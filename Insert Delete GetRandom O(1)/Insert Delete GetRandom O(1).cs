using System;
using System.Collections.Generic;

public class RandomizedSet
{
     Dictionary<int, int> dict;
     List<int> list;
     Random random;

    public RandomizedSet()
    {
        dict = new ();
        list = new ();
        random = new();
    }

    public bool Insert(int ins)
    {
        if (dict.ContainsKey(ins))
            return false;

        dict[ins] = list.Count;
        list.Add(ins);
        return true;
    }

    public bool Remove(int rmv)
    {
        if (!dict.ContainsKey(rmv))
            return false;

        int x = dict[rmv];
        int le = list[list.Count - 1];
        list[x] = le;
        dict[le] = x;
        list.RemoveAt(list.Count - 1);
        dict.Remove(rmv);

        return true;
    }

    public int GetRandom()
    {
        int randomnum = random.Next(list.Count);
        return list[randomnum];
    }
}
