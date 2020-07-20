namespace EsercizioCerchio
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
            this.tbx_raggio = new System.Windows.Forms.TextBox();
            this.tbx_altezza = new System.Windows.Forms.TextBox();
            this.btn_calcola = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbx_cerchioArea = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_cerchioCirconferenza = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_cerchioDiametro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbx_cilindroVolume = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbx_cilindroAreaTotale = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbx_cilindroAreaLaterale = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbx_sferaVolume = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbx_sferaSuperficie = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbx_conoVolume = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_raggio
            // 
            this.tbx_raggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_raggio.Location = new System.Drawing.Point(72, 95);
            this.tbx_raggio.Name = "tbx_raggio";
            this.tbx_raggio.Size = new System.Drawing.Size(138, 39);
            this.tbx_raggio.TabIndex = 0;
            // 
            // tbx_altezza
            // 
            this.tbx_altezza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_altezza.Location = new System.Drawing.Point(72, 204);
            this.tbx_altezza.Name = "tbx_altezza";
            this.tbx_altezza.Size = new System.Drawing.Size(138, 39);
            this.tbx_altezza.TabIndex = 1;
            // 
            // btn_calcola
            // 
            this.btn_calcola.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcola.Location = new System.Drawing.Point(72, 262);
            this.btn_calcola.Name = "btn_calcola";
            this.btn_calcola.Size = new System.Drawing.Size(138, 46);
            this.btn_calcola.TabIndex = 2;
            this.btn_calcola.Text = "Calcola";
            this.btn_calcola.UseVisualStyleBackColor = true;
            this.btn_calcola.Click += new System.EventHandler(this.btn_calcola_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(72, 327);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(138, 46);
            this.btn_reset.TabIndex = 3;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Raggio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Altezza";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbx_cerchioArea);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbx_cerchioCirconferenza);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tbx_cerchioDiametro);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(342, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 349);
            this.panel1.TabIndex = 6;
            // 
            // tbx_cerchioArea
            // 
            this.tbx_cerchioArea.Enabled = false;
            this.tbx_cerchioArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cerchioArea.Location = new System.Drawing.Point(25, 298);
            this.tbx_cerchioArea.Name = "tbx_cerchioArea";
            this.tbx_cerchioArea.Size = new System.Drawing.Size(177, 39);
            this.tbx_cerchioArea.TabIndex = 6;
            this.tbx_cerchioArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(76, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Area";
            // 
            // tbx_cerchioCirconferenza
            // 
            this.tbx_cerchioCirconferenza.Enabled = false;
            this.tbx_cerchioCirconferenza.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cerchioCirconferenza.Location = new System.Drawing.Point(25, 205);
            this.tbx_cerchioCirconferenza.Name = "tbx_cerchioCirconferenza";
            this.tbx_cerchioCirconferenza.Size = new System.Drawing.Size(177, 39);
            this.tbx_cerchioCirconferenza.TabIndex = 4;
            this.tbx_cerchioCirconferenza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 32);
            this.label5.TabIndex = 3;
            this.label5.Text = "Circonferenza";
            // 
            // tbx_cerchioDiametro
            // 
            this.tbx_cerchioDiametro.Enabled = false;
            this.tbx_cerchioDiametro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cerchioDiametro.Location = new System.Drawing.Point(25, 113);
            this.tbx_cerchioDiametro.Name = "tbx_cerchioDiametro";
            this.tbx_cerchioDiametro.Size = new System.Drawing.Size(177, 39);
            this.tbx_cerchioDiametro.TabIndex = 2;
            this.tbx_cerchioDiametro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Diametro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cerchio";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tbx_cilindroVolume);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbx_cilindroAreaTotale);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbx_cilindroAreaLaterale);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(693, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 349);
            this.panel2.TabIndex = 7;
            // 
            // tbx_cilindroVolume
            // 
            this.tbx_cilindroVolume.Enabled = false;
            this.tbx_cilindroVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cilindroVolume.Location = new System.Drawing.Point(25, 298);
            this.tbx_cilindroVolume.Name = "tbx_cilindroVolume";
            this.tbx_cilindroVolume.Size = new System.Drawing.Size(177, 39);
            this.tbx_cilindroVolume.TabIndex = 6;
            this.tbx_cilindroVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(57, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Volume";
            // 
            // tbx_cilindroAreaTotale
            // 
            this.tbx_cilindroAreaTotale.Enabled = false;
            this.tbx_cilindroAreaTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cilindroAreaTotale.Location = new System.Drawing.Point(25, 205);
            this.tbx_cilindroAreaTotale.Name = "tbx_cilindroAreaTotale";
            this.tbx_cilindroAreaTotale.Size = new System.Drawing.Size(177, 39);
            this.tbx_cilindroAreaTotale.TabIndex = 4;
            this.tbx_cilindroAreaTotale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 32);
            this.label8.TabIndex = 3;
            this.label8.Text = "Area totale";
            // 
            // tbx_cilindroAreaLaterale
            // 
            this.tbx_cilindroAreaLaterale.Enabled = false;
            this.tbx_cilindroAreaLaterale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_cilindroAreaLaterale.Location = new System.Drawing.Point(25, 113);
            this.tbx_cilindroAreaLaterale.Name = "tbx_cilindroAreaLaterale";
            this.tbx_cilindroAreaLaterale.Size = new System.Drawing.Size(177, 39);
            this.tbx_cilindroAreaLaterale.TabIndex = 2;
            this.tbx_cilindroAreaLaterale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 32);
            this.label9.TabIndex = 1;
            this.label9.Text = "Area laterale";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(158, 48);
            this.label10.TabIndex = 0;
            this.label10.Text = "Cilindro";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tbx_sferaVolume);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.tbx_sferaSuperficie);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(342, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(224, 265);
            this.panel3.TabIndex = 7;
            // 
            // tbx_sferaVolume
            // 
            this.tbx_sferaVolume.Enabled = false;
            this.tbx_sferaVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_sferaVolume.Location = new System.Drawing.Point(25, 205);
            this.tbx_sferaVolume.Name = "tbx_sferaVolume";
            this.tbx_sferaVolume.Size = new System.Drawing.Size(177, 39);
            this.tbx_sferaVolume.TabIndex = 4;
            this.tbx_sferaVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(57, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 32);
            this.label12.TabIndex = 3;
            this.label12.Text = "Volume";
            // 
            // tbx_sferaSuperficie
            // 
            this.tbx_sferaSuperficie.Enabled = false;
            this.tbx_sferaSuperficie.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_sferaSuperficie.Location = new System.Drawing.Point(25, 113);
            this.tbx_sferaSuperficie.Name = "tbx_sferaSuperficie";
            this.tbx_sferaSuperficie.Size = new System.Drawing.Size(177, 39);
            this.tbx_sferaSuperficie.TabIndex = 2;
            this.tbx_sferaSuperficie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(42, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 32);
            this.label13.TabIndex = 1;
            this.label13.Text = "Superficie";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(56, 11);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 48);
            this.label14.TabIndex = 0;
            this.label14.Text = "Sfera";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tbx_conoVolume);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Location = new System.Drawing.Point(693, 399);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 174);
            this.panel4.TabIndex = 7;
            // 
            // tbx_conoVolume
            // 
            this.tbx_conoVolume.Enabled = false;
            this.tbx_conoVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbx_conoVolume.Location = new System.Drawing.Point(25, 113);
            this.tbx_conoVolume.Name = "tbx_conoVolume";
            this.tbx_conoVolume.Size = new System.Drawing.Size(177, 39);
            this.tbx_conoVolume.TabIndex = 2;
            this.tbx_conoVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(57, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 32);
            this.label17.TabIndex = 1;
            this.label17.Text = "Volume";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(55, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(119, 48);
            this.label18.TabIndex = 0;
            this.label18.Text = "Cono";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1056, 744);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_calcola);
            this.Controls.Add(this.tbx_altezza);
            this.Controls.Add(this.tbx_raggio);
            this.MinimumSize = new System.Drawing.Size(1000, 800);
            this.Name = "Form1";
            this.Text = "Esercizio cerchio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_raggio;
        private System.Windows.Forms.TextBox tbx_altezza;
        private System.Windows.Forms.Button btn_calcola;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_cerchioArea;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbx_cerchioCirconferenza;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_cerchioDiametro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbx_cilindroVolume;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_cilindroAreaTotale;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbx_cilindroAreaLaterale;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbx_sferaVolume;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbx_sferaSuperficie;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox tbx_conoVolume;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

