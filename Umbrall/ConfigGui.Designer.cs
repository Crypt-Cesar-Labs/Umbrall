namespace Umbrall
{
    partial class ConfigGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigGui));
            this.tabControlConfig = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxDevice = new System.Windows.Forms.ComboBox();
            this.lbDevice = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPortDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnDBTest = new System.Windows.Forms.Button();
            this.btnModbusTest = new System.Windows.Forms.Button();
            this.tabControlConfig.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlConfig
            // 
            this.tabControlConfig.Controls.Add(this.tabPage1);
            this.tabControlConfig.Controls.Add(this.tabPage2);
            this.tabControlConfig.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlConfig.Location = new System.Drawing.Point(0, 0);
            this.tabControlConfig.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlConfig.Name = "tabControlConfig";
            this.tabControlConfig.Padding = new System.Drawing.Point(0, 0);
            this.tabControlConfig.SelectedIndex = 0;
            this.tabControlConfig.Size = new System.Drawing.Size(424, 429);
            this.tabControlConfig.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.btnModbusTest);
            this.tabPage1.Controls.Add(this.comboBoxDevice);
            this.tabPage1.Controls.Add(this.lbDevice);
            this.tabPage1.Controls.Add(this.lbPort);
            this.tabPage1.Controls.Add(this.txtPort);
            this.tabPage1.Controls.Add(this.lbAddress);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(416, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Conexión";
            // 
            // comboBoxDevice
            // 
            this.comboBoxDevice.FormattingEnabled = true;
            this.comboBoxDevice.Location = new System.Drawing.Point(248, 119);
            this.comboBoxDevice.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDevice.Name = "comboBoxDevice";
            this.comboBoxDevice.Size = new System.Drawing.Size(126, 22);
            this.comboBoxDevice.TabIndex = 8;
            this.comboBoxDevice.Text = "SENECA";
            // 
            // lbDevice
            // 
            this.lbDevice.AutoSize = true;
            this.lbDevice.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDevice.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbDevice.Location = new System.Drawing.Point(244, 98);
            this.lbDevice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDevice.Name = "lbDevice";
            this.lbDevice.Size = new System.Drawing.Size(95, 18);
            this.lbDevice.TabIndex = 7;
            this.lbDevice.Text = "Dispositivo";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPort.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbPort.Location = new System.Drawing.Point(58, 186);
            this.lbPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(62, 18);
            this.lbPort.TabIndex = 5;
            this.lbPort.Text = "Puerto";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(61, 208);
            this.txtPort.Margin = new System.Windows.Forms.Padding(2);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(65, 21);
            this.txtPort.TabIndex = 4;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbAddress.Location = new System.Drawing.Point(58, 98);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(85, 18);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Dirección";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(61, 119);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(110, 21);
            this.txtAddress.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.tabPage2.Controls.Add(this.btnDBTest);
            this.tabPage2.Controls.Add(this.txtDataBase);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtPortDB);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtPassword);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txtUser);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtHost);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(416, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Base de Datos";
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(156, 251);
            this.txtDataBase.Margin = new System.Windows.Forms.Padding(2);
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(126, 26);
            this.txtDataBase.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(7, 254);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Base de Datos";
            // 
            // txtPortDB
            // 
            this.txtPortDB.Location = new System.Drawing.Point(156, 207);
            this.txtPortDB.Margin = new System.Windows.Forms.Padding(2);
            this.txtPortDB.Name = "txtPortDB";
            this.txtPortDB.Size = new System.Drawing.Size(126, 26);
            this.txtPortDB.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(7, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Puerto";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(156, 163);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(126, 26);
            this.txtPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(7, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(7, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Usuario";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(156, 119);
            this.txtUser.Margin = new System.Windows.Forms.Padding(2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(126, 26);
            this.txtUser.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Host";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(156, 75);
            this.txtHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(253, 26);
            this.txtHost.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Location = new System.Drawing.Point(317, 433);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(96, 39);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAceptar.Location = new System.Drawing.Point(225, 433);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(88, 39);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnDBTest
            // 
            this.btnDBTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnDBTest.FlatAppearance.BorderSize = 0;
            this.btnDBTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDBTest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBTest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDBTest.Location = new System.Drawing.Point(156, 295);
            this.btnDBTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnDBTest.Name = "btnDBTest";
            this.btnDBTest.Size = new System.Drawing.Size(75, 27);
            this.btnDBTest.TabIndex = 2;
            this.btnDBTest.Text = "Test";
            this.btnDBTest.UseVisualStyleBackColor = false;
            this.btnDBTest.Click += new System.EventHandler(this.btnDBTest_Click);
            // 
            // btnModbusTest
            // 
            this.btnModbusTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(108)))));
            this.btnModbusTest.FlatAppearance.BorderSize = 0;
            this.btnModbusTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModbusTest.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModbusTest.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnModbusTest.Location = new System.Drawing.Point(247, 202);
            this.btnModbusTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnModbusTest.Name = "btnModbusTest";
            this.btnModbusTest.Size = new System.Drawing.Size(75, 27);
            this.btnModbusTest.TabIndex = 9;
            this.btnModbusTest.Text = "Test";
            this.btnModbusTest.UseVisualStyleBackColor = false;
            this.btnModbusTest.Click += new System.EventHandler(this.btnModbusTest_Click);
            // 
            // ConfigGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(424, 483);
            this.Controls.Add(this.tabControlConfig);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnCancelar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ConfigGui";
            this.Text = "Configuración";
            this.tabControlConfig.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlConfig;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox comboBoxDevice;
        private System.Windows.Forms.Label lbDevice;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPortDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Button btnDBTest;
        private System.Windows.Forms.Button btnModbusTest;
    }
}