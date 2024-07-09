using System.Xml.Serialization;

namespace NP.Ava.Visuals.DG.Behaviors
{
    public class ColumnSerializationData
    {
        [XmlAttribute]
        public string? HeaderId { get; set; }

        [XmlAttribute]
        public bool IsVisible { get; set; }

        [XmlAttribute]
        public string? WidthStr { get; set; }
    }
}
