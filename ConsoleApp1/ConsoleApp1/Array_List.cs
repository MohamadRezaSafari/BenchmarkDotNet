using BenchmarkDotNet.Attributes;
using Perfolizer.Mathematics.Randomization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    [MemoryDiagnoser]
    [Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class Array_List
    {
        int[] numbersArr = new int[500]; 
        List<int> numbersList = new List<int>(500);  

        [GlobalSetup]
        public void GlobalSetup()
        {
            for (int i = 0; i <= 500; i++)
            {
                //numbersArr[i] = i;
                numbersList.Add(1);
            }

            //for (int i = 1; i <= 100; i++)
            //{
            //    array[i] = i.ToString();
            //    list.Add(i.ToString());
            //}
        }

        [Benchmark]
        public int Single() => numbersList.SingleOrDefault(x => x.Equals(10));

        [Benchmark]
        public int First() => numbersList.FirstOrDefault(x => x.Equals(10));
        //[Benchmark]
        //public void ArraySearch() => Console.WriteLine();

        //[Benchmark]
        //public void ListSearch() => list.Where(i => i == "100").First();

        //[Benchmark]
        //public string ArraySearch() => array.Where(i => i == "100").First();

        //[Benchmark]
        //public string ListSearch() => list.Where(i => i == "100").First();
    }
}
