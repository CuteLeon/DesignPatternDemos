using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manulife.ChengDu.DesignPattern.SimpleFactory.Interface;

namespace Manulife.ChengDu.DesignPattern.SimpleFactory.Product
{
    public class HistogramChart : IChartable
    {
        public HistogramChart()
        {
            Console.WriteLine("创建柱状图...");
        }

        public void Display()
        {
            Console.WriteLine("显示柱状图...");
        }
    }
}
