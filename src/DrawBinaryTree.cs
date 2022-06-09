using System.Diagnostics;

namespace AADS;

public class Tree
{
  string testData = @"a
a b c
b d e
c f g
d h i
e j k
f l m
g n o";

  Dictionary<int, string> idToNodeName;

  public Tree()
  {
    var (adj, idToNodeName) = Parse(testData);
    this.idToNodeName = idToNodeName;
    DrawTree(adj);
  }

  private (Dictionary<int, int[]>, Dictionary<int, string>) Parse(string multilineString)
  {
    var sr = new StringReader(multilineString);

    var nodeNameToId = new Dictionary<string, int>();
    int nextId = 0;
    Func<string, int> assignId = (name) => {
      if (nodeNameToId.ContainsKey(name))
        return nodeNameToId[name];

      nodeNameToId.Add(name, nextId);
      return nextId++;
    };

    int root = assignId(sr.ReadLine() ?? throw new Exception("No first line"));

    Dictionary<int, int[]> adj = new Dictionary<int, int[]>();

    string? line;
    while ((line = sr.ReadLine()) != null)
    {
      var ints = line.Split(" ").Select(assignId);

      int node = ints.First();
      int[] children = ints.TakeLast(ints.Count()-1).ToArray();

      adj.Add(node, children);
    }

    var idToNodeName = new Dictionary<int, string>();
    foreach (var (name, id) in nodeNameToId)
    {
      idToNodeName.Add(id, name);
    }

    return (adj, idToNodeName);
  }

  private void DrawTree(Dictionary<int, int[]> adj)
  {
    int root = 0;
    DepthFirstRecursive(adj, root);
    int rows = maxRow + 1;
    int cols = col + 1;
    string[,] lines = new string[cols, rows];
    foreach (var (row, col, v) in positions)
    {
      lines[col, row] = idToNodeName[v];
    }

    int spacing = 2;

    string spaces = new String(" ") * spacing;
    string dashes = new String("-") * spacing;
    string cSpaces = spaces.Substring(1);
    string cDashes = dashes.Substring(1);

    for (int i = 0; i < rows; i++)
    {
      string first = "";
      bool whiteSpace = true;
      string second = "";
      string third = "";

      for (int j = 0; j < cols; j++)
      {
        string? c = lines[j, i];
        first += (c != null) ? c+cSpaces : spaces;
        second += (c != null) ? "+" + ((!whiteSpace) ? cSpaces : cDashes) : ((whiteSpace) ? spaces : dashes);
        third += (c != null) ? "|" + cSpaces : spaces;
        if (c != null) whiteSpace = !whiteSpace;
      }
      if (i != 0) Console.WriteLine(second);
      if (i != 0) Console.WriteLine(third);
      Console.WriteLine(first);
    }
  }

  List<(int, int, int)> positions = new List<(int, int, int)>();
  int col = 0;
  int maxRow;

  private void DepthFirstRecursive(Dictionary<int, int[]> adj, int v)
  {
    DepthFirstRecursive(adj, v, 0, 0);
  }

  private void DepthFirstRecursive(Dictionary<int, int[]> adj, int v, int row, int nth)
  {
    if (row > maxRow) maxRow = row;
    col += nth;

    positions.Add((row, col, v));

    if (!adj.TryGetValue(v, out int[]? children)) return;

    nth = 0;
    foreach (var w in children)
    {
      DepthFirstRecursive(adj, w, row+1, nth);
      nth++;
    }
  }

  private void DepthFirst(Dictionary<int, int[]> adj, int v)
  {
    var stack = new Stack<int>();
    var discovered = new List<int>();

    stack.Push(v);

    while (!stack.IsEmpty())
    {
      v = stack.Pop();

      if (!discovered.Contains(v))
      {
        discovered.Add(v);
        if (!adj.ContainsKey(v)) continue;
        foreach (var w in adj[v])
        {
          stack.Push(w);
        }
      }
    }
  }

  class Queue<T>
  {
    QueueNode? head;
    QueueNode? tail;

    class QueueNode
    {
      public T value { get; }
      public QueueNode? next;

      public QueueNode(T value)
      {
        this.value = value;
      }
    }

    public bool IsEmpty()
    {
      return head == null;
    }

    public void Push(T value)
    {
      var oldTail = tail;
      tail = new QueueNode(value);

      if (IsEmpty()) head = tail;
      else {
        Debug.Assert(oldTail != null);
        oldTail.next = tail;
      }
    }

    public T Pop()
    {
      if (IsEmpty()) throw new Exception("Queue underflow");
      Debug.Assert(head != null);

      var val = head.value;
      head = head.next;
      if (IsEmpty()) tail = null;
      return val;
    }
  }

  class Stack<T>
  {
    List<T> list = new List<T>();
    int idx = 0;

    public Stack(){}

    public void Push(T item)
    {
      if (idx < list.Count)
        list[idx++] = item;
      else
      {
        list.Add(item);
        idx++;
      }
    }

    public T Pop()
    {
      if (IsEmpty()) throw new Exception("Stack underflow");
      return list[--idx];
    }

    public bool IsEmpty()
    {
      return idx <= 0;
    }

    public override string ToString()
    {
      string str = "";
      for (int i = 0; i < idx; i++)
      {
        if (i == 0)
          str += $"{list[i]}";
        else
          str += $", {list[i]}";
      }

      return $"[{str}] ";
    }
  }
}

class String
{
  private string internalString;

  public override string ToString()
  {
    return internalString;
  }

  public String(string str)
  {
    internalString = str;
  }

  public static string operator *(String str, int i)
  {
    string internalString = str.ToString();
    string outputString = internalString;
    for (int n = i; n > 0; n--)
    {
      outputString += internalString;
    }
    return outputString;
  }
}
