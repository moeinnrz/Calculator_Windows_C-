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
    public partial class length : Form
    {
        public length()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (comFrom.Text == "SElect Unit" || ComTO.Text == "Select Unit")
            {
                MessageBox.Show("Please Select Unit Fo COnvertor");
            }
            else
            {

                //KiloMeters*******************************************************************************
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Meters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1000);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Centimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 100000);
                }
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Nanometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1000000000000);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Microns")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1000000000);
                }
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Millimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1000000);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Inches")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 39370.08);
                }
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Feet")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 3280.84);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Yards")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1093.613);
                }
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.621371);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Kilometers" && ComTO.SelectedItem == "Nautical Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.539957);
                }




                //Meters***********************************************************************************
                if (comFrom.SelectedItem == "Meters" && ComTO.SelectedItem == "Kilometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.001);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Meters" && ComTO.SelectedItem == "Centimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 100);
                }
                if (comFrom.SelectedItem == "Meters" && ComTO.SelectedItem == "Nanometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1000000000);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Meters" && ComTO.SelectedItem == "Microns")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1000000);
                }
                if (comFrom.SelectedItem == "Meters" && ComTO.SelectedItem == "Millimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1000);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Meters" && ComTO.SelectedItem == "Inches")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 39.37008);
                }
                if (comFrom.SelectedItem == "Meters" && ComTO.SelectedItem == "Feet")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 3.28084);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Meters" && ComTO.SelectedItem == "Yards")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1.093613);
                }
                if (comFrom.SelectedItem == "Meters" && ComTO.SelectedItem == "Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000621);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Meters" && ComTO.SelectedItem == "Nautical Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.00054);
                }


                //CentiMeters***************************************************************************
                if (comFrom.SelectedItem == "Centimeters" && ComTO.SelectedItem == "Kilometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.00001);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Centimeters" && ComTO.SelectedItem == "Meters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.01);
                }
                if (comFrom.SelectedItem == "Centimeters" && ComTO.SelectedItem == "Nanometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 10000000);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Centimeters" && ComTO.SelectedItem == "Microns")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 10000);
                }
                if (comFrom.SelectedItem == "Centimeters" && ComTO.SelectedItem == "Millimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 10);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Centimeters" && ComTO.SelectedItem == "Inches")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.393701);
                }
                if (comFrom.SelectedItem == "Centimeters" && ComTO.SelectedItem == "Feet")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.032808);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Centimeters" && ComTO.SelectedItem == "Yards")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.010936);
                }
                if (comFrom.SelectedItem == "Centimeters" && ComTO.SelectedItem == "Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000006);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Centimeters" && ComTO.SelectedItem == "Nautical Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000005);
                }


                //MilliMeters***************************************************************************************
                if (comFrom.SelectedItem == "Millimeters" && ComTO.SelectedItem == "Kilometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000001);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Millimeters" && ComTO.SelectedItem == "Meters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.001);
                }
                if (comFrom.SelectedItem == "Millimeters" && ComTO.SelectedItem == "Nanometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1000000);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Millimeters" && ComTO.SelectedItem == "Microns")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1000);
                }
                if (comFrom.SelectedItem == "Millimeters" && ComTO.SelectedItem == "Centimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.1);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Millimeters" && ComTO.SelectedItem == "Inches")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.03937);
                }
                if (comFrom.SelectedItem == "Millimeters" && ComTO.SelectedItem == "Feet")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.003281);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Millimeters" && ComTO.SelectedItem == "Yards")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.001094);
                }
                if (comFrom.SelectedItem == "Millimeters" && ComTO.SelectedItem == "Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000000621371192);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Millimeters" && ComTO.SelectedItem == "Nautical Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000000539956803);
                }


                //Microns********************************************************************************************
                if (comFrom.SelectedItem == "Microns" && ComTO.SelectedItem == "Kilometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000000001);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Microns" && ComTO.SelectedItem == "Meters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000001);
                }
                if (comFrom.SelectedItem == "Microns" && ComTO.SelectedItem == "Nanometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1000);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Microns" && ComTO.SelectedItem == "Millimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.001);
                }
                if (comFrom.SelectedItem == "Microns" && ComTO.SelectedItem == "Centimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.0001);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Microns" && ComTO.SelectedItem == "Inches")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000039);
                }
                if (comFrom.SelectedItem == "Microns" && ComTO.SelectedItem == "Feet")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000003);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Microns" && ComTO.SelectedItem == "Yards")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000001);
                }
                if (comFrom.SelectedItem == "Microns" && ComTO.SelectedItem == "Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000000000621371);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Microns" && ComTO.SelectedItem == "Nautical Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000000000539957);
                }


                //NanoMeters********************************************************************************************
                if (comFrom.SelectedItem == "Nanometers" && ComTO.SelectedItem == "Kilometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000000000001);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Nanometers" && ComTO.SelectedItem == "Meters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000000001);
                }
                if (comFrom.SelectedItem == "Nanometers" && ComTO.SelectedItem == "Microns")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.001);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Nanometers" && ComTO.SelectedItem == "Millimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000001);
                }
                if (comFrom.SelectedItem == "Nanometers" && ComTO.SelectedItem == "Centimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.0000001);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Nanometers" && ComTO.SelectedItem == "Inches")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000000039370079);
                }
                if (comFrom.SelectedItem == "Nanometers" && ComTO.SelectedItem == "Feet")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.00000000328084);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Nanometers" && ComTO.SelectedItem == "Yards")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000000001093613);
                }
                if (comFrom.SelectedItem == "Nanometers" && ComTO.SelectedItem == "Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000000000000621);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Nanometers" && ComTO.SelectedItem == "Nautical Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.00000000000054);
                }


                //Inches*****************************************************************************************
                if (comFrom.SelectedItem == "Inches" && ComTO.SelectedItem == "Kilometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000025);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Inches" && ComTO.SelectedItem == "Meters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.0254);
                }
                if (comFrom.SelectedItem == "Inches" && ComTO.SelectedItem == "Microns")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 25400);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Inches" && ComTO.SelectedItem == "Millimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 25.4);
                }
                if (comFrom.SelectedItem == "Inches" && ComTO.SelectedItem == "Centimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 2.54);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Inches" && ComTO.SelectedItem == "Nanometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 25400000);
                }
                if (comFrom.SelectedItem == "Inches" && ComTO.SelectedItem == "Feet")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.083333);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Inches" && ComTO.SelectedItem == "Yards")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.027778);
                }
                if (comFrom.SelectedItem == "Inches" && ComTO.SelectedItem == "Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000016);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Inches" && ComTO.SelectedItem == "Nautical Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000014);
                }


                //Feet*****************************************************************************************
                if (comFrom.SelectedItem == "Feet" && ComTO.SelectedItem == "Kilometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000305);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Feet" && ComTO.SelectedItem == "Meters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.3048);
                }
                if (comFrom.SelectedItem == "Feet" && ComTO.SelectedItem == "Microns")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 304800);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Feet" && ComTO.SelectedItem == "Millimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 304.8);
                }
                if (comFrom.SelectedItem == "Feet" && ComTO.SelectedItem == "Centimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 30.48);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Feet" && ComTO.SelectedItem == "Nanometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 304800000);
                }
                if (comFrom.SelectedItem == "Feet" && ComTO.SelectedItem == "Inches")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 12);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Feet" && ComTO.SelectedItem == "Yards")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.333333);
                }
                if (comFrom.SelectedItem == "Feet" && ComTO.SelectedItem == "Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000189);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Feet" && ComTO.SelectedItem == "Nautical Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000165);
                }


                //Yards**************************************************************************************
                if (comFrom.SelectedItem == "Yards" && ComTO.SelectedItem == "Kilometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000914);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Yards" && ComTO.SelectedItem == "Meters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.9144);
                }
                if (comFrom.SelectedItem == "Yards" && ComTO.SelectedItem == "Microns")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 914400);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Yards" && ComTO.SelectedItem == "Millimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 914.4);
                }
                if (comFrom.SelectedItem == "Yards" && ComTO.SelectedItem == "Centimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 91.44);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Yards" && ComTO.SelectedItem == "Nanometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 914400000);
                }
                if (comFrom.SelectedItem == "Yards" && ComTO.SelectedItem == "Inches")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 36);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Yards" && ComTO.SelectedItem == "Feet")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 3);
                }
                if (comFrom.SelectedItem == "Yards" && ComTO.SelectedItem == "Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000568);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Yards" && ComTO.SelectedItem == "Nautical Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.000494);
                }


                //Miles*******************************************************************************
                if (comFrom.SelectedItem == "Miles" && ComTO.SelectedItem == "Kilometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1.609344);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Miles" && ComTO.SelectedItem == "Meters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1609.344);
                }
                if (comFrom.SelectedItem == "Miles" && ComTO.SelectedItem == "Microns")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1609344000);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Miles" && ComTO.SelectedItem == "Millimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1609344);
                }
                if (comFrom.SelectedItem == "Miles" && ComTO.SelectedItem == "Centimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 321868.8);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Miles" && ComTO.SelectedItem == "Nanometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1609344000000);
                }
                if (comFrom.SelectedItem == "Miles" && ComTO.SelectedItem == "Inches")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 63360);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Miles" && ComTO.SelectedItem == "Feet")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 5280);
                }
                if (comFrom.SelectedItem == "Miles" && ComTO.SelectedItem == "Yards")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1760);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Miles" && ComTO.SelectedItem == "Nautical Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 0.868976);
                }

                //Nutical Miles********************************************************************************
                if (comFrom.SelectedItem == "Nautical Miles" && ComTO.SelectedItem == "Kilometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1.852);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Nautical Miles" && ComTO.SelectedItem == "Meters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1852);
                }
                if (comFrom.SelectedItem == "Nautical Miles" && ComTO.SelectedItem == "Microns")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1852000000);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Nautical Miles" && ComTO.SelectedItem == "Millimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1852000);
                }
                if (comFrom.SelectedItem == "Nautical Miles" && ComTO.SelectedItem == "Centimeters")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 185200);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Nautical Miles" && ComTO.SelectedItem == "Nanometers")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1852000000000);
                }   
                if (comFrom.SelectedItem == "Nautical Miles" && ComTO.SelectedItem == "Inches")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 72913.39);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Nautical Miles" && ComTO.SelectedItem == "Feet")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 6076.115);
                }
                if (comFrom.SelectedItem == "Nautical Miles" && ComTO.SelectedItem == "Yards")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 2025.372);
                    txtOutPut = txtOutPut;
                }
                if (comFrom.SelectedItem == "Nautical Miles" && ComTO.SelectedItem == "Miles")
                {
                    txtOutPut.Text = Convert.ToString(Convert.ToDouble(txtAmount.Text) * 1.150779);
                }
            }
        }

        private void NumberLengthclick(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (txtAmount.Text == "0")
            {
                txtAmount.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!txtAmount.Text.Contains("."))
                    txtAmount.Text = txtAmount.Text + tempButton.Text;
            }
            else
            {
                txtAmount.Text = txtAmount.Text + tempButton.Text;
            }
            treeView1.Visible = false;
        }

        private void btnStandardToLength_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "0";
            txtOutPut.Text = "0";

        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length > 0)
            {
                txtAmount.Text = txtAmount.Text.Remove(txtAmount.Text.Length - 1, 1);
            }

            if (txtAmount.Text == "")
            {
                txtAmount.Text = "0";
            }
        }

        private void btnPmLE_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Contains("-"))
            {
                txtAmount.Text = txtAmount.Text.Remove(0, 1);
            }
            else
            {
                txtAmount.Text = txtAmount.Text + "-";
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void length_Load(object sender, EventArgs e)
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
