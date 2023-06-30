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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.TSMI_ConnectionData = new System.Windows.Forms.ToolStripMenuItem();
            this.соеденениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Connection_OpenClose = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ConnectionStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Products = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Products_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Category = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Category_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Category_Show = new System.Windows.Forms.ToolStripMenuItem();
            this.PNL_GridView = new System.Windows.Forms.Panel();
            this.DGV_MainPanel = new System.Windows.Forms.DataGridView();
            this.PNL_DataOperation = new System.Windows.Forms.Panel();
            this.PB_LogoMain = new System.Windows.Forms.PictureBox();
            this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Main.SuspendLayout();
            this.PNL_GridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MainPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoMain)).BeginInit();
            this.SuspendLayout();
            // 
            // MS_Main
            // 
            this.MS_Main.BackColor = System.Drawing.Color.SandyBrown;
            this.MS_Main.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MS_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_File,
            this.TSMI_ConnectionData,
            this.TSMI_Products,
            this.TSMI_Category});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(1366, 29);
            this.MS_Main.TabIndex = 0;
            this.MS_Main.Text = "menuStrip1";
            // 
            // TSMI_ConnectionData
            // 
            this.TSMI_ConnectionData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соеденениеToolStripMenuItem});
            this.TSMI_ConnectionData.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSMI_ConnectionData.Name = "TSMI_ConnectionData";
            this.TSMI_ConnectionData.Size = new System.Drawing.Size(164, 25);
            this.TSMI_ConnectionData.Text = "Данные подключения";
            // 
            // соеденениеToolStripMenuItem
            // 
            this.соеденениеToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.соеденениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Connection_OpenClose,
            this.TSMI_ConnectionStatus});
            this.соеденениеToolStripMenuItem.Name = "соеденениеToolStripMenuItem";
            this.соеденениеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.соеденениеToolStripMenuItem.Text = "Соеденение";
            // 
            // TSMI_Connection_OpenClose
            // 
            this.TSMI_Connection_OpenClose.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Connection_OpenClose.CheckOnClick = true;
            this.TSMI_Connection_OpenClose.Name = "TSMI_Connection_OpenClose";
            this.TSMI_Connection_OpenClose.Size = new System.Drawing.Size(247, 26);
            this.TSMI_Connection_OpenClose.Text = "Установить соединение";
            this.TSMI_Connection_OpenClose.Click += new System.EventHandler(this.TSMI_Connection_OpenClose_Click);
            // 
            // TSMI_ConnectionStatus
            // 
            this.TSMI_ConnectionStatus.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_ConnectionStatus.Name = "TSMI_ConnectionStatus";
            this.TSMI_ConnectionStatus.Size = new System.Drawing.Size(247, 26);
            this.TSMI_ConnectionStatus.Text = "Статус";
            // 
            // TSMI_Products
            // 
            this.TSMI_Products.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Products.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Products_Add,
            this.TSMI_Show});
            this.TSMI_Products.Name = "TSMI_Products";
            this.TSMI_Products.Size = new System.Drawing.Size(85, 25);
            this.TSMI_Products.Text = "Продукты";
            // 
            // TSMI_Products_Add
            // 
            this.TSMI_Products_Add.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Products_Add.Name = "TSMI_Products_Add";
            this.TSMI_Products_Add.Size = new System.Drawing.Size(275, 26);
            this.TSMI_Products_Add.Text = "Добавить  новый продукт";
            // 
            // TSMI_Show
            // 
            this.TSMI_Show.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Show.Name = "TSMI_Show";
            this.TSMI_Show.Size = new System.Drawing.Size(275, 26);
            this.TSMI_Show.Text = "Показать данные продуктов";
            // 
            // TSMI_Category
            // 
            this.TSMI_Category.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Category.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Category_Add,
            this.TSMI_Category_Show});
            this.TSMI_Category.Name = "TSMI_Category";
            this.TSMI_Category.Size = new System.Drawing.Size(90, 25);
            this.TSMI_Category.Text = "Категория";
            // 
            // TSMI_Category_Add
            // 
            this.TSMI_Category_Add.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Category_Add.Name = "TSMI_Category_Add";
            this.TSMI_Category_Add.Size = new System.Drawing.Size(274, 26);
            this.TSMI_Category_Add.Text = "Добавыть новую категорию";
            this.TSMI_Category_Add.Click += new System.EventHandler(this.TSMI_Category_Add_Click);
            // 
            // TSMI_Category_Show
            // 
            this.TSMI_Category_Show.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Category_Show.Name = "TSMI_Category_Show";
            this.TSMI_Category_Show.Size = new System.Drawing.Size(274, 26);
            this.TSMI_Category_Show.Text = "Показать данные категории";
            // 
            // PNL_GridView
            // 
            this.PNL_GridView.BackColor = System.Drawing.Color.SandyBrown;
            this.PNL_GridView.Controls.Add(this.DGV_MainPanel);
            this.PNL_GridView.Location = new System.Drawing.Point(354, 47);
            this.PNL_GridView.Name = "PNL_GridView";
            this.PNL_GridView.Size = new System.Drawing.Size(990, 501);
            this.PNL_GridView.TabIndex = 1;
            // 
            // DGV_MainPanel
            // 
            this.DGV_MainPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.DGV_MainPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_MainPanel.Location = new System.Drawing.Point(0, 0);
            this.DGV_MainPanel.Name = "DGV_MainPanel";
            this.DGV_MainPanel.RowHeadersWidth = 51;
            this.DGV_MainPanel.Size = new System.Drawing.Size(990, 501);
            this.DGV_MainPanel.TabIndex = 0;
            // 
            // PNL_DataOperation
            // 
            this.PNL_DataOperation.Location = new System.Drawing.Point(22, 188);
            this.PNL_DataOperation.Name = "PNL_DataOperation";
            this.PNL_DataOperation.Size = new System.Drawing.Size(313, 360);
            this.PNL_DataOperation.TabIndex = 3;
            // 
            // PB_LogoMain
            // 
            this.PB_LogoMain.Image = global::Bookshop.Properties.Resources.BSManager_MainLogo;
            this.PB_LogoMain.Location = new System.Drawing.Point(22, 37);
            this.PB_LogoMain.Name = "PB_LogoMain";
            this.PB_LogoMain.Size = new System.Drawing.Size(313, 131);
            this.PB_LogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_LogoMain.TabIndex = 2;
            this.PB_LogoMain.TabStop = false;
            // 
            // TSMI_File
            // 
            this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_TopMost});
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(57, 25);
            this.TSMI_File.Text = "Файл";
            // 
            // TSMI_TopMost
            // 
            this.TSMI_TopMost.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_TopMost.CheckOnClick = true;
            this.TSMI_TopMost.Name = "TSMI_TopMost";
            this.TSMI_TopMost.Size = new System.Drawing.Size(224, 26);
            this.TSMI_TopMost.Text = "Поверх других окон";
            this.TSMI_TopMost.Click += new System.EventHandler(this.TSMI_TopMost_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.PNL_DataOperation);
            this.Controls.Add(this.PB_LogoMain);
            this.Controls.Add(this.PNL_GridView);
            this.Controls.Add(this.MS_Main);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS_Main;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookshop Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.PNL_GridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MainPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ConnectionData;
        private System.Windows.Forms.ToolStripMenuItem соеденениеToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem TSMI_Connection_OpenClose;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_ConnectionStatus;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Products;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Products_Add;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Show;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Category;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Category_Add;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Category_Show;
        private System.Windows.Forms.Panel PNL_GridView;
        private System.Windows.Forms.DataGridView DGV_MainPanel;
        private System.Windows.Forms.PictureBox PB_LogoMain;
        private System.Windows.Forms.Panel PNL_DataOperation;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TopMost;
    }
}