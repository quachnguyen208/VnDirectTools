using IntegrationEndPoint.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegrationEndPoint
{
    public partial class frmIntergrationEndPoint : Form
    {
        public frmIntergrationEndPoint()
        {
            InitializeComponent();
        }
        //public List<Object.EndPointRequest> GetData(Object.EndPointRequest input)
        //{
        //    List<Object.EndPointRequest> IsArray = new List<Object.EndPointRequest>();

        //    try
        //    {
        //        Dictionary<string, string> keywords = new Dictionary<string, string>();
        //        keywords.Add("@Code", input.Code);
        //        IsArray = new GlobalClass.ConnectionClass<Object.EndPointRequest>().GetData("sp_EndPointRequestSetup_Get", keywords).ToList();
                    
        //    }
        //    catch (Exception ex)
        //    {
        //        FileLog.WriteFileLog("Exception [API-GetData]" + ex.Message.ToString());
        //    }
        //    return IsArray;
        //}
        public void Customer(string obj, string createdate)
        {
            try
            {
                Object.Customer_Request request = new Object.Customer_Request();
                Object.Customer_Response response = new Object.Customer_Response();
                if (request != null)
                {                    
                    request.createdate = createdate;                    
                    string url = ConfigurationManager.AppSettings["API_URL"] + obj;
                    response = Business.Customer_BU.API.POST<Object.Customer_Response>(url, request);
                    if (response.Result.Count > 0)
                    {
                        foreach (var item in response.Result)
                        {
                            DataAccess.Customer_DA.Create(item.cc_id, item.cc_fullname, item.cc_phone, item.cc_address,item.cc_subregion.ToString(),item.cc_region.ToString()
                                ,item.cc_datecreated.ToString());
                            FileLog.WriteFileLog("Run [API] Customer[" + item.cc_id + "  " + item.cc_phone+ "]");
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("Exception [API-Customer]" + ex.Message.ToString());
            }
        }

        public void SalesOrder(string obj, string datefrom, string dateto)
        {
            try
            {
                Object.SalesOrder_Request request = new Object.SalesOrder_Request();
                Object.SalesOrder_Response response = new Object.SalesOrder_Response();
                if (request != null)
                {
                    request.datefrom = datefrom;
                    request.dateto = dateto;

                    string url = ConfigurationManager.AppSettings["API_URL"] + obj;
                    response = Business.SalesOrder_BU.API.POST<Object.SalesOrder_Response>(url, request);
                    if (response.Result.Count > 0)
                    {
                        foreach (var item in response.Result)
                        {
                            DataAccess.SalesOrder_DA.Create(item.ctm_id, item.so_id, item.so_invoiceid, item.so_status, item.so_pricesell.ToString(), item.so_priceshipping.ToString()
                                ,item.so_pricediscount.ToString(),item.so_pricediscountvip.ToString(),item.so_pricefinal.ToString(),item.so_contactemail,item.so_billinggender,item.so_billingfullname,item.so_billingphone
                                ,item.so_billingaddress,item.so_billingsubsubregionid,item.so_billingsubregionid,item.so_billingregionid,item.so_shippingfullname,item.so_shippingaddress
                                ,item.so_shippingsubsubregionid,item.so_shippingsubregionid,item.so_shippingregionid,item.so_datecreated.ToString(),item.so_datecompleted.ToString());
                            FileLog.WriteFileLog("Run [API] Sales Order[" + item.so_id + "  " + item.so_invoiceid + "]");
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("Exception [API-SalesOrder]" + ex.Message.ToString());
            }
        }

        public void SalesOrderDetail(string obj,string datefrom,string dateto)
        {
            try
            {
                Object.SalesOrderDetail_Request request = new Object.SalesOrderDetail_Request();
                Object.SalesOrderDetail_Response response = new Object.SalesOrderDetail_Response();
                if (request != null)
                {
                    request.datefrom = datefrom;
                    request.dateto = dateto;

                    string url = ConfigurationManager.AppSettings["API_URL"] + obj;
                    response = Business.SalesOrderDetail_BU.API.POST<Object.SalesOrderDetail_Response>(url, request);
                    if (response.Result.Count > 0)
                    {
                        foreach (var item in response.Result)
                        {
                            DataAccess.SalesOrderDetail_DA.Create(item.so_id,item.p_id,item.po_sku,item.sod_itemname,item.sod_quantity,item.sod_itemunitpriceoriginal
                                ,item.sod_itemunitprice,item.sod_datecreated.ToString(),item.sod_datemodified.ToString());
                            FileLog.WriteFileLog("Run [API] Sales Order Detail[" + item.so_id + "  " + item.po_sku + "]");
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("Exception [API-SalesOrder]" + ex.Message.ToString());
            }
        }

        public void FinanceInfor(string symbol,string postdata)
        {
            try
            {
                Object.FinanceInfor_Response response = new Object.FinanceInfor_Response();

                    //request.createdate = createdate;
                    string url = "https://finance.vietstock.vn/data/financeinfo";
                    string result = string.Empty;
                    result = Business.FinanceInfor.API.PostUrlVietStock(url, postdata);
                    DataAccess.FinanceInforResult.Create(txtSymbol.Text, result);
                    FileLog.WriteFileLog(result);
                    //response = Business.FinanceInfor.API.PostUrlVietStock(url, postdata);
                    //                    response = Business.FinanceInfor.API.POST<Object.FinanceInfor_Response>(url, postdata);
                    //                    if (response.Result.Count > 0)
                    //                    {
                    //                        foreach (var item in response.Result)
                    //                        {
                    //                            DataAccess.FinanceInfor.Create(item.ID,item.ReportNormID,item.Name,item.NameEn,item.NameMobile,item.NameMobileEn,item.CssStyle,item.Padding,item.ParentReportNormID,item.ReportComponentName,item.ReportComponentNameEn,
                    //item.Unit,item.UnitEn,item.OrderType,item.OrderingComponent,item.RowNumber,item.ReportComponentTypeID,item.ChildTotal,item.Levels,item.Value1,item.Value2,item.Value3,item.Value4);
                    //                            FileLog.WriteFileLog("Run [API] FinanceInfor[" + item.ID + "  " + item.ReportNormID+ "]");
                    //                        }

                    //                    }

            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("Exception [API-Customer]" + ex.Message.ToString());
            }
        }

        private void btnPost_Click(object sender, EventArgs e)
        {

            FinanceInfor(txtSymbol.Text, string.Format("Code={0}&ReportType={1}&ReportTermType=2&Unit=1000000&Page=1&PageSize=4&__RequestVerificationToken=aSECC8KYhwscu4wZ301Y2drwR60CgpszHYiEERRUvpyopDRNhqbV5kYL1v1GhTN1D4eAOD3DiMIyfaStY1OUFjT-D2wloeyzwDJjMwVQ6iXtmO4Yt9qgOd8c4kLPNZ52raoSqYF3H9VLu_ycvtseOg2", txtSymbol.Text, "BCTC"));

        }
        

        //private void btnPost_Click(object sender, EventArgs e)
        //{


        //    //string Code = ConfigurationManager.AppSettings["Code"];            
        //    //string CreateDate = ConfigurationManager.AppSettings["CreateDate"];
        //    //string FromDate = ConfigurationManager.AppSettings["FromDate"];
        //    //string ToDate = ConfigurationManager.AppSettings["ToDate"];

        //    //if (CreateDate == string.Empty)
        //    //{
        //    //    CreateDate = DateTime.Now.ToString("yyyy-MM-dd");
        //    //    txtValue1.Text = CreateDate.ToString();
        //    //}
        //    //else if (CreateDate.Length < 3)
        //    //{
        //    //    CreateDate = DateTime.Now.AddDays(double.Parse(CreateDate)).ToString("yyyy-MM-dd");
        //    //    txtValue1.Text = CreateDate.ToString();
        //    //}
        //    //else
        //    //{
        //    //    txtValue1.Text = CreateDate.ToString();
        //    //}


        //    //if (FromDate == string.Empty)
        //    //{
        //    //    FromDate = DateTime.Now.ToString("yyyy-MM-dd");
        //    //    txtValue2.Text = FromDate.ToString();
        //    //}
        //    //else if (FromDate.Length < 3)
        //    //{
        //    //    FromDate = DateTime.Now.AddDays(double.Parse(FromDate)).ToString("yyyy-MM-dd");
        //    //    txtValue2.Text = FromDate.ToString();
        //    //}
        //    //else
        //    //{ txtValue2.Text = FromDate.ToString(); }

        //    //if (ToDate == string.Empty)
        //    //{
        //    //    ToDate = DateTime.Now.ToString("yyyy-MM-dd");
        //    //    txtValue3.Text = ToDate.ToString();
        //    //}
        //    //else if (ToDate.Length < 3)
        //    //{ ToDate = DateTime.Now.AddDays(double.Parse(ToDate)).ToString("yyyy-MM-dd"); }
        //    //else
        //    //{ txtValue3.Text = ToDate.ToString(); }


        //    //if (Code == string.Empty)
        //    //{
        //    //    Customer("datacustomer", CreateDate);
        //    //    SalesOrder("saleorders", FromDate, ToDate);
        //    //    SalesOrderDetail("orderdetail", FromDate, ToDate);
        //    //}
        //    //else if (Code == "datacustomer")
        //    //{ Customer(Code,CreateDate); }
        //    //else if (Code == "saleorders")
        //    //{ SalesOrder(Code,FromDate, ToDate); }
        //    //else if (Code == "orderdetail")
        //    //{ SalesOrderDetail(Code,FromDate, ToDate); }
        //}
    }
}
