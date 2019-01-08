namespace Assignment_11
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
            this.txtNr1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNr2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDifference = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1:";
            // 
            // txtNr1
            // 
            this.txtNr1.Location = new System.Drawing.Point(135, 21);
            this.txtNr1.Name = "txtNr1";
            this.txtNr1.Size = new System.Drawing.Size(100, 20);
            this.txtNr1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNr2
            // 
            this.txtNr2.Location = new System.Drawing.Point(135, 47);
            this.txtNr2.Name = "txtNr2";
            this.txtNr2.Size = new System.Drawing.Size(100, 20);
            this.txtNr2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Highest number:";
            // 
            // lblNumber
            // 
            this.lblNumber.Location = new System.Drawing.Point(132, 136);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(35, 13);
            this.lblNumber.TabIndex = 6;
            // 
            // lblAverage
            // 
            this.lblAverage.Location = new System.Drawing.Point(132, 162);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(35, 13);
            this.lblAverage.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Average:";
            // 
            // lblDifference
            // 
            this.lblDifference.Location = new System.Drawing.Point(132, 188);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(35, 13);
            this.lblDifference.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Difference:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 232);
            this.Controls.Add(this.lblDifference);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNr2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNr1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Selection assignment 11";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNr1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNr2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDifference;
        private System.Windows.Forms.Label label8;
    }
}

