using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ClinicProject.FormLayer.DataSetDoctorTableAdapters;

namespace ClinicProject.Reports
{
    public partial class visitBtwReport : DevExpress.XtraReports.UI.XtraReport
    {

        public visitBtwReport(DateTime date1,DateTime date2)
        {
            InitializeComponent();

            dataTable1TableAdapter.Fill(dataSetVisitBtnDate1.DataTable1,date1,date2);
          

        }

        
    }
}
