using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ClinicProject.Reports
{
    public partial class ReportJob : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportJob()
        {
            InitializeComponent();
            jobTableAdapter.Fill(dataSetJob1.job);
        }

    }
}
