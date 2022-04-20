namespace Umbrall
{
    partial class CalculadoraSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculadoraSelector));
            this.btnOrdinara = new System.Windows.Forms.Button();
            this.btnHoraria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOrdinara
            // 
            this.btnOrdinara.Location = new System.Drawing.Point(12, 62);
            this.btnOrdinara.Name = "btnOrdinara";
            this.btnOrdinara.Size = new System.Drawing.Size(172, 23);
            this.btnOrdinara.TabIndex = 0;
            this.btnOrdinara.Text = "Calculadora Tarifa Ordinaría";
            this.btnOrdinara.UseVisualStyleBackColor = true;
            this.btnOrdinara.Click += new System.EventHandler(this.btnOrdinara_Click);
            // 
            // btnHoraria
            // 
            this.btnHoraria.Location = new System.Drawing.Point(12, 24);
            this.btnHoraria.Name = "btnHoraria";
            this.btnHoraria.Size = new System.Drawing.Size(172, 23);
            this.btnHoraria.TabIndex = 1;
            this.btnHoraria.Text = "Calculadora Tarifa Horaria";
            this.btnHoraria.UseVisualStyleBackColor = true;
            this.btnHoraria.Click += new System.EventHandler(this.btnHoraria_Click);
            // 
            // CalculadoraSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 106);
            this.Controls.Add(this.btnHoraria);
            this.Controls.Add(this.btnOrdinara);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalculadoraSelector";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrdinara;
        private System.Windows.Forms.Button btnHoraria;
    }
}