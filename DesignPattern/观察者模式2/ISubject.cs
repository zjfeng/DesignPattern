using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.观察者模式2
{
    public interface ISubject
    {
        public void Register(IObserver observer);
        public void Remove(IObserver observer);
        public void Notify();
    }
}
