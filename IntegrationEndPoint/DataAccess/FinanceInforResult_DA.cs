using IntegrationEndPoint.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.DataAccess
{
    public class FinanceInforResult
    {
       public static int Create(string Symbol,string Result)
        {
            int result = 1;
            DataProvider.ConnectionDMS conn = null;
            try
            {
                conn = new DataProvider.ConnectionDMS();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Symbol", Symbol));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Result", Result));
                result = conn.ExecuteNonQuery("sp_BI_FinanceInfor_Create", lsInput);
            }
            catch (Exception ex)
            {
                result = 0;
                FileLog.WriteFileLog("DataAccess-->FinanceInforResult_DA-->Create::" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
