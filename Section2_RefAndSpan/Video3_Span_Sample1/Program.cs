using System;

namespace Video3_Span_Sample1
{
	class Program
	{
		static void Main(string[] args)
		{
			Span<byte> span = new Span<byte>(new byte[] { 2, 4, 4, 1 });
			var newSpan = span.Slice(3, 2);
			span[1] = 42;
		}
	}
}
