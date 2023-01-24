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

namespace ClinicProject.Security
{
    public partial class logncs : DevExpress.XtraEditors.XtraForm
    {
        public logncs()
        {
            InitializeComponent();
        }
    }
}












//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Text;
//using System.Linq;
//using System.Windows.Forms;
//using DevExpress.XtraEditors;
//using System.Configuration;

//using SmartOneImport;

//namespace SmartOneImport.Security
//{
//    public partial class Login : DevExpress.XtraEditors.XtraForm
//    {

//        DBDataContext dbcon = new DBDataContext();
//        public Login()
//        {
//            InitializeComponent();
//        }

//        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if (e.KeyChar == (char)13)
//            {
//                CheckPassWord();
//            }
//        }

//        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
//        {
//            if (e.KeyChar == (char)13)
//            {
//                CheckPassWord();
//            }
//        }
//        private bool CheckPassWord()
//        {
//            bool result = false;
//            try
//            {
//                User user = dbcon.Users.SingleOrDefault(s => s.Name == textEdit1.Text.Trim());
//                if (user.PassWord == SmartOneImport.Security.UserInformation.CompHash(textEdit2.EditValue.ToString()))
//                {
//                    result = true;
//                    SmartOneImport.Security.UserInformation.UserName = textEdit1.Text;
//                    if (chkRememberMe.Checked)
//                    {
//                        Properties.Settings.Default.UserName = textEdit1.Text;
//                        Properties.Settings.Default.Password = textEdit2.Text;
//                    }
//                    else
//                    {
//                        Properties.Settings.Default.UserName = null;
//                        Properties.Settings.Default.Password = null;
//                    }
//                    Properties.Settings.Default.RememberMe = chkRememberMe.Checked;
//                    Properties.Settings.Default.Save();
//                    this.Close();
//                }
//                else
//                {
//                    result = false;
//                    SmartOneImport.Security.UserInformation.UserName = null;
//                    MessageBox.Show("من فضلك تأكد من البيانات" + "\n" + "ربما يكون الإسم أو الرقم السري غير صحيح");
//                }

//            }
//            catch
//            {
//                result = false;
//                SmartOneImport.Security.UserInformation.UserName = null;
//                MessageBox.Show(" ربما يكون الإسم أو الرقم السري غير صحيح" + "\n" + "من فضلك تأكد من البيانات");
//            }
//            return result;
//        }

//        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
//        {
//            CheckPassWord();
//        }

//        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
//        {
//            SmartOneImport.Security.UserInformation.UserName = null;
//            System.Environment.Exit(1);
//            this.Close();
//        }

//        private void Login_Load(object sender, EventArgs e)
//        {
//            if (Properties.Settings.Default.RememberMe)
//            {
//                textEdit1.Text = Properties.Settings.Default.UserName;
//                textEdit2.Text = Properties.Settings.Default.Password;
//                chkRememberMe.Checked = Properties.Settings.Default.RememberMe;
//            }
//        }

//        private void button1_Click(object sender, EventArgs e)
//        {
//            CheckPassWord();
//        }

//        private void simpleButtonLogIn_Click(object sender, EventArgs e)
//        {
//            CheckPassWord();
//        }

//        private void simpleButtonCancel_Click(object sender, EventArgs e)
//        {
//            SmartOneImport.Security.UserInformation.UserName = null;
//            System.Environment.Exit(1);
//            this.Close();
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            SmartOneImport.Security.UserInformation.UserName = null;
//            System.Environment.Exit(1);
//            this.Close();
//        }

//        private void textEdit1_EditValueChanged(object sender, EventArgs e)
//        {

//        }
//    }
//}