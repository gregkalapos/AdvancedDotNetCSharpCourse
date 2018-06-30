``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300
  [Host]     : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT
  DefaultJob : .NET Core 2.1.0 (CoreCLR 4.6.26515.07, CoreFX 4.6.26515.06), 64bit RyuJIT


```
|  Method |         Mean |      Error |     StdDev |        Gen 0 |    Allocated |
|-------- |-------------:|-----------:|-----------:|-------------:|-------------:|
| Method1 | 124,812.6 us | 758.519 us | 672.407 us | 1298687.5000 | 2050400000 B |
| Method2 |     958.4 us |   3.987 us |   3.534 us |            - |        280 B |
