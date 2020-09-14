using System;

namespace screenprime
{
    class Screenprime
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("请输入一个正整数用以求解2到它的素数：");
            //int n = int.Parse(Console.ReadLine());
            isPrime(100/*n=100*/);//调用isPrime()函数,本题直接令n=100
        }

        private static void isPrime(int num)
        {
            bool[] mark = new bool[num + 1];//角标从0开始，为了对应，数据从0开始，数组长度为num+1
            mark[0] = false;//0不是素数
            mark[1] = false;//1不是素数
            for(int i=2;i<=num;i++)
            {
                mark[i] = true;//初始化，假定2到num都是素数，均标识为true
            }
            for(int i=2;i*i<=num;i++)//要得到自然数num以内的全部素数，必须把不大于根号num的所有素数的倍数剔除，剩下的就是素数
            {
                if(mark[i]==true)
                {
                    for (int j = 2; j * i <= num; j++) //更换标记，剔除非素数
                        mark[j * i] = false;//i的倍数全部置为false(不包括i本身)
                }
            }
            int count = 0;
            Console.WriteLine("2到" + num + "的素数是：");
            for(int i=2;i<=num;i++)//遍历布尔数组，计算true标记的个数，几位素数的个数
            {
                if(mark[i]==true)
                {
                    count++;
                    Console.Write(i + "\t");
                    if (count % 10 == 0) Console.WriteLine();//一行输出10个后换行
                }
            }
            Console.WriteLine();
            Console.WriteLine("2到" + num + "中的素数一共有" + count + "个。");
        }
    }
}
