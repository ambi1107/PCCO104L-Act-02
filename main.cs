using System;

class Program
{
    static void Main(string[] args)
    {
        FooBar(30);
    }

    static void FooBar(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            string output = i.ToString();
            if (i % 3 == 0 && i % 5 == 0)
            {
                output += " - FooBar";
            }
            else if (i % 3 == 0)
            {
                output += " - Foo";
            }
            else if (i % 5 == 0)
            {
                output += " - Bar";
            }
            Console.WriteLine(output);
        }
    }
}
