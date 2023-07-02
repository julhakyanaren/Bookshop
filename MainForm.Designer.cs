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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.TSMI_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ConnectionData = new System.Windows.Forms.ToolStripMenuItem();
            this.соеденениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Connection_OpenClose = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_ConnectionStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Category = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Category_Add = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Datas = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Synchronize = new System.Windows.Forms.ToolStripMenuItem();
            this.PNL_GridView = new System.Windows.Forms.Panel();
            this.DGV_MS_Product = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSDBDataSet = new Bookshop.BSDBDataSet();
            this.PNL_DataOperation = new System.Windows.Forms.Panel();
            this.B_ApplyData = new System.Windows.Forms.Button();
            this.L_Info_UniqueID = new System.Windows.Forms.Label();
            this.TB_UniqueCode = new System.Windows.Forms.TextBox();
            this.DTP_ForUniqueCode = new System.Windows.Forms.DateTimePicker();
            this.B_GenerateUniqueID = new System.Windows.Forms.Button();
            this.L_Info_GenerateUniqueID = new System.Windows.Forms.Label();
            this.L_Info_AddProduct = new System.Windows.Forms.Label();
            this.B_ApplyCount = new System.Windows.Forms.Button();
            this.B_ApplyPrice = new System.Windows.Forms.Button();
            this.L_Info_Product_Count = new System.Windows.Forms.Label();
            this.NUD_Count = new System.Windows.Forms.NumericUpDown();
            this.DUD_CountIncrement = new System.Windows.Forms.DomainUpDown();
            this.L_Info_Product_CountInc = new System.Windows.Forms.Label();
            this.L_Info_Product_Price = new System.Windows.Forms.Label();
            this.NUD_Price = new System.Windows.Forms.NumericUpDown();
            this.DUD_PriceIncrement = new System.Windows.Forms.DomainUpDown();
            this.L_Info_Product_PriceInc = new System.Windows.Forms.Label();
            this.B_SelectCategory = new System.Windows.Forms.Button();
            this.CB_GetCategories = new System.Windows.Forms.ComboBox();
            this.B_GetCategoryData = new System.Windows.Forms.Button();
            this.L_Info_Product_Category = new System.Windows.Forms.Label();
            this.B_ProductName_Check = new System.Windows.Forms.Button();
            this.L_Info_ProductName = new System.Windows.Forms.Label();
            this.TB_ProductName = new System.Windows.Forms.TextBox();
            this.PB_LogoMain = new System.Windows.Forms.PictureBox();
            this.PNL_CodeSelector = new System.Windows.Forms.Panel();
            this.TLP_ProdusctsRedact = new System.Windows.Forms.TableLayoutPanel();
            this.PNL_Redact_Delete = new System.Windows.Forms.Panel();
            this.PNL_Redact_Update = new System.Windows.Forms.Panel();
            this.PNL_Redact_Rename = new System.Windows.Forms.Panel();
            this.L_Info_RedactUpdate = new System.Windows.Forms.Label();
            this.L_Info_RedactRename = new System.Windows.Forms.Label();
            this.L_Info_RedactDelete = new System.Windows.Forms.Label();
            this.MS_Main.SuspendLayout();
            this.PNL_GridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MS_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDBDataSet)).BeginInit();
            this.PNL_DataOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoMain)).BeginInit();
            this.PNL_CodeSelector.SuspendLayout();
            this.TLP_ProdusctsRedact.SuspendLayout();
            this.PNL_Redact_Delete.SuspendLayout();
            this.PNL_Redact_Update.SuspendLayout();
            this.PNL_Redact_Rename.SuspendLayout();
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
            this.TSMI_Category,
            this.TSMI_Datas});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(1366, 25);
            this.MS_Main.TabIndex = 0;
            this.MS_Main.Text = "menuStrip1";
            // 
            // TSMI_File
            // 
            this.TSMI_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_TopMost});
            this.TSMI_File.Name = "TSMI_File";
            this.TSMI_File.Size = new System.Drawing.Size(45, 21);
            this.TSMI_File.Text = "Файл";
            // 
            // TSMI_TopMost
            // 
            this.TSMI_TopMost.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_TopMost.CheckOnClick = true;
            this.TSMI_TopMost.Name = "TSMI_TopMost";
            this.TSMI_TopMost.Size = new System.Drawing.Size(172, 22);
            this.TSMI_TopMost.Text = "Поверх других окон";
            this.TSMI_TopMost.Click += new System.EventHandler(this.TSMI_TopMost_Click);
            // 
            // TSMI_ConnectionData
            // 
            this.TSMI_ConnectionData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соеденениеToolStripMenuItem});
            this.TSMI_ConnectionData.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSMI_ConnectionData.Name = "TSMI_ConnectionData";
            this.TSMI_ConnectionData.Size = new System.Drawing.Size(129, 21);
            this.TSMI_ConnectionData.Text = "Данные подключения";
            // 
            // соеденениеToolStripMenuItem
            // 
            this.соеденениеToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown;
            this.соеденениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Connection_OpenClose,
            this.TSMI_ConnectionStatus});
            this.соеденениеToolStripMenuItem.Name = "соеденениеToolStripMenuItem";
            this.соеденениеToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.соеденениеToolStripMenuItem.Text = "Соеденение";
            // 
            // TSMI_Connection_OpenClose
            // 
            this.TSMI_Connection_OpenClose.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Connection_OpenClose.CheckOnClick = true;
            this.TSMI_Connection_OpenClose.Name = "TSMI_Connection_OpenClose";
            this.TSMI_Connection_OpenClose.Size = new System.Drawing.Size(192, 22);
            this.TSMI_Connection_OpenClose.Text = "Установить соединение";
            this.TSMI_Connection_OpenClose.Click += new System.EventHandler(this.TSMI_Connection_OpenClose_Click);
            // 
            // TSMI_ConnectionStatus
            // 
            this.TSMI_ConnectionStatus.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_ConnectionStatus.Name = "TSMI_ConnectionStatus";
            this.TSMI_ConnectionStatus.Size = new System.Drawing.Size(192, 22);
            this.TSMI_ConnectionStatus.Text = "Статус";
            // 
            // TSMI_Category
            // 
            this.TSMI_Category.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Category.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Category_Add});
            this.TSMI_Category.Name = "TSMI_Category";
            this.TSMI_Category.Size = new System.Drawing.Size(71, 21);
            this.TSMI_Category.Text = "Категория";
            // 
            // TSMI_Category_Add
            // 
            this.TSMI_Category_Add.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Category_Add.Name = "TSMI_Category_Add";
            this.TSMI_Category_Add.Size = new System.Drawing.Size(214, 22);
            this.TSMI_Category_Add.Text = "Добавыть новую категорию";
            this.TSMI_Category_Add.Click += new System.EventHandler(this.TSMI_Category_Add_Click);
            // 
            // TSMI_Datas
            // 
            this.TSMI_Datas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Synchronize});
            this.TSMI_Datas.Name = "TSMI_Datas";
            this.TSMI_Datas.Size = new System.Drawing.Size(59, 21);
            this.TSMI_Datas.Text = "Данные";
            // 
            // TSMI_Synchronize
            // 
            this.TSMI_Synchronize.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Synchronize.Name = "TSMI_Synchronize";
            this.TSMI_Synchronize.Size = new System.Drawing.Size(169, 22);
            this.TSMI_Synchronize.Text = "Синхронизировать";
            // 
            // PNL_GridView
            // 
            this.PNL_GridView.BackColor = System.Drawing.Color.SandyBrown;
            this.PNL_GridView.Controls.Add(this.DGV_MS_Product);
            this.PNL_GridView.Location = new System.Drawing.Point(376, 47);
            this.PNL_GridView.Name = "PNL_GridView";
            this.PNL_GridView.Size = new System.Drawing.Size(968, 372);
            this.PNL_GridView.TabIndex = 1;
            // 
            // DGV_MS_Product
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_MS_Product.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_MS_Product.AutoGenerateColumns = false;
            this.DGV_MS_Product.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.DGV_MS_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_MS_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.кодDataGridViewTextBoxColumn});
            this.DGV_MS_Product.DataSource = this.productBindingSource;
            this.DGV_MS_Product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_MS_Product.EnableHeadersVisualStyles = false;
            this.DGV_MS_Product.GridColor = System.Drawing.Color.Black;
            this.DGV_MS_Product.Location = new System.Drawing.Point(0, 0);
            this.DGV_MS_Product.Name = "DGV_MS_Product";
            this.DGV_MS_Product.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_MS_Product.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_MS_Product.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.PeachPuff;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.DGV_MS_Product.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_MS_Product.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_MS_Product.Size = new System.Drawing.Size(968, 372);
            this.DGV_MS_Product.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 70F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 70;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.FillWeight = 250F;
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.FillWeight = 150F;
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            this.категорияDataGridViewTextBoxColumn.Width = 150;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.FillWeight = 150F;
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 150;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.FillWeight = 170F;
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 170;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.bSDBDataSet;
            // 
            // bSDBDataSet
            // 
            this.bSDBDataSet.DataSetName = "BSDBDataSet";
            this.bSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PNL_DataOperation
            // 
            this.PNL_DataOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.PNL_DataOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_DataOperation.Controls.Add(this.B_ApplyData);
            this.PNL_DataOperation.Controls.Add(this.L_Info_UniqueID);
            this.PNL_DataOperation.Controls.Add(this.TB_UniqueCode);
            this.PNL_DataOperation.Controls.Add(this.DTP_ForUniqueCode);
            this.PNL_DataOperation.Controls.Add(this.B_GenerateUniqueID);
            this.PNL_DataOperation.Controls.Add(this.L_Info_GenerateUniqueID);
            this.PNL_DataOperation.Controls.Add(this.L_Info_AddProduct);
            this.PNL_DataOperation.Controls.Add(this.B_ApplyCount);
            this.PNL_DataOperation.Controls.Add(this.B_ApplyPrice);
            this.PNL_DataOperation.Controls.Add(this.L_Info_Product_Count);
            this.PNL_DataOperation.Controls.Add(this.NUD_Count);
            this.PNL_DataOperation.Controls.Add(this.DUD_CountIncrement);
            this.PNL_DataOperation.Controls.Add(this.L_Info_Product_CountInc);
            this.PNL_DataOperation.Controls.Add(this.L_Info_Product_Price);
            this.PNL_DataOperation.Controls.Add(this.NUD_Price);
            this.PNL_DataOperation.Controls.Add(this.DUD_PriceIncrement);
            this.PNL_DataOperation.Controls.Add(this.L_Info_Product_PriceInc);
            this.PNL_DataOperation.Controls.Add(this.B_SelectCategory);
            this.PNL_DataOperation.Controls.Add(this.CB_GetCategories);
            this.PNL_DataOperation.Controls.Add(this.B_GetCategoryData);
            this.PNL_DataOperation.Controls.Add(this.L_Info_Product_Category);
            this.PNL_DataOperation.Controls.Add(this.B_ProductName_Check);
            this.PNL_DataOperation.Controls.Add(this.L_Info_ProductName);
            this.PNL_DataOperation.Controls.Add(this.TB_ProductName);
            this.PNL_DataOperation.Location = new System.Drawing.Point(22, 188);
            this.PNL_DataOperation.Name = "PNL_DataOperation";
            this.PNL_DataOperation.Size = new System.Drawing.Size(338, 497);
            this.PNL_DataOperation.TabIndex = 3;
            // 
            // B_ApplyData
            // 
            this.B_ApplyData.BackColor = System.Drawing.Color.SandyBrown;
            this.B_ApplyData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ApplyData.Location = new System.Drawing.Point(211, 420);
            this.B_ApplyData.Name = "B_ApplyData";
            this.B_ApplyData.Size = new System.Drawing.Size(118, 25);
            this.B_ApplyData.TabIndex = 26;
            this.B_ApplyData.Text = "Принять данные";
            this.B_ApplyData.UseVisualStyleBackColor = false;
            // 
            // L_Info_UniqueID
            // 
            this.L_Info_UniqueID.AutoSize = true;
            this.L_Info_UniqueID.Location = new System.Drawing.Point(3, 401);
            this.L_Info_UniqueID.Name = "L_Info_UniqueID";
            this.L_Info_UniqueID.Size = new System.Drawing.Size(136, 17);
            this.L_Info_UniqueID.TabIndex = 24;
            this.L_Info_UniqueID.Text = "Уникальный код прадукта";
            this.L_Info_UniqueID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_UniqueCode
            // 
            this.TB_UniqueCode.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_UniqueCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_UniqueCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_UniqueCode.Location = new System.Drawing.Point(3, 420);
            this.TB_UniqueCode.Name = "TB_UniqueCode";
            this.TB_UniqueCode.Size = new System.Drawing.Size(202, 22);
            this.TB_UniqueCode.TabIndex = 25;
            // 
            // DTP_ForUniqueCode
            // 
            this.DTP_ForUniqueCode.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.DTP_ForUniqueCode.CalendarTitleBackColor = System.Drawing.Color.SandyBrown;
            this.DTP_ForUniqueCode.CalendarTrailingForeColor = System.Drawing.Color.DarkOrange;
            this.DTP_ForUniqueCode.Location = new System.Drawing.Point(3, 367);
            this.DTP_ForUniqueCode.MinDate = new System.DateTime(2000, 8, 22, 0, 0, 0, 0);
            this.DTP_ForUniqueCode.Name = "DTP_ForUniqueCode";
            this.DTP_ForUniqueCode.Size = new System.Drawing.Size(156, 22);
            this.DTP_ForUniqueCode.TabIndex = 23;
            // 
            // B_GenerateUniqueID
            // 
            this.B_GenerateUniqueID.BackColor = System.Drawing.Color.SandyBrown;
            this.B_GenerateUniqueID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_GenerateUniqueID.Location = new System.Drawing.Point(173, 364);
            this.B_GenerateUniqueID.Name = "B_GenerateUniqueID";
            this.B_GenerateUniqueID.Size = new System.Drawing.Size(156, 25);
            this.B_GenerateUniqueID.TabIndex = 22;
            this.B_GenerateUniqueID.Text = "Генерация кода";
            this.B_GenerateUniqueID.UseVisualStyleBackColor = false;
            // 
            // L_Info_GenerateUniqueID
            // 
            this.L_Info_GenerateUniqueID.AutoSize = true;
            this.L_Info_GenerateUniqueID.Location = new System.Drawing.Point(111, 331);
            this.L_Info_GenerateUniqueID.Name = "L_Info_GenerateUniqueID";
            this.L_Info_GenerateUniqueID.Size = new System.Drawing.Size(151, 17);
            this.L_Info_GenerateUniqueID.TabIndex = 21;
            this.L_Info_GenerateUniqueID.Text = "Генерация уникального кода";
            this.L_Info_GenerateUniqueID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Info_AddProduct
            // 
            this.L_Info_AddProduct.AutoSize = true;
            this.L_Info_AddProduct.Location = new System.Drawing.Point(111, 0);
            this.L_Info_AddProduct.Name = "L_Info_AddProduct";
            this.L_Info_AddProduct.Size = new System.Drawing.Size(103, 17);
            this.L_Info_AddProduct.TabIndex = 20;
            this.L_Info_AddProduct.Text = "Название продукта";
            this.L_Info_AddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_ApplyCount
            // 
            this.B_ApplyCount.BackColor = System.Drawing.Color.SandyBrown;
            this.B_ApplyCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ApplyCount.Location = new System.Drawing.Point(173, 289);
            this.B_ApplyCount.Name = "B_ApplyCount";
            this.B_ApplyCount.Size = new System.Drawing.Size(156, 25);
            this.B_ApplyCount.TabIndex = 19;
            this.B_ApplyCount.Text = "Принять количество";
            this.B_ApplyCount.UseVisualStyleBackColor = false;
            // 
            // B_ApplyPrice
            // 
            this.B_ApplyPrice.BackColor = System.Drawing.Color.SandyBrown;
            this.B_ApplyPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ApplyPrice.Location = new System.Drawing.Point(3, 289);
            this.B_ApplyPrice.Name = "B_ApplyPrice";
            this.B_ApplyPrice.Size = new System.Drawing.Size(156, 25);
            this.B_ApplyPrice.TabIndex = 18;
            this.B_ApplyPrice.Text = "Принять цену";
            this.B_ApplyPrice.UseVisualStyleBackColor = false;
            // 
            // L_Info_Product_Count
            // 
            this.L_Info_Product_Count.AutoSize = true;
            this.L_Info_Product_Count.Location = new System.Drawing.Point(170, 230);
            this.L_Info_Product_Count.Name = "L_Info_Product_Count";
            this.L_Info_Product_Count.Size = new System.Drawing.Size(65, 17);
            this.L_Info_Product_Count.TabIndex = 17;
            this.L_Info_Product_Count.Text = "Количество";
            this.L_Info_Product_Count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUD_Count
            // 
            this.NUD_Count.BackColor = System.Drawing.Color.SandyBrown;
            this.NUD_Count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_Count.Location = new System.Drawing.Point(173, 250);
            this.NUD_Count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Count.Name = "NUD_Count";
            this.NUD_Count.Size = new System.Drawing.Size(156, 22);
            this.NUD_Count.TabIndex = 16;
            this.NUD_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DUD_CountIncrement
            // 
            this.DUD_CountIncrement.BackColor = System.Drawing.Color.SandyBrown;
            this.DUD_CountIncrement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DUD_CountIncrement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DUD_CountIncrement.Items.Add("1000");
            this.DUD_CountIncrement.Items.Add("100");
            this.DUD_CountIncrement.Items.Add("10");
            this.DUD_CountIncrement.Items.Add("1");
            this.DUD_CountIncrement.Location = new System.Drawing.Point(173, 202);
            this.DUD_CountIncrement.Name = "DUD_CountIncrement";
            this.DUD_CountIncrement.Size = new System.Drawing.Size(156, 22);
            this.DUD_CountIncrement.TabIndex = 15;
            // 
            // L_Info_Product_CountInc
            // 
            this.L_Info_Product_CountInc.AutoSize = true;
            this.L_Info_Product_CountInc.Location = new System.Drawing.Point(170, 182);
            this.L_Info_Product_CountInc.Name = "L_Info_Product_CountInc";
            this.L_Info_Product_CountInc.Size = new System.Drawing.Size(121, 17);
            this.L_Info_Product_CountInc.TabIndex = 14;
            this.L_Info_Product_CountInc.Text = "Инкремент количества";
            this.L_Info_Product_CountInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Info_Product_Price
            // 
            this.L_Info_Product_Price.AutoSize = true;
            this.L_Info_Product_Price.Location = new System.Drawing.Point(0, 230);
            this.L_Info_Product_Price.Name = "L_Info_Product_Price";
            this.L_Info_Product_Price.Size = new System.Drawing.Size(33, 17);
            this.L_Info_Product_Price.TabIndex = 13;
            this.L_Info_Product_Price.Text = "Цена";
            this.L_Info_Product_Price.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUD_Price
            // 
            this.NUD_Price.BackColor = System.Drawing.Color.SandyBrown;
            this.NUD_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_Price.Location = new System.Drawing.Point(3, 250);
            this.NUD_Price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Price.Name = "NUD_Price";
            this.NUD_Price.Size = new System.Drawing.Size(156, 22);
            this.NUD_Price.TabIndex = 12;
            this.NUD_Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DUD_PriceIncrement
            // 
            this.DUD_PriceIncrement.BackColor = System.Drawing.Color.SandyBrown;
            this.DUD_PriceIncrement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DUD_PriceIncrement.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DUD_PriceIncrement.Items.Add("10000");
            this.DUD_PriceIncrement.Items.Add("1000");
            this.DUD_PriceIncrement.Items.Add("100");
            this.DUD_PriceIncrement.Items.Add("10");
            this.DUD_PriceIncrement.Items.Add("1");
            this.DUD_PriceIncrement.Location = new System.Drawing.Point(3, 202);
            this.DUD_PriceIncrement.Name = "DUD_PriceIncrement";
            this.DUD_PriceIncrement.Size = new System.Drawing.Size(156, 22);
            this.DUD_PriceIncrement.TabIndex = 11;
            // 
            // L_Info_Product_PriceInc
            // 
            this.L_Info_Product_PriceInc.AutoSize = true;
            this.L_Info_Product_PriceInc.Location = new System.Drawing.Point(0, 182);
            this.L_Info_Product_PriceInc.Name = "L_Info_Product_PriceInc";
            this.L_Info_Product_PriceInc.Size = new System.Drawing.Size(91, 17);
            this.L_Info_Product_PriceInc.TabIndex = 10;
            this.L_Info_Product_PriceInc.Text = "Инкремент цены";
            this.L_Info_Product_PriceInc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_SelectCategory
            // 
            this.B_SelectCategory.BackColor = System.Drawing.Color.SandyBrown;
            this.B_SelectCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SelectCategory.Location = new System.Drawing.Point(211, 138);
            this.B_SelectCategory.Name = "B_SelectCategory";
            this.B_SelectCategory.Size = new System.Drawing.Size(118, 25);
            this.B_SelectCategory.TabIndex = 9;
            this.B_SelectCategory.Text = "Выбрать категорию";
            this.B_SelectCategory.UseVisualStyleBackColor = false;
            // 
            // CB_GetCategories
            // 
            this.CB_GetCategories.BackColor = System.Drawing.Color.PeachPuff;
            this.CB_GetCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_GetCategories.FormattingEnabled = true;
            this.CB_GetCategories.Location = new System.Drawing.Point(3, 138);
            this.CB_GetCategories.Name = "CB_GetCategories";
            this.CB_GetCategories.Size = new System.Drawing.Size(202, 25);
            this.CB_GetCategories.TabIndex = 8;
            // 
            // B_GetCategoryData
            // 
            this.B_GetCategoryData.BackColor = System.Drawing.Color.SandyBrown;
            this.B_GetCategoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_GetCategoryData.Location = new System.Drawing.Point(169, 75);
            this.B_GetCategoryData.Name = "B_GetCategoryData";
            this.B_GetCategoryData.Size = new System.Drawing.Size(160, 26);
            this.B_GetCategoryData.TabIndex = 7;
            this.B_GetCategoryData.Text = "Получить данные категории";
            this.B_GetCategoryData.UseVisualStyleBackColor = false;
            // 
            // L_Info_Product_Category
            // 
            this.L_Info_Product_Category.AutoSize = true;
            this.L_Info_Product_Category.Location = new System.Drawing.Point(0, 118);
            this.L_Info_Product_Category.Name = "L_Info_Product_Category";
            this.L_Info_Product_Category.Size = new System.Drawing.Size(59, 17);
            this.L_Info_Product_Category.TabIndex = 6;
            this.L_Info_Product_Category.Text = "Категория";
            this.L_Info_Product_Category.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_ProductName_Check
            // 
            this.B_ProductName_Check.BackColor = System.Drawing.Color.SandyBrown;
            this.B_ProductName_Check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ProductName_Check.Location = new System.Drawing.Point(3, 75);
            this.B_ProductName_Check.Name = "B_ProductName_Check";
            this.B_ProductName_Check.Size = new System.Drawing.Size(160, 26);
            this.B_ProductName_Check.TabIndex = 5;
            this.B_ProductName_Check.Text = "Проверить название";
            this.B_ProductName_Check.UseVisualStyleBackColor = false;
            // 
            // L_Info_ProductName
            // 
            this.L_Info_ProductName.AutoSize = true;
            this.L_Info_ProductName.Location = new System.Drawing.Point(3, 28);
            this.L_Info_ProductName.Name = "L_Info_ProductName";
            this.L_Info_ProductName.Size = new System.Drawing.Size(103, 17);
            this.L_Info_ProductName.TabIndex = 3;
            this.L_Info_ProductName.Text = "Название продукта";
            this.L_Info_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_ProductName
            // 
            this.TB_ProductName.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_ProductName.Location = new System.Drawing.Point(3, 47);
            this.TB_ProductName.Name = "TB_ProductName";
            this.TB_ProductName.Size = new System.Drawing.Size(330, 22);
            this.TB_ProductName.TabIndex = 4;
            // 
            // PB_LogoMain
            // 
            this.PB_LogoMain.Image = global::Bookshop.Properties.Resources.BSManager_MainLogo;
            this.PB_LogoMain.Location = new System.Drawing.Point(22, 37);
            this.PB_LogoMain.Name = "PB_LogoMain";
            this.PB_LogoMain.Size = new System.Drawing.Size(338, 131);
            this.PB_LogoMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_LogoMain.TabIndex = 2;
            this.PB_LogoMain.TabStop = false;
            // 
            // PNL_CodeSelector
            // 
            this.PNL_CodeSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.PNL_CodeSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_CodeSelector.Controls.Add(this.TLP_ProdusctsRedact);
            this.PNL_CodeSelector.Location = new System.Drawing.Point(376, 439);
            this.PNL_CodeSelector.Name = "PNL_CodeSelector";
            this.PNL_CodeSelector.Size = new System.Drawing.Size(968, 246);
            this.PNL_CodeSelector.TabIndex = 4;
            // 
            // TLP_ProdusctsRedact
            // 
            this.TLP_ProdusctsRedact.ColumnCount = 3;
            this.TLP_ProdusctsRedact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TLP_ProdusctsRedact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.TLP_ProdusctsRedact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TLP_ProdusctsRedact.Controls.Add(this.PNL_Redact_Rename, 1, 0);
            this.TLP_ProdusctsRedact.Controls.Add(this.PNL_Redact_Update, 0, 0);
            this.TLP_ProdusctsRedact.Controls.Add(this.PNL_Redact_Delete, 2, 0);
            this.TLP_ProdusctsRedact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_ProdusctsRedact.Location = new System.Drawing.Point(0, 0);
            this.TLP_ProdusctsRedact.Name = "TLP_ProdusctsRedact";
            this.TLP_ProdusctsRedact.RowCount = 1;
            this.TLP_ProdusctsRedact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_ProdusctsRedact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_ProdusctsRedact.Size = new System.Drawing.Size(966, 244);
            this.TLP_ProdusctsRedact.TabIndex = 0;
            // 
            // PNL_Redact_Delete
            // 
            this.PNL_Redact_Delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_Redact_Delete.Controls.Add(this.L_Info_RedactDelete);
            this.PNL_Redact_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Redact_Delete.Location = new System.Drawing.Point(649, 3);
            this.PNL_Redact_Delete.Name = "PNL_Redact_Delete";
            this.PNL_Redact_Delete.Size = new System.Drawing.Size(314, 238);
            this.PNL_Redact_Delete.TabIndex = 0;
            // 
            // PNL_Redact_Update
            // 
            this.PNL_Redact_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_Redact_Update.Controls.Add(this.L_Info_RedactUpdate);
            this.PNL_Redact_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Redact_Update.Location = new System.Drawing.Point(3, 3);
            this.PNL_Redact_Update.Name = "PNL_Redact_Update";
            this.PNL_Redact_Update.Size = new System.Drawing.Size(312, 238);
            this.PNL_Redact_Update.TabIndex = 1;
            // 
            // PNL_Redact_Rename
            // 
            this.PNL_Redact_Rename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_Redact_Rename.Controls.Add(this.L_Info_RedactRename);
            this.PNL_Redact_Rename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Redact_Rename.Location = new System.Drawing.Point(321, 3);
            this.PNL_Redact_Rename.Name = "PNL_Redact_Rename";
            this.PNL_Redact_Rename.Size = new System.Drawing.Size(322, 238);
            this.PNL_Redact_Rename.TabIndex = 2;
            // 
            // L_Info_RedactUpdate
            // 
            this.L_Info_RedactUpdate.AutoSize = true;
            this.L_Info_RedactUpdate.Location = new System.Drawing.Point(70, 1);
            this.L_Info_RedactUpdate.Name = "L_Info_RedactUpdate";
            this.L_Info_RedactUpdate.Size = new System.Drawing.Size(142, 17);
            this.L_Info_RedactUpdate.TabIndex = 21;
            this.L_Info_RedactUpdate.Text = "Обнавить данные продукта";
            this.L_Info_RedactUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Info_RedactRename
            // 
            this.L_Info_RedactRename.AutoSize = true;
            this.L_Info_RedactRename.Location = new System.Drawing.Point(108, 1);
            this.L_Info_RedactRename.Name = "L_Info_RedactRename";
            this.L_Info_RedactRename.Size = new System.Drawing.Size(128, 17);
            this.L_Info_RedactRename.TabIndex = 22;
            this.L_Info_RedactRename.Text = "Переименовать продукт";
            this.L_Info_RedactRename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Info_RedactDelete
            // 
            this.L_Info_RedactDelete.AutoSize = true;
            this.L_Info_RedactDelete.Location = new System.Drawing.Point(127, 1);
            this.L_Info_RedactDelete.Name = "L_Info_RedactDelete";
            this.L_Info_RedactDelete.Size = new System.Drawing.Size(88, 17);
            this.L_Info_RedactDelete.TabIndex = 23;
            this.L_Info_RedactDelete.Text = "Удалить продукт";
            this.L_Info_RedactDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.PNL_CodeSelector);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.PNL_GridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MS_Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDBDataSet)).EndInit();
            this.PNL_DataOperation.ResumeLayout(false);
            this.PNL_DataOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LogoMain)).EndInit();
            this.PNL_CodeSelector.ResumeLayout(false);
            this.TLP_ProdusctsRedact.ResumeLayout(false);
            this.PNL_Redact_Delete.ResumeLayout(false);
            this.PNL_Redact_Delete.PerformLayout();
            this.PNL_Redact_Update.ResumeLayout(false);
            this.PNL_Redact_Update.PerformLayout();
            this.PNL_Redact_Rename.ResumeLayout(false);
            this.PNL_Redact_Rename.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem TSMI_Category;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Category_Add;
        private System.Windows.Forms.Panel PNL_GridView;
        private System.Windows.Forms.PictureBox PB_LogoMain;
        private System.Windows.Forms.Panel PNL_DataOperation;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TopMost;
        private BSDBDataSet bSDBDataSet;
        public System.Windows.Forms.DataGridView DGV_MS_Product;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Panel PNL_CodeSelector;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Datas;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Synchronize;
        private System.Windows.Forms.Label L_Info_ProductName;
        private System.Windows.Forms.TextBox TB_ProductName;
        private System.Windows.Forms.Button B_ProductName_Check;
        private System.Windows.Forms.Button B_GetCategoryData;
        private System.Windows.Forms.Label L_Info_Product_Category;
        private System.Windows.Forms.Button B_SelectCategory;
        private System.Windows.Forms.ComboBox CB_GetCategories;
        public System.Windows.Forms.Label L_Info_Product_PriceInc;
        public System.Windows.Forms.DomainUpDown DUD_PriceIncrement;
        public System.Windows.Forms.Label L_Info_Product_Price;
        private System.Windows.Forms.NumericUpDown NUD_Price;
        public System.Windows.Forms.Label L_Info_Product_Count;
        private System.Windows.Forms.NumericUpDown NUD_Count;
        public System.Windows.Forms.DomainUpDown DUD_CountIncrement;
        public System.Windows.Forms.Label L_Info_Product_CountInc;
        private System.Windows.Forms.Button B_ApplyCount;
        private System.Windows.Forms.Button B_ApplyPrice;
        private System.Windows.Forms.Label L_Info_AddProduct;
        private System.Windows.Forms.Button B_GenerateUniqueID;
        private System.Windows.Forms.Label L_Info_GenerateUniqueID;
        public System.Windows.Forms.DateTimePicker DTP_ForUniqueCode;
        private System.Windows.Forms.Button B_ApplyData;
        private System.Windows.Forms.Label L_Info_UniqueID;
        private System.Windows.Forms.TextBox TB_UniqueCode;
        private System.Windows.Forms.TableLayoutPanel TLP_ProdusctsRedact;
        private System.Windows.Forms.Panel PNL_Redact_Rename;
        private System.Windows.Forms.Panel PNL_Redact_Update;
        private System.Windows.Forms.Panel PNL_Redact_Delete;
        private System.Windows.Forms.Label L_Info_RedactRename;
        private System.Windows.Forms.Label L_Info_RedactUpdate;
        private System.Windows.Forms.Label L_Info_RedactDelete;
    }
}