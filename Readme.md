<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631455/15.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T329217)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Record.cs](./CS/WindowsApplication3/Data/Record.cs) (VB: [Record.vb](./VB/WindowsApplication3/Data/Record.vb))
* [FilterNameProvider.cs](./CS/WindowsApplication3/FilterNameProvider.cs) (VB: [FilterNameProvider.vb](./VB/WindowsApplication3/FilterNameProvider.vb))
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
<!-- default file list end -->
# How to set custom names for grid filters and save/restore these names with a grid layout


<p>When an end-users applies any filter to a grid, this filter is shown in the <a href="https://documentation.devexpress.com/#WindowsForms/CustomDocument1424">Filter Panel</a>. When the <a href="https://documentation.devexpress.com/WindowsForms/DevExpressXtraGridViewsBaseColumnViewOptionsFilter_AllowMRUFilterListtopic.aspx">AllowMRUFilterList</a> property is set to <strong>true</strong>, recently used filters can be accessed via the View's <a href="https://documentation.devexpress.com/WindowsForms/CustomDocument1448.aspx">MRU Filter List</a>. It is a convenient way to access previous filters. Since filters can contain multiple filter conditions, it is not always comfortable to search for a necessary filter in the <strong>MRU Filter List</strong>. This example illustrates how to provide an end-user with the capability to set custom short names for filters. This way, a custom filter name will be shown in the <strong>Filter Panel</strong> as well as in the <strong>MRU Filter List</strong>.<br><br></p>
<p>To implement this feature, we have created a custom <strong>FilterNameProvider</strong> class. Create this class object and pass your <strong>GridView</strong> to its constructor. Once it is done, set the <strong>FilterNameProvider.AllowSettingFilterNames</strong> property to true to enable this functionality.<br><br></p>
<p>Now, when you right-click a filter text in the <strong>Filter Panel</strong>, a context menu will be shown. Click the <strong>Save Filter As</strong> item to invoke <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraBarsDocking2010CustomizationFlyoutDialogtopic">FlyoutDialog</a>. In this <strong>FlyoutDialog</strong>, you can enter a custom filter name for the current filter shown in the <strong>Filter Panel</strong>.<br><br></p>
<p>So, your end-user can now assign custom short names for filters. However, this information will be lost once you save and restore a grid layout. To save custom filter names with the grid layout, we use the <strong>XmlXtraSerializer.SerializeObjects</strong> method. We pass the current <strong>GridView</strong> together with a <strong>FilterNameProvider</strong> object to this method. <strong>FilterNameProvider</strong> has the <strong>GridFilters </strong>property of the<strong> List<GridFitlerItem></strong> type, which is intended to be serialized. That is why this property is marked with the <strong>XtraSerializableProperty</strong> attribute. Note that properties of the <strong>GridFitlerItem</strong> class are also marked with this attribute.<br><br></p>
<p>To restore these filters, we use the <strong>XmlXtraSerializer.DeserializeObjects</strong> method. Since new <strong>GridFitlerItem</strong> objects will not be created automatically when this method is called, it is necessary to declare a special method at the <strong>FilterNameProvider</strong> class to allow you to create such objects manually. This method should have a name according to this pattern: “<strong>XtraCreate<PropertyName>Item</strong>”. That is why we call this method as <strong>XtraCreateGridFiltersItem</strong>. </p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-rename-grid-filters-save-restore-layout&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-rename-grid-filters-save-restore-layout&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
