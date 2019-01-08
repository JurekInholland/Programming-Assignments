namespace Assignment08
{
    partial class Form08
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
            this.lblEqualCheck = new System.Windows.Forms.Label();
            this.lblFormula = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEqualCheck
            // 
            this.lblEqualCheck.AutoSize = true;
            this.lblEqualCheck.Location = new System.Drawing.Point(12, 193);
            this.lblEqualCheck.Name = "lblEqualCheck";
            this.lblEqualCheck.Size = new System.Drawing.Size(0, 13);
            this.lblEqualCheck.TabIndex = 15;
            // 
            // lblFormula
            // 
            this.lblFormula.Location = new System.Drawing.Point(139, 158);
            this.lblFormula.Name = "lblFormula";
            this.lblFormula.Size = new System.Drawing.Size(91, 19);
            this.lblFormula.TabIndex = 14;
            this.lblFormula.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "sum = n * (n + 1) / 2";
            // 
            // lblSum
            // 
            this.lblSum.Location = new System.Drawing.Point(139, 120);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(91, 19);
            this.lblSum.TabIndex = 12;
            this.lblSum.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "sum = 1 + 2+ ... + n";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(130, 6);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Enter a number (n)";
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(15, 47);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(215, 29);
            this.btnCompare.TabIndex = 8;
            this.btnCompare.Text = "&Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.BtnCompare_Click);
            // 
            // Form08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 256);
            this.Controls.Add(this.lblEqualCheck);
            this.Controls.Add(this.lblFormula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCompare);
            this.Name = "Form08";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEqualCheck;
        private System.Windows.Forms.Label lblFormula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompare;
    }
}

