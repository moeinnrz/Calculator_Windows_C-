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
    public partial class Energy : Form
    {
        public Energy()
        {
            InitializeComponent();
        }

        private void btnNumberEnEN_Click(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (txtAmountEN.Text == "0")
            {
                txtAmountEN.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!txtAmountEN.Text.Contains("."))
                    txtAmountEN.Text = txtAmountEN.Text + tempButton.Text;
            }
            else
            {
                txtAmountEN.Text = txtAmountEN.Text + tempButton.Text;
            }
            treeView1.Visible = false;
        }

        private void btnPmEnEN_Click(object sender, EventArgs e)
        {
            if (txtAmountEN.Text.Contains("-"))
            {
                txtAmountEN.Text = txtAmountEN.Text.Remove(0, 1);
            }
            else
            {
                txtAmountEN.Text = txtAmountEN.Text + "-";
            }
        }

        private void btnCEeNEN_Click(object sender, EventArgs e)
        {
            txtAmountEN.Text = "0";
            txtOutPutEN.Text = "0";
        }

        private void BtnBackSpaceENeN_Click(object sender, EventArgs e)
        {
            if (txtAmountEN.Text.Length > 0)
            {
                txtAmountEN.Text = txtAmountEN.Text.Remove(txtAmountEN.Text.Length - 1, 1);
            }

            if (txtAmountEN.Text == "")
            {
                txtAmountEN.Text = "0";
            }
        }

        private void btnConverEnEN_Click_Click(object sender, EventArgs e)
        {
            if (comFromEN.Text == "SElect Unit" || ComToEN.Text == "Select Unit")
            {
                MessageBox.Show("Please Select Unit Fo COnvertor");
            }
            else
            {

                //Electron Volts*******************************************************************************
                if (comFromEN.SelectedItem == "Electron Volts" && ComToEN.SelectedItem == "Joules")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 1.602177e-19);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Electron Volts" && ComToEN.SelectedItem == "Kilojouls")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 1.602177e-22);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Electron Volts" && ComToEN.SelectedItem == "Thermal Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 3.829294e-20);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Electron Volts" && ComToEN.SelectedItem == "Food Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 3.829294e-23);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Electron Volts" && ComToEN.SelectedItem == "Foot-Pounds")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 1.181705e-19);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Electron Volts" && ComToEN.SelectedItem == "British Thermal Units")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 1.518570e-22);
                    txtOutPutEN = txtOutPutEN;
                }

                //Jouls************************************************************************************************
                if (comFromEN.SelectedItem == "Joules" && ComToEN.SelectedItem == "Electron Volts")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 6.241509e+18);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Joules" && ComToEN.SelectedItem == "Kilojouls")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.001);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Joules" && ComToEN.SelectedItem == "Thermal Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.239006);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Joules" && ComToEN.SelectedItem == "Food Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.000239);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Joules" && ComToEN.SelectedItem == "Foot-Pounds")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.737562);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Joules" && ComToEN.SelectedItem == "British Thermal Units")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.000948);
                    txtOutPutEN = txtOutPutEN;
                }

                //Kilojouls********************************************************************************************
                if (comFromEN.SelectedItem == "Kilojouls" && ComToEN.SelectedItem == "Electron Volts")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 6.241509e+21);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Kilojouls" && ComToEN.SelectedItem == "Joules")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 1000);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Kilojouls" && ComToEN.SelectedItem == "Thermal Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 239.0057);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Kilojouls" && ComToEN.SelectedItem == "Food Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.239006);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Kilojouls" && ComToEN.SelectedItem == "Foot-Pounds")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 737.5621);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Kilojouls" && ComToEN.SelectedItem == "British Thermal Units")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.947817);
                    txtOutPutEN = txtOutPutEN;
                }


                //Thermal Colories***********************************************************************************
                if (comFromEN.SelectedItem == "Thermal Colories" && ComToEN.SelectedItem == "Electron Volts")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 2.611448e+19);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Thermal Colories" && ComToEN.SelectedItem == "Joules")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 4.184);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Thermal Colories" && ComToEN.SelectedItem == "Kilojouls")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.004184);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Thermal Colories" && ComToEN.SelectedItem == "Food Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.001);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Thermal Colories" && ComToEN.SelectedItem == "Foot-Pounds")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 3.08596);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Thermal Colories" && ComToEN.SelectedItem == "British Thermal Units")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.003966);
                    txtOutPutEN = txtOutPutEN;
                }


                //Food Colories*******************************************************************************************
                if (comFromEN.SelectedItem == "Food Colories" && ComToEN.SelectedItem == "Electron Volts")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 2.611448e+22);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Food Colories" && ComToEN.SelectedItem == "Joules")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 4184);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Food Colories" && ComToEN.SelectedItem == "Kilojouls")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 4.184);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Food Colories" && ComToEN.SelectedItem == "Thermal Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 1000);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Food Colories" && ComToEN.SelectedItem == "Foot-Pounds")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 3085.96);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Food Colories" && ComToEN.SelectedItem == "British Thermal Units")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 3.965666);
                    txtOutPutEN = txtOutPutEN;
                }


                //Foot_Pounds********************************************************************************************
                if (comFromEN.SelectedItem == "Foot-Pounds" && ComToEN.SelectedItem == "Electron Volts")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 8.462350e+18);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Foot-Pounds" && ComToEN.SelectedItem == "Joules")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 1.355818);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Foot-Pounds" && ComToEN.SelectedItem == "Kilojouls")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.001356);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Foot-Pounds" && ComToEN.SelectedItem == "Thermal Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.324048);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Foot-Pounds" && ComToEN.SelectedItem == "Food Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.000324);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "Foot-Pounds" && ComToEN.SelectedItem == "British Thermal Units")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.001285);
                    txtOutPutEN = txtOutPutEN;
                }


                //British Thermial Units ******************************************************************************
                if (comFromEN.SelectedItem == "British Thermal Units" && ComToEN.SelectedItem == "Electron Volts")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 6.585142e+21);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "British Thermal Units" && ComToEN.SelectedItem == "Joules")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 1055.056);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "British Thermal Units" && ComToEN.SelectedItem == "Kilojouls")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 1.055056);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "British Thermal Units" && ComToEN.SelectedItem == "Thermal Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 252.1644);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "British Thermal Units" && ComToEN.SelectedItem == "Food Colories")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 0.252164);
                    txtOutPutEN = txtOutPutEN;
                }
                if (comFromEN.SelectedItem == "British Thermal Units" && ComToEN.SelectedItem == "Foot-Pounds")
                {
                    txtOutPutEN.Text = Convert.ToString(Convert.ToDouble(txtAmountEN.Text) * 778.1694);
                    txtOutPutEN = txtOutPutEN;
                }
            }
        }

        private void btnStandardToENeN_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void Energy_Load(object sender, EventArgs e)
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
