using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace LogClearner
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
       
        protected override void OnStart(string[] args)
        {
            try
            {
                foreach (var eventLog in EventLog.GetEventLogs())
                {
                    eventLog.Clear();
                    eventLog.Dispose();
                }
            }
            catch (Exception ex)
            {

                Library.writetoLog(ex);
            }
        }

        protected override void OnStop()
        {
        
        }
    }
}
