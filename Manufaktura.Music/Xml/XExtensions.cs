using System;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Music.Xml
{
    public static class XExtensions
    {
        public static IXHelper IfAttribute(this XElement element, string name)
        {
            if (element == null) return new XAttributeHelper(null);
            var attribute = element.Attributes().FirstOrDefault(d => d.Name == name);
            return new XAttributeHelper(attribute);
        }

        public static IXHelper IfDescendant(this XElement element, string name)
        {
            if (element == null) return new XAttributeHelper(null);
            var descendant = element.Descendants().FirstOrDefault(d => d.Name == name);
            return new XElementHelper(descendant);
        }

        public static void ForEachDescendant(this XElement element, string name, Action<XElementHelper> action)
        {
            if (element == null) return;
            var descendants = element.Descendants().Where(d => d.Name == name);
            foreach (var descendant in descendants) action(new XElementHelper(descendant));
        }

        public static IXHelper IfElement(this XElement element, string name)
        {
            if (element == null) return new XAttributeHelper(null);
            var descendant = element.Elements().FirstOrDefault(d => d.Name == name);
            return new XElementHelper(descendant);
        }

        public static XElement GetElement(this XElement element, string name)
        {
            if (element == null) return null;
            return element.Elements().FirstOrDefault(x => x.Name == name);
        }

        public static XHelperExistsResult IfHasElement(this XElement element, string name)
        {
            var child = element == null ? null : element.Elements().FirstOrDefault(x => x.Name == name);
            return new XHelperExistsResult(child != null, child, child?.Value);
        }
    }
}