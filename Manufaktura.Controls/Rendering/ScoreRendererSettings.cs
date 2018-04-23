using Manufaktura.Controls.Model.Fonts;
using Manufaktura.Controls.Model.SMuFL;
using Manufaktura.Controls.Primitives;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace Manufaktura.Controls.Rendering
{
    /// <summary>
    /// Initial settings of score renderer.
    /// </summary>
    public class ScoreRendererSettings
    {
        private IMusicFont currentFont;

        /// <summary>
        /// Initializes a new instance of ScoreRendererSettings
        /// </summary>
        public ScoreRendererSettings()
        {
            RenderingMode = ScoreRenderingModes.Panorama;
            IgnoreCustomElementPositions = false;
            CustomElementPositionRatio = 0.7d;
            PageWidth = 200;
            PaddingTop = 20;
            LineSpacing = 6;
            DefaultColor = Color.Black;
            CurrentFont = new PolihymniaFont();
        }

        /// <summary>
        /// Key mapping for current font
        /// </summary>
        public IMusicFont CurrentFont { get => currentFont; set { currentFont = value; IsSMuFLFont = value is SMuFLMusicFont; } }

        /// <summary>
        /// Page to display if renderer is in SinglePage mode.
        /// </summary>
        public int CurrentPage { get; set; }

        public SMuFLFontMetadata CurrentSMuFLMetadata { get; set; }
        public double CustomElementPositionRatio { get; set; }
        public double DefaultBarlineThickness { get; set; } = 0.7;
        public double DefaultBeamThickness { get; set; } = 2.6;

        /// <summary>
        /// Default color
        /// </summary>
        public Color DefaultColor { get; set; }

        public double DefaultStaffLineThickness { get; set; } = 0.5;
        public double DefaultStemThickness { get; set; } = 1;
        public double DefaultTupletBracketThickness { get; set; } = 1;

        /// <summary>
        /// True, to ignore element positions which are implicitly set in MusicXml file
        /// </summary>
        public bool IgnoreCustomElementPositions { get; set; }

        public bool IsSMuFLFont { get; private set; }

        /// <summary>
        /// Default line spacing
        /// </summary>
        public int LineSpacing { get; private set; }

        /// <summary>
        /// Default padding top
        /// </summary>
        public int PaddingTop { get; private set; }

        /// <summary>
        /// Default page width
        /// </summary>
        public double PageWidth { get; set; }

        /// <summary>
        /// Rendering moed
        /// </summary>
        public ScoreRenderingModes RenderingMode { get; set; }

        public void LoadSMuFLMetadata(string metadataJson)
        {
            CurrentSMuFLMetadata = JsonConvert.DeserializeObject<SMuFLFontMetadata>(metadataJson);
            CurrentFont = new SMuFLMusicFont();
        }

        public void LoadSMuFLMetadata(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                var text = reader.ReadToEnd();
                LoadSMuFLMetadata(text);
            }
        }

        public async Task LoadSMuFLMetadataAsync(string metadataJson)
        {
            CurrentSMuFLMetadata = await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<SMuFLFontMetadata>(metadataJson));
            CurrentFont = new SMuFLMusicFont();
        }

        public async Task LoadSMuFLMetadataAsync(Stream stream)
        {
            using (var reader = new StreamReader(stream))
            {
                var text = await reader.ReadToEndAsync();
                await LoadSMuFLMetadataAsync(text);
            }
        }

        public virtual void SetPolihymniaFont()
        {
            CurrentFont = new PolihymniaFont();
            CurrentSMuFLMetadata = null;
        }
    }
}