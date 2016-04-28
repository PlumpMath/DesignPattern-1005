using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Model.AbstractFactory
{
    // 抽象工厂： 对"多系列对象构建"的需求变化, 若仅仅"需要哪些对象(道路、丛林) 经常发生改变不能使用该模式"

    #region 抽象
    /// <summary>
    /// 道路
    /// </summary>
    public abstract class Road
    {

    }
    /// <summary>
    /// 建筑
    /// </summary>
    public abstract class Building
    {

    }
    /// <summary>
    /// 地道
    /// </summary>
    public abstract class Tunnel
    {

    }
    /// <summary>
    /// 丛林
    /// </summary>
    public abstract class Jungle
    {

    }

    public abstract class TotalFactory
    {
        public abstract Road CreateRoad();
        public abstract Building CreateBuilding();
        public abstract Tunnel CreateTunnel();
        public abstract Jungle CreateJungle();
    }

    #endregion

    #region 实现
   
    public class ModernRoad : Road
    {

    }
    public class ModernBuilding : Building
    {

    }
    public class ModernTunnel : Tunnel
    {

    }   
    public class ModernJungle : Jungle
    {

    }

    public class ModernTotalFactory : TotalFactory
    {
        public override Road CreateRoad()
        {
            Console.WriteLine("实现-->CreateRoad");
            return new ModernRoad(); 
        }
        public override Building CreateBuilding()
        {
            Console.WriteLine("实现-->CreateBuilding");
            return new ModernBuilding();
        }
        public override Tunnel CreateTunnel()
        {
            Console.WriteLine("实现-->CreateTunnel");
            return new ModernTunnel();
        }
        public override Jungle CreateJungle()
        {
            Console.WriteLine("实现-->CreateJungle");
            return new ModernJungle();
        }
    }
    #endregion

    class GameManager
    {
        TotalFactory totalFactory;

        public GameManager(TotalFactory entity)
        {
            this.totalFactory = entity;
        }

        public void BuildGameTotal()
        {
            Road road = totalFactory.CreateRoad();
            Building building = totalFactory.CreateBuilding();
            Tunnel tunnel = totalFactory.CreateTunnel();
            Jungle jungle = totalFactory.CreateJungle();
        }
    }

    class App
    {
        public static void Main(string[] args)
        {
            GameManager g = new GameManager(new ModernTotalFactory());
            g.BuildGameTotal();
        }
    }
}
