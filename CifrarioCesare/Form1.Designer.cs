namespace CifrarioCesare
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.txt_testo2 = new System.Windows.Forms.TextBox();
            this.txt_testo1 = new System.Windows.Forms.TextBox();
            this.btn_cifra = new System.Windows.Forms.Button();
            this.btn_decifra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_chiave1 = new System.Windows.Forms.TextBox();
            this.txt_chiave2 = new System.Windows.Forms.TextBox();
            this.lbl_risultato1 = new System.Windows.Forms.Label();
            this.lbl_risultato2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.AutoSize = true;
            this.lbl_titolo.Font = new System.Drawing.Font("Nachlieli CLM", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_titolo.Location = new System.Drawing.Point(434, 9);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(277, 30);
            this.lbl_titolo.TabIndex = 0;
            this.lbl_titolo.Text = "CIFRARIO DI CESARE";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(24, 132);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(159, 16);
            this.lbl_1.TabIndex = 1;
            this.lbl_1.Text = "Inserisci il testo da cifrare:";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbl_2.Location = new System.Drawing.Point(414, 135);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(188, 17);
            this.lbl_2.TabIndex = 2;
            this.lbl_2.Text = "Inserisci il testo da decifrare:";
            // 
            // txt_testo2
            // 
            this.txt_testo2.Location = new System.Drawing.Point(608, 134);
            this.txt_testo2.Name = "txt_testo2";
            this.txt_testo2.Size = new System.Drawing.Size(130, 20);
            this.txt_testo2.TabIndex = 3;
            // 
            // txt_testo1
            // 
            this.txt_testo1.Location = new System.Drawing.Point(189, 135);
            this.txt_testo1.Name = "txt_testo1";
            this.txt_testo1.Size = new System.Drawing.Size(119, 20);
            this.txt_testo1.TabIndex = 4;
            // 
            // btn_cifra
            // 
            this.btn_cifra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cifra.Location = new System.Drawing.Point(69, 282);
            this.btn_cifra.Name = "btn_cifra";
            this.btn_cifra.Size = new System.Drawing.Size(189, 63);
            this.btn_cifra.TabIndex = 5;
            this.btn_cifra.Text = "CIFRA";
            this.btn_cifra.UseVisualStyleBackColor = true;
            this.btn_cifra.Click += new System.EventHandler(this.btn_cifra_Click);
            // 
            // btn_decifra
            // 
            this.btn_decifra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.btn_decifra.Location = new System.Drawing.Point(465, 282);
            this.btn_decifra.Name = "btn_decifra";
            this.btn_decifra.Size = new System.Drawing.Size(213, 63);
            this.btn_decifra.TabIndex = 6;
            this.btn_decifra.Text = "DECIFRA";
            this.btn_decifra.UseVisualStyleBackColor = true;
            this.btn_decifra.Click += new System.EventHandler(this.btn_decifra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inserire la chiave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 380);
            this.label2.TabIndex = 8;
            this.label2.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(414, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inserisci la chiave:";
            // 
            // txt_chiave1
            // 
            this.txt_chiave1.Location = new System.Drawing.Point(141, 213);
            this.txt_chiave1.Name = "txt_chiave1";
            this.txt_chiave1.Size = new System.Drawing.Size(100, 20);
            this.txt_chiave1.TabIndex = 10;
            // 
            // txt_chiave2
            // 
            this.txt_chiave2.Location = new System.Drawing.Point(561, 213);
            this.txt_chiave2.Name = "txt_chiave2";
            this.txt_chiave2.Size = new System.Drawing.Size(100, 20);
            this.txt_chiave2.TabIndex = 11;
            // 
            // lbl_risultato1
            // 
            this.lbl_risultato1.AutoSize = true;
            this.lbl_risultato1.Location = new System.Drawing.Point(66, 394);
            this.lbl_risultato1.Name = "lbl_risultato1";
            this.lbl_risultato1.Size = new System.Drawing.Size(71, 13);
            this.lbl_risultato1.TabIndex = 12;
            this.lbl_risultato1.Text = "RISULTATO:";
            // 
            // lbl_risultato2
            // 
            this.lbl_risultato2.AutoSize = true;
            this.lbl_risultato2.Location = new System.Drawing.Point(481, 394);
            this.lbl_risultato2.Name = "lbl_risultato2";
            this.lbl_risultato2.Size = new System.Drawing.Size(71, 13);
            this.lbl_risultato2.TabIndex = 13;
            this.lbl_risultato2.Text = "RISULTATO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(871, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "RISULTATO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(804, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 18;
            this.label5.Text = "Chiave: 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(762, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 380);
            this.label6.TabIndex = 17;
            this.label6.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.button1.Location = new System.Drawing.Point(783, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 63);
            this.button1.TabIndex = 16;
            this.button1.Text = "DECIFRA";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(998, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(804, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Inserisci il testo da decifrare:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1017, 282);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 63);
            this.button2.TabIndex = 21;
            this.button2.Text = "CIFRA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_risultato2);
            this.Controls.Add(this.lbl_risultato1);
            this.Controls.Add(this.txt_chiave2);
            this.Controls.Add(this.txt_chiave1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_decifra);
            this.Controls.Add(this.btn_cifra);
            this.Controls.Add(this.txt_testo1);
            this.Controls.Add(this.txt_testo2);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_titolo);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.TextBox txt_testo2;
        private System.Windows.Forms.TextBox txt_testo1;
        private System.Windows.Forms.Button btn_cifra;
        private System.Windows.Forms.Button btn_decifra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_chiave1;
        private System.Windows.Forms.TextBox txt_chiave2;
        private System.Windows.Forms.Label lbl_risultato1;
        private System.Windows.Forms.Label lbl_risultato2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
    }
}

