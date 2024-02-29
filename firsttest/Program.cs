using System;

namespace f1
{
    class F2
    {
        static void Main(String[] args)
        {
            // 租金计算
            #region
            //String temp;
            //Console.WriteLine("请输入短期租金:");
            //temp = Console.ReadLine();
            //float a = float.Parse(temp);
            //Console.WriteLine("请输入长期租金:");
            //temp = Console.ReadLine();
            //float b = float.Parse(temp);
            //Console.WriteLine("请输入可接受的的差值(长租期租金-短租期租金):");
            //temp = Console.ReadLine();
            //float washPay = float.Parse(temp);
            //Console.WriteLine("请输入你的预算:");
            //temp = Console.ReadLine();
            //float washMoney = float.Parse(temp);

            //F3.bestPay(a, b, washPay, washMoney);
            #endregion

            // 比大小
            #region
            //float c = 18.0f;
            //F3.selectMax(c, a, b);
            //Console.WriteLine($"c的值是:{c}");
            //Console.ReadKey();
            #endregion


            // 数组
            #region
            //Console.WriteLine("这是做一维数组的");
            //// 方法1
            //int[] array = new int[] { 1, 2 }; // 数组是引用类型，需要使用new关键字初始化，初始化后数组中的每项都具有默认值。
            //Console.WriteLine("成功创建数组a,他的地址在:" + array);
            //// 方法2
            //int[] array2;
            //array2 = new int[] { 2, 3, 4 };
            //Console.WriteLine("成功创建数组b,他的地址在:" + array2);
            //// 方法3
            //int[] array3;
            //array3 = new int[4];
            //array3[0] = 1; // 赋值时，数组的第1个值是使用下标值为0的位置。
            //array3[1] = 2;
            //array3[2] = 3;
            //array3[3] = 4; // 数组初始化为长度为10的int类型的数组，长度4表示该数组只能存储4个整数。下标的最大值为3，也就是长度-1(array.length-1).

            //// 多维数组
            //Console.WriteLine("这是做多维数组的");
            //// 方法1
            //int[][] arr = new int[4][];
            //Console.WriteLine("成功创建数组arr,他的地址在:" + arr);
            //// 方法2
            //int[][] arr2;
            //arr2 = new int[4][];
            //// 遍历数组
            //foreach (int i in array)
            //    Console.WriteLine(i);
            ///*
            // * 1.定义的循环变量i的数据类型必须要与数组的类型一致
            // * 2.in 是固定的
            // * 3.in 后面接数组名
            // */
            #endregion

            //  
            #region

            #endregion
        }
    }
    class F3 // 这里存放方法集
    {
        // 将三个数字从小到大排序 
        public static void selectMax(float a,float b,float c)
        {
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
        // 最优租赁计算
        public static void bestPay(float shortPay,float longPay,float washPay,float washMoney)
        {
            double Pay_d = 0;
            double Pay_dl = 0;
            for(int day = 8;day<15;day++)
            {
                Pay_d = day * shortPay;
                for(int deadline = 15;deadline<=100;deadline++)
                {
                    Pay_dlong = deadline * longPay;
                    if ((Pay_dlong - Pay_dshort) <= washPay)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("最合适短租天数" + day + "最合适长租天数" + deadline);
                        Console.WriteLine($"此时已经得到的Pay_d:{switchInt(Pay_dshort)}和Pay_dl:{switchInt(Pay_dlong)}");
                    }
                    else
                    {
                        Console.WriteLine("没有相同价格或者与你的心理差价相近的租法,可以随意购买或者尝试推荐购买");
                    }
                    if (Pay_d != Pay_dl)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("推荐购买:");
                        Console.WriteLine("输入1推荐长租,输入2推荐短租,输入3退出推荐");
                        String select = Console.ReadLine();
                        float washday;
                        switch (select)
                        {
                            // 当用户用最大价格租长期时
                            case "1":
                                washday = washMoney / longPay;
                                if (washday > 22 && washday <= 100)
                                {
                                    Pay_dl = washday * longPay;
                                    Console.WriteLine("你可以购买的最长长租天数是" + washday + ",共需花费" + Pay_dl);
                                }
                                else
                                {
                                    if (washday < 15)
                                        Console.WriteLine("应该不可能读到这个位置");
                                }
                                break;
                            // 当用户想用最大价格租短租时
                            case "2":
                                washday = washMoney / shortPay;
                                if (washday > 0 && washday < 22)
                                {
                                    Pay_dshort = (washday * shortPay) / 1.0;
                                    Console.WriteLine("你可以购买的最长短租天数是" + switchInt(washday) + ",共需花费" + Pay_dshort);
                                }
                                else
                                {
                                    Console.WriteLine("你的预算充足，建议你长租");
                                    Console.WriteLine("\n或者减少预算购买最长短租租期:14天,\n你的短租花费为"+(14*shortPay));
                                    continue;
                                }
                                break;
                            case "3":
                                return;
                            default:
                                break;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("价格相同的情况下建议长租");
                        return;
                    }
                   
                }
            }
        }

        // 将数据转化为int类型
        public static int switchInt(object num)
        {
            int switchNum = Convert.ToInt32(num);
            return switchNum;
        }

    }
}
