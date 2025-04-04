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
    public partial class Volume : Form
    {
        public Volume()
        {
            InitializeComponent();
        }

        private void btnNumberVoVO(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (txtAmountVO.Text == "0")
            {
                txtAmountVO.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!txtAmountVO.Text.Contains("."))
                    txtAmountVO.Text = txtAmountVO.Text + tempButton.Text;
            }
            else
            {
                txtAmountVO.Text = txtAmountVO.Text + tempButton.Text;
            }
            treeView1.Visible = false;
        }

        private void btnCEvoVO_Click(object sender, EventArgs e)
        {
            txtAmountVO.Text = "0";
            txtOutPutVO.Text = "0";
        }

        private void btnBackSpaceVo_Click(object sender, EventArgs e)
        {
            if (txtAmountVO.Text.Length > 0)
            {
                txtAmountVO.Text.Remove(txtAmountVO.Text.Length - 1, 1);
            }

            if (txtAmountVO.Text == "")
            {
                txtAmountVO.Text = "0";
            }
        }

        private void btnConverVOvo_Click(object sender, EventArgs e)
        {
            if (comFromVO.Text == "SElect Unit" || ComToVO.Text == "Select Unit")
            {
                MessageBox.Show("Please Select Unit Fo COnvertor");
            }
            else
            {

                //MilliLiters*******************************************************************************
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000001);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.202884);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.067628);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.033814);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.004227);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.002113);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001057);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000264);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.061024);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000035);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000001);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4.996045);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.665348);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.040843);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.00176);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.00088);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Milliliters" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.00022);
                    txtOutPutVO = txtOutPutVO;
                }

                //Cubic CEntimeters ************************************************************************************
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000001);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.202884);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.067628);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.033814);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.004227);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.002113);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001057);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000264);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.061024);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000035);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000001);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.002113);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.056312);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.035195);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.00176);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.00088);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Centimeters" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.00022);
                    txtOutPutVO = txtOutPutVO;
                }



                //Liters ********************************************************************************************
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1000);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1000);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 202.8841);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 67.62805);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 33.81402);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4.226753);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 2.113376);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.056688);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.264172);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 61.02374);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.035315);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001308);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 168.9364);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 56.31213);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 35.19508);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.759754);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.879877);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Liters" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.219969);
                    txtOutPutVO = txtOutPutVO;
                }



                //Cubic Meters ********************************************************************************
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1000000);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1000000);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1000);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 202884.1);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 67628.05);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 33814.02);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4226.753);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 2113.376);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1056.688);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 264.1721);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 61023.74);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 35.31467);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.307951);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 168936.4);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 56312.13);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 35195.08);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1759.754);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 879.877);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Meters" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 219.9692);
                    txtOutPutVO = txtOutPutVO;
                }

                //Teaspoons ****************************************************************************
                if (comFromVO.SelectedItem == "Teaspoons (US)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4.928922);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4.928922);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.004929);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000005);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.333333);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.166667);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.020833);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.010417);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.005208);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001302);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.300781);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000174);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000006);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.832674);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.277558);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.173474);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.008674);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.004337);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (US) " && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001084);
                    txtOutPutVO = txtOutPutVO;
                }




                //Tablespoons **********************************************************************************
                if (comFromVO.SelectedItem == "Tablespoons (US)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 14.78676);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 14.78676);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.014787);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000015);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 3);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.5);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.0625);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.03125);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.015625);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.003906);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.902344);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000522);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000019);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 2.498023);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.832674);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.026021);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.026021);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.013011);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (US) " && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.003253);
                    txtOutPutVO = txtOutPutVO;
                }



                //Fluid Ounces *****************************************************************************************************
                if (comFromVO.SelectedItem == "Fluid Ounces (US)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 29.57353);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 29.57353);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.029574);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.00003);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 6);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 2);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.125);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.0625);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.03125);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.007812);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.804688);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001044);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000039);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4.996045);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.665348);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.040843);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.052042);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.026021);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (US) " && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.006505);
                    txtOutPutVO = txtOutPutVO;
                }


                //Cups (US) **********************************************************************************************
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 236.5882);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 236.5882);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.236588);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000237);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 48);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 16);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 8);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.5);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.25);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.0625);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 14.4375);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.008355);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000309);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 39.96836);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 13.32279);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 8.326742);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.416337);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.208169);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cups (US)" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.052042);
                    txtOutPutVO = txtOutPutVO;
                }


                //Pints ********US******************************************************************************
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 473.1765);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 473.1765);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.473176);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000473);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 96);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 32);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 16);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 2);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.5);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.125);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 28.875);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.01671);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000619);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 79.93672);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 26.64557);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 16.65348);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.832674);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.416337);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (US)" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.104084);
                    txtOutPutVO = txtOutPutVO;
                }


                //Quarts************************************************************************************************
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 946.3529);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 946.3529);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.946353);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000946);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 192);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 64);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 32);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 2);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.25);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 57.75);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.03342);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001238);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 159.8734);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 53.29115);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 33.30697);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.665348);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.832674);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (US)" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.208169);
                    txtOutPutVO = txtOutPutVO;
                }


                //Galons***********US*****************************************************************************
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 3785.412);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 3785.412);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 3.785412);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.003785);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 768);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 256);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 128);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 16);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 8);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 231);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.133681);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.004951);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 639.4938);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 213.1646);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 133.2279);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 6.661393);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 3.330697);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (US)" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.832674);
                    txtOutPutVO = txtOutPutVO;
                }


                //?Cubic inc\hes *****************************************************************************************
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 16.38706);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 16.38706);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.016387);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000016);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 3.324675);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.108225);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.554113);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.069264);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.034632);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.017316);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.004329);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000579);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000021);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 2.768371);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.92279);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.576744);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.028837);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.014419);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Inches" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.003605);
                    txtOutPutVO = txtOutPutVO;
                }


                //Cubic Feet*****************************************************************************************
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 28316.85);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 28316.85);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 28.31685);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.028317);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 5745.039);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1915.013);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 957.5065);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 119.6883);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 59.84416);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 29.92208);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 7.480519);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1728);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.037037);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4783.746);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1594.582);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 996.6137);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 49.83068);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 24.91534);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Feet" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 6.228835);
                    txtOutPutVO = txtOutPutVO;
                }



                //Cubic Yards ************************************************************************************
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 764554.9);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 764554.9);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 764.5549);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.764555);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 155116.1);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 51705.35);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 25852.68);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 3231.584);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1615.792);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 807.8961);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 201.974);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 46656);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 27);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 129161.1);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 43053.71);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 26908.57);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1345.428);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 672.7142);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Cubic Yards" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 168.1786);
                    txtOutPutVO = txtOutPutVO;
                }


                //Teaspoons*******************************************************************************************
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 5.919388);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 5.919388);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.005919);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000006);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.20095);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.400317);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.200158);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.02502);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.01251);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.006255);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001564);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.361223);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000209);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000008);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.333333);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.208333);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.010417);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.005208);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Teaspoons (UK)" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001302);
                    txtOutPutVO = txtOutPutVO;
                }


                //Tablespoons ************************************************************************************
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 17.75816);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 17.75816);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.017758);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000018);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 3.60285);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.20095);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.600475);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.075059);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.03753);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.018765);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.004691);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.08367);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000627);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000023);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 3);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.625);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.03125);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.015625);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Tablespoons (UK)" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.003906);
                    txtOutPutVO = txtOutPutVO;
                }


                //Fluid Ounces */************************************************************************************
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 28.41306);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 28.41306);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.028413);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000028);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 5.76456);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.92152);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.96076);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.120095);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.060047);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.030024);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.007506);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.733871);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001003);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000037);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4.8);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.6);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.05);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.025);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Fluid Ounces (UK)" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.00625);
                    txtOutPutVO = txtOutPutVO;
                }



                //Pints*********************************************************************************************
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 568.2613);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 568.2613);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.568261);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000568);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 115.2912);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 38.4304);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 19.2152);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 2.4019);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.20095);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.600475);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.150119);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 34.67743);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.020068);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.000743);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 96);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 32);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 20);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.5);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Pints (UK)" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.125);
                    txtOutPutVO = txtOutPutVO;
                }


                //Quars *****************************************************************************
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1136.523);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1136.523);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.136523);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001137);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 230.5824);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 76.8608);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 38.4304);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4.8038);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 2.4019);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.20095);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.300237);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 69.35486);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.040136);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.001487);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 192);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 64);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 40);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 2);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Quarts (UK)" && ComToVO.SelectedItem == "Gallons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.25);
                    txtOutPutVO = txtOutPutVO;
                }


                //Galons*****************************************************************************************
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Milliliters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4546.09);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Cubic Centimeters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4546.09);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Liters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4.54609);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Cubic Meters")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.004546);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Teaspoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 922.3295);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Tablespoons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 307.4432);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Fluid Ounces (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 153.7216);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Cups (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 19.2152);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Pints (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 9.607599);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Quarts (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4.8038);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Gallons (US)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 1.20095);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Cubic Inches")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 277.4194);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Cubic Feet")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.160544);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Cubic Yards")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 0.005946);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Teaspoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 768);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Tablespoons (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 256);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Fluid Ounces (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 160);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Pints (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 8);
                    txtOutPutVO = txtOutPutVO;
                }
                if (comFromVO.SelectedItem == "Gallons (UK)" && ComToVO.SelectedItem == "Quarts (UK)")
                {
                    txtOutPutVO.Text = Convert.ToString(Convert.ToDouble(txtAmountVO.Text) * 4);
                    txtOutPutVO = txtOutPutVO;
                }

            }
        }

        private void btnStandardToVovO_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void btnPMvoVo_Click(object sender, EventArgs e)
        {
            if (txtAmountVO.Text.Contains("-"))
            {
                txtAmountVO.Text = txtAmountVO.Text.Remove(0, 1);
            }
            else
            {
                txtAmountVO.Text = txtAmountVO.Text + "-";
            }
        }

        private void Volume_Load(object sender, EventArgs e)
        {
            treeView1.Visible = false;
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Node1")
            {
                lblTitle.Text = "Standard";
                treeView1.Visible = false;
                Form1 F1 = new Form1();
                F1.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node2")
            {
                lblTitle.Text = "Scientific";
                treeView1.Visible = false;
                Scientific scientific = new Scientific();
                scientific.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node3")
            {
                lblTitle.Text = "Programmer";
                treeView1.Visible = false;
                Programmer program = new Programmer();
                program.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node4")
            {
                lblTitle.Text = "Date Calculation";
                treeView1.Visible = false;
                Data_Calculation data = new Data_Calculation();
                data.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node6")
            {
                lblTitle.Text = "Currency";
                treeView1.Visible = false;
            }

            if (e.Node.Name == "Node7")
            {
                lblTitle.Text = "Volume";
                treeView1.Visible = false;
                Volume Vol = new Volume();
                Vol.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node8")
            {
                lblTitle.Text = "Length";
                treeView1.Visible = false;
                length leng = new length();
                leng.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node9")
            {
                lblTitle.Text = "Weight & Mass";
                treeView1.Visible = false;
                Weigh_Mass weigh = new Weigh_Mass();
                weigh.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node10")
            {
                lblTitle.Text = "Temperature";
                treeView1.Visible = false;
                Temperature temperature = new Temperature();
                temperature.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node11")
            {
                lblTitle.Text = "Energy";
                treeView1.Visible = false;
                Energy Ene = new Energy();
                Ene.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node12")
            {
                lblTitle.Text = "Area";
                treeView1.Visible = false;
                Area ARE = new Area();
                ARE.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node13")
            {
                lblTitle.Text = "Speed";
                treeView1.Visible = false;
                Spees SPe = new Spees();
                SPe.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node14")
            {
                lblTitle.Text = "Time";
                treeView1.Visible = false;
                Time TIM = new Time();
                TIM.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node15")
            {
                lblTitle.Text = "Power";
                treeView1.Visible = false;
                Power POW = new Power();
                POW.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node16")
            {
                lblTitle.Text = "date";
                treeView1.Visible = false;
                Data DAT = new Data();
                DAT.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node17")
            {
                lblTitle.Text = "Pressure";
                treeView1.Visible = false;
                Pressure PRE = new Pressure();
                PRE.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node18")
            {
                lblTitle.Text = "Angle";
                treeView1.Visible = false;
                Angle ANG = new Angle();
                ANG.Show();
                this.Hide();
            }

            if (e.Node.Name == "Node20")
            {
                lblTitle.Text = "About";
                treeView1.Visible = false;
                About about = new About();
                about.Show();
                this.Hide();
            }
        }
    }
}
