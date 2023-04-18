using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    internal class Bank
    {
        private int Money;
        public string Name { get; set; }
        private int Percent;
        public int _Money
        {
            get => Money;
            set
            {
                Money = value;
                Thread th = new Thread(new ThreadStart(PropertyChanged));
                th.IsBackground = true;
            }
        }
        public int _Percent
        {
            get => Percent;
            set
            {
                Percent = value;
                Thread th = new Thread(new ThreadStart(PropertyChanged));
                th.IsBackground = true;
            }
        }
        public void PropertyChanged()
        {
            Thread th = Thread.CurrentThread;
            StreamWriter writer = new StreamWriter("Bank.txt", true);
            writer.WriteLine("Money: " + Money);
            writer.WriteLine("Name: " + Name);
            writer.WriteLine("Percent: " + Percent);
            writer.Close();
            th.Abort();

        }
    }
}
