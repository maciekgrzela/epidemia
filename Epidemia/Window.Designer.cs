namespace Epidemia
{
    partial class Window
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
            this.label10 = new System.Windows.Forms.Label();
            this.respiratoramounttb = new System.Windows.Forms.TextBox();
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
            this.hospitalPanel = new System.Windows.Forms.Panel();
            this.bedsTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.populationPanel = new System.Windows.Forms.Panel();
            this.populationTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.labPanel = new System.Windows.Forms.Panel();
            this.labTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.vaccinesPanel = new System.Windows.Forms.Panel();
            this.vaccinesTable = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.stopSimulationBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.hospitalPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.populationPanel.SuspendLayout();
            this.panel7.SuspendLayout();
            this.labPanel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.vaccinesPanel.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.stopSimulationBtn);
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
            this.panel1.Size = new System.Drawing.Size(209, 744);
            this.panel1.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(12, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Liczba respiratorów:";
            // 
            // respiratoramounttb
            // 
            this.respiratoramounttb.Location = new System.Drawing.Point(15, 290);
            this.respiratoramounttb.Name = "respiratoramounttb";
            this.respiratoramounttb.Size = new System.Drawing.Size(181, 20);
            this.respiratoramounttb.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(12, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Dostawa szczepionek";
            // 
            // vaccinessupplytb
            // 
            this.vaccinessupplytb.Location = new System.Drawing.Point(15, 386);
            this.vaccinessupplytb.Name = "vaccinessupplytb";
            this.vaccinessupplytb.Size = new System.Drawing.Size(181, 20);
            this.vaccinessupplytb.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(12, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dostawa testów";
            // 
            // testsupplytb
            // 
            this.testsupplytb.Location = new System.Drawing.Point(15, 336);
            this.testsupplytb.Name = "testsupplytb";
            this.testsupplytb.Size = new System.Drawing.Size(181, 20);
            this.testsupplytb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Symulator Epidemii";
            // 
            // startSimulationBtn
            // 
            this.startSimulationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startSimulationBtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.startSimulationBtn.ForeColor = System.Drawing.Color.White;
            this.startSimulationBtn.Location = new System.Drawing.Point(15, 607);
            this.startSimulationBtn.Margin = new System.Windows.Forms.Padding(0);
            this.startSimulationBtn.Name = "startSimulationBtn";
            this.startSimulationBtn.Size = new System.Drawing.Size(181, 78);
            this.startSimulationBtn.TabIndex = 6;
            this.startSimulationBtn.Text = "START";
            this.startSimulationBtn.UseVisualStyleBackColor = false;
            this.startSimulationBtn.Click += new System.EventHandler(this.startSimulationBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(13, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Liczba łóżek szpitalnych:";
            // 
            // canVirusMutatechb
            // 
            this.canVirusMutatechb.AutoSize = true;
            this.canVirusMutatechb.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.canVirusMutatechb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.canVirusMutatechb.Location = new System.Drawing.Point(16, 421);
            this.canVirusMutatechb.Name = "canVirusMutatechb";
            this.canVirusMutatechb.Size = new System.Drawing.Size(139, 19);
            this.canVirusMutatechb.TabIndex = 5;
            this.canVirusMutatechb.Text = "Mutowalność wirusa";
            this.canVirusMutatechb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
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
            // hospitalPanel
            // 
            this.hospitalPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.hospitalPanel.Controls.Add(this.bedsTable);
            this.hospitalPanel.Controls.Add(this.panel6);
            this.hospitalPanel.Location = new System.Drawing.Point(215, 5);
            this.hospitalPanel.Name = "hospitalPanel";
            this.hospitalPanel.Size = new System.Drawing.Size(263, 592);
            this.hospitalPanel.TabIndex = 1;
            // 
            // bedsTable
            // 
            this.bedsTable.ColumnCount = 4;
            this.bedsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bedsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bedsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bedsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.bedsTable.Location = new System.Drawing.Point(1, 28);
            this.bedsTable.Name = "bedsTable";
            this.bedsTable.RowCount = 20;
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bedsTable.Size = new System.Drawing.Size(262, 564);
            this.bedsTable.TabIndex = 1;
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
            this.label6.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(4, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Szpital - łóżka";
            // 
            // populationPanel
            // 
            this.populationPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.populationPanel.Controls.Add(this.populationTable);
            this.populationPanel.Controls.Add(this.panel7);
            this.populationPanel.Location = new System.Drawing.Point(487, 6);
            this.populationPanel.Name = "populationPanel";
            this.populationPanel.Size = new System.Drawing.Size(617, 591);
            this.populationPanel.TabIndex = 2;
            // 
            // populationTable
            // 
            this.populationTable.ColumnCount = 10;
            this.populationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.populationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.populationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.populationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.populationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.populationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.populationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.populationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.populationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.populationTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.populationTable.Location = new System.Drawing.Point(0, 27);
            this.populationTable.Name = "populationTable";
            this.populationTable.RowCount = 10;
            this.populationTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.populationTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.populationTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.populationTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.populationTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.populationTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.populationTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.populationTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.populationTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.populationTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.populationTable.Size = new System.Drawing.Size(617, 564);
            this.populationTable.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(617, 28);
            this.panel7.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Populacja";
            // 
            // labPanel
            // 
            this.labPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.labPanel.Controls.Add(this.labTable);
            this.labPanel.Controls.Add(this.panel8);
            this.labPanel.Location = new System.Drawing.Point(1110, 6);
            this.labPanel.Name = "labPanel";
            this.labPanel.Size = new System.Drawing.Size(232, 591);
            this.labPanel.TabIndex = 3;
            // 
            // labTable
            // 
            this.labTable.ColumnCount = 4;
            this.labTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.labTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.labTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.labTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.labTable.Location = new System.Drawing.Point(0, 27);
            this.labTable.Name = "labTable";
            this.labTable.RowCount = 10;
            this.labTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.labTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.labTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.labTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.labTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.labTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.labTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.labTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.labTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.labTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.labTable.Size = new System.Drawing.Size(232, 564);
            this.labTable.TabIndex = 3;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Controls.Add(this.label8);
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(245, 28);
            this.panel8.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Laboratorium - testy";
            // 
            // vaccinesPanel
            // 
            this.vaccinesPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.vaccinesPanel.Controls.Add(this.vaccinesTable);
            this.vaccinesPanel.Location = new System.Drawing.Point(216, 602);
            this.vaccinesPanel.Name = "vaccinesPanel";
            this.vaccinesPanel.Size = new System.Drawing.Size(1126, 95);
            this.vaccinesPanel.TabIndex = 4;
            // 
            // vaccinesTable
            // 
            this.vaccinesTable.ColumnCount = 15;
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.vaccinesTable.Location = new System.Drawing.Point(0, 29);
            this.vaccinesTable.Name = "vaccinesTable";
            this.vaccinesTable.RowCount = 1;
            this.vaccinesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.vaccinesTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.vaccinesTable.Size = new System.Drawing.Size(1126, 63);
            this.vaccinesTable.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Controls.Add(this.label9);
            this.panel9.Location = new System.Drawing.Point(215, 602);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1127, 28);
            this.panel9.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Przychodnia - szczepienia";
            // 
            // stopSimulationBtn
            // 
            this.stopSimulationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopSimulationBtn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stopSimulationBtn.ForeColor = System.Drawing.Color.White;
            this.stopSimulationBtn.Location = new System.Drawing.Point(15, 527);
            this.stopSimulationBtn.Name = "stopSimulationBtn";
            this.stopSimulationBtn.Size = new System.Drawing.Size(181, 70);
            this.stopSimulationBtn.TabIndex = 13;
            this.stopSimulationBtn.Text = "STOP";
            this.stopSimulationBtn.UseVisualStyleBackColor = true;
            this.stopSimulationBtn.Click += new System.EventHandler(this.stopSimulationBtn_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 700);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.vaccinesPanel);
            this.Controls.Add(this.labPanel);
            this.Controls.Add(this.populationPanel);
            this.Controls.Add(this.hospitalPanel);
            this.Controls.Add(this.panel1);
            this.Name = "Window";
            this.Text = "Epidemia";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.hospitalPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.populationPanel.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.labPanel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.vaccinesPanel.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox testsupplytb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox canVirusMutatechb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bedsamounttb;
        private System.Windows.Forms.TextBox populationtb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox vaccinessupplytb;
        private System.Windows.Forms.Panel hospitalPanel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel populationPanel;
        private System.Windows.Forms.Panel labPanel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel vaccinesPanel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox respiratoramounttb;
        public System.Windows.Forms.Button startSimulationBtn;
        public System.Windows.Forms.TableLayoutPanel vaccinesTable;
        public System.Windows.Forms.TableLayoutPanel bedsTable;
        public System.Windows.Forms.TableLayoutPanel populationTable;
        public System.Windows.Forms.TableLayoutPanel labTable;
        private System.Windows.Forms.Button stopSimulationBtn;
    }
}

