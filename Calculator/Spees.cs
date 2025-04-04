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
    public partial class Spees : Form
    {
        public Spees()
        {
            InitializeComponent();
        }

        private void btnNumberClickSPE(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (txtAmountSPE.Text == "0")
            {
                txtAmountSPE.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!txtAmountSPE.Text.Contains("."))
                    txtAmountSPE.Text = txtAmountSPE.Text + tempButton.Text;
            }
            else
            {
                txtAmountSPE.Text = txtAmountSPE.Text + tempButton.Text;
            }
            treeView1.Visible = false;
        }

        private void btnPMsPE_Click(object sender, EventArgs e)
        {
            if (txtAmountSPE.Text.Contains("-"))
            {
                txtAmountSPE.Text = txtAmountSPE.Text.Remove(0, 1);
            }
            else
            {
                txtAmountSPE.Text = txtAmountSPE.Text + "-";
            }
        }

        private void btnCEsPE_Click(object sender, EventArgs e)
        {

            txtAmountSPE.Text = "0";
            txtOutPutSPE.Text = "0";
        }

        private void btnBackSpaceSPE_Click(object sender, EventArgs e)
        {
            if (txtAmountSPE.Text.Length > 0)
            {
                txtAmountSPE.Text.Remove(txtAmountSPE.Text.Length - 1, 1);
            }

            if (txtAmountSPE.Text == "")
            {
                txtAmountSPE.Text = "0";
            }
        }

        private void btnConvertSPE_Click(object sender, EventArgs e)
        {
            if (comFromSPE.Text == "SElect Unit" || ComToSPE.Text == "Select Unit")
            {
                MessageBox.Show("Please Select Unit Fo COnvertor");
            }
            else
            {

                //*******************************************************************************
                if (comFromSPE.SelectedItem == "Centimeters per second" && ComToSPE.SelectedItem == "Meters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.01);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Centimeters per second" && ComToSPE.SelectedItem == "Kilometers per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.036);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Centimeters per second" && ComToSPE.SelectedItem == "Feet per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.032808);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Centimeters per second" && ComToSPE.SelectedItem == "Miles per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.022371);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Centimeters per second" && ComToSPE.SelectedItem == "Knots")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.01944);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Centimeters per second" && ComToSPE.SelectedItem == "Mach")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.000029);
                    txtOutPutSPE = txtOutPutSPE;
                }


                //*****************************************************************************************************
                if (comFromSPE.SelectedItem == "Meters per second" && ComToSPE.SelectedItem == "Centimeters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 100);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Meters per second" && ComToSPE.SelectedItem == "Kilometers per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 3.6);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Meters per second" && ComToSPE.SelectedItem == "Feet per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 3.28084);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Meters per second" && ComToSPE.SelectedItem == "Miles per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 2.237136);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Meters per second" && ComToSPE.SelectedItem == "Knots")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 1.944012);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Meters per second" && ComToSPE.SelectedItem == "Mach")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.002939);
                    txtOutPutSPE = txtOutPutSPE;
                }


                //************************************************************************************************
                if (comFromSPE.SelectedItem == "Kilometers per hour" && ComToSPE.SelectedItem == "Centimeters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 27.77778);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Kilometers per hour" && ComToSPE.SelectedItem == "Meters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.277778);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Kilometers per hour" && ComToSPE.SelectedItem == "Feet per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.911344);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Kilometers per hour" && ComToSPE.SelectedItem == "Miles per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.621427);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Kilometers per hour" && ComToSPE.SelectedItem == "Knots")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.540003);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Kilometers per hour" && ComToSPE.SelectedItem == "Mach")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.000816);
                    txtOutPutSPE = txtOutPutSPE;
                }


                //***************************************************************************************************
                if (comFromSPE.SelectedItem == "Feet per second" && ComToSPE.SelectedItem == "Centimeters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 30.48);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Feet per second" && ComToSPE.SelectedItem == "Meters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.3048);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Feet per second" && ComToSPE.SelectedItem == "Kilometers per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 1.09728);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Feet per second" && ComToSPE.SelectedItem == "Miles per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.681879);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Feet per second" && ComToSPE.SelectedItem == "Knots")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.592535);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Feet per second" && ComToSPE.SelectedItem == "Mach")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.000896);
                    txtOutPutSPE = txtOutPutSPE;
                }


                //*********************************************************************************************
                if (comFromSPE.SelectedItem == "Miles per hour" && ComToSPE.SelectedItem == "Centimeters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 44.7);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Miles per hour" && ComToSPE.SelectedItem == "Meters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.447);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Miles per hour" && ComToSPE.SelectedItem == "Kilometers per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 1.6092);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Miles per hour" && ComToSPE.SelectedItem == "Feet per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 1.466535);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Miles per hour" && ComToSPE.SelectedItem == "Knots")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 1.466535);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Miles per hour" && ComToSPE.SelectedItem == "Mach")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.001314);
                    txtOutPutSPE = txtOutPutSPE;
                }


                //****************************************************************************************************
                if (comFromSPE.SelectedItem == "Knots" && ComToSPE.SelectedItem == "Centimeters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 51.44);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Knots" && ComToSPE.SelectedItem == "Meters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.5144);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Knots" && ComToSPE.SelectedItem == "Kilometers per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 1.85184);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Knots" && ComToSPE.SelectedItem == "Feet per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 1.687664);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Knots" && ComToSPE.SelectedItem == "Miles per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 1.150783);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Knots" && ComToSPE.SelectedItem == "Mach")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 0.001512);
                    txtOutPutSPE = txtOutPutSPE;
                }


                //***************************************************************************************************
                if (comFromSPE.SelectedItem == "Mach" && ComToSPE.SelectedItem == "Centimeters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 34030);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Mach" && ComToSPE.SelectedItem == "Meters per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 340.3);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Mach" && ComToSPE.SelectedItem == "Kilometers per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 1225.08);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Mach" && ComToSPE.SelectedItem == "Feet per second")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 1116.47);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Mach" && ComToSPE.SelectedItem == "Miles per hour")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 761.2975);
                    txtOutPutSPE = txtOutPutSPE;
                }
                if (comFromSPE.SelectedItem == "Mach" && ComToSPE.SelectedItem == "Knots")
                {
                    txtOutPutSPE.Text = Convert.ToString(Convert.ToDouble(txtAmountSPE.Text) * 661.5474);
                    txtOutPutSPE = txtOutPutSPE;
                }
            }
        }

        private void btnStandardToSPE_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void Spees_Load(object sender, EventArgs e)
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
