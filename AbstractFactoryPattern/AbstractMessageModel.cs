using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public abstract class AbstractMessageModel
    {
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public abstract string UserId { get; set; }

        public AbstractMessageModel() { }
        public AbstractMessageModel(string message, DateTime time)
        {
            this.Message = message;
            this.Time = time;
        }
    }
}
