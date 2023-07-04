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
            this.TSMI_Update_DGV = new System.Windows.Forms.ToolStripMenuItem();
            this.PNL_GridView = new System.Windows.Forms.Panel();
            this.DGV_MS_Product = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.изменениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bSDBDataSet = new Bookshop.BSDBDataSet();
            this.PNL_DataOperation = new System.Windows.Forms.Panel();
            this.B_UpdatePanel = new System.Windows.Forms.Button();
            this.CHB_CountOver1000 = new System.Windows.Forms.CheckBox();
            this.CHB_CountOver100 = new System.Windows.Forms.CheckBox();
            this.CHB_PriceOver1000 = new System.Windows.Forms.CheckBox();
            this.CHB_PriceOver100 = new System.Windows.Forms.CheckBox();
            this.B_ApplyData = new System.Windows.Forms.Button();
            this.L_Info_UniqueID = new System.Windows.Forms.Label();
            this.TB_UniqueCode = new System.Windows.Forms.TextBox();
            this.B_GenerateUniqueID = new System.Windows.Forms.Button();
            this.L_Info_GenerateUniqueID = new System.Windows.Forms.Label();
            this.L_Info_AddProduct = new System.Windows.Forms.Label();
            this.B_ApplyCount = new System.Windows.Forms.Button();
            this.B_ApplyPrice = new System.Windows.Forms.Button();
            this.L_Info_Product_Count = new System.Windows.Forms.Label();
            this.NUD_Count = new System.Windows.Forms.NumericUpDown();
            this.L_Info_Product_Price = new System.Windows.Forms.Label();
            this.NUD_Price = new System.Windows.Forms.NumericUpDown();
            this.B_SelectCategory = new System.Windows.Forms.Button();
            this.CB_GetCategories = new System.Windows.Forms.ComboBox();
            this.B_GetCategoryData = new System.Windows.Forms.Button();
            this.L_Info_Product_Category = new System.Windows.Forms.Label();
            this.B_ProductName_Check = new System.Windows.Forms.Button();
            this.L_Info_ProductName = new System.Windows.Forms.Label();
            this.TB_ProductName = new System.Windows.Forms.TextBox();
            this.PNL_CodeSelector = new System.Windows.Forms.Panel();
            this.TLP_ProdusctsRedact = new System.Windows.Forms.TableLayoutPanel();
            this.CHB_ProdRename_Code = new System.Windows.Forms.Panel();
            this.B_AcceptChoice_Rename = new System.Windows.Forms.Button();
            this.GB_SelectProduct_Rename = new System.Windows.Forms.GroupBox();
            this.CHB_SelectAll_Rename = new System.Windows.Forms.CheckBox();
            this.L_Info_Product_NewName = new System.Windows.Forms.Label();
            this.B_RenameProduct = new System.Windows.Forms.Button();
            this.TB_NewName_Rename = new System.Windows.Forms.TextBox();
            this.B_CheckNewName = new System.Windows.Forms.Button();
            this.CB_Products_Rename = new System.Windows.Forms.ComboBox();
            this.L_NameCode_Rename = new System.Windows.Forms.Label();
            this.GB_SearchType_Rename = new System.Windows.Forms.GroupBox();
            this.CHB_ProdRename_ByCode = new System.Windows.Forms.CheckBox();
            this.CHB_ProdRename_ByName = new System.Windows.Forms.CheckBox();
            this.CHB_ProdRename_ByCategory = new System.Windows.Forms.CheckBox();
            this.TB_InputDataForSearch_Rename = new System.Windows.Forms.TextBox();
            this.L_Info_RedactRename = new System.Windows.Forms.Label();
            this.CB_CategorySearch_Rename = new System.Windows.Forms.ComboBox();
            this.L_InfoCatregorySearch_Rename = new System.Windows.Forms.Label();
            this.PNL_Redact_Update = new System.Windows.Forms.Panel();
            this.B_AcceptChoice_Update = new System.Windows.Forms.Button();
            this.GB_SelectProduct_Update = new System.Windows.Forms.GroupBox();
            this.B_RedactChoosenProduct = new System.Windows.Forms.Button();
            this.CB_Products_Update = new System.Windows.Forms.ComboBox();
            this.L_NameCode_Update = new System.Windows.Forms.Label();
            this.TB_InputDataForSearch_Update = new System.Windows.Forms.TextBox();
            this.CB_CategorySearch_Update = new System.Windows.Forms.ComboBox();
            this.L_InfoCatregorySearch_Update = new System.Windows.Forms.Label();
            this.GB_SearchType_Update = new System.Windows.Forms.GroupBox();
            this.CHB_ProdUpdate_ByCode = new System.Windows.Forms.CheckBox();
            this.CHB_ProdUpdate_ByName = new System.Windows.Forms.CheckBox();
            this.CHB_ProdUpdate_ByCategory = new System.Windows.Forms.CheckBox();
            this.L_Info_RedactUpdate = new System.Windows.Forms.Label();
            this.PNL_Redact_Delete = new System.Windows.Forms.Panel();
            this.B_AcceptChoice_Delete = new System.Windows.Forms.Button();
            this.GB_SelectProduct_Delete = new System.Windows.Forms.GroupBox();
            this.CHB_SelectAll_Delete = new System.Windows.Forms.CheckBox();
            this.B_ProductDelete = new System.Windows.Forms.Button();
            this.CB_Products_Delete = new System.Windows.Forms.ComboBox();
            this.L_NameCode_Delete = new System.Windows.Forms.Label();
            this.TB_InputDataForSearch_Delete = new System.Windows.Forms.TextBox();
            this.CB_CategorySearch_Delete = new System.Windows.Forms.ComboBox();
            this.L_InfoCatregorySearch_Delete = new System.Windows.Forms.Label();
            this.GB_SearchType_Delete = new System.Windows.Forms.GroupBox();
            this.CHB_ProdDelete_ByCode = new System.Windows.Forms.CheckBox();
            this.CHB_ProdDelete_ByName = new System.Windows.Forms.CheckBox();
            this.CHB_ProdDelete_ByCategory = new System.Windows.Forms.CheckBox();
            this.L_Info_RedactDelete = new System.Windows.Forms.Label();
            this.productTableAdapter = new Bookshop.BSDBDataSetTableAdapters.ProductTableAdapter();
            this.B_DEBUG_ADDCATEGORY = new System.Windows.Forms.Button();
            this.B_DEBUG_ADDPRODUCT = new System.Windows.Forms.Button();
            this.PB_LogoMain = new System.Windows.Forms.PictureBox();
            this.MS_Main.SuspendLayout();
            this.PNL_GridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_MS_Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSDBDataSet)).BeginInit();
            this.PNL_DataOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Count)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Price)).BeginInit();
            this.PNL_CodeSelector.SuspendLayout();
            this.TLP_ProdusctsRedact.SuspendLayout();
            this.CHB_ProdRename_Code.SuspendLayout();
            this.GB_SelectProduct_Rename.SuspendLayout();
            this.GB_SearchType_Rename.SuspendLayout();
            this.PNL_Redact_Update.SuspendLayout();
            this.GB_SelectProduct_Update.SuspendLayout();
            this.GB_SearchType_Update.SuspendLayout();
            this.PNL_Redact_Delete.SuspendLayout();
            this.GB_SelectProduct_Delete.SuspendLayout();
            this.GB_SearchType_Delete.SuspendLayout();
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
            this.TSMI_Synchronize,
            this.TSMI_Update_DGV});
            this.TSMI_Datas.Name = "TSMI_Datas";
            this.TSMI_Datas.Size = new System.Drawing.Size(59, 21);
            this.TSMI_Datas.Text = "Данные";
            // 
            // TSMI_Synchronize
            // 
            this.TSMI_Synchronize.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Synchronize.Enabled = false;
            this.TSMI_Synchronize.Name = "TSMI_Synchronize";
            this.TSMI_Synchronize.Size = new System.Drawing.Size(169, 22);
            this.TSMI_Synchronize.Text = "Синхронизировать";
            this.TSMI_Synchronize.Click += new System.EventHandler(this.TSMI_Synchronize_Click);
            // 
            // TSMI_Update_DGV
            // 
            this.TSMI_Update_DGV.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_Update_DGV.Name = "TSMI_Update_DGV";
            this.TSMI_Update_DGV.Size = new System.Drawing.Size(169, 22);
            this.TSMI_Update_DGV.Text = "Обнавить таблицу";
            this.TSMI_Update_DGV.Click += new System.EventHandler(this.TSMI_Update_DGV_Click);
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
            this.кодDataGridViewTextBoxColumn,
            this.изменениеDataGridViewTextBoxColumn});
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
            this.iDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
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
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.FillWeight = 120F;
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Width = 120;
            // 
            // изменениеDataGridViewTextBoxColumn
            // 
            this.изменениеDataGridViewTextBoxColumn.DataPropertyName = "Изменение";
            this.изменениеDataGridViewTextBoxColumn.FillWeight = 120F;
            this.изменениеDataGridViewTextBoxColumn.HeaderText = "Изменение";
            this.изменениеDataGridViewTextBoxColumn.Name = "изменениеDataGridViewTextBoxColumn";
            this.изменениеDataGridViewTextBoxColumn.Width = 120;
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
            this.PNL_DataOperation.Controls.Add(this.B_UpdatePanel);
            this.PNL_DataOperation.Controls.Add(this.CHB_CountOver1000);
            this.PNL_DataOperation.Controls.Add(this.CHB_CountOver100);
            this.PNL_DataOperation.Controls.Add(this.CHB_PriceOver1000);
            this.PNL_DataOperation.Controls.Add(this.CHB_PriceOver100);
            this.PNL_DataOperation.Controls.Add(this.B_ApplyData);
            this.PNL_DataOperation.Controls.Add(this.L_Info_UniqueID);
            this.PNL_DataOperation.Controls.Add(this.TB_UniqueCode);
            this.PNL_DataOperation.Controls.Add(this.B_GenerateUniqueID);
            this.PNL_DataOperation.Controls.Add(this.L_Info_GenerateUniqueID);
            this.PNL_DataOperation.Controls.Add(this.L_Info_AddProduct);
            this.PNL_DataOperation.Controls.Add(this.B_ApplyCount);
            this.PNL_DataOperation.Controls.Add(this.B_ApplyPrice);
            this.PNL_DataOperation.Controls.Add(this.L_Info_Product_Count);
            this.PNL_DataOperation.Controls.Add(this.NUD_Count);
            this.PNL_DataOperation.Controls.Add(this.L_Info_Product_Price);
            this.PNL_DataOperation.Controls.Add(this.NUD_Price);
            this.PNL_DataOperation.Controls.Add(this.B_SelectCategory);
            this.PNL_DataOperation.Controls.Add(this.CB_GetCategories);
            this.PNL_DataOperation.Controls.Add(this.B_GetCategoryData);
            this.PNL_DataOperation.Controls.Add(this.L_Info_Product_Category);
            this.PNL_DataOperation.Controls.Add(this.B_ProductName_Check);
            this.PNL_DataOperation.Controls.Add(this.L_Info_ProductName);
            this.PNL_DataOperation.Controls.Add(this.TB_ProductName);
            this.PNL_DataOperation.Enabled = false;
            this.PNL_DataOperation.Location = new System.Drawing.Point(22, 188);
            this.PNL_DataOperation.Name = "PNL_DataOperation";
            this.PNL_DataOperation.Size = new System.Drawing.Size(338, 457);
            this.PNL_DataOperation.TabIndex = 3;
            // 
            // B_UpdatePanel
            // 
            this.B_UpdatePanel.BackColor = System.Drawing.Color.SandyBrown;
            this.B_UpdatePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_UpdatePanel.Location = new System.Drawing.Point(226, 15);
            this.B_UpdatePanel.Name = "B_UpdatePanel";
            this.B_UpdatePanel.Size = new System.Drawing.Size(103, 26);
            this.B_UpdatePanel.TabIndex = 35;
            this.B_UpdatePanel.Text = "Обновить";
            this.B_UpdatePanel.UseVisualStyleBackColor = false;
            this.B_UpdatePanel.Click += new System.EventHandler(this.B_UpdatePanel_Click);
            // 
            // CHB_CountOver1000
            // 
            this.CHB_CountOver1000.AutoSize = true;
            this.CHB_CountOver1000.Enabled = false;
            this.CHB_CountOver1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_CountOver1000.Location = new System.Drawing.Point(177, 204);
            this.CHB_CountOver1000.Name = "CHB_CountOver1000";
            this.CHB_CountOver1000.Size = new System.Drawing.Size(93, 21);
            this.CHB_CountOver1000.TabIndex = 34;
            this.CHB_CountOver1000.Tag = "2";
            this.CHB_CountOver1000.Text = "Больше 1000";
            this.CHB_CountOver1000.UseVisualStyleBackColor = true;
            this.CHB_CountOver1000.CheckedChanged += new System.EventHandler(this.CHB_CountOver1000_CheckedChanged);
            // 
            // CHB_CountOver100
            // 
            this.CHB_CountOver100.AutoSize = true;
            this.CHB_CountOver100.Enabled = false;
            this.CHB_CountOver100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_CountOver100.Location = new System.Drawing.Point(177, 178);
            this.CHB_CountOver100.Name = "CHB_CountOver100";
            this.CHB_CountOver100.Size = new System.Drawing.Size(86, 21);
            this.CHB_CountOver100.TabIndex = 33;
            this.CHB_CountOver100.Tag = "1";
            this.CHB_CountOver100.Text = "Больше 100";
            this.CHB_CountOver100.UseVisualStyleBackColor = true;
            this.CHB_CountOver100.CheckedChanged += new System.EventHandler(this.CHB_CountOver100_CheckedChanged);
            // 
            // CHB_PriceOver1000
            // 
            this.CHB_PriceOver1000.AutoSize = true;
            this.CHB_PriceOver1000.Enabled = false;
            this.CHB_PriceOver1000.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_PriceOver1000.Location = new System.Drawing.Point(6, 204);
            this.CHB_PriceOver1000.Name = "CHB_PriceOver1000";
            this.CHB_PriceOver1000.Size = new System.Drawing.Size(93, 21);
            this.CHB_PriceOver1000.TabIndex = 32;
            this.CHB_PriceOver1000.Tag = "2";
            this.CHB_PriceOver1000.Text = "Больше 1000";
            this.CHB_PriceOver1000.UseVisualStyleBackColor = true;
            this.CHB_PriceOver1000.CheckedChanged += new System.EventHandler(this.CHB_PriceOver1000_CheckedChanged);
            // 
            // CHB_PriceOver100
            // 
            this.CHB_PriceOver100.AutoSize = true;
            this.CHB_PriceOver100.Enabled = false;
            this.CHB_PriceOver100.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_PriceOver100.Location = new System.Drawing.Point(6, 178);
            this.CHB_PriceOver100.Name = "CHB_PriceOver100";
            this.CHB_PriceOver100.Size = new System.Drawing.Size(86, 21);
            this.CHB_PriceOver100.TabIndex = 31;
            this.CHB_PriceOver100.Tag = "1";
            this.CHB_PriceOver100.Text = "Больше 100";
            this.CHB_PriceOver100.UseVisualStyleBackColor = true;
            this.CHB_PriceOver100.CheckedChanged += new System.EventHandler(this.CHB_PriceOver100_CheckedChanged);
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
            this.B_ApplyData.Click += new System.EventHandler(this.B_ApplyData_Click);
            // 
            // L_Info_UniqueID
            // 
            this.L_Info_UniqueID.AutoSize = true;
            this.L_Info_UniqueID.Location = new System.Drawing.Point(3, 401);
            this.L_Info_UniqueID.Name = "L_Info_UniqueID";
            this.L_Info_UniqueID.Size = new System.Drawing.Size(119, 17);
            this.L_Info_UniqueID.TabIndex = 24;
            this.L_Info_UniqueID.Text = "Уникальный код товар";
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
            // B_GenerateUniqueID
            // 
            this.B_GenerateUniqueID.BackColor = System.Drawing.Color.SandyBrown;
            this.B_GenerateUniqueID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_GenerateUniqueID.Location = new System.Drawing.Point(173, 351);
            this.B_GenerateUniqueID.Name = "B_GenerateUniqueID";
            this.B_GenerateUniqueID.Size = new System.Drawing.Size(156, 25);
            this.B_GenerateUniqueID.TabIndex = 22;
            this.B_GenerateUniqueID.Text = "Генерация кода";
            this.B_GenerateUniqueID.UseVisualStyleBackColor = false;
            this.B_GenerateUniqueID.Click += new System.EventHandler(this.B_GenerateUniqueID_Click);
            // 
            // L_Info_GenerateUniqueID
            // 
            this.L_Info_GenerateUniqueID.AutoSize = true;
            this.L_Info_GenerateUniqueID.Location = new System.Drawing.Point(0, 355);
            this.L_Info_GenerateUniqueID.Name = "L_Info_GenerateUniqueID";
            this.L_Info_GenerateUniqueID.Size = new System.Drawing.Size(151, 17);
            this.L_Info_GenerateUniqueID.TabIndex = 21;
            this.L_Info_GenerateUniqueID.Text = "Генерация уникального кода";
            this.L_Info_GenerateUniqueID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Info_AddProduct
            // 
            this.L_Info_AddProduct.AutoSize = true;
            this.L_Info_AddProduct.Location = new System.Drawing.Point(102, 0);
            this.L_Info_AddProduct.Name = "L_Info_AddProduct";
            this.L_Info_AddProduct.Size = new System.Drawing.Size(119, 17);
            this.L_Info_AddProduct.TabIndex = 20;
            this.L_Info_AddProduct.Text = "Добавить новый товар";
            this.L_Info_AddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_ApplyCount
            // 
            this.B_ApplyCount.BackColor = System.Drawing.Color.SandyBrown;
            this.B_ApplyCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ApplyCount.Location = new System.Drawing.Point(174, 291);
            this.B_ApplyCount.Name = "B_ApplyCount";
            this.B_ApplyCount.Size = new System.Drawing.Size(155, 25);
            this.B_ApplyCount.TabIndex = 19;
            this.B_ApplyCount.Text = "Принять количество";
            this.B_ApplyCount.UseVisualStyleBackColor = false;
            this.B_ApplyCount.Click += new System.EventHandler(this.B_ApplyCount_Click);
            // 
            // B_ApplyPrice
            // 
            this.B_ApplyPrice.BackColor = System.Drawing.Color.SandyBrown;
            this.B_ApplyPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ApplyPrice.Location = new System.Drawing.Point(4, 291);
            this.B_ApplyPrice.Name = "B_ApplyPrice";
            this.B_ApplyPrice.Size = new System.Drawing.Size(156, 25);
            this.B_ApplyPrice.TabIndex = 18;
            this.B_ApplyPrice.Text = "Принять цену";
            this.B_ApplyPrice.UseVisualStyleBackColor = false;
            this.B_ApplyPrice.Click += new System.EventHandler(this.B_ApplyPrice_Click);
            // 
            // L_Info_Product_Count
            // 
            this.L_Info_Product_Count.AutoSize = true;
            this.L_Info_Product_Count.Location = new System.Drawing.Point(174, 230);
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
            this.NUD_Count.Enabled = false;
            this.NUD_Count.Location = new System.Drawing.Point(177, 250);
            this.NUD_Count.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_Count.Name = "NUD_Count";
            this.NUD_Count.Size = new System.Drawing.Size(152, 22);
            this.NUD_Count.TabIndex = 16;
            this.NUD_Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Count.ValueChanged += new System.EventHandler(this.NUD_Count_ValueChanged);
            // 
            // L_Info_Product_Price
            // 
            this.L_Info_Product_Price.AutoSize = true;
            this.L_Info_Product_Price.Location = new System.Drawing.Point(4, 230);
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
            this.NUD_Price.Enabled = false;
            this.NUD_Price.Location = new System.Drawing.Point(7, 250);
            this.NUD_Price.Maximum = new decimal(new int[] {
            99,
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
            this.NUD_Price.ValueChanged += new System.EventHandler(this.NUD_Price_ValueChanged);
            // 
            // B_SelectCategory
            // 
            this.B_SelectCategory.BackColor = System.Drawing.Color.SandyBrown;
            this.B_SelectCategory.Enabled = false;
            this.B_SelectCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_SelectCategory.Location = new System.Drawing.Point(211, 138);
            this.B_SelectCategory.Name = "B_SelectCategory";
            this.B_SelectCategory.Size = new System.Drawing.Size(118, 25);
            this.B_SelectCategory.TabIndex = 9;
            this.B_SelectCategory.Text = "Выбрать категорию";
            this.B_SelectCategory.UseVisualStyleBackColor = false;
            this.B_SelectCategory.Click += new System.EventHandler(this.B_SelectCategory_Click);
            // 
            // CB_GetCategories
            // 
            this.CB_GetCategories.BackColor = System.Drawing.Color.PeachPuff;
            this.CB_GetCategories.Enabled = false;
            this.CB_GetCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_GetCategories.FormattingEnabled = true;
            this.CB_GetCategories.Location = new System.Drawing.Point(3, 138);
            this.CB_GetCategories.Name = "CB_GetCategories";
            this.CB_GetCategories.Size = new System.Drawing.Size(202, 25);
            this.CB_GetCategories.TabIndex = 8;
            this.CB_GetCategories.SelectedIndexChanged += new System.EventHandler(this.CB_GetCategories_SelectedIndexChanged);
            // 
            // B_GetCategoryData
            // 
            this.B_GetCategoryData.BackColor = System.Drawing.Color.SandyBrown;
            this.B_GetCategoryData.Enabled = false;
            this.B_GetCategoryData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_GetCategoryData.Location = new System.Drawing.Point(169, 75);
            this.B_GetCategoryData.Name = "B_GetCategoryData";
            this.B_GetCategoryData.Size = new System.Drawing.Size(160, 26);
            this.B_GetCategoryData.TabIndex = 7;
            this.B_GetCategoryData.Text = "Получить данные категории";
            this.B_GetCategoryData.UseVisualStyleBackColor = false;
            this.B_GetCategoryData.Click += new System.EventHandler(this.B_GetCategoryData_Click);
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
            this.B_ProductName_Check.Click += new System.EventHandler(this.B_ProductName_Check_Click);
            // 
            // L_Info_ProductName
            // 
            this.L_Info_ProductName.AutoSize = true;
            this.L_Info_ProductName.Location = new System.Drawing.Point(3, 28);
            this.L_Info_ProductName.Name = "L_Info_ProductName";
            this.L_Info_ProductName.Size = new System.Drawing.Size(92, 17);
            this.L_Info_ProductName.TabIndex = 3;
            this.L_Info_ProductName.Text = "Название товара";
            this.L_Info_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_ProductName
            // 
            this.TB_ProductName.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_ProductName.Location = new System.Drawing.Point(3, 47);
            this.TB_ProductName.Name = "TB_ProductName";
            this.TB_ProductName.Size = new System.Drawing.Size(326, 22);
            this.TB_ProductName.TabIndex = 4;
            // 
            // PNL_CodeSelector
            // 
            this.PNL_CodeSelector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.PNL_CodeSelector.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_CodeSelector.Controls.Add(this.TLP_ProdusctsRedact);
            this.PNL_CodeSelector.Location = new System.Drawing.Point(376, 439);
            this.PNL_CodeSelector.Name = "PNL_CodeSelector";
            this.PNL_CodeSelector.Size = new System.Drawing.Size(968, 259);
            this.PNL_CodeSelector.TabIndex = 4;
            // 
            // TLP_ProdusctsRedact
            // 
            this.TLP_ProdusctsRedact.ColumnCount = 3;
            this.TLP_ProdusctsRedact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TLP_ProdusctsRedact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.TLP_ProdusctsRedact.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.TLP_ProdusctsRedact.Controls.Add(this.CHB_ProdRename_Code, 1, 0);
            this.TLP_ProdusctsRedact.Controls.Add(this.PNL_Redact_Update, 0, 0);
            this.TLP_ProdusctsRedact.Controls.Add(this.PNL_Redact_Delete, 2, 0);
            this.TLP_ProdusctsRedact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_ProdusctsRedact.Location = new System.Drawing.Point(0, 0);
            this.TLP_ProdusctsRedact.Name = "TLP_ProdusctsRedact";
            this.TLP_ProdusctsRedact.RowCount = 1;
            this.TLP_ProdusctsRedact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_ProdusctsRedact.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 257F));
            this.TLP_ProdusctsRedact.Size = new System.Drawing.Size(966, 257);
            this.TLP_ProdusctsRedact.TabIndex = 0;
            // 
            // CHB_ProdRename_Code
            // 
            this.CHB_ProdRename_Code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CHB_ProdRename_Code.Controls.Add(this.B_AcceptChoice_Rename);
            this.CHB_ProdRename_Code.Controls.Add(this.GB_SelectProduct_Rename);
            this.CHB_ProdRename_Code.Controls.Add(this.L_NameCode_Rename);
            this.CHB_ProdRename_Code.Controls.Add(this.GB_SearchType_Rename);
            this.CHB_ProdRename_Code.Controls.Add(this.TB_InputDataForSearch_Rename);
            this.CHB_ProdRename_Code.Controls.Add(this.L_Info_RedactRename);
            this.CHB_ProdRename_Code.Controls.Add(this.CB_CategorySearch_Rename);
            this.CHB_ProdRename_Code.Controls.Add(this.L_InfoCatregorySearch_Rename);
            this.CHB_ProdRename_Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CHB_ProdRename_Code.Location = new System.Drawing.Point(321, 3);
            this.CHB_ProdRename_Code.Name = "CHB_ProdRename_Code";
            this.CHB_ProdRename_Code.Size = new System.Drawing.Size(322, 251);
            this.CHB_ProdRename_Code.TabIndex = 2;
            // 
            // B_AcceptChoice_Rename
            // 
            this.B_AcceptChoice_Rename.BackColor = System.Drawing.Color.SandyBrown;
            this.B_AcceptChoice_Rename.Enabled = false;
            this.B_AcceptChoice_Rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_AcceptChoice_Rename.Location = new System.Drawing.Point(166, 125);
            this.B_AcceptChoice_Rename.Name = "B_AcceptChoice_Rename";
            this.B_AcceptChoice_Rename.Size = new System.Drawing.Size(145, 25);
            this.B_AcceptChoice_Rename.TabIndex = 40;
            this.B_AcceptChoice_Rename.Text = "Выбрать";
            this.B_AcceptChoice_Rename.UseVisualStyleBackColor = false;
            this.B_AcceptChoice_Rename.Click += new System.EventHandler(this.B_AcceptChoice_Rename_Click);
            // 
            // GB_SelectProduct_Rename
            // 
            this.GB_SelectProduct_Rename.Controls.Add(this.CHB_SelectAll_Rename);
            this.GB_SelectProduct_Rename.Controls.Add(this.L_Info_Product_NewName);
            this.GB_SelectProduct_Rename.Controls.Add(this.B_RenameProduct);
            this.GB_SelectProduct_Rename.Controls.Add(this.TB_NewName_Rename);
            this.GB_SelectProduct_Rename.Controls.Add(this.B_CheckNewName);
            this.GB_SelectProduct_Rename.Controls.Add(this.CB_Products_Rename);
            this.GB_SelectProduct_Rename.Location = new System.Drawing.Point(3, 146);
            this.GB_SelectProduct_Rename.Name = "GB_SelectProduct_Rename";
            this.GB_SelectProduct_Rename.Size = new System.Drawing.Size(314, 104);
            this.GB_SelectProduct_Rename.TabIndex = 41;
            this.GB_SelectProduct_Rename.TabStop = false;
            this.GB_SelectProduct_Rename.Tag = "0";
            this.GB_SelectProduct_Rename.Text = "Выбрать Товар";
            // 
            // CHB_SelectAll_Rename
            // 
            this.CHB_SelectAll_Rename.AutoSize = true;
            this.CHB_SelectAll_Rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_SelectAll_Rename.Location = new System.Drawing.Point(226, 48);
            this.CHB_SelectAll_Rename.Name = "CHB_SelectAll_Rename";
            this.CHB_SelectAll_Rename.Size = new System.Drawing.Size(82, 21);
            this.CHB_SelectAll_Rename.TabIndex = 44;
            this.CHB_SelectAll_Rename.Tag = "2";
            this.CHB_SelectAll_Rename.Text = "Удалить все";
            this.CHB_SelectAll_Rename.UseVisualStyleBackColor = true;
            this.CHB_SelectAll_Rename.CheckedChanged += new System.EventHandler(this.CHB_SelectAll_Rename_CheckedChanged);
            // 
            // L_Info_Product_NewName
            // 
            this.L_Info_Product_NewName.AutoSize = true;
            this.L_Info_Product_NewName.Location = new System.Drawing.Point(6, 56);
            this.L_Info_Product_NewName.Name = "L_Info_Product_NewName";
            this.L_Info_Product_NewName.Size = new System.Drawing.Size(89, 17);
            this.L_Info_Product_NewName.TabIndex = 38;
            this.L_Info_Product_NewName.Text = "Новое Название";
            this.L_Info_Product_NewName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_RenameProduct
            // 
            this.B_RenameProduct.BackColor = System.Drawing.Color.SandyBrown;
            this.B_RenameProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_RenameProduct.Location = new System.Drawing.Point(163, 73);
            this.B_RenameProduct.Name = "B_RenameProduct";
            this.B_RenameProduct.Size = new System.Drawing.Size(145, 25);
            this.B_RenameProduct.TabIndex = 43;
            this.B_RenameProduct.Text = "Переименовать товар";
            this.B_RenameProduct.UseVisualStyleBackColor = false;
            // 
            // TB_NewName_Rename
            // 
            this.TB_NewName_Rename.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_NewName_Rename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_NewName_Rename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_NewName_Rename.Location = new System.Drawing.Point(6, 76);
            this.TB_NewName_Rename.Name = "TB_NewName_Rename";
            this.TB_NewName_Rename.Size = new System.Drawing.Size(147, 22);
            this.TB_NewName_Rename.TabIndex = 37;
            // 
            // B_CheckNewName
            // 
            this.B_CheckNewName.BackColor = System.Drawing.Color.SandyBrown;
            this.B_CheckNewName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_CheckNewName.Location = new System.Drawing.Point(163, 20);
            this.B_CheckNewName.Name = "B_CheckNewName";
            this.B_CheckNewName.Size = new System.Drawing.Size(145, 25);
            this.B_CheckNewName.TabIndex = 42;
            this.B_CheckNewName.Text = "Проверить название";
            this.B_CheckNewName.UseVisualStyleBackColor = false;
            this.B_CheckNewName.Click += new System.EventHandler(this.B_CheckNewName_Click);
            // 
            // CB_Products_Rename
            // 
            this.CB_Products_Rename.BackColor = System.Drawing.Color.PeachPuff;
            this.CB_Products_Rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Products_Rename.FormattingEnabled = true;
            this.CB_Products_Rename.Location = new System.Drawing.Point(6, 21);
            this.CB_Products_Rename.Name = "CB_Products_Rename";
            this.CB_Products_Rename.Size = new System.Drawing.Size(144, 25);
            this.CB_Products_Rename.TabIndex = 38;
            // 
            // L_NameCode_Rename
            // 
            this.L_NameCode_Rename.AutoSize = true;
            this.L_NameCode_Rename.Location = new System.Drawing.Point(0, 30);
            this.L_NameCode_Rename.Name = "L_NameCode_Rename";
            this.L_NameCode_Rename.Size = new System.Drawing.Size(27, 17);
            this.L_NameCode_Rename.TabIndex = 39;
            this.L_NameCode_Rename.Text = "Код";
            this.L_NameCode_Rename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GB_SearchType_Rename
            // 
            this.GB_SearchType_Rename.Controls.Add(this.CHB_ProdRename_ByCode);
            this.GB_SearchType_Rename.Controls.Add(this.CHB_ProdRename_ByName);
            this.GB_SearchType_Rename.Controls.Add(this.CHB_ProdRename_ByCategory);
            this.GB_SearchType_Rename.Location = new System.Drawing.Point(169, 21);
            this.GB_SearchType_Rename.Name = "GB_SearchType_Rename";
            this.GB_SearchType_Rename.Size = new System.Drawing.Size(148, 100);
            this.GB_SearchType_Rename.TabIndex = 32;
            this.GB_SearchType_Rename.TabStop = false;
            this.GB_SearchType_Rename.Tag = "1";
            this.GB_SearchType_Rename.Text = "Тип Поиска";
            // 
            // CHB_ProdRename_ByCode
            // 
            this.CHB_ProdRename_ByCode.AutoSize = true;
            this.CHB_ProdRename_ByCode.Checked = true;
            this.CHB_ProdRename_ByCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHB_ProdRename_ByCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ProdRename_ByCode.Location = new System.Drawing.Point(6, 18);
            this.CHB_ProdRename_ByCode.Name = "CHB_ProdRename_ByCode";
            this.CHB_ProdRename_ByCode.Size = new System.Drawing.Size(93, 21);
            this.CHB_ProdRename_ByCode.TabIndex = 22;
            this.CHB_ProdRename_ByCode.Tag = "0";
            this.CHB_ProdRename_ByCode.Text = "Поиск по коду";
            this.CHB_ProdRename_ByCode.UseVisualStyleBackColor = true;
            this.CHB_ProdRename_ByCode.CheckedChanged += new System.EventHandler(this.CHB_ProdRename_ByCode_CheckedChanged);
            // 
            // CHB_ProdRename_ByName
            // 
            this.CHB_ProdRename_ByName.AutoSize = true;
            this.CHB_ProdRename_ByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ProdRename_ByName.Location = new System.Drawing.Point(6, 70);
            this.CHB_ProdRename_ByName.Name = "CHB_ProdRename_ByName";
            this.CHB_ProdRename_ByName.Size = new System.Drawing.Size(120, 21);
            this.CHB_ProdRename_ByName.TabIndex = 30;
            this.CHB_ProdRename_ByName.Tag = "2";
            this.CHB_ProdRename_ByName.Text = "Поиск по названию";
            this.CHB_ProdRename_ByName.UseVisualStyleBackColor = true;
            this.CHB_ProdRename_ByName.CheckedChanged += new System.EventHandler(this.CHB_ProdRename_ByName_CheckedChanged);
            // 
            // CHB_ProdRename_ByCategory
            // 
            this.CHB_ProdRename_ByCategory.AutoSize = true;
            this.CHB_ProdRename_ByCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ProdRename_ByCategory.Location = new System.Drawing.Point(6, 44);
            this.CHB_ProdRename_ByCategory.Name = "CHB_ProdRename_ByCategory";
            this.CHB_ProdRename_ByCategory.Size = new System.Drawing.Size(128, 21);
            this.CHB_ProdRename_ByCategory.TabIndex = 29;
            this.CHB_ProdRename_ByCategory.Tag = "1";
            this.CHB_ProdRename_ByCategory.Text = "Поиск по категориям";
            this.CHB_ProdRename_ByCategory.UseVisualStyleBackColor = true;
            this.CHB_ProdRename_ByCategory.CheckedChanged += new System.EventHandler(this.CHB_ProdRename_ByCategory_CheckedChanged);
            // 
            // TB_InputDataForSearch_Rename
            // 
            this.TB_InputDataForSearch_Rename.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_InputDataForSearch_Rename.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_InputDataForSearch_Rename.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_InputDataForSearch_Rename.Location = new System.Drawing.Point(3, 50);
            this.TB_InputDataForSearch_Rename.Name = "TB_InputDataForSearch_Rename";
            this.TB_InputDataForSearch_Rename.Size = new System.Drawing.Size(147, 22);
            this.TB_InputDataForSearch_Rename.TabIndex = 38;
            // 
            // L_Info_RedactRename
            // 
            this.L_Info_RedactRename.AutoSize = true;
            this.L_Info_RedactRename.Location = new System.Drawing.Point(108, 1);
            this.L_Info_RedactRename.Name = "L_Info_RedactRename";
            this.L_Info_RedactRename.Size = new System.Drawing.Size(117, 17);
            this.L_Info_RedactRename.TabIndex = 22;
            this.L_Info_RedactRename.Text = "Переименовать товар";
            this.L_Info_RedactRename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_CategorySearch_Rename
            // 
            this.CB_CategorySearch_Rename.BackColor = System.Drawing.Color.PeachPuff;
            this.CB_CategorySearch_Rename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_CategorySearch_Rename.FormattingEnabled = true;
            this.CB_CategorySearch_Rename.Location = new System.Drawing.Point(3, 96);
            this.CB_CategorySearch_Rename.Name = "CB_CategorySearch_Rename";
            this.CB_CategorySearch_Rename.Size = new System.Drawing.Size(147, 25);
            this.CB_CategorySearch_Rename.TabIndex = 37;
            this.CB_CategorySearch_Rename.Visible = false;
            // 
            // L_InfoCatregorySearch_Rename
            // 
            this.L_InfoCatregorySearch_Rename.AutoSize = true;
            this.L_InfoCatregorySearch_Rename.Location = new System.Drawing.Point(0, 75);
            this.L_InfoCatregorySearch_Rename.Name = "L_InfoCatregorySearch_Rename";
            this.L_InfoCatregorySearch_Rename.Size = new System.Drawing.Size(59, 17);
            this.L_InfoCatregorySearch_Rename.TabIndex = 36;
            this.L_InfoCatregorySearch_Rename.Text = "Категория";
            this.L_InfoCatregorySearch_Rename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_InfoCatregorySearch_Rename.Visible = false;
            // 
            // PNL_Redact_Update
            // 
            this.PNL_Redact_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_Redact_Update.Controls.Add(this.B_AcceptChoice_Update);
            this.PNL_Redact_Update.Controls.Add(this.GB_SelectProduct_Update);
            this.PNL_Redact_Update.Controls.Add(this.L_NameCode_Update);
            this.PNL_Redact_Update.Controls.Add(this.TB_InputDataForSearch_Update);
            this.PNL_Redact_Update.Controls.Add(this.CB_CategorySearch_Update);
            this.PNL_Redact_Update.Controls.Add(this.L_InfoCatregorySearch_Update);
            this.PNL_Redact_Update.Controls.Add(this.GB_SearchType_Update);
            this.PNL_Redact_Update.Controls.Add(this.L_Info_RedactUpdate);
            this.PNL_Redact_Update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Redact_Update.Location = new System.Drawing.Point(3, 3);
            this.PNL_Redact_Update.Name = "PNL_Redact_Update";
            this.PNL_Redact_Update.Size = new System.Drawing.Size(312, 251);
            this.PNL_Redact_Update.TabIndex = 1;
            // 
            // B_AcceptChoice_Update
            // 
            this.B_AcceptChoice_Update.BackColor = System.Drawing.Color.SandyBrown;
            this.B_AcceptChoice_Update.Enabled = false;
            this.B_AcceptChoice_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_AcceptChoice_Update.Location = new System.Drawing.Point(159, 125);
            this.B_AcceptChoice_Update.Name = "B_AcceptChoice_Update";
            this.B_AcceptChoice_Update.Size = new System.Drawing.Size(148, 25);
            this.B_AcceptChoice_Update.TabIndex = 27;
            this.B_AcceptChoice_Update.Text = "Выбрать";
            this.B_AcceptChoice_Update.UseVisualStyleBackColor = false;
            this.B_AcceptChoice_Update.Click += new System.EventHandler(this.B_AcceptChoice_Update_Click);
            // 
            // GB_SelectProduct_Update
            // 
            this.GB_SelectProduct_Update.Controls.Add(this.B_RedactChoosenProduct);
            this.GB_SelectProduct_Update.Controls.Add(this.CB_Products_Update);
            this.GB_SelectProduct_Update.Location = new System.Drawing.Point(3, 146);
            this.GB_SelectProduct_Update.Name = "GB_SelectProduct_Update";
            this.GB_SelectProduct_Update.Size = new System.Drawing.Size(304, 104);
            this.GB_SelectProduct_Update.TabIndex = 36;
            this.GB_SelectProduct_Update.TabStop = false;
            this.GB_SelectProduct_Update.Tag = "0";
            this.GB_SelectProduct_Update.Text = "Выбрать Товар";
            // 
            // B_RedactChoosenProduct
            // 
            this.B_RedactChoosenProduct.BackColor = System.Drawing.Color.SandyBrown;
            this.B_RedactChoosenProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_RedactChoosenProduct.Location = new System.Drawing.Point(3, 70);
            this.B_RedactChoosenProduct.Name = "B_RedactChoosenProduct";
            this.B_RedactChoosenProduct.Size = new System.Drawing.Size(200, 25);
            this.B_RedactChoosenProduct.TabIndex = 37;
            this.B_RedactChoosenProduct.Text = "Редактировать данные товаров";
            this.B_RedactChoosenProduct.UseVisualStyleBackColor = false;
            this.B_RedactChoosenProduct.Click += new System.EventHandler(this.B_RedactChoosenProduct_Click);
            // 
            // CB_Products_Update
            // 
            this.CB_Products_Update.BackColor = System.Drawing.Color.PeachPuff;
            this.CB_Products_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Products_Update.FormattingEnabled = true;
            this.CB_Products_Update.Location = new System.Drawing.Point(3, 21);
            this.CB_Products_Update.Name = "CB_Products_Update";
            this.CB_Products_Update.Size = new System.Drawing.Size(200, 25);
            this.CB_Products_Update.TabIndex = 38;
            // 
            // L_NameCode_Update
            // 
            this.L_NameCode_Update.AutoSize = true;
            this.L_NameCode_Update.Location = new System.Drawing.Point(3, 30);
            this.L_NameCode_Update.Name = "L_NameCode_Update";
            this.L_NameCode_Update.Size = new System.Drawing.Size(27, 17);
            this.L_NameCode_Update.TabIndex = 35;
            this.L_NameCode_Update.Text = "Код";
            this.L_NameCode_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_InputDataForSearch_Update
            // 
            this.TB_InputDataForSearch_Update.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_InputDataForSearch_Update.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_InputDataForSearch_Update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_InputDataForSearch_Update.Location = new System.Drawing.Point(6, 50);
            this.TB_InputDataForSearch_Update.Name = "TB_InputDataForSearch_Update";
            this.TB_InputDataForSearch_Update.Size = new System.Drawing.Size(147, 22);
            this.TB_InputDataForSearch_Update.TabIndex = 34;
            // 
            // CB_CategorySearch_Update
            // 
            this.CB_CategorySearch_Update.BackColor = System.Drawing.Color.PeachPuff;
            this.CB_CategorySearch_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_CategorySearch_Update.FormattingEnabled = true;
            this.CB_CategorySearch_Update.Location = new System.Drawing.Point(6, 96);
            this.CB_CategorySearch_Update.Name = "CB_CategorySearch_Update";
            this.CB_CategorySearch_Update.Size = new System.Drawing.Size(147, 25);
            this.CB_CategorySearch_Update.TabIndex = 33;
            this.CB_CategorySearch_Update.Visible = false;
            // 
            // L_InfoCatregorySearch_Update
            // 
            this.L_InfoCatregorySearch_Update.AutoSize = true;
            this.L_InfoCatregorySearch_Update.Location = new System.Drawing.Point(3, 75);
            this.L_InfoCatregorySearch_Update.Name = "L_InfoCatregorySearch_Update";
            this.L_InfoCatregorySearch_Update.Size = new System.Drawing.Size(59, 17);
            this.L_InfoCatregorySearch_Update.TabIndex = 32;
            this.L_InfoCatregorySearch_Update.Text = "Категория";
            this.L_InfoCatregorySearch_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_InfoCatregorySearch_Update.Visible = false;
            // 
            // GB_SearchType_Update
            // 
            this.GB_SearchType_Update.Controls.Add(this.CHB_ProdUpdate_ByCode);
            this.GB_SearchType_Update.Controls.Add(this.CHB_ProdUpdate_ByName);
            this.GB_SearchType_Update.Controls.Add(this.CHB_ProdUpdate_ByCategory);
            this.GB_SearchType_Update.Location = new System.Drawing.Point(159, 21);
            this.GB_SearchType_Update.Name = "GB_SearchType_Update";
            this.GB_SearchType_Update.Size = new System.Drawing.Size(148, 100);
            this.GB_SearchType_Update.TabIndex = 31;
            this.GB_SearchType_Update.TabStop = false;
            this.GB_SearchType_Update.Tag = "0";
            this.GB_SearchType_Update.Text = "Тип Поиска";
            // 
            // CHB_ProdUpdate_ByCode
            // 
            this.CHB_ProdUpdate_ByCode.AutoSize = true;
            this.CHB_ProdUpdate_ByCode.Checked = true;
            this.CHB_ProdUpdate_ByCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHB_ProdUpdate_ByCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ProdUpdate_ByCode.Location = new System.Drawing.Point(6, 18);
            this.CHB_ProdUpdate_ByCode.Name = "CHB_ProdUpdate_ByCode";
            this.CHB_ProdUpdate_ByCode.Size = new System.Drawing.Size(93, 21);
            this.CHB_ProdUpdate_ByCode.TabIndex = 22;
            this.CHB_ProdUpdate_ByCode.Tag = "0";
            this.CHB_ProdUpdate_ByCode.Text = "Поиск по коду";
            this.CHB_ProdUpdate_ByCode.UseVisualStyleBackColor = true;
            this.CHB_ProdUpdate_ByCode.CheckedChanged += new System.EventHandler(this.CHB_ProdUpdate_ByCode_CheckedChanged);
            // 
            // CHB_ProdUpdate_ByName
            // 
            this.CHB_ProdUpdate_ByName.AutoSize = true;
            this.CHB_ProdUpdate_ByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ProdUpdate_ByName.Location = new System.Drawing.Point(6, 70);
            this.CHB_ProdUpdate_ByName.Name = "CHB_ProdUpdate_ByName";
            this.CHB_ProdUpdate_ByName.Size = new System.Drawing.Size(120, 21);
            this.CHB_ProdUpdate_ByName.TabIndex = 30;
            this.CHB_ProdUpdate_ByName.Tag = "2";
            this.CHB_ProdUpdate_ByName.Text = "Поиск по названию";
            this.CHB_ProdUpdate_ByName.UseVisualStyleBackColor = true;
            this.CHB_ProdUpdate_ByName.CheckedChanged += new System.EventHandler(this.CHB_ProdUpdate_ByName_CheckedChanged);
            // 
            // CHB_ProdUpdate_ByCategory
            // 
            this.CHB_ProdUpdate_ByCategory.AutoSize = true;
            this.CHB_ProdUpdate_ByCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ProdUpdate_ByCategory.Location = new System.Drawing.Point(6, 44);
            this.CHB_ProdUpdate_ByCategory.Name = "CHB_ProdUpdate_ByCategory";
            this.CHB_ProdUpdate_ByCategory.Size = new System.Drawing.Size(128, 21);
            this.CHB_ProdUpdate_ByCategory.TabIndex = 29;
            this.CHB_ProdUpdate_ByCategory.Tag = "1";
            this.CHB_ProdUpdate_ByCategory.Text = "Поиск по категориям";
            this.CHB_ProdUpdate_ByCategory.UseVisualStyleBackColor = true;
            this.CHB_ProdUpdate_ByCategory.CheckedChanged += new System.EventHandler(this.CHB_ProdUpdate_ByCategory_CheckedChanged);
            // 
            // L_Info_RedactUpdate
            // 
            this.L_Info_RedactUpdate.AutoSize = true;
            this.L_Info_RedactUpdate.Location = new System.Drawing.Point(70, 1);
            this.L_Info_RedactUpdate.Name = "L_Info_RedactUpdate";
            this.L_Info_RedactUpdate.Size = new System.Drawing.Size(131, 17);
            this.L_Info_RedactUpdate.TabIndex = 21;
            this.L_Info_RedactUpdate.Text = "Обнавить данные товара";
            this.L_Info_RedactUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PNL_Redact_Delete
            // 
            this.PNL_Redact_Delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_Redact_Delete.Controls.Add(this.B_AcceptChoice_Delete);
            this.PNL_Redact_Delete.Controls.Add(this.GB_SelectProduct_Delete);
            this.PNL_Redact_Delete.Controls.Add(this.L_NameCode_Delete);
            this.PNL_Redact_Delete.Controls.Add(this.TB_InputDataForSearch_Delete);
            this.PNL_Redact_Delete.Controls.Add(this.CB_CategorySearch_Delete);
            this.PNL_Redact_Delete.Controls.Add(this.L_InfoCatregorySearch_Delete);
            this.PNL_Redact_Delete.Controls.Add(this.GB_SearchType_Delete);
            this.PNL_Redact_Delete.Controls.Add(this.L_Info_RedactDelete);
            this.PNL_Redact_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Redact_Delete.Location = new System.Drawing.Point(649, 3);
            this.PNL_Redact_Delete.Name = "PNL_Redact_Delete";
            this.PNL_Redact_Delete.Size = new System.Drawing.Size(314, 251);
            this.PNL_Redact_Delete.TabIndex = 0;
            // 
            // B_AcceptChoice_Delete
            // 
            this.B_AcceptChoice_Delete.BackColor = System.Drawing.Color.SandyBrown;
            this.B_AcceptChoice_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_AcceptChoice_Delete.Location = new System.Drawing.Point(169, 124);
            this.B_AcceptChoice_Delete.Name = "B_AcceptChoice_Delete";
            this.B_AcceptChoice_Delete.Size = new System.Drawing.Size(132, 25);
            this.B_AcceptChoice_Delete.TabIndex = 42;
            this.B_AcceptChoice_Delete.Text = "Выбрать";
            this.B_AcceptChoice_Delete.UseVisualStyleBackColor = false;
            this.B_AcceptChoice_Delete.Click += new System.EventHandler(this.B_AcceptChoice_Delete_Click);
            // 
            // GB_SelectProduct_Delete
            // 
            this.GB_SelectProduct_Delete.Controls.Add(this.CHB_SelectAll_Delete);
            this.GB_SelectProduct_Delete.Controls.Add(this.B_ProductDelete);
            this.GB_SelectProduct_Delete.Controls.Add(this.CB_Products_Delete);
            this.GB_SelectProduct_Delete.Location = new System.Drawing.Point(3, 146);
            this.GB_SelectProduct_Delete.Name = "GB_SelectProduct_Delete";
            this.GB_SelectProduct_Delete.Size = new System.Drawing.Size(304, 100);
            this.GB_SelectProduct_Delete.TabIndex = 40;
            this.GB_SelectProduct_Delete.TabStop = false;
            this.GB_SelectProduct_Delete.Tag = "0";
            this.GB_SelectProduct_Delete.Text = "Выбрать Товар";
            // 
            // CHB_SelectAll_Delete
            // 
            this.CHB_SelectAll_Delete.AutoSize = true;
            this.CHB_SelectAll_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_SelectAll_Delete.Location = new System.Drawing.Point(168, 19);
            this.CHB_SelectAll_Delete.Name = "CHB_SelectAll_Delete";
            this.CHB_SelectAll_Delete.Size = new System.Drawing.Size(82, 21);
            this.CHB_SelectAll_Delete.TabIndex = 31;
            this.CHB_SelectAll_Delete.Tag = "2";
            this.CHB_SelectAll_Delete.Text = "Удалить все";
            this.CHB_SelectAll_Delete.UseVisualStyleBackColor = true;
            this.CHB_SelectAll_Delete.CheckedChanged += new System.EventHandler(this.CHB_SelectAll_Delete_CheckedChanged);
            // 
            // B_ProductDelete
            // 
            this.B_ProductDelete.BackColor = System.Drawing.Color.SandyBrown;
            this.B_ProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ProductDelete.Location = new System.Drawing.Point(166, 73);
            this.B_ProductDelete.Name = "B_ProductDelete";
            this.B_ProductDelete.Size = new System.Drawing.Size(132, 25);
            this.B_ProductDelete.TabIndex = 43;
            this.B_ProductDelete.Text = "Удалить товар";
            this.B_ProductDelete.UseVisualStyleBackColor = false;
            // 
            // CB_Products_Delete
            // 
            this.CB_Products_Delete.BackColor = System.Drawing.Color.PeachPuff;
            this.CB_Products_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_Products_Delete.FormattingEnabled = true;
            this.CB_Products_Delete.Location = new System.Drawing.Point(3, 20);
            this.CB_Products_Delete.Name = "CB_Products_Delete";
            this.CB_Products_Delete.Size = new System.Drawing.Size(145, 25);
            this.CB_Products_Delete.TabIndex = 40;
            // 
            // L_NameCode_Delete
            // 
            this.L_NameCode_Delete.AutoSize = true;
            this.L_NameCode_Delete.Location = new System.Drawing.Point(0, 31);
            this.L_NameCode_Delete.Name = "L_NameCode_Delete";
            this.L_NameCode_Delete.Size = new System.Drawing.Size(27, 17);
            this.L_NameCode_Delete.TabIndex = 39;
            this.L_NameCode_Delete.Text = "Код";
            this.L_NameCode_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_InputDataForSearch_Delete
            // 
            this.TB_InputDataForSearch_Delete.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_InputDataForSearch_Delete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_InputDataForSearch_Delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_InputDataForSearch_Delete.Location = new System.Drawing.Point(3, 51);
            this.TB_InputDataForSearch_Delete.Name = "TB_InputDataForSearch_Delete";
            this.TB_InputDataForSearch_Delete.Size = new System.Drawing.Size(147, 22);
            this.TB_InputDataForSearch_Delete.TabIndex = 38;
            // 
            // CB_CategorySearch_Delete
            // 
            this.CB_CategorySearch_Delete.BackColor = System.Drawing.Color.PeachPuff;
            this.CB_CategorySearch_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_CategorySearch_Delete.FormattingEnabled = true;
            this.CB_CategorySearch_Delete.Location = new System.Drawing.Point(3, 97);
            this.CB_CategorySearch_Delete.Name = "CB_CategorySearch_Delete";
            this.CB_CategorySearch_Delete.Size = new System.Drawing.Size(147, 25);
            this.CB_CategorySearch_Delete.TabIndex = 37;
            this.CB_CategorySearch_Delete.Visible = false;
            // 
            // L_InfoCatregorySearch_Delete
            // 
            this.L_InfoCatregorySearch_Delete.AutoSize = true;
            this.L_InfoCatregorySearch_Delete.Location = new System.Drawing.Point(0, 76);
            this.L_InfoCatregorySearch_Delete.Name = "L_InfoCatregorySearch_Delete";
            this.L_InfoCatregorySearch_Delete.Size = new System.Drawing.Size(59, 17);
            this.L_InfoCatregorySearch_Delete.TabIndex = 36;
            this.L_InfoCatregorySearch_Delete.Text = "Категория";
            this.L_InfoCatregorySearch_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_InfoCatregorySearch_Delete.Visible = false;
            // 
            // GB_SearchType_Delete
            // 
            this.GB_SearchType_Delete.Controls.Add(this.CHB_ProdDelete_ByCode);
            this.GB_SearchType_Delete.Controls.Add(this.CHB_ProdDelete_ByName);
            this.GB_SearchType_Delete.Controls.Add(this.CHB_ProdDelete_ByCategory);
            this.GB_SearchType_Delete.Location = new System.Drawing.Point(165, 21);
            this.GB_SearchType_Delete.Name = "GB_SearchType_Delete";
            this.GB_SearchType_Delete.Size = new System.Drawing.Size(142, 100);
            this.GB_SearchType_Delete.TabIndex = 33;
            this.GB_SearchType_Delete.TabStop = false;
            this.GB_SearchType_Delete.Tag = "2";
            this.GB_SearchType_Delete.Text = "Тип Поиска";
            // 
            // CHB_ProdDelete_ByCode
            // 
            this.CHB_ProdDelete_ByCode.AutoSize = true;
            this.CHB_ProdDelete_ByCode.Checked = true;
            this.CHB_ProdDelete_ByCode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CHB_ProdDelete_ByCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ProdDelete_ByCode.Location = new System.Drawing.Point(6, 18);
            this.CHB_ProdDelete_ByCode.Name = "CHB_ProdDelete_ByCode";
            this.CHB_ProdDelete_ByCode.Size = new System.Drawing.Size(93, 21);
            this.CHB_ProdDelete_ByCode.TabIndex = 22;
            this.CHB_ProdDelete_ByCode.Tag = "0";
            this.CHB_ProdDelete_ByCode.Text = "Поиск по коду";
            this.CHB_ProdDelete_ByCode.UseVisualStyleBackColor = true;
            this.CHB_ProdDelete_ByCode.CheckedChanged += new System.EventHandler(this.CHB_ProdDelete_ByCode_CheckedChanged);
            // 
            // CHB_ProdDelete_ByName
            // 
            this.CHB_ProdDelete_ByName.AutoSize = true;
            this.CHB_ProdDelete_ByName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ProdDelete_ByName.Location = new System.Drawing.Point(6, 70);
            this.CHB_ProdDelete_ByName.Name = "CHB_ProdDelete_ByName";
            this.CHB_ProdDelete_ByName.Size = new System.Drawing.Size(120, 21);
            this.CHB_ProdDelete_ByName.TabIndex = 30;
            this.CHB_ProdDelete_ByName.Tag = "2";
            this.CHB_ProdDelete_ByName.Text = "Поиск по названию";
            this.CHB_ProdDelete_ByName.UseVisualStyleBackColor = true;
            this.CHB_ProdDelete_ByName.CheckedChanged += new System.EventHandler(this.CHB_ProdDelete_ByName_CheckedChanged);
            // 
            // CHB_ProdDelete_ByCategory
            // 
            this.CHB_ProdDelete_ByCategory.AutoSize = true;
            this.CHB_ProdDelete_ByCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ProdDelete_ByCategory.Location = new System.Drawing.Point(6, 44);
            this.CHB_ProdDelete_ByCategory.Name = "CHB_ProdDelete_ByCategory";
            this.CHB_ProdDelete_ByCategory.Size = new System.Drawing.Size(128, 21);
            this.CHB_ProdDelete_ByCategory.TabIndex = 29;
            this.CHB_ProdDelete_ByCategory.Tag = "1";
            this.CHB_ProdDelete_ByCategory.Text = "Поиск по категориям";
            this.CHB_ProdDelete_ByCategory.UseVisualStyleBackColor = true;
            this.CHB_ProdDelete_ByCategory.CheckedChanged += new System.EventHandler(this.CHB_ProdDelete_ByCategory_CheckedChanged);
            // 
            // L_Info_RedactDelete
            // 
            this.L_Info_RedactDelete.AutoSize = true;
            this.L_Info_RedactDelete.Location = new System.Drawing.Point(127, 1);
            this.L_Info_RedactDelete.Name = "L_Info_RedactDelete";
            this.L_Info_RedactDelete.Size = new System.Drawing.Size(77, 17);
            this.L_Info_RedactDelete.TabIndex = 23;
            this.L_Info_RedactDelete.Text = "Удалить товар";
            this.L_Info_RedactDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // B_DEBUG_ADDCATEGORY
            // 
            this.B_DEBUG_ADDCATEGORY.BackColor = System.Drawing.Color.OrangeRed;
            this.B_DEBUG_ADDCATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_DEBUG_ADDCATEGORY.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B_DEBUG_ADDCATEGORY.Location = new System.Drawing.Point(22, 682);
            this.B_DEBUG_ADDCATEGORY.Name = "B_DEBUG_ADDCATEGORY";
            this.B_DEBUG_ADDCATEGORY.Size = new System.Drawing.Size(202, 25);
            this.B_DEBUG_ADDCATEGORY.TabIndex = 35;
            this.B_DEBUG_ADDCATEGORY.Text = "ОТКЛАДКА: ДОБАВИТЬ КАТЕГОРИЮ";
            this.B_DEBUG_ADDCATEGORY.UseVisualStyleBackColor = false;
            this.B_DEBUG_ADDCATEGORY.Click += new System.EventHandler(this.B_DEBUG_ADDCATEGORY_Click);
            // 
            // B_DEBUG_ADDPRODUCT
            // 
            this.B_DEBUG_ADDPRODUCT.BackColor = System.Drawing.Color.OrangeRed;
            this.B_DEBUG_ADDPRODUCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_DEBUG_ADDPRODUCT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.B_DEBUG_ADDPRODUCT.Location = new System.Drawing.Point(22, 651);
            this.B_DEBUG_ADDPRODUCT.Name = "B_DEBUG_ADDPRODUCT";
            this.B_DEBUG_ADDPRODUCT.Size = new System.Drawing.Size(202, 25);
            this.B_DEBUG_ADDPRODUCT.TabIndex = 36;
            this.B_DEBUG_ADDPRODUCT.Text = "ОТКЛАДКА: ДОБАВИТЬ ПРОДУКТ";
            this.B_DEBUG_ADDPRODUCT.UseVisualStyleBackColor = false;
            this.B_DEBUG_ADDPRODUCT.Click += new System.EventHandler(this.B_DEBUG_ADDPRODUCT_Click);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1366, 749);
            this.Controls.Add(this.B_DEBUG_ADDCATEGORY);
            this.Controls.Add(this.B_DEBUG_ADDPRODUCT);
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
            this.PNL_CodeSelector.ResumeLayout(false);
            this.TLP_ProdusctsRedact.ResumeLayout(false);
            this.CHB_ProdRename_Code.ResumeLayout(false);
            this.CHB_ProdRename_Code.PerformLayout();
            this.GB_SelectProduct_Rename.ResumeLayout(false);
            this.GB_SelectProduct_Rename.PerformLayout();
            this.GB_SearchType_Rename.ResumeLayout(false);
            this.GB_SearchType_Rename.PerformLayout();
            this.PNL_Redact_Update.ResumeLayout(false);
            this.PNL_Redact_Update.PerformLayout();
            this.GB_SelectProduct_Update.ResumeLayout(false);
            this.GB_SearchType_Update.ResumeLayout(false);
            this.GB_SearchType_Update.PerformLayout();
            this.PNL_Redact_Delete.ResumeLayout(false);
            this.PNL_Redact_Delete.PerformLayout();
            this.GB_SelectProduct_Delete.ResumeLayout(false);
            this.GB_SelectProduct_Delete.PerformLayout();
            this.GB_SearchType_Delete.ResumeLayout(false);
            this.GB_SearchType_Delete.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem TSMI_Category;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Category_Add;
        private System.Windows.Forms.Panel PNL_GridView;
        private System.Windows.Forms.PictureBox PB_LogoMain;
        private System.Windows.Forms.Panel PNL_DataOperation;
        private System.Windows.Forms.ToolStripMenuItem TSMI_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TopMost;
        public System.Windows.Forms.DataGridView DGV_MS_Product;
        private System.Windows.Forms.Panel PNL_CodeSelector;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Datas;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Synchronize;
        private System.Windows.Forms.Label L_Info_ProductName;
        private System.Windows.Forms.TextBox TB_ProductName;
        private System.Windows.Forms.Button B_ProductName_Check;
        private System.Windows.Forms.Button B_GetCategoryData;
        private System.Windows.Forms.Label L_Info_Product_Category;
        private System.Windows.Forms.Button B_SelectCategory;
        private System.Windows.Forms.ComboBox CB_GetCategories;
        public System.Windows.Forms.Label L_Info_Product_Price;
        private System.Windows.Forms.Button B_ApplyCount;
        private System.Windows.Forms.Button B_ApplyPrice;
        private System.Windows.Forms.Label L_Info_AddProduct;
        private System.Windows.Forms.Button B_GenerateUniqueID;
        private System.Windows.Forms.Label L_Info_GenerateUniqueID;
        private System.Windows.Forms.Button B_ApplyData;
        private System.Windows.Forms.Label L_Info_UniqueID;
        private System.Windows.Forms.TextBox TB_UniqueCode;
        private System.Windows.Forms.TableLayoutPanel TLP_ProdusctsRedact;
        private System.Windows.Forms.Panel CHB_ProdRename_Code;
        private System.Windows.Forms.Panel PNL_Redact_Update;
        private System.Windows.Forms.Panel PNL_Redact_Delete;
        private System.Windows.Forms.Label L_Info_RedactRename;
        private System.Windows.Forms.Label L_Info_RedactUpdate;
        private System.Windows.Forms.Label L_Info_RedactDelete;
        private BSDBDataSet bSDBDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private BSDBDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn изменениеDataGridViewTextBoxColumn;
        public System.Windows.Forms.CheckBox CHB_ProdUpdate_ByName;
        public System.Windows.Forms.CheckBox CHB_ProdUpdate_ByCode;
        public System.Windows.Forms.CheckBox CHB_ProdUpdate_ByCategory;
        public System.Windows.Forms.GroupBox GB_SearchType_Update;
        public System.Windows.Forms.GroupBox GB_SearchType_Rename;
        public System.Windows.Forms.CheckBox CHB_ProdRename_ByCode;
        public System.Windows.Forms.CheckBox CHB_ProdRename_ByName;
        public System.Windows.Forms.CheckBox CHB_ProdRename_ByCategory;
        public System.Windows.Forms.GroupBox GB_SearchType_Delete;
        public System.Windows.Forms.CheckBox CHB_ProdDelete_ByCode;
        public System.Windows.Forms.CheckBox CHB_ProdDelete_ByName;
        public System.Windows.Forms.CheckBox CHB_ProdDelete_ByCategory;
        private System.Windows.Forms.ComboBox CB_CategorySearch_Update;
        private System.Windows.Forms.Label L_InfoCatregorySearch_Update;
        private System.Windows.Forms.Label L_NameCode_Update;
        private System.Windows.Forms.TextBox TB_InputDataForSearch_Update;
        private System.Windows.Forms.Label L_NameCode_Rename;
        private System.Windows.Forms.TextBox TB_InputDataForSearch_Rename;
        private System.Windows.Forms.ComboBox CB_CategorySearch_Rename;
        private System.Windows.Forms.Label L_InfoCatregorySearch_Rename;
        private System.Windows.Forms.Label L_NameCode_Delete;
        private System.Windows.Forms.TextBox TB_InputDataForSearch_Delete;
        private System.Windows.Forms.ComboBox CB_CategorySearch_Delete;
        private System.Windows.Forms.Label L_InfoCatregorySearch_Delete;
        private System.Windows.Forms.Button B_AcceptChoice_Update;
        public System.Windows.Forms.GroupBox GB_SelectProduct_Update;
        private System.Windows.Forms.Button B_RedactChoosenProduct;
        private System.Windows.Forms.ComboBox CB_Products_Update;
        private System.Windows.Forms.Button B_AcceptChoice_Rename;
        public System.Windows.Forms.GroupBox GB_SelectProduct_Rename;
        private System.Windows.Forms.Label L_Info_Product_NewName;
        private System.Windows.Forms.Button B_RenameProduct;
        private System.Windows.Forms.TextBox TB_NewName_Rename;
        private System.Windows.Forms.Button B_CheckNewName;
        private System.Windows.Forms.ComboBox CB_Products_Rename;
        public System.Windows.Forms.GroupBox GB_SelectProduct_Delete;
        private System.Windows.Forms.ComboBox CB_Products_Delete;
        private System.Windows.Forms.Button B_ProductDelete;
        public System.Windows.Forms.CheckBox CHB_SelectAll_Delete;
        private System.Windows.Forms.Button B_AcceptChoice_Delete;
        public System.Windows.Forms.Label L_Info_Product_Count;
        private System.Windows.Forms.NumericUpDown NUD_Count;
        private System.Windows.Forms.NumericUpDown NUD_Price;
        public System.Windows.Forms.CheckBox CHB_CountOver1000;
        public System.Windows.Forms.CheckBox CHB_CountOver100;
        public System.Windows.Forms.CheckBox CHB_PriceOver1000;
        public System.Windows.Forms.CheckBox CHB_PriceOver100;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Update_DGV;
        private System.Windows.Forms.Button B_DEBUG_ADDPRODUCT;
        private System.Windows.Forms.Button B_DEBUG_ADDCATEGORY;
        private System.Windows.Forms.Button B_UpdatePanel;
        public System.Windows.Forms.CheckBox CHB_SelectAll_Rename;
    }
}