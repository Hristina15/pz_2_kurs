using System;

namespace pz_2_kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Track tra1 = new Track("name", "executor", "album", "year", TypeEnum.Aac, "16000");
            Track tra2 = new Track("name", "executor", "album", "year", TypeEnum.Mp3, "32000");
            Track tra3 = new Track("name", "executor", "album", "year", TypeEnum.Flac, "28000");
            Track tra4 = new Track("name", "executor", "album", "year", TypeEnum.Aac, "48000");

            Console.WriteLine(tra1.GetInfo());
            Console.WriteLine(tra2.GetInfo());
            Console.WriteLine(tra3.GetInfo());
            Console.WriteLine(tra4.GetInfo());
        }
    }
    public enum TypeEnum
    {
        Mp3,
        Aac,
        Flac
    }
}
