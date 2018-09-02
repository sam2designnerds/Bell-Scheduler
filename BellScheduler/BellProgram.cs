using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
            //AppDomain.CurrentDomain.AssemblyResolve += (sender, args1) => {
            //    String resourceName = "BellScheduler." +
            //       new AssemblyName(args1.Name).Name + ".dll";
            //   using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            //    {
            //        Console.WriteLine("testing");
            //        Byte[] assemblyData = new Byte[stream.Length];
            //        Console.WriteLine("testing");
            //        stream.Read(assemblyData, 0, assemblyData.Length);
            //        return Assembly.Load(assemblyData);
            //    }
            //};
            AppDomain.CurrentDomain.AssemblyResolve += AssembyResolver;
            Logger.Initialize();
            AppDomain.CurrentDomain.UnhandledException += UnhandledExceptionTrapper;
           

            if (args.Length != 0) // Console
            {
                // Run as console code  
                BellManager bellManager = new BellManager();
                bellManager.HandleConsoleRequest(args);

            }
            else
            {
                // Run as windows code
                FreeConsole();

                //if (Environment.OSVersion.Version.Major == 6)
                //SetProcessDPIAware();

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new BellForm());
            }
        }

        static void UnhandledExceptionTrapper(object sender, UnhandledExceptionEventArgs e)
        {
            //Console.WriteLine(e.ExceptionObject.ToString());
            //Console.WriteLine("Press Enter to continue");
            //Console.ReadLine();
            //Environment.Exit(1);
            // Logger.LogObj.LogException(NLog.LogLevel.Fatal, e.ExceptionObject.ToString(),null );
            Logger.LogObj.Info(e.ExceptionObject.ToString());
            Environment.Exit(1);
        }

        
        static Assembly AssembyResolver(object sender, ResolveEventArgs args)
        {
            String resourceName = "BellScheduler." + new AssemblyName(args.Name).Name + ".dll";
           // Console.WriteLine("Ashis" + resourceName);
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                Byte[] assemblyData = new Byte[stream.Length];
                stream.Read(assemblyData, 0, assemblyData.Length);
                return Assembly.Load(assemblyData);
            }

        }
    }
}


