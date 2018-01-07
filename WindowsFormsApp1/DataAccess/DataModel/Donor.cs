using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bloonk.DataAccess.DataModel
{
    public class Donor
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Oib { get; set; }
        public DateTime Datum_rodenja { get; set; }
        public string Grad { get; set; }
        public string Br_mobitela { get; set; }
        public DateTime Datum { get; set; }
        public Krvna_grupa KrvnaGrupa { get; set; }
        public Spol SpolDonor { get; set; }
        public int Id { get; set; }

        public static Krvna_grupa MapirajKrvnuGrupu(string krvnaGrupa)
        {
            switch (krvnaGrupa.ToLowerInvariant())
            {
                case "zn": return Krvna_grupa.Zn;
                case "zp": return Krvna_grupa.Zp;
                case "an": return Krvna_grupa.an;
                case "ap": return Krvna_grupa.ap;
                case "bn": return Krvna_grupa.bn;
                case "bp": return Krvna_grupa.bp;
                case "abn": return Krvna_grupa.abn;
                case "abp": return Krvna_grupa.abp;
            }

            return Krvna_grupa.Nepoznata;
        }

        public static Spol MapirajSpol(int spolId)
        {
            return spolId == 1 ? Spol.musko : Spol.zensko;
        }
    }



    public enum Krvna_grupa
    {
        Zn,
        Zp,
        an,
        ap,
        bn,
        bp,
        abn,
        abp,
        Nepoznata
    }

    public enum Spol
    {
        musko,
        zensko
    }
}
