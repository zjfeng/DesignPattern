using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式
{
    internal interface IObserverable<T>
    {
        void SetChanged();
        void AddObserver(IObserver<T> observer);
        void DeleteObserver(IObserver<T> observer);
        void NotifyObservers();
    }
}
