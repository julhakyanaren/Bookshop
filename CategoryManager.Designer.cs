namespace Bookshop
{
    partial class CategoryManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManager));
            this.MS_Category = new System.Windows.Forms.MenuStrip();
            this.TSMI_CM_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CM_Connection = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CM_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CM_CheckConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CM_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Category.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Category
            // 
            this.MS_Category.BackColor = System.Drawing.Color.DarkOrange;
            this.MS_Category.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MS_Category.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CM_File});
            this.MS_Category.Location = new System.Drawing.Point(0, 0);
            this.MS_Category.Name = "MS_Category";
            this.MS_Category.Size = new System.Drawing.Size(800, 25);
            this.MS_Category.TabIndex = 0;
            this.MS_Category.Text = "menuStrip1";
            // 
            // TSMI_CM_File
            // 
            this.TSMI_CM_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CM_Connection});
            this.TSMI_CM_File.Name = "TSMI_CM_File";
            this.TSMI_CM_File.Size = new System.Drawing.Size(45, 21);
            this.TSMI_CM_File.Text = "Файл";
            // 
            // TSMI_CM_Connection
            // 
            this.TSMI_CM_Connection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CM_Status,
            this.TSMI_CM_CheckConnection,
            this.TSMI_CM_Connect});
            this.TSMI_CM_Connection.Name = "TSMI_CM_Connection";
            this.TSMI_CM_Connection.Size = new System.Drawing.Size(180, 22);
            this.TSMI_CM_Connection.Text = "Соеденение";
            // 
            // TSMI_CM_Status
            // 
            this.TSMI_CM_Status.Name = "TSMI_CM_Status";
            this.TSMI_CM_Status.Size = new System.Drawing.Size(180, 22);
            this.TSMI_CM_Status.Text = "Статус:";
            // 
            // TSMI_CM_CheckConnection
            // 
            this.TSMI_CM_CheckConnection.Name = "TSMI_CM_CheckConnection";
            this.TSMI_CM_CheckConnection.Size = new System.Drawing.Size(180, 22);
            this.TSMI_CM_CheckConnection.Text = "Проверить";
            // 
            // TSMI_CM_Connect
            // 
            this.TSMI_CM_Connect.Name = "TSMI_CM_Connect";
            this.TSMI_CM_Connect.Size = new System.Drawing.Size(180, 22);
            this.TSMI_CM_Connect.Text = "Подключить";
            // 
            // CategoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(800, 554);
            this.Controls.Add(this.MS_Category);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS_Category;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CategoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category Manager";
            this.Load += new System.EventHandler(this.CategoryManager_Load);
            this.MS_Category.ResumeLayout(false);
            this.MS_Category.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Category;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CM_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CM_Connection;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CM_Status;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CM_CheckConnection;
        private System.Windows.Forms.ToolStripMenuItem TSMI_CM_Connect;
    }
}