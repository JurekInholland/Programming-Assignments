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
            this.lblThrows = new System.Windows.Forms.Label();
            this.btnThrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblThrows
            // 
            this.lblThrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThrows.Location = new System.Drawing.Point(25, 22);
            this.lblThrows.Name = "lblThrows";
            this.lblThrows.Size = new System.Drawing.Size(310, 137);
            this.lblThrows.TabIndex = 0;
            // 
            // btnThrow
            // 
            this.btnThrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThrow.Location = new System.Drawing.Point(117, 162);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(116, 35);
            this.btnThrow.TabIndex = 1;
            this.btnThrow.Text = "&Throw";
            this.btnThrow.UseVisualStyleBackColor = true;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // Form07
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 201);
            this.Controls.Add(this.btnThrow);
            this.Controls.Add(this.lblThrows);
            this.Name = "Form07";
            this.Text = "Arrays assignment 7";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblThrows;
        private System.Windows.Forms.Button btnThrow;
    }
}

