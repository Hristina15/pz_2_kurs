using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2_kurs
{
    class Track
    {
        public Track(string name, string executor, string album, string year, TypeEnum type, string bitrate = "16000")
        {

            if (type == TypeEnum.Aac)
            {
                aacCount++;
            }
            if (type == TypeEnum.Mp3)
            {
                mp3Count++;
            }
            if (type == TypeEnum.Flac)
            {
                flacCount++;
            }

            Singer = executor;
            Name = name;
            Album = album;
            Year = year;
            Bitrate = bitrate;
            Type = type;

        }
        public Track(string name, string executor, string album, string year, TypeEnum type)
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

        public TypeEnum Type { get; set; }


        public static int mp3Count = 0;
        public static int aacCount = 0;
        public static int flacCount = 0;

        public int getFlac() => flacCount;
        public int getAac() => aacCount;
        public int getMp3() => mp3Count;

        public string GetInfo()
        {
            return $"Name = {Name}, Singer = {Singer}, Album = {Album}, Year = {Year}, Bitrate = {Bitrate}, Type = {Type}";
        }

        
    }
}
