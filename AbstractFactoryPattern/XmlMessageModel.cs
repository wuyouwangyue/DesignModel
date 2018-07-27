using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public class XmlMessageModel : AbstractMessageModel
    {
        public override string UserId { get; set; }

        public XmlMessageModel() { }
        public XmlMessageModel(string userId, string message, DateTime time) 
            : base(message, time)
        {
            this.UserId = userId;
        }
    }
}
