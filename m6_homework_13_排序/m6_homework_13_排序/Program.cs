using System;
class Program
{
    static void Main(string[] args)
    {
        long[] v;
        
        v = new long[] { 9, 4, 3, 7, 2 };

        Console.WriteLine("??????????????????????????");
        for (int i = 0; i < v.Length; i++)
        {
            Console.Write(" " + v[i]);
        }
        Console.WriteLine();
        Console.WriteLine("##########################");
        // fix #1 排序

        Console.WriteLine("由小排到大");
        Array.Sort(v);
        for (int i = 0; i < v.Length; i++)
        {
            Console.Write(" " + v[i]);
        }

        Console.WriteLine();
        Console.WriteLine("由大排到小");
        Array.Reverse(v);
        for (int i = 0; i < v.Length; i++)
        {
            Console.Write(" " + v[i]);
        }


        Console.WriteLine();
        Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$");
        Console.WriteLine();
        Console.WriteLine();
    }

}