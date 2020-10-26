using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.Object
{
    public class Customer_Response
    {
        public IList<Results> Result { get; set; }
        public int Status { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public string MesageStatus { get; set; }
        public class Results
        {
            public string cc_id { get; set; }
            public string cc_fullname { get; set; }
            public string cc_phone { get; set; }
            public string cc_address { get; set; }
            public string cc_subregion { get; set; }
            public string cc_region { get; set; }
            public string cc_datecreated { get; set; }
        }
        
    }
}
