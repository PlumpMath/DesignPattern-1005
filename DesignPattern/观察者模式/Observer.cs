using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式
{
    //public class ATM
    //{
    //    BankAccount bankAccounty;

    //    void process(int data)
    //    {
    //        bankAccounty.Withdraw(data);
    //    }
    //}

    public class BankAccount
    {
        public string Key { get; set; }
        public string Value { get; set; }

        public event NotifyChilds Notify;

        List<IObserverT> lst = new List<IObserverT>();

        public void Iterator()
        {
            foreach (var item in lst)
            {
                item.Send(Key, Value);
            }
        }

        public void Iterator2()
        {
            if (Notify != null)
            {
                Notify(Key, Value);
            }
        }

        public void Add(IObserverT entity)
        {
            lst.Add(entity);
        }
    }

    public interface IObserverT
    {
        void Send(string key, string value);
    }

    public class Emailer : IObserverT
    {
        void IObserverT.Send(string key, string value)
        {
            Console.WriteLine("邮件:" + key + "," + value);
        }
    }

    public class Mobile : IObserverT
    {
        void IObserverT.Send(string key, string value)
        {
            Console.WriteLine("手机:" + key + "," + value);
        }
    }

    public delegate void NotifyChilds(string key, string value);


}
