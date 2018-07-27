using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Message message = new Message(new XmlMessage());
                Console.WriteLine($"{message.Insert(new MessageModel("Insert", DateTime.Now))}");
                Console.WriteLine($"{message.Get()?[0].Message} {message.Get()?[0].Time}");
            }
            {
                Message message = new Message(new SqlMessage());
                Console.WriteLine($"{message.Insert(new MessageModel("Insert", DateTime.Now))}");
                Console.WriteLine($"{message.Get()?[0].Message} {message.Get()?[0].Time}");
            }
        }
    }
}
