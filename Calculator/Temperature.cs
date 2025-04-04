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
    public partial class Temperature : Form
    {
        bool enter_value=false;
        double Icelsius, Ifarenheit, Ikevin, q, p;
        public Temperature()
        {
            InitializeComponent();
        }

        private void Number_Temperature(object sender, EventArgs e)
        {
            Button tempButton = (Button)sender;
            if (LblTemp.Text == "0")
            {
                LblTemp.Text = "";

            }
            if (tempButton.Text == ".")
            {
                if (!LblTemp.Text.Contains("."))
                    LblTemp.Text = LblTemp.Text + tempButton.Text;
            }
            else
            {
                LblTemp.Text = LblTemp.Text + tempButton.Text;
            }

            treeView1.Visible = false;
            //*******************************************************************************
            CalTemp();
            Tempreture();
            //*******************************************************************************
        }

        private void btnBackSpace_click_Click(object sender, EventArgs e)
        {
            if (LblTemp.Text.Length>0)
            {
                LblTemp.Text = LblTemp.Text.Remove(LblTemp.Text.Length - 1, 1);
            }

            if (LblTemp.Text=="")
            {
                LblTemp.Text = "0";
            }
            //*******************************************************************************
            CalTemp();
            Tempreture();
            //*******************************************************************************
        }

        private void combTemp_SelectedIndexChanged(object sender, EventArgs e)
        {
            //*******************************************************************************
            CalTemp();
            Tempreture();
            //*******************************************************************************
        }

        private void comboConvert_SelectedIndexChanged(object sender, EventArgs e)
        {
            //*******************************************************************************
            CalTemp();
            Tempreture();
            //*******************************************************************************
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            LblTemp.Text="0";
            //*******************************************************************************
            CalTemp();
            Tempreture();
            //*******************************************************************************
        }

        private void btnStandardToTem_Click(object sender, EventArgs e)
        {
            Form1 F1 = new Form1();
            F1.Show();
            this.Hide();
        }

        private void LblTemp_Click(object sender, EventArgs e)
        {

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

        private void CalTemp()
        {
            if (combTemp.Text == "Celsius")
            {
                Icelsius = double.Parse(LblTemp.Text);
                lblConvert.Text = (Math.Round((((9 - Icelsius) / 5) + 32), 2).ToString());
            }

            else if (combTemp.Text == "Fahrenheit")
            {
                Ifarenheit = double.Parse(LblTemp.Text);
                lblConvert.Text = (Math.Round((((Ifarenheit - 32) * 5) / 9), 2).ToString());
            }
            else if (combTemp.Text == "Kevin")
            {
                Ikevin = double.Parse(LblTemp.Text);
                lblConvert.Text = (Math.Round((((9 * Ikevin) / 5) + 32) + 273.15), 2).ToString();
            }
       
        }
        //*******************************************************************************

        private void Tempreture() 
        {
            double temValue = double.Parse(lblConvert.Text);
            if ((combTemp.Text == "Fahrenheit") && (comboConvert.Text == "Fahrenheit"))
            {
                q = ((((Icelsius - 32) / 1.8) + 32) + 273.15);
                p = (((Ifarenheit - 32) * 5 / 9) + 273.15);
                q = Math.Round(q, 2);
                p = Math.Round(q, 2);
                lblDiff.Text = q.ToString() + " C" + "            " + (p.ToString()) + "K";
            }


            else if ((combTemp.Text == "Celsius") && (comboConvert.Text == "Celsius"))
            {
                lblDiff.Text = (((9 * Icelsius) / 5) + 32) + "F" + "            " + (Icelsius + 273.15) + "K";
            }


            else if ((combTemp.Text == "Celsius") && (comboConvert.Text == "Kevin"))
            {
                lblDiff.Text = Math.Round((Icelsius + 273.15), 2).ToString() + "F";
            }
            else if ((combTemp.Text == "Kevin") && (comboConvert.Text == "Celsius"))
            {
                lblDiff.Text = Math.Round((9/5 *(Ikevin-273) + 32), 2).ToString() + "F";
            }


            else if ((combTemp.Text == "Fahrenhit") && (comboConvert.Text == "Celsius"))
            {
                lblDiff.Text = Math.Round((temValue+273.15), 2).ToString() + "K";

            }

            else if ((combTemp.Text == "Fahrenhit") && (comboConvert.Text == "Celsius"))
            {
                lblDiff.Text = Math.Round((temValue + 273.15), 2).ToString() + "F";
            }
            else if ((combTemp.Text == "Fahrenhit") && (comboConvert.Text == "Celsius"))
            {
                lblDiff.Text = Math.Round(((temValue - 32)/1.8), 2).ToString() + "C";
            }
        }   
            //*******************************************************************************

        private void btnPM_Click_Click(object sender, EventArgs e)
        {
            if (LblTemp.Text.Contains("-"))
            {
                LblTemp.Text = LblTemp.Text.Remove(0, 1);
            }
            else
            {
                LblTemp.Text = LblTemp.Text+"-";
            }
            //*******************************************************************************
            CalTemp();
            Tempreture();
            //*******************************************************************************
        }

        private void Temperature_Load(object sender, EventArgs e)
        {
            combTemp.Text = ("Fahrenheit");
            combTemp.Items.Add("Celsius");
            combTemp.Items.Add("Fahrenheit");
            combTemp.Items.Add("Kevin");


            comboConvert.Text=("Celsius");
            comboConvert.Items.Add("Celsius");
            comboConvert.Items.Add("Fahrenheit");
            comboConvert.Items.Add("Kevin");


            treeView1.Visible = false;
            //*******************************************************************************
            CalTemp();
            Tempreture();
            //*******************************************************************************
        }
    }
}
