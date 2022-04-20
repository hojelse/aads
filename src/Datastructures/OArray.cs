using System.Collections;
namespace AADS.Datastructures;

public class OArray<T> : IEnumerable<T>
{
  T[] arr;

  public int Length {
    get => arr.Length;
  }

  public OArray(int size)
  {
    this.arr = new T[size];
  }

  public T this[int index] {
    get => arr[index.Mod(arr.Length)];
    set => arr[index.Mod(arr.Length)] = value;
  }

  public IEnumerator<T> GetEnumerator()
  {
    return ((IEnumerable<T>)arr).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return arr.GetEnumerator();
  }
}
