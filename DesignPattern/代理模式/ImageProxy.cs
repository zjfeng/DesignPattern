using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.代理模式
{
    internal class ImageProxy : IImage
    {
        private HeavyImage _heavyImage;
        private readonly string _path;

        public ImageProxy(string path)
        {
           _path = path;
        }

        public void Display()
        {
            if (_heavyImage == null)
            {
                _heavyImage = new HeavyImage(_path);
            }

            // 权限检查相关代码

            _heavyImage.Display();
        }
    }
}
