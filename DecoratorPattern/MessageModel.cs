using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class MessageModel
    {
        public MessageModel(string message, DateTime time)
        {
            Message = message;
            Time = time;
        }

        public string Message { get; set; }
        public DateTime Time { get; set; }
    }
}
