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
using Securety_Module.DB;


namespace Securety_Module.Forms
{
    public partial class MainPermessions : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DB.DataClassesSecurityMouleDataContext db = new DB.DataClassesSecurityMouleDataContext();
        public bool IsEdit { get; set; }
        public int Code { get; set; }
        public MainPermessions()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!dxValidationProvider1.Validate())
            {
                return;
            }
            if (!IsEdit)
            {
                Securety_Module.DB.Action  objAct= new Securety_Module.DB.Action()
                {
                    ActionName = textEditActionName.Text,
                    IsActive = Convert.ToBoolean(checkEdit1.EditValue),
                    Notes =textEditNotes.Text

                };
                db.Actions.InsertOnSubmit(objAct);
                db.SubmitChanges();
            }
            else
            {
                var Edit = db.Actions.Where(p => p.ActionID == Code).FirstOrDefault();
                if (Edit != null)
                {
                    Edit.ActionName = textEditActionName.Text;
                    Edit.IsActive = Convert.ToBoolean(checkEdit1.EditValue);
                    Edit.Notes = textEditNotes.Text;
                   
                    db.SubmitChanges();
                }
            }
            MessageBox.Show("تم الحفظ بنجاح");
           
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditActionName.Text = null;
            textEditNotes.Text = null;
        }

        private void MainPermessions_Load(object sender, EventArgs e)
        {
            checkEdit1.Checked = true;
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}