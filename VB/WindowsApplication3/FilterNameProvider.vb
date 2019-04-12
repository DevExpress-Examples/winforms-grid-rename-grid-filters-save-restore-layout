Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.Utils.Serializing
Imports DevExpress.XtraBars.Docking2010.Customization
Imports DevExpress.XtraBars.Docking2010.Views.WindowsUI
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DXSample
	Public Class FilterNameProvider
		Private filters As List(Of GridFitlerItem)
		Private menu As DXPopupMenu
		Private view As GridView
		Public Sub New(ByVal view As GridView)
			Me.view = view
			view.OptionsLayout.StoreDataSettings = True
			filters = New List(Of GridFitlerItem)()
		End Sub
		Private fAllowSettingFilterNames As Boolean
		Public Property AllowSettingFilterNames() As Boolean
			Get
				Return fAllowSettingFilterNames
			End Get
			Set(ByVal value As Boolean)
				If fAllowSettingFilterNames <> value Then
					fAllowSettingFilterNames = value
					If fAllowSettingFilterNames Then
						SubscribeToEvents()
						CreatePopupMenu()
					Else
						UnsubscribeFromEvents()
						DestroyPopupMenu()
					End If
				End If
			End Set
		End Property
		<XtraSerializableProperty(XtraSerializationVisibility.Collection, True)>
		Public ReadOnly Property GridFilters() As List(Of GridFitlerItem)
			Get
				Return filters
			End Get
		End Property
		Friend Function XtraCreateGridFiltersItem(ByVal e As XtraItemEventArgs) As GridFitlerItem
			Dim fItem As New GridFitlerItem()
			GridFilters.Add(fItem)
			Return fItem
		End Function
		Private Sub SubscribeToEvents()
			AddHandler view.MouseDown, AddressOf OnViewMouseDown
			AddHandler view.CustomFilterDisplayText, AddressOf OnViewCustomFilterDisplayText
		End Sub
		Private Sub OnViewCustomFilterDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs)
			Dim view As GridView = TryCast(sender, GridView)
			Dim filterString As String = e.Value.ToString()
			Dim fItem As GridFitlerItem = filters.FirstOrDefault(Function(it) it.FilterString = filterString)
			If fItem IsNot Nothing Then
				e.Value = fItem.FilterName
				e.Handled = True
			End If
		End Sub
		Private Sub OnViewMouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
			Dim view As GridView = TryCast(sender, GridView)
			Dim hitInfo As GridHitInfo = view.CalcHitInfo(e.Location)
			If e.Button = MouseButtons.Right AndAlso hitInfo.HitTest = GridHitTest.FilterPanelText Then
				CType(menu, IDXDropDownControl).Show(New SkinMenuManager(view.GridControl.LookAndFeel), view.GridControl, e.Location)
			End If
		End Sub
		Private Sub CreatePopupMenu()
			menu = New DXPopupMenu()
			menu.Items.Add(New DXMenuItem("Save Filter As", AddressOf OnSaveItemClick))
		End Sub
		Private Sub OnSaveItemClick(ByVal sender As Object, ByVal e As EventArgs)
			Dim action As New FlyoutAction() With {
				.Caption = "Save Filter As",
				.Description = ""
			}
			Dim command1 As New FlyoutCommand() With {
				.Text = "Save",
				.Result = DialogResult.OK
			}
			Dim command2 As New FlyoutCommand() With {
				.Text = "Cancel",
				.Result = DialogResult.Cancel
			}
			action.Commands.Add(command1)
			action.Commands.Add(command2)
			Using filterNameEdit As New TextEdit()
				filterNameEdit.Width = 300
				If FlyoutDialog.Show(view.GridControl.FindForm(), action, filterNameEdit) = System.Windows.Forms.DialogResult.OK Then
					If String.IsNullOrEmpty(filterNameEdit.Text.Trim()) Then
						Return
					End If
					Dim fItem As GridFitlerItem = filters.FirstOrDefault(Function(it) it.FilterString = view.ActiveFilterString)
					If fItem Is Nothing Then
						filters.Add(New GridFitlerItem() With {
							.FilterString = view.ActiveFilterString,
							.FilterName = filterNameEdit.Text
						})
					Else
						fItem.FilterName = filterNameEdit.Text
					End If
					view.LayoutChanged()
				End If
			End Using
		End Sub
		Private Sub UnsubscribeFromEvents()
			RemoveHandler view.MouseDown, AddressOf OnViewMouseDown
			RemoveHandler view.CustomFilterDisplayText, AddressOf OnViewCustomFilterDisplayText
		End Sub
		Private Sub DestroyPopupMenu()
			menu.Dispose()
			menu = Nothing
		End Sub
	End Class
	Public Class GridFitlerItem
		Public Sub New()
		End Sub
		<XtraSerializableProperty>
		Public Property FilterString() As String
		<XtraSerializableProperty>
		Public Property FilterName() As String
	End Class
	Public Module Extensions
		<System.Runtime.CompilerServices.Extension> _
		Public Sub SaveLayoutToXmlEx(ByVal view As ColumnView, ByVal provider As FilterNameProvider, ByVal filePath As String)
			Dim serializer As New XmlXtraSerializer()
			serializer.SerializeObjects(New XtraObjectInfo() {
				New XtraObjectInfo("View", view),
				New XtraObjectInfo("Filters", provider)
			}, filePath, "DXSample")
		End Sub
		<System.Runtime.CompilerServices.Extension> _
		Public Sub RestoreLayoutFromXmlEx(ByVal view As ColumnView, ByVal provider As FilterNameProvider, ByVal filePath As String)
			Dim serializer As New XmlXtraSerializer()
			serializer.DeserializeObjects(New XtraObjectInfo() {
				New XtraObjectInfo("View", view),
				New XtraObjectInfo("Filters", provider)
			}, filePath, "DXSample")
		End Sub
	End Module
End Namespace
