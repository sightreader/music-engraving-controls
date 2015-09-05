using Manufaktura.Music.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Manufaktura.Controls.Extensions
{
    public static class XmlExtensions
    {
        public static Nullable<T> ParseAttribute<T>(this XElement element, string name) where T : struct
        {
            var childElement = element.Attributes().FirstOrDefault(d => d.Name == name);
            if (childElement == null) return null;
            return ParseValue<T>(childElement.Value, name);
        }

        public static Nullable<T> ParseChildElement<T>(this XElement element, string name) where T : struct
        {
            var childElement = element.Descendants().FirstOrDefault(d => d.Name == name);
            if (childElement == null) return null;
            return ParseValue<T>(childElement.Value, name);
        }

        public static IEnumerable<Nullable<T>> ParseChildElements<T>(this XElement element, string name) where T : struct
        {
            var childElements = element.Descendants().Where(d => d.Name == name);
            foreach (var el in childElements) yield return ParseValue<T>(el.Value, name);
        }

        public static IEnumerable<string> ParseChildElements(this XElement element, string name)
        {
            var childElements = element.Descendants().Where(d => d.Name == name);
            foreach (var el in childElements) yield return el.Value;
        }

        private static Nullable<T> ParseValue<T>(string value, string name) where T : struct
        {
            if (typeof(T) == typeof(int)) return UsefulMath.TryParseInt(value) as Nullable<T>;
            if (typeof(T) == typeof(double)) return UsefulMath.TryParse(value) as Nullable<T>;
            if (typeof(T) == typeof(DateTime)) return UsefulMath.TryParseDateTime(value) as Nullable<T>;
            throw new NotImplementedException("Type not supported");
        }
    }
}