using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace GUI
{
    public partial class PhieuThu : DevExpress.XtraReports.UI.XtraReport
    {
        public PhieuThu()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, CancelEventArgs e)
        {
            DetailReportBand detailReport = sender as DetailReportBand;
            detailReport.ReportPrintOptions.PrintOnEmptyDataSource = false;
        }
    }
}