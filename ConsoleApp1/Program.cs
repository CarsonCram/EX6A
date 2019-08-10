using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int[] reverseArray(int[] inputArray)
        {
            //Array.Reverse(); can also be used
            int[] answer = inputArray;
            for (int i = 0; i < inputArray.Length / 2; i++)
            {
                int temp = answer[i];
                answer[i] = answer[inputArray.Length - i - 1];
                answer[inputArray.Length - i - 1] = temp;

            }
            return answer;
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

            ShowArray(reverseArray(a));
            Console.WriteLine();
            ShowArray(reverseArray(b));
            Console.WriteLine();
            ShowArray(reverseArray(c));
        }
    }
}
