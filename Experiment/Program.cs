using System;

namespace Experiment
{
    class Program
    {
        public static int[] RotateArray(string direction, int numPlaces,
            int[] y)
        {
            if (direction == "right")
            {
                for (int i = 0; i < y.Length; i++)
                {
                    int element = y[i];
                    y[i] = y[y.Length - numPlaces - 1];
                    y[y.Length - i - 1] = element;
                }
            }
            //if (direction == "left")
            //{

            //}
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 0, 2, 4, 8, 10 };
            int[] b = new int[] { 1, 3, 5, 7, 9 };
            int[] c = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            //RotateArray("left", 2, a);
            RotateArray("right", 2, b);
            //RotateArray("left", 4, c);
        }
    }
}
