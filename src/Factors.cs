namespace AADS;

public abstract partial class Factors
{
  public static int[] GetFactors(int upperBound)
  {
    return TrialDivision(upperBound);
  }

  private static int[] TrialDivision(int n)
  {
    var factors = new HashSet<int>();

    int f = 2;
    while (n > 1)
    {
      if (n.isDivisibleBy(f))
      {
        factors.Add(n);
        n /= f;
      } else {
        f++;
      }
    }

    return factors.ToArray();
  }

  
}