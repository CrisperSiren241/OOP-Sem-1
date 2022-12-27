using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILESTREAM
{
    public class XXXDirInfo
    {
        string path = "D:\\";
        public void DirInfo()
        {
            if(Directory.Exists(path))
            {
                Console.WriteLine("Подкаталоги: ");
                string[] dirs = Directory.GetDirectories(path);
                foreach(string s in dirs)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы: ");
                string[] files = Directory.GetFiles(path);
                foreach(string f in files)
                {
                    Console.WriteLine(f);
                }
            }
        }
    }
}
