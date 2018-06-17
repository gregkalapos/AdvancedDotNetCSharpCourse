using System;

namespace Video1_StructLayout
{
	struct Struct1
	{
		public byte b1;
		public double d1;
		public byte b2;
		public double d2;
		public byte b3;
	}

	struct Struct2
	{
		public double d1;
		public double d2;
		public byte b1;
		public byte b2;
		public byte b3;
	}

	class Program
	{
		static void Main(string[] args)
		{
			unsafe
			{
				Console.WriteLine("Struct1: " + sizeof(Struct1));
				Console.WriteLine("Struct2: " + sizeof(Struct2));
			}
		}
	}
}
