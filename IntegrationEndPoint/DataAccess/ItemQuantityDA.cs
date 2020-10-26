using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntegrationEndPoint.Utilities;

namespace IntegrationEndPoint.DataAccess
{
    public class ItemQuantityDA
    {
        public static int Create(string ItemNo, string VariantCode, string LocationCode, double Quantity)
        {
            int result = 1;
            DataProvider.ConnectionDMS conn = null;
            try
            {
                conn = new DataProvider.ConnectionDMS();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ItemNo", ItemNo));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@VariantCode", VariantCode));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@LocationCode", LocationCode));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Quantity", Quantity));
                result = conn.ExecuteNonQuery("sp_ItemQuantity_Insert", lsInput);
            }
            catch (Exception ex)
            {
                result = 0;
                FileLog.WriteFileLog("DMS.DataAccess-->RequestOrder-->Insert::" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
