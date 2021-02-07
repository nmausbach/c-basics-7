using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mausbach_Project7
{
    class Validator
    {
        public static int GetInt(string prompt)
        {
            bool isValid = false;
            int iTemp = 0;
            while (!isValid)
            {
                try
                {
                    Console.Write(prompt + ": ");
                    iTemp = int.Parse(Console.ReadLine());
                    isValid = true;
                }//end of try
                catch
                {
                    Console.WriteLine("Please Enter a valid integer value!");
                    Console.WriteLine("Clearing the buffer.......\n");
                    if (-1 < Console.In.Peek())
                        Console.In.ReadToEnd();
                }//end of catch
            }//end of while loop
            return iTemp;
        }//end of GetInt 
        
        public static int GetInt(string prompt, int min, int max)
        {
            bool isValid = false, InRange = false;
            int iTemp = 0;
            prompt += " greater than " + min + " and less than " + max + ": ";
            while (!isValid || !InRange)
            {
                Console.Write(prompt);
                isValid = int.TryParse(Console.ReadLine(), out iTemp);
                InRange = iTemp >= min && iTemp <= max;
                if (!isValid)
                {
                    Console.WriteLine("Please Enter a valid integer value!");
                    Console.WriteLine("Clearing the buffer.......\n");
                    if (-1 < Console.In.Peek())
                        Console.In.ReadToEnd();
                }//end of if
                else if (!InRange)
                {
                    Console.WriteLine("Please Enter integer within range!");
                    Console.WriteLine("Clearing the buffer.......\n");
                    if (-1 < Console.In.Peek())
                        Console.In.ReadToEnd();
                }//end of else if
            }//end of while loop
            return iTemp;
        }//end of GetInt within Range

        public static double GetDouble(string prompt)
        {
            bool isValid = false;
            double dTemp = 0;
            while (!isValid)
            {
                try
                {
                    Console.Write(prompt + ": ");
                    dTemp = double.Parse(Console.ReadLine());
                    isValid = true;
                }//end of try
                catch
                {
                    Console.WriteLine("Please Enter a valid numeric value!");
                    Console.WriteLine("Clearing the buffer.......\n");
                    if (-1 < Console.In.Peek())
                        Console.In.ReadToEnd();
                }//end of catch
            }//end of while loop
            return dTemp;
        }//end of GetDouble 

        public static double GetDouble(string prompt, int min, int max)
        {
            bool isValid = false, InRange = false;
            double dTemp = 0.0;
            prompt += " greater than " + min + " and less than " + max + ": ";
            while (!isValid || !InRange)
            {
                Console.Write(prompt);
                isValid = double.TryParse(Console.ReadLine(), out dTemp);
                InRange = dTemp >= min && dTemp <= max;
                if (!isValid)
                {
                    Console.WriteLine("Please Enter a valid numeric value!");
                    Console.WriteLine("Clearing the buffer.......\n");
                    if (-1 < Console.In.Peek())
                        Console.In.ReadToEnd();
                }//end of if
                else if (!InRange)
                {
                    Console.WriteLine("Please Enter numeric value within range!");
                    Console.WriteLine("Clearing the buffer.......\n");
                    if (-1 < Console.In.Peek())
                        Console.In.ReadToEnd();
                }//end of else if
            }//end of while loop
            return dTemp;
        }//end of GetDouble within Range

        public static bool IsValidString(string value, int maximumLength = 30)
        {
            return value != null && value.Length < maximumLength;
        }//end of IsValidString

        public static bool IsValidEntry(string input, string type, int min = 0,
            int max = 0)
        {
            const int CHAR_LIMIT = 30;

            if (String.IsNullOrEmpty(input))
                return false;
            else
            {
                switch (type.ToLower())
                {
                    case "double":
                        double d;
                        if (double.TryParse(input, out d))
                            return ((d >= min) && (d <= max));
                        else
                            return false;
                    case "integer":
                        int i;
                        if (Int32.TryParse(input, out i))
                            return ((i >= min) && (i <= max));
                        else
                            return false;
                    case "string":
                        return input.Length < CHAR_LIMIT;
                    default:
                        return false;
                }//end of switch
            }//end of else
        }//end of IsValidEntry

    }//end of static class Validator
}//end of namespace Assignment_5_Solution_Updated
