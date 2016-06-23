using DesignPattern.AbstractFactory;
using DesignPattern.观察者模式;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 抽象工厂 测试
            // GameManager g = new GameManager(new ModernTotalFactory());
            // g.BuildGameTotal();

            // 工厂模式 测试
            // CarTets t = new CarTets(new FengTianCar());
            // t.BuildTestContext();

            // 观察者模式 测试
            // BankAccount ba = new BankAccount() { Key = "冯伟才", Value = "拉屎" };
            // ba.Add(new Emailer());
            // ba.Add(new Mobile());
            // ba.Iterator();
            // ba.Notify += (t, t2) =>
            // {
            //     Console.WriteLine("通知1");
            // };
            // ba.Notify += (t, t2) =>
            // {
            //     Console.WriteLine("通知2");
            // };
            // ba.Notify += (t, t2) =>
            // {
            //     Console.WriteLine("通知3");
            // };
            // ba.Iterator2();

            Console.ReadLine();
        }


    }
}
