using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.DataAccess
{
    public class SalesOrder_DA
    {
        public static int Create(string ctm_id,string so_id,string so_invoiceid,string so_status, string so_pricesell, string so_priceshipping,string so_pricediscount,
            string so_pricediscountvip, string so_pricefinal, string so_contactemail, string so_billinggender,string so_billingfullname, string so_billingphone, string so_billingaddress
            ,string so_billingsubsubregionid, string so_billingsubregionid, string so_billingregionid, string so_shippingfullname, string so_shippingaddress,string so_shippingsubsubregionid,string so_shippingsubregionid, string so_shippingregionid
            ,string so_datecreated, string so_datecompleted)
        {
            int result = 1;
            DataProvider.ConnectionDMS conn = null;
            try
            {
                conn = new DataProvider.ConnectionDMS();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ctm_id", ctm_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_id", so_id));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_invoiceid", so_invoiceid));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_status", so_status));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_pricesell", so_pricesell));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_priceshipping", so_priceshipping));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_pricediscount", so_pricediscount));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_pricediscountvip", so_pricediscountvip));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_pricefinal", so_pricefinal));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_contactemail", so_contactemail));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_billinggender", so_billinggender));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_billingfullname", so_billingfullname));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_billingphone", so_billingphone));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_billingaddress", so_billingaddress));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_billingsubsubregionid", so_billingsubsubregionid));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_billingsubregionid", so_billingsubregionid));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_billingregionid", so_billingregionid));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_shippingfullname", so_shippingfullname));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_shippingaddress", so_shippingaddress));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_shippingsubsubregionid", so_shippingsubsubregionid));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_shippingsubregionid", so_shippingsubregionid));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_shippingregionid", so_shippingregionid));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_datecreated", so_datecreated));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@so_datecompleted", so_datecompleted));              

                result = conn.ExecuteNonQuery("sp_lit_sale_orders_Create", lsInput);
            }
            catch (Exception ex)
            {
                result = 0;
                Utilities.FileLog.WriteFileLog("DataAccess-->SalesOrder_DA-->Create::" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
