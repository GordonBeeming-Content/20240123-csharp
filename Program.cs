using System;

static class Program
{
  public static void Main()
  {
    var rnd = new Random();
    var rnd2 = new Random();
    Console.WriteLine(rnd.Next());
    Console.WriteLine(rnd2.Next());
  }
}
