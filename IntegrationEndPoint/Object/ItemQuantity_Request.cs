using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.Object
{
    public class ItemQuantity_Request
    {
        public string ItemNo { get; set; }
        public string VariantCode { get; set; }
        public string LocationCode { get; set; }
        public double Est { get; set; }
    }
}
