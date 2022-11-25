using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiratenContext_01 {
    class Program {
        static void Main ( string [ ] args ) {
            GangContext gc = new GangContext ( "Piratenwelt" );
            Console.WriteLine ( gc.Name);
            gc.ErzeugeGangs ( 10, "Gang_");
            gc.ErzeugePiraten ( 5, "Gang_0" );
            gc.ZeigeNamenDerPiratenDerGang ( "Gang_0" );

            Console.Read ( );
        }
    }
}
