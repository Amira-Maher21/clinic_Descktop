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
    public partial class SubPermessions : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DB.DataClassesSecurityMouleDataContext db = new DB.DataClassesSecurityMouleDataContext();
        public bool IsEdit { get; set; }
        public int Code { get; set; }
        public SubPermessions()
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
                Securety_Module.DB.ActionDetail objac = new Securety_Module.DB.ActionDetail()
                {
                    ActionDetailName = textEditActDetail.Text,
                    ActionID = Convert.ToInt32 (searchLookUpAction.EditValue),
                    Notes = textEditNotes.Text,
                    IsActive=checkEdit1.Checked

                };
                db.ActionDetails.InsertOnSubmit(objac);
                db.SubmitChanges();
            }
            else
            {
                var Edit = db.ActionDetails.Where(p => p.ActionDetailId == Code).FirstOrDefault();
                if (Edit != null)
                {
                    Edit.ActionDetailName = textEditActDetail.Text;
                    Edit.ActionID = Convert.ToInt32(searchLookUpAction.EditValue);
                    Edit.Notes = textEditNotes.Text;
                    Edit.IsActive = checkEdit1.Checked;

                    db.SubmitChanges();
                }
            }
            MessageBox.Show("تم الحفظ بنجاح");

        }

        private void SubPermessions_Load(object sender, EventArgs e)
        {
            searchLookUpAction.Properties.DataSource = db.Actions;
            checkEdit1.Checked = true;

        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditActDetail.Text = null;
            searchLookUpAction.EditValue = null;
            textEditNotes.Text = null;
       

        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void searchLookUpAction_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEditNotes_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEditActDetail_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}