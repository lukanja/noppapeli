using System;

namespace teht21
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstdie, seconddie, thirddie, total = 0;
            Random dice = new Random();
            int[] throws = new int[5];

            Console.WriteLine("Paina jotain näppäintä heittääksesi kolmea noppaa. Lopussa saat yhteenlasketun numeron.");

            for (int i = 0; i < 5; i++)
            {
                Console.ReadKey(true);
                Console.WriteLine("Heitto numero {0}:", i + 1);
                firstdie = dice.Next(1, 7);
                seconddie = dice.Next(1, 7);
                thirddie = dice.Next(1, 7);
                Console.WriteLine("{0}, {1} ja {2}", firstdie, seconddie, thirddie);



                throws[i] = firstdie + seconddie + thirddie;
            }

            for (int i = 0; i < throws.Length; i++)
            {
                total += throws[i];
            }

            Console.WriteLine("Nopanheittojen yhteissumma on {0}.", total);
        }
    }
}