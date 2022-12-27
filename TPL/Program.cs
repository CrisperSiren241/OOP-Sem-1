using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace TPL
{
    public class Program
    {
        static void Main(string[] args)
        {
            //TPL.ParallelVectorByNumber();
            //TPL.ParallelVectorByNumberWithTocken();
            //TPL.Continuation();
            TPL.ParallelFor();
            //TPL.Shop();
            //TPL.AsyncDemonstration();
        }
    }
}
