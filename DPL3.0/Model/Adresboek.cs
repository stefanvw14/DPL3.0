using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPL3._0.Klassen
{
    class Adresboek
    {
        private List<Persoon> personen;
        public Adresboek()
        {
            personen = new List<Persoon>();
        }

        public List<Persoon> geeflijst()
        {
            return personen;

        }

        public List<Persoon> zoeken(string tekst)
        {

        }

        public void aanmaken(Persoon p)
        {
            personen.Add(p);
        }

        public void verwijderen(Persoon p)
        {
            personen.Remove(p);
        }
    }
}
