using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLibrary.Generic
{
    /// <summary>
    /// 类泛型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ClassGeneric<T>
    {
        private T t;
        public ClassGeneric(T t)
        {
            this.t = t;
        }
    }
}
