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
    public partial class ActionFrm1 : DevExpress.XtraEditors.XtraForm
    {
        DataBaseLayr.DataClasses1DataContext dbcontxt = new DataBaseLayr.DataClasses1DataContext();
        public ActionFrm1()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void ActionFrm1_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            var action = from ac in dbcon.Actions select ac;
            gridControl1.DataSource = action;
            fill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridView1.FocusedRowHandle = -1;
            string ActionName = null;
            string Notes = null;
            try
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    ActionName = gridView1.GetRowCellValue(i, "ActionName").ToString();
                    if (gridView1.GetRowCellValue(i, "Notes") != null)
                    {
                        Notes = gridView1.GetRowCellValue(i, "Notes").ToString();
                    }
                    else
                    {
                        Notes = null;
                    }
                    dbcon.ActionInsetUpdate(ActionName, Notes);
                }
                XtraMessageBox.Show("تم الحفظ بنجاح", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                XtraMessageBox.Show("لم يتم الحفظ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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