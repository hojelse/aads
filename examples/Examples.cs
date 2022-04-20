using System;

class Examples
{
  public static void Main()
  {
    Example_Prime_GetPrimes();
  }

  static void Example_Prime_GetPrimes()
  {
    int upperBound = 20;
    int[] primes = AADS.Primes.GetPrimes(upperBound);

    Console.WriteLine($"Printing primes from 2 to {upperBound} ...");

    foreach (var p in primes)
      Console.Write($"{p} ");

    Console.WriteLine();
  }
}

