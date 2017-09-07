using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLibrary.DesignPattern.Factory
{
    public class CustomFactory2cs : ICustomFactory
    {
        public ICustomProduct GetProduct()
        {
            ICustomProduct product = new CustomProduct2();
            return product;
        }
    }
}
