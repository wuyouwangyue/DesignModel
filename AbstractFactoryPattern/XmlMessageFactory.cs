using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public class XmlMessageFactory : AbstractMessageFactory
    {
        public override AbstractMessage CreateMessage()
        {
            return new XmlMessage();
        }

        public override AbstractMessageModel CreateMessageModel()
        {
            return new XmlMessageModel();
        }
    }
}
