namespace Umbrall
{
    partial class MonitorGui
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
            this.panelMonitor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewMonitor = new System.Windows.Forms.DataGridView();
            this.panelMonitor.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonitor)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMonitor
            // 
            this.panelMonitor.Controls.Add(this.panel5);
            this.panelMonitor.Controls.Add(this.panel4);
            this.panelMonitor.Controls.Add(this.panel3);
            this.panelMonitor.Controls.Add(this.panel2);
            this.panelMonitor.Controls.Add(this.panel1);
            this.panelMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMonitor.Location = new System.Drawing.Point(0, 0);
            this.panelMonitor.Name = "panelMonitor";
            this.panelMonitor.Size = new System.Drawing.Size(868, 652);
            this.panelMonitor.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 652);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(753, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(115, 652);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(115, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(638, 100);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(115, 552);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(638, 100);
            this.panel4.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.splitContainer1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(115, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(638, 452);
            this.panel5.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridViewMonitor);
            this.splitContainer1.Size = new System.Drawing.Size(638, 452);
            this.splitContainer1.SplitterDistance = 163;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridViewMonitor
            // 
            this.dataGridViewMonitor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.dataGridViewMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMonitor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMonitor.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewMonitor.Name = "dataGridViewMonitor";
            this.dataGridViewMonitor.RowHeadersWidth = 51;
            this.dataGridViewMonitor.RowTemplate.Height = 24;
            this.dataGridViewMonitor.Size = new System.Drawing.Size(638, 163);
            this.dataGridViewMonitor.TabIndex = 3;
            // 
            // MonitorGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(868, 652);
            this.Controls.Add(this.panelMonitor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonitorGui";
            this.Text = "MonitorGui";
            this.Load += new System.EventHandler(this.MonitorGui_Load);
            this.panelMonitor.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMonitor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMonitor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewMonitor;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}