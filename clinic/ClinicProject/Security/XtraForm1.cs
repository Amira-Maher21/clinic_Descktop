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

namespace ClinicProject.secayrty
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {

        DataBaseLayr.DataClasses1DataContext dbcontxt = new DataBaseLayr.DataClasses1DataContext();
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void FillGrid()
        {
            var actionDetail = from ac in dbcontxt.ActionDetails select ac;
            gridControl1.DataSource = actionDetail;
            fill();
        }

        private void fill()
        {
            throw new NotImplementedException();
        }

        private void searchLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

                gridView1.FocusedRowHandle = -1;
                string ActionDetailName = null;
                string ActionName = null;
                string Notes = null;
                try
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        ActionDetailName = gridView1.GetRowCellValue(i, "ActionDetailName").ToString();
                        ActionName = gridView1.GetRowCellValue(i, "ActionName").ToString();
                        if (gridView1.GetRowCellValue(i, "Notes") != null)
                        {
                            Notes = gridView1.GetRowCellValue(i, "Notes").ToString();
                        }
                        else
                        {
                            Notes = null;
                        }
                        dbcontxt.ActionDetailInsetUpdate(ActionDetailName, ActionName, Notes);
                    }
                    XtraMessageBox.Show("تم الحفظ بنجاح", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    XtraMessageBox.Show("لم يتم الحفظ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {

            var action = from ac in dbcontxt.Actions select ac;
            searchLookUpEdit1.Properties.DataSource = action;
            

        }
        private void fill()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn column in gridView1.Columns)
            {
                // column.Caption = Resources.ResourceManager.GetString(column.FieldName);
            }
        }
    }
}