using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public interface IMessageStrategy
    {
        List<MessageModel> Get();
        bool Insert(MessageModel messageModel);
    }
}
