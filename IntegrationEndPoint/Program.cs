using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntegrationEndPoint;

namespace IntegrationEndPoint
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if DEBUG
            //Application.Run(new frmIntergrationEndPoint());
            IntegrationEndPoint myservices = new IntegrationEndPoint();
            myservices.onDebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new IntegrationEndPoint()
            };
            ServiceBase.Run(ServicesToRun);
#endif
            //ServiceBase[] ServicesToRun;
            //ServicesToRun = new ServiceBase[]
            //{
            //    new IntegrationEndPoint()
            //};
            //ServiceBase.Run(ServicesToRun);
        }
    }
}
