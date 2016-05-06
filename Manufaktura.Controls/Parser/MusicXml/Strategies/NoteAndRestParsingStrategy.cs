using Manufaktura.Controls.Model;
using Manufaktura.Controls.Model.Builders;
using Manufaktura.Music.Model;
using Manufaktura.Music.Xml;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
	internal class NoteAndRestParsingStrategy : MusicXmlParsingStrategy
	{
		public override string ElementName
		{
			get { return "note"; }
		}

		public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
		{
			var builder = new NoteOrRestBuilder(state);

			element.IfAttribute("default-x").HasValue<double>().Then(m => builder.DefaultX = m);
			element.IfAttribute("measure").HasValue("yes").Then(m => builder.FullMeasure = true);
			element.IfAttribute("print-object").HasValue(new Dictionary<string, bool> {
				{"yes", true}, {"no", false}}).Then(m => builder.IsVisible = m);
			element.IfAttribute("size").HasValue("cue").Then(() => builder.IsCueNote = true);
			element.IfElement("staff").HasValue<int>().Then(m => builder.Staff = staff.Score.Staves.ElementAt(m - 1)); //TODO: Sprawdzić czy staff to numer liczony od góry strony czy numer w obrębie parta
			element.IfElement("type").HasValue(new Dictionary<string, RhythmicDuration> {
				 { "whole", RhythmicDuration.Whole },
				 { "half", RhythmicDuration.Half },
				 { "quarter",  RhythmicDuration.Quarter },
				 { "eighth", RhythmicDuration.Eighth },
				 { "16th",  RhythmicDuration.Sixteenth },
				 { "32nd",  RhythmicDuration.D32nd },
				 { "64th",  RhythmicDuration.D64th },
				 { "128th",  RhythmicDuration.D128th }}).Then(m => builder.BaseDuration = m);

			element.IfElement("voice").HasValue<int>().Then(m => builder.Voice = m);
			element.IfElement("grace").Exists().Then(() => builder.IsGraceNote = true);
			element.IfElement("chord").Exists().Then(() => builder.IsChordElement = true);
			element.IfElement("accidental").HasValue("natural").Then(() => builder.HasNatural = true);
			element.IfElement("rest").Exists().Then(() => builder.IsRest = true);
			element.ForEachDescendant("dot", f => f.Exists().Then(() => builder.NumberOfDots++));

			var pitchElement = element.IfElement("pitch").Exists().ThenReturnResult();
			pitchElement.IfElement("step").HasAnyValue().Then(v => builder.Step = v);
			pitchElement.IfElement("octave").HasValue<int>().Then(v => builder.Octave = v);
			pitchElement.IfElement("alter").HasValue<int>().Then(v => builder.Alter = v);

			var tieElements = element.Elements().Where(e => e.Name == "tie");
			foreach (var tieElement in tieElements)
			{
				tieElement.IfAttribute("type").HasValue("start").Then(v =>
				{
					if (builder.TieType == NoteTieType.Stop) builder.TieType = NoteTieType.StopAndStartAnother;
					else builder.TieType = NoteTieType.Start;
				}).Otherwise(() => builder.TieType = NoteTieType.Stop);
			}

			element.IfElement("stem").HasValue("down")
				.Then(() => builder.StemDirection = VerticalDirection.Down)
				.Otherwise(() => builder.StemDirection = VerticalDirection.Up);
			element.GetElement("stem").IfAttribute("default-y").HasValue<float>().Then(v =>
				{
					builder.StemDefaultY = v;
					builder.CustomStemEndPosition = true;
				});

			element.ForEachDescendant("beam", h => h.HasValue(new Dictionary<string, NoteBeamType> {
				{"begin", NoteBeamType.Start},
				{"end", NoteBeamType.End},
				{"continue", NoteBeamType.Continue},
				{"forward hook", NoteBeamType.ForwardHook},
				{"backward hook", NoteBeamType.BackwardHook}
			}).Then(v => builder.BeamList.Add(v)));

			var notationsNode = element.GetElement("notations");
			var tupletNode = notationsNode.GetElement("tuplet");
			tupletNode.IfAttribute("type").HasValue(new Dictionary<string, TupletType> {
						{"start", TupletType.Start},
						{"stop", TupletType.Stop},
					}).Then(v => builder.Tuplet = v);
			tupletNode.IfAttribute("placement").HasValue(new Dictionary<string, VerticalPlacement> {
						{"above", VerticalPlacement.Above},
						{"below", VerticalPlacement.Below},
					}).Then(v => builder.TupletPlacement = v);

			notationsNode.IfElement("fermata").HasAnyValue().Then(() => builder.HasFermataSign = true);
			notationsNode.IfElement("sound").Exists().Then(e => e.IfAttribute("dynamics").HasValue<int>().Then(v => state.CurrentDynamics = v));

			notationsNode.IfHasElement("dynamics").Then(d =>
			{
				var dir = new Direction();
				d.IfAttribute("default-y").HasValue<int>().Then(v =>
				{
					dir.DefaultYPosition = v;
					dir.Placement = DirectionPlacementType.Custom;
				});
				d.IfAttribute("placement").HasValue(new Dictionary<string, DirectionPlacementType>
				{
					{"above", DirectionPlacementType.Above},
					{"below", DirectionPlacementType.Below}
				}).Then(v =>
				{
					if (dir.Placement != DirectionPlacementType.Custom) dir.Placement = v;
				});
				foreach (XElement dynamicsType in d.Elements())
				{
					dir.Text = dynamicsType.Name.LocalName;
				}
				staff.Elements.Add(dir);
			});

			notationsNode.IfHasElement("articulations").Then(d =>
			{
				d.IfElement("staccato").HasAnyValue().Then(() => builder.Articulation = ArticulationType.Staccato);
				d.IfElement("accent").HasAnyValue().Then(() => builder.Articulation = ArticulationType.Accent);
				d.IfAttribute("placement").HasValue(new Dictionary<string, VerticalPlacement> {
						{"above", VerticalPlacement.Above},
						{"below", VerticalPlacement.Below},
					}).Then(v => builder.ArticulationPlacement = v);
			});

			var ornamentsNode = notationsNode.GetElement("ornaments");
			ornamentsNode.GetElement("trill-mark").IfAttribute("placement").HasValue(new Dictionary<string, NoteTrillMark> {
				{"above", NoteTrillMark.Above},
				{"below", NoteTrillMark.Below}
			}).Then(v => builder.TrillMark = v);
			ornamentsNode.IfElement("tremolo").HasValue<int>().Then(v => builder.TremoloLevel = v);

			var invMordentNode = ornamentsNode
				.IfElement("inverted-mordent")
				.Exists()
				.Then(e => builder.Mordent = new Mordent() { IsInverted = true })
				.AndReturnResult();
			invMordentNode.IfAttribute("placement").HasValue(new Dictionary<string, VerticalPlacement> {
				{"above", VerticalPlacement.Above},
				{"below", VerticalPlacement.Below}
			}).Then(v => builder.Mordent.Placement = v);
			invMordentNode.IfAttribute("default-x").HasValue<double>().Then(v => builder.Mordent.DefaultXPosition = v);
			invMordentNode.IfAttribute("default-y").HasValue<double>().Then(v => builder.Mordent.DefaultYPosition = v);

			var slurNode = notationsNode.IfElement("slur").Exists().Then(s => builder.Slur = new Slur()).AndReturnResult();
			var number = slurNode.IfAttribute("number").HasValue<int>().Then(v => { }).AndReturnResult();
			if (number < 2)
			{
				slurNode.IfAttribute("type").HasValue(new Dictionary<string, NoteSlurType> {
					{"start", NoteSlurType.Start},
					{"stop", NoteSlurType.Stop}
				}).Then(v => builder.Slur.Type = v);
				slurNode.IfAttribute("placement").HasValue(new Dictionary<string, VerticalPlacement> {
					{"above", VerticalPlacement.Above},
					{"below", VerticalPlacement.Below}
				}).Then(v => builder.Slur.Placement = v);
			}

			foreach (var lNode in element.Elements().Where(n => n.Name == "lyric"))
			{
				Lyrics lyricsInstance = new Lyrics();
				Lyrics.Syllable syllable = new Lyrics.Syllable();
				bool isSylabicSet = false;
				bool isTextSet = false;
				lNode.IfAttribute("default-y").HasValue<double>().Then(v => lyricsInstance.DefaultYPosition = v);
				lNode.IfElement("syllabic").HasValue(new Dictionary<string, SyllableType> {
					{"begin", SyllableType.Begin},
					{"middle", SyllableType.Middle},
					{"end", SyllableType.End},
					{"single", SyllableType.Single}
					}).Then(v =>
					{
						syllable.Type = v;
						isSylabicSet = true;
					});
				lNode.IfElement("text").HasAnyValue().Then(v =>
				{
					syllable.Text = v;
					isTextSet = true;
				});
				lNode.IfElement("elision").HasAnyValue().Then(v => syllable.ElisionMark = v);

				if (isSylabicSet && isTextSet)
				{
					lyricsInstance.Syllables.Add(syllable);
					syllable = new Lyrics.Syllable();
					isSylabicSet = false;
					isTextSet = false;
				}
				builder.Lyrics.Add(lyricsInstance);
			}

			if (builder.BeamList.Count == 0) builder.BeamList.Add(NoteBeamType.Single);

			var noteOrRest = builder.Build();

			var correctStaff = noteOrRest.Staff ?? staff;
			correctStaff.Elements.Add(noteOrRest);
		}
	}
}