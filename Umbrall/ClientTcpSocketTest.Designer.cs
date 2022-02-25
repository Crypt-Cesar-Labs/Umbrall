namespace Umbrall
{
    partial class ClientTcpSocketTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientTcpSocketTest));
            this.lbClientSocketTestTitle = new System.Windows.Forms.Label();
            this.lbClientSocketTcpTestAdd = new System.Windows.Forms.Label();
            this.txtClientSocketTcpTestAdd = new System.Windows.Forms.TextBox();
            this.lbPort = new System.Windows.Forms.Label();
            this.txtClientSocketTcpTestPort = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.lbClientSocketTcpTestMsg = new System.Windows.Forms.Label();
            this.txtClientSocketTcpTestMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbClientSocketTestTitle
            // 
            this.lbClientSocketTestTitle.AutoSize = true;
            this.lbClientSocketTestTitle.Location = new System.Drawing.Point(72, 58);
            this.lbClientSocketTestTitle.Name = "lbClientSocketTestTitle";
            this.lbClientSocketTestTitle.Size = new System.Drawing.Size(116, 13);
            this.lbClientSocketTestTitle.TabIndex = 0;
            this.lbClientSocketTestTitle.Text = "Client Socket Tcp Test";
            // 
            // lbClientSocketTcpTestAdd
            // 
            this.lbClientSocketTcpTestAdd.AutoSize = true;
            this.lbClientSocketTcpTestAdd.Location = new System.Drawing.Point(72, 90);
            this.lbClientSocketTcpTestAdd.Name = "lbClientSocketTcpTestAdd";
            this.lbClientSocketTcpTestAdd.Size = new System.Drawing.Size(45, 13);
            this.lbClientSocketTcpTestAdd.TabIndex = 1;
            this.lbClientSocketTcpTestAdd.Text = "Address";
            // 
            // txtClientSocketTcpTestAdd
            // 
            this.txtClientSocketTcpTestAdd.Location = new System.Drawing.Point(75, 106);
            this.txtClientSocketTcpTestAdd.Name = "txtClientSocketTcpTestAdd";
            this.txtClientSocketTcpTestAdd.Size = new System.Drawing.Size(100, 20);
            this.txtClientSocketTcpTestAdd.TabIndex = 2;
            this.txtClientSocketTcpTestAdd.TextChanged += new System.EventHandler(this.txtClientSocketTcpTestAdd_TextChanged);
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(72, 129);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(26, 13);
            this.lbPort.TabIndex = 3;
            this.lbPort.Text = "Port";
            // 
            // txtClientSocketTcpTestPort
            // 
            this.txtClientSocketTcpTestPort.Location = new System.Drawing.Point(75, 145);
            this.txtClientSocketTcpTestPort.Name = "txtClientSocketTcpTestPort";
            this.txtClientSocketTcpTestPort.Size = new System.Drawing.Size(100, 20);
            this.txtClientSocketTcpTestPort.TabIndex = 4;
            this.txtClientSocketTcpTestPort.TextChanged += new System.EventHandler(this.txtClientSocketTcpTestPort_TextChanged);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(167, 210);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 5;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // lbClientSocketTcpTestMsg
            // 
            this.lbClientSocketTcpTestMsg.AutoSize = true;
            this.lbClientSocketTcpTestMsg.Location = new System.Drawing.Point(72, 168);
            this.lbClientSocketTcpTestMsg.Name = "lbClientSocketTcpTestMsg";
            this.lbClientSocketTcpTestMsg.Size = new System.Drawing.Size(50, 13);
            this.lbClientSocketTcpTestMsg.TabIndex = 6;
            this.lbClientSocketTcpTestMsg.Text = "Message";
            // 
            // txtClientSocketTcpTestMsg
            // 
            this.txtClientSocketTcpTestMsg.Location = new System.Drawing.Point(75, 184);
            this.txtClientSocketTcpTestMsg.Name = "txtClientSocketTcpTestMsg";
            this.txtClientSocketTcpTestMsg.Size = new System.Drawing.Size(167, 20);
            this.txtClientSocketTcpTestMsg.TabIndex = 7;
            this.txtClientSocketTcpTestMsg.TextChanged += new System.EventHandler(this.txtClientSocketTcpTestMsg_TextChanged);
            // 
            // ClientTcpSocketTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 450);
            this.Controls.Add(this.txtClientSocketTcpTestMsg);
            this.Controls.Add(this.lbClientSocketTcpTestMsg);
            this.Controls.Add(this.btnConectar);
            this.Controls.Add(this.txtClientSocketTcpTestPort);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.txtClientSocketTcpTestAdd);
            this.Controls.Add(this.lbClientSocketTcpTestAdd);
            this.Controls.Add(this.lbClientSocketTestTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientTcpSocketTest";
            this.Text = "Umbrall - Client socket Tcp Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClientSocketTestTitle;
        private System.Windows.Forms.Label lbClientSocketTcpTestAdd;
        private System.Windows.Forms.TextBox txtClientSocketTcpTestAdd;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox txtClientSocketTcpTestPort;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label lbClientSocketTcpTestMsg;
        private System.Windows.Forms.TextBox txtClientSocketTcpTestMsg;
    }
}