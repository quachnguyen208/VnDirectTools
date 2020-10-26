using IntegrationEndPoint.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.DataAccess
{
    public class Customer_DA
    {
        public static int Create(string cc_id, string cc_fullname, string cc_phone, string cc_address, string cc_subregion, string cc_region,string cc_datecreated)
        {
            int result = 1;
            DataProvider.ConnectionDMS conn = null;
            try
            {
                conn = new DataProvider.ConnectionDMS();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@cc_id", cc_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@cc_fullname", cc_fullname));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@cc_phone", cc_phone));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@cc_address", cc_address));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@cc_subregion", cc_subregion));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@cc_region", cc_region));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@cc_datecreated", cc_datecreated));
                

                result = conn.ExecuteNonQuery("sp_lit_crm_customer_Create", lsInput);
            }
            catch (Exception ex)
            {
                result = 0;
                FileLog.WriteFileLog("DataAccess-->Customer_DA-->Create::" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
