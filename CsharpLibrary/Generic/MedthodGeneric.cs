using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLibrary.Generic
{
    /// <summary>
    /// 方法泛型
    /// </summary>
    public class MedthodGeneric
    {

        public MedthodGeneric()
        {

        }


        /// <summary>
        /// 方法泛型
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="param"></param>
        /// <returns></returns>
        public T getSomeInfo<T>(T param)
        {
            return default(T);
        }


        /// <summary>
        /// 方法泛型约束
        /// </summary>
        /// <typeparam name="T">约束t为一个类，且可以实例化</typeparam>
        /// <param name="param"></param>
        /// <returns></returns>
        public T getSomeClassInfo<T>(T param) where T : class, new()   
        {
            var t = new T();
            return t;
        }

        public void getSpecificClass<T>(T param) where T: innerClass
        {
            var t = new innerClass();
            t.a = 11;
        }

        public class innerClass
        {
            public int a = 10;
            public string b = "11";
            public innerClass()
            {

            }
        }

        public class ChildinnerClass:innerClass
        {
            public ChildinnerClass():base()
            {

            }
        }
    }
}
