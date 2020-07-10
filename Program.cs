using System;
using System.Linq;

namespace HackerRankCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Program myProgram = new Program();
            //// myProgram.RotateArrayLeftNthPlace(new int[] { 1, 2, 3, 4, 5 }, 4);
            //myProgram.matchingStrings(new string[] {"aba","baba","aba","xzxb" }, new string[] { "aba","xzxb","ab" });
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[] {1,2,100 };
            jaggedArray[1] = new int[] { 2, 5, 100 };
            jaggedArray[2] = new int[] { 3, 4, 100 };

            long output = arrayManipulation(5, jaggedArray);


        }


        public static long arrayManipulation(int n, int[][] queries)
        {

            long[] jaggedArray = new long[n + 1];
            long maxValue = 0;

            for (int i = 0; i < queries.Length; i++)
            {
                int minIndex = queries[i][0];
                int maxIndex = queries[i][1];
                long value =  queries[i][2];

                jaggedArray[minIndex] += value;
                if (maxIndex + 1 <= n) jaggedArray[maxIndex + 1] -= value;



            }

            long tempMax = 0;
            long max = 0;
            for (int i = 1; i <= n; i++)
            {
                tempMax += jaggedArray[i];
                if (tempMax > max) max = tempMax;
            }

            return max;


            //int[][] jaggedArray = new int[queries.Length][];
            //int maxValue = 0;

            //for (int i = 0; i < jaggedArray.Length; i++)
            //{

            //    jaggedArray[i] = new int[n];

            //}


            //    for (int i = 0; i < queries.Length; i++)
            //{
            //        int minIndex = queries[i][0];
            //        int maxIndex = queries[i][1];
            //        int value = queries[i][2];

            //    for (int k = i; k < jaggedArray.Length; k++)
            //    {
            //        for (int j = minIndex - 1; j <= maxIndex - 1; j++)
            //        {
            //            jaggedArray[k][j] += value;
            //            if (maxValue < jaggedArray[k][j])
            //                maxValue = jaggedArray[k][j];
            //        }

            //    }



            //}

            return maxValue;




        }




        public int[] matchingStrings(string[] strings, string[] queries)
        {
            int[] itemsOccuranceCount = new int[queries.Length];

            for (int i = 0; i < queries.Length; i++)
            {
                itemsOccuranceCount[i] = strings.Where(x => x == queries[i]).Count();
            }

            return itemsOccuranceCount;

        }




        public void RotateArrayLeftNthPlace(int[] array, int d)
        {
            //  int n = 5;
            //  int d = 4;

            //  int[] array = new int[n];

            int[] a = new int[] { 1, 2, 3, 4, 5 };
            int n = a.Length;


            int[] firstArray = new int[d];
            int[] secondArray = new int[n-d];

            for (int i = 0; i < a.Length; i++)
            {
                if (i < d)
                    firstArray[i] = a[i];
                else
                    secondArray[i-d] = a[i];

            }

            for (int i = 0; i < a.Length; i++)
            {
                if (i < n- d)
                    a[i] = secondArray[i] ;
                else
                    a[i] = firstArray[i-(n-d)];

            }

            Console.WriteLine(string.Join(" ", a));

            //int ArrayLength = a.Length;
            //d = d % ArrayLength;


            //for (int i = 0; i < a.Length; i++)
            //{
            //    int temp = i + 1 + d;
            //    temp = temp > ArrayLength ? temp % ArrayLength : temp;
            //    a[i] = temp;
            //}

            //Console.WriteLine(string.Join(" ", a));


        }


    }
}
