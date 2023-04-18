using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static void CollectionToStringThread(object obj)
        {
            List<int> list = (List<int>)obj;
            Thread t = Thread.CurrentThread;
            foreach(int item in list)
            {
                Console.WriteLine(item.ToString());
               Thread.Sleep(100);
            }

        }


        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Thread th = new Thread(new ParameterizedThreadStart(CollectionToStringThread));
            th.IsBackground = true;
            th.Start(list);
        }
    }

}
