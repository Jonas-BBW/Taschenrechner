namespace Taschenrechner
{
    partial class frm_Taschenrechner
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_ergebnis = new System.Windows.Forms.TextBox();
            this.btn_durch = new System.Windows.Forms.Button();
            this.btn_mal = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_gleichheitszeichen = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_komma = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_klammerZu = new System.Windows.Forms.Button();
            this.btn_klammerAuf = new System.Windows.Forms.Button();
            this.btn_löschen = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_ergebnis
            // 
            this.tb_ergebnis.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tb_ergebnis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ergebnis.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ergebnis.ForeColor = System.Drawing.Color.White;
            this.tb_ergebnis.HideSelection = false;
            this.tb_ergebnis.Location = new System.Drawing.Point(11, 12);
            this.tb_ergebnis.Multiline = true;
            this.tb_ergebnis.Name = "tb_ergebnis";
            this.tb_ergebnis.ReadOnly = true;
            this.tb_ergebnis.Size = new System.Drawing.Size(420, 43);
            this.tb_ergebnis.TabIndex = 1;
            this.tb_ergebnis.WordWrap = false;
            this.tb_ergebnis.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_ergebnis_KeyDown);
            this.tb_ergebnis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ergebnis_KeyPress);
            // 
            // btn_durch
            // 
            this.btn_durch.BackColor = System.Drawing.Color.Black;
            this.btn_durch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_durch.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_durch.ForeColor = System.Drawing.Color.White;
            this.btn_durch.Location = new System.Drawing.Point(330, 272);
            this.btn_durch.Name = "btn_durch";
            this.btn_durch.Size = new System.Drawing.Size(100, 45);
            this.btn_durch.TabIndex = 34;
            this.btn_durch.TabStop = false;
            this.btn_durch.Text = "÷";
            this.btn_durch.UseVisualStyleBackColor = false;
            this.btn_durch.Click += new System.EventHandler(this.btn_durch_Click);
            // 
            // btn_mal
            // 
            this.btn_mal.BackColor = System.Drawing.Color.Black;
            this.btn_mal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mal.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mal.ForeColor = System.Drawing.Color.White;
            this.btn_mal.Location = new System.Drawing.Point(330, 221);
            this.btn_mal.Name = "btn_mal";
            this.btn_mal.Size = new System.Drawing.Size(100, 45);
            this.btn_mal.TabIndex = 33;
            this.btn_mal.TabStop = false;
            this.btn_mal.Text = "×";
            this.btn_mal.UseVisualStyleBackColor = false;
            this.btn_mal.Click += new System.EventHandler(this.btn_mal_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.BackColor = System.Drawing.Color.Black;
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.ForeColor = System.Drawing.Color.White;
            this.btn_minus.Location = new System.Drawing.Point(330, 170);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(100, 45);
            this.btn_minus.TabIndex = 32;
            this.btn_minus.TabStop = false;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = false;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.BackColor = System.Drawing.Color.Black;
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.ForeColor = System.Drawing.Color.White;
            this.btn_plus.Location = new System.Drawing.Point(330, 119);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(100, 45);
            this.btn_plus.TabIndex = 31;
            this.btn_plus.TabStop = false;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = false;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_gleichheitszeichen
            // 
            this.btn_gleichheitszeichen.BackColor = System.Drawing.Color.Black;
            this.btn_gleichheitszeichen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_gleichheitszeichen.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gleichheitszeichen.ForeColor = System.Drawing.Color.White;
            this.btn_gleichheitszeichen.Location = new System.Drawing.Point(224, 272);
            this.btn_gleichheitszeichen.Name = "btn_gleichheitszeichen";
            this.btn_gleichheitszeichen.Size = new System.Drawing.Size(100, 45);
            this.btn_gleichheitszeichen.TabIndex = 30;
            this.btn_gleichheitszeichen.TabStop = false;
            this.btn_gleichheitszeichen.Text = "=";
            this.btn_gleichheitszeichen.UseVisualStyleBackColor = false;
            this.btn_gleichheitszeichen.Click += new System.EventHandler(this.btn_gleichheitszeichen_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Black;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(224, 221);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(100, 45);
            this.btn_3.TabIndex = 29;
            this.btn_3.TabStop = false;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_6
            // 
            this.btn_6.BackColor = System.Drawing.Color.Black;
            this.btn_6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_6.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.ForeColor = System.Drawing.Color.White;
            this.btn_6.Location = new System.Drawing.Point(224, 170);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(100, 45);
            this.btn_6.TabIndex = 28;
            this.btn_6.TabStop = false;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = false;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_9
            // 
            this.btn_9.BackColor = System.Drawing.Color.Black;
            this.btn_9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_9.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.ForeColor = System.Drawing.Color.White;
            this.btn_9.Location = new System.Drawing.Point(224, 119);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(100, 45);
            this.btn_9.TabIndex = 27;
            this.btn_9.TabStop = false;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = false;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_komma
            // 
            this.btn_komma.BackColor = System.Drawing.Color.Black;
            this.btn_komma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_komma.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_komma.ForeColor = System.Drawing.Color.White;
            this.btn_komma.Location = new System.Drawing.Point(118, 272);
            this.btn_komma.Name = "btn_komma";
            this.btn_komma.Size = new System.Drawing.Size(100, 45);
            this.btn_komma.TabIndex = 26;
            this.btn_komma.TabStop = false;
            this.btn_komma.Text = ",";
            this.btn_komma.UseVisualStyleBackColor = false;
            this.btn_komma.Click += new System.EventHandler(this.btn_komma_Click);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Black;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(118, 221);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(100, 45);
            this.btn_2.TabIndex = 25;
            this.btn_2.TabStop = false;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_5
            // 
            this.btn_5.BackColor = System.Drawing.Color.Black;
            this.btn_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_5.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.ForeColor = System.Drawing.Color.White;
            this.btn_5.Location = new System.Drawing.Point(118, 170);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(100, 45);
            this.btn_5.TabIndex = 24;
            this.btn_5.TabStop = false;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = false;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_8
            // 
            this.btn_8.BackColor = System.Drawing.Color.Black;
            this.btn_8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_8.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.ForeColor = System.Drawing.Color.White;
            this.btn_8.Location = new System.Drawing.Point(118, 119);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(100, 45);
            this.btn_8.TabIndex = 23;
            this.btn_8.TabStop = false;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = false;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_0
            // 
            this.btn_0.BackColor = System.Drawing.Color.Black;
            this.btn_0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_0.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.ForeColor = System.Drawing.Color.White;
            this.btn_0.Location = new System.Drawing.Point(12, 272);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(100, 45);
            this.btn_0.TabIndex = 22;
            this.btn_0.TabStop = false;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = false;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Black;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(12, 221);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(100, 45);
            this.btn_1.TabIndex = 21;
            this.btn_1.TabStop = false;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_4
            // 
            this.btn_4.BackColor = System.Drawing.Color.Black;
            this.btn_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.ForeColor = System.Drawing.Color.White;
            this.btn_4.Location = new System.Drawing.Point(11, 170);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(100, 45);
            this.btn_4.TabIndex = 20;
            this.btn_4.TabStop = false;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = false;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_7
            // 
            this.btn_7.BackColor = System.Drawing.Color.Black;
            this.btn_7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_7.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.ForeColor = System.Drawing.Color.White;
            this.btn_7.Location = new System.Drawing.Point(11, 119);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(100, 45);
            this.btn_7.TabIndex = 18;
            this.btn_7.TabStop = false;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = false;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_klammerZu
            // 
            this.btn_klammerZu.BackColor = System.Drawing.Color.Black;
            this.btn_klammerZu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_klammerZu.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_klammerZu.ForeColor = System.Drawing.Color.White;
            this.btn_klammerZu.Location = new System.Drawing.Point(118, 68);
            this.btn_klammerZu.Name = "btn_klammerZu";
            this.btn_klammerZu.Size = new System.Drawing.Size(100, 45);
            this.btn_klammerZu.TabIndex = 39;
            this.btn_klammerZu.TabStop = false;
            this.btn_klammerZu.Text = ")";
            this.btn_klammerZu.UseVisualStyleBackColor = false;
            this.btn_klammerZu.Click += new System.EventHandler(this.btn_klammerZu_Click);
            // 
            // btn_klammerAuf
            // 
            this.btn_klammerAuf.BackColor = System.Drawing.Color.Black;
            this.btn_klammerAuf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_klammerAuf.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_klammerAuf.ForeColor = System.Drawing.Color.White;
            this.btn_klammerAuf.Location = new System.Drawing.Point(12, 68);
            this.btn_klammerAuf.Name = "btn_klammerAuf";
            this.btn_klammerAuf.Size = new System.Drawing.Size(100, 45);
            this.btn_klammerAuf.TabIndex = 38;
            this.btn_klammerAuf.TabStop = false;
            this.btn_klammerAuf.Text = "(";
            this.btn_klammerAuf.UseVisualStyleBackColor = false;
            this.btn_klammerAuf.Click += new System.EventHandler(this.btn_klammerAuf_Click);
            // 
            // btn_löschen
            // 
            this.btn_löschen.BackColor = System.Drawing.Color.Black;
            this.btn_löschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_löschen.Font = new System.Drawing.Font("Arial Unicode MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_löschen.ForeColor = System.Drawing.Color.White;
            this.btn_löschen.Location = new System.Drawing.Point(330, 68);
            this.btn_löschen.Name = "btn_löschen";
            this.btn_löschen.Size = new System.Drawing.Size(100, 45);
            this.btn_löschen.TabIndex = 37;
            this.btn_löschen.TabStop = false;
            this.btn_löschen.Text = "⌫";
            this.btn_löschen.UseCompatibleTextRendering = true;
            this.btn_löschen.UseVisualStyleBackColor = false;
            this.btn_löschen.Click += new System.EventHandler(this.btn_löschen_Click);
            // 
            // btn_c
            // 
            this.btn_c.BackColor = System.Drawing.Color.Black;
            this.btn_c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_c.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_c.ForeColor = System.Drawing.Color.White;
            this.btn_c.Location = new System.Drawing.Point(224, 68);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(100, 45);
            this.btn_c.TabIndex = 36;
            this.btn_c.TabStop = false;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = false;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // frm_Taschenrechner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(444, 330);
            this.Controls.Add(this.btn_klammerZu);
            this.Controls.Add(this.btn_klammerAuf);
            this.Controls.Add(this.btn_löschen);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.tb_ergebnis);
            this.Controls.Add(this.btn_durch);
            this.Controls.Add(this.btn_mal);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_gleichheitszeichen);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_komma);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Taschenrechner";
            this.ShowIcon = false;
            this.Text = "Taschenrechner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_ergebnis;
        private System.Windows.Forms.Button btn_durch;
        private System.Windows.Forms.Button btn_mal;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_gleichheitszeichen;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_komma;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_klammerZu;
        private System.Windows.Forms.Button btn_klammerAuf;
        private System.Windows.Forms.Button btn_löschen;
        private System.Windows.Forms.Button btn_c;
    }
}

