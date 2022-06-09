namespace AADS;

public static class ExtensionMethods
{
  public static int Rem(this int dividend, int divisor)
  {
    return dividend % divisor;
  }

  public static int Mod(this int number, int modulus)
  {
    return ((number % modulus) + modulus) % modulus;
  }

  public static bool isEven(this int num)
  {
    return isDivisibleBy(num, 2);
  }

  public static bool isDivisibleBy(this int num, int divisor)
  {
    return num % divisor == 0;
  }

  public static char ToUpper(this char c)
  {
    return (c+"").ToUpper()[0];
  }

  public static char ToLower(this char c)
  {
    return (c+"").ToLower()[0];
  }
}
