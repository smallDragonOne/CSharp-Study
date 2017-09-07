using System;
using System.Reflection;


namespace cSharp.Basic
{
    /*
     * 反射的加载入口
     * 反射创建实例
     * 反射方法调用
     * 反射破坏单例
     * 反射设置实体值
     * 
     */
    public class ReflectionTest
    {

        public ReflectionTest()
        {
            Console.WriteLine("it is in relection");
        }
        
        public void DoTest()
        {
            Assembly assembly = Assembly.Load("CsharpLibrary");

            foreach (var i in assembly.GetModules())
            {
                Console.WriteLine($"module is {i.FullyQualifiedName}");
            }

            foreach (var item in assembly.GetTypes())
            {
                Console.WriteLine($"Types includes {item.FullName}");
            }

            Type type = assembly.GetType("CsharpLibrary.Reflection.ReflectClass");
            object ob = Activator.CreateInstance(type);             /// 实例化对应的类型


            //反射调用类方法
            var medthod = type.GetMethod("getSomeThing");
            medthod.Invoke(ob, new Type[] { typeof(int)});    ///调取还有重载方法的方式

            medthod.Invoke(ob, null);  //调取不重载的方法
            medthod.Invoke(ob, new object[] { 11 });  //调用带参数的方法  


            var medthod1 = type.GetMethod("getSometing", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);  ///找到私有方法
            medthod1.Invoke(ob, null);

            foreach (var p in type.GetProperties())
            {
                if (p.Name.Equals("str"))  ///给str属性 设置
                {
                    p.SetValue(ob, "123");   
                }
            }
        }



    }
}
