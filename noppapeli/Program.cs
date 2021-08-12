using System;

namespace teht21
{
    class Program
    {
        static void Main(string[] args)
        {
            int userchoice = 0, firstdie, seconddie, thirddie, total = 0;
            string input;
            bool parsesuccess = false;
            Random dice = new Random();

            while (parsesuccess == false)
            {
                Console.WriteLine("Kuinka monta kertaa haluat heittää kolmea noppaa?");

                input = Console.ReadLine();


                if (parsesuccess = int.TryParse(input, out userchoice))
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Tapahtui virhe, syötä kokonaisluku.");
                }

            }

            int[] throws = new int[userchoice];


            Console.WriteLine("Paina jotain näppäintä heittääksesi noppaa. Lopussa saat yhteenlasketun numeron.");

            for (int i = 0; i < userchoice; i++)
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