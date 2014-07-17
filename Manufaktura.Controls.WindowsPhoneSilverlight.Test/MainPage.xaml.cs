using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Manufaktura.Controls.WindowsPhoneSilverlight.Test.Resources;
using Manufaktura.Controls.Parser;
using Manufaktura.Controls.Model;

namespace Manufaktura.Controls.WindowsPhoneSilverlight.Test
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string scoreXml = @"<?xml version=""1.0"" encoding=""UTF-8"" standalone=""no""?>
<!DOCTYPE score-partwise PUBLIC ""-//Recordare//DTD MusicXML 3.0 Partwise//EN"" ""http://www.musicxml.org/dtds/partwise.dtd"">
<score-partwise version=""3.0"">
  <identification>
    <rights>©</rights>
    <encoding>
      <software>Finale NotePad 2012 for Windows</software>
      <software>Dolet Light for Finale NotePad 2012</software>
      <encoding-date>2014-06-10</encoding-date>
      <supports attribute=""new-system"" element=""print"" type=""yes"" value=""yes""/>
      <supports attribute=""new-page"" element=""print"" type=""yes"" value=""yes""/>
    </encoding>
  </identification>
  <defaults>
    <scaling>
      <millimeters>7.2319</millimeters>
      <tenths>40</tenths>
    </scaling>
    <page-layout>
      <page-height>1545</page-height>
      <page-width>1194</page-width>
      <page-margins type=""both"">
        <left-margin>140</left-margin>
        <right-margin>70</right-margin>
        <top-margin>88</top-margin>
        <bottom-margin>88</bottom-margin>
      </page-margins>
    </page-layout>
    <system-layout>
      <system-margins>
        <left-margin>0</left-margin>
        <right-margin>0</right-margin>
      </system-margins>
      <system-distance>121</system-distance>
      <top-system-distance>70</top-system-distance>
    </system-layout>
    <appearance>
      <line-width type=""stem"">0.7487</line-width>
      <line-width type=""beam"">5</line-width>
      <line-width type=""staff"">0.7487</line-width>
      <line-width type=""light barline"">0.7487</line-width>
      <line-width type=""heavy barline"">5</line-width>
      <line-width type=""leger"">0.7487</line-width>
      <line-width type=""ending"">0.7487</line-width>
      <line-width type=""wedge"">0.7487</line-width>
      <line-width type=""enclosure"">0.7487</line-width>
      <line-width type=""tuplet bracket"">0.7487</line-width>
      <note-size type=""grace"">60</note-size>
      <note-size type=""cue"">60</note-size>
      <distance type=""hyphen"">120</distance>
      <distance type=""beam"">8</distance>
    </appearance>
    <music-font font-family=""Maestro,engraved"" font-size=""20.5""/>
    <word-font font-family=""Times New Roman"" font-size=""10.25""/>
  </defaults>
  <part-list>
    <score-part id=""P1"">
      <part-name>Violin</part-name>
      <part-abbreviation>Vln.</part-abbreviation>
      <score-instrument id=""P1-I1"">
        <instrument-name>SmartMusic SoftSynth 1</instrument-name>
        <instrument-sound>strings.violin</instrument-sound>
        <solo/>
      </score-instrument>
      <midi-instrument id=""P1-I1"">
        <midi-channel>1</midi-channel>
        <midi-bank>15489</midi-bank>
        <midi-program>41</midi-program>
        <volume>80</volume>
        <pan>0</pan>
      </midi-instrument>
    </score-part>
  </part-list>
  <!--=========================================================-->
  <part id=""P1"">
    <measure number=""1"" width=""236"">
      <print>
        <system-layout>
          <system-margins>
            <left-margin>70</left-margin>
            <right-margin>0</right-margin>
          </system-margins>
          <top-system-distance>167</top-system-distance>
        </system-layout>
        <measure-numbering>none</measure-numbering>
      </print>
      <attributes>
        <divisions>2</divisions>
        <key>
          <fifths>-1</fifths>
          <mode>major</mode>
        </key>
        <time>
          <beats>2</beats>
          <beat-type>4</beat-type>
        </time>
        <clef>
          <sign>G</sign>
          <line>2</line>
        </clef>
      </attributes>
      <sound tempo=""120""/>
      <note default-x=""111"">
        <pitch>
          <step>A</step>
          <octave>4</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-60"">down</stem>
        <beam number=""1"">begin</beam>
      </note>
      <note default-x=""111"">
        <chord/>
        <pitch>
          <step>A</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""142"">
        <pitch>
          <step>A</step>
          <octave>4</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-60"">down</stem>
        <beam number=""1"">end</beam>
      </note>
      <note default-x=""142"">
        <chord/>
        <pitch>
          <step>A</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""174"">
        <pitch>
          <step>B</step>
          <alter>-1</alter>
          <octave>4</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-55"">down</stem>
        <beam number=""1"">begin</beam>
      </note>
      <note default-x=""174"">
        <chord/>
        <pitch>
          <step>B</step>
          <alter>-1</alter>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""204"">
        <pitch>
          <step>C</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-50"">down</stem>
        <beam number=""1"">end</beam>
      </note>
      <note default-x=""204"">
        <chord/>
        <pitch>
          <step>C</step>
          <octave>6</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
    </measure>
    <!--=======================================================-->
    <measure number=""2"" width=""135"">
      <note default-x=""16"">
        <pitch>
          <step>C</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-60"">down</stem>
        <beam number=""1"">begin</beam>
      </note>
      <note default-x=""16"">
        <chord/>
        <pitch>
          <step>C</step>
          <octave>6</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""46"">
        <pitch>
          <step>G</step>
          <octave>4</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-65"">down</stem>
        <beam number=""1"">end</beam>
      </note>
      <note default-x=""46"">
        <chord/>
        <pitch>
          <step>G</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""75"">
        <pitch>
          <step>A</step>
          <octave>4</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-60"">down</stem>
        <beam number=""1"">begin</beam>
      </note>
      <note default-x=""75"">
        <chord/>
        <pitch>
          <step>A</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""105"">
        <pitch>
          <step>B</step>
          <alter>-1</alter>
          <octave>4</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-55"">down</stem>
        <beam number=""1"">end</beam>
      </note>
      <note default-x=""105"">
        <chord/>
        <pitch>
          <step>B</step>
          <alter>-1</alter>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
    </measure>
    <!--=======================================================-->
    <measure number=""3"" width=""141"">
      <note default-x=""17"">
        <pitch>
          <step>B</step>
          <alter>-1</alter>
          <octave>4</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-55"">down</stem>
        <beam number=""1"">begin</beam>
      </note>
      <note default-x=""17"">
        <chord/>
        <pitch>
          <step>B</step>
          <alter>-1</alter>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""47"">
        <pitch>
          <step>B</step>
          <alter>-1</alter>
          <octave>4</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-55"">down</stem>
        <beam number=""1"">end</beam>
      </note>
      <note default-x=""47"">
        <chord/>
        <pitch>
          <step>B</step>
          <alter>-1</alter>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""78"">
        <pitch>
          <step>C</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-50"">down</stem>
        <beam number=""1"">begin</beam>
      </note>
      <note default-x=""78"">
        <chord/>
        <pitch>
          <step>C</step>
          <octave>6</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""109"">
        <pitch>
          <step>D</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-45"">down</stem>
        <beam number=""1"">end</beam>
      </note>
      <note default-x=""109"">
        <chord/>
        <pitch>
          <step>D</step>
          <octave>6</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
    </measure>
    <!--=======================================================-->
    <measure number=""4"" width=""141"">
      <note default-x=""16"">
        <pitch>
          <step>D</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-55"">down</stem>
        <beam number=""1"">begin</beam>
      </note>
      <note default-x=""16"">
        <chord/>
        <pitch>
          <step>D</step>
          <octave>6</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""47"">
        <pitch>
          <step>A</step>
          <octave>4</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-60"">down</stem>
        <beam number=""1"">end</beam>
      </note>
      <note default-x=""47"">
        <chord/>
        <pitch>
          <step>A</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""79"">
        <pitch>
          <step>B</step>
          <alter>-1</alter>
          <octave>4</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-55"">down</stem>
        <beam number=""1"">begin</beam>
      </note>
      <note default-x=""79"">
        <chord/>
        <pitch>
          <step>B</step>
          <alter>-1</alter>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""109"">
        <pitch>
          <step>C</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-50"">down</stem>
        <beam number=""1"">end</beam>
      </note>
      <note default-x=""109"">
        <chord/>
        <pitch>
          <step>C</step>
          <octave>6</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
    </measure>
    <!--=======================================================-->
    <measure number=""5"" width=""141"">
      <note default-x=""16"">
        <pitch>
          <step>F</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-35"">down</stem>
        <beam number=""1"">begin</beam>
      </note>
      <note default-x=""16"">
        <chord/>
        <pitch>
          <step>F</step>
          <octave>6</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""47"">
        <pitch>
          <step>F</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-35"">down</stem>
        <beam number=""1"">end</beam>
      </note>
      <note default-x=""47"">
        <chord/>
        <pitch>
          <step>F</step>
          <octave>6</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""78"">
        <pitch>
          <step>E</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-40"">down</stem>
        <beam number=""1"">begin</beam>
      </note>
      <note default-x=""78"">
        <chord/>
        <pitch>
          <step>E</step>
          <octave>6</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""109"">
        <pitch>
          <step>D</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-42.5"">down</stem>
        <beam number=""1"">end</beam>
      </note>
      <note default-x=""109"">
        <chord/>
        <pitch>
          <step>D</step>
          <octave>6</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
    </measure>
    <!--=======================================================-->
    <measure number=""6"" width=""119"">
      <note default-x=""14"">
        <pitch>
          <step>D</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-45"">down</stem>
        <beam number=""1"">begin</beam>
      </note>
      <note default-x=""14"">
        <chord/>
        <pitch>
          <step>G</step>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""40"">
        <pitch>
          <step>B</step>
          <alter>-1</alter>
          <octave>5</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem default-y=""-40"">down</stem>
        <beam number=""1"">end</beam>
      </note>
      <note default-x=""40"">
        <chord/>
        <pitch>
          <step>D</step>
          <octave>6</octave>
        </pitch>
        <duration>1</duration>
        <voice>1</voice>
        <type>eighth</type>
        <stem>down</stem>
      </note>
      <note default-x=""67"">
        <rest/>
        <duration>2</duration>
        <voice>1</voice>
        <type>quarter</type>
      </note>
      <barline location=""right"">
        <bar-style>light-heavy</bar-style>
      </barline>
    </measure>
  </part>
  <!--=========================================================-->
</score-partwise>
";

            MusicXmlParser parser = new MusicXmlParser();
            Score score = parser.Parse(scoreXml);


            noteViewer1.DataContext = score;
            noteViewer1.RefreshView();
            noteViewer1.InvalidateArrange();
            //noteViewer2.DataContext = score;
            noteViewer2.RefreshView();
            //noteViewer3.DataContext = score;
            //noteViewer3.RefreshView();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}