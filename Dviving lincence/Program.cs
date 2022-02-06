using System;

namespace Dviving_lincence
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat;
            //Programm arvutab kasutaja vanust;
            //kui kasutaja on noorem kui 18, programm kuvab konsoolis "Oled liiga noor, et juhulube saada!"
            //Kui kasutaja on vanem kui 18, programm kuvab "Oled piisavalt vana, et juhulube saada";
            //Kui kasutaja on 18, programm kuvab "Palju õnne! Nüüd sa saad juhilube taotleda"

            Console.WriteLine("Sisesta oma sünniaasta.");
            int Birthdate = Convert.ToInt32(Console.ReadLine());
            int UserAge = 2022 - Birthdate;

           

            if (UserAge > 18)
            {
                Console.WriteLine("Oled piisavalt vana, et juhuload saada.");
            }

            else if (UserAge < 18)
            { 
              Console.WriteLine("Oled liiga noor, et juhuload saada!");
            }

            else
            {
              Console.WriteLine("Palju õnne! Nüüd sa saad juhilube taotleda.");
            }

        }
    }
}
