namespace Oef4WindowsFormsApp1108
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNotities = new System.Windows.Forms.ListBox();
            this.rtbLees = new System.Windows.Forms.RichTextBox();
            this.rtbSchrijf = new System.Windows.Forms.RichTextBox();
            this.btnMaak = new System.Windows.Forms.Button();
            this.btnScheur = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSchrijfBij = new System.Windows.Forms.Button();
            this.btnLamineer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Notitieboekje";
            // 
            // lbNotities
            // 
            this.lbNotities.FormattingEnabled = true;
            this.lbNotities.Location = new System.Drawing.Point(16, 52);
            this.lbNotities.Name = "lbNotities";
            this.lbNotities.Size = new System.Drawing.Size(209, 407);
            this.lbNotities.TabIndex = 1;
            this.lbNotities.SelectedIndexChanged += new System.EventHandler(this.lbNotities_SelectedIndexChanged);
            // 
            // rtbLees
            // 
            this.rtbLees.Location = new System.Drawing.Point(231, 52);
            this.rtbLees.Name = "rtbLees";
            this.rtbLees.Size = new System.Drawing.Size(257, 201);
            this.rtbLees.TabIndex = 3;
            this.rtbLees.Text = "";
            this.rtbLees.TextChanged += new System.EventHandler(this.rtbLees_TextChanged);
            // 
            // rtbSchrijf
            // 
            this.rtbSchrijf.Location = new System.Drawing.Point(231, 297);
            this.rtbSchrijf.Name = "rtbSchrijf";
            this.rtbSchrijf.Size = new System.Drawing.Size(257, 201);
            this.rtbSchrijf.TabIndex = 4;
            this.rtbSchrijf.Text = "";
            // 
            // btnMaak
            // 
            this.btnMaak.Location = new System.Drawing.Point(16, 466);
            this.btnMaak.Name = "btnMaak";
            this.btnMaak.Size = new System.Drawing.Size(209, 32);
            this.btnMaak.TabIndex = 5;
            this.btnMaak.Text = "Maak Nieuwe Notitie";
            this.btnMaak.UseVisualStyleBackColor = true;
            this.btnMaak.Click += new System.EventHandler(this.btnMaak_Click);
            // 
            // btnScheur
            // 
            this.btnScheur.Location = new System.Drawing.Point(16, 504);
            this.btnScheur.Name = "btnScheur";
            this.btnScheur.Size = new System.Drawing.Size(209, 32);
            this.btnScheur.TabIndex = 6;
            this.btnScheur.Text = "Scheur Notitie Uit";
            this.btnScheur.UseVisualStyleBackColor = true;
            this.btnScheur.Click += new System.EventHandler(this.btnScheur_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bijschrijven";
            // 
            // btnSchrijfBij
            // 
            this.btnSchrijfBij.Location = new System.Drawing.Point(297, 260);
            this.btnSchrijfBij.Name = "btnSchrijfBij";
            this.btnSchrijfBij.Size = new System.Drawing.Size(191, 32);
            this.btnSchrijfBij.TabIndex = 8;
            this.btnSchrijfBij.Text = "Publiceer";
            this.btnSchrijfBij.UseVisualStyleBackColor = true;
            this.btnSchrijfBij.Click += new System.EventHandler(this.btnSchrijfBij_Click);
            // 
            // btnLamineer
            // 
            this.btnLamineer.Location = new System.Drawing.Point(234, 504);
            this.btnLamineer.Name = "btnLamineer";
            this.btnLamineer.Size = new System.Drawing.Size(254, 32);
            this.btnLamineer.TabIndex = 9;
            this.btnLamineer.Text = "Lamineer";
            this.btnLamineer.UseVisualStyleBackColor = true;
            this.btnLamineer.Click += new System.EventHandler(this.btnLamineer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.Location = new System.Drawing.Point(229, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Notitie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 543);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnLamineer);
            this.Controls.Add(this.btnSchrijfBij);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnScheur);
            this.Controls.Add(this.btnMaak);
            this.Controls.Add(this.rtbSchrijf);
            this.Controls.Add(this.rtbLees);
            this.Controls.Add(this.lbNotities);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Notitieboekje";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbNotities;
        private System.Windows.Forms.RichTextBox rtbLees;
        private System.Windows.Forms.RichTextBox rtbSchrijf;
        private System.Windows.Forms.Button btnMaak;
        private System.Windows.Forms.Button btnScheur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSchrijfBij;
        private System.Windows.Forms.Button btnLamineer;
        private System.Windows.Forms.Label label4;
    }
}

