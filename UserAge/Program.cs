using System;

namespace UserAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja vanust;
            //programm arvutab kasutaja sünniaasta;
            //programm kuvab sünniaastat konsoolis;

            Console.WriteLine("Sisesta palun enda vanus.");
            int UserAge = Convert.ToInt32(Console.ReadLine());
            int YearOfBirth = 2022 - UserAge;
            Console.WriteLine($"Oled sündinud {YearOfBirth} aastal.");


        }
    }
}
