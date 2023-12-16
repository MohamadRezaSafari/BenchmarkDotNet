using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ArrayListBenchmark
    {
        [Params(10, 50, 100)]
        public int Count;

        [Benchmark]
        public int[] ArrayPerformance()
        {
            int[] items = new int[Count];
            for (int i = 0; i < Count; i++)
                items[i] = i;

            return items;
        }

        [Benchmark]
        public List<int> GenericListPerformanceWithCapacity()
        {
            List<int> items = new List<int>(Count);
            for (int i = 0; i < Count; i++)
                items.Add(i);

            return items;
        }

        [Benchmark]
        public List<int> GenericListPerformanceWithOutCapacity()
        {
            List<int> items = new List<int>();
            for (int i = 0; i < Count; i++)
                items.Add(i);

            return items;
        }
    }
}
