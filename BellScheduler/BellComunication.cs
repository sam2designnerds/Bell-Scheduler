using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace BellScheduler
{
    class BellComunication
    {

       
        public static BellComunication bellCommunication = null;

        public static BellComunication ObjCommunication
        {
            get
            {
                if (bellCommunication == null)
                {
                    bellCommunication = new BellComunication();
                }
                return bellCommunication;
            }
        }
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


            //using (WebClient client = new WebClient())
            //{
            //    client.Credentials = new System.Net.NetworkCredential(UserName, Password);
            //    client.Headers.Add("Content-Type", "application/octet-stream");
            //    using (Stream fileStream = File.OpenRead(@"C:\Users\ashis.meher\Desktop\Upload.txt"))
            //    using (Stream requestStream = client.OpenWrite(new Uri(@"http://netbell.dyndns.ws:8007/p/upload.htm"), "POST"))
            //    {
            //        fileStream.CopyTo(requestStream);
            //    }
            //}



            //using (var client = new WebClient())
            //{
            //    client.Credentials = new System.Net.NetworkCredential(UserName, Password);
            //    client.UploadFile(@"http://netbell.dyndns.ws:8007/p/upload.htm", @"C:\Users\ashis.meher\Desktop\Upload.txt");
            //}

            using (var client = new WebClient())
            {
                client.Credentials = new System.Net.NetworkCredential(UserName,Password);
                try
                {
                    content = client.DownloadString(DownloadURL);
                }
                catch (WebException WE)
                {

                    MessageBox.Show(WE.Message+Environment.NewLine +"Please check your set up information to connect the server properly");
                    return Result;
                }
                
            }
           
            // This might need later if the html page change their structure, for now we are getting as a raw string i.e. content
            //var doc = new HtmlAgilityPack.HtmlDocument();
            Result = content.Substring(content.IndexOf("#Start")).Replace("<BR>",Environment.NewLine);
            return Result;
        }

        public void UploadFile()
        {
            //using (WebClient client = new WebClient())
            //{
            //    client.Credentials = new System.Net.NetworkCredential(UserName, Password);
            //    client.Headers.Add("Content-Type", "multipart/form-data");
            //    using (Stream fileStream = File.OpenRead(@"C:\Users\ashis.meher\Desktop\Upload.txt"))
            //    using (Stream requestStream = client.OpenWrite(new Uri(@"http://netbell.dyndns.ws:8007/p/upload.htm"), "POST"))
            //    {
            //        fileStream.CopyTo(requestStream);
            //    }
            //}

            FileStream stream = File.OpenRead(@"C:\Users\ashis.meher\Desktop\Upload.txt");
            byte[] fileBytes = new byte[stream.Length];

            stream.Read(fileBytes, 0, fileBytes.Length);
            stream.Close();

            var url = @"http://netbell.dyndns.ws:8007/p/upload.htm";
            var webClient = new WebClient();
                 webClient.Credentials = new System.Net.NetworkCredential(UserName, Password);
            string boundary = "------------------------" + DateTime.Now.Ticks.ToString("x");
            webClient.Headers.Add("Content-Type", "multipart/form-data; boundary=" + boundary);
            var fileData = webClient.Encoding.GetString(fileBytes);
            var package = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"file\"; filename=\"{1}\"\r\nContent-Type: {2}\r\n\r\n{3}\r\n--{0}--\r\n", boundary, "Upload.txt", "multipart/form-data; boundary=" + boundary, fileData);

            var nfile = webClient.Encoding.GetBytes(package);

            byte[] resp = webClient.UploadData(url, "POST", nfile);
            string str = Encoding.ASCII.GetString(resp, 0, resp.Length);
            MessageBox.Show(str);
        }

        public void SaveSettings()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(BellConstants.BellSettingsRegKey);

            key.SetValue(BellConstants.Host, Host);
            key.SetValue(BellConstants.Port, Port);
            key.SetValue(BellConstants.Protocol, Protocol);
            key.SetValue(BellConstants.UserName, UserName);
            key.SetValue(BellConstants.Password, Password);
        }

        public void RetriveSettings()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(BellConstants.BellSettingsRegKey);
            if (Registry.GetValue(key.Name, BellConstants.Host, null) == null)
            {
                //code if key Not Exist
                SaveSettings();

            }
            else
            {
                //code if key Exist
            }

            Host = Registry.GetValue(key.Name, BellConstants.Host, Host).ToString();
            Port = Registry.GetValue(key.Name, BellConstants.Port, Port).ToString();
            Protocol = Registry.GetValue(key.Name, BellConstants.Protocol, Protocol).ToString();
            UserName = Registry.GetValue(key.Name, BellConstants.UserName, UserName).ToString();
            Password = Registry.GetValue(key.Name, BellConstants.Password, Password).ToString();
        }

    }
}
