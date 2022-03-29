namespace Umbrall
{
    partial class ConsultaTarifaForm1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaTarifaForm1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDomestic = new System.Windows.Forms.Button();
            this.btnEnterprise = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Umbrall.Properties.Resources.factory11;
            this.pictureBox2.InitialImage = global::Umbrall.Properties.Resources.factory;
            this.pictureBox2.Location = new System.Drawing.Point(348, 147);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(130, 127);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Umbrall.Properties.Resources.home1;
            this.pictureBox1.Location = new System.Drawing.Point(81, 147);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnDomestic
            // 
            this.btnDomestic.Location = new System.Drawing.Point(81, 339);
            this.btnDomestic.Margin = new System.Windows.Forms.Padding(5);
            this.btnDomestic.Name = "btnDomestic";
            this.btnDomestic.Size = new System.Drawing.Size(130, 23);
            this.btnDomestic.TabIndex = 2;
            this.btnDomestic.Text = "Doméstico";
            this.btnDomestic.UseVisualStyleBackColor = true;
            this.btnDomestic.Click += new System.EventHandler(this.btnDomestic_Click);
            // 
            // btnEnterprise
            // 
            this.btnEnterprise.Location = new System.Drawing.Point(348, 339);
            this.btnEnterprise.Margin = new System.Windows.Forms.Padding(5);
            this.btnEnterprise.Name = "btnEnterprise";
            this.btnEnterprise.Size = new System.Drawing.Size(130, 23);
            this.btnEnterprise.TabIndex = 3;
            this.btnEnterprise.Text = "Industria";
            this.btnEnterprise.UseVisualStyleBackColor = true;
            this.btnEnterprise.Click += new System.EventHandler(this.btnEnterprise_Click);
            // 
            // ConsultaTarifaForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 450);
            this.Controls.Add(this.btnEnterprise);
            this.Controls.Add(this.btnDomestic);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultaTarifaForm1";
            this.Text = "Umbrall - Consulta de la tarifa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDomestic;
        private System.Windows.Forms.Button btnEnterprise;
    }
}