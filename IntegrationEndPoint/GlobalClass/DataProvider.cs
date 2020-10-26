using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEndPoint
{
    public class DataProvider
    {
        
        public class ConnectionDMS : Connection.Connection
        {
            public ConnectionDMS()
                : base(System.Configuration.ConfigurationManager.ConnectionStrings["BI"].ConnectionString)
            {
            }
        }
    }
}
