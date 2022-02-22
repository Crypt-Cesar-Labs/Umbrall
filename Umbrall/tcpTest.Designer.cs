namespace Umbrall
{
    partial class tcpTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tcpTest));
            this.btnClientTcpConnect = new System.Windows.Forms.Button();
            this.lbServer = new System.Windows.Forms.Label();
            this.btnServerTcpConnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lbServerAdd = new System.Windows.Forms.Label();
            this.lbServerPort = new System.Windows.Forms.Label();
            this.txtServerPort = new System.Windows.Forms.TextBox();
            this.lbServerData = new System.Windows.Forms.Label();
            this.txtServerData = new System.Windows.Forms.TextBox();
            this.btnServerSendData = new System.Windows.Forms.Button();
            this.btnClientSendData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtClientData = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClientPort = new System.Windows.Forms.TextBox();
            this.lbClientAdd = new System.Windows.Forms.Label();
            this.txtClientAdd = new System.Windows.Forms.TextBox();
            this.lbClient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClientTcpConnect
            // 
            this.btnClientTcpConnect.Location = new System.Drawing.Point(411, 246);
            this.btnClientTcpConnect.Name = "btnClientTcpConnect";
            this.btnClientTcpConnect.Size = new System.Drawing.Size(101, 23);
            this.btnClientTcpConnect.TabIndex = 0;
            this.btnClientTcpConnect.Text = "Conectar";
            this.btnClientTcpConnect.UseVisualStyleBackColor = true;
            this.btnClientTcpConnect.Click += new System.EventHandler(this.btnClientTcpConnect_Click);
            // 
            // lbServer
            // 
            this.lbServer.AutoSize = true;
            this.lbServer.Location = new System.Drawing.Point(55, 44);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(58, 16);
            this.lbServer.TabIndex = 1;
            this.lbServer.Text = "Servidor";
            // 
            // btnServerTcpConnect
            // 
            this.btnServerTcpConnect.Location = new System.Drawing.Point(58, 246);
            this.btnServerTcpConnect.Name = "btnServerTcpConnect";
            this.btnServerTcpConnect.Size = new System.Drawing.Size(113, 23);
            this.btnServerTcpConnect.TabIndex = 2;
            this.btnServerTcpConnect.Text = "Conectar";
            this.btnServerTcpConnect.UseVisualStyleBackColor = true;
            this.btnServerTcpConnect.Click += new System.EventHandler(this.btnServerTcpConnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(58, 94);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(167, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "127.0.0.1";
            // 
            // lbServerAdd
            // 
            this.lbServerAdd.AutoSize = true;
            this.lbServerAdd.Location = new System.Drawing.Point(55, 75);
            this.lbServerAdd.Name = "lbServerAdd";
            this.lbServerAdd.Size = new System.Drawing.Size(64, 16);
            this.lbServerAdd.TabIndex = 4;
            this.lbServerAdd.Text = "Dirección";
            // 
            // lbServerPort
            // 
            this.lbServerPort.AutoSize = true;
            this.lbServerPort.Location = new System.Drawing.Point(55, 129);
            this.lbServerPort.Name = "lbServerPort";
            this.lbServerPort.Size = new System.Drawing.Size(46, 16);
            this.lbServerPort.TabIndex = 6;
            this.lbServerPort.Text = "Puerto";
            // 
            // txtServerPort
            // 
            this.txtServerPort.Location = new System.Drawing.Point(58, 148);
            this.txtServerPort.Name = "txtServerPort";
            this.txtServerPort.ReadOnly = true;
            this.txtServerPort.Size = new System.Drawing.Size(167, 22);
            this.txtServerPort.TabIndex = 5;
            this.txtServerPort.Text = "9898";
            // 
            // lbServerData
            // 
            this.lbServerData.AutoSize = true;
            this.lbServerData.Location = new System.Drawing.Point(55, 185);
            this.lbServerData.Name = "lbServerData";
            this.lbServerData.Size = new System.Drawing.Size(36, 16);
            this.lbServerData.TabIndex = 8;
            this.lbServerData.Text = "Data";
            // 
            // txtServerData
            // 
            this.txtServerData.Location = new System.Drawing.Point(58, 204);
            this.txtServerData.Name = "txtServerData";
            this.txtServerData.Size = new System.Drawing.Size(167, 22);
            this.txtServerData.TabIndex = 7;
            // 
            // btnServerSendData
            // 
            this.btnServerSendData.Location = new System.Drawing.Point(231, 204);
            this.btnServerSendData.Name = "btnServerSendData";
            this.btnServerSendData.Size = new System.Drawing.Size(75, 23);
            this.btnServerSendData.TabIndex = 9;
            this.btnServerSendData.Text = "Enviar";
            this.btnServerSendData.UseVisualStyleBackColor = true;
            // 
            // btnClientSendData
            // 
            this.btnClientSendData.Location = new System.Drawing.Point(584, 204);
            this.btnClientSendData.Name = "btnClientSendData";
            this.btnClientSendData.Size = new System.Drawing.Size(75, 23);
            this.btnClientSendData.TabIndex = 17;
            this.btnClientSendData.Text = "Enviar";
            this.btnClientSendData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(408, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Data";
            // 
            // txtClientData
            // 
            this.txtClientData.Location = new System.Drawing.Point(411, 204);
            this.txtClientData.Name = "txtClientData";
            this.txtClientData.Size = new System.Drawing.Size(167, 22);
            this.txtClientData.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(408, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Puerto";
            // 
            // txtClientPort
            // 
            this.txtClientPort.Location = new System.Drawing.Point(411, 148);
            this.txtClientPort.Name = "txtClientPort";
            this.txtClientPort.Size = new System.Drawing.Size(167, 22);
            this.txtClientPort.TabIndex = 13;
            // 
            // lbClientAdd
            // 
            this.lbClientAdd.AutoSize = true;
            this.lbClientAdd.Location = new System.Drawing.Point(408, 75);
            this.lbClientAdd.Name = "lbClientAdd";
            this.lbClientAdd.Size = new System.Drawing.Size(64, 16);
            this.lbClientAdd.TabIndex = 12;
            this.lbClientAdd.Text = "Dirección";
            // 
            // txtClientAdd
            // 
            this.txtClientAdd.Location = new System.Drawing.Point(411, 94);
            this.txtClientAdd.Name = "txtClientAdd";
            this.txtClientAdd.Size = new System.Drawing.Size(167, 22);
            this.txtClientAdd.TabIndex = 11;
            // 
            // lbClient
            // 
            this.lbClient.AutoSize = true;
            this.lbClient.Location = new System.Drawing.Point(408, 44);
            this.lbClient.Name = "lbClient";
            this.lbClient.Size = new System.Drawing.Size(48, 16);
            this.lbClient.TabIndex = 10;
            this.lbClient.Text = "Cliente";
            // 
            // tcpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 543);
            this.Controls.Add(this.btnClientSendData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClientData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClientPort);
            this.Controls.Add(this.lbClientAdd);
            this.Controls.Add(this.txtClientAdd);
            this.Controls.Add(this.lbClient);
            this.Controls.Add(this.btnServerSendData);
            this.Controls.Add(this.lbServerData);
            this.Controls.Add(this.txtServerData);
            this.Controls.Add(this.lbServerPort);
            this.Controls.Add(this.txtServerPort);
            this.Controls.Add(this.lbServerAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnServerTcpConnect);
            this.Controls.Add(this.lbServer);
            this.Controls.Add(this.btnClientTcpConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tcpTest";
            this.Text = "Umbrall - TCP Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClientTcpConnect;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.Button btnServerTcpConnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbServerAdd;
        private System.Windows.Forms.Label lbServerPort;
        private System.Windows.Forms.TextBox txtServerPort;
        private System.Windows.Forms.Label lbServerData;
        private System.Windows.Forms.TextBox txtServerData;
        private System.Windows.Forms.Button btnServerSendData;
        private System.Windows.Forms.Button btnClientSendData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtClientData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClientPort;
        private System.Windows.Forms.Label lbClientAdd;
        private System.Windows.Forms.TextBox txtClientAdd;
        private System.Windows.Forms.Label lbClient;
    }
}