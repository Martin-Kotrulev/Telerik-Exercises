using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*05.Write a method that checks if the element 
 * at given position in given array of integers 
 * is bigger than its two neighbors (when such exist).*/

class CheckNeighboursElementsMethod
{
    static bool IsBiggerThanNeighbours(int[] arr, int index)

    {
        bool check = false;
        if (index == 0)
        {
            if (arr[index + 1] < arr[index]) check = true;
        }
        else if (index == arr.Length - 1)
        {
            if (arr[index - 1] < arr[index]) check = true;
        }
        else
        {
            if (arr[index + 1] < arr[index] && arr[index + 1] < arr[index])
            {
                check = true;
            }
        }
        return check;
    }

    static void Main()
    {
        int[] arr = { 6, 3, 4, 5, 3, 6, 7, 3, 4, 2, 5, 3, 6 };

        Console.Write("Select which element to be checked by its index: ");
        int numberIndex = int.Parse(Console.ReadLine());
        if (numberIndex >= arr.Length || numberIndex < 0)
        {
            Console.WriteLine("Theres no such element in the array!");
        }
        else
        {
            bool check = IsBiggerThanNeighbours(arr, numberIndex);
            Console.WriteLine("Your element is bigger than its neighbours: {0}!", check);
        }
    }
}

