using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DXSample.Data;

namespace DXSample {
    public partial class Main : XtraForm {
        FilterNameProvider provider;
        public Main() {
            InitializeComponent();
            recordBindingSource.DataSource = DataHelper.GetData(10);
            provider = new FilterNameProvider(gridView1) { AllowSettingFilterNames = true };
        }
        string filePath = "Layout.xml";
        private void OnSaveLayoutButtonClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gridView1.SaveLayoutToXmlEx(provider, filePath);
        }

        private void OnRestoreLayoutButtonClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            gridView1.RestoreLayoutFromXmlEx(provider, filePath);
        }
    }
}
