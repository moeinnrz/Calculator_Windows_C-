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
    public partial class Pressure : Form
    {
        public Pressure()
        {
            InitializeComponent();
        }

        private void btnCEpPRE_Click(object sender, EventArgs e)
        {
            txtAmountPRE.Text = "0";
            txtOutPutPRE.Text = "0";
        }

        private void btnBackSpacePRE_Click(object sender, EventArgs e)
        {
            if (txtAmountPRE.Text.Length > 0)
            {
                txtAmountPRE.Text.Remove(txtAmountPRE.Text.Length - 1, 1);
            }

            if (txtAmountPRE.Text == "")
            {
                txtAmountPRE.Text = "0";
            }
        }

        private void btnPMtIM_Click(object sender, EventArgs e)
        {
            if (txtAmountPRE.Text.Contains("-"))
            {
                txtAmountPRE.Text = txtAmountPRE.Text.Remove(0, 1);
            }
            else
            {
                txtAmountPRE.Text = txtAmountPRE.Text + "-";
            }
        }

        private void btnNumberClick_PRE(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (txtAmountPRE.Text == "0")
            {
                txtAmountPRE.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!txtAmountPRE.Text.Contains("."))
                    txtAmountPRE.Text = txtAmountPRE.Text + tempButton.Text;
            }
            else
            {
                txtAmountPRE.Text = txtAmountPRE.Text + tempButton.Text;
            }
            treeView1.Visible = false;
        }

        private void btnConvertPRE_Click(object sender, EventArgs e)
        {
            if (comFromPRE.Text == "SElect Unit" || ComToPRE.Text == "Select Unit")
            {
                MessageBox.Show("Please Select Unit Fo COnvertor");
            }
            else
            {

                //*******************************************************************************
                if (comFromPRE.SelectedItem == "Atmospheres" && ComToPRE.SelectedItem == "bars")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 1.01325);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Atmospheres" && ComToPRE.SelectedItem == "KiloPascals")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 101.325);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Atmospheres" && ComToPRE.SelectedItem == "Millimeters of Mercury")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 760.1275);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Atmospheres" && ComToPRE.SelectedItem == "Pascals")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 101325);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Atmospheres" && ComToPRE.SelectedItem == "Pounds per square inch")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 14.69595);
                    txtOutPutPRE = txtOutPutPRE;
                }



                //*******************************************************************************
                if (comFromPRE.SelectedItem == "bars" && ComToPRE.SelectedItem == "Atmospheres")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.986923);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "bars" && ComToPRE.SelectedItem == "KiloPascals")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 100);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "bars" && ComToPRE.SelectedItem == "Millimeters of Mercury")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 750.1875);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "bars" && ComToPRE.SelectedItem == "Pascals")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 100000);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "bars" && ComToPRE.SelectedItem == "Pounds per square inch")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 14.50377);
                    txtOutPutPRE = txtOutPutPRE;
                }


                //*******************************************************************************
                if (comFromPRE.SelectedItem == "KiloPascals" && ComToPRE.SelectedItem == "Atmospheres")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.009869);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "KiloPascals" && ComToPRE.SelectedItem == "bars")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.01);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "KiloPascals" && ComToPRE.SelectedItem == "Millimeters of Mercury")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 7.501875);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "KiloPascals" && ComToPRE.SelectedItem == "Pascals")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 1000);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "KiloPascals" && ComToPRE.SelectedItem == "Pounds per square inch")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.145038);
                    txtOutPutPRE = txtOutPutPRE;
                }


                //*******************************************************************************
                if (comFromPRE.SelectedItem == "Millimeters of Mercury" && ComToPRE.SelectedItem == "Atmospheres")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.001316);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Millimeters of Mercury" && ComToPRE.SelectedItem == "bars")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.001333);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Millimeters of Mercury" && ComToPRE.SelectedItem == "KiloPascals")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.1333);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Millimeters of Mercury" && ComToPRE.SelectedItem == "Pascals")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 133.3);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Millimeters of Mercury" && ComToPRE.SelectedItem == "Pounds per square inch")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.019334);
                    txtOutPutPRE = txtOutPutPRE;
                }


                //*******************************************************************************
                if (comFromPRE.SelectedItem == "Pascals" && ComToPRE.SelectedItem == "Atmospheres")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.00001);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Pascals" && ComToPRE.SelectedItem == "bars")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.00001);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Pascals" && ComToPRE.SelectedItem == "KiloPascals")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.001);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Pascals" && ComToPRE.SelectedItem == "Millimeters of Mercury")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.007502);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Pascals" && ComToPRE.SelectedItem == "Pounds per square inch")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.000145);
                    txtOutPutPRE = txtOutPutPRE;
                }


                //*******************************************************************************
                if (comFromPRE.SelectedItem == "Pounds per square inch" && ComToPRE.SelectedItem == "Atmospheres")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.068046);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Pounds per square inch" && ComToPRE.SelectedItem == "bars")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 0.068948);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Pounds per square inch" && ComToPRE.SelectedItem == "KiloPascals")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 6.894757);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Pounds per square inch" && ComToPRE.SelectedItem == "Millimeters of Mercury")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 51.72361);
                    txtOutPutPRE = txtOutPutPRE;
                }
                if (comFromPRE.SelectedItem == "Pounds per square inch" && ComToPRE.SelectedItem == "Pascals")
                {
                    txtOutPutPRE.Text = Convert.ToString(Convert.ToDouble(txtAmountPRE.Text) * 6894.757);
                    txtOutPutPRE = txtOutPutPRE;
                }
            }
        }

        private void btnStandardToPRE_Click(object sender, EventArgs e)
        {
            Form1 F1= new Form1();
            F1.Show();
            this.Hide();
        }

        private void Pressure_Load(object sender, EventArgs e)
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
