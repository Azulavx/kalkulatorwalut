namespace WinFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.USD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EUR = new System.Windows.Forms.TextBox();
            this.CHF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // USD
            // 
            this.USD.Location = new System.Drawing.Point(158, 28);
            this.USD.Name = "USD";
            this.USD.Size = new System.Drawing.Size(100, 23);
            this.USD.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kurs USD";
            // 
            // EUR
            // 
            this.EUR.Location = new System.Drawing.Point(158, 57);
            this.EUR.Name = "EUR";
            this.EUR.Size = new System.Drawing.Size(100, 23);
            this.EUR.TabIndex = 4;
            // 
            // CHF
            // 
            this.CHF.Location = new System.Drawing.Point(158, 86);
            this.CHF.Name = "CHF";
            this.CHF.Size = new System.Drawing.Size(100, 23);
            this.CHF.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kurs EUR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kurs CHF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kalkulator walutowy";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CHF);
            this.Controls.Add(this.EUR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.USD);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox USD;
        private Label label1;
        private TextBox EUR;
        private TextBox CHF;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}