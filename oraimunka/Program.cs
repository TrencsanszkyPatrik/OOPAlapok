using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oraimunka
{
    internal class Program
    {

        public class Szemely
        {
            private string Nev;
            private int Eletkor;

            public Szemely(string nev, int eletkor)
            {
                Nev = nev; Eletkor = eletkor;
            }

            public string Kiir()
            {
                return $"A személy neve: {Nev}\nÉletkora: {Eletkor}";

            }
        } 


        static void Main(string[] args)
        {
            Szemely person = new Szemely("Dani", 67);
            Console.WriteLine(person.Kiir());
        }
    }
}
