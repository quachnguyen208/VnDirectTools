using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint.Object
{
    public class FinanceInfor_Response
    {
        public IList<Results> Result { get; set; }
        public int Status { get; set; }
        public bool Error { get; set; }
        public string Message { get; set; }
        public string MesageStatus { get; set; }
        public class Results
        {
            public string ID { get; set; }
            public string ReportNormID { get; set; }
            public string Name { get; set; }
            public string NameEn { get; set; }
            public string NameMobile { get; set; }
            public string NameMobileEn { get; set; }
            public string CssStyle { get; set; }
            public string Padding { get; set; }
            public string ParentReportNormID { get; set; }
            public string ReportComponentName { get; set; }
            public string ReportComponentNameEn { get; set; }
            public string Unit { get; set; }
            public string UnitEn { get; set; }
            public string OrderType { get; set; }
            public string OrderingComponent { get; set; }
            public string RowNumber { get; set; }
            public string ReportComponentTypeID { get; set; }
            public string ChildTotal { get; set; }
            public string Levels { get; set; }
            public string Value1 { get; set; }
            public string Value2 { get; set; }
            public string Value3 { get; set; }
            public string Value4 { get; set; }

        }

    }
}
