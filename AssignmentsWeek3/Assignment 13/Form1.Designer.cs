namespace Assignment_13
{
    partial class assignment13
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
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRefuel = new System.Windows.Forms.CheckBox();
            this.txtKms = new System.Windows.Forms.TextBox();
            this.txtLitres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRentalPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of rental days";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(186, 12);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 20);
            this.txtDays.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 148);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(271, 33);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "&Calculate Rental Price";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Number of kms";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of litres tanked";
            // 
            // cbRefuel
            // 
            this.cbRefuel.AutoSize = true;
            this.cbRefuel.Location = new System.Drawing.Point(12, 79);
            this.cbRefuel.Name = "cbRefuel";
            this.cbRefuel.Size = new System.Drawing.Size(156, 17);
            this.cbRefuel.TabIndex = 6;
            this.cbRefuel.Text = "Refuel on account of renter";
            this.cbRefuel.UseVisualStyleBackColor = true;
            // 
            // txtKms
            // 
            this.txtKms.Location = new System.Drawing.Point(186, 44);
            this.txtKms.Name = "txtKms";
            this.txtKms.Size = new System.Drawing.Size(100, 20);
            this.txtKms.TabIndex = 7;
            // 
            // txtLitres
            // 
            this.txtLitres.Location = new System.Drawing.Point(186, 112);
            this.txtLitres.Name = "txtLitres";
            this.txtLitres.Size = new System.Drawing.Size(100, 20);
            this.txtLitres.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rental price";
            // 
            // lblRentalPrice
            // 
            this.lblRentalPrice.AutoSize = true;
            this.lblRentalPrice.Location = new System.Drawing.Point(183, 210);
            this.lblRentalPrice.Name = "lblRentalPrice";
            this.lblRentalPrice.Size = new System.Drawing.Size(0, 13);
            this.lblRentalPrice.TabIndex = 10;
            // 
            // assignment13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 242);
            this.Controls.Add(this.lblRentalPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLitres);
            this.Controls.Add(this.txtKms);
            this.Controls.Add(this.cbRefuel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.label1);
            this.Name = "assignment13";
            this.Text = "Selection assignment 13";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbRefuel;
        private System.Windows.Forms.TextBox txtKms;
        private System.Windows.Forms.TextBox txtLitres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRentalPrice;
    }
}

