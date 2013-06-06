using System;

class SortInDescendingOrder
{
    static void Main()
    {
        Console.WriteLine("Enter three numbers. The numbers will be sorted in descending order: ");
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        if (first != second && first != third)
        {
            int biggest = FindBiggest(first, second, third);
            int middle = FindNextNum(first, second, third);
            int smallest = FindSmallest(first, second, third);

            Console.WriteLine("{0}, {1}, {2}", biggest, middle, smallest);
        }
        else
        {
            Console.WriteLine("Some of the numbers are equal!");
        }
    }

    static int FindSmallest(int first, int second, int third)
    {
        int smallest = first;

        if (second < first && second < third)
        {
            smallest = second;
        }
        else if (third < first && third < second)
        {
            smallest = third;
        }
        return smallest;
    }

    static int FindNextNum(int first, int second, int third)
    {
        int middle = second;

        if ((first > second && first < third) || (first > third && first < second))
        {
            middle = first;
        }
        else if ((third > second && third < first) || (third > first && third < second))
        {
            middle = third;
        }
        return middle;
    }

    static int FindBiggest(int first, int second, int third)
    {
        int biggest = third;

        if (first > second && first > third)
        {
            biggest = first;
        }
        else if (second > first && second > third)
        {
            biggest = second;
        }
        return biggest;
    }
}

