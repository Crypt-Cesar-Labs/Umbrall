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
            this.iniciarMonitoreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detenerMonitoreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarDispositivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarifasCFEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alertasCorreoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCPIPTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modbusRTUTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modbusRTUOverTCPTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modbusTCPTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientTCPTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientSocketTCPTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.ayudaToolStripMenuItem,
            this.testToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1203, 24);
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
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menúToolStripMenuItem.Text = "Menú";
            // 
            // iniciarMonitoreoToolStripMenuItem
            // 
            this.iniciarMonitoreoToolStripMenuItem.Image = global::Umbrall.Properties.Resources.play;
            this.iniciarMonitoreoToolStripMenuItem.Name = "iniciarMonitoreoToolStripMenuItem";
            this.iniciarMonitoreoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.iniciarMonitoreoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.iniciarMonitoreoToolStripMenuItem.Text = "Iniciar Monitoreo";
            // 
            // detenerMonitoreoToolStripMenuItem
            // 
            this.detenerMonitoreoToolStripMenuItem.Image = global::Umbrall.Properties.Resources.stop;
            this.detenerMonitoreoToolStripMenuItem.Name = "detenerMonitoreoToolStripMenuItem";
            this.detenerMonitoreoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.detenerMonitoreoToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.detenerMonitoreoToolStripMenuItem.Text = "Detener Monitoreo";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(213, 6);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarDispositivoToolStripMenuItem,
            this.tarifasCFEToolStripMenuItem,
            this.alertasCorreoToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // conectarDispositivoToolStripMenuItem
            // 
            this.conectarDispositivoToolStripMenuItem.Name = "conectarDispositivoToolStripMenuItem";
            this.conectarDispositivoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.conectarDispositivoToolStripMenuItem.Text = "Conectar Dispositivo";
            // 
            // tarifasCFEToolStripMenuItem
            // 
            this.tarifasCFEToolStripMenuItem.Name = "tarifasCFEToolStripMenuItem";
            this.tarifasCFEToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.tarifasCFEToolStripMenuItem.Text = "Tarifas CFE";
            this.tarifasCFEToolStripMenuItem.Click += new System.EventHandler(this.tarifasCFEToolStripMenuItem_Click);
            // 
            // alertasCorreoToolStripMenuItem
            // 
            this.alertasCorreoToolStripMenuItem.Name = "alertasCorreoToolStripMenuItem";
            this.alertasCorreoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.alertasCorreoToolStripMenuItem.Text = "Alertas Correo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tCPIPTestToolStripMenuItem,
            this.modbusRTUTestToolStripMenuItem,
            this.modbusRTUOverTCPTestToolStripMenuItem,
            this.modbusTCPTestToolStripMenuItem,
            this.clientTCPTestToolStripMenuItem,
            this.clientSocketTCPTestToolStripMenuItem});
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.testToolStripMenuItem.Text = "Test";
            // 
            // tCPIPTestToolStripMenuItem
            // 
            this.tCPIPTestToolStripMenuItem.Name = "tCPIPTestToolStripMenuItem";
            this.tCPIPTestToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.tCPIPTestToolStripMenuItem.Text = "TCP/IP Test";
            this.tCPIPTestToolStripMenuItem.Click += new System.EventHandler(this.tCPIPTestToolStripMenuItem_Click);
            // 
            // modbusRTUTestToolStripMenuItem
            // 
            this.modbusRTUTestToolStripMenuItem.Name = "modbusRTUTestToolStripMenuItem";
            this.modbusRTUTestToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.modbusRTUTestToolStripMenuItem.Text = "Modbus RTU Test";
            this.modbusRTUTestToolStripMenuItem.Click += new System.EventHandler(this.modbusRTUTestToolStripMenuItem_Click);
            // 
            // modbusRTUOverTCPTestToolStripMenuItem
            // 
            this.modbusRTUOverTCPTestToolStripMenuItem.Name = "modbusRTUOverTCPTestToolStripMenuItem";
            this.modbusRTUOverTCPTestToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.modbusRTUOverTCPTestToolStripMenuItem.Text = "Modbus RTU over TCP Test";
            this.modbusRTUOverTCPTestToolStripMenuItem.Click += new System.EventHandler(this.modbusRTUOverTCPTestToolStripMenuItem_Click);
            // 
            // modbusTCPTestToolStripMenuItem
            // 
            this.modbusTCPTestToolStripMenuItem.Name = "modbusTCPTestToolStripMenuItem";
            this.modbusTCPTestToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.modbusTCPTestToolStripMenuItem.Text = "Modbus TCP Test";
            this.modbusTCPTestToolStripMenuItem.Click += new System.EventHandler(this.modbusTCPTestToolStripMenuItem_Click);
            // 
            // clientTCPTestToolStripMenuItem
            // 
            this.clientTCPTestToolStripMenuItem.Name = "clientTCPTestToolStripMenuItem";
            this.clientTCPTestToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.clientTCPTestToolStripMenuItem.Text = "Client TCP Test";
            this.clientTCPTestToolStripMenuItem.Click += new System.EventHandler(this.clientTCPTestToolStripMenuItem_Click);
            // 
            // clientSocketTCPTestToolStripMenuItem
            // 
            this.clientSocketTCPTestToolStripMenuItem.Name = "clientSocketTCPTestToolStripMenuItem";
            this.clientSocketTCPTestToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.clientSocketTCPTestToolStripMenuItem.Text = "Client Socket TCP Test";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 716);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCPIPTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modbusRTUTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modbusRTUOverTCPTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modbusTCPTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientTCPTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientSocketTCPTestToolStripMenuItem;
    }
}

