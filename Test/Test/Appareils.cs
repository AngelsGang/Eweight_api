using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Appareils
    {
        private string nomAppareil;
        private string marqueAppareil;
        private double porterAppareil;
        private bool etatAppareil;
        private List<string> listAppareils = new List<string>();

        public Appareils()
        {
            etatAppareil = false;
            recuperAppareils();
        }

        public string NomAppareil { get => nomAppareil; set => nomAppareil = value; }
        public string MarqueAppareil { get => marqueAppareil; set => marqueAppareil = value; }
        public double PorterAppareil { get => porterAppareil; set => porterAppareil = value; }
        public bool EtatAppareil { get => etatAppareil; set => etatAppareil = value; }
        public List<string> ListAppareils { get => listAppareils; set => listAppareils = value; }

        public void recuperAppareils()
        {
            ListAppareils.Add("E-weight");
            ListAppareils.Add("E-mirror");
            ListAppareils.Add("E-shoes");
            ListAppareils.Add("E-Dyson");
        }
    }
}
