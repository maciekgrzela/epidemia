namespace Epidemia
{
    partial class Epidemia
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.vaccinessupplytb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.testsupplytb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startSimulationBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.canVirusMutatechb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bedsamounttb = new System.Windows.Forms.TextBox();
            this.populationtb = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.respiratoramounttb = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.respiratoramounttb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.vaccinessupplytb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.testsupplytb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.startSimulationBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.canVirusMutatechb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bedsamounttb);
            this.panel1.Controls.Add(this.populationtb);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 583);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dostawa szczepionek";
            // 
            // vaccinessupplytb
            // 
            this.vaccinessupplytb.Location = new System.Drawing.Point(15, 386);
            this.vaccinessupplytb.Name = "vaccinessupplytb";
            this.vaccinessupplytb.Size = new System.Drawing.Size(181, 20);
            this.vaccinessupplytb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dostawa testów";
            // 
            // testsupplytb
            // 
            this.testsupplytb.Location = new System.Drawing.Point(15, 336);
            this.testsupplytb.Name = "testsupplytb";
            this.testsupplytb.Size = new System.Drawing.Size(181, 20);
            this.testsupplytb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Symulator Epidemii";
            // 
            // startSimulationBtn
            // 
            this.startSimulationBtn.ForeColor = System.Drawing.Color.White;
            this.startSimulationBtn.Location = new System.Drawing.Point(15, 494);
            this.startSimulationBtn.Margin = new System.Windows.Forms.Padding(0);
            this.startSimulationBtn.Name = "startSimulationBtn";
            this.startSimulationBtn.Size = new System.Drawing.Size(181, 78);
            this.startSimulationBtn.TabIndex = 5;
            this.startSimulationBtn.Text = "START";
            this.startSimulationBtn.UseVisualStyleBackColor = false;
            this.startSimulationBtn.Click += new System.EventHandler(this.startSimulationBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liczba łóżek szpitalnych:";
            // 
            // canVirusMutatechb
            // 
            this.canVirusMutatechb.AutoSize = true;
            this.canVirusMutatechb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canVirusMutatechb.Location = new System.Drawing.Point(16, 421);
            this.canVirusMutatechb.Name = "canVirusMutatechb";
            this.canVirusMutatechb.Size = new System.Drawing.Size(122, 17);
            this.canVirusMutatechb.TabIndex = 2;
            this.canVirusMutatechb.Text = "Mutowalność wirusa";
            this.canVirusMutatechb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Liczność populacji:";
            // 
            // bedsamounttb
            // 
            this.bedsamounttb.Location = new System.Drawing.Point(16, 240);
            this.bedsamounttb.Name = "bedsamounttb";
            this.bedsamounttb.Size = new System.Drawing.Size(181, 20);
            this.bedsamounttb.TabIndex = 1;
            // 
            // populationtb
            // 
            this.populationtb.Location = new System.Drawing.Point(15, 190);
            this.populationtb.Name = "populationtb";
            this.populationtb.Size = new System.Drawing.Size(182, 20);
            this.populationtb.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Location = new System.Drawing.Point(215, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 471);
            this.panel2.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(1, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(261, 28);
            this.panel6.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Szpital - łóżka";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Location = new System.Drawing.Point(487, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(495, 470);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Location = new System.Drawing.Point(991, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 470);
            this.panel4.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 28);
            this.panel8.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Laboratorium - testy";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.Location = new System.Drawing.Point(216, 489);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(975, 83);
            this.panel5.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(487, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(495, 28);
            this.panel7.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Populacja";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(215, 489);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(976, 28);
            this.panel9.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Przychodnia - szczepienia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(12, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Liczba respiratorów:";
            // 
            // respiratoramounttb
            // 
            this.respiratoramounttb.Location = new System.Drawing.Point(15, 290);
            this.respiratoramounttb.Name = "respiratoramounttb";
            this.respiratoramounttb.Size = new System.Drawing.Size(181, 20);
            this.respiratoramounttb.TabIndex = 11;
            // 
            // Epidemia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 583);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Epidemia";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox testsupplytb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button startSimulationBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox canVirusMutatechb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bedsamounttb;
        private System.Windows.Forms.TextBox populationtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vaccinessupplytb;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox respiratoramounttb;
    }
}

