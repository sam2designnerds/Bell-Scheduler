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
using System.Net.Http;
using System.Threading;

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

        public int Delay { get; set; } = 1000;
        public string ComMode { get; set; } = "TCP/IP";
        public string Host { get; set; } = "netbell.dyndns.ws";
        public string Port { get; set; } = "8007";
        public string Protocol { get; set; } = "Bells";

        

        public void ClearStatus()
        {

            BellConstants.IsSuccess = false;
            BellConstants.ErrorMessage = string.Empty;
        } 

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
                result = "http://" + Host + ":" + Port + "/api/pgmbells/add/";
                return result;
            }
        }

        public string ResetURL
        {
            get
            {
                string result = string.Empty;
                result = "http://" + Host + ":" + Port + "/api/pgmbells/clearmem";
                return result;
            }
        }

        public String DownloadString()
        {
            String Result = string.Empty;
            String content = string.Empty;
            ClearStatus();

            using (var client = new WebClient())
            {
                client.Credentials = new System.Net.NetworkCredential(UserName,Password);
                try
                {
                    content = client.DownloadString(DownloadURL);
                    BellConstants.IsSuccess = true;
                }
                catch (WebException WE)
                {
                    BellConstants.IsSuccess = false;
                    BellConstants.ErrorMessage = WE.Message + Environment.NewLine + BellConstants.BellSettingIssue;
                    return Result;
                }
                
            }
           
            // This might need later if the html page change their structure, for now we are getting as a raw string i.e. content
            //var doc = new HtmlAgilityPack.HtmlDocument();
            Result = content.Substring(content.IndexOf("#Start")).Replace("<BR>",Environment.NewLine);
            return Result;
        }

        public String UploadBells(List<string> Abells)
        {
            String Result = string.Empty;
            String content = string.Empty;

            ClearStatus();

            // Reset before adding any bells to the system
            using (var client = new WebClient())
            {
                client.Credentials = new System.Net.NetworkCredential(UserName, Password);
                try
                {
                    content = client.DownloadString(ResetURL);
                    
                }
                catch (WebException WE)
                {
                    BellConstants.IsSuccess = false;
                    BellConstants.ErrorMessage = WE.Message + Environment.NewLine + BellConstants.BellSettingIssue;
                    return Result;

                }

            }

            foreach (var item in Abells)
            {
                using (var client = new WebClient())
                {
                    client.Credentials = new System.Net.NetworkCredential(UserName, Password);
                    try
                    {
                        content = client.DownloadString(UploadURL+item);
                        BellConstants.IsSuccess = true;
                    }
                    catch (WebException WE)
                    {

                        BellConstants.IsSuccess = false;
                        BellConstants.ErrorMessage = WE.Message + Environment.NewLine + BellConstants.BellSettingIssue;
                    }

                }
                // Adding the delay
                Thread.Sleep(Delay);
               
            }
            return Result;

        }

        public void SaveSettings()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(BellConstants.BellSettingsRegKey);

            key.SetValue(BellConstants.Host, Host);
            key.SetValue(BellConstants.Port, Port);
            key.SetValue(BellConstants.Protocol, Protocol);
            key.SetValue(BellConstants.UserName, UserName);
            key.SetValue(BellConstants.Password, Password);
            key.SetValue(BellConstants.Delay, Delay);
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
            Delay = Convert.ToInt32(Registry.GetValue(key.Name, BellConstants.Delay, Delay));
        }

    }
}
