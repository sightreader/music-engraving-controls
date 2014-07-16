using Manufaktura.Controls.Model;
using Manufaktura.Controls.Parser;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Manufaktura.Controls.WPF.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MusicXml (*.xml)|*.xml";
            if (dialog.ShowDialog().Value)
            {
                MusicXmlParser parser = new MusicXmlParser();
                Score score = parser.Parse(File.ReadAllText(dialog.FileName));
                noteViewer1.DataContext = score;
                noteViewer2.DataContext = score;
                noteViewer3.DataContext = score;
            }
        }
    }
}
