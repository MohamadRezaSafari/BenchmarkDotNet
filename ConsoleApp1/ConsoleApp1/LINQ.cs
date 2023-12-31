﻿using BenchmarkDotNet.Attributes;

namespace ConsoleApp1
{
    public class BenchmarkLINQPerformance
    {
        private readonly List<string> data = new List<string>();

        [GlobalSetup]
        public void GlobalSetup()
        {
            for (int i = 65; i < 90; i++)
            {
                char c = (char)i;
                data.Add(c.ToString());
            }
        }

        [Benchmark]
        public string Single() => data.SingleOrDefault(x => x.Equals("M"));

        [Benchmark]
        public string First() => data.FirstOrDefault(x => x.Equals("M"));
    }

}
