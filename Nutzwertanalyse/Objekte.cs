﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nutzwertanalyse
{
    internal class Objekte
    {
        public Objekte(string name)
        {
            _name = name;
        }

        private string _name;

        public string Name { get { return _name; } }
    }
}
