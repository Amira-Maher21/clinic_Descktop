using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ClinicProject.Reports
{
    public partial class EmployeeReport : DevExpress.XtraReports.UI.XtraReport
    {
        public EmployeeReport()
        { 
            InitializeComponent();
            dataTable1TableAdapter.Fill(dataSetEmployee1.DataTable1 );
        }

    }
}
