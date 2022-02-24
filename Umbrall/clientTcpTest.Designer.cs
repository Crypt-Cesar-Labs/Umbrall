namespace Umbrall
{
    partial class clientTcpTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientTcpTest));
            this.lbClientTcpTestAdd = new System.Windows.Forms.Label();
            this.txtClientTcpTestAdd = new System.Windows.Forms.TextBox();
            this.txtClientTcpTestPort = new System.Windows.Forms.TextBox();
            this.lbClientTcpTestPort = new System.Windows.Forms.Label();
            this.btnClientTcpTestConnect = new System.Windows.Forms.Button();
            this.lbClientTcpTestTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbClientTcpTestAdd
            // 
            this.lbClientTcpTestAdd.AutoSize = true;
            this.lbClientTcpTestAdd.Location = new System.Drawing.Point(60, 107);
            this.lbClientTcpTestAdd.Name = "lbClientTcpTestAdd";
            this.lbClientTcpTestAdd.Size = new System.Drawing.Size(58, 16);
            this.lbClientTcpTestAdd.TabIndex = 0;
            this.lbClientTcpTestAdd.Text = "Address";
            // 
            // txtClientTcpTestAdd
            // 
            this.txtClientTcpTestAdd.Location = new System.Drawing.Point(63, 126);
            this.txtClientTcpTestAdd.Name = "txtClientTcpTestAdd";
            this.txtClientTcpTestAdd.Size = new System.Drawing.Size(152, 22);
            this.txtClientTcpTestAdd.TabIndex = 1;
            // 
            // txtClientTcpTestPort
            // 
            this.txtClientTcpTestPort.Location = new System.Drawing.Point(63, 176);
            this.txtClientTcpTestPort.Name = "txtClientTcpTestPort";
            this.txtClientTcpTestPort.Size = new System.Drawing.Size(152, 22);
            this.txtClientTcpTestPort.TabIndex = 3;
            // 
            // lbClientTcpTestPort
            // 
            this.lbClientTcpTestPort.AutoSize = true;
            this.lbClientTcpTestPort.Location = new System.Drawing.Point(60, 157);
            this.lbClientTcpTestPort.Name = "lbClientTcpTestPort";
            this.lbClientTcpTestPort.Size = new System.Drawing.Size(31, 16);
            this.lbClientTcpTestPort.TabIndex = 2;
            this.lbClientTcpTestPort.Text = "Port";
            // 
            // btnClientTcpTestConnect
            // 
            this.btnClientTcpTestConnect.Location = new System.Drawing.Point(140, 231);
            this.btnClientTcpTestConnect.Name = "btnClientTcpTestConnect";
            this.btnClientTcpTestConnect.Size = new System.Drawing.Size(75, 23);
            this.btnClientTcpTestConnect.TabIndex = 4;
            this.btnClientTcpTestConnect.Text = "Conectar";
            this.btnClientTcpTestConnect.UseVisualStyleBackColor = true;
            this.btnClientTcpTestConnect.Click += new System.EventHandler(this.btnClientTcpTestConnect_Click);
            // 
            // lbClientTcpTestTitle
            // 
            this.lbClientTcpTestTitle.AutoSize = true;
            this.lbClientTcpTestTitle.Location = new System.Drawing.Point(60, 67);
            this.lbClientTcpTestTitle.Name = "lbClientTcpTestTitle";
            this.lbClientTcpTestTitle.Size = new System.Drawing.Size(100, 16);
            this.lbClientTcpTestTitle.TabIndex = 5;
            this.lbClientTcpTestTitle.Text = "Client TCP Test";
            // 
            // clientTcpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 450);
            this.Controls.Add(this.lbClientTcpTestTitle);
            this.Controls.Add(this.btnClientTcpTestConnect);
            this.Controls.Add(this.txtClientTcpTestPort);
            this.Controls.Add(this.lbClientTcpTestPort);
            this.Controls.Add(this.txtClientTcpTestAdd);
            this.Controls.Add(this.lbClientTcpTestAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "clientTcpTest";
            this.Text = "Umbrall - Client Tcp Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbClientTcpTestAdd;
        private System.Windows.Forms.TextBox txtClientTcpTestAdd;
        private System.Windows.Forms.TextBox txtClientTcpTestPort;
        private System.Windows.Forms.Label lbClientTcpTestPort;
        private System.Windows.Forms.Button btnClientTcpTestConnect;
        private System.Windows.Forms.Label lbClientTcpTestTitle;
    }
}