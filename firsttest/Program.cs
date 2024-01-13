using System;

namespace f1
{
    class F2
    {
        static void Main(String[] args)
        {
            F3.outputWord();

            String temp;
            Console.WriteLine("请输入一个数:");
            temp = Console.ReadLine();
            float a = float.Parse(temp);
            Console.WriteLine("请输入一个数:");
            temp = Console.ReadLine();
            float b = float.Parse(temp);
            float c =F2.相加(a,b);
            F3.selectMax(a,b,c);
            Console.WriteLine($"c的值是:{c}");
        }
          static float 相加(float m,float n){
            return m+n;
        }
    }
    class F3
    {
        public static void outputWord(){
            Console.WriteLine("我爱中国");
        }

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
            Console.WriteLine($"{a},{b},{c}");
        }
    }
}
