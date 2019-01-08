namespace Assignment_14
{
    partial class A14
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lblHealthyWeight = new System.Windows.Forms.Label();
            this.lblNormalBmi = new System.Windows.Forms.Label();
            this.lblBmi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFemale = new System.Windows.Forms.Button();
            this.btnMale = new System.Windows.Forms.Button();
            this.grpInput.SuspendLayout();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.label2);
            this.grpInput.Controls.Add(this.txtWeight);
            this.grpInput.Controls.Add(this.txtLength);
            this.grpInput.Controls.Add(this.label1);
            this.grpInput.Location = new System.Drawing.Point(6, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(233, 80);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weight (kg)";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(108, 42);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 20);
            this.txtWeight.TabIndex = 2;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(108, 16);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length (cm)";
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lblHealthyWeight);
            this.grpOutput.Controls.Add(this.lblNormalBmi);
            this.grpOutput.Controls.Add(this.lblBmi);
            this.grpOutput.Controls.Add(this.label5);
            this.grpOutput.Controls.Add(this.label4);
            this.grpOutput.Controls.Add(this.label3);
            this.grpOutput.Location = new System.Drawing.Point(6, 107);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(233, 98);
            this.grpOutput.TabIndex = 1;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // lblHealthyWeight
            // 
            this.lblHealthyWeight.Location = new System.Drawing.Point(131, 75);
            this.lblHealthyWeight.Name = "lblHealthyWeight";
            this.lblHealthyWeight.Size = new System.Drawing.Size(62, 13);
            this.lblHealthyWeight.TabIndex = 9;
            // 
            // lblNormalBmi
            // 
            this.lblNormalBmi.Location = new System.Drawing.Point(130, 50);
            this.lblNormalBmi.Name = "lblNormalBmi";
            this.lblNormalBmi.Size = new System.Drawing.Size(62, 13);
            this.lblNormalBmi.TabIndex = 8;
            // 
            // lblBmi
            // 
            this.lblBmi.Location = new System.Drawing.Point(131, 25);
            this.lblBmi.Name = "lblBmi";
            this.lblBmi.Size = new System.Drawing.Size(62, 13);
            this.lblBmi.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Healthy weight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Normal BMI values";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "BMI";
            // 
            // btnFemale
            // 
            this.btnFemale.BackgroundImage = global::Assignment_14.Properties.Resources._80818;
            this.btnFemale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFemale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFemale.Location = new System.Drawing.Point(140, 224);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(99, 131);
            this.btnFemale.TabIndex = 4;
            this.btnFemale.Text = "Calculate &Female";
            this.btnFemale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFemale.UseVisualStyleBackColor = true;
            this.btnFemale.Click += new System.EventHandler(this.btnFemale_Click);
            // 
            // btnMale
            // 
            this.btnMale.BackgroundImage = global::Assignment_14.Properties.Resources.patient_clipart;
            this.btnMale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMale.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMale.Location = new System.Drawing.Point(6, 224);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(99, 131);
            this.btnMale.TabIndex = 3;
            this.btnMale.Text = "Calculate &Male";
            this.btnMale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMale.UseVisualStyleBackColor = true;
            this.btnMale.Click += new System.EventHandler(this.btnMale_Click);
            // 
            // A14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 366);
            this.Controls.Add(this.btnFemale);
            this.Controls.Add(this.btnMale);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.grpInput);
            this.Name = "A14";
            this.Text = "Selection assignment 14";
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Button btnMale;
        private System.Windows.Forms.Button btnFemale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHealthyWeight;
        private System.Windows.Forms.Label lblNormalBmi;
        private System.Windows.Forms.Label lblBmi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

