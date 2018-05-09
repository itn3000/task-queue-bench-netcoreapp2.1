``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 8.1 (6.3.9600.0)
Intel Core i7-4770 CPU 3.40GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=3312640 Hz, Resolution=301.8740 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host]     : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT
  Job-FMEWTN : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  Job-JCACMB : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

TargetCount=5  WarmupCount=5  

```
|                 Method |     Toolchain | LoopNum | TaskNum |             Mean |             Error |           StdDev |
|----------------------- |-------------- |-------- |-------- |-----------------:|------------------:|-----------------:|
|              **TaskYield** | **.NET Core 2.0** |   **10000** |       **1** |       **2,088.5 ns** |         **25.754 ns** |         **6.689 ns** |
|      TaskCompletedTask | .NET Core 2.0 |   10000 |       1 |         375.0 ns |         24.635 ns |         6.399 ns |
|         TaskYieldQueue | .NET Core 2.0 |   10000 |       1 |     171,802.1 ns |      5,031.695 ns |     1,306.964 ns |
| TaskCompletedTaskQueue | .NET Core 2.0 |   10000 |       1 |     149,919.3 ns |      4,429.630 ns |     1,150.580 ns |
|              TaskYield | .NET Core 2.1 |   10000 |       1 |       1,830.0 ns |         45.332 ns |        11.775 ns |
|      TaskCompletedTask | .NET Core 2.1 |   10000 |       1 |         376.8 ns |          8.663 ns |         2.250 ns |
|         TaskYieldQueue | .NET Core 2.1 |   10000 |       1 |     170,171.0 ns |     15,004.073 ns |     3,897.252 ns |
| TaskCompletedTaskQueue | .NET Core 2.1 |   10000 |       1 |     150,311.5 ns |      4,981.072 ns |     1,293.815 ns |
|              **TaskYield** | **.NET Core 2.0** |   **10000** |      **10** |       **7,504.0 ns** |        **394.081 ns** |       **102.361 ns** |
|      TaskCompletedTask | .NET Core 2.0 |   10000 |      10 |         760.9 ns |         55.442 ns |        14.401 ns |
|         TaskYieldQueue | .NET Core 2.0 |   10000 |      10 |  29,251,121.0 ns | 13,772,221.666 ns | 3,577,283.339 ns |
| TaskCompletedTaskQueue | .NET Core 2.0 |   10000 |      10 |   1,565,564.5 ns |     32,855.059 ns |     8,533.979 ns |
|              TaskYield | .NET Core 2.1 |   10000 |      10 |       6,890.5 ns |        113.640 ns |        29.518 ns |
|      TaskCompletedTask | .NET Core 2.1 |   10000 |      10 |         725.5 ns |         10.442 ns |         2.712 ns |
|         TaskYieldQueue | .NET Core 2.1 |   10000 |      10 |  64,684,019.0 ns | 15,594,655.525 ns | 4,050,653.754 ns |
| TaskCompletedTaskQueue | .NET Core 2.1 |   10000 |      10 |   1,664,589.9 ns |     52,411.284 ns |    13,613.636 ns |
|              **TaskYield** | **.NET Core 2.0** |   **10000** |     **100** |      **64,554.5 ns** |      **2,616.702 ns** |       **679.679 ns** |
|      TaskCompletedTask | .NET Core 2.0 |   10000 |     100 |       3,912.9 ns |        215.501 ns |        55.975 ns |
|         TaskYieldQueue | .NET Core 2.0 |   10000 |     100 |  56,853,397.1 ns | 14,165,311.289 ns | 3,679,386.906 ns |
| TaskCompletedTaskQueue | .NET Core 2.0 |   10000 |     100 |  16,994,759.1 ns |    318,852.054 ns |    82,820.635 ns |
|              TaskYield | .NET Core 2.1 |   10000 |     100 |      61,726.9 ns |      2,627.345 ns |       682.443 ns |
|      TaskCompletedTask | .NET Core 2.1 |   10000 |     100 |       3,772.9 ns |        210.400 ns |        54.651 ns |
|         TaskYieldQueue | .NET Core 2.1 |   10000 |     100 | 119,756,983.9 ns | 30,738,126.367 ns | 7,984,113.965 ns |
| TaskCompletedTaskQueue | .NET Core 2.1 |   10000 |     100 |  16,218,704.5 ns |    435,904.558 ns |   113,224.587 ns |
