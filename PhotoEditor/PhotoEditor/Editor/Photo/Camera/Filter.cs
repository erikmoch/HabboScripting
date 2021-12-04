using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace PhotoEditor.Editor.Photo.Camera
{
    [DataContract(Name = "filter")]
    public class Filter
    {
        [DataMember(Name = "alpha")]
        public int Alpha { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        public bool Equals(Filter filter)
        {
            return Alpha == filter.Alpha && Name == filter.Name;
        }
    }
}
