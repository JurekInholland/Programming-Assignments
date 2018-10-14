namespace Assignment07
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbFahrenheitToCelsius = new System.Windows.Forms.RadioButton();
            this.rdbCelsiusToFahrenheit = new System.Windows.Forms.RadioButton();
            this.rdbCelsiusToKelvin = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Degrees";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(135, 21);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(100, 20);
            this.txtInput.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFahrenheitToCelsius);
            this.groupBox1.Controls.Add(this.rdbCelsiusToFahrenheit);
            this.groupBox1.Controls.Add(this.rdbCelsiusToKelvin);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conversion";
            // 
            // rdbFahrenheitToCelsius
            // 
            this.rdbFahrenheitToCelsius.AutoSize = true;
            this.rdbFahrenheitToCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFahrenheitToCelsius.Location = new System.Drawing.Point(15, 77);
            this.rdbFahrenheitToCelsius.Name = "rdbFahrenheitToCelsius";
            this.rdbFahrenheitToCelsius.Size = new System.Drawing.Size(159, 21);
            this.rdbFahrenheitToCelsius.TabIndex = 2;
            this.rdbFahrenheitToCelsius.Text = "Fahrenheit to Celsius";
            this.rdbFahrenheitToCelsius.UseVisualStyleBackColor = true;
            this.rdbFahrenheitToCelsius.CheckedChanged += new System.EventHandler(this.rdbFahrenheitToCelsius_CheckedChanged);
            // 
            // rdbCelsiusToFahrenheit
            // 
            this.rdbCelsiusToFahrenheit.AutoSize = true;
            this.rdbCelsiusToFahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCelsiusToFahrenheit.Location = new System.Drawing.Point(15, 54);
            this.rdbCelsiusToFahrenheit.Name = "rdbCelsiusToFahrenheit";
            this.rdbCelsiusToFahrenheit.Size = new System.Drawing.Size(159, 21);
            this.rdbCelsiusToFahrenheit.TabIndex = 1;
            this.rdbCelsiusToFahrenheit.Text = "Celsius to Fahrenheit";
            this.rdbCelsiusToFahrenheit.UseVisualStyleBackColor = true;
            this.rdbCelsiusToFahrenheit.CheckedChanged += new System.EventHandler(this.rdbCelsiusToFahrenheit_CheckedChanged);
            // 
            // rdbCelsiusToKelvin
            // 
            this.rdbCelsiusToKelvin.AutoSize = true;
            this.rdbCelsiusToKelvin.Checked = true;
            this.rdbCelsiusToKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCelsiusToKelvin.Location = new System.Drawing.Point(15, 31);
            this.rdbCelsiusToKelvin.Name = "rdbCelsiusToKelvin";
            this.rdbCelsiusToKelvin.Size = new System.Drawing.Size(129, 21);
            this.rdbCelsiusToKelvin.TabIndex = 0;
            this.rdbCelsiusToKelvin.TabStop = true;
            this.rdbCelsiusToKelvin.Text = "Celsius to Kelvin";
            this.rdbCelsiusToKelvin.UseVisualStyleBackColor = true;
            this.rdbCelsiusToKelvin.CheckedChanged += new System.EventHandler(this.rdbCelsiusToKelvin_CheckedChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 201);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(220, 41);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Converted degrees";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(147, 259);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 305);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Methods assignment 7";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFahrenheitToCelsius;
        private System.Windows.Forms.RadioButton rdbCelsiusToFahrenheit;
        private System.Windows.Forms.RadioButton rdbCelsiusToKelvin;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
    }
}

