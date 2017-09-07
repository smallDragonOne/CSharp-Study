using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLibrary.DesignPattern.Factory
{
    public interface ISimpleFactory
    {
        ISimpleProduct CreateProduct(string param);
    }
}
