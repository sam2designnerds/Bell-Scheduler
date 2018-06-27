using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BellScheduler
{
    
    class BellProgram
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern int FreeConsole();
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 0) // Console
            {
                // Run as console code  
                BellManager bellManager = new BellManager();
                bellManager.HandleConsoleRequest(args);
                Console.Read();
                
            }
            else
            {
                // Run as windows code
                FreeConsole();
                Application.Run(new BellForm());
            }
        }
    }
}
