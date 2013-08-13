using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*06.Write a method that returns the index of the first 
 * element in array that is bigger than 
 * its neighbors, or -1, if there’s no such element.
Use the method from the previous exercise.*/

class FirstElementBiggerThanItsNeighbours
{
    static int FirstBiggerThanNeighbours(int[] arr)
    {
        int current = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            current = arr[i];
            if (i == 0)
            {
                if (arr[i + 1] < arr[i]) return current;
            }
            else if (i == arr.Length - 1)
            {
                if (arr[i - 1] < arr[i]) return current;
            }
            else
            {
                if (arr[i + 1] < arr[i] && arr[i + 1] < arr[i]) return current;
            }
        }
        return current;
    }

    static void Main()
    {
        int[] arr = { 6, 3, 4, 5, 3, 6, 7, 3, 4, 2, 5, 3, 6 };

        int firstBigger = FirstBiggerThanNeighbours(arr);

        Console.WriteLine("The first element greater than his neighbours is {0}!", firstBigger);
    }
}

