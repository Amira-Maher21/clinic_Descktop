using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ClinicProject.Reports
{
    public partial class Reportdoct4 : DevExpress.XtraReports.UI.XtraReport
    {
        public Reportdoct4(int DoctorID, DateTime date1, DateTime date2)
        {
            InitializeComponent();

            dataTable1TableAdapter.Fill(dataSetdoct41.DataTable1, DoctorID, date1, date2);
            xrTableCell5.Text = date1.ToString();
            xrTableCell10.Text = date2.ToString();

        }

    }
}
