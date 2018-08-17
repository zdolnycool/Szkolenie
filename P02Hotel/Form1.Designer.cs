namespace P02Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWiek = new System.Windows.Forms.TextBox();
            this.txtNoclegi = new System.Windows.Forms.TextBox();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCennik = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel - koszt noclegu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Podaj wiek";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Podaj ilość noclegów";
            // 
            // txtWiek
            // 
            this.txtWiek.Location = new System.Drawing.Point(168, 80);
            this.txtWiek.Name = "txtWiek";
            this.txtWiek.Size = new System.Drawing.Size(100, 20);
            this.txtWiek.TabIndex = 3;
            // 
            // txtNoclegi
            // 
            this.txtNoclegi.Location = new System.Drawing.Point(168, 137);
            this.txtNoclegi.Name = "txtNoclegi";
            this.txtNoclegi.Size = new System.Drawing.Size(100, 20);
            this.txtNoclegi.TabIndex = 4;
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(38, 266);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(230, 44);
            this.btnOblicz.TabIndex = 5;
            this.btnOblicz.Text = "Oblicz koszt";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // txtWynik
            // 
            this.txtWynik.Location = new System.Drawing.Point(387, 279);
            this.txtWynik.Multiline = true;
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.Size = new System.Drawing.Size(175, 26);
            this.txtWynik.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Koszt Twojego noclegu wyniesie:";
            // 
            // txtCennik
            // 
            this.txtCennik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCennik.Location = new System.Drawing.Point(387, 69);
            this.txtCennik.Multiline = true;
            this.txtCennik.Name = "txtCennik";
            this.txtCennik.ReadOnly = true;
            this.txtCennik.Size = new System.Drawing.Size(282, 150);
            this.txtCennik.TabIndex = 8;
            this.txtCennik.Text = resources.GetString("txtCennik.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cennik:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCennik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWynik);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.txtNoclegi);
            this.Controls.Add(this.txtWiek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWiek;
        private System.Windows.Forms.TextBox txtNoclegi;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.TextBox txtWynik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCennik;
        private System.Windows.Forms.Label label5;
    }
}

