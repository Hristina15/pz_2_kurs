using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2_kurs
{
    class Track
    {
        public Track(string name, string executor, string album, string year, string bitrate, string type = "музыка")
        {
            Singer = executor;
            Name = name;
            Album = album;
            Year = year;
            Bitrate = bitrate;
            Type = type;

        }
        public Track(string name, string executor, string album, string year, string type)
        {
            Singer = executor;
            Name = name;
            Album = album;
            Year = year;
            Bitrate = "16000";
            Type = type;

        }
        public string Singer { get; set; }
        public string Name { get; set; }
        public string Album { get; set; }
        public string Year { get; set; }

        public string Bitrate { get; set; }

        public string Type { get; set; }

        public string GetInfo()
        {
            return $"Name = {Name}, Singer = {Singer}, Album = {Album}, Year = {Year}, Bitrate = {Bitrate}, Type = {Type}";
        }
    }
}
