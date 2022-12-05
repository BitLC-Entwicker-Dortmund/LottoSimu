using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace LottoSimu {
    class Program {
        static void Main ( string [ ] args ) {
            Random zfg = new Random ( );

            List<int> zahlen = new List<int> ( );
            List<List<int>> ziehungen = new List<List<int>> ( );
            int zahl;

            //zahlen.Add ( 1 );
            //zahlen.Add ( 4 );
            //zahlen.Add ( 7 );
            //zahlen.Add ( 10 );
            //zahlen.Add ( 32 );
            //zahlen.Add ( 34 );

            int zaehler = 0;

            do {
                do {
                    zahl = zfg.Next ( 1 , 50 );
                    Thread.Sleep(20);
                    if ( !zahlen.Contains ( zahl ) ) {
                        zahlen.Add ( zahl );
                    }

                } while ( zahlen.Count < 6 );

                zahlen.Sort ( );
                
                ziehungen.Add ( zahlen );

                ziehungen.Add ( new List<int> ( ) );

            } while (ziehungen.Count < 10);

            foreach ( List<int> item in ziehungen ) {
                foreach ( int z in item ) {
                    Console.Write ( z + " " );
                }
                Console.WriteLine ( );
                Console.WriteLine ( "===============");
            }

            Console.Read ( );
        }
    }
}
