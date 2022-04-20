using AADS;
using static AADS.Algorithms;

class Examples
{
  public static void Main()
  {
    Example_Prime_GetPrimes();
    Console.WriteLine();
    Example_Datastructure_OArray();
  }

  static void Example_ExtensionMethods_Mod()
  {
    int number = -1;
    int modulus = 10;
    int remainder = number.Mod(modulus);
  }

  static void Example_Prime_GetPrimes()
  {
    int upperBound = 20;
    int[] primes = GetPrimes(upperBound);

    Console.WriteLine($"Example_Prime_GetPrimes...");

    foreach (var p in primes)
      Console.Write($"{p} ");

    Console.WriteLine();
  }

  static void Example_Datastructure_OArray()
  {
    int size = 10;
    OArray<int> oarr = new OArray<int>(size);

    for (int i = 0; i < oarr.Length; i++)
      oarr[i] = i;

    Console.WriteLine($"Example_Datastructure_OArray...");

    Console.WriteLine($"oarr[-1] = {oarr[-1]}");
    Console.WriteLine($"oarr[0] = {oarr[0]}");
    Console.WriteLine($"oarr[1] = {oarr[1]}");
    Console.WriteLine($"oarr[10] = {oarr[10]}");
    Console.WriteLine($"oarr[11] = {oarr[11]}");


    foreach (var num in oarr)
      Console.Write($"{num} ");
    Console.WriteLine();

    int sum = 0;
    foreach (var num in oarr)
      sum += num;

    Console.WriteLine($"sum = {sum}");
  }
}

