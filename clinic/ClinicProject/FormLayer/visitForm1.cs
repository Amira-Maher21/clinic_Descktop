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
    public partial class visitForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
         DataBaseLayr.DataClasses1DataContext dbcontxt = new DataBaseLayr.DataClasses1DataContext();

        public bool IsEdite;
        public int Code;
        private object g;
        public visitForm1()
        {
            InitializeComponent();
        }

        private void visitForm1_Load(object sender, EventArgs e)
        {
        Fill();
        }

        void Fill()
        {


            searchLookUpEdit1.Properties.DataSource = dbcontxt.patients.ToList();

            repositoryItemLookUpEdit2.DataSource = dbcontxt.patients.ToList();



            searchLookUpEdit2.Properties.DataSource = dbcontxt.Doctors.ToList();

            repositoryItemLookUpEdit1.DataSource = dbcontxt.Doctors.ToList();


            gridControl1.DataSource = dbcontxt.visits.ToList();

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

            try
            {
                if (IsEdite)
                {



                    var getdata = dbcontxt.visits.Where(a => a.visitID == Code).FirstOrDefault();
                    getdata.visitdate = Convert.ToDateTime(dateEdit1.EditValue);
                    getdata.DoctorId = Convert.ToInt32(searchLookUpEdit2.EditValue);
                    getdata.visitvalue = Convert.ToInt32(textEdit1.EditValue);
                    getdata.patientID = Convert.ToInt32(searchLookUpEdit1.EditValue);
                    getdata.Descreption = Convert.ToString(textEdit2.EditValue);



                    dbcontxt.SubmitChanges();
                    MessageBox.Show("تم الحفظ");
                    IsEdite = false;
                    Clear();
                    Fill();

                }
                else
                {
                    visit vi = new visit();
                    vi.visitdate = Convert.ToDateTime(dateEdit1.EditValue);
                    vi.DoctorId = Convert.ToInt32(searchLookUpEdit2.EditValue);
                    vi.visitvalue = Convert.ToInt32(textEdit1.EditValue);
                    vi.patientID = Convert.ToInt32(searchLookUpEdit1.EditValue);
                    vi.Descreption = Convert.ToString(textEdit2.EditValue);




                    dbcontxt.visits.InsertOnSubmit(vi);
                    dbcontxt.SubmitChanges();
                    MessageBox.Show("تم الحفظ");

                    Clear();
                    Fill();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("لم يتم الحفظ ");
            }
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            dateEdit1.EditValue = 0;
            searchLookUpEdit2.EditValue = 0;
            textEdit1.EditValue = null;
            searchLookUpEdit1.EditValue = 0;
            textEdit2.EditValue = null;
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void searchLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            Code = Convert.ToInt32(gridView1.GetFocusedRowCellValue("visitID"));
            var getdata = dbcontxt.visits.Where(a => a.visitID == Code).FirstOrDefault();

            dateEdit1.EditValue = Convert.ToDateTime(getdata.visitdate);
            searchLookUpEdit2.EditValue = Convert.ToInt32(getdata.DoctorId);
            textEdit1.EditValue = Convert.ToInt32(getdata.visitvalue);
            searchLookUpEdit1.EditValue = Convert.ToInt32(getdata.patientID);
            textEdit2.EditValue = Convert.ToString(getdata.Descreption);



            IsEdite = true;
        }
    }
}