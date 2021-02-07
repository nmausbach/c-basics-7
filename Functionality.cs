using System;
using System.Collections.Generic;
using System.Text;

namespace Mausbach_Project7
{
    class Functionality
    {
        public static decimal[] fillTheArray(decimal tireRatio)//pass in ratio
        {
            //math is tireRatio * speed '10 ,20, 30, 40...'
            decimal speed = 10;
            
            decimal[] array1 = new decimal[10];
            for (var count = 0; count < 10; ++count)
            {
                array1[count] = tireRatio * speed;
                speed += 10;
            }
            return array1;
        }

        public static decimal calcRatio()//pass in tire size new and old
        {
            string prompt ="Please enter the old tire size: ";
            decimal oldTireSize = Validator.GetInt(prompt);
            
            string prompt2 = "Please enter the new tire size: ";
            decimal newTireSize = Validator.GetInt(prompt2);

            decimal tireRatio = newTireSize / oldTireSize;
            return tireRatio;
        }

        public static decimal[] outputSpeedInfo(decimal tireRatio, decimal[] array1)//pass in array values
        {
            
            int speed = 10;
            for (int count = 0; count < array1.Length; ++count)
                { 
                     Console.WriteLine($"When your spedo is reading {speed,3} you're actually going : {array1[count], 5}");
                speed += 10;
                }
            return array1;
        }
    }
}
