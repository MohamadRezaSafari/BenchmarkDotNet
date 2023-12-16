using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test
    {
        [GlobalSetup]
        public void GlobalSetup()
        {
            //for (int i = 1; i <= 100; i++)
            //{
            //    _array[i] = i.ToString();
            //    _arrayInt[i] = i;
            //    _arrayObj.Add(i);
            //}
        }

        [Benchmark]
        public void Str1()
        {
            Console.WriteLine($"Hi");
        }

        [Benchmark]
        public void Str2()
        {
            var str = string.Concat("Hi");
            Console.WriteLine(str);
        }
    }
}
