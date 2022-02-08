namespace Umbrall
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarDispositivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifasCFEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertasCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iniciarMonitoreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerMonitoreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.acercaDeToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarMonitoreoToolStripMenuItem,
            this.detenerMonitoreoToolStripMenuItem,
            this.toolStripSeparator1,
            this.configuraciónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(269, 6);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarDispositivoToolStripMenuItem,
            this.tarifasCFEToolStripMenuItem,
            this.alertasCorreoToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // conectarDispositivoToolStripMenuItem
            // 
            this.conectarDispositivoToolStripMenuItem.Name = "conectarDispositivoToolStripMenuItem";
            this.conectarDispositivoToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.conectarDispositivoToolStripMenuItem.Text = "Conectar Dispositivo";
            // 
            // tarifasCFEToolStripMenuItem
            // 
            this.tarifasCFEToolStripMenuItem.Name = "tarifasCFEToolStripMenuItem";
            this.tarifasCFEToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.tarifasCFEToolStripMenuItem.Text = "Tarifas CFE";
            this.tarifasCFEToolStripMenuItem.Click += new System.EventHandler(this.tarifasCFEToolStripMenuItem_Click);
            // 
            // alertasCorreoToolStripMenuItem
            // 
            this.alertasCorreoToolStripMenuItem.Name = "alertasCorreoToolStripMenuItem";
            this.alertasCorreoToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.alertasCorreoToolStripMenuItem.Text = "Alertas Correo";
            // 
            // iniciarMonitoreoToolStripMenuItem
            // 
            this.iniciarMonitoreoToolStripMenuItem.Image = global::Umbrall.Properties.Resources.play;
            this.iniciarMonitoreoToolStripMenuItem.Name = "iniciarMonitoreoToolStripMenuItem";
            this.iniciarMonitoreoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.iniciarMonitoreoToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.iniciarMonitoreoToolStripMenuItem.Text = "Iniciar Monitoreo";
            // 
            // detenerMonitoreoToolStripMenuItem
            // 
            this.detenerMonitoreoToolStripMenuItem.Image = global::Umbrall.Properties.Resources.stop;
            this.detenerMonitoreoToolStripMenuItem.Name = "detenerMonitoreoToolStripMenuItem";
            this.detenerMonitoreoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.detenerMonitoreoToolStripMenuItem.Size = new System.Drawing.Size(272, 26);
            this.detenerMonitoreoToolStripMenuItem.Text = "Detener Monitoreo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Umbrall - Monitor de Energía";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menúToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iniciarMonitoreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detenerMonitoreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conectarDispositivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarifasCFEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alertasCorreoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

