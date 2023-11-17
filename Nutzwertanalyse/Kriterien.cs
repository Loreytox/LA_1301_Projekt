using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutzwertanalyse
{
    internal class Kriterien
    {
        public Kriterien(string name, int gewichtung)
        {
            _name = name;
            _gewichtung = gewichtung;
        }

        private string _name;
        private int _gewichtung;
        
        public string Name { get { return _name; } }
        public int Gewichtung { get {  return _gewichtung; } }
    }
}
