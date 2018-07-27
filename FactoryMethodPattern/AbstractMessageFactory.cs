using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class AbstractMessageFactory
    {
        public abstract AbstractMessage CreateMessage();
    }
}
