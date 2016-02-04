using System;

namespace AlgorithmsPrometheus.Coursera.UnionFind
{
    class QuickUnionAlgorithm
    {
        private int[] id;
        private int[] size;

        public QuickUnionAlgorithm(int N)
        {
            id = new int[N];
            size = new int[N];
            for (int i = 0; i < N; i++)
            {
                id[i] = i;
                size[i] = 1;
            }
        }

        private int Root(int p)
        {
            while (p != id[p])
            {
                p = id[p];
            }
            return p;
        }

        public bool Find(int p, int q)
        {
            bool isConnected = Root(p) == Root(q);
            Console.WriteLine(p + " and " + q + " are connected : " + isConnected);
            return isConnected;
        }

        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            if (i == j)
            {
                Console.WriteLine("Is already connected.");
            }
            else
            {
                if (size[i] < size[j])
                {
                    size[j] += size[i];
                    id[i] = j;
                }
                else
                {
                    size[i] += size[j];
                    id[j] = i;
                }
            }
        }

        public void PrintArray()
        {
            for (int i = 0; i < id.Length; i++)
            {
                Console.Write(id[i] + " ");
            }
        }
    }
}
