using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manulife.ChengDu.DesignPattern.Prototype.Serializa;
using Manulife.ChengDu.DesignPattern.Prototype.Clone;

namespace Manulife.ChengDu.DesignPattern.Prototype
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("序列化克隆：");
            SerializaClone();

            Console.WriteLine("————————————");

            Console.WriteLine("深度、浅度复制：");
            Clone();

            Console.ReadKey();
        }

        public static void SerializaClone()
        {
            WeeklyLog log = new WeeklyLog();
            log.Name = "Victor";
            log.Date = "第11周";
            log.Content = "这周工作太忙，每天都在加班！~~~~(>_<)~~~~";
            log.attachmentList.Add(new Attachment() { Name = "周报附件.xls" });
            
            WeeklyLog log2 = log.Clone() as WeeklyLog;
            log2.Date = "第12周";
            
            WeeklyLog log3 = log.Clone() as WeeklyLog;
            log3.Date = "第13周";

            Console.WriteLine("周报哈希：");
            Console.WriteLine("log : " + log.GetHashCode().ToString("X"));
            Console.WriteLine("log2 : " + log2.GetHashCode().ToString("X"));
            Console.WriteLine("log3 : " + log3.GetHashCode().ToString("X"));

            Console.WriteLine("附件哈希：");
            Console.WriteLine("log.attachmentList.First() : " + log.attachmentList.First().GetHashCode().ToString("X"));
            Console.WriteLine("log2.attachmentList.First() : " + log2.attachmentList.First().GetHashCode().ToString("X"));
            Console.WriteLine("log3.attachmentList.First() : " + log3.attachmentList.First().GetHashCode().ToString("X"));
        }

        public static void Clone()
        {
            // 对象深复制，附件浅复制
            MonthlyLog log = new MonthlyLog();
            log.attachments.Add(new Attachment() { Name = "工作总结20170426-20170501_Victor.xlsx" });

            MonthlyLog log2 = log.Clone() as MonthlyLog;

            Console.WriteLine("月报哈希：");
            Console.WriteLine("log : " + log.GetHashCode().ToString("X"));
            Console.WriteLine("log2 : " + log2.GetHashCode().ToString("X"));

            Console.WriteLine("附件哈希：");
            Console.WriteLine("log.attachments.First() : " + log.attachments.First().GetHashCode().ToString("X"));
            Console.WriteLine("log2.attachments.First() : " + log2.attachments.First().GetHashCode().ToString("X"));
        }
        
    }
}
