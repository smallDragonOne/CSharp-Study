using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLibrary.DesignPattern.Factory
{
    public interface IAbstractFactory
    {
        IAbstractProduct GetProduct();

        IAbstractProduct2 GetProduct2();
    }
}
