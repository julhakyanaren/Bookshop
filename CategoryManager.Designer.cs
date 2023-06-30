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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManager));
            this.MS_Category = new System.Windows.Forms.MenuStrip();
            this.TSMI_CM_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CM_TopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CM_ConnectionData = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CM_Connection = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CM_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CM_CheckConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_CM_Connect = new System.Windows.Forms.ToolStripMenuItem();
            this.PB_LogoMain = new System.Windows.Forms.PictureBox();
            this.PNL_CM_DGV = new System.Windows.Forms.Panel();
            this.DGV_CM_Category = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количевствоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BS_CategoryBS = new System.Windows.Forms.BindingSource(this.components);
            this.BSDataSetBM = new Bookshop.BSDBDataSet();
            this.PNL_CM_ControlElements = new System.Windows.Forms.Panel();
            this.SC_CM_ControlElement = new System.Windows.Forms.SplitContainer();
            this.PNL_CM_AddCategory = new System.Windows.Forms.Panel();
            this.B_CM_Add = new System.Windows.Forms.Button();
            this.B_CM_Check = new System.Windows.Forms.Button();
            this.L_Info_AddCategory = new System.Windows.Forms.Label();
            this.L_Info_CategoryName = new System.Windows.Forms.Label();
            this.TB_CategoryName = new System.Windows.Forms.TextBox();
            this.PNL_CM_AddRedact = new System.Windows.Forms.Panel();
            this.B_CM_CategoryRename = new System.Windows.Forms.Button();
            this.L_Info_CategoryNameNew = new System.Windows.Forms.Label();
            this.B_CM_CheckNewName = new System.Windows.Forms.Button();
            this.TB_CM_NewCategoryName = new System.Windows.Forms.TextBox();
            this.L_Info_CategoryNameOld = new System.Windows.Forms.Label();
            this.CB_CM_Categories = new System.Windows.Forms.ComboBox();
            this.B_CM_GetCategory = new System.Windows.Forms.Button();
            this.L_Info_RedactCategory = new System.Windows.Forms.Label();
            this.TT_CM = new System.Windows.Forms.ToolTip(this.components);
            this.TB_LoadingData = new System.Windows.Forms.TextBox();
            this.PNL_LoadingData = new System.Windows.Forms.Panel();
            this.PB_CM_LoadingData = new System.Windows.Forms.ProgressBar();
            this.TA_CategoryBS = new Bookshop.BSDBDataSetTableAdapters.CategoryTableAdapter();
            this.B_CM_UpdateDable = new System.Windows.Forms.Button();
            this.MS_Category.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoMain)).BeginInit();
            this.PNL_CM_DGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CM_Category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CategoryBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSDataSetBM)).BeginInit();
            this.PNL_CM_ControlElements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SC_CM_ControlElement)).BeginInit();
            this.SC_CM_ControlElement.Panel1.SuspendLayout();
            this.SC_CM_ControlElement.Panel2.SuspendLayout();
            this.SC_CM_ControlElement.SuspendLayout();
            this.PNL_CM_AddCategory.SuspendLayout();
            this.PNL_CM_AddRedact.SuspendLayout();
            this.PNL_LoadingData.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Category
            // 
            this.MS_Category.BackColor = System.Drawing.Color.SandyBrown;
            this.MS_Category.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MS_Category.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_Category.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CM_File,
            this.TSMI_CM_ConnectionData});
            this.MS_Category.Location = new System.Drawing.Point(0, 0);
            this.MS_Category.Name = "MS_Category";
            this.MS_Category.Size = new System.Drawing.Size(687, 25);
            this.MS_Category.TabIndex = 0;
            this.MS_Category.Text = "menuStrip1";
            // 
            // TSMI_CM_File
            // 
            this.TSMI_CM_File.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_CM_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CM_TopMost});
            this.TSMI_CM_File.Name = "TSMI_CM_File";
            this.TSMI_CM_File.Size = new System.Drawing.Size(45, 21);
            this.TSMI_CM_File.Text = "Файл";
            // 
            // TSMI_CM_TopMost
            // 
            this.TSMI_CM_TopMost.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_CM_TopMost.CheckOnClick = true;
            this.TSMI_CM_TopMost.Name = "TSMI_CM_TopMost";
            this.TSMI_CM_TopMost.Size = new System.Drawing.Size(172, 22);
            this.TSMI_CM_TopMost.Text = "Поверх других окон";
            this.TSMI_CM_TopMost.Click += new System.EventHandler(this.TSMI_TopMost_Click);
            // 
            // TSMI_CM_ConnectionData
            // 
            this.TSMI_CM_ConnectionData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CM_Connection});
            this.TSMI_CM_ConnectionData.Name = "TSMI_CM_ConnectionData";
            this.TSMI_CM_ConnectionData.Size = new System.Drawing.Size(129, 21);
            this.TSMI_CM_ConnectionData.Text = "Данные подключения";
            // 
            // TSMI_CM_Connection
            // 
            this.TSMI_CM_Connection.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_CM_Connection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_CM_Status,
            this.TSMI_CM_CheckConnection,
            this.TSMI_CM_Connect});
            this.TSMI_CM_Connection.Name = "TSMI_CM_Connection";
            this.TSMI_CM_Connection.Size = new System.Drawing.Size(137, 22);
            this.TSMI_CM_Connection.Text = "Соеденение";
            // 
            // TSMI_CM_Status
            // 
            this.TSMI_CM_Status.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_CM_Status.Name = "TSMI_CM_Status";
            this.TSMI_CM_Status.Size = new System.Drawing.Size(137, 22);
            this.TSMI_CM_Status.Text = "Статус:";
            // 
            // TSMI_CM_CheckConnection
            // 
            this.TSMI_CM_CheckConnection.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_CM_CheckConnection.Name = "TSMI_CM_CheckConnection";
            this.TSMI_CM_CheckConnection.Size = new System.Drawing.Size(137, 22);
            this.TSMI_CM_CheckConnection.Text = "Проверить";
            this.TSMI_CM_CheckConnection.Click += new System.EventHandler(this.TSMI_CM_CheckConnection_Click);
            // 
            // TSMI_CM_Connect
            // 
            this.TSMI_CM_Connect.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_CM_Connect.Name = "TSMI_CM_Connect";
            this.TSMI_CM_Connect.Size = new System.Drawing.Size(137, 22);
            this.TSMI_CM_Connect.Text = "Подключить";
            this.TSMI_CM_Connect.Click += new System.EventHandler(this.TSMI_CM_Connect_Click);
            // 
            // PB_LogoMain
            // 
            this.PB_LogoMain.Image = global::Bookshop.Properties.Resources.BSManager_MainLogo;
            this.PB_LogoMain.Location = new System.Drawing.Point(0, 28);
            this.PB_LogoMain.Name = "PB_LogoMain";
            this.PB_LogoMain.Size = new System.Drawing.Size(690, 77);
            this.PB_LogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_LogoMain.TabIndex = 3;
            this.PB_LogoMain.TabStop = false;
            // 
            // PNL_CM_DGV
            // 
            this.PNL_CM_DGV.Controls.Add(this.DGV_CM_Category);
            this.PNL_CM_DGV.Location = new System.Drawing.Point(244, 111);
            this.PNL_CM_DGV.Name = "PNL_CM_DGV";
            this.PNL_CM_DGV.Size = new System.Drawing.Size(431, 267);
            this.PNL_CM_DGV.TabIndex = 4;
            // 
            // DGV_CM_Category
            // 
            this.DGV_CM_Category.AutoGenerateColumns = false;
            this.DGV_CM_Category.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.DGV_CM_Category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_CM_Category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.количевствоDataGridViewTextBoxColumn});
            this.DGV_CM_Category.DataSource = this.BS_CategoryBS;
            this.DGV_CM_Category.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_CM_Category.EnableHeadersVisualStyles = false;
            this.DGV_CM_Category.GridColor = System.Drawing.Color.Black;
            this.DGV_CM_Category.Location = new System.Drawing.Point(0, 0);
            this.DGV_CM_Category.Name = "DGV_CM_Category";
            this.DGV_CM_Category.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_CM_Category.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_CM_Category.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_CM_Category.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_CM_Category.Size = new System.Drawing.Size(431, 267);
            this.DGV_CM_Category.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.FillWeight = 250F;
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 250;
            // 
            // количевствоDataGridViewTextBoxColumn
            // 
            this.количевствоDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.количевствоDataGridViewTextBoxColumn.DataPropertyName = "Количевство";
            this.количевствоDataGridViewTextBoxColumn.HeaderText = "Количевство";
            this.количевствоDataGridViewTextBoxColumn.Name = "количевствоDataGridViewTextBoxColumn";
            this.количевствоDataGridViewTextBoxColumn.Width = 91;
            // 
            // BS_CategoryBS
            // 
            this.BS_CategoryBS.DataMember = "Category";
            this.BS_CategoryBS.DataSource = this.BSDataSetBM;
            // 
            // BSDataSetBM
            // 
            this.BSDataSetBM.DataSetName = "BSDBDataSet";
            this.BSDataSetBM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PNL_CM_ControlElements
            // 
            this.PNL_CM_ControlElements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.PNL_CM_ControlElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_CM_ControlElements.Controls.Add(this.SC_CM_ControlElement);
            this.PNL_CM_ControlElements.Location = new System.Drawing.Point(16, 111);
            this.PNL_CM_ControlElements.Name = "PNL_CM_ControlElements";
            this.PNL_CM_ControlElements.Size = new System.Drawing.Size(212, 308);
            this.PNL_CM_ControlElements.TabIndex = 5;
            // 
            // SC_CM_ControlElement
            // 
            this.SC_CM_ControlElement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC_CM_ControlElement.Location = new System.Drawing.Point(0, 0);
            this.SC_CM_ControlElement.Name = "SC_CM_ControlElement";
            this.SC_CM_ControlElement.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SC_CM_ControlElement.Panel1
            // 
            this.SC_CM_ControlElement.Panel1.Controls.Add(this.PNL_CM_AddCategory);
            // 
            // SC_CM_ControlElement.Panel2
            // 
            this.SC_CM_ControlElement.Panel2.Controls.Add(this.PNL_CM_AddRedact);
            this.SC_CM_ControlElement.Size = new System.Drawing.Size(210, 306);
            this.SC_CM_ControlElement.SplitterDistance = 106;
            this.SC_CM_ControlElement.TabIndex = 3;
            // 
            // PNL_CM_AddCategory
            // 
            this.PNL_CM_AddCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.PNL_CM_AddCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_CM_AddCategory.Controls.Add(this.B_CM_Add);
            this.PNL_CM_AddCategory.Controls.Add(this.B_CM_Check);
            this.PNL_CM_AddCategory.Controls.Add(this.L_Info_AddCategory);
            this.PNL_CM_AddCategory.Controls.Add(this.L_Info_CategoryName);
            this.PNL_CM_AddCategory.Controls.Add(this.TB_CategoryName);
            this.PNL_CM_AddCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_CM_AddCategory.Location = new System.Drawing.Point(0, 0);
            this.PNL_CM_AddCategory.Name = "PNL_CM_AddCategory";
            this.PNL_CM_AddCategory.Size = new System.Drawing.Size(210, 106);
            this.PNL_CM_AddCategory.TabIndex = 0;
            // 
            // B_CM_Add
            // 
            this.B_CM_Add.BackColor = System.Drawing.Color.SandyBrown;
            this.B_CM_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_CM_Add.Location = new System.Drawing.Point(108, 70);
            this.B_CM_Add.Name = "B_CM_Add";
            this.B_CM_Add.Size = new System.Drawing.Size(95, 26);
            this.B_CM_Add.TabIndex = 4;
            this.B_CM_Add.Text = "Добавить";
            this.TT_CM.SetToolTip(this.B_CM_Add, "Добовить новую категорию с иказанным именем");
            this.B_CM_Add.UseVisualStyleBackColor = false;
            // 
            // B_CM_Check
            // 
            this.B_CM_Check.BackColor = System.Drawing.Color.SandyBrown;
            this.B_CM_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_CM_Check.Location = new System.Drawing.Point(3, 70);
            this.B_CM_Check.Name = "B_CM_Check";
            this.B_CM_Check.Size = new System.Drawing.Size(95, 26);
            this.B_CM_Check.TabIndex = 3;
            this.B_CM_Check.Text = "Проверить";
            this.TT_CM.SetToolTip(this.B_CM_Check, "Проверить существует ли введённое имя категории");
            this.B_CM_Check.UseVisualStyleBackColor = false;
            // 
            // L_Info_AddCategory
            // 
            this.L_Info_AddCategory.AutoSize = true;
            this.L_Info_AddCategory.Location = new System.Drawing.Point(58, 0);
            this.L_Info_AddCategory.Name = "L_Info_AddCategory";
            this.L_Info_AddCategory.Size = new System.Drawing.Size(104, 16);
            this.L_Info_AddCategory.TabIndex = 0;
            this.L_Info_AddCategory.Text = "Добавить категорию";
            this.L_Info_AddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Info_CategoryName
            // 
            this.L_Info_CategoryName.AutoSize = true;
            this.L_Info_CategoryName.Location = new System.Drawing.Point(3, 24);
            this.L_Info_CategoryName.Name = "L_Info_CategoryName";
            this.L_Info_CategoryName.Size = new System.Drawing.Size(104, 16);
            this.L_Info_CategoryName.TabIndex = 1;
            this.L_Info_CategoryName.Text = "Название категории";
            this.L_Info_CategoryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_CategoryName
            // 
            this.TB_CategoryName.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_CategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_CategoryName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_CategoryName.Location = new System.Drawing.Point(3, 43);
            this.TB_CategoryName.Name = "TB_CategoryName";
            this.TB_CategoryName.Size = new System.Drawing.Size(200, 21);
            this.TB_CategoryName.TabIndex = 2;
            this.TT_CM.SetToolTip(this.TB_CategoryName, "Название категории");
            // 
            // PNL_CM_AddRedact
            // 
            this.PNL_CM_AddRedact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_CM_AddRedact.Controls.Add(this.B_CM_UpdateDable);
            this.PNL_CM_AddRedact.Controls.Add(this.B_CM_CategoryRename);
            this.PNL_CM_AddRedact.Controls.Add(this.L_Info_CategoryNameNew);
            this.PNL_CM_AddRedact.Controls.Add(this.B_CM_CheckNewName);
            this.PNL_CM_AddRedact.Controls.Add(this.TB_CM_NewCategoryName);
            this.PNL_CM_AddRedact.Controls.Add(this.L_Info_CategoryNameOld);
            this.PNL_CM_AddRedact.Controls.Add(this.CB_CM_Categories);
            this.PNL_CM_AddRedact.Controls.Add(this.B_CM_GetCategory);
            this.PNL_CM_AddRedact.Controls.Add(this.L_Info_RedactCategory);
            this.PNL_CM_AddRedact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_CM_AddRedact.Location = new System.Drawing.Point(0, 0);
            this.PNL_CM_AddRedact.Name = "PNL_CM_AddRedact";
            this.PNL_CM_AddRedact.Size = new System.Drawing.Size(210, 196);
            this.PNL_CM_AddRedact.TabIndex = 1;
            // 
            // B_CM_CategoryRename
            // 
            this.B_CM_CategoryRename.BackColor = System.Drawing.Color.SandyBrown;
            this.B_CM_CategoryRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_CM_CategoryRename.Location = new System.Drawing.Point(111, 150);
            this.B_CM_CategoryRename.Name = "B_CM_CategoryRename";
            this.B_CM_CategoryRename.Size = new System.Drawing.Size(95, 26);
            this.B_CM_CategoryRename.TabIndex = 6;
            this.B_CM_CategoryRename.Text = "Переименовать";
            this.TT_CM.SetToolTip(this.B_CM_CategoryRename, "Переиминовать выбранную категорию");
            this.B_CM_CategoryRename.UseVisualStyleBackColor = false;
            // 
            // L_Info_CategoryNameNew
            // 
            this.L_Info_CategoryNameNew.AutoSize = true;
            this.L_Info_CategoryNameNew.Location = new System.Drawing.Point(6, 104);
            this.L_Info_CategoryNameNew.Name = "L_Info_CategoryNameNew";
            this.L_Info_CategoryNameNew.Size = new System.Drawing.Size(135, 16);
            this.L_Info_CategoryNameNew.TabIndex = 7;
            this.L_Info_CategoryNameNew.Text = "Новое название категории";
            this.L_Info_CategoryNameNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_CM_CheckNewName
            // 
            this.B_CM_CheckNewName.BackColor = System.Drawing.Color.SandyBrown;
            this.B_CM_CheckNewName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_CM_CheckNewName.Location = new System.Drawing.Point(6, 150);
            this.B_CM_CheckNewName.Name = "B_CM_CheckNewName";
            this.B_CM_CheckNewName.Size = new System.Drawing.Size(95, 26);
            this.B_CM_CheckNewName.TabIndex = 5;
            this.B_CM_CheckNewName.Text = "Проверить";
            this.TT_CM.SetToolTip(this.B_CM_CheckNewName, "Проверить существует ли новое введённое имя категории");
            this.B_CM_CheckNewName.UseVisualStyleBackColor = false;
            // 
            // TB_CM_NewCategoryName
            // 
            this.TB_CM_NewCategoryName.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_CM_NewCategoryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_CM_NewCategoryName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_CM_NewCategoryName.Location = new System.Drawing.Point(6, 123);
            this.TB_CM_NewCategoryName.Name = "TB_CM_NewCategoryName";
            this.TB_CM_NewCategoryName.Size = new System.Drawing.Size(200, 21);
            this.TB_CM_NewCategoryName.TabIndex = 8;
            this.TT_CM.SetToolTip(this.TB_CM_NewCategoryName, "Новое название категории");
            // 
            // L_Info_CategoryNameOld
            // 
            this.L_Info_CategoryNameOld.AutoSize = true;
            this.L_Info_CategoryNameOld.Location = new System.Drawing.Point(3, 57);
            this.L_Info_CategoryNameOld.Name = "L_Info_CategoryNameOld";
            this.L_Info_CategoryNameOld.Size = new System.Drawing.Size(104, 16);
            this.L_Info_CategoryNameOld.TabIndex = 5;
            this.L_Info_CategoryNameOld.Text = "Название категории";
            this.L_Info_CategoryNameOld.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_CM_Categories
            // 
            this.CB_CM_Categories.BackColor = System.Drawing.Color.PeachPuff;
            this.CB_CM_Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_CM_Categories.FormattingEnabled = true;
            this.CB_CM_Categories.Location = new System.Drawing.Point(6, 76);
            this.CB_CM_Categories.Name = "CB_CM_Categories";
            this.CB_CM_Categories.Size = new System.Drawing.Size(197, 24);
            this.CB_CM_Categories.TabIndex = 6;
            // 
            // B_CM_GetCategory
            // 
            this.B_CM_GetCategory.BackColor = System.Drawing.Color.SandyBrown;
            this.B_CM_GetCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_CM_GetCategory.Location = new System.Drawing.Point(3, 20);
            this.B_CM_GetCategory.Name = "B_CM_GetCategory";
            this.B_CM_GetCategory.Size = new System.Drawing.Size(95, 26);
            this.B_CM_GetCategory.TabIndex = 5;
            this.B_CM_GetCategory.Text = "Получить данные ";
            this.TT_CM.SetToolTip(this.B_CM_GetCategory, "Получить все данные о записанных категории с БД");
            this.B_CM_GetCategory.UseVisualStyleBackColor = false;
            // 
            // L_Info_RedactCategory
            // 
            this.L_Info_RedactCategory.AutoSize = true;
            this.L_Info_RedactCategory.Location = new System.Drawing.Point(58, 1);
            this.L_Info_RedactCategory.Name = "L_Info_RedactCategory";
            this.L_Info_RedactCategory.Size = new System.Drawing.Size(104, 16);
            this.L_Info_RedactCategory.TabIndex = 5;
            this.L_Info_RedactCategory.Text = "Изменить категорию";
            this.L_Info_RedactCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_LoadingData
            // 
            this.TB_LoadingData.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_LoadingData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_LoadingData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_LoadingData.Location = new System.Drawing.Point(285, 6);
            this.TB_LoadingData.Name = "TB_LoadingData";
            this.TB_LoadingData.ReadOnly = true;
            this.TB_LoadingData.Size = new System.Drawing.Size(141, 21);
            this.TB_LoadingData.TabIndex = 9;
            this.TT_CM.SetToolTip(this.TB_LoadingData, "Новое название категории");
            // 
            // PNL_LoadingData
            // 
            this.PNL_LoadingData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.PNL_LoadingData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_LoadingData.Controls.Add(this.TB_LoadingData);
            this.PNL_LoadingData.Controls.Add(this.PB_CM_LoadingData);
            this.PNL_LoadingData.Location = new System.Drawing.Point(244, 384);
            this.PNL_LoadingData.Name = "PNL_LoadingData";
            this.PNL_LoadingData.Size = new System.Drawing.Size(431, 33);
            this.PNL_LoadingData.TabIndex = 6;
            // 
            // PB_CM_LoadingData
            // 
            this.PB_CM_LoadingData.ForeColor = System.Drawing.Color.DarkOrange;
            this.PB_CM_LoadingData.Location = new System.Drawing.Point(3, 5);
            this.PB_CM_LoadingData.Name = "PB_CM_LoadingData";
            this.PB_CM_LoadingData.Size = new System.Drawing.Size(276, 23);
            this.PB_CM_LoadingData.TabIndex = 0;
            // 
            // TA_CategoryBS
            // 
            this.TA_CategoryBS.ClearBeforeFill = true;
            // 
            // B_CM_UpdateDable
            // 
            this.B_CM_UpdateDable.BackColor = System.Drawing.Color.SandyBrown;
            this.B_CM_UpdateDable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_CM_UpdateDable.Location = new System.Drawing.Point(108, 20);
            this.B_CM_UpdateDable.Name = "B_CM_UpdateDable";
            this.B_CM_UpdateDable.Size = new System.Drawing.Size(95, 26);
            this.B_CM_UpdateDable.TabIndex = 5;
            this.B_CM_UpdateDable.Text = "Обнавить";
            this.TT_CM.SetToolTip(this.B_CM_UpdateDable, "Обновить таблицу категории");
            this.B_CM_UpdateDable.UseVisualStyleBackColor = false;
            // 
            // CategoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(687, 429);
            this.Controls.Add(this.PNL_LoadingData);
            this.Controls.Add(this.PNL_CM_ControlElements);
            this.Controls.Add(this.PNL_CM_DGV);
            this.Controls.Add(this.PB_LogoMain);
            this.Controls.Add(this.MS_Category);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS_Category;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CategoryManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Диспечер категории";
            this.Load += new System.EventHandler(this.CategoryManager_Load);
            this.MS_Category.ResumeLayout(false);
            this.MS_Category.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoMain)).EndInit();
            this.PNL_CM_DGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_CM_Category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BS_CategoryBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSDataSetBM)).EndInit();
            this.PNL_CM_ControlElements.ResumeLayout(false);
            this.SC_CM_ControlElement.Panel1.ResumeLayout(false);
            this.SC_CM_ControlElement.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SC_CM_ControlElement)).EndInit();
            this.SC_CM_ControlElement.ResumeLayout(false);
            this.PNL_CM_AddCategory.ResumeLayout(false);
            this.PNL_CM_AddCategory.PerformLayout();
            this.PNL_CM_AddRedact.ResumeLayout(false);
            this.PNL_CM_AddRedact.PerformLayout();
            this.PNL_LoadingData.ResumeLayout(false);
            this.PNL_LoadingData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Category;
        private System.Windows.Forms.PictureBox PB_LogoMain;
        private System.Windows.Forms.Panel PNL_CM_DGV;
        private System.Windows.Forms.Panel PNL_CM_ControlElements;
        private System.Windows.Forms.Label L_Info_AddCategory;
        private System.Windows.Forms.Label L_Info_CategoryName;
        private System.Windows.Forms.TextBox TB_CategoryName;
        public System.Windows.Forms.SplitContainer SC_CM_ControlElement;
        private System.Windows.Forms.Panel PNL_CM_AddCategory;
        private System.Windows.Forms.Button B_CM_Check;
        private System.Windows.Forms.Panel PNL_CM_AddRedact;
        private System.Windows.Forms.Button B_CM_Add;
        private System.Windows.Forms.Label L_Info_RedactCategory;
        private System.Windows.Forms.Label L_Info_CategoryNameOld;
        private System.Windows.Forms.ComboBox CB_CM_Categories;
        private System.Windows.Forms.Button B_CM_GetCategory;
        private System.Windows.Forms.Label L_Info_CategoryNameNew;
        private System.Windows.Forms.TextBox TB_CM_NewCategoryName;
        private System.Windows.Forms.Button B_CM_CategoryRename;
        private System.Windows.Forms.Button B_CM_CheckNewName;
        private System.Windows.Forms.ToolTip TT_CM;
        private System.Windows.Forms.Panel PNL_LoadingData;
        private System.Windows.Forms.TextBox TB_LoadingData;
        private System.Windows.Forms.ProgressBar PB_CM_LoadingData;
        public System.Windows.Forms.ToolStripMenuItem TSMI_CM_Connection;
        public System.Windows.Forms.ToolStripMenuItem TSMI_CM_Status;
        public System.Windows.Forms.ToolStripMenuItem TSMI_CM_CheckConnection;
        public System.Windows.Forms.ToolStripMenuItem TSMI_CM_Connect;
        public System.Windows.Forms.ToolStripMenuItem TSMI_CM_TopMost;
        public System.Windows.Forms.ToolStripMenuItem TSMI_CM_ConnectionData;
        public System.Windows.Forms.ToolStripMenuItem TSMI_CM_File;
        public BSDBDataSet BSDataSetBM;
        public System.Windows.Forms.BindingSource BS_CategoryBS;
        public BSDBDataSetTableAdapters.CategoryTableAdapter TA_CategoryBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количевствоDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView DGV_CM_Category;
        private System.Windows.Forms.Button B_CM_UpdateDable;
    }
}