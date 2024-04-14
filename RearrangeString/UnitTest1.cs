using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        string str = "bbbaa";
        Console.WriteLine(RearrangeString(str));
    }

    public static string RearrangeString(string str)
    {
        int[] count = new int[26];
        foreach (char c in str)
        {
            count[c - 'a']++;
        }

        PriorityQueue<(char, int)> pq = new PriorityQueue<(char, int)>(Comparer<(char, int)>.Create((x, y) => y.Item2.CompareTo(x.Item2)));

        for (char c = 'a'; c <= 'z'; c++)
        {
            if (count[c - 'a'] > 0)
            {
                pq.Enqueue((c, count[c - 'a']));
            }
        }

        (char, int) prev = ('#', -1);
        string result = "";

        while (pq.Count > 0)
        {
            (char, int) curr = pq.Dequeue();
            result += curr.Item1;

            if (prev.Item2 > 0)
            {
                pq.Enqueue(prev);
            }

            curr.Item2--;
            prev = curr;
        }

        if (result.Length != str.Length)
        {
            return "Not possible";
        }

        return result;
    }
}

public class PriorityQueue<T> : SortedSet<T>
{
    private int count = 0;

    public PriorityQueue(IComparer<T> comparer) : base(comparer)
    {
    }

    public new void Enqueue(T item)
    {
        base.Add(item);
        count++;
    }

    public new T Dequeue()
    {
        if (count > 0)
        {
            T item = Min;
            base.Remove(item);
            count--;
            return item;
        }

        throw new InvalidOperationException("The queue is empty");
    }

    public new int Count
    {
        get { return count; }
    }
}