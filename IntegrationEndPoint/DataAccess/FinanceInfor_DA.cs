using IntegrationEndPoint.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.DataAccess
{
    public class FinanceInfor
    {
       public static int Create(string ID,string ReportNormID,string Name,string NameEn,string NameMobile,string NameMobileEn,
                string CssStyle,
                string Padding,
                string ParentReportNormID,
                string ReportComponentName,
                string ReportComponentNameEn,
                string Unit,
                string UnitEn,
                string OrderType,
                string OrderingComponent,
                string RowNumber,
                string ReportComponentTypeID,
                string ChildTotal,
                string Levels,
                string Value1,
                string Value2,
                string Value3,
                string Value4)
        {
            int result = 1;
            DataProvider.ConnectionDMS conn = null;
            try
            {
                conn = new DataProvider.ConnectionDMS();
                conn.Open();
                List<System.Data.SqlClient.SqlParameter> lsInput = new List<System.Data.SqlClient.SqlParameter>();
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ID", ID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ReportNormID", ReportNormID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Name", Name));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@NameEn", NameEn));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@NameMobile", NameMobile));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@NameMobileEn", NameMobileEn));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@CssStyle", CssStyle));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Padding", Padding));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ParentReportNormID", ParentReportNormID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ReportComponentName", ReportComponentName));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ReportComponentNameEn", ReportComponentNameEn));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Unit", Unit));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@UnitEn", UnitEn));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@OrderType", OrderType));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@OrderingComponent", OrderingComponent));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@RowNumber", RowNumber));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ReportComponentTypeID", ReportComponentTypeID));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@ChildTotal", ChildTotal));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Levels", Levels));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Value1", Value1));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Value2", Value2));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Value3", Value3));
                lsInput.Add(new System.Data.SqlClient.SqlParameter("@Value4", Value4));

                result = conn.ExecuteNonQuery("sp_FinanceInfoLine_Create", lsInput);
            }
            catch (Exception ex)
            {
                result = 0;
                FileLog.WriteFileLog("DataAccess-->FinanceInfor_DA-->Create::" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}
