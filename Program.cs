using List;

MyList<int> l = new MyList<int>();
for (int i = 15; i > 1; i--)
{
    l.Add(i);
}
l.Insert(5, 1000);

l.RemoveAt(0);
Console.WriteLine(l.Count);
Console.WriteLine(l.Capacity);

l.Sort();
for (int i = 0; i < l.Count; i++)
{
    Console.WriteLine(l[i]);
}
Console.WriteLine(l.LastIndexOf(1000));
