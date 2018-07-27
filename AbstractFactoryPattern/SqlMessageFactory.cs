using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public class SqlMessageFactory : AbstractMessageFactory
    {
        public override AbstractMessage CreateMessage()
        {
            return new SqlMessage();
        }

        public override AbstractMessageModel CreateMessageModel()
        {
            return new SqlMessageModel();
        }
    }
}
