using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace GeoCodingService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }
        public void OnDebug()
        {
            OnStart(null);
        }
        System.Timers.Timer timer = new System.Timers.Timer();
        protected override void OnStart(string[] args)
        {
            timer.Elapsed += new ElapsedEventHandler(OnElapsedTime);
            string myPath = @"C:\Users\Master\source\repos\GeoCoding\GeoCoding\bin\Debug\GeoCoding.exe";
            System.Diagnostics.Process islem = new System.Diagnostics.Process();
            islem.StartInfo.FileName = myPath;
            islem.Start();
            timer.Interval = 10000;
            timer.Enabled = true;

        }
        private void OnElapsedTime(object source, ElapsedEventArgs e)
        {
            string myPath = @"C:\Users\Master\source\repos\GeoCoding\GeoCoding\bin\Debug\GeoCoding.exe";
            System.Diagnostics.Process islem = new System.Diagnostics.Process();
            islem.StartInfo.FileName = myPath;
            islem.Start();
        }
        protected override void OnStop()
        {
        }
    }
}
