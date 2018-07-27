using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public abstract class AbstractMessageWrapper : AbstractMessage
    {
        private AbstractMessage Message { get; set; }

        public AbstractMessageWrapper(AbstractMessage abstractMessage)
        {
            this.Message = abstractMessage;
        }

        public override List<MessageModel> Get()
        {
            return this.Message.Get();
        }

        public override bool Insert(MessageModel messageModel)
        {
            return this.Insert(messageModel);
        }
    }
}
