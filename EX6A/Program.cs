using System;

namespace EX6A
{
    class ArrayStuff
    {
        //Write a method that counts the number of elements in an integer array, and then sums the elemetns in an
        //integer array. It should return the average of the array elements as a double. Using the count and cum,
        //compute and print the mean of each array.

        static double MeanArray(int[] x)
        {
            int sum = 0;

            for (int i = 0; i < x.Length; i++)
            {
                sum += x[i];
            }
            return (double)sum / x.Length;
        }

        //Write a method that accepts an array as an argument and prints the reversed array. For example,
        //if you passs the method Array B, it should print [9, 7, 5, 3, 1]. Print the reverse of all 
        //three arrays.

        static int[] ReverseArray(int[] y)
        {
            for (int i = 0; i < y.Length / 2; i++)
            {
                int tmp = y[i];
                y[i] = y[y.Length - i - 1];
                y[y.Length - i - 1] = tmp;
            }
            return y;
        }

        public static void ShowArray(int[] z)
        {
            for (int i = 0; i < z.Length; i++)
            {
                Console.WriteLine($"[{i}] : {z[i]}");
            }
        }

        //Arrays can be rotated to the right or to the left by any number
        //of places.Rotating an array to the right by two places puts the
        //first element in position three, the second element in position
        //four, and so on, with the last element in postion two and the
        //net to last element in position one. Array A rotated to the right
        //by tow plaved results in [8, 10, 0, 2, 4, 6]. Likewise, rotating
        //an array to the left places the first elemenets at the end.
        //Array B rotated to the left by two plaves results in [5, 7, 9, 1, 3].

        //Write a method that accepts three parameters, a direction, a number
        //of places, and an array, which prints the apporpriate rotation, Call
        // the method on all three arrays.Rotate array A two places to the
        //left. Rotate array B two places to the right. Rotate array C four
        //fours places to the left.

        public static void RotateArray(string direction, int numPlaces,
            int[] y)
        {
            int[] rotated = new int[y.Length];
            int index;

            while (numPlaces > y.Length)
            {
                numPlaces -= y.Length;
            }
            if (direction == "right")
            {
                index = 0 + numPlaces;
                for (int i = 0; i < GetLength(y); i++)
                {
                    if (index == GetLength(y))
                    {
                        index = 0;
                    }
                    rotated[index] = y[i];
                    index++;
                }
            }
            if (direction == "left")
            {
                index = 0;
                for (int i = 0; i < GetLength(y); i++)
                {
                    if(index == GetLength(y))
                    {
                        i = 0;
                    }
                    rotated[index] = y[i];
                    index++;
                }
            }
            ShowArray(rotated);
        }

        public static int GetLength(int[] y)
        {
            int count = 0;
            foreach (int x in y) count++;
            return count;
        }

        public static int GetSum(int[] y)
        {
            int sum = 0;
            for (int i = 0; i < GetLength(y); i++) sum += y[i];
            return sum;
        }


        public static void Sort(int[] y)
        {
            int temp = 0;

            for (int i = 0; i < GetLength(y) - 1; i++)     
            {
                for (int j = i + 1; j < GetLength(y); j++) 
                {
                    if (y[i] > y[j])
                    {
                        temp = y[i];   
                        y[i] = y[j]; 
                        y[j] = temp;
                    }
                }
            }
            ShowArray(y);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tEX6A.ArrayStuff.Main()");
            int[] a = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] b = new int[] { 1, 3, 5, 7, 9 };
            int[] c = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            Console.WriteLine("\n\tFind the mean of every array");
            Console.WriteLine($"\t{MeanArray(a)}");
            Console.WriteLine($"\t{MeanArray(b)}");
            Console.WriteLine($"\t{MeanArray(c)}");

            Console.WriteLine("\n\tFind the reverse of all arrays");
            ShowArray(ReverseArray(a));
            Console.WriteLine();
            ShowArray(ReverseArray(b));
            Console.WriteLine();
            ShowArray(ReverseArray(c));

            Console.WriteLine("\n\tRotate the Arrays");
            RotateArray("right", 2, a);
            Console.WriteLine();
            RotateArray("left", 2, b);
            Console.WriteLine();
            RotateArray("left", 4, c);

            Console.WriteLine("\n\tSort the array.");
            Sort(c);
        }
    }
}
