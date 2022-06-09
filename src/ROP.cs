namespace AADS;

public class Trie<T,U>
{
  public static int radix = char.MaxValue;

  public Node root = new Node();
  public int n;

  // R-way trie node
  public class Node {
    public U? value;
    public Node[] children = new Node[radix];
  }

  public void Insert(char[] key, U value)
  {
    Node curr = root;
    for (int i = 0; i < key.Length; i++)
    {
      if (curr.children[key[i]] == default(Node))
      {
        curr.children[key[i]] = new Node();
      }
      curr = curr.children[key[i]];
    }
    curr.value = value;
  }

  public U? Find(char[] key)
  {
    Node curr = root;
    for (int i = 0; i < key.Length; i++)
    {
      if (curr.children[key[i]] == default(Node))
      {
        return default(U);
      }
      curr = curr.children[key[i]];
    }
    return curr.value;
  }

}


public class ROP
{

  public static string FindGadgets(byte[] input)
  {
    Console.WriteLine(char.MaxValue);
    return "hej";
    // var st = new Trie<byte[], string>();
    // foreach (var pop in popqDescr)
    // {
      
    // }
    // st.Insert("", "'hej' er en sætning");
    // st.Insert("a", "'a' er en sætning");
    // var x = st.Find("hej");
    // Console.WriteLine(st.Find("hej"));
    // Console.WriteLine(st.Find("a"));
    // Console.WriteLine(st.Find("nej"));
    // return x;
  }

  static byte[] testInput = new byte[] {
    0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x01, 0x00, 0x00, 0x00, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xc7, 0x07, 0x58, 0x90, 0x90, 0x90, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xc7, 0x07, 0x6d, 0x50, 0x90, 0x90, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x48, 0x89, 0xc7, 0xc2, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x48, 0x89, 0xc7, 0xc3, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x88, 0xc7, 0x2e, 0x58, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xc7, 0x07, 0x48, 0x88, 0xc7, 0x90, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x1a, 0x48, 0x90, 0xc3, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xc7, 0x07, 0x48, 0x89, 0xc7, 0x90, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x01, 0x00, 0x00, 0x00, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x48, 0x8d, 0x04, 0x37, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x89, 0xca, 0x90, 0xc3, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0xc9, 0xc1, 0x20, 0xdb, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xc7, 0x07, 0x89, 0xc1, 0xc1, 0x52, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x89, 0xd6, 0x38, 0xdb, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x81, 0xca, 0x08, 0xdb, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x48, 0x89, 0xe0, 0x94, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x99, 0xca, 0x08, 0xc9, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xc7, 0x07, 0xa9, 0xca, 0x08, 0xc9, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x89, 0xc1, 0x20, 0xc9, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x89, 0xca, 0x20, 0xd2, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x09, 0xd6, 0x38, 0xd2, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x89, 0xc1, 0x92, 0x90, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x09, 0xd6, 0x90, 0x90, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xc7, 0x07, 0x89, 0xd6, 0x60, 0xd2, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0xa9, 0xc1, 0x84, 0xc9, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xc7, 0x07, 0x89, 0xd6, 0x30, 0xd2, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x09, 0xca, 0x20, 0xc9, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xc7, 0x07, 0x89, 0xd6, 0x30, 0xdb, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x89, 0xc1, 0x20, 0xd2, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x48, 0x8d, 0xe0, 0x90, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x88, 0xc1, 0x90, 0xc3, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x89, 0xca, 0x78, 0xd2, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x48, 0xa9, 0xe0, 0x90, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x99, 0xc1, 0x38, 0xdb, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xc7, 0x07, 0x48, 0x89, 0xe0, 0xc3, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x8d, 0xd6, 0x84, 0xc0, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x40, 0x89, 0xe0, 0xc3, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x5a, 0x68, 0x89, 0xe0, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x89, 0xd6, 0x08, 0xd2, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0x48, 0x89, 0xe0, 0xc3, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0xc9, 0xca, 0x08, 0xdb, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0x8d, 0x87, 0xc8, 0x89, 0xe0, 0xc3, 0xc3, 0xf3, 0x0f, 0x1e, 0xfa, 0xb8, 0x01, 0x00, 0x00, 0x00, 0xc3
  };

  static byte retq = 0xc3;

