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

namespace ClinicProject.Reports
{
    public partial class Administration : DevExpress.XtraEditors.XtraForm
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SmartOneImport.Security.ActionFrm Fm1 = new SmartOneImport.Security.ActionFrm();
            Fm1.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            UserActionFrm Fm2 = new UserActionFrm();
            Fm2.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            new UserFrm().Show();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            new SmartOneImport.Security.ActionDetailForm().ShowDialog();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            new UpdateUserFrm().ShowDialog();
        }
    }
}