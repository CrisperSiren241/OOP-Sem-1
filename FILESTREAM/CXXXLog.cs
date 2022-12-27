using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILESTREAM
{
    public class CXXXLog
    {
        public static void LOGGER(string info, string path)
        {
            if(path != null)
            {
                File.AppendAllText("log.text", $"{DateTime.Now}: {info}");
            }
            else
            {
                Console.WriteLine("Has not path!");
            }
        }
    }       
}
