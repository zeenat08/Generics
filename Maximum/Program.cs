﻿using System;


namespace FindMaximumNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 22.45, 78.56);
            Console.WriteLine(doubleoutput);
            string strigoutput = MaximumNumberCheck.MaximumStringNumber("22", "33", "44");
            Console.WriteLine(strigoutput);
            //int[] intArray = { 112, 344, 432, 555, 678 };
            //    GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            //    generic.PrintMaxValue();
            //    double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            //    GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            //    genericDouble.PrintMaxValue();
            //    string[] stringArray = { "111", "222", "333", "55", "999" };
            //    GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            //    //GenericMaximum<Employee> genericString = new GenericMaximum<string>(stringArray);
            //    genericString.PrintMaxValue();
                 Console.ReadKey();
            }

          
        }
    }

