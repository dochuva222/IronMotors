using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace IronMotors.Services
{
    public static class Tools
    {
        public static BitmapImage BytesToImage(byte[] bytes) //метод нужен чтобы получать картинку в wpf из байтов, используется например чтобы показать картинку, которую мы выбрали через окно выбора 
        {
            using (MemoryStream memoryStream = new MemoryStream(bytes))
            {
                var image = new BitmapImage();
                image.BeginInit();
                image.CacheOption = BitmapCacheOption.OnLoad;
                image.StreamSource = memoryStream;
                image.EndInit();
                return image;
            }
        }
    }
}
