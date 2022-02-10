using System;

namespace pz_2_kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Track tra1 = new Track("name", "executor", "album", "year", "bitrate");
            Track tra2 = new Track("name", "executor", "album", "year", "bitrate", "type");
            Track tra3 = new Track("name", "executor", "album", "year", "bitrate", "type");
            Track tra4 = new Track("name", "executor", "album", "year", "type");

            Console.WriteLine(tra1.GetInfo());
            Console.WriteLine(tra2.GetInfo());
            Console.WriteLine(tra3.GetInfo());
            Console.WriteLine(tra4.GetInfo());
        }
    }
}
