using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraimunka
{
    internal class Program
    {
        public class BankSzamla
        {
            private int _egyenleg;

            public int Egyenleg
            {
                get { return _egyenleg; }
                set
                {
                    if (value > 0)
                        _egyenleg = value;
                    else
                        Console.WriteLine("Egyenleg nem lehet nulla");
                }
            }
            public void Betesz() { }
            public void Kivesz() { }

        }
       
        
        public class Szemely
        {
            private string _nev;
            private int _eletkor;

            public string Nev
            {
                get { return _nev; } //privat adattag kiolvasásához
                set { _nev = value; }
            }

            public int Eletkor
            {
                get { return _eletkor; }
                set
                {
                    if (value > 0) _eletkor = value;
                    else Console.WriteLine("Nem lehet negatív.");
                }
            }

            public override string ToString()
            {
                return $"A személy neve: {Nev}, kora: {Eletkor}";
            }

            /*
            public Szemely(string neve, int eletkora)
            {
                nev = neve; eletkor = eletkora;
            }

            public string Kiir()
            {
                return $"A személy neve: {Nev}\nÉletkora: {Eletkor}";

            }
            
            */
        }


        static void Main(string[] args)
        {
            Szemely person = new Szemely();
            person.Eletkor = 33;
            person.Nev = "Feri";
            Console.WriteLine(person);
            
            //Console.WriteLine($"A személy neve: {person.Nev}, kora: {person.Eletkor}");
            
            //Szemely person = new Szemely("Dani", 67);
            //Console.WriteLine(person.Kiir());
        }
    }
}
