Imports Microsoft.VisualBasic
Imports System
Namespace PopupContainerEditSelection
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.popupContainerEdit1 = New DevExpress.XtraEditors.PopupContainerEdit()
			Me.popupContainerControl1 = New DevExpress.XtraEditors.PopupContainerControl()
			Me.controlNavigator1 = New DevExpress.XtraEditors.ControlNavigator()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.popupContainerControl1.SuspendLayout()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' popupContainerEdit1
			' 
			Me.popupContainerEdit1.Location = New System.Drawing.Point(13, 13)
			Me.popupContainerEdit1.Name = "popupContainerEdit1"
			Me.popupContainerEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.popupContainerEdit1.Size = New System.Drawing.Size(161, 20)
			Me.popupContainerEdit1.TabIndex = 0
			' 
			' popupContainerControl1
			' 
			Me.popupContainerControl1.Controls.Add(Me.controlNavigator1)
			Me.popupContainerControl1.Controls.Add(Me.gridControl1)
			Me.popupContainerControl1.Location = New System.Drawing.Point(13, 40)
			Me.popupContainerControl1.Name = "popupContainerControl1"
			Me.popupContainerControl1.Size = New System.Drawing.Size(189, 175)
			Me.popupContainerControl1.TabIndex = 1
			' 
			' controlNavigator1
			' 
			Me.controlNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.controlNavigator1.Location = New System.Drawing.Point(0, 151)
			Me.controlNavigator1.Name = "controlNavigator1"
			Me.controlNavigator1.Size = New System.Drawing.Size(189, 24)
			Me.controlNavigator1.TabIndex = 2
			Me.controlNavigator1.Text = "controlNavigator1"
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Top
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(189, 152)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 262)
			Me.Controls.Add(Me.popupContainerControl1)
			Me.Controls.Add(Me.popupContainerEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.popupContainerEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.popupContainerControl1.ResumeLayout(False)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private popupContainerEdit1 As DevExpress.XtraEditors.PopupContainerEdit
		Private popupContainerControl1 As DevExpress.XtraEditors.PopupContainerControl
		Private controlNavigator1 As DevExpress.XtraEditors.ControlNavigator
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
	End Class
End Namespace

