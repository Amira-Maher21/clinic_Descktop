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
    public partial class doctorForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
 
    {
        DataBaseLayr.DataClasses1DataContext dbcontxt = new DataBaseLayr.DataClasses1DataContext();
        public doctorForm1()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Doctor et = new Doctor();
                et.DoctorName = Convert.ToString(textedit.EditValue);
                et.visitvalue = Convert.ToDecimal(textEdit2.EditValue);
                et.Revisitvalue = Convert.ToDecimal(textEdit3.EditValue);
                et.specializID = Convert.ToString(textEdit4.EditValue);

                dbcontxt.Doctors.InsertOnSubmit(et);
                dbcontxt.SubmitChanges();
                MessageBox.Show("تم الحفظ");
                gridControl1.DataSource = dbcontxt.Doctors.ToList();
            }
            catch
            {


                MessageBox.Show("لم يتم الحفظ ");
            }
       }
        void Clear()
        {
            textedit.EditValue = null;
            textEdit2.EditValue = null;
            textEdit3.EditValue = null;
            textEdit4.EditValue = null;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {


        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void doctorForm1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dbcontxt.Doctors.ToList();
        }
    }
}