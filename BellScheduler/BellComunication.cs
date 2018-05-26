using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.IO;

namespace BellScheduler
{
    class BellComunication
    {

        public string UserName { get; set; } = "admin";
        public string Password { get; set; } = "admin";

        public string ComMode { get; set; } = "TCP/IP";
        public string Host { get; set; } = "netbell.dyndns.ws";
        public string Port { get; set; } = "8007";
        public string Protocol { get; set; } = "Bells";

        public string DownloadURL
        {
            get
            {
                string result = string.Empty;
                result = "http://" + Host + ":" + Port + "/p/bellsDL.htm";
                return result;
            }
        }

        public string UploadURL
        {
            get
            {
                string result = string.Empty;
                result = "http://" + Host + ":" + Port + "/p/bellsDL.htm";
                return result;
            }
        }
        public String DownloadString()
        {
            String Result = string.Empty;
            String content = string.Empty;


            using (WebClient client = new WebClient())
            {
                client.Credentials = new System.Net.NetworkCredential(UserName, Password);
                client.Headers.Add("Content-Type", "application/octet-stream");
                using (Stream fileStream = File.OpenRead(@"C:\Users\ashis.meher\Desktop\Upload.txt"))
                using (Stream requestStream = client.OpenWrite(new Uri(@"http://netbell.dyndns.ws:8007/p/upload.htm"), "POST"))
                {
                    fileStream.CopyTo(requestStream);
                }
            }



            //using (var client = new WebClient())
            //{
            //    client.Credentials = new System.Net.NetworkCredential(UserName, Password);
            //    client.UploadFile(@"http://netbell.dyndns.ws:8007/p/upload.htm", @"C:\Users\ashis.meher\Desktop\Upload.txt");
            //}

            using (var client = new WebClient())
            {
                client.Credentials = new System.Net.NetworkCredential(UserName,Password);
                content = client.DownloadString(DownloadURL);
            }
           
            // This might need later if the html page change their structure, for now we are getting as a raw string i.e. content
            //var doc = new HtmlAgilityPack.HtmlDocument();
            Result = content.Substring(content.IndexOf("#Start")).Replace("<BR>",Environment.NewLine);
            return Result;
        }
    }
}
