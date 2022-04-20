using System.Collections.Generic;

namespace AADS;

public class Primes
{
  public static int[] GetPrimes(int upperBound)
  {
    return Sieve_of_Eratosthenes(upperBound);
  }

  private static int[] Sieve_of_Eratosthenes(int upperBound)
  {
    bool[] isPrime = new bool[upperBound];

    for (int i = 2; i < isPrime.Length; i++)
      isPrime[i] = true;

    for (int i = 2; i < isPrime.Length; i++)
      if (isPrime[i])
        for (int j = i*i; j < isPrime.Length; j += i)
          isPrime[j] = false;

    List<int> primes = new List<int>();

    for (int i = 2; i < isPrime.Length; i++)
      if (isPrime[i])
        primes.Add(i);

    return primes.ToArray();
  }

}