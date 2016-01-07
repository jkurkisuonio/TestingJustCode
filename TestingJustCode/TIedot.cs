using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestingJustCode
{
    public class Tiedot
    {

        private string nimi;

        public Tiedot(string nimi)
        {
            this.Nimi = nimi;
        }

        public string Nimi
        {
            get
            {
                return nimi;
            }

            set
            {
                this.nimi = value;
            }
        }
    }
}