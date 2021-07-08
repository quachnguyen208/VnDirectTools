using IntegrationEndPoint.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.DataAccess
{
    public class FinanceInforResultGrid
    {
       public static DataTable Get(string Symbol)
        {            
            DataTable dt = new DataTable();
            DataProvider.ConnectionDMS conn = null;
            try
            {
                conn = new DataProvider.ConnectionDMS();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@symbol", Symbol));             
                
                dt = conn.ExecuteNonQueryDataTable("sp_FinanceInfor_Get", lsInput);
            }
            catch (Exception ex)
            {
                dt = null;
                FileLog.WriteFileLog("DataAccess-->FinanceInforResultGrid_DA-->Create::" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;            
        }
    }
}
