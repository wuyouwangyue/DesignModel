using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                AbstractMessageFactory abstractMessageFactory = new SqlMessageFactory();
                AbstractMessage abstractMessage = abstractMessageFactory.CreateMessage();
                Console.WriteLine($"{abstractMessage.Insert(new MessageModel("Insert", DateTime.Now))}");
                Console.WriteLine($"{abstractMessage.Get()?[0].Message} {abstractMessage.Get()?[0].Time}");
            }
            {
                AbstractMessageFactory abstractMessageFactory = new XmlMessageFactory();
                AbstractMessage abstractMessage = abstractMessageFactory.CreateMessage();
                Console.WriteLine($"{abstractMessage.Insert(new MessageModel("Insert", DateTime.Now))}");
                Console.WriteLine($"{abstractMessage.Get()?[0].Message} {abstractMessage.Get()?[0].Time}");
            }
        }
    }
}
