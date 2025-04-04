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
    public partial class Weigh_Mass : Form
    {
        public Weigh_Mass()
        {
            InitializeComponent();
        }

        private void btnConvertWE_Click(object sender, EventArgs e)
        {
            if (comFromWE.Text == "SElect Unit" || comToWE.Text == "Select Unit")
            {
                MessageBox.Show("Please Select Unit Fo COnvertor");
            }
            else
            {
                //Crats*******************************************************************************
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 200);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 20);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 2);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.2);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.02);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.002);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.0002);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.0000002);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.007055);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000441);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000031);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000220462262);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Crats" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000196841306);
                    txtOutPutWE = txtOutPutWE;
                }



                //MilliGrams************************************************************************************************
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.005);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.1);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.01);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.0001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.00001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000035);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000002);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000157473044);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000001102311);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000000984207);
                    txtOutPutWE = txtOutPutWE;
                }



                //CentiGrams************************************************************************************************
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.005);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.1);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.01);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.0001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.00001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000035);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000002);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000157473044);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000001102311);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Milligrams" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000000984207);
                    txtOutPutWE = txtOutPutWE;
                }

                //CentiGrams***********************************************************************************************************
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.05);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.1);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.01);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.0001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.00001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.00000001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000353);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000022);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000002);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000011023113);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Centigrams" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000009842065);
                    txtOutPutWE = txtOutPutWE;
                }


                //DeciGrams***************************************************************************************************
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.5);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 100);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.1);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.01);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.0001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.0000001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.003527);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.00022);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000016);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000110231131);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Decigrams" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000098420653);
                    txtOutPutWE = txtOutPutWE;
                }


                //Grams*******************************************************************************************************
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 5);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 100);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.1);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.01);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.035274);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.002205);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000157);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Grams" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000000984206528);
                    txtOutPutWE = txtOutPutWE;
                }


                //DekaGrams***************************************************************************************************
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 50);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 100);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.1);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.01);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.00001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.35274);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.022046);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.001575);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000011);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Dekagrams" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000098);
                    txtOutPutWE = txtOutPutWE;
                }


                //HectaGrams****************************************************************************************
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 500);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 100000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 100);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.1);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.0001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 3.527396);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.220462);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.015747);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.00011);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Hectograms" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000098);
                    txtOutPutWE = txtOutPutWE;
                }


                //KiloGrams**************************************************************************************
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 5000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1000000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 100000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 100);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.001);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 35.27396);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 2.204623);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.157473);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.001102);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Kilograms" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000984);
                    txtOutPutWE = txtOutPutWE;
                }


                //Metric Tonnes**************************************************************************************
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 5000000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1000000000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 100000000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10000000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1000000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 100000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 35273.96);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 2204.623);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 157.473);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1.102311);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Metric Tonnes" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.984207);
                    txtOutPutWE = txtOutPutWE;
                }


                //Ounces***********************************************************************************************
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 141.7476);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 28349.52);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 2834.952);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 283.4952);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 28.34952);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 2.834952);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.283495);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.02835);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000028);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.0625);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.004464);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000031);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Ounces" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000028);
                    txtOutPutWE = txtOutPutWE;
                }

                //Pounds***********************************************************************************************
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 2267.962);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 453592.4);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 45359.24);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 4535.924);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 453.5924);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 45.35924);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 4.535924);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.453592);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000454);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 16);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.071429);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.0005);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Pounds" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.000446);
                    txtOutPutWE = txtOutPutWE;
                }


                //stone**********************************************************************************************
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 31751.47);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 6350293);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 635029.3);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 63502.93);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 6350.293);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 635.0293);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 63.50293);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 6.350293);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.00635);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 224);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 14);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.007);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Stone" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.00625);
                    txtOutPutWE = txtOutPutWE;
                }


                //Short Tons (US)*************************************************************************************
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 4535924);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 907184740);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 90718474);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 9071847);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 907184.7);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 90718.47);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 9071.847);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 907.1847);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.907185);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 32000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 2000);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 142.8571);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Short Tons (US)" && comToWE.SelectedItem == "Long Tons (UK)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 0.892857);
                    txtOutPutWE = txtOutPutWE;
                }


                //Long Tons (UK)********************************************************************************************
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Crats")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 5080235);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Milligrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1016046909);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Centigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 101604691);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Decigrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10160469);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Grams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1016047);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Dekagrams")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 101604.7);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Hectograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 10160.47);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Kilograms")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1016.047);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Metric Tonnes")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1.016047);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Ounces")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 35840);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Pounds")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 2240);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Stone")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 160);
                    txtOutPutWE = txtOutPutWE;
                }
                if (comFromWE.SelectedItem == "Long Tons (UK)" && comToWE.SelectedItem == "Short Tons (US)")
                {
                    txtOutPutWE.Text = Convert.ToString(Convert.ToDouble(txtAmountWE.Text) * 1.12);
                    txtOutPutWE = txtOutPutWE;
                }
            }
        }

        private void btnNumberClickWE(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (txtAmountWE.Text == "0")
            {
                txtAmountWE.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!txtAmountWE.Text.Contains("."))
                    txtAmountWE.Text = txtAmountWE.Text + tempButton.Text;
            }
            else
            {
                txtAmountWE.Text = txtAmountWE.Text + tempButton.Text;
            }
            treeView1.Visible = false;
        }

        private void BtnCEWE_Click(object sender, EventArgs e)
        {
            txtAmountWE.Text = "0";
            txtOutPutWE.Text = "0";
        }

        private void btnBackSpaceWE_Click(object sender, EventArgs e)
        {
            if (txtAmountWE.Text.Length > 0)
            {
                txtAmountWE.Text = txtAmountWE.Text.Remove(txtAmountWE.Text.Length - 1, 1);
            }

            if (txtAmountWE.Text == "")
            {
                txtAmountWE.Text = "0";
            }
        }

        private void btnStandardToWE_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtAmountWE.Text.Contains("-"))
            {
                txtAmountWE.Text = txtAmountWE.Text.Remove(0, 1);
            }
            else
            {
                txtAmountWE.Text = txtAmountWE.Text + "-";
            }
        }

        private void Weigh_Mass_Load(object sender, EventArgs e)
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
