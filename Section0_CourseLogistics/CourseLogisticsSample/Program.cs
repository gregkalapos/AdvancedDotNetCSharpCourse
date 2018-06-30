using System;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace CourseLogisticsSample
{
	public class SampleClass
	{
		public int MyIntProperty { get; set; }
		public void PrintSomething()
		{
			Console.WriteLine("Hi");
		}
	}

	[MemoryDiagnoser]
	public class Program
	{
		[Benchmark]
		public static void Method1()
		{
			for (int i = 0; i < 100_000; i++)
			{
				var byteArray = new byte[1024 * 20];
				Debug.WriteLine(byteArray[0]);
			}
		}

		[Benchmark]
		public static void Method2()
		{
			Random rnd = new Random();
			for (int i = 0; i < 100_000; i++)
			{
				if (rnd.Next() % 2 == 0)
				{
					var obj = new Object();
					Debug.WriteLine(obj.ToString());
				}
			}
		}

		static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Program>();
		}
	}
}
