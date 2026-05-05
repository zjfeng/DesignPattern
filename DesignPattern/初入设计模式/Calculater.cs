using DesignPattern.工厂方法模式;
using System;

namespace DesignPattern.初入设计模式
{
    public static class Calculater
    {
        public static void Calculate()
        {
            bool go = true;

            while (go)
            {
                Console.WriteLine("请输入第一个数字：");
                decimal left = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("请输入运算符（+、-、*、/）：");
                string op = Console.ReadLine();
                Console.WriteLine("请输入第二个数字：");
                decimal right = Convert.ToDecimal(Console.ReadLine());

                /// 第一种写法，增加新的运算符需要修改代码，特别是此处修改了视图代码，违反了开闭原则
                //Methon methon = op switch
                //{
                //    "+" => new Add(left, right),
                //    "-" => new Subtract(left, right),
                //    "*" => new Multiply(left, right),
                //    "/" => new Divide(left, right),
                //    _ => throw new InvalidOperationException("无效的运算符")
                //};


                decimal result = 0;
                try
                {
                    /// 第二种写法，增加新的运算符只需要增加新的类，修改少量代码
                    //Methon methon = MethonFactory.Create(op);

                    /// 第三种写法，工厂方法模式实现，增加新的运算符只需要增加新的类和工厂方法，不需要修改现有代码，符合开闭原则
                    ICreateMethonFactory createMethonFactory = new CreateAddFactory();
                    Methon methon = createMethonFactory.CreateMethon();

                    result = methon.Execute(left, right);
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine($"结果等于{result}");

                Console.WriteLine("是否继续？");
                string yon = Console.ReadLine();

                if (yon != "y" && yon != "Y")
                {
                    go = false;
                }
            }
        }
    }
}
