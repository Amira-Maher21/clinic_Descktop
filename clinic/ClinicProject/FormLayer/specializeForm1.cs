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
    public partial class specializeForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DataBaseLayr.DataClasses1DataContext dbcontxt = new DataBaseLayr.DataClasses1DataContext();
        public specializeForm1()
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
                specialize ca = new specialize();
                ca.specializeName = Convert.ToString(textEdit1.EditValue);
                ca.isActive = Convert.ToBoolean(checkEdit1.Checked);
                dbcontxt.specializes.InsertOnSubmit(ca);
                dbcontxt.SubmitChanges();
                Clear();
            }
            catch 
            {
                MessageBox.Show("لم يتم الحفظ");

            }
            gridControl1.DataSource = dbcontxt.specializes.ToList();
        }

        private void specializeForm1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = dbcontxt.specializes.ToList();
        }
        private void Clear()
        {
            textEdit1.EditValue = null;
            checkEdit1.Checked = false;
        }
    }
}