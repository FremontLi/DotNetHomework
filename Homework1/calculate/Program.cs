using System;

namespace Homework1
{
    class Calculator
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("请输入数组的长度！");
            int m = int.Parse(Console.ReadLine());//输入数组长度，方便遍历输入数组元素
            double[] nums = new double[m];
            Console.WriteLine("请输入数组元素，每输入一个元素请按回车！");
            for (int i=0;i<m;i++)//遍历输入数组元素
            {
                nums[i] = double.Parse(Console.ReadLine());//这个函数以回车键判断字符串结束
            }
            Calculate(nums, out double max, out double min, out double sum, out double average);//调用Calculate()函数
            Console.WriteLine($"max={max},min={min},sum={sum},average={average}!");
        }
        
        private static void Calculate(double[] nums, out double max, out double min, out double sum, out double average)
        {
            max = nums[0];//初始化max
            min = nums[0];//初始化min
            sum = 0;
            foreach(double n in nums)//只读遍历，不会改变数组的数据
            {
                if (n > max) max = n;//将数组元素与max变量比较，始终保持max是当前搜索到的最大的数据
                if (n < min) min = n;//将数组元素与min变量比较，始终保持min是当前搜索到的最小的数据
                sum += n;//求和
            }
            average = sum / nums.Length;//平均值是数组元素求和除以数组长度
        }
    }
}
