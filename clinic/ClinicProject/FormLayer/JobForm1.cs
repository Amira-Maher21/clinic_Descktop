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
    public partial class JobForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        //private object dbcontxt;
        DataBaseLayr.DataClasses1DataContext dbcontxt = new DataBaseLayr.DataClasses1DataContext();

        public JobForm1()
        {
            InitializeComponent();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                job jo = new job();

                jo.jobDesc = Convert.ToString(textEdit1.Text);
                jo.isActive = Convert.ToBoolean(checkEdit1.Checked);
                dbcontxt.jobs.InsertOnSubmit(jo);
                dbcontxt.SubmitChanges();

                MessageBox.Show("تم الحفظ");

                Clear();



            }
            catch
            {
                MessageBox.Show("لم تم الحفظ");
                return;
                gridControl1.DataSource = dbcontxt.jobs.ToList();

            }


        }

        private void Clear()
        {
            textEdit1.Text = "";
            checkEdit1.Checked = false;
        }
    
        private void gridControl1_Click(object sender, EventArgs e)
        {
                                      
        }

        private void JobForm1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dbcontxt.jobs.ToList();
        }
    }
}