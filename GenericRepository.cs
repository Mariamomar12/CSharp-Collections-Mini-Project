using System;

public class GenericRepository<T>
{
    internal List<T> list;

    public GenericRepository()
    {
        list = new List<T>();
    }

    public void add(T s)
    {
        list.Add(s);
    }

    public void remove(T s)
    {
        list.Remove(s);
    }
}
