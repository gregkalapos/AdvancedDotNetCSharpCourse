using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video1_ExceptionFilter_Syntax
{

	class Program
	{
		public static void Main(String[] args)
		{
			Method_Filter();
		}

		static void Method_Filter()
		{
			try
			{
				MethodThrowing();
			}
			catch (Exception e) when (e.Message == "Bamm")
			{
				Console.WriteLine("BammException");
			}
		}

		static void Method_PlainCatchBlock()
		{
			try
			{
				MethodThrowing();
			}
			catch (Exception e)
			{
				if (e.Message == "Bamm")
				{
					Console.WriteLine("BammException");
				}
				else
				{
					throw;
				}
			}
		}

		static void MethodThrowing() => throw new Exception("Bamm");
	}
}
