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
    public partial class EmployeeForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataBaseLayr.DataClasses1DataContext dbcontxt = new DataBaseLayr.DataClasses1DataContext();

        public bool IsEdite;
        public int Code;
        private object g;
        public EmployeeForm1()
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
                if (IsEdite)
                {
                    var getdata = dbcontxt.employees.Where(a => a.empID ==Code).FirstOrDefault();
                    getdata.empName = Convert.ToString(textEdit1.EditValue);
                    getdata.empphone = Convert.ToInt32(searchLookUpEdit2.EditValue);
                    getdata.jobId = Convert.ToInt32(searchLookUpEdit1.EditValue);
                    getdata.empsalary = Convert.ToInt32(textEdit3.EditValue);
                    getdata.hiredate = Convert.ToDateTime(dateEdit1.EditValue);
                    getdata.isActive = Convert.ToBoolean(checkEdit1.EditValue);
                    getdata.note = Convert.ToString(textEdit4.EditValue);



                    dbcontxt.SubmitChanges();
                    MessageBox.Show("تم الحفظ");
                    IsEdite = false;
                    Clear();
                  Fill();
                }
                else
                {
                    employee em = new employee();
                    em.empName = Convert.ToString(textEdit1.EditValue);
                    em.empphone = Convert.ToInt32(searchLookUpEdit2.EditValue);
                    em.jobId = Convert.ToInt32(searchLookUpEdit1.EditValue);
                    em.empsalary = Convert.ToInt32(textEdit3.EditValue);
                    em.hiredate = Convert.ToDateTime(dateEdit1.EditValue);
                    em.isActive = Convert.ToBoolean(checkEdit1.Checked);
                    em.note = Convert.ToString(textEdit4.Text);


                    dbcontxt.employees.InsertOnSubmit(em);
                    dbcontxt.SubmitChanges();
                    MessageBox.Show("تم الحفظ");

                    Clear();
                   Fill();
                }
            }
            catch 
            {
                MessageBox.Show("لم يتم الحفظ ");

            }
    }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            textEdit1.EditValue = null;
            searchLookUpEdit2.EditValue = null;
            searchLookUpEdit1.EditValue = null;
            textEdit3.EditValue = null;
         dateEdit1.EditValue = null;
            checkEdit1.Checked = false;
           textEdit4.Text = "";
        }

        private void EmployeeForm1_Load(object sender, EventArgs e)
        {
            
            Fill();
        
          
        }
        void Fill()
        {
            searchLookUpEdit1.Properties.DataSource = dbcontxt.jobs.ToList();
            repositoryItemLookUpEdit1.DataSource = dbcontxt.jobs.ToList();



            gridControl1.DataSource = dbcontxt.employees.ToList();

            var au = (from a in dbcontxt.employees
                      join n in dbcontxt.jobs on a.jobId equals n.jobID

                      select new { a.empName, a.empphone, a.empsalary, a.hiredate, a.jobId, a.note, }).ToList();
            gridControl1.DataSource = au;
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

            Code = Convert.ToInt32(gridView1.GetFocusedRowCellValue("empID"));
            var getdata = dbcontxt.employees.Where(a => a.empID == Code).FirstOrDefault();




            textEdit1.EditValue = Convert.ToString(getdata.empName);
            searchLookUpEdit2.EditValue = Convert.ToInt32(getdata.empphone);
            searchLookUpEdit1.EditValue = Convert.ToString(getdata.jobId);
            textEdit3.EditValue = Convert.ToInt32(getdata.empsalary);
            dateEdit1.EditValue = Convert.ToInt32(getdata.hiredate);
            checkEdit1.EditValue = Convert.ToDateTime(getdata.isActive);
            textEdit4.EditValue = Convert.ToString(getdata.note);
       

            IsEdite = true;
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}