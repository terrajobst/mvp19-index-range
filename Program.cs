using System;
using System.Collections;
using System.Collections.Generic;

namespace index_and_range
{
    class Program
    {
        static void Main()
        {
            var text = "Hello World";
            // var hello = text.Substring(0, 5);
            // var world = text.Substring(6, 5);

            var hello = text[..5];
            var world = text[^5..];

            Console.WriteLine(text);
            Console.WriteLine(hello);
            Console.WriteLine(world);
        }
    }

    class MyCollection : IReadOnlyList<int>
    {
        private int[] _data = { 1, 2, 3, 4, 5 };

        public IEnumerator<int> GetEnumerator() => ((IEnumerable<int>)_data).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        public int Count => _data.Length;

        public int this[int index] => _data[index];

        public int this[Index index] => _data[index.GetOffset(Count)];

        public IEnumerable<int> this[Range range] => _data[range];
    }
}
