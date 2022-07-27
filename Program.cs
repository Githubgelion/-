using System;

class Program
{
    public static int Main()
    {
        int j = 1; // initial start number 
        for (int i = 1; i <= 1000; i += j) // cycle for displaying fibonacci numbers
        {
            Console.WriteLine(i); 
            j = i - j; 
        }
        Console.ReadKey();
        return 0;
    }
}