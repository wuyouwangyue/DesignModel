using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class SqlMessage : AbstractMessage
    {
        public override List<MessageModel> Get()
        {
            return new List<MessageModel>() { new MessageModel("SQL方式获取Message", DateTime.Now) };
        }

        public override bool Insert(MessageModel messageModel)
        {
            return true;
        }
    }
}
