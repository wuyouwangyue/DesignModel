using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public abstract class AbstractMessageFactory
    {
        public abstract AbstractMessageModel CreateMessageModel();
        public abstract AbstractMessage CreateMessage();
    }
}
