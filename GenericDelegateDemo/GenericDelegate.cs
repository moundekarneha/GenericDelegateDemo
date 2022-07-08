using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegateDemo
{
    //Generic Delegate
    //define delegate 
    public delegate double DelegateAddNum1(int i, float f, double d);
    public delegate void DelegateAddNum2(int i, float f, double d);
    public delegate bool DelegateCheckLen(string str);
    internal class GenericDelegate
    {
        public static void Disp()
        {
            Console.WriteLine("Function without return type");
        }
        public static double AddNums1(int i, float f, double d)
        {
            return i + f + d;
        }

        public static void AddNums2(int i, float f, double d)
        {
            Console.WriteLine ("Addition = "+(i + f + d));
        }

        public static bool CheckLength(string s)
        {
            if(s.Length>5)
                return true;
            else
                return false;
        }

        static void Main()
        {
            DelegateAddNum1 obj1 = AddNums1;
            DelegateAddNum2 obj2 = AddNums2;
            DelegateCheckLen obj3 = CheckLength;
            double res = obj1.Invoke(10, 10.0f, 10.0);
            Console.WriteLine("Add = " + res);
            obj2.Invoke(10, 10.0f, 10.0);
            bool s = obj3.Invoke("nehamoundekar");
            Console.WriteLine("Bool value = " + s+"\n\n");

            //generic delegate - Func - with return type method 
            Console.WriteLine("Generic Delegate:\n");
            Func<int,float,double,double> fd = AddNums1;
            double res1 = fd.Invoke(10, 10.0f, 10.0);
            Console.WriteLine("Add = " + res1);

            //or
            Console.WriteLine("Generic Delegate:");
            Func<int, float, double, double> fd1 = new Func<int, float, double, double>(AddNums1);
            double res11 = fd.Invoke(10, 10.0f, 10.0);
            Console.WriteLine("Add = " + res11+"\n\n");


            //or
            Func<string,bool> pd1 = CheckLength;
            bool b22 = pd1("Maharaj");
            Console.WriteLine("\n B2 = " + b22);


            //generic delegate - Action - without return type method 
            Action ad = Disp;
            ad.Invoke();

            //generic delegate - Predicate - for bool returning method - and contains single parameter


            Predicate<string> pd = CheckLength;
            bool b2 = pd("Maharaj");
            Console.WriteLine("\n B2 = " + b2);



            Console.ReadLine();
        }





















    }
}
