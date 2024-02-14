using System;
using System.Transactions;

namespace UnitConvertorHarjoitus
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            { 
                Console.WriteLine("Hello and welcome to unit convertor");
                Console.WriteLine("Type 1 to convert lengths\ntype 2 to convert weight\ntype 3 to convert volume\n");
                //Console.ReadLine();
                string type = Console.ReadLine();


                //if(Console.ReadLine() == "1")
                if(type == "1")
                {
                    Console.Write("Type 1 to convert kilometers to miles or 2 to convert miles to kilometers: ");
                    string choice = Console.ReadLine();

                    if (choice == "1") 
                    {
                        KilometersToMiles();
                    }
                    else if (choice == "2")
                    {
                        MilesToKilometers();
                    }
                    else
                    {
                        Console.WriteLine("Invalid command - please only enter the requested number\nReturning to main menu\n");
                    }
                }
                else if (type == "2")
                {
                    Console.WriteLine("Type 1 to convert kilograms to pounds or 2 to convert pounds to kilograms");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        KilogramsToPounds();
                    }
                    else if(choice == "2")
                    {
                        PoundsToKilograms();
                    }
                    else
                    {
                        Console.WriteLine("Invalid command - please only enter the requested number\nReturning to main menu\n");
                    }
                }
                else if (type == "3")
                {
                    Console.WriteLine("Type 1 to convert deciliters to cups or 2 to convert cups to deciliters");
                    string choice = Console.ReadLine();

                    if (choice == "1")
                    {
                        DecilitersToCups();   
                    }
                    else if (choice == "2")
                    {
                        CupsToDeciliters();
                    }
                    else
                    {
                        Console.WriteLine("Invalid command - please only enter the requested number\nReturning to main menu\n");
                    }
                }
                else 
                { 
                    Console.WriteLine("Invalid command. Please Type 1 to convert lengths, 2 to convert weight and 3 to convert volume");
                }
            }
        }
        static void KilometersToMiles()
        {
            try
            {
                Console.Write("Please enter the number of kilometers: ");
                double kilometers = double.Parse(Console.ReadLine());
                double miles = kilometers * 0.621371192;
                Console.WriteLine("{0} kilometers is equal to {1} miles\n\n", kilometers, miles);
            }
            catch
            {
                Console.WriteLine("Please only enter numbers and in correct format (did you accidently use dot instead of comma?)\n");
                KilometersToMiles();
            }


        }
        static void MilesToKilometers()
        {
            try
            {
                Console.Write("Please enter the number of miles: ");
                double miles = double.Parse(Console.ReadLine());
                double kilometers = miles * 1.609344;
                Console.WriteLine("{0} miles is equal to {1} kilometers.", miles, kilometers);
            }
            catch
            {
                Console.WriteLine("Please only enter numbers and in correct format (did you accidently use dot instead of comma?)\n");
                MilesToKilometers();
            }
            

        }
        static void PoundsToKilograms()
        {
            try
            {
                Console.Write("Please enter the number of pounds: ");
                double pounds = double.Parse(Console.ReadLine());
                double kilograms = pounds * 0.45359237;
                Console.WriteLine("{0} pounds is equal to {1} kilograms\n\n", pounds, kilograms);
            }
            catch
            {
                Console.WriteLine("Please only enter numbers and in correct format (did you accidently use dot instead of comma?)\n");
                PoundsToKilograms();
            }
            
        }
        static void KilogramsToPounds()
        {
            try
            {
                Console.Write("Please enter the number of kilograms: ");
                double kilograms = double.Parse(Console.ReadLine());
                double pounds = kilograms * 2.20462262;
                Console.WriteLine("{0} kilograms is equal to {1} pounds\n\n", kilograms, pounds);
            }
            catch
            {
                Console.WriteLine("Please only enter numbers and in correct format (did you accidently use dot instead of comma?)\n");
                KilogramsToPounds();
            }
            
        }
        static void DecilitersToCups()
        {
            try
            {
                Console.Write("Please enter the number of deciliters: ");
                double deciliters = double.Parse(Console.ReadLine());
                double cups = deciliters * 0.422675284;
                Console.WriteLine("{0} deciliters is equal to {1} cups\n\n", deciliters, cups);
            }
            catch
            {
                Console.WriteLine("Please only enter numbers and in correct format (did you accidently use dot instead of comma?)\n");
                DecilitersToCups();
            }
            
        }
        static void CupsToDeciliters()
        {
            try
            {
                Console.Write("Please enter the number of cups: ");
                double cups = double.Parse(Console.ReadLine());
                double deciliters = cups * 2.36588237;
                Console.WriteLine("{0} cups is equal to {1} deciliters\n\n", cups, deciliters);
            }
            catch
            {
                Console.WriteLine("Please only enter numbers and in correct format (did you accidently use dot instead of comma?)\n");
                CupsToDeciliters();
            }
            
        }
    }

}
