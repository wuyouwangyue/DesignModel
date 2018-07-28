using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    public class MessageProxy : IMessage
    {
        private SqlMessage SqlMessage { get; set; }

        public MessageProxy()
        {
            this.SqlMessage = new SqlMessage();
        }

        public List<MessageModel> Get()
        {
            return this.SqlMessage.Get();
        }

        public bool Insert(MessageModel messageModel)
        {
            return this.SqlMessage.Insert(messageModel);
        }
    }
}
