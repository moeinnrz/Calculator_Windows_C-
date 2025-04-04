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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void btnNumberClickARAR(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (txtAmountAR.Text == "0")
            {
                txtAmountAR.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!txtAmountAR.Text.Contains("."))
                    txtAmountAR.Text = txtAmountAR.Text + tempButton.Text;
            }
            else
            {
                txtAmountAR.Text = txtAmountAR.Text + tempButton.Text;
            }
            treeView1.Visible = false;
        }

        private void btnConverARAR_Click(object sender, EventArgs e)
        {
            if (comFromAR.Text == "SElect Unit" || ComToAR.Text == "Select Unit")
            {
                MessageBox.Show("Please Select Unit Fo COnvertor");
            }
            else
            {

                //*******************************************************************************
                if (comFromAR.SelectedItem == "Square millimeters" && ComToAR.SelectedItem == "Square centimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.01);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square millimeters" && ComToAR.SelectedItem == "Square meters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000001);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square millimeters" && ComToAR.SelectedItem == "Hectars")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.0000000001);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square millimeters" && ComToAR.SelectedItem == "Square kilometers")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000000000001);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square millimeters" && ComToAR.SelectedItem == "Square inches")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.00155);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square millimeters" && ComToAR.SelectedItem == "Square feet")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000011);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square millimeters" && ComToAR.SelectedItem == "Square yards")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000001);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square millimeters" && ComToAR.SelectedItem == "Acres")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000000000247105);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square millimeters" && ComToAR.SelectedItem == "Square miles")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000000000000386);
                    txtOutPutAR = txtOutPutAR;
                }


                //square Cetimeters****************************************************************************************
                if (comFromAR.SelectedItem == "Square centimeters" && ComToAR.SelectedItem == "Square millimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 100);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square centimeters" && ComToAR.SelectedItem == "Square meters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.0001);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square centimeters" && ComToAR.SelectedItem == "Hectars")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.00000001);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square centimeters" && ComToAR.SelectedItem == "Square kilometers")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.0000000001);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square centimeters" && ComToAR.SelectedItem == "Square inches")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.155);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square centimeters" && ComToAR.SelectedItem == "Square feet")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.001076);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square centimeters" && ComToAR.SelectedItem == "Square yards")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.00012);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square centimeters" && ComToAR.SelectedItem == "Acres")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000000024710538);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square centimeters" && ComToAR.SelectedItem == "Square miles")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.00000000003861);
                    txtOutPutAR = txtOutPutAR;
                }


                //SquareMEters*******************************************************************************************
                if (comFromAR.SelectedItem == "Square meters" && ComToAR.SelectedItem == "Square millimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 1000000);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square meters" && ComToAR.SelectedItem == "Square centimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 10000);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square meters" && ComToAR.SelectedItem == "Hectars")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.0001);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square meters" && ComToAR.SelectedItem == "Square kilometers")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000001);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square meters" && ComToAR.SelectedItem == "Square inches")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 1550.003);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square meters" && ComToAR.SelectedItem == "Square feet")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 10.76391);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square meters" && ComToAR.SelectedItem == "Square yards")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 1.19599);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square meters" && ComToAR.SelectedItem == "Acres")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000247);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square meters" && ComToAR.SelectedItem == "Square miles")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000000386102159);
                    txtOutPutAR = txtOutPutAR;
                }


                //Hectars**************************************************************************************************
                if (comFromAR.SelectedItem == "Hectars" && ComToAR.SelectedItem == "Square millimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 10000000000);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Hectars" && ComToAR.SelectedItem == "Square centimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 100000000);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Hectars" && ComToAR.SelectedItem == "Square meters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 10000);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Hectars" && ComToAR.SelectedItem == "Square kilometers")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.01);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Hectars" && ComToAR.SelectedItem == "Square inches")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 15500031);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Hectars" && ComToAR.SelectedItem == "Square feet")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 107639.1);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Hectars" && ComToAR.SelectedItem == "Square yards")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 11959.9);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Hectars" && ComToAR.SelectedItem == "Acres")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 2.471054);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Hectars" && ComToAR.SelectedItem == "Square miles")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.003861);
                    txtOutPutAR = txtOutPutAR;
                }


                //SquareKilomerters *******************************************************************************
                if (comFromAR.SelectedItem == "Square kilometers" && ComToAR.SelectedItem == "Square millimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 1000000000000);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square kilometers" && ComToAR.SelectedItem == "Square centimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 10000000000);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square kilometers" && ComToAR.SelectedItem == "Square meters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 1000000);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square kilometers" && ComToAR.SelectedItem == "Hectars")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 100);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square kilometers" && ComToAR.SelectedItem == "Square inches")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 1550003100);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square kilometers" && ComToAR.SelectedItem == "Square feet")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 10763910);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square kilometers" && ComToAR.SelectedItem == "Square yards")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 1195990);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square kilometers" && ComToAR.SelectedItem == "Acres")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 247.1054);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square kilometers" && ComToAR.SelectedItem == "Square miles")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.386102);
                    txtOutPutAR = txtOutPutAR;
                }


                //Square Inches ********************************************************************************************

                if (comFromAR.SelectedItem == "Square inches" && ComToAR.SelectedItem == "Square millimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 645.16);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square inches" && ComToAR.SelectedItem == "Square centimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 6.4516);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square inches" && ComToAR.SelectedItem == "Square meters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000645);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square inches" && ComToAR.SelectedItem == "Hectars")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000000064516);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square inches" && ComToAR.SelectedItem == "Square kilometers")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.00000000064516);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square inches" && ComToAR.SelectedItem == "Square feet")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.006944);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square inches" && ComToAR.SelectedItem == "Square yards")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000772);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square inches" && ComToAR.SelectedItem == "Acres")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000000159422508);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square inches" && ComToAR.SelectedItem == "Square miles")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000000000249098);
                    txtOutPutAR = txtOutPutAR;
                }

                // Square Feet***********************************************************************************************

                if (comFromAR.SelectedItem == "Square feet" && ComToAR.SelectedItem == "Square millimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 92903.04);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square feet" && ComToAR.SelectedItem == "Square centimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 929.0304);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square feet" && ComToAR.SelectedItem == "Square meters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.092903);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square feet" && ComToAR.SelectedItem == "Hectars")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000009);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square feet" && ComToAR.SelectedItem == "Square kilometers")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.00000009290304);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square feet" && ComToAR.SelectedItem == "Square inches")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 144);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square feet" && ComToAR.SelectedItem == "Square yards")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.111111);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square feet" && ComToAR.SelectedItem == "Acres")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000023);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square feet" && ComToAR.SelectedItem == "Square miles")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000000035870064);
                    txtOutPutAR = txtOutPutAR;
                }


                //Square Yards********************************************************************************************

                if (comFromAR.SelectedItem == "Square yards" && ComToAR.SelectedItem == "Square millimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 836127.4);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square yards" && ComToAR.SelectedItem == "Square centimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 8361.274);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square yards" && ComToAR.SelectedItem == "Square meters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.836127);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square yards" && ComToAR.SelectedItem == "Hectars")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000084);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square yards" && ComToAR.SelectedItem == "Square kilometers")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.00000083612736);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square yards" && ComToAR.SelectedItem == "Square inches")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 1296);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square yards" && ComToAR.SelectedItem == "Square feet")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 9);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square yards" && ComToAR.SelectedItem == "Acres")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000207);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square yards" && ComToAR.SelectedItem == "Square miles")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.000000322830579);
                    txtOutPutAR = txtOutPutAR;
                }


                //Arces**************************** ************************************************************************
                if (comFromAR.SelectedItem == "Acres" && ComToAR.SelectedItem == "Square millimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 4046856422);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Acres" && ComToAR.SelectedItem == "Square centimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 40468564);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Acres" && ComToAR.SelectedItem == "Square meters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 4046.856);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Acres" && ComToAR.SelectedItem == "Hectars")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.404686);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Acres" && ComToAR.SelectedItem == "Square kilometers")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.004047);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Acres" && ComToAR.SelectedItem == "Square inches")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 6272640);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Acres" && ComToAR.SelectedItem == "Square feet")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 43560);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Acres" && ComToAR.SelectedItem == "Square yards")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 4840);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Acres" && ComToAR.SelectedItem == "Square miles")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 0.001563);
                    txtOutPutAR = txtOutPutAR;
                }


                // Square Miles *************************************************************************************
                if (comFromAR.SelectedItem == "Square miles" && ComToAR.SelectedItem == "Square millimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 2589988110336);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square miles" && ComToAR.SelectedItem == "Square centimeters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 25899881103);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square miles" && ComToAR.SelectedItem == "Square meters")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 2589988);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square miles" && ComToAR.SelectedItem == "Hectars")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 258.9988);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square miles" && ComToAR.SelectedItem == "Square kilometers")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 2.589988);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square miles" && ComToAR.SelectedItem == "Square inches")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 4014489600);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square miles" && ComToAR.SelectedItem == "Square feet")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 27878400);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square miles" && ComToAR.SelectedItem == "Square yards")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 3097600);
                    txtOutPutAR = txtOutPutAR;
                }
                if (comFromAR.SelectedItem == "Square miles" && ComToAR.SelectedItem == "Acres")
                {
                    txtOutPutAR.Text = Convert.ToString(Convert.ToDouble(txtAmountAR.Text) * 640);
                    txtOutPutAR = txtOutPutAR;
                }
            }
        }

        private void btnStandardToARaR_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void btnPMvoAR_Click(object sender, EventArgs e)
        {
            if (txtAmountAR.Text.Contains("-"))
            {
                txtAmountAR.Text = txtAmountAR.Text.Remove(0, 1);
            }
            else
            {
                txtAmountAR.Text = txtAmountAR.Text + "-";
            }
        }

        private void btnCEvoAR_Click(object sender, EventArgs e)
        {

            txtAmountAR.Text = "0";
            txtOutPutAR.Text = "0";
        }

        private void btnBackSpaceAR_Click(object sender, EventArgs e)
        {
            if (txtAmountAR.Text.Length > 0)
            {
                txtAmountAR.Text.Remove(txtAmountAR.Text.Length - 1, 1);
            }

            if (txtAmountAR.Text == "")
            {
                txtAmountAR.Text = "0";
            }
        }

        private void Area_Load(object sender, EventArgs e)
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
