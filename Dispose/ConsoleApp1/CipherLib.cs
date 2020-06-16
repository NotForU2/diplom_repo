using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.IO;
namespace CipherLib
{
    public class CipherComp : Component
    {
        StreamWriter log;
        static int useID = 0;
        int id;
        bool isDisposed;
        public CipherComp()
        {
            isDisposed = false;
            try
            {
                log = new StreamWriter("Log" + useID);
                id = useID;
                useID++;
                log.WriteLine("Create sucsessful");
            }
            catch (FileNotFoundException exc)
            {
                Console.WriteLine(exc);
                log = null;
            }
        }
        ~CipherComp()
        {
            Console.WriteLine("Деструктор для компонента " + id);
            Dispose(false);
        }
        public uint Fn(uint n, uint acc)
        {
            if (n == 0)
            {
                log.WriteLine(acc);
                return acc;
            }
            return Fn(n - 1, acc * n);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected override void Dispose(bool disposing)
        {
            Console.WriteLine("Dispose(" + disposing + ") for component " + id);
            if (!isDisposed)
            {
                if (disposing)
                {
                    log.WriteLine("Closed " + id);
                    log.Close();
                }
                Console.WriteLine("Free " + id + " component memory");
                base.Dispose(disposing);
                isDisposed = true;
            }
        }
    }
}