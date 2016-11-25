using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPL3._0.Model
{
    class Persoon
    {
        private string naam;
        private string adres;
        private string woonplaats;

        public string Naam()
        {

        }

        public Persoon(string naam, string adres, string woonplaats)
        {
            this.naam = naam;
            this.adres = adres;
            this.woonplaats = woonplaats;
        }
    }
}
