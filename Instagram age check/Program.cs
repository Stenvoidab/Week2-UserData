using System;

namespace Instagram_age_check
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm küsib kasutaja vanust;
            //programm kontrollib, kas kasutaja on 13.a vana või vanem;
            //kui kasutaja on 13.a vana või vanem, võib kasutaja Instagrami kasutada;
            //kui kasutaja on noorem kui 13.a ei tohi kasutada Instagrami;

            Console.WriteLine("Palun sisesta enda vanus");
            int UserAge = Convert.ToInt32(Console.ReadLine());
            if (UserAge > 13)
            {
                Console.WriteLine("Tere tulemast!");
            }
            else if (UserAge < 13)
            {
                Console.WriteLine("Oota veel veidi");
            }
            else
            {
                Console.WriteLine("Tere tulemast!"); 
            }
            Console.WriteLine("Head päeva!");


        }
    }
}
