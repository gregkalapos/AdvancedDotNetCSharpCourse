using System;
using System.Collections.Generic;
using System.Linq;

namespace Video2_RefReturAndRefLocal
{
	class Program
	{
		public class SampleClass
		{
			private int _intField;

			public int IntProperty { get => _intField; set => _intField = value; }

			public ref int M() => ref _intField;
		}

		static void Main(string[] args)
		{
			MyList l = new MyList();
			ref int i = ref l.GetRefToSmallestItem();
			i = 42;

			Console.WriteLine("Hello World!");
		}

		public static ref int MethodReturningIntByRef(ref int intValue)
		{
			//...do something with 'intValue'
			return ref intValue;
		}


		public static ref object MethodReturningObjByRef(ref object obj)
		{
			//...do something with 'obj'
			return ref obj;
		}
		
		class MyList
		{
			private int[] _items = { 3, 4, 7, 1, 4, 6 };

			public ref int GetRefToSmallestItem()
			{
				var smallest = _items[0];
				int index = 0;

				for (int i = 1; i < _items.Length; i++)
				{
					if (_items[i] < smallest)
					{
						smallest = _items[i];
						index = i;
					}
				}

				return ref _items[index];
			}
		}
	}
}
