using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.Object
{
    public class ItemQuantity_Response
    {
        public IList<Results> Result { get; set; }
        public int Status { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public string MesageStatus { get; set; }

        public class Results
        {
            public string ItemNo { get; set; }
            public string VariantCode { get; set; }
            public string LocationCode { get; set; }
            public double Quantity { get; set; }

        }
    }
}
