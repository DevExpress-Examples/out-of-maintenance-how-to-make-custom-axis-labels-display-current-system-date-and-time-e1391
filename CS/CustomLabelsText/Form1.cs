using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace CustomLabelsText {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CustomAxisLabelCollection coll = ((XYDiagram)this.chartControl1.Diagram).AxisX.CustomLabels;
            coll[0].Name = DateTime.Today.DayOfWeek.ToString();
            coll[1].Name = DateTime.Today.AddDays(4).DayOfWeek.ToString();
        }

    }
}