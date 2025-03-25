
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    public class EtreVivant
    {
        public DateTime DateNaissance { get; set; }

        public EtreVivant()
        {
            this.DateNaissance = DateTime.Now;
        }
        public EtreVivant(DateTime dateNaissance)
        {
            this.DateNaissance = dateNaissance;
        }

        public int GetAge()
        {
            int year = DateTime.Now.Year - this.DateNaissance.Year;
            if (this.DateNaissance.Date > DateTime.Now.AddYears(-year)) year--;
            return year;

        }

        static class Helper
        { 
            public static void Test(int valeur)
            {
                valeur++;
            }
            public static void TestEtreVidant(EtreVivant etreVivant)
            {
                etreVivant.DateNaissance = etreVivant
            }
                
        }
    }
}
