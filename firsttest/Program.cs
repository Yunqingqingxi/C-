using System;

namespace f1
{
    class F2
    {
        static void Main(String[] args)
        {
            String temp;
            Console.WriteLine("请输入短期租金:");
            temp = Console.ReadLine();
            float a = float.Parse(temp);
            Console.WriteLine("请输入长期租金:");
            temp = Console.ReadLine();
            float b = float.Parse(temp);
            Console.WriteLine("请输入可接受的的差值(长租金-短租金):");
            temp = Console.ReadLine();
            float washPay = float.Parse(temp);
            Console.WriteLine("请输入你的预算:");
            temp = Console.ReadLine();
            float washMoney = float.Parse(temp);
            // float c =F2.Sum(a,b);
            F3.bestPay(a,b,washPay,washMoney);
            // F3.selectMax(c,a,b);
            // Console.WriteLine($"c的值是:{c}");
            // Console.ReadKey();
        }
          static float Sum(float m,float n){
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
        public static void bestPay(float shortPay,float longPay,float washPay,float washMoney)
        {
            double Pay_d;
            double Pay_dl;
            for(int day = 8;day<15;day++)
            {
                Pay_d = day * shortPay;
                for(int deadline = 15;deadline<=100;deadline++)
                {
                    Pay_dl = deadline * longPay;
                     if(Pay_d == Pay_dl && (Pay_dl-Pay_d)<washPay)
                     {
                        Console.WriteLine("最合适短租天数"+day+"最合适长租天数"+deadline);
                        Console.WriteLine($"此时已经得到的Pay_d:{Pay_d}和Pay_dl:{Pay_dl}");
                     }
                     else
                     {
                        Console.WriteLine("没有相同价格或者与你的心理差价相近的租法,可以随意购买");
                        Console.WriteLine("\n");
                        Console.WriteLine("推荐购买:");
                        Console.WriteLine("输入1推荐长租,输入2推荐短租");
                        String select = Console.ReadLine();
                        float washday;
                        switch(select)
                        {
                            // 当用户用最大价格租长期时
                            case "1":
                            washday = washMoney/longPay;
                            if(washday > 15 && washday <= 100)
                            {
                                Console.WriteLine("你可以购买的最长长租天数是"+washday);
                            }else{
                                if(washday < 15)
                                Console.WriteLine("应该不可能读到这个");
                            }
                            break;
                            // 当用户想用最大价格租短租时
                            case "2":
                            washday = washMoney/shortPay;
                            if(washday > 0 && washday <15)
                            {
                                Console.WriteLine("你可以购买的最长短租天数是"+washday);
                            }
                            else
                            {
                                Console.WriteLine("你的预算充足，建议你长租");
                                return;
                            }
                            break;
                            default:
                            break;
                        }
                    }
                }
            }
        }
    }
}
