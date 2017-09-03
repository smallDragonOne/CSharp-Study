using System;
using System.Reflection;


namespace cSharp.Basic
{
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


            
        }



    }
}
