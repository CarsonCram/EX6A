using System;

namespace Experimento
{
    class Program
    {

        static int[] ReverseArray(int[] y)
        {
            int length = y.Length - 1;
            int[] backwards = new int[length];

            for (int i = 0; i < y.Length; i++)
            {
                backwards[i] = y[i];
                return backwards;
            }
        }

        public static void ShowArray(int[] z)
        {
            for (int i = 0; i < z.Length; i++)
            {
                Console.WriteLine($"[{i}] : {z[i]}");
            }
        }

        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 2, 4, 8, 10 };
            int[] b = new int[] { 1, 3, 5, 7, 9 };
            int[] c = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine("\n\tFind the reverse of all arrays");
            ShowArray(ReverseArray(a));
            Console.WriteLine();
            ShowArray(ReverseArray(b));
            Console.WriteLine();
            ShowArray(ReverseArray(c));

        }
    }
}
