using System;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Music.Xml
{
    public static class XExtensions
    {
        public static IXHelper IfAttribute(this XElement element, string name)
        {
            var attribute = element.Attributes().FirstOrDefault(d => d.Name == name);
            return new XAttributeHelper(attribute);
        }

        public static IXHelper IfDescendant(this XElement element, string name)
        {
            var descendant = element.Descendants().FirstOrDefault(d => d.Name == name);
            return new XElementHelper(descendant);
        }

        public static void ForEachDescendant(this XElement element, string name, Action<XElementHelper> action)
        {
            var descendants = element.Descendants().Where(d => d.Name == name);
            foreach (var descendant in descendants) action(new XElementHelper(descendant));
        }

        public static IXHelper IfElement(this XElement element, string name)
        {
            var descendant = element.Elements().FirstOrDefault(d => d.Name == name);
            return new XElementHelper(descendant);
        }
    }
}