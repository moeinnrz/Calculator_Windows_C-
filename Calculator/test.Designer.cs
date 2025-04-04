namespace ماشین_حسابی
{
    partial class test
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtOutPut = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.comFrom = new System.Windows.Forms.ComboBox();
            this.ComTO = new System.Windows.Forms.ComboBox();
            this.LblOutPut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(291, 31);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "=";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtOutPut
            // 
            this.txtOutPut.Location = new System.Drawing.Point(384, 12);
            this.txtOutPut.Multiline = true;
            this.txtOutPut.Name = "txtOutPut";
            this.txtOutPut.Size = new System.Drawing.Size(100, 67);
            this.txtOutPut.TabIndex = 1;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(31, 12);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(100, 42);
            this.txtAmount.TabIndex = 1;
            // 
            // comFrom
            // 
            this.comFrom.FormattingEnabled = true;
            this.comFrom.Items.AddRange(new object[] {
            "Centimeters",
            "Meters",
            "Kilometers",
            "Inches",
            "Feet"});
            this.comFrom.Location = new System.Drawing.Point(31, 100);
            this.comFrom.Name = "comFrom";
            this.comFrom.Size = new System.Drawing.Size(83, 21);
            this.comFrom.TabIndex = 2;
            // 
            // ComTO
            // 
            this.ComTO.FormattingEnabled = true;
            this.ComTO.Items.AddRange(new object[] {
            "Centimeters",
            "Meters",
            "Kilometers",
            "Inches",
            "Feet"});
            this.ComTO.Location = new System.Drawing.Point(31, 171);
            this.ComTO.Name = "ComTO";
            this.ComTO.Size = new System.Drawing.Size(83, 21);
            this.ComTO.TabIndex = 2;
            // 
            // LblOutPut
            // 
            this.LblOutPut.AutoSize = true;
            this.LblOutPut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOutPut.Location = new System.Drawing.Point(401, 95);
            this.LblOutPut.Name = "LblOutPut";
            this.LblOutPut.Size = new System.Drawing.Size(0, 24);
            this.LblOutPut.TabIndex = 3;
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblOutPut);
            this.Controls.Add(this.ComTO);
            this.Controls.Add(this.comFrom);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtOutPut);
            this.Controls.Add(this.btnConvert);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtOutPut;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox comFrom;
        private System.Windows.Forms.ComboBox ComTO;
        private System.Windows.Forms.Label LblOutPut;
    }
}