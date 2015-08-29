using Manufaktura.Controls.Primitives;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Linq;
using Manufaktura.Controls.Model;

namespace Manufaktura.Orm.UnitTests.Rendering
{
    public class ScoreRenderingTestResultsRepository : IScoreRenderingTestResultsRepository
    {
        private string dataPath = string.Empty;

        private List<ScoreRenderingTestEntry> elements = new List<ScoreRenderingTestEntry>();

        public ScoreRenderingTestResultsRepository(string folderPath)
        {
            dataPath = folderPath;
        }

        public IEnumerator<ScoreRenderingTestEntry> GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return elements.GetEnumerator();
        }

        public void Persist(string fileName)
        {
            if (!Directory.Exists(dataPath)) Directory.CreateDirectory(dataPath);

            using (var writer = XmlWriter.Create(Path.Combine(dataPath, fileName), new XmlWriterSettings { Indent = true, Encoding = Encoding.UTF8 }))
            {
                writer.WriteStartElement("TestResults");
                foreach (var element in elements)
                {
                    writer.WriteStartElement("Result");
                    writer.WriteStartElement("Type");
                    writer.WriteValue(element.Type.ToString());
                    writer.WriteEndElement();
                    writer.WriteStartElement("LocationX");
                    writer.WriteValue(element.Location.X);
                    writer.WriteEndElement();
                    writer.WriteStartElement("LocationY");
                    writer.WriteValue(element.Location.Y);
                    writer.WriteEndElement();
                    writer.WriteStartElement("SizeX");
                    writer.WriteValue(element.Size.X);
                    writer.WriteEndElement();
                    writer.WriteStartElement("SizeY");
                    writer.WriteValue(element.Size.Y);
                    writer.WriteEndElement();
                    foreach (var property in element.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                        .Where(p => p.PropertyType != typeof(Point) && p.PropertyType != typeof(MusicalSymbolType)))
                    {
                        var value = property.GetValue(element);
                        if (value == null) continue;
                        writer.WriteStartElement(property.Name);
                        writer.WriteValue(value);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
            }

        }

        public void Put(ScoreRenderingTestEntry entry)
        {
            elements.Add(entry);
        }


        public void Load(string fileName)
        {
            
        }
    }
}