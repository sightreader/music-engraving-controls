using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Manufaktura.Controls.Winforms.Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MusicXml (*.xml)|*.xml";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MusicXmlParser parser = new MusicXmlParser();
                Score score = parser.Parse(XDocument.Parse(File.ReadAllText(dialog.FileName)));
                noteViewer1.DataSource = score;
                noteViewer1.Refresh();
            }
        }
    }
}
