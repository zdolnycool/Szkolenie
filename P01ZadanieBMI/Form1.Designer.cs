namespace P01ZadanieBMI
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
            this.lblTytul = new System.Windows.Forms.Label();
            this.lblWzrost = new System.Windows.Forms.Label();
            this.txtWzrost = new System.Windows.Forms.TextBox();
            this.txtWaga = new System.Windows.Forms.TextBox();
            this.lblWaga = new System.Windows.Forms.Label();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.lblWynik = new System.Windows.Forms.Label();
            this.txtZalecenia = new System.Windows.Forms.TextBox();
            this.lblZalecenia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTytul
            // 
            this.lblTytul.AutoSize = true;
            this.lblTytul.Location = new System.Drawing.Point(29, 28);
            this.lblTytul.Name = "lblTytul";
            this.lblTytul.Size = new System.Drawing.Size(26, 13);
            this.lblTytul.TabIndex = 0;
            this.lblTytul.Text = "BMI";
            // 
            // lblWzrost
            // 
            this.lblWzrost.AutoSize = true;
            this.lblWzrost.Location = new System.Drawing.Point(32, 71);
            this.lblWzrost.Name = "lblWzrost";
            this.lblWzrost.Size = new System.Drawing.Size(90, 13);
            this.lblWzrost.TabIndex = 1;
            this.lblWzrost.Text = "Podaj wzrost [cm]";
            // 
            // txtWzrost
            // 
            this.txtWzrost.Location = new System.Drawing.Point(138, 68);
            this.txtWzrost.Name = "txtWzrost";
            this.txtWzrost.Size = new System.Drawing.Size(100, 20);
            this.txtWzrost.TabIndex = 2;
            // 
            // txtWaga
            // 
            this.txtWaga.Location = new System.Drawing.Point(138, 112);
            this.txtWaga.Name = "txtWaga";
            this.txtWaga.Size = new System.Drawing.Size(100, 20);
            this.txtWaga.TabIndex = 3;
            // 
            // lblWaga
            // 
            this.lblWaga.AutoSize = true;
            this.lblWaga.Location = new System.Drawing.Point(32, 119);
            this.lblWaga.Name = "lblWaga";
            this.lblWaga.Size = new System.Drawing.Size(84, 13);
            this.lblWaga.TabIndex = 4;
            this.lblWaga.Text = "Podaj wagę [kg]";
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(32, 178);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(153, 50);
            this.btnOblicz.TabIndex = 5;
            this.btnOblicz.Text = "Oblicz BMI";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // txtWynik
            // 
            this.txtWynik.Location = new System.Drawing.Point(379, 67);
            this.txtWynik.Multiline = true;
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.Size = new System.Drawing.Size(211, 20);
            this.txtWynik.TabIndex = 6;
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Location = new System.Drawing.Point(316, 70);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(40, 13);
            this.lblWynik.TabIndex = 7;
            this.lblWynik.Text = "Wynik:";
            // 
            // txtZalecenia
            // 
            this.txtZalecenia.Location = new System.Drawing.Point(379, 119);
            this.txtZalecenia.Multiline = true;
            this.txtZalecenia.Name = "txtZalecenia";
            this.txtZalecenia.Size = new System.Drawing.Size(296, 154);
            this.txtZalecenia.TabIndex = 8;
            // 
            // lblZalecenia
            // 
            this.lblZalecenia.AutoSize = true;
            this.lblZalecenia.Location = new System.Drawing.Point(319, 119);
            this.lblZalecenia.Name = "lblZalecenia";
            this.lblZalecenia.Size = new System.Drawing.Size(57, 13);
            this.lblZalecenia.TabIndex = 9;
            this.lblZalecenia.Text = "Zalecenia:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblZalecenia);
            this.Controls.Add(this.txtZalecenia);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.txtWynik);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.lblWaga);
            this.Controls.Add(this.txtWaga);
            this.Controls.Add(this.txtWzrost);
            this.Controls.Add(this.lblWzrost);
            this.Controls.Add(this.lblTytul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTytul;
        private System.Windows.Forms.Label lblWzrost;
        private System.Windows.Forms.TextBox txtWzrost;
        private System.Windows.Forms.TextBox txtWaga;
        private System.Windows.Forms.Label lblWaga;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.TextBox txtWynik;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.TextBox txtZalecenia;
        private System.Windows.Forms.Label lblZalecenia;
    }
}

