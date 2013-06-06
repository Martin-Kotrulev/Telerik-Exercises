using System;

class SubsetSumZeroCheck
{
    static void Main()
    {
        Console.WriteLine("Enter five numbers, to see if there's a subset sum between them which equals 0: ");
        int[] numbers = new int[5];
        int len = numbers.Length;
        int count = 0;

        for (int i = 0; i < len; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int a = 0; a < numbers.Length; a++)
        {
            // checking for sum of 2 numbers*********************************************
            for (int b = 0; b < len; b++)
            {
                if (a != b)
                {
                    if (numbers[a] + numbers[b] == 0 && count < 1)
                    {
                        Console.WriteLine("{0} + {1} = 0", numbers[a], numbers[b]);
                        count++;
                    }
                }
                // checking for sum of 3 numbers*****************************************
                for (int c = 0; c < len; c++)
                {
                    if (a != b && b != c)
                    {
                        if (numbers[a] + numbers[b] + numbers[c] == 0 && count < 2)
                        {
                            Console.WriteLine("{0} + {1} + {2} = 0", numbers[a], numbers[b], numbers[c]);
                            count++;
                        }
                        // Yeeees, I know that it's not a good idea to use more than 3 nested loops :P
                        // checking for sum of 4 numbers*********************************
                        for (int d = 0; d < len; d++)
                        {
                            if (a != b && b != c && c != d)
                            {
                                if (numbers[a] + numbers[b] + numbers[c] + numbers[d] == 0 && count < 3)
                                {
                                    Console.WriteLine("{0} + {1} + {2} + {3} = 0", numbers[a], numbers[b],
                                        numbers[c], numbers[d]);
                                    count++;
                                }
                            }
                            // checking for sum of 5 numbers*****************************
                            for (int e = 0; e < len; e++)
                            {
                                if (a != b && b != c && c != d && d != e)
                                {
                                    if (numbers[a] + numbers[b] + numbers[c] + numbers[d] + numbers[e] == 0 && count < 4)
                                    {
                                        Console.WriteLine("{0} + {1} + {2} + {3} + {4} = 0", numbers[a], 
                                            numbers[b], numbers[c], numbers[d], numbers[e]);
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}

