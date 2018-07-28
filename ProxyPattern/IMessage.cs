using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProxyPattern
{
    public interface IMessage
    {
        List<MessageModel> Get();
        bool Insert(MessageModel messageModel);
    }
}
