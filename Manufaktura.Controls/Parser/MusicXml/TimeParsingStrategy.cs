﻿using Manufaktura.Controls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Manufaktura.Controls.Parser.MusicXml
{
    class TimeParsingStrategy : MusicXmlParsingStrategy
    {
        public override string ElementName
        {
            get { return "time"; }
        }

        public override void ParseElement(MusicXmlParserState state, Staff staff, XElement element)
        {
            uint numberOfBeats = 4;
            uint beatType = 4;
            TimeSignatureType sType = TimeSignatureType.Numbers;
            foreach (XElement timeAttribute in element.Elements())
            {
                if (timeAttribute.Name == "beats")
                    numberOfBeats = Convert.ToUInt32(timeAttribute.Value);
                if (timeAttribute.Name == "beat-type")
                    beatType = Convert.ToUInt32(timeAttribute.Value);
            }
            if (element.Attributes().Count() > 0)
            {
                foreach (XAttribute a in element.Attributes())
                {
                    if (a.Name == "symbol")
                    {
                        if (a.Value == "common")
                            sType = TimeSignatureType.Common;
                        else if (a.Value == "cut")
                            sType = TimeSignatureType.Cut;
                    }
                }
            }
            staff.Elements.Add(new TimeSignature(sType, numberOfBeats, beatType));
        }
    }
}