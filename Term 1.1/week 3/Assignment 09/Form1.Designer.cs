namespace Assignment_9
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbFootball = new System.Windows.Forms.RadioButton();
            this.rdbHandball = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFee = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sport";
            // 
            // rdbFootball
            // 
            this.rdbFootball.AutoSize = true;
            this.rdbFootball.Location = new System.Drawing.Point(202, 24);
            this.rdbFootball.Name = "rdbFootball";
            this.rdbFootball.Size = new System.Drawing.Size(62, 17);
            this.rdbFootball.TabIndex = 1;
            this.rdbFootball.TabStop = true;
            this.rdbFootball.Text = "Football";
            this.rdbFootball.UseVisualStyleBackColor = true;
            this.rdbFootball.CheckedChanged += new System.EventHandler(this.rdbFootball_CheckedChanged);
            // 
            // rdbHandball
            // 
            this.rdbHandball.AutoSize = true;
            this.rdbHandball.Location = new System.Drawing.Point(202, 47);
            this.rdbHandball.Name = "rdbHandball";
            this.rdbHandball.Size = new System.Drawing.Size(67, 17);
            this.rdbHandball.TabIndex = 2;
            this.rdbHandball.TabStop = true;
            this.rdbHandball.Text = "Handball";
            this.rdbHandball.UseVisualStyleBackColor = true;
            this.rdbHandball.CheckedChanged += new System.EventHandler(this.rdbHandball_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(202, 89);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 20);
            this.txtAge.TabIndex = 4;
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(202, 115);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 20);
            this.txtDuration.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Membership duration";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(13, 160);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(289, 41);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "&Calculate Fee";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fee to be paid";
            // 
            // lblFee
            // 
            this.lblFee.AutoSize = true;
            this.lblFee.Location = new System.Drawing.Point(199, 217);
            this.lblFee.Name = "lblFee";
            this.lblFee.Size = new System.Drawing.Size(0, 13);
            this.lblFee.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 263);
            this.Controls.Add(this.lblFee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdbHandball);
            this.Controls.Add(this.rdbFootball);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Selection assignment 9";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbFootball;
        private System.Windows.Forms.RadioButton rdbHandball;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblFee;
    }
}

