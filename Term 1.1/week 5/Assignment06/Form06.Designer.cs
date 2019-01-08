namespace Assignment06
{
    partial class Form06
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
<<<<<<< HEAD
            this.lblFinalCap = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFinalCap
            // 
            this.lblFinalCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalCap.Location = new System.Drawing.Point(111, 133);
            this.lblFinalCap.Name = "lblFinalCap";
            this.lblFinalCap.Size = new System.Drawing.Size(100, 18);
            this.lblFinalCap.TabIndex = 9;
            this.lblFinalCap.TextAlign = System.Drawing.ContentAlignment.TopRight;
=======
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblContentBefore = new System.Windows.Forms.Label();
            this.lblContentAfter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComparison = new System.Windows.Forms.TextBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Content table (before)";
>>>>>>> programming-week5/master
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Final capital";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 74);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(196, 28);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "&Calculate final capital";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(111, 17);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(100, 20);
            this.txtStart.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start amount";
=======
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(180, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Content table (after)";
            // 
            // lblContentBefore
            // 
            this.lblContentBefore.AutoSize = true;
            this.lblContentBefore.Location = new System.Drawing.Point(12, 53);
            this.lblContentBefore.Name = "lblContentBefore";
            this.lblContentBefore.Size = new System.Drawing.Size(0, 13);
            this.lblContentBefore.TabIndex = 2;
            // 
            // lblContentAfter
            // 
            this.lblContentAfter.AutoSize = true;
            this.lblContentAfter.Location = new System.Drawing.Point(180, 53);
            this.lblContentAfter.Name = "lblContentAfter";
            this.lblContentAfter.Size = new System.Drawing.Size(16, 13);
            this.lblContentAfter.TabIndex = 3;
            this.lblContentAfter.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Comparison number";
            // 
            // txtComparison
            // 
            this.txtComparison.Location = new System.Drawing.Point(138, 333);
            this.txtComparison.Name = "txtComparison";
            this.txtComparison.Size = new System.Drawing.Size(51, 20);
            this.txtComparison.TabIndex = 5;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(208, 331);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 6;
            this.btnCompare.Text = "&Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
>>>>>>> programming-week5/master
            // 
            // Form06
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(254, 184);
            this.Controls.Add(this.lblFinalCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.label1);
            this.Name = "Form06";
            this.Text = "Iteration assignment 6";
=======
            this.ClientSize = new System.Drawing.Size(326, 369);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txtComparison);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblContentAfter);
            this.Controls.Add(this.lblContentBefore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form06";
            this.Text = "Arrays assignemnt 6";
            this.Load += new System.EventHandler(this.Form1_Load);
>>>>>>> programming-week5/master
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

<<<<<<< HEAD
        private System.Windows.Forms.Label lblFinalCap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.Label label1;
=======
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblContentBefore;
        private System.Windows.Forms.Label lblContentAfter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComparison;
        private System.Windows.Forms.Button btnCompare;
>>>>>>> programming-week5/master
    }
}

