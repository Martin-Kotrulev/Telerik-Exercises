using System;

class SumThreeIntegers
{
    static void Main()
    {
        int firstNum = 0;
        int secondNum = 0;
        int thirdNum = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Please enter a number: ");
            string input = Console.ReadLine();
            int num;

            //check if input is integer and put the number in one of the three variables;
            if (int.TryParse(input, out num))
            {
                if (i == 0)
                {
                    firstNum = num;
                }
                else if (i == 1)
                {
                    secondNum = num;
                }
                else if (i == 2)
                {
                    thirdNum = num;
                }
            }
            else
            {
                //if input is not a valid integer, goes back to loop condition;
                Console.WriteLine("Invalid Input! Try again!");
                i--;
                continue;
            }
        }
    Console.WriteLine(firstNum + secondNum + thirdNum);
    }
}

