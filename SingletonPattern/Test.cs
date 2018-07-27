using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SingletonPattern
{
    public class Test
    {
        public DateTime Time { get; set; }

        public Test()
        {
            Thread.Sleep(3000);
            Time = DateTime.Now;
        }
    }
}
