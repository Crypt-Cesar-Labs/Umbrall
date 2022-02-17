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
            this.SuspendLayout();
            // 
            // btnClientTcpConnect
            // 
            this.btnClientTcpConnect.Location = new System.Drawing.Point(562, 68);
            this.btnClientTcpConnect.Name = "btnClientTcpConnect";
            this.btnClientTcpConnect.Size = new System.Drawing.Size(101, 23);
            this.btnClientTcpConnect.TabIndex = 0;
            this.btnClientTcpConnect.Text = "Conectar";
            this.btnClientTcpConnect.UseVisualStyleBackColor = true;
            // 
            // tcpTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClientTcpConnect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tcpTest";
            this.Text = "Umbrall - TCP Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientTcpConnect;
    }
}