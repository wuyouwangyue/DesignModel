using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern
{
    public class SqlMessageFactory : AbstractMessageFactory
    {
        public override AbstractMessage CreateMessage()
        {
            return new SqlMessage();
        }
    }
}
