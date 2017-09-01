using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;


namespace cSharp.Basic
{
    /// <summary>
    /// 主要是一些声明和控制语句
    /// </summary>
    public class BasicClass
    {
        /*
         * 控制权限修饰符
         * public     共有
         * private    私有
         * protected  保护
         */


        /// 声明变量
        private int a;                                   //int型    （结构体值类型）
        private string b;                                //string型  （引用类型）       
        private double c;                                //double型  (值类型)
        private decimal d;                               //decimal型 (结构体 值类型)
        private bool e;                                  //bool类型 （值类型）
        private cls f;                                   //声明一个cls的类
        private stu g;                                   //声明一个结构体
        private string[] strs = { "1","2","3"};          //数组的表示
        private enu h;                                   //声明一个枚举 （值类型）

        public BasicClass()                             //初始化当前类
        {

        }

        public BasicClass(string param)                //根据不同参数初始化类
        {

        }


        /***************for循环使用 ***************/
        private void DoForLoop()                      //方法
        {
            for (var i = 1; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            foreach (var i in strs)
            {
                Console.WriteLine(i);
            }

        }


        /// <summary>
        /// 处理if 语句
        /// </summary>
        private void DoIfSentence(bool isTrue)
        {
            if (isTrue)
            {

            }
            else
            {

            }
        }


        /// <summary>
        /// 处理switch语句
        /// </summary>
        /// <param name="a"></param>
        private void DoSwitchSentence(int a)
        {
            switch (a)
            {
                case 1:
                    Console.Write(1);
                    break;
                case 2:
                    Console.Write(2);
                    break;
                default:
                    break;
            }
        }

    }




    public class cls
    {

    }


    public struct stu
    {

    }

    public enum enu
    {
        one,
        two,
        three
    }

}
