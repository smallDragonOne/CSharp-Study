
using cSharp.Basic;
using System;
using System.Reflection;
using CsharpLibrary.Reflection;

namespace cSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            new ReflectionTest().DoTest();

            Console.ReadKey();

            var reflection = new ReflectClass();
            Type t = reflection.GetType();
            foreach (var p in t.GetProperties())
            {
                
            }
        }
    }
}
