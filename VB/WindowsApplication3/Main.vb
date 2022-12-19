Imports DevExpress.XtraEditors
Imports DXSample.Data

Namespace DXSample

    Public Partial Class Main
        Inherits XtraForm

        Private provider As FilterNameProvider

        Public Sub New()
            InitializeComponent()
            gridView1.OptionsView.FilterCriteriaDisplayStyle = FilterCriteriaDisplayStyle.Text
            recordBindingSource.DataSource = DataHelper.GetData(10)
            provider = New FilterNameProvider(gridView1) With {.AllowSettingFilterNames = True}
        End Sub

        Private filePath As String = "Layout.xml"

        Private Sub OnSaveLayoutButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            gridView1.SaveLayoutToXmlEx(provider, filePath)
        End Sub

        Private Sub OnRestoreLayoutButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            gridView1.RestoreLayoutFromXmlEx(provider, filePath)
        End Sub
    End Class
End Namespace
