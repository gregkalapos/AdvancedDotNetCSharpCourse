using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Video4_ImplementIDisposableAndFinalizer
{
	class Program
	{
		class SampleClass: IDisposable
		{
			IntPtr intPtr;
			StreamReader streamReader;


			public SampleClass()
			{
				intPtr = Marshal.AllocHGlobal(1000000000);
				streamReader = new StreamReader("sample.txt");
			}

			protected void Dispose(bool itIsSafeToAlsoFreeManagedObjects)
			{
				Marshal.FreeHGlobal(intPtr);

				if (itIsSafeToAlsoFreeManagedObjects)
				{
					if (streamReader != null)
					{
						streamReader.Dispose();
						streamReader = null;
					}
				}
			}

			public void Dispose()
			{
				Dispose(true);
				GC.SuppressFinalize(this);
			}

			~SampleClass()
			{
				Dispose(false);
			}
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
