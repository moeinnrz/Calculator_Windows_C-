using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ماشین_حسابی
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (comFrom.Text=="SElect Unit"|| ComTO.Text=="Select Unit")
            {
                MessageBox.Show("Please Select Unit Fo COnvertor");
            }
            else
            {
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Meters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1000);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Centimeters")
                {
                    LblOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 100000);
                }
            }
        }
    }
}
