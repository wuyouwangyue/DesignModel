using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public class XmlMessage : IMessageStrategy
    {
        public List<MessageModel> Get()
        {
            return new List<MessageModel>() { new MessageModel("XML方式获取Message", DateTime.Now) };
        }

        public bool Insert(MessageModel messageModel)
        {
            return true;
        }
    }
}
