using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_13._4 {
    class Program {
        static void Main(string[] args) {
            RedPanda myPanda = new RedPanda();
            RedPanda.name = "Tails";
            RedPanda.age = 23;

            Console.WriteLine("Denna kattbjörnen heter {0} och är {1}år gammal.", RedPanda.name, RedPanda.age);
            Console.ReadKey();

            RedPanda.Sleep();
            Console.ReadKey();
        }
    }
}
