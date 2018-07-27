using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public class Message
    {
        private AbstractMessage abstractMessage { get; set; }
        private AbstractMessageModel abstractMessageModel { get; set; }

        public Message(AbstractMessageFactory factory)
        {
            this.abstractMessage = factory.CreateMessage();
            this.abstractMessageModel = factory.CreateMessageModel();
        }

        public string Insert(string userId, string message, DateTime time)
        {
            abstractMessageModel.UserId = userId;
            abstractMessageModel.Message = message;
            abstractMessageModel.Time = time;

            return abstractMessage.Insert(abstractMessageModel);
        }
    }
}
