namespace Umbrall
{
    partial class ConsultaTarifaEmpresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaTarifaEmpresa));
            this.cmbDivInc = new System.Windows.Forms.ComboBox();
            this.btnBuscarTarifa = new System.Windows.Forms.Button();
            this.cmbTarifaInc = new System.Windows.Forms.ComboBox();
            this.cmbMonthInc = new System.Windows.Forms.ComboBox();
            this.cmbYearInc = new System.Windows.Forms.ComboBox();
            this.lbDiv = new System.Windows.Forms.Label();
            this.lbTarifa = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.Label();
            this.lbCapEne = new System.Windows.Forms.Label();
            this.txtCapEne = new System.Windows.Forms.TextBox();
            this.txtCenace = new System.Windows.Forms.TextBox();
            this.lbCenace = new System.Windows.Forms.Label();
            this.txtDistribPot = new System.Windows.Forms.TextBox();
            this.lbDistribPot = new System.Windows.Forms.Label();
            this.txtGenB = new System.Windows.Forms.TextBox();
            this.lbGenB = new System.Windows.Forms.Label();
            this.txtTransm = new System.Windows.Forms.TextBox();
            this.lbTransm = new System.Windows.Forms.Label();
            this.txtSuminis = new System.Windows.Forms.TextBox();
            this.lbSumin = new System.Windows.Forms.Label();
            this.txtScnmem = new System.Windows.Forms.TextBox();
            this.lbScnmem = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCapPot = new System.Windows.Forms.TextBox();
            this.lbCapPot = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtGenI = new System.Windows.Forms.TextBox();
            this.lbGenI = new System.Windows.Forms.Label();
            this.txtGenP = new System.Windows.Forms.TextBox();
            this.lbGenP = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lbGen = new System.Windows.Forms.Label();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.progBarQuery = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDivInc
            // 
            this.cmbDivInc.FormattingEnabled = true;
            this.cmbDivInc.Items.AddRange(new object[] {
            "Baja California",
            "Baja California Sur",
            "Bajío",
            "Centro Occidente",
            "Centro Oriente",
            "Centro Sur",
            "Golfo Centro",
            "Golfo Norte",
            "Jalisco",
            "Noroeste",
            "Norte",
            "Oriente",
            "Peninsular",
            "Sureste",
            "Valle de México Centro",
            "Valle de México Norte",
            "Valle de México Sur"});
            this.cmbDivInc.Location = new System.Drawing.Point(177, 158);
            this.cmbDivInc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDivInc.Name = "cmbDivInc";
            this.cmbDivInc.Size = new System.Drawing.Size(92, 21);
            this.cmbDivInc.TabIndex = 18;
            this.cmbDivInc.SelectedIndexChanged += new System.EventHandler(this.cmbDivInc_SelectedIndexChanged);
            // 
            // btnBuscarTarifa
            // 
            this.btnBuscarTarifa.Location = new System.Drawing.Point(111, 208);
            this.btnBuscarTarifa.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscarTarifa.Name = "btnBuscarTarifa";
            this.btnBuscarTarifa.Size = new System.Drawing.Size(95, 23);
            this.btnBuscarTarifa.TabIndex = 17;
            this.btnBuscarTarifa.Text = "Obtener cargos";
            this.btnBuscarTarifa.UseVisualStyleBackColor = true;
            this.btnBuscarTarifa.Click += new System.EventHandler(this.btnBuscarTarifa_Click);
            // 
            // cmbTarifaInc
            // 
            this.cmbTarifaInc.FormattingEnabled = true;
            this.cmbTarifaInc.Items.AddRange(new object[] {
            "GDBT",
            "GDMTH",
            "GDMTO",
            "RABT",
            "APBT",
            "APMT",
            "RAMT"});
            this.cmbTarifaInc.Location = new System.Drawing.Point(57, 158);
            this.cmbTarifaInc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTarifaInc.Name = "cmbTarifaInc";
            this.cmbTarifaInc.Size = new System.Drawing.Size(92, 21);
            this.cmbTarifaInc.TabIndex = 16;
            this.cmbTarifaInc.SelectedIndexChanged += new System.EventHandler(this.cmbTarifaInc_SelectedIndexChanged);
            // 
            // cmbMonthInc
            // 
            this.cmbMonthInc.FormattingEnabled = true;
            this.cmbMonthInc.Items.AddRange(new object[] {
            "ENERO"});
            this.cmbMonthInc.Location = new System.Drawing.Point(177, 79);
            this.cmbMonthInc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMonthInc.Name = "cmbMonthInc";
            this.cmbMonthInc.Size = new System.Drawing.Size(92, 21);
            this.cmbMonthInc.TabIndex = 15;
            this.cmbMonthInc.SelectedIndexChanged += new System.EventHandler(this.cmbMonthInc_SelectedIndexChanged);
            // 
            // cmbYearInc
            // 
            this.cmbYearInc.FormattingEnabled = true;
            this.cmbYearInc.Items.AddRange(new object[] {
            "2022"});
            this.cmbYearInc.Location = new System.Drawing.Point(57, 79);
            this.cmbYearInc.Margin = new System.Windows.Forms.Padding(2);
            this.cmbYearInc.Name = "cmbYearInc";
            this.cmbYearInc.Size = new System.Drawing.Size(92, 21);
            this.cmbYearInc.TabIndex = 14;
            this.cmbYearInc.SelectedIndexChanged += new System.EventHandler(this.cmbYearInc_SelectedIndexChanged);
            // 
            // lbDiv
            // 
            this.lbDiv.AutoSize = true;
            this.lbDiv.Location = new System.Drawing.Point(198, 130);
            this.lbDiv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDiv.Name = "lbDiv";
            this.lbDiv.Size = new System.Drawing.Size(44, 13);
            this.lbDiv.TabIndex = 13;
            this.lbDiv.Text = "División";
            // 
            // lbTarifa
            // 
            this.lbTarifa.AutoSize = true;
            this.lbTarifa.Location = new System.Drawing.Point(85, 130);
            this.lbTarifa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTarifa.Name = "lbTarifa";
            this.lbTarifa.Size = new System.Drawing.Size(34, 13);
            this.lbTarifa.TabIndex = 12;
            this.lbTarifa.Text = "Tarifa";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(198, 50);
            this.lbMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(27, 13);
            this.lbMonth.TabIndex = 11;
            this.lbMonth.Text = "Mes";
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(93, 49);
            this.lbYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(26, 13);
            this.lbYear.TabIndex = 10;
            this.lbYear.Text = "Año";
            // 
            // lbCapEne
            // 
            this.lbCapEne.AutoSize = true;
            this.lbCapEne.Location = new System.Drawing.Point(339, 53);
            this.lbCapEne.Name = "lbCapEne";
            this.lbCapEne.Size = new System.Drawing.Size(99, 13);
            this.lbCapEne.TabIndex = 23;
            this.lbCapEne.Text = "Capacidad Energía";
            // 
            // txtCapEne
            // 
            this.txtCapEne.Location = new System.Drawing.Point(342, 69);
            this.txtCapEne.Name = "txtCapEne";
            this.txtCapEne.ReadOnly = true;
            this.txtCapEne.Size = new System.Drawing.Size(100, 20);
            this.txtCapEne.TabIndex = 24;
            // 
            // txtCenace
            // 
            this.txtCenace.Location = new System.Drawing.Point(342, 323);
            this.txtCenace.Name = "txtCenace";
            this.txtCenace.ReadOnly = true;
            this.txtCenace.Size = new System.Drawing.Size(100, 20);
            this.txtCenace.TabIndex = 26;
            // 
            // lbCenace
            // 
            this.lbCenace.AutoSize = true;
            this.lbCenace.Location = new System.Drawing.Point(339, 307);
            this.lbCenace.Name = "lbCenace";
            this.lbCenace.Size = new System.Drawing.Size(50, 13);
            this.lbCenace.TabIndex = 25;
            this.lbCenace.Text = "CENACE";
            // 
            // txtDistribPot
            // 
            this.txtDistribPot.Location = new System.Drawing.Point(342, 173);
            this.txtDistribPot.Name = "txtDistribPot";
            this.txtDistribPot.ReadOnly = true;
            this.txtDistribPot.Size = new System.Drawing.Size(100, 20);
            this.txtDistribPot.TabIndex = 28;
            // 
            // lbDistribPot
            // 
            this.lbDistribPot.AutoSize = true;
            this.lbDistribPot.Location = new System.Drawing.Point(339, 157);
            this.lbDistribPot.Name = "lbDistribPot";
            this.lbDistribPot.Size = new System.Drawing.Size(107, 13);
            this.lbDistribPot.TabIndex = 27;
            this.lbDistribPot.Text = "Distribución Potencia";
            // 
            // txtGenB
            // 
            this.txtGenB.Location = new System.Drawing.Point(502, 69);
            this.txtGenB.Name = "txtGenB";
            this.txtGenB.ReadOnly = true;
            this.txtGenB.Size = new System.Drawing.Size(100, 20);
            this.txtGenB.TabIndex = 30;
            // 
            // lbGenB
            // 
            this.lbGenB.AutoSize = true;
            this.lbGenB.Location = new System.Drawing.Point(499, 53);
            this.lbGenB.Name = "lbGenB";
            this.lbGenB.Size = new System.Drawing.Size(78, 13);
            this.lbGenB.TabIndex = 29;
            this.lbGenB.Text = "Generación (B)";
            // 
            // txtTransm
            // 
            this.txtTransm.Location = new System.Drawing.Point(342, 273);
            this.txtTransm.Name = "txtTransm";
            this.txtTransm.ReadOnly = true;
            this.txtTransm.Size = new System.Drawing.Size(100, 20);
            this.txtTransm.TabIndex = 36;
            // 
            // lbTransm
            // 
            this.lbTransm.AutoSize = true;
            this.lbTransm.Location = new System.Drawing.Point(339, 257);
            this.lbTransm.Name = "lbTransm";
            this.lbTransm.Size = new System.Drawing.Size(63, 13);
            this.lbTransm.TabIndex = 35;
            this.lbTransm.Text = "Transmisión";
            // 
            // txtSuminis
            // 
            this.txtSuminis.Location = new System.Drawing.Point(502, 273);
            this.txtSuminis.Name = "txtSuminis";
            this.txtSuminis.ReadOnly = true;
            this.txtSuminis.Size = new System.Drawing.Size(100, 20);
            this.txtSuminis.TabIndex = 34;
            // 
            // lbSumin
            // 
            this.lbSumin.AutoSize = true;
            this.lbSumin.Location = new System.Drawing.Point(499, 257);
            this.lbSumin.Name = "lbSumin";
            this.lbSumin.Size = new System.Drawing.Size(55, 13);
            this.lbSumin.TabIndex = 33;
            this.lbSumin.Text = "Suministro";
            // 
            // txtScnmem
            // 
            this.txtScnmem.Location = new System.Drawing.Point(342, 224);
            this.txtScnmem.Name = "txtScnmem";
            this.txtScnmem.ReadOnly = true;
            this.txtScnmem.Size = new System.Drawing.Size(100, 20);
            this.txtScnmem.TabIndex = 32;
            // 
            // lbScnmem
            // 
            this.lbScnmem.AutoSize = true;
            this.lbScnmem.Location = new System.Drawing.Point(339, 208);
            this.lbScnmem.Name = "lbScnmem";
            this.lbScnmem.Size = new System.Drawing.Size(52, 13);
            this.lbScnmem.TabIndex = 31;
            this.lbScnmem.Text = "SCnMEM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Umbrall.Properties.Resources.factory21;
            this.pictureBox1.InitialImage = global::Umbrall.Properties.Resources.factory11;
            this.pictureBox1.Location = new System.Drawing.Point(111, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 93);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(438, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Aceptar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtCapPot
            // 
            this.txtCapPot.Location = new System.Drawing.Point(342, 119);
            this.txtCapPot.Name = "txtCapPot";
            this.txtCapPot.ReadOnly = true;
            this.txtCapPot.Size = new System.Drawing.Size(100, 20);
            this.txtCapPot.TabIndex = 45;
            // 
            // lbCapPot
            // 
            this.lbCapPot.AutoSize = true;
            this.lbCapPot.Location = new System.Drawing.Point(339, 103);
            this.lbCapPot.Name = "lbCapPot";
            this.lbCapPot.Size = new System.Drawing.Size(103, 13);
            this.lbCapPot.TabIndex = 44;
            this.lbCapPot.Text = "Capacidad Potencia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(448, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "$/kW";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(448, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "$/kWh";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(448, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "$/kWh";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(448, 227);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 50;
            this.label15.Text = "$/kWh";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(448, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "$/kWh";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(448, 326);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 52;
            this.label17.Text = "$/kWh";
            // 
            // txtGenI
            // 
            this.txtGenI.Location = new System.Drawing.Point(502, 119);
            this.txtGenI.Name = "txtGenI";
            this.txtGenI.ReadOnly = true;
            this.txtGenI.Size = new System.Drawing.Size(100, 20);
            this.txtGenI.TabIndex = 54;
            // 
            // lbGenI
            // 
            this.lbGenI.AutoSize = true;
            this.lbGenI.Location = new System.Drawing.Point(499, 103);
            this.lbGenI.Name = "lbGenI";
            this.lbGenI.Size = new System.Drawing.Size(74, 13);
            this.lbGenI.TabIndex = 53;
            this.lbGenI.Text = "Generación (I)";
            // 
            // txtGenP
            // 
            this.txtGenP.Location = new System.Drawing.Point(502, 173);
            this.txtGenP.Name = "txtGenP";
            this.txtGenP.ReadOnly = true;
            this.txtGenP.Size = new System.Drawing.Size(100, 20);
            this.txtGenP.TabIndex = 56;
            // 
            // lbGenP
            // 
            this.lbGenP.AutoSize = true;
            this.lbGenP.Location = new System.Drawing.Point(499, 157);
            this.lbGenP.Name = "lbGenP";
            this.lbGenP.Size = new System.Drawing.Size(78, 13);
            this.lbGenP.TabIndex = 55;
            this.lbGenP.Text = "Generación (P)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(608, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 13);
            this.label21.TabIndex = 59;
            this.label21.Text = "$/kWh";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(608, 122);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 60;
            this.label22.Text = "$/kWh";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(608, 176);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 13);
            this.label23.TabIndex = 61;
            this.label23.Text = "$/kWh";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(608, 280);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(50, 13);
            this.label25.TabIndex = 63;
            this.label25.Text = "$/Cliente";
            // 
            // lbGen
            // 
            this.lbGen.AutoSize = true;
            this.lbGen.Location = new System.Drawing.Point(499, 208);
            this.lbGen.Name = "lbGen";
            this.lbGen.Size = new System.Drawing.Size(62, 13);
            this.lbGen.TabIndex = 37;
            this.lbGen.Text = "Generación";
            // 
            // txtGen
            // 
            this.txtGen.Location = new System.Drawing.Point(502, 224);
            this.txtGen.Name = "txtGen";
            this.txtGen.ReadOnly = true;
            this.txtGen.Size = new System.Drawing.Size(100, 20);
            this.txtGen.TabIndex = 38;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(608, 231);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(41, 13);
            this.label26.TabIndex = 64;
            this.label26.Text = "$/kWh";
            // 
            // progBarQuery
            // 
            this.progBarQuery.Location = new System.Drawing.Point(211, 208);
            this.progBarQuery.Name = "progBarQuery";
            this.progBarQuery.Size = new System.Drawing.Size(100, 23);
            this.progBarQuery.TabIndex = 65;
            this.progBarQuery.Visible = false;
            // 
            // ConsultaTarifaEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 450);
            this.Controls.Add(this.progBarQuery);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.txtGenP);
            this.Controls.Add(this.lbGenP);
            this.Controls.Add(this.txtGenI);
            this.Controls.Add(this.lbGenI);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCapPot);
            this.Controls.Add(this.lbCapPot);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.lbGen);
            this.Controls.Add(this.txtTransm);
            this.Controls.Add(this.lbTransm);
            this.Controls.Add(this.txtSuminis);
            this.Controls.Add(this.lbSumin);
            this.Controls.Add(this.txtScnmem);
            this.Controls.Add(this.lbScnmem);
            this.Controls.Add(this.txtGenB);
            this.Controls.Add(this.lbGenB);
            this.Controls.Add(this.txtDistribPot);
            this.Controls.Add(this.lbDistribPot);
            this.Controls.Add(this.txtCenace);
            this.Controls.Add(this.lbCenace);
            this.Controls.Add(this.txtCapEne);
            this.Controls.Add(this.lbCapEne);
            this.Controls.Add(this.cmbDivInc);
            this.Controls.Add(this.btnBuscarTarifa);
            this.Controls.Add(this.cmbTarifaInc);
            this.Controls.Add(this.cmbMonthInc);
            this.Controls.Add(this.cmbYearInc);
            this.Controls.Add(this.lbDiv);
            this.Controls.Add(this.lbTarifa);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.lbYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaTarifaEmpresa";
            this.Text = "Umbrall - Consulta de la tarifa para empresa o negocio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDivInc;
        private System.Windows.Forms.Button btnBuscarTarifa;
        private System.Windows.Forms.ComboBox cmbTarifaInc;
        private System.Windows.Forms.ComboBox cmbMonthInc;
        private System.Windows.Forms.ComboBox cmbYearInc;
        private System.Windows.Forms.Label lbDiv;
        private System.Windows.Forms.Label lbTarifa;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbCapEne;
        private System.Windows.Forms.TextBox txtCapEne;
        private System.Windows.Forms.TextBox txtCenace;
        private System.Windows.Forms.Label lbCenace;
        private System.Windows.Forms.Label lbDistribPot;
        private System.Windows.Forms.TextBox txtGenB;
        private System.Windows.Forms.Label lbGenB;
        private System.Windows.Forms.TextBox txtTransm;
        private System.Windows.Forms.Label lbTransm;
        private System.Windows.Forms.TextBox txtSuminis;
        private System.Windows.Forms.Label lbSumin;
        private System.Windows.Forms.TextBox txtScnmem;
        private System.Windows.Forms.Label lbScnmem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtDistribPot;
        private System.Windows.Forms.TextBox txtCapPot;
        private System.Windows.Forms.Label lbCapPot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGenI;
        private System.Windows.Forms.Label lbGenI;
        private System.Windows.Forms.TextBox txtGenP;
        private System.Windows.Forms.Label lbGenP;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lbGen;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ProgressBar progBarQuery;
    }
}