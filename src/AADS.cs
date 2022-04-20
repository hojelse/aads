namespace AADS;

public static class UtilExtensionMethods
{
  public static int Rem(this int dividend, int divisor)
  {
    return dividend % divisor;
  }

  public static int Mod(this int dividend, int divisor)
  {
    return ((dividend % divisor) + divisor) % divisor;
  }
}
