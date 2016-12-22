using Manufaktura.Controls.Model;
using Manufaktura.Controls.Primitives;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Manufaktura.UnitTests.Rendering
{
    public class ScoreRenderingTestResultsRepository : IScoreRenderingTestResultsRepository
    {
        private string dataPath = string.Empty;

        private List<ScoreRenderingTestEntry> elements = new List<ScoreRenderingTestEntry>();

        public string DataPath
        {
            get { return dataPath; }
        }

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

        public void Load(string fileName)
        {
            var document = XDocument.Load(Path.Combine(dataPath, fileName));
            elements.Clear();
            foreach (var resultNode in document.Descendants().Where(d => d.Name == "Result"))
            {
                var entry = new ScoreRenderingTestEntry();
                var x = resultNode.Elements().FirstOrDefault(d => d.Name == "LocationX");
                var y = resultNode.Elements().FirstOrDefault(d => d.Name == "LocationY");
                if (x != null && y != null)
                {
                    entry.Location = new Point(double.Parse(x.Value, CultureInfo.InvariantCulture), double.Parse(y.Value, CultureInfo.InvariantCulture));
                }
                x = resultNode.Elements().FirstOrDefault(d => d.Name == "SizeX");
                y = resultNode.Elements().FirstOrDefault(d => d.Name == "SizeY");
                if (x != null && y != null)
                {
                    entry.Size = new Point(double.Parse(x.Value, CultureInfo.InvariantCulture), double.Parse(y.Value, CultureInfo.InvariantCulture));
                }
                x = resultNode.Elements().FirstOrDefault(d => d.Name == "Type");
                if (x != null) entry.Type = x.Value;
                x = resultNode.Elements().FirstOrDefault(d => d.Name == "StaffNo");
                if (x != null) entry.StaffNo = int.Parse(x.Value);
                x = resultNode.Elements().FirstOrDefault(d => d.Name == "StaffIndex");
                if (x != null) entry.StaffIndex = int.Parse(x.Value);
                x = resultNode.Elements().FirstOrDefault(d => d.Name == "Text");
                if (x != null) entry.Text = x.Value;
                elements.Add(entry);
            }
            
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
                        .Where(p => p.PropertyType != typeof(Point)))
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
    }
}