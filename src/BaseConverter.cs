namespace AADS;
using System.Numerics;

public abstract partial class BaseConverter
{
  public static List<BigInteger> ConvertBase(BigInteger number, int newBaseInt) {
    BigInteger newBase = BigInteger.Parse(newBaseInt.ToString());
    List<BigInteger> newNumber = new List<BigInteger>();
    BigInteger quotient = number;
    BigInteger remainder;

    int p = (int) Math.Floor(BigInteger.Log(number) / Math.Log(newBaseInt));

    for (int j = 0; j <= p; j++){
      remainder = quotient % newBase;
      quotient = quotient / newBase;
      newNumber.Add(remainder);
    }
    return newNumber;
  }
}
