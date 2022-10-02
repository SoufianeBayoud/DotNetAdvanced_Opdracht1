namespace CelsiusToFahrenheit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.celsiusTxtBox = new System.Windows.Forms.TextBox();
            this.FahrenheitTxtBox = new System.Windows.Forms.TextBox();
            this.celsiusBtn = new System.Windows.Forms.Button();
            this.fahrenheitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Celsius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fahrenheit";
            // 
            // celsiusTxtBox
            // 
            this.celsiusTxtBox.Location = new System.Drawing.Point(96, 99);
            this.celsiusTxtBox.Name = "celsiusTxtBox";
            this.celsiusTxtBox.Size = new System.Drawing.Size(100, 23);
            this.celsiusTxtBox.TabIndex = 2;
            // 
            // FahrenheitTxtBox
            // 
            this.FahrenheitTxtBox.Location = new System.Drawing.Point(241, 99);
            this.FahrenheitTxtBox.Name = "FahrenheitTxtBox";
            this.FahrenheitTxtBox.Size = new System.Drawing.Size(100, 23);
            this.FahrenheitTxtBox.TabIndex = 3;
            // 
            // celsiusBtn
            // 
            this.celsiusBtn.Location = new System.Drawing.Point(96, 142);
            this.celsiusBtn.Name = "celsiusBtn";
            this.celsiusBtn.Size = new System.Drawing.Size(100, 23);
            this.celsiusBtn.TabIndex = 4;
            this.celsiusBtn.Text = "C to F";
            this.celsiusBtn.UseVisualStyleBackColor = true;
            this.celsiusBtn.Click += new System.EventHandler(this.celsiusBtn_Click);
            // 
            // fahrenheitBtn
            // 
            this.fahrenheitBtn.Location = new System.Drawing.Point(241, 142);
            this.fahrenheitBtn.Name = "fahrenheitBtn";
            this.fahrenheitBtn.Size = new System.Drawing.Size(100, 23);
            this.fahrenheitBtn.TabIndex = 5;
            this.fahrenheitBtn.Text = "F to C";
            this.fahrenheitBtn.UseVisualStyleBackColor = true;
            this.fahrenheitBtn.Click += new System.EventHandler(this.fahrenheitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 267);
            this.Controls.Add(this.fahrenheitBtn);
            this.Controls.Add(this.celsiusBtn);
            this.Controls.Add(this.FahrenheitTxtBox);
            this.Controls.Add(this.celsiusTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CelsiusToFahrenheit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox celsiusTxtBox;
        private TextBox FahrenheitTxtBox;
        private Button celsiusBtn;
        private Button fahrenheitBtn;
    }
}