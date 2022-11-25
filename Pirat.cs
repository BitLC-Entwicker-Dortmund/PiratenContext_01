using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenContext_01 {
    class Pirat {
        public string Name { get; set; }
        public Gang Gang { get; set; }

        public Pirat ( string n, Gang g) {
            Name = n;
            Gang = g;
        }
    }
}
