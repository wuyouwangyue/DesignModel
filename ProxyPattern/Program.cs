using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageProxy messageProxy = new MessageProxy();
            Console.WriteLine($"{messageProxy.Insert(new MessageModel("Insert", DateTime.Now))}");
            Console.WriteLine($"{messageProxy.Get()?[0].Message} {messageProxy.Get()?[0].Time}");
        }
    }
}
