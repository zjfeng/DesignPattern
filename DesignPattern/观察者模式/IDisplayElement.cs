using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式
{
    internal interface IDisplayElement
    {
        /// <summary>
        /// 更新面板数据
        /// </summary>
        void Display();
    }
}
