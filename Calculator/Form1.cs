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
    public partial class Form1 : Form
    {
        double num1 = 0;
        char op;
        public Form1()
        {
            InitializeComponent();
        }

        private void numberBtnClick(object sender, EventArgs e)
        {
            //txtscreen.Text += ((Button)sender).Text;


            if (txtscreen.Text == "0")
                txtscreen.Text = ((Button)sender).Text;
            else
                txtscreen.Text += ((Button)sender).Text;
            treeView1.Visible = false;
            groupBox1.Visible = false;
        }
        //17
        private void btnInverse_Click(object sender, EventArgs e)
        {
            num1=Convert.ToDouble(txtscreen.Text);
            num1 = 1 / num1;
            txtscreen.Text=num1.ToString();
        }
        //18
        private void btnSquare_Click(object sender, EventArgs e)
        {
            num1= Convert.ToDouble(txtscreen.Text);
            num1 = Math.Sqrt(num1);
            txtscreen.Text=num1.ToString();
        }
        //22
        private void btnC_Click(object sender, EventArgs e)
        {
            txtscreen.Text = "0";
        }
        //24
        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            txtscreen.Text = txtscreen.Text.Remove(txtscreen.Text.Length - 1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeView1.Visible = false;
            groupBox1.Visible = false;
        }
        //op
        private void OpBtnClklick(object sender, EventArgs e)
        {
            num1=Convert.ToDouble(txtscreen.Text);
            op = Convert.ToChar(((Button)sender).Text);
            txtscreen.Text = "0";
        }
        //16
        private void btnEqualsClick(object sender, EventArgs e)
        {
            double num2 = 0;
            num2 = Convert.ToDouble(txtscreen.Text);
            switch (op)
            {
                case '+':
                    num1 = num1 + num2;
                    break;
                case '-':
                    num1 = num1 - num2;
                    break;
                case '×':
                    num1 = num1 * num2;
                    break;
                case '÷':
                    num1 = num1 / num2;
                    break;
            }
            txtscreen.Text = num1.ToString();
        }
        //توان 
        private void btnPower_Click(object sender, EventArgs e)
        {

        }

        private void btnStandard_Click(object sender, EventArgs e)
        {

        }

        private void btnScientific_Click(object sender, EventArgs e)
        {
            Scientific scientific = new Scientific();
            scientific.Show();
            this.Hide();
        }

        private void btnSpeed_Click(object sender, EventArgs e)
        {

        }

        private void btnTime_Click(object sender, EventArgs e)
        {

        }

        private void btnDataCalculation_Click(object sender, EventArgs e)
        {
            Data_Calculation data = new Data_Calculation();
            data.Show();
            this.Hide();
        }

        private void btnTemperature_Click(object sender, EventArgs e)
        {
            Temperature temperature = new Temperature();
            temperature.Show();
            this.Hide();
        }

        private void btnProgrammer_Click(object sender, EventArgs e)
        {
            Programmer program = new Programmer();
            program.Show();
            this.Hide();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;
            groupBox1.Visible = true;

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

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
