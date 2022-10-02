namespace Oefening2
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
            this.resultaatLabel1 = new System.Windows.Forms.Label();
            this.berekening1 = new System.Windows.Forms.Label();
            this.Resultaat1 = new System.Windows.Forms.Label();
            this.Resultaatberekening1 = new System.Windows.Forms.Label();
            this.berekening2 = new System.Windows.Forms.Label();
            this.Resultaatberekening2 = new System.Windows.Forms.Label();
            this.TrueOrFalse = new System.Windows.Forms.Label();
            this.ResultaatTrueOrFalse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "12345 * 54321 = ";
            // 
            // resultaatLabel1
            // 
            this.resultaatLabel1.Location = new System.Drawing.Point(0, 0);
            this.resultaatLabel1.Name = "resultaatLabel1";
            this.resultaatLabel1.Size = new System.Drawing.Size(100, 23);
            this.resultaatLabel1.TabIndex = 0;
            // 
            // berekening1
            // 
            this.berekening1.AutoSize = true;
            this.berekening1.Location = new System.Drawing.Point(312, 100);
            this.berekening1.Name = "berekening1";
            this.berekening1.Size = new System.Drawing.Size(92, 15);
            this.berekening1.TabIndex = 0;
            this.berekening1.Text = "12345 * 54321 = ";
            this.berekening1.Click += new System.EventHandler(this.berekening1_Click);
            // 
            // Resultaat1
            // 
            this.Resultaat1.AutoSize = true;
            this.Resultaat1.Location = new System.Drawing.Point(410, 100);
            this.Resultaat1.Name = "Resultaat1";
            this.Resultaat1.Size = new System.Drawing.Size(0, 15);
            this.Resultaat1.TabIndex = 1;
            // 
            // Resultaatberekening1
            // 
            this.Resultaatberekening1.AutoSize = true;
            this.Resultaatberekening1.Location = new System.Drawing.Point(410, 100);
            this.Resultaatberekening1.Name = "Resultaatberekening1";
            this.Resultaatberekening1.Size = new System.Drawing.Size(0, 15);
            this.Resultaatberekening1.TabIndex = 2;
            this.Resultaatberekening1.Click += new System.EventHandler(this.Resultaatberekening1_Click);
            // 
            // berekening2
            // 
            this.berekening2.AutoSize = true;
            this.berekening2.Location = new System.Drawing.Point(312, 132);
            this.berekening2.Name = "berekening2";
            this.berekening2.Size = new System.Drawing.Size(92, 15);
            this.berekening2.TabIndex = 3;
            this.berekening2.Text = "22222 * 33333 = ";
            // 
            // Resultaatberekening2
            // 
            this.Resultaatberekening2.AutoSize = true;
            this.Resultaatberekening2.Location = new System.Drawing.Point(410, 132);
            this.Resultaatberekening2.Name = "Resultaatberekening2";
            this.Resultaatberekening2.Size = new System.Drawing.Size(0, 15);
            this.Resultaatberekening2.TabIndex = 4;
            this.Resultaatberekening2.Click += new System.EventHandler(this.Resultaatberekening2_Click);
            // 
            // TrueOrFalse
            // 
            this.TrueOrFalse.AutoSize = true;
            this.TrueOrFalse.Location = new System.Drawing.Point(312, 170);
            this.TrueOrFalse.Name = "TrueOrFalse";
            this.TrueOrFalse.Size = new System.Drawing.Size(177, 15);
            this.TrueOrFalse.TabIndex = 5;
            this.TrueOrFalse.Text = "12345 * 54321 > 22222 * 33333 = ";
            // 
            // ResultaatTrueOrFalse
            // 
            this.ResultaatTrueOrFalse.AutoSize = true;
            this.ResultaatTrueOrFalse.Location = new System.Drawing.Point(495, 170);
            this.ResultaatTrueOrFalse.Name = "ResultaatTrueOrFalse";
            this.ResultaatTrueOrFalse.Size = new System.Drawing.Size(0, 15);
            this.ResultaatTrueOrFalse.TabIndex = 6;
            this.ResultaatTrueOrFalse.Click += new System.EventHandler(this.ResultaatTrueOrFalse_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(912, 360);
            this.Controls.Add(this.ResultaatTrueOrFalse);
            this.Controls.Add(this.TrueOrFalse);
            this.Controls.Add(this.Resultaatberekening2);
            this.Controls.Add(this.berekening2);
            this.Controls.Add(this.Resultaatberekening1);
            this.Controls.Add(this.Resultaat1);
            this.Controls.Add(this.berekening1);
            this.Name = "Form1";
            this.Text = "IsItBigger";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label resultaatLabel1;
        private Label berekening1;
        private Label Resultaat1;
        private Label Resultaatberekening1;
        private Label berekening2;
        private Label Resultaatberekening2;
        private Label TrueOrFalse;
        private Label ResultaatTrueOrFalse;
    }
}