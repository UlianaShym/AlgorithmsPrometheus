using System;

namespace AlgorithmsPrometheus.Coursera.UnionFind
{
    public class QuickFindAlgorithm
    {
        private int[] id;

        public QuickFindAlgorithm(int N)
        {
            id = new int[N];
            for (int i = 0; i < N; i++)
            {
                id[i] = i;
            }
        }

        public bool Find(int p, int q)
        {
            bool isConnected = id[p] == id[q];
            Console.WriteLine(p + " and " + q + " are connected : " + isConnected);
            return isConnected;
        }

        public void Union(int p, int q)
        {
            int pid = id[p];
            int qid = id[q];
            for (int i = 0; i < id.Length; i++)
            {
                if (id[i] == pid)
                {
                    id[i] = qid;
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
