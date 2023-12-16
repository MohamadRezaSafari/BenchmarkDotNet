using BenchmarkDotNet.Attributes;
using System.Collections;

namespace ConsoleApp1
{
    public class Array
    {
        private readonly string[] _array;
        private readonly int[] _arrayInt;
        private readonly ArrayList _arrayObj;

        [GlobalSetup]
        public void GlobalSetup()
        {
            for (int i = 1; i <= 100; i++)
            {
                _array[i] = i.ToString();
                _arrayInt[i] = i;
                _arrayObj.Add(i);
            }
        }

        [Benchmark]
        public string[] ArrayObj() => _arrayObj.ToArray().Select(i => i.ToString()).ToArray();

        [Benchmark]
        public string[] ArrayInt() => _arrayInt.ToArray().Select(i => i.ToString()).ToArray();

        [Benchmark]
        public string[] ArrayString() => _array.ToArray();
    }
}
