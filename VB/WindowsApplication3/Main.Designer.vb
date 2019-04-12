Imports DevExpress.XtraGrid
Namespace DXSample
	Partial Public Class Main
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Main))
			Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.recordBindingSource = New System.Windows.Forms.BindingSource()
			Me.imageCollection1 = New DevExpress.Utils.ImageCollection()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
			Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemTrackBar()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
			Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colParentID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colText = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDt = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonPageGroup1
			' 
			Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
			Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
			' 
			' recordBindingSource
			' 
			Me.recordBindingSource.DataSource = GetType(DXSample.Data.Record)
			' 
			' imageCollection1
			' 
			Me.imageCollection1.ImageStream = (CType(resources.GetObject("imageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.barButtonItem1, Me.barButtonItem2, Me.barEditItem1, Me.barEditItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5})
			Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
			Me.ribbonControl1.MaxItemId = 11
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.ribbonPage1})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemProgressBar1, Me.repositoryItemTextEdit1, Me.repositoryItemTrackBar1})
			Me.ribbonControl1.Size = New System.Drawing.Size(1012, 141)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "barButtonItem1"
			Me.barButtonItem1.Id = 3
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "barButtonItem2"
			Me.barButtonItem2.Id = 4
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barEditItem1
			' 
			Me.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.barEditItem1.Caption = "barEditItem1"
			Me.barEditItem1.Edit = Me.repositoryItemTextEdit1
			Me.barEditItem1.Id = 6
			Me.barEditItem1.Name = "barEditItem1"
			' 
			' repositoryItemTextEdit1
			' 
			Me.repositoryItemTextEdit1.AutoHeight = False
			Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
			' 
			' barEditItem2
			' 
			Me.barEditItem2.Caption = "barEditItem2"
			Me.barEditItem2.Edit = Me.repositoryItemTrackBar1
			Me.barEditItem2.Id = 7
			Me.barEditItem2.Name = "barEditItem2"
			' 
			' repositoryItemTrackBar1
			' 
			Me.repositoryItemTrackBar1.LabelAppearance.Options.UseTextOptions = True
			Me.repositoryItemTrackBar1.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.repositoryItemTrackBar1.Name = "repositoryItemTrackBar1"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "barButtonItem3"
			Me.barButtonItem3.Id = 8
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barButtonItem4
			' 
			Me.barButtonItem4.Caption = "Save Layout"
			Me.barButtonItem4.Glyph = (CType(resources.GetObject("barButtonItem4.Glyph"), System.Drawing.Image))
			Me.barButtonItem4.Id = 9
			Me.barButtonItem4.LargeGlyph = (CType(resources.GetObject("barButtonItem4.LargeGlyph"), System.Drawing.Image))
			Me.barButtonItem4.Name = "barButtonItem4"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnSaveLayoutButtonClick);
			' 
			' barButtonItem5
			' 
			Me.barButtonItem5.Caption = "Restore Layout"
			Me.barButtonItem5.Glyph = (CType(resources.GetObject("barButtonItem5.Glyph"), System.Drawing.Image))
			Me.barButtonItem5.Id = 10
			Me.barButtonItem5.LargeGlyph = (CType(resources.GetObject("barButtonItem5.LargeGlyph"), System.Drawing.Image))
			Me.barButtonItem5.Name = "barButtonItem5"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.OnRestoreLayoutButtonClick);
			' 
			' ribbonPage1
			' 
			Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup2})
			Me.ribbonPage1.Name = "ribbonPage1"
			Me.ribbonPage1.Text = "Home"
			' 
			' ribbonPageGroup2
			' 
			Me.ribbonPageGroup2.ItemLinks.Add(Me.barButtonItem4)
			Me.ribbonPageGroup2.ItemLinks.Add(Me.barButtonItem5)
			Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
			Me.ribbonPageGroup2.Text = "Layout"
			' 
			' repositoryItemProgressBar1
			' 
			Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.recordBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 141)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.MenuManager = Me.ribbonControl1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(1012, 479)
			Me.gridControl1.TabIndex = 3
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colParentID, Me.colText, Me.colDt, Me.colState, Me.colImage})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			' 
			' colID
			' 
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' colParentID
			' 
			Me.colParentID.FieldName = "ParentID"
			Me.colParentID.Name = "colParentID"
			Me.colParentID.Visible = True
			Me.colParentID.VisibleIndex = 1
			' 
			' colText
			' 
			Me.colText.FieldName = "Text"
			Me.colText.Name = "colText"
			Me.colText.Visible = True
			Me.colText.VisibleIndex = 2
			' 
			' colDt
			' 
			Me.colDt.FieldName = "Dt"
			Me.colDt.Name = "colDt"
			Me.colDt.Visible = True
			Me.colDt.VisibleIndex = 3
			' 
			' colState
			' 
			Me.colState.FieldName = "State"
			Me.colState.Name = "colState"
			Me.colState.Visible = True
			Me.colState.VisibleIndex = 4
			' 
			' colImage
			' 
			Me.colImage.FieldName = "Image"
			Me.colImage.Name = "colImage"
			Me.colImage.Visible = True
			Me.colImage.VisibleIndex = 5
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(1012, 620)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.Name = "Main"
			Me.Text = "Main"
			CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.imageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private recordBindingSource As System.Windows.Forms.BindingSource
		Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private imageCollection1 As DevExpress.Utils.ImageCollection
		Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
		Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private gridControl1 As GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colParentID As DevExpress.XtraGrid.Columns.GridColumn
		Private colText As DevExpress.XtraGrid.Columns.GridColumn
		Private colDt As DevExpress.XtraGrid.Columns.GridColumn
		Private colState As DevExpress.XtraGrid.Columns.GridColumn
		Private colImage As DevExpress.XtraGrid.Columns.GridColumn
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barEditItem1 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
		Private barEditItem2 As DevExpress.XtraBars.BarEditItem
		Private repositoryItemTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemTrackBar
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar
		Private WithEvents barButtonItem4 As DevExpress.XtraBars.BarButtonItem
		Private WithEvents barButtonItem5 As DevExpress.XtraBars.BarButtonItem
	End Class
End Namespace