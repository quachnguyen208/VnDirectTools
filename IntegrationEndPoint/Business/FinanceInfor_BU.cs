using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.Business
{
    public class FinanceInfor
    {
        public class API
        {  
        public static string PostUrlVietStock(string url, string postData)
        {                
            string result = "";
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
                req.Method = "POST"; 
                req.Host = "finance.vietstock.vn";
                req.Accept = "*/*";
                req.Referer = "https://finance.vietstock.vn/STB/tai-chinh.htm";
                req.KeepAlive = true;
                req.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:89.0) Gecko/20100101 Firefox/89.0";
                req.ContentType = "application/x-www-form-urlencoded";
                //req.Timeout = 800;
                byte[] data = Encoding.UTF8.GetBytes(postData);
                req.ContentLength = data.Length;
                using (Stream reqStream = req.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }

                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                Stream stream = resp.GetResponseStream();
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
            }
            catch (Exception ex) 
            {
                    Utilities.FileLog.WriteFileLog("API-->FinanceInfor-->FinanceInfor::Data" + Environment.NewLine + postData);
                    Utilities.FileLog.WriteFileLog("API-->FinanceInfor-->POST::" + ex.Message);                
            }
            
            return result;
        }
        }
    }
}
