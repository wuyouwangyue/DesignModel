using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class MessageModel
    {
        public string Message { get; set; }
        public DateTime Time { get; set; }

        public MessageModel(string message, DateTime time)
        {
            this.Message = message;
            this.Time = time;
        }
    }
}
