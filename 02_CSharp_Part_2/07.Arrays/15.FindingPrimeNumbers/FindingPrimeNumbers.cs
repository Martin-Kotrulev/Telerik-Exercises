using System;

class FindingPrimeNumbers
{
    static void Main()
    {
        bool[] nums = new bool[10000000];

        for (int i = 2; i < Math.Sqrt(nums.Length); i++)
        {
            if (nums[i] == false)
            {
                for (int j = i * i; j < nums.Length; j += i)
                {
                    nums[j] = true;
                }
            }
        }

        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] == false)
            {
                Console.WriteLine("{0}", i);
            }
        }
    }
}

