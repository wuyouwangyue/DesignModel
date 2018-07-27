using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Singleton<Test>.Instance.Time}");
            Thread.Sleep(1000);
            Console.WriteLine($"{Singleton<Test>.Instance.Time}");
        }
    }
}
