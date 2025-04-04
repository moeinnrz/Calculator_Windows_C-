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
    public partial class Angle : Form
    {
        public Angle()
        {
            InitializeComponent();
        }

        private void btnNumberClick_ANG(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (txtAmountANG.Text == "0")
            {
                txtAmountANG.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!txtAmountANG.Text.Contains("."))
                    txtAmountANG.Text = txtAmountANG.Text + tempButton.Text;
            }
            else
            {
                txtAmountANG.Text = txtAmountANG.Text + tempButton.Text;
            }
            treeView1.Visible = false;
        }

        private void btnCEpANG_Click(object sender, EventArgs e)
        {
            txtAmountANG.Text = "0";
            txtOutPutANG.Text = "0";
        }

        private void btnBackSpaceANG_Click(object sender, EventArgs e)
        {
            if (txtAmountANG.Text.Length > 0)
            {
                txtAmountANG.Text.Remove(txtAmountANG.Text.Length - 1, 1);
            }

            if (txtAmountANG.Text == "")
            {
                txtAmountANG.Text = "0";
            }
        }

        private void btnPMANG_Click(object sender, EventArgs e)
        {
            if (txtAmountANG.Text.Contains("-"))
            {
                txtAmountANG.Text = txtAmountANG.Text.Remove(0, 1);
            }
            else
            {
                txtAmountANG.Text = txtAmountANG.Text + "-";
            }
        }

        private void btnConvertANG_Click(object sender, EventArgs e)
        {
            if (comFromANG.Text == "SElect Unit" || ComToANG.Text == "Select Unit")
            {
                MessageBox.Show("Please Select Unit Fo COnvertor");
            }
            else
            {

                //*******************************************************************************
                if (comFromANG.SelectedItem == "Degrees" && ComToANG.SelectedItem == "Radians")
                {
                    txtOutPutANG.Text = Convert.ToString(Convert.ToDouble(txtAmountANG.Text) * 0.017453);
                    txtOutPutANG = txtOutPutANG;
                }
                if (comFromANG.SelectedItem == "Degrees" && ComToANG.SelectedItem == "Gradians")
                {
                    txtOutPutANG.Text = Convert.ToString(Convert.ToDouble(txtAmountANG.Text) * 1.111111);
                    txtOutPutANG = txtOutPutANG;
                }


                //*******************************************************************************
                if (comFromANG.SelectedItem == "Radians" && ComToANG.SelectedItem == "Degrees")
                {
                    txtOutPutANG.Text = Convert.ToString(Convert.ToDouble(txtAmountANG.Text) * 57.29578);
                    txtOutPutANG = txtOutPutANG;
                }
                if (comFromANG.SelectedItem == "Radians" && ComToANG.SelectedItem == "Gradians")
                {
                    txtOutPutANG.Text = Convert.ToString(Convert.ToDouble(txtAmountANG.Text) * 63.66198);
                    txtOutPutANG = txtOutPutANG;
                }


                //*******************************************************************************
                if (comFromANG.SelectedItem == "Gradians" && ComToANG.SelectedItem == "Degrees")
                {
                    txtOutPutANG.Text = Convert.ToString(Convert.ToDouble(txtAmountANG.Text) * 0.9);
                    txtOutPutANG = txtOutPutANG;
                }
                if (comFromANG.SelectedItem == "Gradians" && ComToANG.SelectedItem == "Radians")
                {
                    txtOutPutANG.Text = Convert.ToString(Convert.ToDouble(txtAmountANG.Text) * 0.015708);
                    txtOutPutANG = txtOutPutANG;
                }
            }
        }

        private void Angle_Load(object sender, EventArgs e)
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
