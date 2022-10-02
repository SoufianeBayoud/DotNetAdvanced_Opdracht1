namespace Oefening7
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
            this.calculate = new System.Windows.Forms.Button();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.showResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number:";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(142, 119);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(81, 31);
            this.calculate.TabIndex = 1;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(168, 65);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(133, 23);
            this.inputNumber.TabIndex = 2;
            // 
            // showResult
            // 
            this.showResult.BackColor = System.Drawing.SystemColors.Window;
            this.showResult.Enabled = false;
            this.showResult.Location = new System.Drawing.Point(12, 184);
            this.showResult.Name = "showResult";
            this.showResult.Size = new System.Drawing.Size(354, 23);
            this.showResult.TabIndex = 3;
            this.showResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 230);
            this.Controls.Add(this.showResult);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Sum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button calculate;
        private TextBox inputNumber;
        private TextBox showResult;
    }
}