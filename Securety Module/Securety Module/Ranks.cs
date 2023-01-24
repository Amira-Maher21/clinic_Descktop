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
    public partial class Ranks : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        DB.DataClassesSecurityMouleDataContext db = new DB.DataClassesSecurityMouleDataContext();
        public bool IsEdit { get; set; }
        public int Code { get; set; }
        public Ranks()
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
                Securety_Module.DB.Rank r = new Securety_Module.DB.Rank()
                {
                    RankName = textEditRankName.Text,
                    IsActive = Convert.ToBoolean(checkEdit1.EditValue)

                };
                db.Ranks.InsertOnSubmit(r);
                db.SubmitChanges();
            }
            else
            {
                var Edit = db.Ranks.Where(p => p.RankID == Code).FirstOrDefault();
                if (Edit != null)
                {
                    Edit.RankName = textEditRankName.Text;
                    Edit.IsActive = Convert.ToBoolean(checkEdit1.EditValue);
           

                    db.SubmitChanges();
                }
            }
            MessageBox.Show("تم الحفظ بنجاح");

        }

       private void Ranks_Load(object sender, EventArgs e)
        {
            checkEdit1.Checked = true;
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            textEditRankName.Text = null;
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }
    }
}