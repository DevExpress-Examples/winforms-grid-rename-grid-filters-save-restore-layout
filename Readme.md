<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631455/21.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T329217)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Rename grid filters and serialize custom names

When a end users applies a filter to a grid, the filter is shown within the [Filter Panel](https://docs.devexpress.com/WindowsForms/1424/controls-and-libraries/data-grid/visual-elements/view-common-elements/filter-panel). If the [AllowMRUFilterList](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnViewOptionsFilter.AllowMRUFilterList) option is enabled, the user can access [recently used filters](https://docs.devexpress.com/WindowsForms/1448/controls-and-libraries/data-grid/visual-elements/view-common-elements/views-mru-(most-recently-used)-filter-list) and apply them.

This example shows how to allow the user to rename filters as needed:

![Rename grid filters and serialize custom names](https://raw.githubusercontent.com/DevExpress-Examples/how-to-set-custom-names-for-grid-filters-and-save-restore-these-names-with-a-grid-layout-t329217/21.1.3%2B/media/winforms-grid-custom-filter-names.gif)

```csharp
public partial class Main : XtraForm {
    FilterNameProvider provider;
    public Main() {
        InitializeComponent();
        gridView1.OptionsView.FilterCriteriaDisplayStyle = FilterCriteriaDisplayStyle.Text;
        recordBindingSource.DataSource = DataHelper.GetData(10);
        provider = new FilterNameProvider(gridView1) { AllowSettingFilterNames = true };
    }
}
```

The `FilterNameProvider.GridFilters` property is marked with the `XtraSerializableProperty` attribute. The following code serializes custom filter names with the grid layout:

```csharp
void OnSaveLayoutButtonClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
    gridView1.SaveLayoutToXmlEx(provider, filePath);
}
```

The following code deserializes (restores) grid filters:

```csharp
void OnRestoreLayoutButtonClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
    gridView1.RestoreLayoutFromXmlEx(provider, filePath);
}
```

`GridFitlerItem` objects are not created automaticall. You should declare a special method in the `FilterNameProvider` class that creates such objects. Name this method according to the following pattern: "XtraCreate<PropertyName>Item". In this example, this is the `XtraCreateGridFiltersItem` method:

```csharp
internal GridFitlerItem XtraCreateGridFiltersItem(XtraItemEventArgs e) {
    GridFitlerItem fItem = new GridFitlerItem();
    GridFilters.Add(fItem);
    return fItem;
}
```


## Files to Review

* [FilterNameProvider.cs](./CS/WindowsApplication3/FilterNameProvider.cs) (VB: [FilterNameProvider.vb](./VB/WindowsApplication3/FilterNameProvider.vb))
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))


## Documentation

* [CustomFilterDisplayText Event](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnView.CustomFilterDisplayText)
* [Save and Restore Grid Layout](https://docs.devexpress.com/WindowsForms/772/controls-and-libraries/data-grid/save-and-restore-layout)
