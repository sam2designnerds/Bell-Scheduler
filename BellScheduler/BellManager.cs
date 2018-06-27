using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using System.IO;

namespace BellScheduler
{
    class BellManager
    {
        string task = string.Empty;
        string fileName = string.Empty;
        bool IsValidArguments;
        public void DownloadFile(string AfileName)
        {
            BellComunication BellComObj = new BellComunication();
            BellContent.ObjContent.Content = GetStringLinesFromContent(BellComObj.DownloadString());
            BellContent.ObjContent.FilePath = AfileName;
            BellContent.ObjContent.SaveContent();

        }

        public void HandleConsoleRequest(string[] args)
        {
            ParseConsoleCommand(args);
            if (!IsValidArguments)
            {
                Console.Write(BellConstants.HelpMessage);
                return;
             }

            if (task == BellConstants.Upload)
            {
                // Do the uplaod task
            }
            else if (task == BellConstants.Download)
            {
                // Do the download task
                
                DownloadFile(fileName);
            }

        }

        public void ParseConsoleCommand(string[] args)
        {
          
            var result = Parser.Default.ParseArguments<Options>(args);
            task = result.Value.Task.ToLower();
            fileName = result.Value.FileName;

            if (!(task == BellConstants.Upload || task == BellConstants.Download))
            {
                // show the help text and return
            }
            else if(( task == BellConstants.Upload && (!File.Exists(fileName)))
                ||(task == BellConstants.Download && (!Directory.Exists(Path.GetDirectoryName(fileName)))) )
            {
                // show the help text and return
               
            }
            else
            {
                IsValidArguments = true;
            }

        }

        public string[] GetStringLinesFromContent(string Content)
        {
            string[] splitSeparator = { Environment.NewLine };
            return Content.Split(splitSeparator, StringSplitOptions.RemoveEmptyEntries);
        }
    }

   internal class Options
    {
        [Option('T',Required = true, Separator = ' ', HelpText = @"Task--> Upload/Download: This accept Upload or Download and perform accordingly")]
        public string Task { get; set; }

        [Option('F',Required =true, Separator = ' ',HelpText = @" FileName--> fullpath of the file with its name")]
        public string FileName { get; set; }
    }
}
