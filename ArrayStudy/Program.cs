using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            //一维数组的定义
            int[] arr1 = new int[3];
            int[] arr2 = new int[3] { 1, 2, 3 };
            int[] arr3 = { 1, 2, 3 };

            //二维数组的定义
            int[,] arr11 = new int[2, 2];
            int[,] arr22 = new int[2, 2] { { 11, 22 }, { 33, 44} };
            int[,] arr33 = { { 1, 2 },{ 3, 3 } };

            //多维数组的定义(暂且不会)
            //int[,,] arr111 = new int[2, 2, 2] {  };

            //一维数组的遍历
            for (int i = 0; i < arr1.Length; i++) {
                System.Console.WriteLine("{0}", arr1[i]);
            }
            System.Console.WriteLine("===========");
            for (int i = 0; i < arr2.Length; i++)
            {
                System.Console.WriteLine("{0}", arr2[i]);
            }
            System.Console.WriteLine("===========");
            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                System.Console.WriteLine("{0}", arr3[i]);
            }
            System.Console.WriteLine("===========");
            foreach (int dex in arr3) {
                System.Console.WriteLine("一维foreach：{0}", dex);
            }

            //二维数组的遍历(数组都可以通过数组名.GetLength("维度")的方式来获取数组不同维度的长度)
            for (int i = 0; i < arr11.GetLength(0); i++)
            {
                for (int j = 0; j < arr11.GetLength(1); j++) {
                    System.Console.WriteLine("{0}", arr11[i, j]);
                }
                
                System.Console.WriteLine();
            }

            for (int i = 0; i < arr22.GetLength(0); i++)
            {
                for (int j = 0; j < arr22.GetLength(1); j++)
                {
                    System.Console.WriteLine("{0}", arr22[i, j]);
                }

                System.Console.WriteLine();
            }
            foreach (int dex in arr22) {
                System.Console.WriteLine("二维foreach:{0}", dex);
            }
            Console.ReadKey();
        }
    }
}
