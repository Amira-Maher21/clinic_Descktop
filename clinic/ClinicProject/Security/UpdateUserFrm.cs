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
    public partial class UpdateUserFrm : DevExpress.XtraEditors.XtraForm
    {
        public UpdateUserFrm()
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
//    public partial class UpdateUserFrm : DevExpress.XtraEditors.XtraForm
//    {
//        DBDataContext dbcon = new DBDataContext();
//        public UpdateUserFrm()
//        {
//            InitializeComponent();
//            WindowsFormsSettings.DefaultFont = new Font("Times New Roman", 10, FontStyle.Bold);
//        }

//        private void UpdateUserFrm_Load(object sender, EventArgs e)
//        {
//            lookUpEdit1.Properties.DataSource = dbcon.Users;

//        }

//        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
//        {
//            Close();
//        }

//        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
//        {
//            if (dxValidationProvider1.Validate())
//            {
//                User User = dbcon.Users.Single(us => us.UserCode == Convert.ToInt32(lookUpEdit1.EditValue));
//                if (SmartOneImport.Security.UserInformation.CompHash(textEdit1.Text) == User.PassWord)
//                {
//                    if (textEdit2.Text == textEdit3.Text)
//                    {
//                        User.PassWord = SmartOneImport.Security.UserInformation.CompHash(textEdit2.Text);
//                        dbcon.SubmitChanges();
//                        XtraMessageBox.Show("تم الحفظ", "تغيير كلمة مرور المستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                        Clear();

//                    }
//                    else
//                    {
//                        XtraMessageBox.Show("أكد كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                        Clear();
//                    }

//                }
//                else
//                {
//                    XtraMessageBox.Show("كلمة المرور القديمة خطأ أعد إدخال كلمة المرور", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
//                    Clear();


//                }
//            }
//        }


//        private void Clear()
//        {
//            textEdit1.Text = "";
//            textEdit2.Text = "";
//            textEdit3.Text = "";