using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvijum1.Klase
{
    [Serializable]
    public class Knjiga : ISerializable
    {
        public static int id = 1;
        private int idd;
        public int Id
        {
            get
            {
                return idd;
            }
            set
            {
                idd = value;
            }
        }
        public string Naslov { get; set; }
        public string Autor { get; set; }
        public int GodinaIzdanja { get; set; }
        public string Zanrovi { get; set; }
        public string Ocene { get; set; }

        public Knjiga(string naslov, string autor, int godinaizdanja, string zanrovi, string ocene)
        {
            idd = id++;
            Naslov = naslov;
            Autor = autor;
            GodinaIzdanja = godinaizdanja;
            Zanrovi = zanrovi;
            Ocene = ocene;
        }

        public Knjiga() : this("", "", 0, "", "") { }

        public double ProsecnaOcena()
        {
            string[] ocene = Ocene.Split(',');
            double br_ocena = 0;
            double zbir_ocena = 0;
            foreach (var ocena in ocene)
            {
                var ocenaint = int.Parse(ocena);
                br_ocena += 1;
                zbir_ocena += ocenaint;
            }
            return Math.Round((zbir_ocena / br_ocena), 2);
        }

        public override string ToString()
        {
            return $"{Id} {Naslov} {Autor}, {GodinaIzdanja}. | Zanrovi: {Zanrovi}, Prosecna ocena: {ProsecnaOcena()}";
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Naslov", Naslov);
            info.AddValue("Autor", Autor);
            info.AddValue("GodinaIzdanja", GodinaIzdanja);
            info.AddValue("Zanrovi", Zanrovi);
            info.AddValue("Ocene", Ocene);
        }

        public Knjiga(SerializationInfo info, StreamingContext context)
        {
            Naslov = (string)info.GetValue("Naslov", typeof(string));
            Autor = (string)info.GetValue("Autor", typeof(int));
            GodinaIzdanja = (int)info.GetValue("GodinaIzdanja", typeof(int));
            Zanrovi = (string)info.GetValue("Zanrovi", typeof(string));
            Ocene = (string)info.GetValue("Ocene", typeof(string));
        }
    }
}
