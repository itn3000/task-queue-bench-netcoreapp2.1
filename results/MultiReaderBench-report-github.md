``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 8.1 (6.3.9600.0)
Intel Core i7-4770 CPU 3.40GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=3312644 Hz, Resolution=301.8737 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host]     : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT
  Job-CQFBMR : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  Job-DJRETH : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

TargetCount=5  WarmupCount=5  

```
|                    Method |     Toolchain | LoopNum | TaskNum |       Mean |      Error |      StdDev |
|-------------------------- |-------------- |-------- |-------- |-----------:|-----------:|------------:|
| **ThreadingChannelReadMulti** | **.NET Core 2.0** |   **10000** |       **1** |   **642.8 us** |   **2.880 us** |   **0.7479 us** |
| ThreadingChannelReadMulti | .NET Core 2.1 |   10000 |       1 |   660.8 us |  30.731 us |   7.9823 us |
| **ThreadingChannelReadMulti** | **.NET Core 2.0** |   **10000** |     **100** | **1,595.8 us** | **552.248 us** | **143.4444 us** |
| ThreadingChannelReadMulti | .NET Core 2.1 |   10000 |     100 | 2,030.8 us |  36.545 us |   9.4923 us |
