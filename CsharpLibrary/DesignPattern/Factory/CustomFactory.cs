using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLibrary.DesignPattern.Factory
{
    /// <summary>
    /// 一般工厂方法用于分散处理矛盾
    /// 适用于初始化比较复杂的产品类
    /// </summary>
    public class CustomFactory : ICustomFactory
    {
        public ICustomProduct GetProduct()
        {
            ICustomProduct product = new CustomProduct();
            return product;
        }
    }
}
