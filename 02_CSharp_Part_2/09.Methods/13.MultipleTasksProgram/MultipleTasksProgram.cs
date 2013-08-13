using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*13. Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0 */

class MultipleTasksProgram
{
    // Linear equation program *****************************************************//
    static void StartLinearEquation()                                               //
    {                                                                               //
        Console.Write("Enter value for a: ");                                       //
        int a, b;                                                                   //
        //
        while (true)                                                                //
        {                                                                           //
            int.TryParse(Console.ReadLine(), out a);                                //
            if (a > 0) break;                                                       //
            else Console.Write(                                                     //
                "\"a\" must be a number, and shouldn't be zero! Try again: ");      //
        }                                                                           //
        //
        Console.Write("Enter value for b: ");                                       //
        while (true)                                                                //
        {                                                                           //
            if (int.TryParse(Console.ReadLine(), out b)) break;                     //
            else Console.Write("Number please: ");                                  //
        }                                                                           //
        //
        Console.WriteLine("\nCalculate equation: " + CalculateEquation(a, b));      //
    }                                                                               //
    //
    static double CalculateEquation(int a, int b)                                   //
    {                                                                               //
        return (double)-b / a;                                                      //
    }                                                                               //
    //******************************************************************************//
    // Calculate average program****************************************************//
    static void StartCalculateAverage()                                             //
    {                                                                               //
        Console.Write("Enter the size of your array: ");                            //
        //
        int size;                                                                   // 
        //  
        while (true)                                                                //  
        {                                                                           //
            string input = Console.ReadLine();                                      //
            int.TryParse(input, out size);                                          //
            if (size > 0) break;                                                    //
            else Console.Write("The array should not be empty! Try again: ");       //
        }                                                                           //
        //
        int[] arr = new int[size];                                                  //
        for (int i = 0; i < arr.Length; i++)                                        //
        {                                                                           //
            while (true)                                                            //
            {                                                                       //
                Console.Write("Element[{0}]: ", i);                                 //
                int current;                                                        //
                bool succes = int.TryParse(Console.ReadLine(), out current);        //
                if (succes)                                                         //
                {                                                                   //
                    arr[i] = current;                                               //
                    break;                                                          //
                }                                                                   //
            }                                                                       //
        }                                                                           //
        //
        Console.WriteLine("Average: " + CalculateAverage(arr));                     //
    }                                                                               //
    //    
    static double CalculateAverage(int[] arr)                                       //
    {                                                                               //
        int sum = 0;                                                                //
        //
        for (int i = 0; i < arr.Length; i++)                                        //
        {                                                                           //
            sum += arr[i];                                                          //
        }                                                                           //
        //
        return (double)sum / arr.Length;                                            //
    }                                                                               //
    //******************************************************************************//
    // Reverse digits program//*****************************************************//
    static void StartReverseDigits()                                                //
    {                                                                               //
        Console.Write("Please enter a number: ");                                   //
        int num;                                                                    //
        //
        while (true)                                                                //
        {                                                                           //
            string input = Console.ReadLine();                                      //
            bool valid = int.TryParse(input, out num);                              //
            //
            if (valid && num > 0) break;                                            //
            else Console.Write("Come on, valid and POSITIVE number please: ");      //
        }                                                                           //
        //
        Console.Write("Your number reversed: ");                                    //
        ReverseDigits(num);                                                         //
    }                                                                               //
    //
    static int ReverseDigits(int num)                                               //
    {                                                                               //
        while (num != 0)                                                            //
        {                                                                           //
            Console.Write("{0}", num % 10);                                         //
            num /= 10;                                                              //
        }                                                                           //
        return num;                                                                 //
    }                                                                               //
    //******************************************************************************//
    static void Main()
    {
        Console.WriteLine(
            "Welcome, with this program you can solve three different tasks:");
        Console.WriteLine();
        Console.WriteLine("1. Reverse the digits of a number;");
        Console.WriteLine("2. Calculate the average of a sequence of integers;");
        Console.WriteLine("3. Solve a linear equation a * x + b = 0;");

        while (true)
        {
            Console.Write("\nType 1, 2 or 3 to Continue or 4 to Exit: ");

            byte choice;
            string input = Console.ReadLine();
            byte.TryParse(input, out choice);
            if (choice == 1 || choice == 2 || choice == 3)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine(
                            "\nYou have chosen to Reverse the digits of a number!");
                        StartReverseDigits();
                        break;
                    case 2:
                        Console.WriteLine(
                            "\nYou have chosen to Calculate the avarage of a sequence of integers!");
                        StartCalculateAverage();
                        break;
                    case 3:
                        Console.WriteLine(
                            "\nYou have chosen to Solve a linear equation a * x + b = 0!");
                        StartLinearEquation();
                        break;
                    default:
                        break;
                }
            }
            else if (choice == 4) break;
            else Console.Write("Waiting for your choice!");
        }
    }
}

