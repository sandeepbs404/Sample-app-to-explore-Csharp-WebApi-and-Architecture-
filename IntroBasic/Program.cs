using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System;
using System.Threading;

namespace IntroBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            var basci = BenchmarkRunner.Run<IntroParams>();
            Console.ReadKey();
        }
    }

    // It is very easy to use BenchmarkDotNet. You should just create a class
    public class IntroParams
    {
        [Params(100, 200)]
        public int A { get; set; }

        [Params(10, 20)]
        public int B { get; set; }

        [Benchmark]
        public void Benchmark() => Thread.Sleep(A + B + 5);
    }
}
