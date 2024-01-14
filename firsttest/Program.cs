using System;

namespace f1
{
    class F2
    {
        static void Main(String[] args)
        {
            String temp;
            Console.WriteLine("请输入一个数:");
            temp = Console.ReadLine();
            float a = float.Parse(temp);
            Console.WriteLine("请输入一个数:");
            temp = Console.ReadLine();
            float b = float.Parse(temp);
            float c =F2.相加(a,b);
            F3.selectMax(c,a,b);
            // Console.WriteLine($"c的值是:{c}");
            Console.ReadKey();
        }
          static float 相加(float m,float n){
            return m+n;
        }
    }
    class F3
    {
        public static void selectMax(float a,float b,float c){
            float temp;
            if(a>b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if(b>c)
            {
                temp = b;
                b = c;
                c = temp;
            }
            if(a>b){
                temp = a;
                a = b;
                b = temp;
            }
            Console.WriteLine($"{a}<{b}<{c}");
            float max = c;
            if(max>=17)
            {
                Console.WriteLine("年龄太大了不像是萝莉");
            } 
            else
            {
                Console.WriteLine("最爱萝莉了");
            }
        }
    }
}
