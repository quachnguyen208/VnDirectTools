using IntegrationEndPoint.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace IntegrationEndPoint
{
    public partial class IntegrationEndPoint : ServiceBase
    {
        Timer timer = new Timer();
        public IntegrationEndPoint()
        {
            InitializeComponent();
        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            Process();
            Log.Create("IntegrationEndPoint", "OnElapsedTime", "Service is recall at " + DateTime.Now);
        }
        public void onDebug()
        {
            OnStart(null);
        }
        protected override void OnStart(string[] args)
        {
            // TODO: Add code here to start your service.
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = int.Parse(ConfigurationManager.AppSettings["MinutesInterval"])*60000;            
            timer.Enabled = true;
            Log.Create("IntegrationEndPoint", "OnStart", "Service is started at " + DateTime.Now);

        }

        protected override void OnStop()
        {
            Log.Create("IntegrationEndPoint", "OnStop", "Service is stopped at " + DateTime.Now);
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }

        //Function will be action below.
        //We have three Object DataCustomer,SalesOrder, SalesOrderDetail

        public void Process()
        {
            string Code = ConfigurationManager.AppSettings["Code"];
            string CreateDate = ConfigurationManager.AppSettings["CreateDate"];
            string FromDate = ConfigurationManager.AppSettings["FromDate"];
            string ToDate = ConfigurationManager.AppSettings["ToDate"];

            if (CreateDate == string.Empty)
            {CreateDate = DateTime.Now.ToString("yyyy-MM-dd");}
            else if (CreateDate.Length < 3)
            {CreateDate = DateTime.Now.AddDays(double.Parse(CreateDate)).ToString("yyyy-MM-dd");}
            if (FromDate == string.Empty)
            {FromDate = DateTime.Now.ToString("yyyy-MM-dd");}
            else if (FromDate.Length < 3)
            {FromDate = DateTime.Now.AddDays(double.Parse(FromDate)).ToString("yyyy-MM-dd");}
            if (ToDate == string.Empty)
            {ToDate = DateTime.Now.ToString("yyyy-MM-dd");}
            else if (ToDate.Length < 3)
            { ToDate = DateTime.Now.AddDays(double.Parse(ToDate)).ToString("yyyy-MM-dd");}

            if (Code == string.Empty)
            {
                Customer("datacustomer", CreateDate);
                SalesOrder("saleorders", FromDate, ToDate);
                SalesOrderDetail("orderdetail", FromDate, ToDate);
            }
            else if (Code == "datacustomer")
            { Customer(Code, CreateDate); }
            else if (Code == "saleorders")
            { SalesOrder(Code, FromDate, ToDate); }
            else if (Code == "orderdetail")
            { SalesOrderDetail(Code, FromDate, ToDate); }
        }
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
                            DataAccess.Customer_DA.Create(item.cc_id.ToString(), item.cc_fullname.ToString()
                                , item.cc_phone.ToString(), item.cc_address.ToString(), item.cc_subregion.ToString(), item.cc_region.ToString()
                                , item.cc_datecreated.ToString());
                            FileLog.WriteFileLog("Run [API] Customer[" + item.cc_id.ToString() + "  " + item.cc_phone.ToString()+ "]");
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
                                , item.so_pricediscount.ToString(), item.so_pricediscountvip.ToString(), item.so_pricefinal.ToString(), item.so_contactemail, item.so_billinggender, item.so_billingfullname, item.so_billingphone
                                , item.so_billingaddress, item.so_billingsubsubregionid, item.so_billingsubregionid, item.so_billingregionid, item.so_shippingfullname, item.so_shippingaddress
                                , item.so_shippingsubsubregionid, item.so_shippingsubregionid, item.so_shippingregionid, item.so_datecreated.ToString(), item.so_datecompleted.ToString());
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

        public void SalesOrderDetail(string obj, string datefrom, string dateto)
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
                            DataAccess.SalesOrderDetail_DA.Create(item.so_id, item.p_id, item.po_sku, item.sod_itemname, item.sod_quantity, item.sod_itemunitpriceoriginal
                                , item.sod_itemunitprice, item.sod_datecreated.ToString(), item.sod_datemodified.ToString());
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
    }
}
