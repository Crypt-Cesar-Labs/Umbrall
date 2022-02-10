namespace Umbrall
{
    partial class tarifaCFE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tarifaCFE));
            this.lbYear = new System.Windows.Forms.Label();
            this.lbMonth = new System.Windows.Forms.Label();
            this.lbDiv = new System.Windows.Forms.Label();
            this.lbCat = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.btnBuscarTarifa = new System.Windows.Forms.Button();
            this.cmbDiv = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbYear
            // 
            this.lbYear.AutoSize = true;
            this.lbYear.Location = new System.Drawing.Point(69, 74);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(31, 16);
            this.lbYear.TabIndex = 0;
            this.lbYear.Text = "Año";
            // 
            // lbMonth
            // 
            this.lbMonth.AutoSize = true;
            this.lbMonth.Location = new System.Drawing.Point(240, 74);
            this.lbMonth.Name = "lbMonth";
            this.lbMonth.Size = new System.Drawing.Size(33, 16);
            this.lbMonth.TabIndex = 1;
            this.lbMonth.Text = "Mes";
            // 
            // lbDiv
            // 
            this.lbDiv.AutoSize = true;
            this.lbDiv.Location = new System.Drawing.Point(395, 74);
            this.lbDiv.Name = "lbDiv";
            this.lbDiv.Size = new System.Drawing.Size(55, 16);
            this.lbDiv.TabIndex = 2;
            this.lbDiv.Text = "División";
            // 
            // lbCat
            // 
            this.lbCat.AutoSize = true;
            this.lbCat.Location = new System.Drawing.Point(560, 74);
            this.lbCat.Name = "lbCat";
            this.lbCat.Size = new System.Drawing.Size(66, 16);
            this.lbCat.TabIndex = 3;
            this.lbCat.Text = "Categoría";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2021",
            "2022"});
            this.cmbYear.Location = new System.Drawing.Point(22, 111);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 24);
            this.cmbYear.TabIndex = 4;
            this.cmbYear.SelectedIndexChanged += new System.EventHandler(this.cmbYear_SelectedIndexChanged);
            // 
            // cmbMonth
            // 
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "enero"});
            this.cmbMonth.Location = new System.Drawing.Point(192, 111);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(121, 24);
            this.cmbMonth.TabIndex = 5;
            this.cmbMonth.SelectedIndexChanged += new System.EventHandler(this.cmbMonth_SelectedIndexChanged);
            // 
            // cmbCat
            // 
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Items.AddRange(new object[] {
            "db1",
            "db2",
            "pdbt",
            "gdbt",
            "gdmth",
            "gdmto",
            "rabt",
            "apbt",
            "apmt",
            "ramt"});
            this.cmbCat.Location = new System.Drawing.Point(532, 111);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(121, 24);
            this.cmbCat.TabIndex = 7;
            this.cmbCat.SelectedIndexChanged += new System.EventHandler(this.cmbCat_SelectedIndexChanged);
            // 
            // btnBuscarTarifa
            // 
            this.btnBuscarTarifa.Location = new System.Drawing.Point(729, 112);
            this.btnBuscarTarifa.Name = "btnBuscarTarifa";
            this.btnBuscarTarifa.Size = new System.Drawing.Size(133, 23);
            this.btnBuscarTarifa.TabIndex = 8;
            this.btnBuscarTarifa.Text = "Buscar Tarifa";
            this.btnBuscarTarifa.UseVisualStyleBackColor = true;
            this.btnBuscarTarifa.Click += new System.EventHandler(this.btnBuscarTarifa_Click);
            // 
            // cmbDiv
            // 
            this.cmbDiv.FormattingEnabled = true;
            this.cmbDiv.Items.AddRange(new object[] {
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
            this.cmbDiv.Location = new System.Drawing.Point(365, 112);
            this.cmbDiv.Name = "cmbDiv";
            this.cmbDiv.Size = new System.Drawing.Size(121, 24);
            this.cmbDiv.TabIndex = 9;
            this.cmbDiv.SelectedIndexChanged += new System.EventHandler(this.cmbDiv_SelectedIndexChanged);
            // 
            // tarifaCFE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 547);
            this.Controls.Add(this.cmbDiv);
            this.Controls.Add(this.btnBuscarTarifa);
            this.Controls.Add(this.cmbCat);
            this.Controls.Add(this.cmbMonth);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.lbCat);
            this.Controls.Add(this.lbDiv);
            this.Controls.Add(this.lbMonth);
            this.Controls.Add(this.lbYear);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tarifaCFE";
            this.Text = "tarifaCFE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.Label lbMonth;
        private System.Windows.Forms.Label lbDiv;
        private System.Windows.Forms.Label lbCat;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Button btnBuscarTarifa;
        private System.Windows.Forms.ComboBox cmbDiv;
    }
}