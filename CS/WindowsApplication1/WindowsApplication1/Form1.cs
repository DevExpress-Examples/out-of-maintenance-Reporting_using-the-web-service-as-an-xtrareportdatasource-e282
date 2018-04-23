using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void chartControl1_ObjectHotTracked(object sender, DevExpress.XtraCharts.HotTrackEventArgs e) {
         
        }
        SeriesPoint selectedSeriesPoint;
        private void chartControl1_ObjectSelected(object sender, DevExpress.XtraCharts.HotTrackEventArgs e) {
            if(e.HitInfo.SeriesPoint != null) {
                if(selectedSeriesPoint != e.HitInfo.SeriesPoint) {
                    selectedSeriesPoint = e.HitInfo.SeriesPoint;
                    this.chartControl1.Refresh();
                }
            }
        }
        private void chartControl1_CustomDrawSeriesPoint(object sender, DevExpress.XtraCharts.CustomDrawSeriesPointEventArgs e) {
            if(e.SeriesPoint == selectedSeriesPoint) {
                e.SeriesDrawOptions.Color = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            selectedSeriesPoint = null;
        }
    }
}