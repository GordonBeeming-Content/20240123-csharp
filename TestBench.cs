using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class MyBenchmark
{
  [Benchmark]
  public int NewRandom()
  {
    return new Random().Next(0, int.MaxValue);
  }

  [Benchmark]
  public int SharedRandom()
  {
      return Random.Shared.Next(0, int.MaxValue);
  }

  [Benchmark]
  public int CryptographicallySecureRandom()
  {
      return RandomNumberGenerator.GetInt32(0, int.MaxValue);
  }
}
