using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLibrary.Reflection
{
    public class ReflectClass
    {

        public string str;
        public ReflectClass()
        {
            Console.WriteLine($"name is{this.GetType().FullName}");
        }

        public string getSomeThing()
        {
            return "Ok";
        }

        public int getSomeThing(int a)
        {
            return a;
        }

        private string getSometing(string b)
        {
            return b;
        }
    }
}
