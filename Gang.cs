using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenContext_01 {
    class Gang {
        public string Name { get; set; }
        private List<Pirat> piraten = new List<Pirat> ( );

        public Gang(string n ) {
            Name = n;
        }

        public void AddGangMembers ( List<Pirat> tP ) {
            piraten.AddRange ( tP );
        }

        public void PrintPirates ( ) {
            foreach ( Pirat einPirat in piraten ) {
                Console.WriteLine (einPirat.Name);
            }
        }
    }
}
