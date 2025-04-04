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
    public partial class Power : Form
    {
        public Power()
        {
            InitializeComponent();
        }

        private void btnBackSpaceSPE_Click(object sender, EventArgs e)
        {
            if (txtAmountPOW.Text.Length > 0)
            {
                txtAmountPOW.Text.Remove(txtAmountPOW.Text.Length - 1, 1);
            }

            if (txtAmountPOW.Text == "")
            {
                txtAmountPOW.Text = "0";
            }
        }

        private void btnNumberPOW_CLick(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (txtAmountPOW.Text == "0")
            {
                txtAmountPOW.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!txtAmountPOW.Text.Contains("."))
                    txtAmountPOW.Text = txtAmountPOW.Text + tempButton.Text;
            }
            else
            {
                txtAmountPOW.Text = txtAmountPOW.Text + tempButton.Text;
            }
            treeView1.Visible = false;
        }

        private void btnPMpOW_Click(object sender, EventArgs e)
        {
            if (txtAmountPOW.Text.Contains("-"))
            {
                txtAmountPOW.Text = txtAmountPOW.Text.Remove(0, 1);
            }
            else
            {
                txtAmountPOW.Text = txtAmountPOW.Text + "-";
            }
        }

        private void btnCEpOW_Click(object sender, EventArgs e)
        {
            txtAmountPOW.Text = "0";
            txtOutPutPOW.Text = "0";
        }

        private void btnConvertPOW_Click(object sender, EventArgs e)
        {
            {
                if (comFromPOW.Text == "SElect Unit" || ComToPOW.Text == "Select Unit")
                {
                    MessageBox.Show("Please Select Unit Fo COnvertor");
                }
                else
                {

                    //*******************************************************************************
                    if (comFromPOW.SelectedItem == "Watts" && ComToPOW.SelectedItem == "KiloWatts")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtOutPutPOW.Text) * 0.001);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "Watts" && ComToPOW.SelectedItem == "HorsePower (US)")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 0.001341);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "Watts" && ComToPOW.SelectedItem == "Foot_Pounds/Minute")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 44.25373);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "Watts" && ComToPOW.SelectedItem == "BTUs/Minute")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 0.056869);
                        txtOutPutPOW = txtOutPutPOW;
                    }


                    //********************************************************************************************
                    if (comFromPOW.SelectedItem == "KiloWatts" && ComToPOW.SelectedItem == "Watts")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 1000);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "KiloWatts" && ComToPOW.SelectedItem == "HorsePower (US)")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 1.341022);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "KiloWatts" && ComToPOW.SelectedItem == "Foot_Pounds/Minute")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 44253.73);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "KiloWatts" && ComToPOW.SelectedItem == "BTUs/Minute")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 56.86902);
                        txtOutPutPOW = txtOutPutPOW;
                    }


                    //*************************************************************************************************
                    if (comFromPOW.SelectedItem == "HorsePower (US)" && ComToPOW.SelectedItem == "Watts")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 745.6999);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "HorsePower (US)" && ComToPOW.SelectedItem == "KiloWatts")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 0.7457);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "HorsePower (US)" && ComToPOW.SelectedItem == "Foot_Pounds/Minute")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 33000);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "HorsePower (US)" && ComToPOW.SelectedItem == "BTUs/Minute")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 42.40722);
                        txtOutPutPOW = txtOutPutPOW;
                    }


                    //****************************************************************************************************
                    if (comFromPOW.SelectedItem == "Foot_Pounds/Minute" && ComToPOW.SelectedItem == "Watts")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 0.022597);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "Foot_Pounds/Minute" && ComToPOW.SelectedItem == "KiloWatts")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 0.000023);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "Foot_Pounds/Minute" && ComToPOW.SelectedItem == "HorsePower (US)")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 0.00003);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "Foot_Pounds/Minute" && ComToPOW.SelectedItem == "BTUs/Minute")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 0.001285);
                        txtOutPutPOW = txtOutPutPOW;
                    }


                    //*************************************************************************************************
                    if (comFromPOW.SelectedItem == "BTUs/Minute" && ComToPOW.SelectedItem == "Watts")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 17.58427);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "BTUs/Minute" && ComToPOW.SelectedItem == "KiloWatts")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 0.017584);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "BTUs/Minute" && ComToPOW.SelectedItem == "HorsePower (US)")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 0.023581);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                    if (comFromPOW.SelectedItem == "BTUs/Minute" && ComToPOW.SelectedItem == "Foot_Pounds/Minute")
                    {
                        txtOutPutPOW.Text = Convert.ToString(Convert.ToDouble(txtAmountPOW.Text) * 778.1694);
                        txtOutPutPOW = txtOutPutPOW;
                    }
                }
            }
        }

        private void btnStandardToPower_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void Power_Load(object sender, EventArgs e)
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
