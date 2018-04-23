using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Serializing;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace DXSample {
    public class FilterNameProvider {
        List<GridFitlerItem> filters;
        DXPopupMenu menu;
        GridView view;
        public FilterNameProvider(GridView view) {
            this.view = view;
            view.OptionsLayout.StoreDataSettings = true;
            filters = new List<GridFitlerItem>();
        }
        bool fAllowSettingFilterNames;
        public bool AllowSettingFilterNames {
            get {
                return fAllowSettingFilterNames;
            }
            set {
                if (fAllowSettingFilterNames != value) {
                    fAllowSettingFilterNames = value;
                    if (fAllowSettingFilterNames) {
                        SubscribeToEvents();
                        CreatePopupMenu();
                    }
                    else {
                        UnsubscribeFromEvents();
                        DestroyPopupMenu();
                    }
                }
            }
        }
        [XtraSerializableProperty(XtraSerializationVisibility.Collection, true)]
        public List<GridFitlerItem> GridFilters {
            get { return filters; }
        }
        internal GridFitlerItem XtraCreateGridFiltersItem(XtraItemEventArgs e) {
            GridFitlerItem fItem = new GridFitlerItem();
            GridFilters.Add(fItem);
            return fItem;
        }
        void SubscribeToEvents() {
            view.MouseDown += OnViewMouseDown;
            view.CustomFilterDisplayText += OnViewCustomFilterDisplayText;
        }
        void OnViewCustomFilterDisplayText(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e) {
            GridView view = sender as GridView;
            string filterString = e.Value.ToString();
            GridFitlerItem fItem = filters.FirstOrDefault(it => it.FilterString == filterString);
            if(fItem != null){
                e.Value = fItem.FilterName;
                e.Handled = true;
            }
        }
        void OnViewMouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            GridView view = sender as GridView;
            GridHitInfo hitInfo = view.CalcHitInfo(e.Location);
            if (e.Button == MouseButtons.Right && hitInfo.HitTest == GridHitTest.FilterPanelText) {
                ((IDXDropDownControl)menu).Show(new SkinMenuManager(view.GridControl.LookAndFeel), view.GridControl, e.Location);
            }
        }
        void CreatePopupMenu() {
            menu = new DXPopupMenu();
            menu.Items.Add(new DXMenuItem("Save Filter As", OnSaveItemClick));
        }
        void OnSaveItemClick(object sender, EventArgs e) {
            FlyoutAction action = new FlyoutAction() { Caption = "Save Filter As", Description = "" };
            FlyoutCommand command1 = new FlyoutCommand() { Text = "Save", Result = DialogResult.OK };
            FlyoutCommand command2 = new FlyoutCommand() { Text = "Cancel", Result = DialogResult.Cancel };
            action.Commands.Add(command1);
            action.Commands.Add(command2);
            using (TextEdit filterNameEdit = new TextEdit()) {
                filterNameEdit.Width = 300;
                if (FlyoutDialog.Show(view.GridControl.FindForm(), action, filterNameEdit) == System.Windows.Forms.DialogResult.OK) {
                    if (string.IsNullOrEmpty(filterNameEdit.Text.Trim())) return;
                    GridFitlerItem fItem = filters.FirstOrDefault(it => it.FilterString == view.ActiveFilterString);
                    if (fItem == null)
                        filters.Add(new GridFitlerItem() { FilterString = view.ActiveFilterString, FilterName = filterNameEdit.Text });
                    else
                        fItem.FilterName = filterNameEdit.Text;
                }
            }
        }
        void UnsubscribeFromEvents() {
            view.MouseDown -= OnViewMouseDown;
            view.CustomFilterDisplayText -= OnViewCustomFilterDisplayText;
        }
        void DestroyPopupMenu() {
            menu.Dispose();
            menu = null;
        }
    }
    public class GridFitlerItem {
        public GridFitlerItem() { }
        [XtraSerializableProperty]
        public string FilterString { get; set; }
        [XtraSerializableProperty]
        public string FilterName { get; set; }
    }
    public static class Extensions {
        public static void SaveLayoutToXmlEx(this ColumnView view, FilterNameProvider provider, string filePath) {
            XmlXtraSerializer serializer = new XmlXtraSerializer();
            serializer.SerializeObjects(new XtraObjectInfo[] {new XtraObjectInfo("View", view), new XtraObjectInfo("Filters", provider) }, filePath, "DXSample");
        }
        public static void RestoreLayoutFromXmlEx(this ColumnView view, FilterNameProvider provider, string filePath) {
            XmlXtraSerializer serializer = new XmlXtraSerializer();
            serializer.DeserializeObjects(new XtraObjectInfo[] { new XtraObjectInfo("View", view), new XtraObjectInfo("Filters", provider) }, filePath, "DXSample");
        }
    }
}
