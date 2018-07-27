using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class AbstractMessage
    {
        public abstract List<MessageModel> Get();
        public abstract bool Insert(MessageModel messageModel);
    }
}
