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
    public partial class Time : Form
    {
        public Time()
        {
            InitializeComponent();
        }

        private void btnCEpTIM_Click(object sender, EventArgs e)
        {
            txtAmountTIM.Text = "0";
            txtOutPutTIM.Text = "0";
        }

        private void btnBackSpaceTIM_Click(object sender, EventArgs e)
        {
            if (txtAmountTIM.Text.Length > 0)
            {
                txtAmountTIM.Text.Remove(txtAmountTIM.Text.Length - 1, 1);
            }

            if (txtAmountTIM.Text == "")
            {
                txtAmountTIM.Text = "0";
            }
        }

        private void btnPMtIM_Click(object sender, EventArgs e)
        {
            if (txtAmountTIM.Text.Contains("-"))
            {
                txtAmountTIM.Text = txtAmountTIM.Text.Remove(0, 1);
            }
            else
            {
                txtAmountTIM.Text = txtAmountTIM.Text + "-";
            }
        }

        private void btnNumberTIM_CLick(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (txtAmountTIM.Text == "0")
            {
                txtAmountTIM.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!txtAmountTIM.Text.Contains("."))
                    txtAmountTIM.Text = txtAmountTIM.Text + tempButton.Text;
            }
            else
            {
                txtAmountTIM.Text = txtAmountTIM.Text + tempButton.Text;
            }
            treeView1.Visible = false;
        }

        private void btnConvertTIM_Click(object sender, EventArgs e)
        {
            if (comFromTIM.Text == "SElect Unit" || ComToTIM.Text == "Select Unit")
            {
                MessageBox.Show("Please Select Unit Fo COnvertor");
            }
            else
            {

                //*******************************************************************************
                if (comFromTIM.SelectedItem == "MicroSeconds" && ComToTIM.SelectedItem == "MilliSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.001);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MicroSeconds" && ComToTIM.SelectedItem == "Seconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000001);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MicroSeconds" && ComToTIM.SelectedItem == "Minutes")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000000016666667);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MicroSeconds" && ComToTIM.SelectedItem == "Hours")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000000000277778);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MicroSeconds" && ComToTIM.SelectedItem == "Days")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000000000011574);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MicroSeconds" && ComToTIM.SelectedItem == "Weeks")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000000000001653);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MicroSeconds" && ComToTIM.SelectedItem == "Years")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000000000000032);
                    txtOutPutTIM = txtOutPutTIM;
                }


                //******************************************************************************************
                if (comFromTIM.SelectedItem == "MilliSeconds" && ComToTIM.SelectedItem == "MicroSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 1000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MilliSeconds" && ComToTIM.SelectedItem == "Seconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.001);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MilliSeconds" && ComToTIM.SelectedItem == "Minutes")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000017);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MilliSeconds" && ComToTIM.SelectedItem == "Hours")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000000277777778);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MilliSeconds" && ComToTIM.SelectedItem == "Days")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000000011574074);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MilliSeconds" && ComToTIM.SelectedItem == "Weeks")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000000001653439);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "MilliSeconds" && ComToTIM.SelectedItem == "Years")
                {   
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000000000031688);
                    txtOutPutTIM = txtOutPutTIM;
                }


                //*******************************************************************************************************
                if (comFromTIM.SelectedItem == "Seconds" && ComToTIM.SelectedItem == "MicroSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 1000000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Seconds" && ComToTIM.SelectedItem == "MilliSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 1000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Seconds" && ComToTIM.SelectedItem == "Minutes")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.016667);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Seconds" && ComToTIM.SelectedItem == "Hours")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000278);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Seconds" && ComToTIM.SelectedItem == "Days")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000012);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Seconds" && ComToTIM.SelectedItem == "Weeks")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000002);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Seconds" && ComToTIM.SelectedItem == "Years")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000000031688088);
                    txtOutPutTIM = txtOutPutTIM;
                }



                //***************************************************************************************************
                if (comFromTIM.SelectedItem == "Minutes" && ComToTIM.SelectedItem == "MicroSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 60000000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Minutes" && ComToTIM.SelectedItem == "MilliSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 60000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Minutes" && ComToTIM.SelectedItem == "Seconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 60);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Minutes" && ComToTIM.SelectedItem == "Hours")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.016667);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Minutes" && ComToTIM.SelectedItem == "Days")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000694);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Minutes" && ComToTIM.SelectedItem == "Weeks")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000099);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Minutes" && ComToTIM.SelectedItem == "Years")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000002);
                    txtOutPutTIM = txtOutPutTIM;
                }


                //*********************************************************************************************
                if (comFromTIM.SelectedItem == "Hours" && ComToTIM.SelectedItem == "MicroSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 3600000000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Hours" && ComToTIM.SelectedItem == "MilliSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 3600000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Hours" && ComToTIM.SelectedItem == "Seconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 3600);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Hours" && ComToTIM.SelectedItem == "Minutes")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 60);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Hours" && ComToTIM.SelectedItem == "Days")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.041667);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Hours" && ComToTIM.SelectedItem == "Weeks")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.005952);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Hours" && ComToTIM.SelectedItem == "Years")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.000114);
                    txtOutPutTIM = txtOutPutTIM;
                }


                //****************************************************************************************************
                if (comFromTIM.SelectedItem == "Days" && ComToTIM.SelectedItem == "MicroSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 86400000000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Days" && ComToTIM.SelectedItem == "MilliSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 86400000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Days" && ComToTIM.SelectedItem == "Seconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 86400);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Days" && ComToTIM.SelectedItem == "Minutes")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 1440);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Days" && ComToTIM.SelectedItem == "Hours")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 24);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Days" && ComToTIM.SelectedItem == "Weeks")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.142857);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Days" && ComToTIM.SelectedItem == "Years")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.002738);
                    txtOutPutTIM = txtOutPutTIM;
                }


                //****************************************************************************************************
                if (comFromTIM.SelectedItem == "Weeks" && ComToTIM.SelectedItem == "MicroSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 604800000000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Weeks" && ComToTIM.SelectedItem == "MilliSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 604800000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Weeks" && ComToTIM.SelectedItem == "Seconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 604800);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Weeks" && ComToTIM.SelectedItem == "Minutes")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 10080);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Weeks" && ComToTIM.SelectedItem == "Hours")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 168);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Weeks" && ComToTIM.SelectedItem == "Days")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 7);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Weeks" && ComToTIM.SelectedItem == "Years")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 0.019165);
                    txtOutPutTIM = txtOutPutTIM;
                }



                //****************************************************************************************************
                if (comFromTIM.SelectedItem == "Years" && ComToTIM.SelectedItem == "MicroSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 31557600000000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Years" && ComToTIM.SelectedItem == "MilliSeconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 31557600000);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Years" && ComToTIM.SelectedItem == "Seconds")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 31557600);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Years" && ComToTIM.SelectedItem == "Minutes")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 525960);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Years" && ComToTIM.SelectedItem == "Hours")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 8766);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Years" && ComToTIM.SelectedItem == "Days")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 365.25);
                    txtOutPutTIM = txtOutPutTIM;
                }
                if (comFromTIM.SelectedItem == "Years" && ComToTIM.SelectedItem == "Weeks")
                {
                    txtOutPutTIM.Text = Convert.ToString(Convert.ToDouble(txtAmountTIM.Text) * 52.17857);
                    txtOutPutTIM = txtOutPutTIM;
                }
            }
        }

        private void btnStandardToTIM_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void Time_Load(object sender, EventArgs e)
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
