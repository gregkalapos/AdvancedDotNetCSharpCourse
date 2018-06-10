using System;
using System.Diagnostics;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Video2_MatrixPerfSample_RefVsValue
{
	public struct Matrix
	{
		public readonly int i00, i01, i02;
		public readonly int i10, i11, i12;
		public readonly int i20, i21, i22;

		public Matrix(int i00, int i01, int i02, int i10, int i11, int i12, int i20, int i21, int i22)
		{
			this.i00 = i00;
			this.i01 = i01;
			this.i02 = i02;

			this.i10 = i10;
			this.i11 = i11;
			this.i12 = i12;

			this.i20 = i20;
			this.i21 = i21;
			this.i22 = i22;
		}
	}

	public class Program
	{
		static void Main(string[] args)
		{
			var summary = BenchmarkRunner.Run<Program>();
		}

		[Benchmark]
		public static void RefReturnPerf()
		{
			Random rnd = new Random();
			for (int i = 0; i < 100; i++)
			{
				Matrix m1 = new Matrix(N(), N(), N(), N(), N(), N(), N(), N(), N());
				Matrix m2 = new Matrix(N(), N(), N(), N(), N(), N(), N(), N(), N());

				ref Matrix biggerMatrix = ref GetBiggerByReference(ref m1, ref m2);
				Debug.WriteLine(biggerMatrix.i00);
			}
			
			int N() => rnd.Next(Int32.MaxValue / 5);
		}

		[Benchmark]
		public static void RetByValuePerf()
		{
			Random rnd = new Random();
			for (int i = 0; i < 100; i++)
			{
				Matrix m1 = new Matrix(N(), N(), N(), N(), N(), N(), N(), N(), N());
				Matrix m2 = new Matrix(N(), N(), N(), N(), N(), N(), N(), N(), N());

				Matrix biggerMatrix = GetBiggerByValue(m1, m2);
				Debug.WriteLine(biggerMatrix.i00);
			}

			int N() => rnd.Next(Int32.MaxValue / 5);
		}



		public static Matrix GetBiggerByValue(Matrix matrix1, Matrix matrix2)
		{
			var sum1 = matrix1.i00 + matrix1.i01 + matrix1.i02 +
						matrix1.i10 + matrix1.i11 + matrix1.i12 +
						matrix1.i20 + matrix1.i21 + matrix1.i22;

			var sum2 = matrix2.i00 + matrix2.i01 + matrix2.i02 +
						matrix2.i10 + matrix2.i11 + matrix2.i12 +
						matrix2.i20 + matrix2.i21 + matrix2.i22;

			if (sum2 > sum1)
				return matrix2;
			else
				return matrix1;
		}

		public static ref Matrix GetBiggerByReference(ref Matrix matrix1, ref Matrix matrix2)
		{
			var sum1 = matrix1.i00 + matrix1.i01 + matrix1.i02 +
						matrix1.i10 + matrix1.i11 + matrix1.i12 +
						matrix1.i20 + matrix1.i21 + matrix1.i22;

			var sum2 = matrix2.i00 + matrix2.i01 + matrix2.i02 +
						matrix2.i10 + matrix2.i11 + matrix2.i12 +
						matrix2.i20 + matrix2.i21 + matrix2.i22;

			if (sum2 > sum1)
				return ref matrix2;
			else
				return ref matrix1;
		}
	}
}
