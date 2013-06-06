using System;

class DeclareDataTypes
{
    static void Main()
    {
        ushort var1 = 53130;
        sbyte var2 = -115;
        int var3 = 4825932;
        byte var4 = 97;
        short var5 = -10000;
        Console.WriteLine(
            "{0} is \"ushort\" type, {1} is \"sbyte\" type, {2} is \"int\" type.\n" +
            "{3} is \"byte\" type and {4} is \"short\" type.", 
            var1, var2, var3, var4, var5);
    }
}