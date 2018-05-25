``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 8.1 (6.3.9600.0)
Intel Core i7-4770 CPU 3.40GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=3312644 Hz, Resolution=301.8737 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host]     : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT
  Job-UXIICZ : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  Job-XRYVVC : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

TargetCount=5  WarmupCount=5  

```
|                 Method |     Toolchain | LoopNum | TaskNum |             Mean |             Error |            StdDev |
|----------------------- |-------------- |-------- |-------- |-----------------:|------------------:|------------------:|
|              **TaskYield** | **.NET Core 2.0** |   **10000** |       **1** |       **2,241.1 ns** |      **1,066.232 ns** |        **276.950 ns** |
|      TaskCompletedTask | .NET Core 2.0 |   10000 |       1 |         380.8 ns |         50.682 ns |         13.165 ns |
|         TaskYieldQueue | .NET Core 2.0 |   10000 |       1 |     167,983.8 ns |      3,393.550 ns |        881.462 ns |
| TaskCompletedTaskQueue | .NET Core 2.0 |   10000 |       1 |     146,255.0 ns |      1,873.387 ns |        486.605 ns |
|              TaskYield | .NET Core 2.1 |   10000 |       1 |       1,745.5 ns |         47.047 ns |         12.220 ns |
|      TaskCompletedTask | .NET Core 2.1 |   10000 |       1 |         343.2 ns |         16.505 ns |          4.287 ns |
|         TaskYieldQueue | .NET Core 2.1 |   10000 |       1 |     164,078.1 ns |      4,497.357 ns |      1,168.172 ns |
| TaskCompletedTaskQueue | .NET Core 2.1 |   10000 |       1 |     154,224.7 ns |     31,289.319 ns |      8,127.284 ns |
|              **TaskYield** | **.NET Core 2.0** |   **10000** |      **10** |       **7,523.3 ns** |         **77.052 ns** |         **20.014 ns** |
|      TaskCompletedTask | .NET Core 2.0 |   10000 |      10 |         740.3 ns |         53.082 ns |         13.788 ns |
|         TaskYieldQueue | .NET Core 2.0 |   10000 |      10 |  47,629,539.8 ns | 23,368,364.764 ns |  6,069,845.807 ns |
| TaskCompletedTaskQueue | .NET Core 2.0 |   10000 |      10 |   1,510,740.6 ns |     30,819.654 ns |      8,005.291 ns |
|              TaskYield | .NET Core 2.1 |   10000 |      10 |       6,911.2 ns |         96.589 ns |         25.089 ns |
|      TaskCompletedTask | .NET Core 2.1 |   10000 |      10 |         682.6 ns |          5.609 ns |          1.457 ns |
|         TaskYieldQueue | .NET Core 2.1 |   10000 |      10 | 109,910,750.3 ns | 38,099,776.419 ns |  9,896,275.178 ns |
| TaskCompletedTaskQueue | .NET Core 2.1 |   10000 |      10 |   1,616,248.8 ns |     90,775.325 ns |     23,578.553 ns |
|              **TaskYield** | **.NET Core 2.0** |   **10000** |     **100** |      **65,878.0 ns** |        **437.995 ns** |        **113.768 ns** |
|      TaskCompletedTask | .NET Core 2.0 |   10000 |     100 |       3,736.7 ns |        200.539 ns |         52.089 ns |
|         TaskYieldQueue | .NET Core 2.0 |   10000 |     100 |  85,907,939.0 ns | 11,902,333.222 ns |  3,091,586.773 ns |
| TaskCompletedTaskQueue | .NET Core 2.0 |   10000 |     100 |  16,514,585.9 ns |    487,745.707 ns |    126,690.133 ns |
|              TaskYield | .NET Core 2.1 |   10000 |     100 |      61,800.2 ns |      1,562.746 ns |        405.917 ns |
|      TaskCompletedTask | .NET Core 2.1 |   10000 |     100 |       3,551.0 ns |        238.650 ns |         61.988 ns |
|         TaskYieldQueue | .NET Core 2.1 |   10000 |     100 | 132,993,820.1 ns | 46,024,119.035 ns | 11,954,593.691 ns |
| TaskCompletedTaskQueue | .NET Core 2.1 |   10000 |     100 |  16,002,552.8 ns |  2,606,320.669 ns |    676,982.097 ns |
