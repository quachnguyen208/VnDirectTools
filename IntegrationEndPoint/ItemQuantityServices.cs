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
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace IntegrationEndPoint
{
    public partial class ItemQuantityServices : ServiceBase
    {
        System.Timers.Timer timer = new System.Timers.Timer();
        public ItemQuantityServices()
        {
            InitializeComponent();
            
        }

        public static void GetByRequest()
        {
            DataProvider.ConnectionDMS conn = null;
            try
            {
                conn = new DataProvider.ConnectionDMS();
                Object.Customer_Request request = new Object.Customer_Request();                
                
                conn.Open();
                conn.BeginTransaction();
                var result = conn.ExecuteNonQuery("sp_EndPointRequestSetup_Get");

                if (result != null )
                {
                    //request.createdate = result
                }



                    
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("Run [API] GetByRequest["+ex.Message.ToString()+"]");
                
            }
        }

        public void Inventory()
        {
            try
            {
                Object.ItemQuantity_Request request = new Object.ItemQuantity_Request();
                Object.ItemQuantity_Response response = new Object.ItemQuantity_Response();
                if (request != null)
                {

                    request.ItemNo = "1010BMN0330";
                    request.VariantCode = "";
                    request.LocationCode = "VNB45";
                    request.Est = 0;
                    string url = ConfigurationManager.AppSettings["API_URL"] + "";
                    response = Business.ItemQuantity.API.POST<Object.ItemQuantity_Response>(url, request);
                    if (response.Result.Count > 0)
                    {
                        foreach (var item in response.Result)
                        {
                            DataAccess.ItemQuantityDA.Create(item.ItemNo, item.VariantCode, item.LocationCode, item.Quantity);
                            FileLog.WriteFileLog("Run [API] Item_Variant[" + item.ItemNo + "  " + item.VariantCode + "]");
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                FileLog.WriteFileLog("Exception [API]" + ex.Message.ToString());
            }
        }
        public void onDebug()
        {
            OnStart(null);
        }

        protected override void OnStart(string[] args)
        {            
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            timer.Interval = int.Parse(System.Configuration.ConfigurationManager.AppSettings["MinutesInterval"]);           
            timer.Enabled = true;
        }

        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            Inventory();
        }

        protected override void OnStop()
        {
            FileLog.WriteFileLog("Exception [API]" );
        }
    }
}
