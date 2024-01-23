``` ini

BenchmarkDotNet=v0.13.1, OS=macOS 14.2.1 (23C71) [Darwin 23.2.0]
Apple M3 Max, 1 CPU, 14 logical and 14 physical cores
.NET SDK=8.0.101
  [Host]     : .NET 8.0.1 (8.0.123.58001), Arm64 RyuJIT
  DefaultJob : .NET 8.0.1 (8.0.123.58001), Arm64 RyuJIT


```
|                        Method |       Mean |     Error |    StdDev |  Gen 0 | Allocated |
|------------------------------ |-----------:|----------:|----------:|-------:|----------:|
|                     NewRandom | 212.001 ns | 4.1147 ns | 3.8489 ns | 0.0086 |      72 B |
|                  SharedRandom |   7.069 ns | 0.0421 ns | 0.0351 ns |      - |         - |
| CryptographicallySecureRandom |  61.272 ns | 0.5298 ns | 0.4956 ns |      - |         - |
