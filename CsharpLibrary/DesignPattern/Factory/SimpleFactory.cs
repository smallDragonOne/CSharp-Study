using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLibrary.DesignPattern.Factory
{

    /// <summary>
    /// 抽象工厂方法，用于集中处理矛盾
    /// 将各种情况穷举
    /// </summary>
    public class SimpleFactory : ISimpleFactory
    {

        public ISimpleProduct CreateProduct(string param)
        {
           if (param == "1")
            {
                ISimpleProduct product1 = new SimpleProduct1();
                return product1;
            }
            else if (param == "2")
            {
                ISimpleProduct product2 = new SimpleProduct2();
                return product2;
            }
            return null;
        }
    }
}
