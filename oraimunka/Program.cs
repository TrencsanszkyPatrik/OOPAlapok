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
           public string nev = "Dani";
           public int eletkor = 19;
        } 


        static void Main(string[] args)
        {
            Szemely person = new Szemely();
            Console.WriteLine($"A személy neve: {person.nev}\nÉletkora: {person.eletkor}");

        }
    }
}
