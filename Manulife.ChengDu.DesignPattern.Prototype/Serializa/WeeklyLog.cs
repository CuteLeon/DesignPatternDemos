using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Prototype.Serializa
{
    /// <summary>
    /// 工作周报：具体原型类
    /// 考虑到代码可读性和易理解性，只列出部分与原型模式相关的核心代码
    /// </summary>
    [Serializable]
    public class WeeklyLog : ICloneable
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string Content { get; set; }
        public IList<Attachment> attachmentList { get; set; }

        public WeeklyLog()
        {
            this.attachmentList = new List<Attachment>();
        }

        public object Clone()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, this);
            ms.Position = 0;
            return bf.Deserialize(ms);
        }
    }
}
