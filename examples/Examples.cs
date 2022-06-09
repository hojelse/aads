using AADS;
// using static AADS.BaseConverter;
// using static AADS.CaesarCipher;
// using static AADS.PrimeSieve;

class Examples
{
  public static void Main()
  {
    new AADS.Tree();
    // ROP.FindGadgets(new byte[] {0x1});
  //   Example_Prime_GetPrimes();
  //   Console.WriteLine();

  //   Example_Datastructure_OArray();
  //   Console.WriteLine();

  //   Example_ConvertBase();
  //   Console.WriteLine();
    
  //   Example_TryCaesarCipherDecrypt();
  //   Console.WriteLine();
  }

  static void Example_TryCaesarCipherDecrypt()
  {
    string cipher = "cvpbPGS{arkg_gvzr_V'yy_gel_2_ebhaqf_bs_ebg13_uJdSftmh}";
    var clear = CaesarCipher.TryCaesarCipherDecrypt(cipher, "picoCTF");
    Console.WriteLine(clear);
  }

  static void Example_ConvertBase()
  {
    int newBase = 256;
    string decimalNumber = "13016382529449106065927291425342535437996222135352905256639647889241102700065917";

    var input = System.Numerics.BigInteger.Parse(decimalNumber);
    var output = BaseConverter.ConvertBase(input, newBase);

    // Print as readable text
    output.Reverse();
    Console.WriteLine(output.Select(x => (char)x).ToArray());
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
    int[] primes = PrimeSieve.GetPrimes(upperBound);

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

