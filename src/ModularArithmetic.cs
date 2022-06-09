public abstract partial class ModularArithmetic
{
  public static int LCM(int a, int b)
  {
    var dividend = a * b;
    var divisor = GCD(a, b);
    return dividend/divisor;
  }

  public static int GCD(int a, int b)
  {
    return EuclideanAlgorithm(a, b);
  }

  private static int EuclideanAlgorithm(int a, int b)
  {
    int dividend = a;
    int divisor = b;
    int quotient = a / b;
    int remainder = a % b;

    while(remainder != 0)
    {
      dividend = divisor;
      divisor = remainder;
      quotient = dividend / divisor;
      remainder = dividend % divisor;
    }

    return divisor;
  }
}