using System;
using ЛР_2;
namespace ЛР_3
{
    public class Program

    {
        public delegate double MyDel(int[] a);

        public static MyDel myDelegate = delegate (int[] a)
        {
            int s = 0;
            double res = 0;
            for (int i = 0; i < a.Length; i++)
            {
                s += a[i];
            }
            res = (s*1.0) / a.Length;
            return res;
        };
        public delegate double MyDelnew(double x, double y, string operatorr);

        public static MyDelnew myDelegatenew = delegate (double x, double y, string operatorr)
        {
            double s = double.MinValue + 1;
            switch (operatorr)
            {
                case "+": s=x + y;
                    break;
                case "-": s=x - y;
                    break;
                default: Console.WriteLine("ОШИБКА");
                    break;
            }
            return s;
        };
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            computer.AddNewUser += delegate
            {
                if (computer.UserList.Contains("admin"))
                    computer.UserList.Remove("admin");
            };
            computer.InvokeEvents();
        }
        }
}
