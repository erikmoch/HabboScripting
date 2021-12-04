using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Serialization;

namespace PhotoEditor.Editor.Photo.Camera.Layers
{
    [DataContract(Name = "plane")]
    public class Plane
    {
        private List<Point> _cornerPoints;
        private List<Mask> _masks;
        private List<TexCol> _texCols;

        [DataMember(Name = "cornerPoints", Order = 2)]
        public List<Point> CornerPoints
        {
            get
            {
                return _cornerPoints ?? (_cornerPoints = new List<Point>());
            }
        }

        [DataMember(Name = "bottomAligned", Order = 4)]
        public bool IsBottomAligned { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "masks", Order = 5)]
        public List<Mask> Masks
        {
            get
            {
                return _masks ?? (_masks = new List<Mask>());
            }
        }

        [DataMember(Name = "texCols", Order = 3)]
        public List<TexCol> TexCols
        {
            get
            {
                return _texCols ?? (_texCols = new List<TexCol>());
            }
        }

        [DataMember(Name = "z", Order = 1)]
        public double Z { get; set; }

        [DataMember(Name = "color", Order = 0)]
        public int Color { get; set; }

        public bool Equals(Plane plane)
        {
            return CornerPoints == plane.CornerPoints && IsBottomAligned == plane.IsBottomAligned && (Masks == plane.Masks && TexCols == plane.TexCols) && Color == plane.Color;
        }
    }
}
