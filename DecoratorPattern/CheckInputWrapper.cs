using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class CheckInputWrapper : AbstractMessageWrapper
    {
        public CheckInputWrapper(AbstractMessage abstractMessage) 
            : base(abstractMessage)
        {
        }

        public override List<MessageModel> Get()
        {
            var L = base.Get();
            foreach (var item in L)
            {
                item.Message += "(经过输入验证)";
            }

            return L;
        }

        public override bool Insert(MessageModel messageModel)
        {
            return base.Insert(messageModel);
        }
    }
}
