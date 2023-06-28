namespace Bookshop
{
    partial class MainForm
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
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
            this.соеденениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Connection_OpenClose = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Main
            // 
            this.MS_Main.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MS_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(1366, 29);
            this.MS_Main.TabIndex = 0;
            this.MS_Main.Text = "menuStrip1";
            // 
            // TSMI_File
            // 
            this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соеденениеToolStripMenuItem});
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(57, 25);
            this.TSMI_File.Text = "Файл";
            // 
            // соеденениеToolStripMenuItem
            // 
            this.соеденениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Connection_OpenClose});
            this.соеденениеToolStripMenuItem.Name = "соеденениеToolStripMenuItem";
            this.соеденениеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.соеденениеToolStripMenuItem.Text = "Соеденение";
            // 
            // TSMI_Connection_OpenClose
            // 
            this.TSMI_Connection_OpenClose.CheckOnClick = true;
            this.TSMI_Connection_OpenClose.Name = "TSMI_Connection_OpenClose";
            this.TSMI_Connection_OpenClose.Size = new System.Drawing.Size(247, 26);
            this.TSMI_Connection_OpenClose.Text = "Устоновить соеденение";
            this.TSMI_Connection_OpenClose.Click += new System.EventHandler(this.TSMI_Connection_OpenClose_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.MS_Main);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.MS_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem соеденениеToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem TSMI_Connection_OpenClose;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}