using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMessageFactory abstractMessageFactory = new SqlMessageFactory();
            Message message = new Message(abstractMessageFactory);

            Console.WriteLine(message.Insert("admin", "Sql方式", DateTime.Now));

            abstractMessageFactory = new XmlMessageFactory();
            message = new Message(abstractMessageFactory);

            Console.WriteLine(message.Insert("user", "Xml方式", DateTime.Now));
        }
    }
}
