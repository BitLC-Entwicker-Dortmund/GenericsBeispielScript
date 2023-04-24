using System.ComponentModel;

namespace GenericsBeispielScript {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello, Generic!");

            Container<int> c = new Container<int> ();
            int zahl = 42;
            c.Add (zahl);

            foreach (int wasAnderes in c.liste) {
                Console.WriteLine(wasAnderes);
            }

            /// Generische Klasse
            /// 
            Console.WriteLine("Bsp: GenerischeKlasse");
            GenerischeKlasse<int> gk1 = new GenerischeKlasse<int>();
            gk1.Add(42);
            Console.WriteLine(gk1.Show());

            GenerischeKlasse<string> gk2 = new GenerischeKlasse<string>();
            gk2.Add("Zweiundvierzig");
            Console.WriteLine(gk2.Show());

            Console.ReadLine();


            Console.Read();
        }
    }
}