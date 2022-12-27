using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILESTREAM
{
    public class XXXFileInfo
    {
        static string path = "D:\\BSTU\\ООП\\FILESTREAM\\text.txt";
        FileInfo info = new FileInfo(path);
        public void FileInformation()
        {
            if(info.Exists)
            {
                Console.WriteLine($"Имя файла: {info.Name}");
                Console.WriteLine($"Время создания: {info.CreationTime}");
                Console.WriteLine($"Размер: {info.Length}");
                Console.WriteLine($"Расширение: {info.Length}");
                Console.WriteLine($"Путь: {path}");
            }
        }
    }
}
