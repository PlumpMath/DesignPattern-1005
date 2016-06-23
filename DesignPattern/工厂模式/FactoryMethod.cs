using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    public abstract class AbstrctCar
    {
        public abstract void Runing();
    }

    public class HongQiCar : AbstrctCar
    {
        public override void Runing()
        {
            Console.WriteLine("红旗: Runing");
        }
    }

    public class FengTianCar : AbstrctCar
    {
        public override void Runing()
        {
            Console.WriteLine("丰田: Runing");
        }
    }

    public class CarTets
    {
        AbstrctCar car;

        public CarTets(AbstrctCar car)
        {
            this.car = car;
        }

        public void BuildTestContext()
        {
            car.Runing();
        }
    }
}
 