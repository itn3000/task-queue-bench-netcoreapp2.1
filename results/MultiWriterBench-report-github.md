``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 8.1 (6.3.9600.0)
Intel Core i7-4770 CPU 3.40GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
Frequency=3312644 Hz, Resolution=301.8737 ns, Timer=TSC
.NET Core SDK=2.1.300-rc1-008673
  [Host]     : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT
  Job-DJHURE : .NET Core 2.0.6 (CoreCLR 4.6.26212.01, CoreFX 4.6.26212.01), 64bit RyuJIT
  Job-TRNJLR : .NET Core 2.1.0-rc1 (CoreCLR 4.6.26426.02, CoreFX 4.6.26426.04), 64bit RyuJIT

TargetCount=5  WarmupCount=5  

```
|                    Method |     Toolchain | LoopNum | TaskNum |     Mean |     Error |    StdDev |
|-------------------------- |-------------- |-------- |-------- |---------:|----------:|----------:|
| **ThreadingChannelWriteOnly** | **.NET Core 2.0** |   **10000** |       **1** | **446.0 us** |  **21.18 us** |  **5.501 us** |
| ThreadingChannelWriteOnly | .NET Core 2.1 |   10000 |       1 | 441.9 us |  24.05 us |  6.248 us |
| **ThreadingChannelWriteOnly** | **.NET Core 2.0** |   **10000** |     **100** | **999.2 us** | **104.85 us** | **27.234 us** |
| ThreadingChannelWriteOnly | .NET Core 2.1 |   10000 |     100 | 716.7 us |  28.08 us |  7.293 us |
