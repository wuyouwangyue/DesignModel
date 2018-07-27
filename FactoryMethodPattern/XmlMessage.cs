using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern
{
    public class XmlMessage : AbstractMessage
    {
        public override List<MessageModel> Get()
        {
            return new List<MessageModel>() { new MessageModel("XML方式获取Message", DateTime.Now) };
        }

        public override bool Insert(MessageModel messageModel)
        {
            return true;
        }
    }
}
