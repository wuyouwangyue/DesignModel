using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    public class SqlMessage : IMessage
    {
        public List<MessageModel> Get()
        {
            return new List<MessageModel>() { new MessageModel("SQL方式获取Message", DateTime.Now) };
        }

        public bool Insert(MessageModel messageModel)
        {
            return true;
        }
    }
}
