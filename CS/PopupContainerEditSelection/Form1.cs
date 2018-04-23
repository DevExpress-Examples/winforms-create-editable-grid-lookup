using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;

namespace PopupContainerEditSelection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = FillDataTable();
            controlNavigator1.NavigatableControl = gridControl1;

            popupContainerControl1.Controls.Add(gridControl1);
            popupContainerControl1.Controls.Add(controlNavigator1);

            popupContainerEdit1.Properties.PopupControl = popupContainerControl1;
            popupContainerEdit1.Properties.ShowPopupCloseButton = false;
            popupContainerEdit1.QueryDisplayText += new DevExpress.XtraEditors.Controls.QueryDisplayTextEventHandler(popupContainerEdit1_QueryDisplayText);
            popupContainerEdit1.QueryResultValue += new DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(popupContainerEdit1_QueryResultValue);
        }

        void popupContainerEdit1_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e)
        {
            e.Value = gridView1.GetFocusedRowCellValue("Fruit");
        }

        void popupContainerEdit1_QueryDisplayText(object sender, DevExpress.XtraEditors.Controls.QueryDisplayTextEventArgs e)
        {
            e.DisplayText = e.EditValue != null ? e.EditValue.ToString() : "";
        }

        DataTable FillDataTable()
        {
            DataTable _dataTable = new DataTable();
            DataColumn col;
            DataRow row;

            col = new DataColumn();
            col.ColumnName = "ID";
            col.DataType = System.Type.GetType("System.Int32");
            _dataTable.Columns.Add(col);

            col = new DataColumn();
            col.ColumnName = "Fruit";
            col.DataType = System.Type.GetType("System.String");
            _dataTable.Columns.Add(col);

            row = _dataTable.NewRow();
            row["ID"] = "1"; row["Fruit"] = "Apple";
            _dataTable.Rows.Add(row);

            row = _dataTable.NewRow();
            row["ID"] = "2"; row["Fruit"] = "Banana";
            _dataTable.Rows.Add(row);

            row = _dataTable.NewRow();
            row["ID"] = "3"; row["Fruit"] = "Peach";
            _dataTable.Rows.Add(row);

            return _dataTable;
        }
    }
}
