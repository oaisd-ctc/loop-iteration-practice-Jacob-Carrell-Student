using System;

class Program
{
    public static int i = 1;
    public static void Main(string[] args)
    {
        Write1ThroughN_While();
        Write1ThroughN_For(10);
        WriteNThrough1_While();
        WriteNThrough1_For(10);
        WriteEvensThrough100();
        FindSum(10);
        FindSumOfEvenNumbers(20);
        FindSumOfOddNumbers(20);
        OutputRightTriangle();
    }

    public static void Write1ThroughN_While()
    {
        int i = 1;
        int n = 10;

        while (i <= n)
        {
            Console.WriteLine(i);
            i++;
        }

        if (i > n) 
        {
            Console.WriteLine("Out Of Range");
            Console.WriteLine();
        }
    }

    public static void Write1ThroughN_For(int n)
    {
        for (int i = 1; i <= n; i++;)
        {
            Console.WriteLine(i);
        }

        
        if (i > n)
        {
            Console.WriteLine("Out Of Range");
            Console.WriteLine();
        }
    }

    public static void WriteNThrough1_While()
    {
        int i = 1;
        int n = 10;

        while (i <= n)
        {
            Console.WriteLine(n);
            n--;
        }

        if (i > n) 
        {
            Console.WriteLine("Out Of Range");
            Console.WriteLine();
        }
    }

    public static void WriteNThrough1_For(int n)
    {
        for (int i = 1; i <= n; n--;)
        {
            Console.WriteLine(n);
        }

        
        if (i > n)
        {
            Console.WriteLine("Out Of Range");
            Console.WriteLine();
        }
    }

    public static void WriteEvensThrough100()
    {
        int i1 = 0;
        int n1 = 101;

        while (i1 <= n1)
        {
            i1++;
            if (i1 % 2 == 0)
            {
                continue;
            }
            i1++;
            if (i1 == 102)
            {
                break;
            }
            Console.WriteLine(i1);
        }
        Console.WriteLine();
    }

    public static void FindSum(int n)
    {
        int i = 1;
        int sum = 0;

        while (i >= n)
        {
            Console.WriteLine(i);
            i++;
            i + sum;
        }
        Console.WriteLine("The sum is " + sum);
    }

    public static void FindSumOfEvenNumbers(int n)
    {
        int i = 1;
        int sum = 0;

        while (i >= n && i % 2 == 0)
        {
            Console.WriteLine(i);
            i++;
            i + sum;
        }
        Console.WriteLine("The sum is " + sum);
    }

    public static void FindSumOfOddNumbers(int n)
    {
        int i = 1;
        int sum = 0;

        while (i >= n && i !% 2 == 0)
        {
            Console.WriteLine(i);
            i++;
            i + sum;
        }
        Console.WriteLine("The sum is " + sum);
    }

    public static void OutputRightTriangle()
    { 
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine();
            for (int l = 0; l < i; l++)
            {
                Console.Write("*");

              
            }
            Console.WriteLine();
        }

    }
}


