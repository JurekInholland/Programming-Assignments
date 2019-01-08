namespace WindowsFormsApp1
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
            this.btnVat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNr2 = new System.Windows.Forms.TextBox();
            this.txtNr3 = new System.Windows.Forms.TextBox();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number 1:";
            // 
            // txtNr1
            // 
            this.txtNr1.Location = new System.Drawing.Point(394, 29);
            this.txtNr1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.txtNr1.Name = "txtNr1";
            this.txtNr1.Size = new System.Drawing.Size(161, 31);
            this.txtNr1.TabIndex = 1;
            // 
            // btnVat
            // 
            this.btnVat.Location = new System.Drawing.Point(17, 195);
            this.btnVat.Margin = new System.Windows.Forms.Padding(0);
            this.btnVat.Name = "btnVat";
            this.btnVat.Size = new System.Drawing.Size(538, 45);
            this.btnVat.TabIndex = 2;
            this.btnVat.Text = "Calculate average";
            this.btnVat.UseVisualStyleBackColor = true;
            this.btnVat.Click += new System.EventHandler(this.Btn_vat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Average:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Number 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number 3:";
            // 
            // txtNr2
            // 
            this.txtNr2.Location = new System.Drawing.Point(394, 69);
            this.txtNr2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.txtNr2.Name = "txtNr2";
            this.txtNr2.Size = new System.Drawing.Size(161, 31);
            this.txtNr2.TabIndex = 11;
            // 
            // txtNr3
            // 
            this.txtNr3.Location = new System.Drawing.Point(394, 114);
            this.txtNr3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.txtNr3.Name = "txtNr3";
            this.txtNr3.Size = new System.Drawing.Size(161, 31);
            this.txtNr3.TabIndex = 12;
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(389, 272);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(0, 25);
            this.lblAverage.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 441);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.txtNr3);
            this.Controls.Add(this.txtNr2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVat);
            this.Controls.Add(this.txtNr1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assignment 5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNr1;
        private System.Windows.Forms.Button btnVat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNr2;
        private System.Windows.Forms.TextBox txtNr3;
        private System.Windows.Forms.Label lblAverage;
    }
}

