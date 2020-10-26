using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.Utilities
{
    public class Log
    {
        public static List<Object.LogObj> Get()
        {
            List<Object.LogObj> lsArray = new List<Object.LogObj>();
            try
            {
                
                Dictionary<string, string> keywords = new Dictionary<string, string>();
                lsArray = new GlobalClass.ConnectionClass<Object.LogObj>().GetData("sp_Log_Get", keywords).ToList();
            }
            catch (Exception ex)
            {
                Create("Logs", "Get", ex.Message);
            }
            return lsArray;
        }

        public static int Create(string type, string function, string error)
        {
            int result = 1;
            List<Object.LogObj> lsArray = new List<Object.LogObj>();
            try
            {
                Dictionary<string, string> keywords = new Dictionary<string, string>();
                keywords.Add("@Type", type);
                keywords.Add("@Function", function);
                keywords.Add("@Error", error);

                lsArray = new GlobalClass.ConnectionClass<Object.LogObj>().GetData("sp_Log_Insert", keywords).ToList();
                return result;
            }
            catch (Exception ex)
            {
                result = 0;
                throw ex;
            }
        }
    }
}
