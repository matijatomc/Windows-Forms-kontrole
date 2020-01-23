namespace matijaTomcCheckBox
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
            this.chbDorucak = new System.Windows.Forms.CheckBox();
            this.chbRucak = new System.Windows.Forms.CheckBox();
            this.chbVecera = new System.Windows.Forms.CheckBox();
            this.chbSakriNarudzbu = new System.Windows.Forms.CheckBox();
            this.txtPrikaz = new System.Windows.Forms.TextBox();
            this.btnPosalji = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chbDorucak
            // 
            this.chbDorucak.AutoSize = true;
            this.chbDorucak.Location = new System.Drawing.Point(77, 49);
            this.chbDorucak.Name = "chbDorucak";
            this.chbDorucak.Size = new System.Drawing.Size(67, 17);
            this.chbDorucak.TabIndex = 0;
            this.chbDorucak.Text = "Doručak";
            this.chbDorucak.UseVisualStyleBackColor = true;
            // 
            // chbRucak
            // 
            this.chbRucak.AutoSize = true;
            this.chbRucak.Location = new System.Drawing.Point(77, 90);
            this.chbRucak.Name = "chbRucak";
            this.chbRucak.Size = new System.Drawing.Size(58, 17);
            this.chbRucak.TabIndex = 1;
            this.chbRucak.Text = "Ručak";
            this.chbRucak.UseVisualStyleBackColor = true;
            // 
            // chbVecera
            // 
            this.chbVecera.AutoSize = true;
            this.chbVecera.Location = new System.Drawing.Point(77, 137);
            this.chbVecera.Name = "chbVecera";
            this.chbVecera.Size = new System.Drawing.Size(60, 17);
            this.chbVecera.TabIndex = 2;
            this.chbVecera.Text = "Večera";
            this.chbVecera.UseVisualStyleBackColor = true;
            // 
            // chbSakriNarudzbu
            // 
            this.chbSakriNarudzbu.AutoSize = true;
            this.chbSakriNarudzbu.Location = new System.Drawing.Point(189, 200);
            this.chbSakriNarudzbu.Name = "chbSakriNarudzbu";
            this.chbSakriNarudzbu.Size = new System.Drawing.Size(97, 17);
            this.chbSakriNarudzbu.TabIndex = 3;
            this.chbSakriNarudzbu.Text = "Sakri narudžbu";
            this.chbSakriNarudzbu.UseVisualStyleBackColor = true;
            // 
            // txtPrikaz
            // 
            this.txtPrikaz.Location = new System.Drawing.Point(189, 32);
            this.txtPrikaz.Multiline = true;
            this.txtPrikaz.Name = "txtPrikaz";
            this.txtPrikaz.Size = new System.Drawing.Size(232, 143);
            this.txtPrikaz.TabIndex = 4;
            this.txtPrikaz.Text = "Odabrali ste:";
            this.txtPrikaz.TextChanged += new System.EventHandler(this.TxtPrikaz_TextChanged);
            // 
            // btnPosalji
            // 
            this.btnPosalji.Location = new System.Drawing.Point(77, 193);
            this.btnPosalji.Name = "btnPosalji";
            this.btnPosalji.Size = new System.Drawing.Size(74, 28);
            this.btnPosalji.TabIndex = 5;
            this.btnPosalji.Text = "Pošalji";
            this.btnPosalji.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 250);
            this.Controls.Add(this.btnPosalji);
            this.Controls.Add(this.txtPrikaz);
            this.Controls.Add(this.chbSakriNarudzbu);
            this.Controls.Add(this.chbVecera);
            this.Controls.Add(this.chbRucak);
            this.Controls.Add(this.chbDorucak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbDorucak;
        private System.Windows.Forms.CheckBox chbRucak;
        private System.Windows.Forms.CheckBox chbVecera;
        private System.Windows.Forms.CheckBox chbSakriNarudzbu;
        private System.Windows.Forms.TextBox txtPrikaz;
        private System.Windows.Forms.Button btnPosalji;
    }
}

