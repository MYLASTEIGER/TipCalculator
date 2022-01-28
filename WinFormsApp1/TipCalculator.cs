using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1 {
    public partial class TipCalculator : Form {
        public TipCalculator() {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e) {
            var billAmount = Convert.ToDecimal(txtBillAmount.Text);

            var tipPercent =.2m;
            txtTipPercent.Text = tipPercent.ToString("p0");

            var tipAmount = billAmount * tipPercent;
            txtTotalTipAmount.Text = tipAmount.ToString("c");
        }
    }
}
