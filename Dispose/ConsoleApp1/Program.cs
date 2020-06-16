using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CipherLib;
using System.Runtime.InteropServices;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                for (int k = 1; k <= 1000; k++)
                {
                    CipherComp сc = new CipherComp();
                    for (uint i = 0; i < 32; i++)
                        сc.Fn(i, 1);
                    сc.Dispose();
                }
            }
        }
    }
}
