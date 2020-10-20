using System;
using System.Collections.Generic;
using System.Linq;

namespace _2D_Array___DS
{
    class Program
    {
        //static int hourglassSum(int[][] arr)
        //{
        //    1 1 1 0 0 0
        //    0 1 0 0 0 0
        //    1 1 1 0 0 0
        //    0 0 2 4 4 0
        //    0 0 0 2 0 0
        //    0 0 1 2 4 0

           

        //    return maximun;
        //}
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            int tot = 0;
            int x = 6;
            int y = 6,singleval=0;
            int size = 4 * y, maximun = 0;
            List<int> val = new List<int>();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    singleval = arr[i][j] + arr[i][j + 1] + arr[i][j + 2] + arr[i + 1][j + 1] + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    Console.WriteLine(arr[i][j] +""+ arr[i][j + 1] + "" + arr[i][j + 2] + "" + arr[i + 1][j + 1] + "" + arr[i + 2][j] + "" + arr[i + 2][j + 1] + "" + arr[i + 2][j + 2]);
                    val.Add(singleval);
                }
            }
            maximun = val.Max();
            Console.WriteLine("vales is ");
            for(int n=0;n<val.Count;n++)
            {
                Console.WriteLine(n+":"+val[n]);
            }

            Console.WriteLine("higest value is:"+maximun);


        }

       
    }
}
