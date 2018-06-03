using System;

namespace Video1_RefAndManagedPointers
{
	class Program
	{
		class SampleClass
		{
			public int IntValue { get; set; }
		}

		static void Main(string[] args)
		{
			int i = 42;
			Increment_ByValue(i);
			Console.WriteLine($"Incement_ByValue executed, i:{i}");

			Increment_ByReference(ref i);
			Console.WriteLine($"Incement_ByReference executed, i:{i}");

			var sampleInstance = new SampleClass { IntValue = 42 };
			IncrementSampleClass_ByValue(sampleInstance);
			Console.WriteLine($"sampleInstance.IntValue: {sampleInstance.IntValue}");

			SetToNull_ByReference(ref sampleInstance);
			if(sampleInstance == null)
			{
				Console.WriteLine("null");
			}
			else
			{
				Console.WriteLine("NOT null");
			}
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
