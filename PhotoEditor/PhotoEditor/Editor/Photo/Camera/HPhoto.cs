using PhotoEditor.Editor.Photo.Camera.Layers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace PhotoEditor.Editor.Photo.Camera
{
    [DataContract]
    public class HPhoto
    {
        private static readonly DataContractJsonSerializer _serializer = new DataContractJsonSerializer(typeof(HPhoto));
        private static readonly DateTime _unixEpoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private long _timestamp;
        private List<Plane> _planes;
        private List<Sprite> _sprites;
        private Modifiers _modifiers;
        private List<Filter> _filters;

        [DataMember(Name = "planes", Order = 0)]
        public List<Plane> Planes
        {
            get
            {
                return _planes ?? (_planes = new List<Plane>());
            }
            set
            {
                _planes = value;
            }
        }

        [DataMember(Name = "sprites", Order = 1)]
        public List<Sprite> Sprites
        {
            get
            {
                return _sprites ?? (_sprites = new List<Sprite>());
            }
            set
            {
                _sprites = value;
            }
        }

        [DataMember(Name = "modifiers", Order = 2)]
        public Modifiers Modifiers
        {
            get
            {
                return _modifiers ?? (_modifiers = new Modifiers());
            }
            set
            {
                _modifiers = value;
            }
        }

        [DataMember(Name = "filters", Order = 3)]
        public List<Filter> Filters
        {
            get
            {
                return _filters ?? (_filters = new List<Filter>());
            }
            set
            {
                _filters = value;
            }
        }

        [DataMember(Name = "roomid", Order = 4)]
        public int RoomId { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "zoom", Order = 5)]
        public int Zoom { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "status", Order = 6)]
        public long Status { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "timestamp", Order = 7)]
        public long Timestamp { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "checksum", Order = 8)]
        public long Checksum { get; set; }

        private long GetStatus(ref long mod)
        {
            _timestamp -= mod = _timestamp % 100L;
            return _timestamp / 100L % 23L;
        }

        private long GetChecksum(long mod, long key)
        {
            return (mod + 13L) * (key + 29L);
        }

        private long GetTimestamp(string blob, long key)
        {
            return _timestamp + Calculate(Encoding.Default.GetBytes(blob), key, RoomId);
        }

        private long Calculate(byte[] data, long key, int roomId)
        {
            long num1 = key;
            long num2 = (long)roomId;
            foreach (byte num3 in data)
            {
                num1 = (num1 + (long)num3) % (long)byte.MaxValue;
                num2 = (num1 + num2) % (long)byte.MaxValue;
            }
            return (num1 + num2) % 100L;
        }

        public string ToJson()
        {
            string str = string.Empty;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                HPhoto._serializer.WriteObject((Stream)memoryStream, (object)this);
                str = Encoding.UTF8.GetString(memoryStream.ToArray());
                str = str.Remove(str.Length - 1, 1);
            }
            return string.Format("{0}}}", (object)str);
        }

        public List<long> getSetStatusTimestampChecksum(bool genstatus = true, bool gentimestamp = true, bool genchecksum = true, bool customstatus = false, bool customtimestamp = false, bool customchecksum = false, long status = 0, long timestamp = 0, long checksum = 0)
        {
            List<long> longList = new List<long>();
            HPhoto hphoto = new HPhoto()
            {
                Filters = Filters,
                Modifiers = Modifiers,
                Planes = Planes,
                RoomId = RoomId,
                Sprites = Sprites,
                Zoom = Zoom
            };
            string str = string.Empty;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                HPhoto._serializer.WriteObject((Stream)memoryStream, (object)hphoto);
                str = Encoding.UTF8.GetString(memoryStream.ToArray());
                str = str.Remove(str.Length - 1, 1);
            }
            _timestamp = (long)(DateTime.UtcNow - HPhoto._unixEpoch).TotalMilliseconds;
            long mod = 0;
            if (!customstatus)
                status = genstatus ? GetStatus(ref mod) : Status;
            longList.Add(status);
            string blob = str + ",\"status\":" + (object)status;
            long key = ((long)blob.Length + _timestamp / 100L * 17L) % 1493L;
            if (!customstatus)
            {
                if (genstatus)
                    timestamp = GetTimestamp(blob, key);
                else
                    status = Status;
            }
            longList.Add(timestamp);
            if (!customstatus)
            {
                if (genstatus)
                    checksum = GetChecksum(mod, key);
                else
                    status = Status;
            }
            longList.Add(checksum);
            return longList;
        }

        public void Save(string path)
        {
            File.WriteAllText(path, ToJson());
        }

        public static HPhoto Load(string path)
        {
            using (FileStream fileStream = File.Open(path, FileMode.Open))
                return (HPhoto)HPhoto._serializer.ReadObject((Stream)fileStream);
        }

        public static HPhoto Create(string json)
        {
            using (MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
                return (HPhoto)HPhoto._serializer.ReadObject((Stream)memoryStream);
        }
    }
}
