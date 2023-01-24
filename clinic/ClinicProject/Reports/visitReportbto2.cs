using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ClinicProject.Reports
{
    public partial class visitReportbto2 : DevExpress.XtraReports.UI.XtraReport
    {
        private DateTime dateTime1;
        private DateTime dateTime2;
        private DateTime dateTime3;

        public visitReportbto2()
        {
        }

        public visitReportbto2(DateTime dateTime1, DateTime dateTime2, DateTime dateTime3)
        {
            this.dateTime1 = dateTime1;
            this.dateTime2 = dateTime2;
            this.dateTime3 = dateTime3;
        }

        public visitReportbto2(int DoctorID, DateTime date1,DateTime date2)
        {
            InitializeComponent();
            dataTable1TableAdapter1.Fill(dataSet11.DataTable1, DoctorID, date1, date2);
        }

        
        
    }
}
