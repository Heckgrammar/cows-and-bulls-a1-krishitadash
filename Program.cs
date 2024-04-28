using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string computerDigit = "";

            string userDigit = "";

            int cows = 0;

            int bulls = 0;

            int guesses = 0;

            bool game_on = true;





            while (game_on)

            {

                if ((bulls==4) || (guesses==0))

                {

                    do

                    {

                        Random rnd = new Random();

                        computerDigit= (rnd.Next(1000, 10000)).ToString();

                        Console.WriteLine(computerDigit);

                        Console.WriteLine(computerDigit.Distinct().Count());

                    } while (computerDigit.Length != computerDigit.Distinct().Count());

                }



                bulls = 0;

                cows = 0;



                do

                {

                    Console.WriteLine("enter a four digit number");

                    userDigit = Console.ReadLine();



                }

                while (

                    (userDigit.Length != userDigit.Distinct().Count()) ||

                    ((Convert.ToInt32(userDigit) < 1000) || (Convert.ToInt32(userDigit) > 9999))



                    );





                for (int i = 0; i < 4; i++)

                {

                    if (i == 0)

                    {

                        continue;

                    }

                    if (computerDigit[0] == userDigit[i])

                    {

                        cows = cows + 1;



                    }

                    //Console.WriteLine("1st cow loop");

                    Console.WriteLine(cows);



                }





                for (int i = 0; i < 4; i++)

                {

                    if (i == 1)

                    {

                        continue;

                    }



                    if (computerDigit[1] == userDigit[i])

                    {

                        cows = cows + 1;

                    }

                   // Console.WriteLine("2nd cow loop");

                    Console.WriteLine(cows);



                }



                for (int i = 0; i < 4; i++)

                {

                    if (i == 2)

                    {

                        continue;

                    }



                    if (computerDigit[2] == userDigit[i])

                    {

                        cows = cows + 1;

                    }

                   // Console.WriteLine("3rd cow loop");

                   // Console.WriteLine(cows);

                }



                for (int i = 0; i < 4; i++)

                {

                    if (i == 3)

                    {

                        continue;

                    }



                    if (computerDigit[3] == userDigit[i])

                    {

                        cows = cows + 1;

                    }



                    

                }
                Console.WriteLine("number of cows is "+cows);






                for (int i = 0; i < 4; i++)

                {

                    if (computerDigit[i] == userDigit[i])

                    {

                        bulls = bulls + 1;

                    }

                    

                }

                Console.WriteLine("number of bulls is "+ bulls);

                guesses = guesses + 1;



                Console.WriteLine("Do you want to try again !! [y/n]");

                string play_again = Console.ReadLine();



                if (play_again == "y")

                {

                    game_on=true;
                    if (computerDigit == userDigit)
                    {
                        guesses = 0;
                    }

                }

                else

                {

                    game_on=false;

                }



            }



            Console.WriteLine("number of guesses: "+guesses);
        }
        }
    }
}
