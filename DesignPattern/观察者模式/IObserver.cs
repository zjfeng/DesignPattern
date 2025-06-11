using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式
{
    internal interface IObserver<T>
    {
        /// <summary>
        /// 更新观察者
        /// </summary>
        void Update();
    }
}
