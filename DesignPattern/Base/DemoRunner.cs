using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Base
{
    internal abstract class DemoRunner
    {
        public abstract string Description { get; }

        public void Run()
        {
            Console.WriteLine($"Running Demo: {Description}");
            Excute();
        }

        public abstract void Excute();
    }
}