  static Dictionary<byte[], string> functionalNop = new Dictionary<byte[], string> {
    {new byte[] { 0x20, 0xc0 }, "andb %a1"},
    {new byte[] { 0x20, 0xc9 }, "andb %c1"},
    {new byte[] { 0x20, 0xd2 }, "andb %d1"},
    {new byte[] { 0x20, 0xdb }, "andb %b1"},
    {new byte[] { 0x08, 0xc0 }, "orb %a1"},
    {new byte[] { 0x08, 0xc9 }, "orb %c1"},
    {new byte[] { 0x08, 0xd2 }, "orb %d1"},
    {new byte[] { 0x08, 0xdb }, "orb %b1"},
    {new byte[] { 0x38, 0xc0 }, "cmpb %a1"},
    {new byte[] { 0x38, 0xc9 }, "cmpb %c1"},
    {new byte[] { 0x38, 0xd2 }, "cmpb %d1"},
    {new byte[] { 0x38, 0xdb }, "cmpb %b1"},
    {new byte[] { 0x84, 0xc0 }, "testb %a1"},
    {new byte[] { 0x84, 0xc9 }, "testb %c1"},
    {new byte[] { 0x84, 0xd2 }, "testb %d1"},
    {new byte[] { 0x84, 0xdb }, "testb %b1"},
  };

  static Dictionary<byte, string> popqDescr = new Dictionary<byte, string> {
    {0x58, "popq %rax"},
    {0x59, "popq %rcx"},
    {0x5a, "popq %rdx"},
    {0x5b, "popq %rbx"},
    {0x5c, "popq %rsp"},
    {0x5d, "popq %rbp"},
    {0x5e, "popq %rsi"},
    {0x5f, "popq %rdi"},
  };

  static byte[] movlPrefix = new byte[] { 0x89 };
  static byte[] movqPrefix = new byte[] { 0x48, 0x89 };

  static Dictionary<byte, string> movMap = new Dictionary<byte, string> {
    {0xc0, "%rax %rax"},
    {0xc1, "%rax %rcx"},
    {0xc2, "%rax %rdx"},
    {0xc3, "%rax %rbx"},
    {0xc4, "%rax %rsp"},
    {0xc5, "%rax %rbp"},
    {0xc6, "%rax %rsi"},
    {0xc7, "%rax %rdi"},
    {0xc8, "%rcx %rax"},
    {0xc9, "%rcx %rcx"},
    {0xca, "%rcx %rdx"},
    {0xcb, "%rcx %rbx"},
    {0xcc, "%rcx %rsp"},
    {0xcd, "%rcx %rbp"},
    {0xce, "%rcx %rsi"},
    {0xcf, "%rcx %rdi"},
    {0xd0, "%rdx %rax"},
    {0xd1, "%rdx %rcx"},
    {0xd2, "%rdx %rdx"},
    {0xd3, "%rdx %rbx"},
    {0xd4, "%rdx %rsp"},
    {0xd5, "%rdx %rbp"},
    {0xd6, "%rdx %rsi"},
    {0xd7, "%rdx %rdi"},
    {0xd8, "%rbx %rax"},
    {0xd9, "%rbx %rcx"},
    {0xda, "%rbx %rdx"},
    {0xdb, "%rbx %rbx"},
    {0xdc, "%rbx %rsp"},
    {0xdd, "%rbx %rbp"},
    {0xde, "%rbx %rsi"},
    {0xdf, "%rbx %rdi"},
    {0xe0, "%rsp %rax"},
    {0xe1, "%rsp %rcx"},
    {0xe2, "%rsp %rdx"},
    {0xe3, "%rsp %rbx"},
    {0xe4, "%rsp %rsp"},
    {0xe5, "%rsp %rbp"},
    {0xe6, "%rsp %rsi"},
    {0xe7, "%rsp %rdi"},
    {0xe8, "%rbp %rax"},
    {0xe9, "%rbp %rcx"},
    {0xea, "%rbp %rdx"},
    {0xeb, "%rbp %rbx"},
    {0xec, "%rbp %rsp"},
    {0xed, "%rbp %rbp"},
    {0xee, "%rbp %rsi"},
    {0xef, "%rbp %rdi"},
    {0xf0, "%rsi %rax"},
    {0xf1, "%rsi %rcx"},
    {0xf2, "%rsi %rdx"},
    {0xf3, "%rsi %rbx"},
    {0xf4, "%rsi %rsp"},
    {0xf5, "%rsi %rbp"},
    {0xf6, "%rsi %rsi"},
    {0xf7, "%rsi %rdi"},
    {0xf8, "%rdi %rax"},
    {0xf9, "%rdi %rcx"},
    {0xfa, "%rdi %rdx"},
    {0xfb, "%rdi %rbx"},
    {0xfc, "%rdi %rsp"},
    {0xfd, "%rdi %rbp"},
    {0xfe, "%rdi %rsi"},
    {0xff, "%rdi %rdi"},
  };

}

