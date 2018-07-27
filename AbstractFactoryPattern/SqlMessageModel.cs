using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public class SqlMessageModel : AbstractMessageModel
    {
        public override string UserId { get; set; }

        public SqlMessageModel() { }
        public SqlMessageModel(string userId, string message, DateTime time) 
            : base(message, time)
        {
            this.UserId = userId;
        }
    }
}
