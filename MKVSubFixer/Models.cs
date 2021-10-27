using System;
using System.Collections.Generic;
using System.Text;

namespace MKVSubFixer
{
    class Models
    {
        public class Videos
        {
            public string Name { get; set; }
            public List<Tracks> TrackList { get; set; } = new List<Tracks>();
        }
        public class Tracks
        {
            public string Id { get; set; }
            public string Name { get; set; }
            public string Type { get; set; }
            public string Language { get; set; }
            public string Codec { get; set; }
        }
    }
}
