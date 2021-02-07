using System;

namespace Mausbach_Project7
{
    class Program
    {
        static void Main(string[] args)
        {

            MausbachHeading.getHeading("Assignment 7");
            Console.WriteLine("\n\tTire Size Program\n\n");

            
            char choice = 'Y';

            while (choice == 'Y')
                {
                    Console.WriteLine("\nDo you want to do this tire conversion program: Y or N : ");
                    choice = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (choice == 'Y')
                    {

                        decimal tireRatio = Functionality.calcRatio();
                        decimal[] array1 = Functionality.fillTheArray(tireRatio);
                        Functionality.outputSpeedInfo(tireRatio, array1);
                    
                    }
                }
            MausbachHeading.getClosing();
        }
    }
}