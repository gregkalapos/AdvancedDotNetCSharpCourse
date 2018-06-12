using System;

namespace Video1_RefAndManagedPointers
{
	class Program
	{
		public class SampleClass
		{
			public int IntValue { get; set; }
		}

		static void IncrementSampleClass_ByValue(SampleClass sampleClass)
		{
			sampleClass.IntValue++;
		}

		static void SetToNull_ByValue(SampleClass sampleClass)
		{
			sampleClass = null;
		}

		static void SetToNull_ByReference(ref SampleClass sampleClass)
		{
			sampleClass = null;
		}

		static void Main(string[] args)
		{
			var sampleInstance = new SampleClass { IntValue = 42 };
			SetToNull_ByReference(ref sampleInstance);
			if(sampleInstance == null)
			{
				Console.WriteLine("null");
			}
			else
			{
				Console.WriteLine("NOT null");
			}
			int i1 = 42;
			Increment_ByValue(i1);
			Console.WriteLine($"Incement_ByValue executed, i1:{i1}");

			int i2 = 42;
			Increment_ByReference(ref i2);
			Console.WriteLine($"Incement_ByReference executed, i2:{i2}");
		}

		static void Increment_ByValue(int number)
		{
			number++;
		}

		static void Increment_ByReference(ref int number)
		{
			number++;
		}
	}
}
