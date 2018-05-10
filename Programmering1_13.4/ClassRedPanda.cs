using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_13._4 {
    class RedPanda {
        //      SAME FOR ALL
        public static int eyes = 2;
        public static int legs = 4;
        public static int tail = 1;

        //      UNIQUE FOR ALL
        public static string name;
        public static int age;

        //      STUFF THEY DO
        public static void Sleep() {    // No need to mention "name" as an agument here as they're in the same class.
            Console.WriteLine("sssh, {0} sover", name);
            return;
        }
    }
}
