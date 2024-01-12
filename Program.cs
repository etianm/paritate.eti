using System;

class Program
{
    static void Main(string[] args)
    {
        int a;
        a = Convert.ToInt32(Console.ReadLine());
        if (a % 2 == 0)
            Console.WriteLine("PAR");
        else
            Console.WriteLine("IMPAR");
    }
}
