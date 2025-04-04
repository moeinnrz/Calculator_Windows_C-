using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ماشین_حسابی
{
    public partial class Scientific : Form
    {
        double num1Sci = 0;
        char op;
        double results = 0;
        string operation = "";
        bool enter_value = false;
        char iOperation;
        double iCelsius = 0;
        double iFahrenhit = 0;
        double iKevin = 0;
        public Scientific()
        {
            InitializeComponent();
        }

        private void numberScientifickBtnClick(object sender, EventArgs e)
        {
            if (txtScreenSci.Text == "0")
                txtScreenSci.Text = ((Button)sender).Text;
            else
                txtScreenSci.Text += ((Button)sender).Text;
            treeView1.Visible = false;

        }

        private void btnInverseSci_Click(object sender, EventArgs e)
        {
            num1Sci = Convert.ToDouble(txtScreenSci.Text);
            num1Sci = 1 / num1Sci;
            txtScreenSci.Text = num1Sci.ToString();
        }

        private void bynSquareSci_Click(object sender, EventArgs e)
        {
            num1Sci = Convert.ToDouble(txtScreenSci.Text);
            num1Sci = Math.Sqrt(num1Sci);
            txtScreenSci.Text = num1Sci.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtScreenSci.Text = "0";
        }

        private void btnBackSpaceSci_Click(object sender, EventArgs e)
        {
            txtScreenSci.Text = txtScreenSci.Text.Remove(txtScreenSci.Text.Length - 1);
        }

        private void OpBtnClklick(object sender, EventArgs e)
        {
            num1Sci = Convert.ToDouble(txtScreenSci.Text);
            op = Convert.ToChar(((Button)sender).Text);
            txtScreenSci.Text = "0";
        }

        private void btnEqualsClick(object sender, EventArgs e)
        {
            double num2 = 0;
            num2 = Convert.ToDouble(txtScreenSci.Text);
            switch (op)
            {
                case '+':
                    num1Sci = num1Sci + num2;
                    break;
                case '-':
                    num1Sci = num1Sci - num2;
                    break;
                case '×':
                    num1Sci = num1Sci * num2;
                    break;
                case '÷':
                    num1Sci = num1Sci / num2;
                    break;
            }
            txtScreenSci.Text = num1Sci.ToString();
        }

        private void btnNumberPI_Click(object sender, EventArgs e)
        {
            txtScreenSci.Text = "3.1415926535897932384626433832795";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double Ilog = double.Parse(txtScreenSci.Text);
            Ilog = Math.Log10(Ilog);
            txtScreenSci.Text = System.Convert.ToString(Ilog);
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            double sq = double.Parse(txtScreenSci.Text);
            sq = Math.Sqrt(sq);
            txtScreenSci.Text = System.Convert.ToString(sq);
        }

        private void btnSinch_Click(object sender, EventArgs e)
        {
            double SInch = double.Parse(txtScreenSci.Text);
            SInch = Math.Sinh(SInch);
            txtScreenSci.Text = System.Convert.ToString(SInch);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double SIn = double.Parse(txtScreenSci.Text);
            SIn = Math.Sin(SIn);
            txtScreenSci.Text = System.Convert.ToString(SIn);
        }

        private void btnCosh_Click(object sender, EventArgs e)
        {
            double Cosh = double.Parse(txtScreenSci.Text);
            
            Cosh = Math.Cosh(Cosh);
            txtScreenSci.Text = System.Convert.ToString(Cosh);
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            double Cos = double.Parse(txtScreenSci.Text);
            
            Cos = Math.Cos(Cos);
            txtScreenSci.Text = System.Convert.ToString(Cos);
        }

        private void btnTenh_Click(object sender, EventArgs e)
        {
            double Tenh = double.Parse(txtScreenSci.Text);
            Tenh = Math.Tanh(Tenh);
            txtScreenSci.Text = System.Convert.ToString(Tenh);
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            double Ten = double.Parse(txtScreenSci.Text);
            Ten = Math.Tan(Ten);
            txtScreenSci.Text = System.Convert.ToString(Ten);
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            int b = int.Parse(txtScreenSci.Text);
            txtScreenSci.Text = System.Convert.ToString(b);
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            int b = int.Parse(txtScreenSci.Text);
            txtScreenSci.Text = System.Convert.ToString(b);
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            int b = int.Parse(txtScreenSci.Text);
            txtScreenSci.Text = System.Convert.ToString(b, 16);
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            int b = int.Parse(txtScreenSci.Text);
            txtScreenSci.Text = System.Convert.ToString(b, 8);
        }

        private void btnX2_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtScreenSci.Text) * Convert.ToDouble(txtScreenSci.Text);
            txtScreenSci.Text = System.Convert.ToString(a);
        }

        private void btnX3_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtScreenSci.Text) * Convert.ToDouble(txtScreenSci.Text) * Convert.ToDouble(txtScreenSci.Text);
            txtScreenSci.Text = System.Convert.ToString(a);
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            double ilog = double.Parse(txtScreenSci.Text);
            ilog = Math.Log(ilog);
            txtScreenSci.Text = System.Convert.ToString(ilog);
        }

        private void btnDarsad_Click(object sender, EventArgs e)
        {
            double a;
            a = Convert.ToDouble(txtScreenSci.Text) / Convert.ToDouble(100);
            txtScreenSci.Text = System.Convert.ToString(a);
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            double exp = double.Parse(txtScreenSci.Text);
            exp = Math.Exp(exp);
            txtScreenSci.Text = System.Convert.ToString(exp);
        }

        private void btnStandardToSci_Click(object sender, EventArgs e)
        {
            Form1 F1=new Form1();
            F1.Show();
            this.Hide();
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            treeView1.Visible = true;

        }

        private void Scientific_Load(object sender, EventArgs e)
        {
            treeView1.Visible = false;
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
