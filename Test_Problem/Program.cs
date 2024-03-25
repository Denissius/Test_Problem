using System;

namespace Test_Problem
{
    class Program
    {
        static void Merge1(int[] A, int p, int q, int r)
        {
            int wholeLength = (r - p) + 1;

            int index = 0;
            int leftindex = p;
            int rightindex = q + 1;

            int[] M = new int[wholeLength];

            while (index < wholeLength)
            {
                if ((leftindex <= q) && (rightindex <= r))
                {
                    if ((A[leftindex]) <= (A[rightindex]))
                    {
                        M[index] = A[leftindex];
                        leftindex++;
                    }
                    else
                    {
                        M[index] = A[rightindex];
                        rightindex++;
                    }
                    index++;
                }
                else
                {
                    if (rightindex <= r)
                    {
                        M[index] = A[rightindex];
                        rightindex++;
                    }
                    else
                    {
                        M[index] = A[leftindex];
                        leftindex++;
                    }
                    index++;
                }
            }
            for (int i = 0; i < M.Length; i++)
            {
                A[p + i] = M[i];
            }
        }
        static int[] Sort1(int[] A, int p, int r)
        {
            int q = (p + r) / 2;
            if (p < r)
            {
                Sort1(A, p, q);
                Sort1(A, q + 1, r);
                Merge1(A, p, q, r);
            }
            else if (p == r)
            {
                return A;
            }
            return A;
        }
        static void Main(string[] args)
        {
            int[] F = { 2, 9, 3, 4, 0 };

            int[] S = Sort1(F, 0, F.Length - 1);

            foreach (var item in S)
            {
                Console.Write(item);
                Console.Write(" ");
            }
        }
    }
}
