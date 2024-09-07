namespace BMI_Calculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKg = new System.Windows.Forms.Label();
            this.lblCm = new System.Windows.Forms.Label();
            this.nmkg = new System.Windows.Forms.NumericUpDown();
            this.nmCm = new System.Windows.Forms.NumericUpDown();
            this.lblNotice = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmkg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCm)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKg);
            this.groupBox1.Controls.Add(this.lblCm);
            this.groupBox1.Controls.Add(this.nmkg);
            this.groupBox1.Controls.Add(this.nmCm);
            this.groupBox1.Controls.Add(this.lblNotice);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.lblWeight);
            this.groupBox1.Controls.Add(this.lblHeight);
            this.groupBox1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculater BMI";
            // 
            // lblKg
            // 
            this.lblKg.Location = new System.Drawing.Point(265, 78);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(34, 27);
            this.lblKg.TabIndex = 9;
            this.lblKg.Text = "kg";
            this.lblKg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCm
            // 
            this.lblCm.Location = new System.Drawing.Point(265, 43);
            this.lblCm.Name = "lblCm";
            this.lblCm.Size = new System.Drawing.Size(34, 27);
            this.lblCm.TabIndex = 8;
            this.lblCm.Text = "cm";
            this.lblCm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nmkg
            // 
            this.nmkg.Location = new System.Drawing.Point(197, 76);
            this.nmkg.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmkg.Name = "nmkg";
            this.nmkg.Size = new System.Drawing.Size(62, 29);
            this.nmkg.TabIndex = 7;
            // 
            // nmCm
            // 
            this.nmCm.Location = new System.Drawing.Point(197, 41);
            this.nmCm.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmCm.Name = "nmCm";
            this.nmCm.Size = new System.Drawing.Size(62, 29);
            this.nmCm.TabIndex = 6;
            // 
            // lblNotice
            // 
            this.lblNotice.BackColor = System.Drawing.Color.LightGreen;
            this.lblNotice.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotice.ForeColor = System.Drawing.Color.White;
            this.lblNotice.Location = new System.Drawing.Point(24, 121);
            this.lblNotice.Name = "lblNotice";
            this.lblNotice.Size = new System.Drawing.Size(655, 40);
            this.lblNotice.TabIndex = 5;
            this.lblNotice.Text = "Your weight is  ...";
            this.lblNotice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(334, 43);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(126, 56);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.LightGray;
            this.lblResult.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(477, 43);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(202, 56);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Your BMI is 0.00";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWeight
            // 
            this.lblWeight.Location = new System.Drawing.Point(19, 79);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(158, 29);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "Select Your Weight";
            // 
            // lblHeight
            // 
            this.lblHeight.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeight.Location = new System.Drawing.Point(19, 41);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(158, 29);
            this.lblHeight.TabIndex = 0;
            this.lblHeight.Text = "Select Your height";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(695, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculate Body Mass Index";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 260);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(692, 292);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "BMI Legend";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BMI_Calculator.Properties.Resources.bmi_legend;
            this.pictureBox1.Location = new System.Drawing.Point(10, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(676, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 564);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BMI Calculater";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmkg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCm)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNotice;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nmkg;
        private System.Windows.Forms.NumericUpDown nmCm;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Label lblCm;
    }
}

