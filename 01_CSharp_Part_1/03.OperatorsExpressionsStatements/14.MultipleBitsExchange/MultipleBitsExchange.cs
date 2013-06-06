using System;


class MultipleBitsExchange
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number in binary representation: {0}",
            Convert.ToString(n, 2).PadLeft(32, '0'));

        Console.Write("Please specify the position at which the exchange begins: ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("Now enter how many bits will be exchanged:  ");
        int k = int.Parse(Console.ReadLine());
        k = k + 1;

        Console.Write("Enter destination position for the selected bits: ");
        int q = int.Parse(Console.ReadLine());

        // on every turn the for loop checks the value of the entered starting bit position,
        // and paste it on the entered destination position, after that the starting
        // positions are altered respectively towards destination positions;
        for (int i = p, j = q; i < p + k - 1; i++, j++)
        {
            int mask1 = 1 << i;
            int mask2 = 1 << j;
            int bit1 = n & mask1;
            int bit2 = n & mask2;

            if (bit1 == 0)
            {
                int exchanger = 1 << j;
                n = n & ~exchanger;
            }
            else
            {
                int exchanger = 1 << j;
                n = n | exchanger;
            }

            if (bit2 == 0)
            {
                int exchanger = 1 << i;
                n = n & ~exchanger;
            }
            else
            {
                int exchanger = 1 << i;
                n = n | exchanger;
            }
        }
        Console.WriteLine("Result in binary representation: {0}",
            Convert.ToString(n, 2).PadLeft(32, '0'));
    }
}
