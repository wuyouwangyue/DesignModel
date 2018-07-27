using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public abstract class AbstractMessage
    {
        public abstract string Insert(AbstractMessageModel abstractMessageModel);
    }
}
