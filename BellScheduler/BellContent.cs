using System;
using System.Collections.Generic;
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
    }
}
