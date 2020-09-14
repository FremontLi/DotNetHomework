using System;

namespace Homework1
{
    class Primefactors
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数:");
            int num = int.Parse(Console.ReadLine());
            prime_factors(num);//调用查找素数因数函数
        }
        private static void prime_factors(int n)
        {
            int i,m=0;//m记录素数因数的个数
            int p = n;//由于本程序的n不断在变动，先把n记录在p中
            double[] nums = new double[1000];
            while (n%2==0)//n是偶数时，处理之后n变为奇数
            {
                n = n / 2;
                nums[m] = 2;
                m++;
            }
            //已经处理完了偶数的情况，下面只处理奇数情况
            for (i = 3; i * i <= p; i += 2)//对于每个组合数而言，最少有一个素数因子是小于或者等于它的平方根的
            {
                while (n % i == 0)
                {
                    n = n / i;
                    nums[m] = i;
                    m++;
                }
            }
            if (n > 2)//如果处理之后的n是奇数，则进入这一步
            {
                nums[m] = n;
                m++;
            }

            Console.WriteLine("该数据的所有素数因子有：");
            for(int k=0;k<m;k++)//遍历输出素数因子
            {
                Console.Write(nums[k]+" ");
            }
        }
    }
}
