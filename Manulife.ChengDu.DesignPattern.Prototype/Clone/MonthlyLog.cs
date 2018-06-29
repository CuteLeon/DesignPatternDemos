using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manulife.ChengDu.DesignPattern.Prototype.Clone
{
    public class MonthlyLog : ICloneable
    {
        public string Content { get; set; }

        public List<Attachment> attachments;

        public MonthlyLog()
        {
            attachments = new List<Attachment>();
        }

        public object Clone()
        {
            MonthlyLog monthlyLog = new MonthlyLog();
            monthlyLog.Content = this.Content;
            foreach (var attachment in this.attachments)
                monthlyLog.attachments.Add(attachment);
            return monthlyLog;
        }

    }
}
