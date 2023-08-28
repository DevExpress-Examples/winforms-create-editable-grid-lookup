Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms

Namespace PopupContainerEditSelection

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            gridControl1.DataSource = FillDataTable()
            controlNavigator1.NavigatableControl = gridControl1
            popupContainerControl1.Controls.Add(gridControl1)
            popupContainerControl1.Controls.Add(controlNavigator1)
            popupContainerEdit1.Properties.PopupControl = popupContainerControl1
            popupContainerEdit1.Properties.ShowPopupCloseButton = False
            AddHandler popupContainerEdit1.QueryDisplayText, New DevExpress.XtraEditors.Controls.QueryDisplayTextEventHandler(AddressOf popupContainerEdit1_QueryDisplayText)
            AddHandler popupContainerEdit1.QueryResultValue, New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(AddressOf popupContainerEdit1_QueryResultValue)
        End Sub

        Private Sub popupContainerEdit1_QueryResultValue(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryResultValueEventArgs)
            e.Value = gridView1.GetFocusedRowCellValue("Fruit")
        End Sub

        Private Sub popupContainerEdit1_QueryDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.QueryDisplayTextEventArgs)
            e.DisplayText = If(e.EditValue IsNot Nothing, e.EditValue.ToString(), "")
        End Sub

        Private Function FillDataTable() As DataTable
            Dim _dataTable As DataTable = New DataTable()
            Dim col As DataColumn
            Dim row As DataRow
            col = New DataColumn()
            col.ColumnName = "ID"
            col.DataType = Type.GetType("System.Int32")
            _dataTable.Columns.Add(col)
            col = New DataColumn()
            col.ColumnName = "Fruit"
            col.DataType = Type.GetType("System.String")
            _dataTable.Columns.Add(col)
            row = _dataTable.NewRow()
            row("ID") = "1"
            row("Fruit") = "Apple"
            _dataTable.Rows.Add(row)
            row = _dataTable.NewRow()
            row("ID") = "2"
            row("Fruit") = "Banana"
            _dataTable.Rows.Add(row)
            row = _dataTable.NewRow()
            row("ID") = "3"
            row("Fruit") = "Peach"
            _dataTable.Rows.Add(row)
            Return _dataTable
        End Function
    End Class
End Namespace
