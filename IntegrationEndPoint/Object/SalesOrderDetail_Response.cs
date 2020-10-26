using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.Object
{
    public class SalesOrderDetail_Response
    {
        public IList<Results> Result { get; set; }
        public int Status { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public string MesageStatus { get; set; }

        public class Results
        {
            public string so_id { get; set; }
            public string p_id { get; set; }
            public string po_sku { get; set; }
            public string sod_itemname { get; set; }
            public string sod_quantity { get; set; }
            public string sod_itemunitpriceoriginal { get; set; }
            public string sod_itemunitprice { get; set; }
            public string sod_datecreated { get; set; }
            public string sod_datemodified { get; set; }
        }
        
    }
}
