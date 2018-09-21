namespace Assignment07
{
    partial class Form07
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
            this.txtSides = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblRender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Side";
            // 
            // txtSides
            // 
            this.txtSides.Location = new System.Drawing.Point(131, 46);
            this.txtSides.Name = "txtSides";
            this.txtSides.Size = new System.Drawing.Size(130, 20);
            this.txtSides.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Create square";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lblRender
            // 
            this.lblRender.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRender.Location = new System.Drawing.Point(42, 142);
            this.lblRender.Name = "lblRender";
            this.lblRender.Size = new System.Drawing.Size(226, 385);
            this.lblRender.TabIndex = 3;
            this.lblRender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 536);
            this.Controls.Add(this.lblRender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSides);
            this.Controls.Add(this.label1);
            this.Name = "Form07";
            this.Text = "Iteration assignment 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSides;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblRender;
    }
}

