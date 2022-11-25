using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenContext_01 {
    class GangContext {
        public string Name { get; set; }
        private List<Gang> gangs = new List<Gang> ( );

        // Constructor
        public GangContext ( string s) {
            Name = s;
        }

        public void ErzeugeGangs(int anzahl, string name ) {

            for ( int i = 0 ; i < anzahl ; i++ ) {
                gangs.Add (new Gang ( name + i));
                gangs [ i ].Name = name + i;
            }
        }

        internal void ZeigeNamenDerPiratenDerGang ( string gname ) {
            Gang g = SucheGang ( gname );
            g.PrintPirates ( );
        }

        public void ErzeugePiraten ( int anzahl, string gangname ) {
            List<Pirat> tempPiraten = new List<Pirat> ( );
            Gang g = SucheGang ( gangname);

            for ( int i = 0 ; i < anzahl ; i++ ) {
                tempPiraten.Add( new Pirat ( "Sven_"+i, g ));
                //Console.WriteLine ( "Sven"+i);
            }
            
            g.AddGangMembers ( tempPiraten );
        }

        private Gang SucheGang ( string suchbegriff ) {
            for ( int i = 0 ; i < gangs.Count ; i++ ) {
                if ( gangs[i].Name == suchbegriff ) {
                    return gangs [ i ];
                }
            } return null;
        }

    }
}
