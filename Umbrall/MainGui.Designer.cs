namespace Umbrall
{
    partial class MainGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGui));
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.panelControlMonitor = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.panelSubCalculator = new System.Windows.Forms.Panel();
            this.btnCalcO = new System.Windows.Forms.Button();
            this.btnCalcH = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.panelSubReports = new System.Windows.Forms.Panel();
            this.btnCharts = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panelSubMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.logoPimeMain = new System.Windows.Forms.PictureBox();
            this.panelSlideMenu.SuspendLayout();
            this.panelControlMonitor.SuspendLayout();
            this.panelSubCalculator.SuspendLayout();
            this.panelSubReports.SuspendLayout();
            this.panelSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelConfig.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPimeMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.AutoScroll = true;
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.panelSlideMenu.Controls.Add(this.panelControlMonitor);
            this.panelSlideMenu.Controls.Add(this.btnHelp);
            this.panelSlideMenu.Controls.Add(this.panelSubCalculator);
            this.panelSlideMenu.Controls.Add(this.btnCalculator);
            this.panelSlideMenu.Controls.Add(this.panelSubReports);
            this.panelSlideMenu.Controls.Add(this.btnReports);
            this.panelSlideMenu.Controls.Add(this.panelSubMenu);
            this.panelSlideMenu.Controls.Add(this.btnMenu);
            this.panelSlideMenu.Controls.Add(this.panelLogo);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(207, 701);
            this.panelSlideMenu.TabIndex = 0;
            // 
            // panelControlMonitor
            // 
            this.panelControlMonitor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelControlMonitor.Controls.Add(this.btnSave);
            this.panelControlMonitor.Controls.Add(this.btnStop);
            this.panelControlMonitor.Controls.Add(this.btnPlay);
            this.panelControlMonitor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlMonitor.Location = new System.Drawing.Point(0, 636);
            this.panelControlMonitor.Name = "panelControlMonitor";
            this.panelControlMonitor.Size = new System.Drawing.Size(207, 65);
            this.panelControlMonitor.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Umbrall.Properties.Resources.savew;
            this.btnSave.Location = new System.Drawing.Point(138, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 65);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Image = global::Umbrall.Properties.Resources.stopw;
            this.btnStop.Location = new System.Drawing.Point(69, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(69, 65);
            this.btnStop.TabIndex = 1;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::Umbrall.Properties.Resources.playw;
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(69, 65);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.Location = new System.Drawing.Point(0, 502);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(207, 45);
            this.btnHelp.TabIndex = 6;
            this.btnHelp.Text = "AYUDA";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelSubCalculator
            // 
            this.panelSubCalculator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubCalculator.Controls.Add(this.btnCalcO);
            this.panelSubCalculator.Controls.Add(this.btnCalcH);
            this.panelSubCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubCalculator.Location = new System.Drawing.Point(0, 402);
            this.panelSubCalculator.Name = "panelSubCalculator";
            this.panelSubCalculator.Size = new System.Drawing.Size(207, 100);
            this.panelSubCalculator.TabIndex = 5;
            // 
            // btnCalcO
            // 
            this.btnCalcO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcO.FlatAppearance.BorderSize = 0;
            this.btnCalcO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcO.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalcO.Location = new System.Drawing.Point(0, 45);
            this.btnCalcO.Name = "btnCalcO";
            this.btnCalcO.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCalcO.Size = new System.Drawing.Size(207, 45);
            this.btnCalcO.TabIndex = 3;
            this.btnCalcO.Text = "Ordinaría";
            this.btnCalcO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcO.UseVisualStyleBackColor = true;
            this.btnCalcO.Click += new System.EventHandler(this.btnCalcO_Click);
            // 
            // btnCalcH
            // 
            this.btnCalcH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalcH.FlatAppearance.BorderSize = 0;
            this.btnCalcH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcH.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalcH.Location = new System.Drawing.Point(0, 0);
            this.btnCalcH.Name = "btnCalcH";
            this.btnCalcH.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCalcH.Size = new System.Drawing.Size(207, 45);
            this.btnCalcH.TabIndex = 2;
            this.btnCalcH.Text = "Horaria";
            this.btnCalcH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcH.UseVisualStyleBackColor = true;
            this.btnCalcH.Click += new System.EventHandler(this.btnCalcH_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalculator.FlatAppearance.BorderSize = 0;
            this.btnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculator.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalculator.Location = new System.Drawing.Point(0, 357);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCalculator.Size = new System.Drawing.Size(207, 45);
            this.btnCalculator.TabIndex = 4;
            this.btnCalculator.Text = "CALCULADORA";
            this.btnCalculator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // panelSubReports
            // 
            this.panelSubReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubReports.Controls.Add(this.btnCharts);
            this.panelSubReports.Controls.Add(this.btnBilling);
            this.panelSubReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubReports.Location = new System.Drawing.Point(0, 257);
            this.panelSubReports.Name = "panelSubReports";
            this.panelSubReports.Size = new System.Drawing.Size(207, 100);
            this.panelSubReports.TabIndex = 3;
            // 
            // btnCharts
            // 
            this.btnCharts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCharts.FlatAppearance.BorderSize = 0;
            this.btnCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCharts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCharts.Location = new System.Drawing.Point(0, 45);
            this.btnCharts.Name = "btnCharts";
            this.btnCharts.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnCharts.Size = new System.Drawing.Size(207, 45);
            this.btnCharts.TabIndex = 1;
            this.btnCharts.Text = "Gráficos";
            this.btnCharts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCharts.UseVisualStyleBackColor = true;
            this.btnCharts.Click += new System.EventHandler(this.btnCharts_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBilling.FlatAppearance.BorderSize = 0;
            this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilling.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBilling.Location = new System.Drawing.Point(0, 0);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnBilling.Size = new System.Drawing.Size(207, 45);
            this.btnBilling.TabIndex = 0;
            this.btnBilling.Text = "Facturación";
            this.btnBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReports.Location = new System.Drawing.Point(0, 212);
            this.btnReports.Name = "btnReports";
            this.btnReports.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReports.Size = new System.Drawing.Size(207, 45);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "REPORTES";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panelSubMenu
            // 
            this.panelSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelSubMenu.Controls.Add(this.btnSalir);
            this.panelSubMenu.Controls.Add(this.btnMonitor);
            this.panelSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenu.Location = new System.Drawing.Point(0, 120);
            this.panelSubMenu.Name = "panelSubMenu";
            this.panelSubMenu.Size = new System.Drawing.Size(207, 92);
            this.panelSubMenu.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Location = new System.Drawing.Point(0, 40);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(207, 40);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMonitor.FlatAppearance.BorderSize = 0;
            this.btnMonitor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitor.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMonitor.Location = new System.Drawing.Point(0, 0);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnMonitor.Size = new System.Drawing.Size(207, 40);
            this.btnMonitor.TabIndex = 0;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenu.FlatAppearance.BorderSize = 0;
            this.btnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMenu.Location = new System.Drawing.Point(0, 80);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenu.Size = new System.Drawing.Size(207, 40);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "MENÚ";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(207, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Umbrall.Properties.Resources.PIMEFondooscurorecortada2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelConfig
            // 
            this.panelConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.panelConfig.Controls.Add(this.btnPrint);
            this.panelConfig.Controls.Add(this.btnConfig);
            this.panelConfig.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelConfig.Location = new System.Drawing.Point(1114, 0);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(61, 701);
            this.panelConfig.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = global::Umbrall.Properties.Resources.pdfSaveRedW;
            this.btnPrint.Location = new System.Drawing.Point(0, 55);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(61, 55);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Image = global::Umbrall.Properties.Resources.wheelredimw;
            this.btnConfig.Location = new System.Drawing.Point(0, 0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(61, 55);
            this.btnConfig.TabIndex = 0;
            this.btnConfig.UseVisualStyleBackColor = true;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelChildForm.Controls.Add(this.logoPimeMain);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(207, 0);
            this.panelChildForm.MinimumSize = new System.Drawing.Size(884, 694);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(907, 701);
            this.panelChildForm.TabIndex = 2;
            // 
            // logoPimeMain
            // 
            this.logoPimeMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoPimeMain.Image = ((System.Drawing.Image)(resources.GetObject("logoPimeMain.Image")));
            this.logoPimeMain.Location = new System.Drawing.Point(182, 257);
            this.logoPimeMain.Name = "logoPimeMain";
            this.logoPimeMain.Size = new System.Drawing.Size(590, 190);
            this.logoPimeMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.logoPimeMain.TabIndex = 0;
            this.logoPimeMain.TabStop = false;
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 701);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.panelSlideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1136, 694);
            this.Name = "MainGui";
            this.Text = "PIME";
            this.panelSlideMenu.ResumeLayout(false);
            this.panelControlMonitor.ResumeLayout(false);
            this.panelSubCalculator.ResumeLayout(false);
            this.panelSubReports.ResumeLayout(false);
            this.panelSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelConfig.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPimeMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Panel panelSubMenu;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panelSubReports;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelSubCalculator;
        private System.Windows.Forms.Button btnCalcO;
        private System.Windows.Forms.Button btnCalcH;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnCharts;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Panel panelControlMonitor;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox logoPimeMain;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPrint;
    }
}