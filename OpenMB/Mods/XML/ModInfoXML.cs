﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace OpenMB.Mods.XML
{
    public class ModInfoXML
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Description")]
        public string Description { get; set; }
        [XmlElement("Version")]
        public string Version { get; set; }
        [XmlElement("Thumb")]
        public string Thumb { get; set; }
        [XmlElement("Movie")]
        public string Movie { get; set; }

        [XmlElement("Assembly")]
        public string Assembly { get; set; }
    }
}
