using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SimplyService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            FileStream fs = new FileStream(@"c:\temp\mcWindowsService.txt",
            FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine(" mcWindowsService: Service Started \n");
            m_streamWriter.Flush();
            m_streamWriter.Close();

        }

        protected override void OnStop()
        {
            FileStream fs = new FileStream(@"c:\temp\mcWindowsService.txt",
    FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter m_streamWriter = new StreamWriter(fs);
            m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
            m_streamWriter.WriteLine(" mcWindowsService: Service Stopped \n"); m_streamWriter.Flush();
            m_streamWriter.Close();
        }
    }
}
