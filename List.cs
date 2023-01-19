namespace List;

internal class MyList<T>
{
    public MyList()
    {
        Capacity = 4;
    }

    public MyList(int count)
    {
        Capacity = count;
    }

    public T this[int index]
    {
        set
        {
            if (index > Count || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            arr[index] = value;
        }
        get
        {
            return arr[index];
        }
    }

    public int Capacity { get; set; }
    public int Count { get; set; }
    private T[] arr = new T[4];

    public void Add(T item)
    {
        if (Count == Capacity)
        {
            Capacity *= 2;
            T[] temp = arr;
            arr = new T[Capacity];
            for (int i = 0; i < temp.Length; i++)
            {
                arr[i] = temp[i];
            }
        }
        arr[Count] = item;
        Count++;
    }

    public void Insert(int index, T value)
    {
        if (index > Count || index < 0)
        {
            throw new IndexOutOfRangeException();
        }
        if (Count == Capacity)
        {
            Capacity *= 2;
            T[] temp = arr;
            arr = new T[Capacity];
            arr = temp;
        }

        for (int i = Count; i >= index; i--)
        {
            arr[i + 1] = arr[i];
        }
        arr[index] = value;
        Count++;
    }

    public void RemoveAt(int index)
    {
        for (var i = index + 1; i < arr.Length; i++)
        {
            arr[i - 1] = arr[i];
        }
        Count--;
    }

    public int IndexOf(T item)
    {
        for (int i = 0; i < Count; i++)
        {
            dynamic t1 = arr[i]!;
            dynamic t2 = item!;
            if (t1 == t2)
                return i;
        }
        return -1;
    }

    public int LastIndexOf(T item)
    {
        int cnt = 0;
        for (int i = Count - 1; i >= 0; i--)
        {
            dynamic t1 = arr[i]!;
            dynamic t2 = item!;
            if (t1 == t2)
            {
                return cnt;
            }
            cnt++;
        }
        return -1;
    }

    public void Sort()
    {
        Array.Sort(arr, 0, Count);
    }
}