using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractFactoryPattern
{
    public class XmlMessage : AbstractMessage
    {
        public override string Insert(AbstractMessageModel abstractMessageModel)
        {
            return $"Xml方式插入 Message -> "
                 + $"账号：{abstractMessageModel.UserId}；"
                 + $"内容：{abstractMessageModel.Message}；"
                 + $"时间：{abstractMessageModel.Time}";
        }
    }
}
