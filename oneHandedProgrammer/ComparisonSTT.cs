using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oneHandedProgrammer
{
    internal class ComparisonSTT
    {
        private string _entendu;
        private string _converti;

        public ComparisonSTT(string entendu, string converti)
        {
            Entendu = entendu;
            Converti = converti;
        }

        public string Entendu { get => _entendu; set => _entendu = value.ToLower(); }
        public string Converti { get => _converti; set => _converti = value.ToLower(); }


    }
}
