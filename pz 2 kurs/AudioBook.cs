using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_2_kurs
{
    class AudioBook : Track
    {
        int prodolshitelnost;

        public AudioBook(string name, string executor, string album, string year, TypeEnum type, int prodolshitelnost, string bitrate = "16000") : base(name, executor, album, year, type, bitrate)
        {
            this.prodolshitelnost = prodolshitelnost;
        }

        public AudioBook(string name, string executor, string album, string year, TypeEnum type) : base(name, executor, album, year, type)
        {
        }


        public new virtual string GetInfo()
        {
            return $"Name = {Name}, Singer = {Singer}, Album = {Album}, Year = {Year}, Bitrate = {Bitrate}, Type = {Type}, prodolshitelnost = {prodolshitelnost}";
        }
    }
}
