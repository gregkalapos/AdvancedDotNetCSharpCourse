using System;
using System.Diagnostics;

namespace Video2_Finalizer_GC
{
	class SampleClass
	{
		public int MyProperty { get; set; }
		~SampleClass()
		{
			long sum = 0;
			Random rnd = new Random();
			while (true)
			{
				sum += rnd.Next(-2, 2);
			}
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var rnd = new Random();
			while (true)
			{
				var sapleInstance = new SampleClass() { MyProperty = rnd.Next() };
				Debug.WriteLine(sapleInstance.MyProperty);
				GC.SuppressFinalize(sapleInstance);
				GC.ReRegisterForFinalize(sapleInstance);
			}

			Console.ReadKey();
		}
	}
}
