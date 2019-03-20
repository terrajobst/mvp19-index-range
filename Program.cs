using System;

namespace index_and_range
{
    class Program
    {
        static void Main()
        {
            var text = "Hello World";
            var hello = text.Substring(0, 5);
            var world = text.Substring(6, 5);

            Console.WriteLine(text);
            Console.WriteLine(hello);
            Console.WriteLine(world);
        }
    }
}
