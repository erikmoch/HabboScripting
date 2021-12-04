using System.Drawing;
using System.Runtime.Serialization;

namespace PhotoEditor.Editor.Photo.Camera
{
    [DataContract(Name = "mask")]
    public class Mask
    {
        [DataMember(IsRequired = false, Name = "flipH", Order = 0)]
        public bool FlipH { get; set; }

        [DataMember(IsRequired = false, Name = "location", Order = 1)]
        public Point Location { get; set; }

        [DataMember(IsRequired = false, Name = "flipV", Order = 2)]
        public bool FlipV { get; set; }

        [DataMember(IsRequired = false, Name = "name", Order = 3)]
        public string Name { get; set; }
    }
}
