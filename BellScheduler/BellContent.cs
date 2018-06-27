using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BellScheduler
{
   public class BellContent
    {
        private static BellContent Fcontent = null;
        private string[] _content;

        public string[] Content
           { get
            {
                return _content;
            }
            set
            {
                _content = value;
                IsSaved = false;
            }
              }


        public Boolean IsSaved { get; set; }

        public Boolean IsChanged { get; set; }

        public string FilePath { get; set; }

        public static BellContent ObjContent
        {
            get
            {
                if (Fcontent==null)
                {
                    Fcontent = new BellContent();
                }
                return Fcontent;
            }
        }

        public Boolean IsSaveRequired(string[] EditorContent)
        {
            Boolean Result = false;
            if (Content != null)
            { 
            Result = !EditorContent.SequenceEqual(Content) || string.IsNullOrEmpty(FilePath);
            }
            else 
            {
                Result = true;
            }
            return Result;
        }

        public void SaveContent()
        {
            //Save the file with specified path
            if ((! string.IsNullOrEmpty(FilePath)) && (!(Content==null)))
            {
                System.IO.File.WriteAllLines(FilePath, Content);
            }

           
            
        }

        public void CleanContent()
        {
            Content = null;
            FilePath = string.Empty;
        }
    }
}
