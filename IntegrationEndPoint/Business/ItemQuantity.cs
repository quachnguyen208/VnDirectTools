﻿using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using IntegrationEndPoint.Utilities;

namespace IntegrationEndPoint.Business
{
    public class ItemQuantity
    {
        public class API
        {
            public static T POST<T>(string url, Object.ItemQuantity_Request obj) where T : class
            {
                T item = null;
                string postData = "";
                string result = "";
                try
                {
                    postData = Newtonsoft.Json.JsonConvert.SerializeObject(obj, Newtonsoft.Json.Formatting.Indented, new Newtonsoft.Json.JsonSerializerSettings()
                    {
                        ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                    });
                    //FileLog.WriteFileLog("API-->ETRANSFER-->POST::Data" + Environment.NewLine + postData);
                    System.Net.WebRequest request = System.Net.WebRequest.Create(url);
                    byte[] credentialBuffer = new UTF8Encoding().GetBytes(ConfigurationManager.AppSettings["API_User"] + ":" + ConfigurationManager.AppSettings["API_Password"]);
                    request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(credentialBuffer);
                    request.PreAuthenticate = true;
                    request.Method = "POST";

                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12 | SecurityProtocolType.Ssl3;
                    ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(delegate { return true; });
                    byte[] byteArray = System.Text.Encoding.UTF8.GetBytes(postData);
                    request.ContentType = "application/json; charset=utf-8";
                    request.ContentLength = byteArray.Length;
                    Stream dataStream = request.GetRequestStream();
                    dataStream.Write(byteArray, 0, byteArray.Length);
                    dataStream.Close();
                    System.Net.WebResponse response = request.GetResponse();
                    Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                    dataStream = response.GetResponseStream();
                    System.IO.StreamReader reader = new System.IO.StreamReader(dataStream);
                    result = reader.ReadToEnd();
                    reader.Close();
                    dataStream.Close();
                    response.Close();
                    item = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(result);
                    return item;
                }
                catch (Exception ex)
                {
                    FileLog.WriteFileLog("API-->Inventory-->Inventory::Data" + Environment.NewLine + postData);
                    FileLog.WriteFileLog("API-->Inventory-->POST::" + ex.Message);
                }
                return item;
            }
        }
    }
}
