Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraEditors
Imports DXSample.Data

Namespace DXSample
    Partial Public Class Main
        Inherits XtraForm

        Private provider As FilterNameProvider
        Public Sub New()
            InitializeComponent()
            recordBindingSource.DataSource = DataHelper.GetData(10)
            provider = New FilterNameProvider(gridView1) With {.AllowSettingFilterNames = True}
        End Sub
        Private filePath As String = "Layout.xml"
        Private Sub OnSaveLayoutButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem4.ItemClick
            gridView1.SaveLayoutToXmlEx(provider, filePath)
        End Sub

        Private Sub OnRestoreLayoutButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem5.ItemClick
            gridView1.RestoreLayoutFromXmlEx(provider, filePath)
        End Sub
    End Class
End Namespace
