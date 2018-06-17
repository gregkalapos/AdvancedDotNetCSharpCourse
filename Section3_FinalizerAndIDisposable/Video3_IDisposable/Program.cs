using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Video3_Finalizer
{
	class Program
	{
		static void Main(string[] args)
		{
			using (StreamReader streamReader = new StreamReader("sample.txt"))
			{
				var str = streamReader.ReadToEnd();
			}

			Console.WriteLine("Hello World!");
		}
	}
}
