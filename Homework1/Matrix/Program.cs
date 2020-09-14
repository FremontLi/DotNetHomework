using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入二维数组的行数：");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入二维数组的列数：");
            int n = int.Parse(Console.ReadLine());
            int[,] cost = new int[m, n];//这里一开始写成了int[][]，要注意c#的语法
            Console.WriteLine("请输入二维数组的值：");
            for(int i=0;i<m;i++)
            {
                string str = Console.ReadLine();
                string[] tmp = str.Split(" ".ToCharArray());//通过Split方法以空格作为分隔符将输入的一行字符串分隔开
                for (int j=0;j<n;j++)
                {
                    cost[i, j] = int.Parse(tmp[j]);//将分割后的字符付给二维数组每个元素
                }
            }
            var result = IsTMatrix(cost);//调用IsTMatrix()函数
            Console.WriteLine(result);//输出结果
        }

        private static bool IsTMatrix(int[,] matrix)
        {
            for(int i=0;i<matrix.GetLength(0)-1;i++)
                for(int j=0;j<matrix.GetLength(1)-1;j++)
                    if (matrix[i + 1, j + 1] != matrix[i, j])//如果每个数组元素和右下相邻元素不同
                    {
                        return false;//改变标志为false，即不是托普利茨矩阵
                    }
            return true;
        }
    }
}
