using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ClinicProject.Reports
{
    public partial class DoctorReport : DevExpress.XtraReports.UI.XtraReport
    {
        public DoctorReport()
        {
            InitializeComponent();
            dataTable1TableAdapter.Fill(dataSetDoctor1.DataTable1);
        }

    }
}
