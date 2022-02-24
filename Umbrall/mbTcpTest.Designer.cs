namespace Umbrall
{
    partial class mbTcpTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mbTcpTest));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMbTcpAdd = new System.Windows.Forms.TextBox();
            this.lbMbTcpTestAdd = new System.Windows.Forms.Label();
            this.lbMbTcpTestPort = new System.Windows.Forms.Label();
            this.txtMbTcpTestPort = new System.Windows.Forms.TextBox();
            this.btnMbTcpTestConnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modbus TCP Test";
            // 
            // txtMbTcpAdd
            // 
            this.txtMbTcpAdd.Location = new System.Drawing.Point(68, 116);
            this.txtMbTcpAdd.Name = "txtMbTcpAdd";
            this.txtMbTcpAdd.Size = new System.Drawing.Size(164, 22);
            this.txtMbTcpAdd.TabIndex = 1;
            // 
            // lbMbTcpTestAdd
            // 
            this.lbMbTcpTestAdd.AutoSize = true;
            this.lbMbTcpTestAdd.Location = new System.Drawing.Point(65, 97);
            this.lbMbTcpTestAdd.Name = "lbMbTcpTestAdd";
            this.lbMbTcpTestAdd.Size = new System.Drawing.Size(58, 16);
            this.lbMbTcpTestAdd.TabIndex = 2;
            this.lbMbTcpTestAdd.Text = "Address";
            // 
            // lbMbTcpTestPort
            // 
            this.lbMbTcpTestPort.AutoSize = true;
            this.lbMbTcpTestPort.Location = new System.Drawing.Point(65, 159);
            this.lbMbTcpTestPort.Name = "lbMbTcpTestPort";
            this.lbMbTcpTestPort.Size = new System.Drawing.Size(31, 16);
            this.lbMbTcpTestPort.TabIndex = 4;
            this.lbMbTcpTestPort.Text = "Port";
            // 
            // txtMbTcpTestPort
            // 
            this.txtMbTcpTestPort.Location = new System.Drawing.Point(68, 178);
            this.txtMbTcpTestPort.Name = "txtMbTcpTestPort";
            this.txtMbTcpTestPort.Size = new System.Drawing.Size(164, 22);
            this.txtMbTcpTestPort.TabIndex = 3;
            // 
            // btnMbTcpTestConnect
            // 
            this.btnMbTcpTestConnect.Location = new System.Drawing.Point(130, 235);
            this.btnMbTcpTestConnect.Name = "btnMbTcpTestConnect";
            this.btnMbTcpTestConnect.Size = new System.Drawing.Size(102, 23);
            this.btnMbTcpTestConnect.TabIndex = 5;
            this.btnMbTcpTestConnect.Text = "Conectar";
            this.btnMbTcpTestConnect.UseVisualStyleBackColor = true;
            this.btnMbTcpTestConnect.Click += new System.EventHandler(this.btnMbTcpTestConnect_Click);
            // 
            // mbTcpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMbTcpTestConnect);
            this.Controls.Add(this.lbMbTcpTestPort);
            this.Controls.Add(this.txtMbTcpTestPort);
            this.Controls.Add(this.lbMbTcpTestAdd);
            this.Controls.Add(this.txtMbTcpAdd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mbTcpTest";
            this.Text = "Umbrall - Modbus Tcp Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMbTcpAdd;
        private System.Windows.Forms.Label lbMbTcpTestAdd;
        private System.Windows.Forms.Label lbMbTcpTestPort;
        private System.Windows.Forms.TextBox txtMbTcpTestPort;
        private System.Windows.Forms.Button btnMbTcpTestConnect;
    }
}