using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.Object
{
    public class SalesOrder_Response
    {
        public IList<Results> Result { get; set; }
        public int Status { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public string MesageStatus { get; set; }

        public class Results
        {
            public string ctm_id { get; set; }
            public string so_id { get; set; }
            public string so_invoiceid { get; set; }
            public string so_status { get; set; }
            public string so_pricesell { get; set; }
            public string so_pricediscount { get; set; }
            public string so_pricediscountvip { get; set; }
            public string so_pricefinal { get; set; }
            public string so_priceshipping { get; set; }
            public string so_contactemail { get; set; }
            public string so_billinggender { get; set; }
            public string so_billingfullname { get; set; }
            public string so_billingphone { get; set; }
            public string so_billingaddress { get; set; }
            public string so_billingsubsubregionid { get; set; }
            public string so_billingsubregionid { get; set; }
            public string so_billingregionid { get; set; }
            public string so_shippingfullname { get; set; }
            public string so_shippingaddress { get; set; }
            public string so_shippingsubsubregionid { get; set; }
            public string so_shippingsubregionid { get; set; }
            public string so_shippingregionid { get; set; }
            public string so_datecreated { get; set; }
            public string so_datecompleted { get; set; }
        }
    }
}
