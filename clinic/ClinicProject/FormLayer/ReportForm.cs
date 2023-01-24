using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ClinicProject.FormLayer
{
    public partial class ReportForm : DevExpress.XtraEditors.XtraForm
    {
        DataBaseLayr.DataClasses1DataContext dbcontxt = new DataBaseLayr.DataClasses1DataContext();

        public ReportForm()
        {
            InitializeComponent();
        }

        public void fill()
        {
            dateEdit1.DateTime = DateTime.Now;
            dateEdit2.DateTime = DateTime.Now;
            searchLookUpEmp.Properties.DataSource = dbcontxt.employees.ToList();
            searchLookUpDoctor.Properties.DataSource = dbcontxt.Doctors.ToList();





        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            fill();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (!dxValidationProvider1.Validate())
            {
                return;
            }
            switch (Convert.ToInt32(imageComboBoxEdit1.EditValue))
            {
                case 1:

                    // Reports.DoctorReport doc = new DoctorReport(Convert.ToInt32(searchLookUpEmp.EditValue), Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit2.EditValue).AddHours(23).AddMinutes(59).AddSeconds(59));
                    Reports.DoctorReport doc = new Reports.DoctorReport();
                    doc.CreateDocument();
                   documentViewer1.DocumentSource = doc;


                    break;
                case 2:
                    
                    Reports.ReportJob jo = new Reports.ReportJob();
                    jo.CreateDocument();
                    documentViewer1.DocumentSource = jo;

                    break;


                case 3:

                    Reports.EmployeeReport em = new Reports.EmployeeReport();
                    em.CreateDocument();
                    documentViewer1.DocumentSource = em;

                    break;

                case 4:

                    Reports.visitBtwReport vi = new Reports.visitBtwReport(Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit2.EditValue).AddHours(23).AddMinutes(59).AddSeconds(59));
                    vi.CreateDocument();
                    documentViewer1.DocumentSource = vi;

                    break;


                case 5:
                    if (dxValidationProvider2.Validate())
                    {
                        Reports.Reportdoct4 vs = new Reports.Reportdoct4(Convert.ToInt32(searchLookUpDoctor.EditValue), Convert.ToDateTime(dateEdit1.EditValue), Convert.ToDateTime(dateEdit2.EditValue).AddHours(23).AddMinutes(59).AddSeconds(59));


                        vs.CreateDocument();
                        documentViewer1.DocumentSource = vs;
                    }
                   
                    break;








            }

        }

        private void imageComboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Convert.ToInt32(imageComboBoxEdit1.EditValue))
            {
                case 1:
                    layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;
                case 2:
                    layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;

                case 3:
                    layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    break;


                case 4:
                    layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;

                case 5:
                    layoutControlItem6.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
                    layoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlItem8.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    layoutControlItem9.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
                    break;


              
            }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}