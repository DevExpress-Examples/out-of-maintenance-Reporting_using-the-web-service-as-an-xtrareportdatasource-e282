using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            localhost.Service s = new WindowsApplication1.localhost.Service();
            XtraReport1 rep = new XtraReport1();
            rep.DataSource = s.FillDS();
            rep.ShowPreviewDialog();
        }
    }
}