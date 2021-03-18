using System;

namespace IntroToProgramming {
    class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("How old are you? ");
            string age = Console.ReadLine();

            int ageNum = int.Parse(age);

            if (ageNum >= 18) {
                Console.WriteLine("Legally an adult");

            }

            else {
                Console.WriteLine("Legally not adult age");

            }  

        }
    }
}
