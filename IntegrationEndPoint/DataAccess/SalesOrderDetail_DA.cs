using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.DataAccess
{
    public class SalesOrderDetail_DA
    {
        public static int Create(string so_id,string p_id,string po_sku, string sod_itemname,string sod_quantity,string sod_itemunitpriceoriginal,string sod_itemunitprice,string sod_datecreated,string sod_datemodified)
        {
            int result = 1;
            DataProvider.ConnectionDMS conn = null;
            try
            {
                conn = new DataProvider.ConnectionDMS();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_id", so_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@p_id", p_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@po_sku", po_sku));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@sod_itemname", sod_itemname));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@sod_quantity", sod_quantity));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@sod_itemunitpriceoriginal", sod_itemunitpriceoriginal));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@sod_itemunitprice", sod_itemunitprice));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@sod_datecreated", sod_datecreated));                
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@sod_datemodified", sod_datemodified));

                result = conn.ExecuteNonQuery("sp_lit_sale_orders_detail_Create", lsInput);
            }
            catch (Exception ex)
            {
                result = 0;
                Utilities.FileLog.WriteFileLog("DataAccess-->SalesOrderDetail_DA-->Create::" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
