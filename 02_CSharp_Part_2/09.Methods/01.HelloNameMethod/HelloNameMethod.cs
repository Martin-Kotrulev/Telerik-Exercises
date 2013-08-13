using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*01.Write a method that asks the user for his
 *name and prints “Hello, <name>” (for example, “Hello, Peter!”).
 *Write a program to test this method.*/

class HelloNameMethod
{
    static void UnitTest()
    {
        HelloMethod("");
        HelloMethod("!@#$%^&*()_+");
        HelloMethod("123456789");
        HelloMethod("tralala" + 15);
    }

    static void HelloMethod(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        UnitTest();
        Console.Write("Enter your name, plese: ");
        string name = Console.ReadLine();
        
        HelloMethod(name);
    }
}

