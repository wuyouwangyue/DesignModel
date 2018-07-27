using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class Message
    {
        private IMessageStrategy Strategy { get; set; }

        public Message(IMessageStrategy strategy)
        {
            this.Strategy = strategy;
        }

        public List<MessageModel> Get()
        {
            return this.Strategy.Get();
        }

        public bool Insert(MessageModel messageModel)
        {
            return this.Strategy.Insert(messageModel);
        }
    }
}
