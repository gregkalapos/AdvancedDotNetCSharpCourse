using System;
using System.Diagnostics;
using System.Threading;

namespace Video1_Finalizer
{
	class SampleClass
	{
		~SampleClass()
		{
			Program.PrintThreadInfo("Finalizer", Thread.CurrentThread);
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			PrintThreadInfo("Main", Thread.CurrentThread);

			var sampleInstance = new SampleClass();
			sampleInstance = null;
						
			GC.Collect();
			Console.ReadKey();
		}

		public static void PrintThreadInfo(string str, Thread thread)
		{
			Console.WriteLine($"{str} Priority: {thread.Priority}");
			Console.WriteLine($"{str} ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
		}
	}
}
