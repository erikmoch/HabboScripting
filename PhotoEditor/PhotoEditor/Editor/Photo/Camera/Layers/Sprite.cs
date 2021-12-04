using System.Runtime.Serialization;

namespace PhotoEditor.Editor.Photo.Camera.Layers
{
    [DataContract(Name = "sprite")]
    public class Sprite
    {
        [DataMember(IsRequired = false, Name = "flipH")]
        public bool FlipHorizontally { get; set; }

        [DataMember(Name = "x", Order = 0)]
        public int X { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "width", Order = 1)]
        public int Width { get; set; }

        [DataMember(Name = "y", Order = 2)]
        public int Y { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "height", Order = 3)]
        public int Height { get; set; }

        [DataMember(Name = "z", Order = 4)]
        public double Z { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "frame", Order = 5)]
        public bool Frame { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "skew", Order = 6)]
        public double Skew { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "alpha", Order = 7)]
        public int Alpha { get; set; }

        [DataMember(IsRequired = false, Name = "color", Order = 8)]
        public int Color { get; set; }

        [DataMember(Name = "name", Order = 9)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "blendMode")]
        public string BlendMode { get; set; }

        public bool Equals(Sprite sprite)
        {
            return FlipHorizontally == sprite.FlipHorizontally && X == sprite.X && (Width == sprite.Width && Y == sprite.Y) && (Height == sprite.Height && Frame == sprite.Frame && (Skew == sprite.Skew && Alpha == sprite.Alpha)) && (Color == sprite.Color && Name == sprite.Name) && BlendMode == sprite.BlendMode;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
