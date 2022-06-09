namespace AADS;

public abstract partial class CaesarCipher
{
  // Simple rotation cipher
  // Preserves characters not in the alphabet
  // Preserves the case of characters
  public static string[] CaesarCipherDecrypt(string cipher)
  {
    var alphabet = "abcdefghijklmnopqrstuvwxyz";
    var radix = alphabet.Length;

    string[] rotations = new string[radix];

    for (int i = 0; i < radix; i++)
    {
       char[] rotation = cipher.Select(c => {
        int idx = alphabet.IndexOf(c.ToLower());
        if (idx == -1) {
          return c;
        } else {
          var newC = alphabet[(idx + i) % radix];
          bool isUpperCase = c.ToUpper() == c;
          return isUpperCase ? newC.ToUpper() : newC;
        }
      }).ToArray();

      rotations[i] = new string(rotation);
    }

    return rotations;
  }

  public static string? TryCaesarCipherDecrypt(string cipher, string prefix)
  {
    var rotations = CaesarCipherDecrypt(cipher);
    foreach (var rot in rotations)
    {
      if (rot.StartsWith(prefix))
        return rot;
    }
    return null;
  }
}

