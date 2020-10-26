using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.Object
{
    public class EndPointRequest
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value1 { get; set; }
        public string Value2 { get; set; }
        public string Value3 { get; set; }
        public string Value4 { get; set; }
        public string Value5 { get; set; }
        public bool Enable  { get; set; }

        public EndPointRequest()
        {
            Code = "";
            Name = "";
            Description = "";
            Value1 = "";
            Value2 = "";
            Value3 = "";
            Value4 = "";
            Value5 = "";
            Enable = true;
        }

    }
    
}
