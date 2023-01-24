using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ClinicProject.DataBaseLayr;

namespace ClinicProject.FormLayer
{
    public partial class patientForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataBaseLayr.DataClasses1DataContext dbcontxt = new DataBaseLayr.DataClasses1DataContext();
        public patientForm1()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                patient pa = new patient();
                pa.patientName = Convert.ToString(textEdit1.EditValue);
                pa.patientage = Convert.ToInt32(textEdit1.EditValue);
                pa.patientphone = Convert.ToString(textEdit3.EditValue);
                dbcontxt.patients.InsertOnSubmit(pa);
                dbcontxt.SubmitChanges();
                Clear();
            }
            catch 
            {


                MessageBox.Show("لم يتم الحفظ");
            }
            gridControl1.DataSource = dbcontxt.patients.ToList();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void Clear()
        {
            textEdit1.EditValue = "";
            textEdit1.EditValue = 0;
            textEdit3.EditValue = 0;
        }

        private void patientForm1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dbcontxt.patients.ToList();
        }
    }
}