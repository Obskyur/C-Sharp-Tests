using Lucene.Net.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_RearrangeString
{

    public class RearrangeString
    {
        const int MAX_CHAR = 26;
        private struct Key
        {
            public int freq;
            public char ch;

            // Function to compare two Key values 
            public int CompareTo(Key other)
            {
                return freq - other.freq;
            }
        };
        internal static void Run(String str)
        {

            int N = str.Length;

            // Store frequencies of all characters in string 
            int[] count = new int[MAX_CHAR];
            for (int i = 0; i < N; i++)
                count[str[i] - 'a']++;

            // Insert all characters with their frequencies 
            // into a priority_queue 
            PriorityQueue<Key> pq = new PriorityQueue<Key>();
            for (int c = 'a'; c <= 'z'; c++)
            {
                int val = c - 'a';
                if (count[val] > 0)
                    pq.Enqueue(new Key(count[val], (char)c));
            }

            // 'str' that will store resultant value 
            str = "";

            // work as the previous visited element 
            // initial previous element be. ( '#' and 
            // it's frequency '-1' ) 
            Key prev = new Key(-1, '#');

            // traverse queue 
            while (pq.Count != 0)
            {
                // pop top element from queue and add it 
                // to string. 
                Key k = pq.Dequeue();
                str += k.ch;

                // IF frequency of previous character is less 
                // than zero that means it is useless, we 
                // need not to push it 
                if (prev.freq > 0)
                    pq.Enqueue(prev);

                // Make current character as the previous 'char' 
                // decrease frequency by 'one' 
                (k.freq)--;
                prev = k;
            }

            // If length of the resultant string and original 
            // string is not same then string is not valid 
            if (N != str.Length)
                Console.WriteLine(" Not possible ");

            else // valid string 
                Console.WriteLine(str);
        }
    
}
