using BenchmarkDotNet.Attributes;
using Perfolizer.Mathematics.Randomization;

namespace ConsoleApp1
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Array_List
    {
        private string[] array;
        private List<string> list;

        [GlobalSetup]
        public void GlobalSetup()
        {
            for (int i = 1; i <= 100; i++)
            {
                array[i] = i.ToString();
                list.Add(i.ToString());
            }
        }

        [Benchmark]
        public void ArraySearch() => Console.WriteLine();

        [Benchmark]
        public void ListSearch() => list.Where(i => i == "100").First();

        //[Benchmark]
        //public string ArraySearch() => array.Where(i => i == "100").First();

        //[Benchmark]
        //public string ListSearch() => list.Where(i => i == "100").First();
    }
}
