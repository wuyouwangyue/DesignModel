using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractMessage message = new SqlMessage();
            AbstractMessageWrapper amw = new CheckUserWarpper(message);
            Console.WriteLine($"{amw.Get()?[0].Message} {amw.Get()?[0].Time}");

            AbstractMessageWrapper amw2 = new CheckInputWrapper(message);
            Console.WriteLine($"{amw2.Get()?[0].Message} {amw2.Get()?[0].Time}");

            AbstractMessageWrapper amw3 = new CheckUserWarpper(message);
            AbstractMessageWrapper amw4 = new CheckInputWrapper(amw3);
            Console.WriteLine($"{amw4.Get()?[0].Message} {amw4.Get()?[0].Time}");
        }
    }
}
