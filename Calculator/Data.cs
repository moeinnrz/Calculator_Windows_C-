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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void btnCEpDAT_Click(object sender, EventArgs e)
        {
            txtAmountDAT.Text = "0";
            txtOutPutDAT.Text = "0";
        }

        private void btnBackSpaceDAT_Click(object sender, EventArgs e)
        {
            if (txtAmountDAT.Text.Length > 0)
            {
                txtAmountDAT.Text.Remove(txtAmountDAT.Text.Length - 1, 1);
            }

            if (txtAmountDAT.Text == "")
            {
                txtAmountDAT.Text = "0";
            }
        }

        private void btnPMaAT_Click(object sender, EventArgs e)
        {
            if (txtAmountDAT.Text.Contains("-"))
            {
                txtAmountDAT.Text = txtAmountDAT.Text.Remove(0, 1);
            }
            else
            {
                txtAmountDAT.Text = txtAmountDAT.Text + "-";
            }
        }

        private void btnConvertDAT_Click(object sender, EventArgs e)
        {
            if (comFromDAT.Text == "SElect Unit" || ComToDAT.Text == "Select Unit")
            {
                MessageBox.Show("Please Select Unit Fo COnvertor");
            }
            else
            {

                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000122);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00000011920929);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000116415);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000909);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000114);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.881784e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.110223e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.673617e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.084202e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.470329e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.058791e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-24);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.271806e-25);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e-25);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.033976e-25);
                    txtOutPutDAT = txtOutPutDAT;
                }






                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007812);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000007450581);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000007276);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000909);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.105427e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.881784e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.938894e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.938894e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.673617e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.776264e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.470329e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e-24);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.617445e-24);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-24);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Bytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.271806e-25);
                    txtOutPutDAT = txtOutPutDAT;
                }






                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.976563);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.12207);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000954);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000119);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000931322575);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000116415322);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000909495);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000113687);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000888);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000111);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.673617e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.084202e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.470329e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.058791e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.271806e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.033976e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }







                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000122);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00000011920929);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000116415);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000909);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000114);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.024000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.881784e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.280000e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.110223e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.024000e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.673617e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.280000e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.084202e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.024000e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.470329e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.280000e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilbibits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.058791e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }








                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.8125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.976563);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007629);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000954);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000007);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000931322575);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000007275958);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000909495);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000007105);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000888);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.938894e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.673617e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.776264e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.470329e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.617445e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kilobytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.271806e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }







                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.024);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.008192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007812);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000008192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000007450581);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000008192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000007276);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000909);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.192000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.105427e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.024000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.881784e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.192000e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.938894e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.024000e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.673617e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.192000e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.776264e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.024000e-21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Kibibytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.470329e-22);
                    txtOutPutDAT = txtOutPutDAT;
                }










                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 976.5625);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 122.0703);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.953674);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.119209);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000931);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000116);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000909494702);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000113686838);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000888178);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000111022);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000867);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000108);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.470329e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.058791e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.271806e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.033976e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }






                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 131072);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048.576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 131.072);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.131072);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001049);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000131);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000122);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000131072);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00000011920929);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000131072);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000116415);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001049);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000909);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000131);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000114);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.048576e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.881784e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.310720e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.110223e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.048576e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.673617e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.310720e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.084202e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }









                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7812.5);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 976.5625);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.629395);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.953674);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007451);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000931);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000007);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000909494702);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000007105427);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000888178);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000006939);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000867);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.776264e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.470329e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.617445e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Megabytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.271806e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }









                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8388608);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8388.608);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048.576);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.388608);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.048576);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.008389);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007812);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001049);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000008388608);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000007450581);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000008389);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000007276);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001049);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000909);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.388608e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.105427e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.048576e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.881784e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.388608e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.938894e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.048576e-18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Mebibytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.673617e-19);
                    txtOutPutDAT = txtOutPutDAT;
                }





                //*****************//////////**************************************////////////*********************************/**/*/*/*///*/*





                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 976562.5);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 122070.3);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 953.6743);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 119.2093);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.931323);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.116415);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000909);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000114);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00000088817842);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000111022302);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000867362);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00000000010842);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000847);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000106);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.271806e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.033976e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }







                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073741824);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 134217728);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073742);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 134217.7);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 131072);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073.742);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 134.2177);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.073742);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.134218);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001074);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000134);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000122);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000134217728);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00000011920929);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001073742);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000134218);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000116415);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001074);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000909);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000134);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000114);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.073742e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.881784e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.342177e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.110223e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }







                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7812500);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 976562.5);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7629.395);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 953.6743);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.450581);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.931323);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007276);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000909);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000007);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00000088817842);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000006938894);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000867362);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000006776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000847);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.617445e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gigabytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.271806e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }








                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8589934592);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073741824);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8589935);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8388608);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 976562.5);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8589.935);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073.742);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.589935);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.073742);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00859);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007812);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001074);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000009);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000008589935);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000007450581);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001073742);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00000000000859);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000007276);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001074);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000909);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.589935e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.105427e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.073742e-15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Gibibytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.881784e-16);
                    txtOutPutDAT = txtOutPutDAT;
                }







                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 976562500);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 122070312);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 953674.3);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 119209.3);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 931.3226);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 116.4153);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.909495);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.113687);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000888);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000111);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000867361738);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000108420217);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000847033);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000105879);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000827);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000103);
                    txtOutPutDAT = txtOutPutDAT;
                }








                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511627776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 137438953472);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511628);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073741824);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 137438953);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 134217728);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099512);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 137439);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 131072);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099.512);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 137.439);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.099512);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.137439);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.0011);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000137);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000122);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000137438953);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00000011920929);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001099512);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000137439);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000116415);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.0000000000011);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000909);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000137);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000114);
                    txtOutPutDAT = txtOutPutDAT;
                }






                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7812500000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 976562500);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7629395);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 953674.3);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7450.581);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 931.3226);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.275958);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.909495);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007105);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000888);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000007);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000867361738);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000006776264);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000847033);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000006617);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Terabytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000827);
                    txtOutPutDAT = txtOutPutDAT;
                }






                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8796093022208);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511627776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8796093022);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8589934592);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511628);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073741824);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8796093);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8388608);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099512);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8796.093);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099.512);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.796093);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.099512);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.008796);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007812);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.0011);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000009);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000008796093);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000007450581);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001099512);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000008796);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000007276);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.0000000000011);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Tebibytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000000909);
                    txtOutPutDAT = txtOutPutDAT;
                }






                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 976562500000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 122070312500);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 119209290);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 931322.6);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 116415.3);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 909.4947);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 113.6868);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.888178);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.111022);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000867);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000108);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000847032947);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000105879118);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000827181);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000103398);
                    txtOutPutDAT = txtOutPutDAT;
                }









                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.125900e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 140737488355328);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1125899906843);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511627776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 140737488355);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 137438953472);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1125899907);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073741824);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 140737488);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 134217728);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1125900);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 140737.5);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 131072);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1125.9);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 140.7375);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.1259);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.140737);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001126);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000141);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000122);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000140737488);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00000011920929);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.0000000011259);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000140737);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000116415);
                    txtOutPutDAT = txtOutPutDAT;
                }









                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7812500000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 976562500000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7629394531);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7450581);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 931322.6);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7275.958);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 909.4947);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.105427);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.888178);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.006939);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000867);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000007);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000847032947);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000006617445);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Petabytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000827181);
                    txtOutPutDAT = txtOutPutDAT;
                }







                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.007199e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.125900e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9007199254741);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8796093022208);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1125899906843);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511627776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9007199255);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8589934592);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1125899907);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073741824);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9007199);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8388608);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1125900);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9007.199);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1125.9);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.007199);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.1259);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.009007);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007812);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001126);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000009);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000009007199);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000007450581);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.0000000011259);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Pebibytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000000931323);
                    txtOutPutDAT = txtOutPutDAT;
                }










                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 976562500000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 122070312500000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 953674316406);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 119209289551);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 931322575);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 116415322);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 909494.7);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 113686.8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 888.1784);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 111.0223);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.867362);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.10842);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000847);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000106);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000827180613);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000103397577);
                    txtOutPutDAT = txtOutPutDAT;
                }









                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.152922e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.441152e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.152922e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.125900e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 144115188075856);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 140737488355328);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1152921504607);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511627776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 144115188076);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 137438953472);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1152921505);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073741824);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 144115188);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 134217728);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1152922);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 144115.2);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 131072);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1152.922);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 144.1152);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.152922);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.144115);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001153);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000144);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000122);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000144115188);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.00000011920929);
                    txtOutPutDAT = txtOutPutDAT;
                }









                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.812500e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 976562500000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7629394531250);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 953674316406);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7450580597);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 931322575);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7275958);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 909494.7);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7105.427);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 888.1784);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.938894);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.867362);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.006776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000847);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000007);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exabytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000827180613);
                    txtOutPutDAT = txtOutPutDAT;
                }









                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.223372e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.152922e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.223372e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.007199e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.152922e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.125900e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9223372036855);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8796093022208);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1152921504607);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511627776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9223372037);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8589934592);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1152921505);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073741824);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9223372);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "ExabExbibytesytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8388608);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1152922);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9223.372);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1152.922);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.223372);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.152922);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.009223);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007812);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001153);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000009);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Exbibytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000000953674316);
                    txtOutPutDAT = txtOutPutDAT;
                }









                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e+20);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.765625e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.220703e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 953674316406250);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 119209289550781);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 931322574615);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 116415321827);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 909494702);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 113686838);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 888178.4);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 111022.3);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 867.3617);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 108.4202);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.847033);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.105879);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000827);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000103);
                    txtOutPutDAT = txtOutPutDAT;
                }









                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.180592e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.475740e+20);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.180592e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.152922e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.475740e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.441152e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.180592e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.125900e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 147573952589676);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 140737488355328);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1180591620717);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511627776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 147573952590);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 137438953472);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1180591621);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073741824);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 147573953);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 134217728);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1180592);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 147574);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 131072);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1180.592);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 147.574);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.180592);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.147574);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001181);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000148);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000122);
                    txtOutPutDAT = txtOutPutDAT;
                }










                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.812500e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.765625e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.629395e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 953674316406250);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7450580596924);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 931322574615);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7275957614);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 909494702);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7105427);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 888178.4);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6938.894);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 867.3617);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.776264);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.847033);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.008);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.006617);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zetabytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000827);
                    txtOutPutDAT = txtOutPutDAT;
                }










                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.444733e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.180592e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.444733e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.223372e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.180592e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.152922e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.444733e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.007199e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.180592e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.125900e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9444732965739);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8796093022208);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1180591620717);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511627776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9444732966);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8589934592);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1180591621);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073741824);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9444733);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8388608);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1180592);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9444.733);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1180.592);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.444733);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.180592);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.009445);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.007812);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.001181);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Zebibytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.000977);
                    txtOutPutDAT = txtOutPutDAT;
                }
















                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+24);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e+23);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.765625e+20);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e+20);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.220703e+20);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.536743e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.250000e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.192093e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 931322574615478);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 116415321826935);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 909494701773);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 113686837722);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 888178420);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 111022302);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 867361.7);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 108420.2);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 847.0329);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 105.8791);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.827181);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.103398);
                    txtOutPutDAT = txtOutPutDAT;
                }








                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.208926e+24);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.511157e+23);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.208926e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.180592e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.511157e+20);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.475740e+20);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.208926e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.152922e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.511157e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.441152e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.208926e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.125900e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 151115727451829);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 140737488355328);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1208925819615);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511627776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 125000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 151115727452);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 137438953472);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1208925820);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 151115727);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 134217728);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1208926);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 151115.7);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 131072);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1208.926);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 151.1157);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 128);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.208926);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.151116);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibits" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.125);
                    txtOutPutDAT = txtOutPutDAT;
                }









                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e+24);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+24);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.812500e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.765625e+20);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.629395e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.536743e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7.450581e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 931322574615478);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7275957614183);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 909494701773);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 7105427358);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000000);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 888178420);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6938894);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 867361.7);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8000);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6776.264);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1000);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 847.0329);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 6.617445);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yottabytes" && ComToDAT.SelectedItem == "Yobibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 0.827181);
                    txtOutPutDAT = txtOutPutDAT;
                }








                //*******************************************************************************
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Bits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.671407e+24);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Bytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.208926e+24);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Kilobits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.671407e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Kilbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.444733e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Kilobytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.208926e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Kibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.180592e+21);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Megabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.671407e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Mebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.223372e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Megabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.208926e+18);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Mebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.536743e+17);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Gigabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8.000000e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Gibibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.007199e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Gigabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.208926e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Gibibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.125900e+15);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Terabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9671406556917);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Tebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8796093022208);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Terabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1208925819615);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Tebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1099511627776);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Petabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9671406557);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Pebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8589934592);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Petabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1208925820);
                    txtOutPutDAT = txtOutPutDAT;
                }



                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Pebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1073741824);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Exabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9671407);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Exbibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8388608);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Exabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1208926);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Exbibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1048576);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Zetabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9671.407);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Zebibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8192);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Zetabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1208.926);
                    txtOutPutDAT = txtOutPutDAT;
                }


                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Zebibytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1024);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Yottabits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 9.671407);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Yobibits")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 8);
                    txtOutPutDAT = txtOutPutDAT;
                }
                if (comFromDAT.SelectedItem == "Yobibytes" && ComToDAT.SelectedItem == "Yottabytes")
                {
                    txtOutPutDAT.Text = Convert.ToString(Convert.ToDouble(txtAmountDAT.Text) * 1.208926);
                    txtOutPutDAT = txtOutPutDAT;
                }

            }
        }

        private void btnNUmberCLick_DAT(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (txtAmountDAT.Text == "0")
            {
                txtAmountDAT.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!txtAmountDAT.Text.Contains("."))
                    txtAmountDAT.Text = txtAmountDAT.Text + tempButton.Text;
            }
            else
            {
                txtAmountDAT.Text = txtAmountDAT.Text + tempButton.Text;
            }
            treeView1.Visible = false;
        }

        private void btnStandardToDAT_Click(object sender, EventArgs e)
        {
            Form1 F1=new Form1();
            F1.Show();
            this.Hide();
        }

        private void Data_Load(object sender, EventArgs e)
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
