using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.代理模式
{
    internal class HeavyImage
    {
        public readonly string Path;
        public HeavyImage(string path)
        {
            Path = path;
        }

        public void Display()
        {
            Console.WriteLine($"show picture: {Path}");
        }
    }
}
