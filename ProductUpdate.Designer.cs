namespace Bookshop
{
    partial class ProductUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUpdate));
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.TSMI_PU_File = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PU_TopMost = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PU_ConnectionData = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PU_Connection = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PU_Connection_OpenClose = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PU_ConnectionStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PU_DataTools = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_PU_Synchronize = new System.Windows.Forms.ToolStripMenuItem();
            this.SC_ProductUpdate = new System.Windows.Forms.SplitContainer();
            this.TLP_NewOldData = new System.Windows.Forms.TableLayoutPanel();
            this.PNL_NewData = new System.Windows.Forms.Panel();
            this.B_OverwriteData = new System.Windows.Forms.Button();
            this.B_ResetChanges = new System.Windows.Forms.Button();
            this.B_ApplyChanges = new System.Windows.Forms.Button();
            this.CHB_ChangePrice = new System.Windows.Forms.CheckBox();
            this.CHB_ChangeCount = new System.Windows.Forms.CheckBox();
            this.CHB_ChangeCategory = new System.Windows.Forms.CheckBox();
            this.CHB_ChangeName = new System.Windows.Forms.CheckBox();
            this.NUD_New_ProductPrice = new System.Windows.Forms.NumericUpDown();
            this.NUD_New_ProductCount = new System.Windows.Forms.NumericUpDown();
            this.CB_New_ProductCategory = new System.Windows.Forms.ComboBox();
            this.TB_New_ProductName = new System.Windows.Forms.TextBox();
            this.L_New_ProductName = new System.Windows.Forms.Label();
            this.L_New_ProductCategory = new System.Windows.Forms.Label();
            this.L_New_ProductCount = new System.Windows.Forms.Label();
            this.L_New_ProductPrice = new System.Windows.Forms.Label();
            this.PNL_OldData = new System.Windows.Forms.Panel();
            this.L_Old_ProductDate = new System.Windows.Forms.Label();
            this.TB_Old_ProductDate = new System.Windows.Forms.TextBox();
            this.L_Old_ProductCode = new System.Windows.Forms.Label();
            this.TB_Old_ProductCode = new System.Windows.Forms.TextBox();
            this.TB_Old_ProductCategory = new System.Windows.Forms.TextBox();
            this.L_Old_ProductPrice = new System.Windows.Forms.Label();
            this.TB_Old_ProductPrice = new System.Windows.Forms.TextBox();
            this.L_Old_ProductCount = new System.Windows.Forms.Label();
            this.TB_Old_ProductCount = new System.Windows.Forms.TextBox();
            this.L_Old_ProductCategory = new System.Windows.Forms.Label();
            this.L_Old_ProductName = new System.Windows.Forms.Label();
            this.TB_Old_ProductName = new System.Windows.Forms.TextBox();
            this.PNL_Operations = new System.Windows.Forms.Panel();
            this.SC_TimeDelete = new System.Windows.Forms.SplitContainer();
            this.PNL_Delete = new System.Windows.Forms.Panel();
            this.PNL_Time = new System.Windows.Forms.Panel();
            this.L_Timer = new System.Windows.Forms.Label();
            this.Timer_ForLable = new System.Windows.Forms.Timer(this.components);
            this.MS_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SC_ProductUpdate)).BeginInit();
            this.SC_ProductUpdate.Panel1.SuspendLayout();
            this.SC_ProductUpdate.Panel2.SuspendLayout();
            this.SC_ProductUpdate.SuspendLayout();
            this.TLP_NewOldData.SuspendLayout();
            this.PNL_NewData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_New_ProductPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_New_ProductCount)).BeginInit();
            this.PNL_OldData.SuspendLayout();
            this.PNL_Operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SC_TimeDelete)).BeginInit();
            this.SC_TimeDelete.Panel1.SuspendLayout();
            this.SC_TimeDelete.Panel2.SuspendLayout();
            this.SC_TimeDelete.SuspendLayout();
            this.PNL_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Main
            // 
            this.MS_Main.BackColor = System.Drawing.Color.SandyBrown;
            this.MS_Main.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MS_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_PU_File,
            this.TSMI_PU_ConnectionData,
            this.TSMI_PU_DataTools});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(715, 25);
            this.MS_Main.TabIndex = 1;
            this.MS_Main.Text = "menuStrip1";
            // 
            // TSMI_PU_File
            // 
            this.TSMI_PU_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_PU_TopMost});
            this.TSMI_PU_File.Name = "TSMI_PU_File";
            this.TSMI_PU_File.Size = new System.Drawing.Size(45, 21);
            this.TSMI_PU_File.Text = "Файл";
            // 
            // TSMI_PU_TopMost
            // 
            this.TSMI_PU_TopMost.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_PU_TopMost.CheckOnClick = true;
            this.TSMI_PU_TopMost.Name = "TSMI_PU_TopMost";
            this.TSMI_PU_TopMost.Size = new System.Drawing.Size(172, 22);
            this.TSMI_PU_TopMost.Text = "Поверх других окон";
            this.TSMI_PU_TopMost.Click += new System.EventHandler(this.TSMI_PU_TopMost_Click);
            // 
            // TSMI_PU_ConnectionData
            // 
            this.TSMI_PU_ConnectionData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_PU_Connection});
            this.TSMI_PU_ConnectionData.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TSMI_PU_ConnectionData.Name = "TSMI_PU_ConnectionData";
            this.TSMI_PU_ConnectionData.Size = new System.Drawing.Size(129, 21);
            this.TSMI_PU_ConnectionData.Text = "Данные подключения";
            // 
            // TSMI_PU_Connection
            // 
            this.TSMI_PU_Connection.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_PU_Connection.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_PU_Connection_OpenClose,
            this.TSMI_PU_ConnectionStatus});
            this.TSMI_PU_Connection.Name = "TSMI_PU_Connection";
            this.TSMI_PU_Connection.Size = new System.Drawing.Size(137, 22);
            this.TSMI_PU_Connection.Text = "Соеденение";
            // 
            // TSMI_PU_Connection_OpenClose
            // 
            this.TSMI_PU_Connection_OpenClose.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_PU_Connection_OpenClose.CheckOnClick = true;
            this.TSMI_PU_Connection_OpenClose.Name = "TSMI_PU_Connection_OpenClose";
            this.TSMI_PU_Connection_OpenClose.Size = new System.Drawing.Size(192, 22);
            this.TSMI_PU_Connection_OpenClose.Text = "Установить соединение";
            // 
            // TSMI_PU_ConnectionStatus
            // 
            this.TSMI_PU_ConnectionStatus.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_PU_ConnectionStatus.Name = "TSMI_PU_ConnectionStatus";
            this.TSMI_PU_ConnectionStatus.Size = new System.Drawing.Size(192, 22);
            this.TSMI_PU_ConnectionStatus.Text = "Статус";
            // 
            // TSMI_PU_DataTools
            // 
            this.TSMI_PU_DataTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_PU_Synchronize});
            this.TSMI_PU_DataTools.Name = "TSMI_PU_DataTools";
            this.TSMI_PU_DataTools.Size = new System.Drawing.Size(133, 21);
            this.TSMI_PU_DataTools.Text = "Данные и инструменты";
            // 
            // TSMI_PU_Synchronize
            // 
            this.TSMI_PU_Synchronize.BackColor = System.Drawing.Color.SandyBrown;
            this.TSMI_PU_Synchronize.Name = "TSMI_PU_Synchronize";
            this.TSMI_PU_Synchronize.Size = new System.Drawing.Size(180, 22);
            this.TSMI_PU_Synchronize.Text = "Синхронизировать";
            this.TSMI_PU_Synchronize.Click += new System.EventHandler(this.TSMI_PU_Synchronize_Click);
            // 
            // SC_ProductUpdate
            // 
            this.SC_ProductUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC_ProductUpdate.Location = new System.Drawing.Point(0, 25);
            this.SC_ProductUpdate.Name = "SC_ProductUpdate";
            // 
            // SC_ProductUpdate.Panel1
            // 
            this.SC_ProductUpdate.Panel1.Controls.Add(this.TLP_NewOldData);
            // 
            // SC_ProductUpdate.Panel2
            // 
            this.SC_ProductUpdate.Panel2.Controls.Add(this.PNL_Operations);
            this.SC_ProductUpdate.Size = new System.Drawing.Size(715, 351);
            this.SC_ProductUpdate.SplitterDistance = 464;
            this.SC_ProductUpdate.TabIndex = 2;
            // 
            // TLP_NewOldData
            // 
            this.TLP_NewOldData.ColumnCount = 1;
            this.TLP_NewOldData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_NewOldData.Controls.Add(this.PNL_NewData, 0, 1);
            this.TLP_NewOldData.Controls.Add(this.PNL_OldData, 0, 0);
            this.TLP_NewOldData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_NewOldData.Location = new System.Drawing.Point(0, 0);
            this.TLP_NewOldData.Name = "TLP_NewOldData";
            this.TLP_NewOldData.RowCount = 2;
            this.TLP_NewOldData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_NewOldData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_NewOldData.Size = new System.Drawing.Size(464, 351);
            this.TLP_NewOldData.TabIndex = 0;
            // 
            // PNL_NewData
            // 
            this.PNL_NewData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.PNL_NewData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_NewData.Controls.Add(this.B_OverwriteData);
            this.PNL_NewData.Controls.Add(this.B_ResetChanges);
            this.PNL_NewData.Controls.Add(this.B_ApplyChanges);
            this.PNL_NewData.Controls.Add(this.CHB_ChangePrice);
            this.PNL_NewData.Controls.Add(this.CHB_ChangeCount);
            this.PNL_NewData.Controls.Add(this.CHB_ChangeCategory);
            this.PNL_NewData.Controls.Add(this.CHB_ChangeName);
            this.PNL_NewData.Controls.Add(this.NUD_New_ProductPrice);
            this.PNL_NewData.Controls.Add(this.NUD_New_ProductCount);
            this.PNL_NewData.Controls.Add(this.CB_New_ProductCategory);
            this.PNL_NewData.Controls.Add(this.TB_New_ProductName);
            this.PNL_NewData.Controls.Add(this.L_New_ProductName);
            this.PNL_NewData.Controls.Add(this.L_New_ProductCategory);
            this.PNL_NewData.Controls.Add(this.L_New_ProductCount);
            this.PNL_NewData.Controls.Add(this.L_New_ProductPrice);
            this.PNL_NewData.Cursor = System.Windows.Forms.Cursors.Default;
            this.PNL_NewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_NewData.Location = new System.Drawing.Point(3, 178);
            this.PNL_NewData.Name = "PNL_NewData";
            this.PNL_NewData.Size = new System.Drawing.Size(458, 170);
            this.PNL_NewData.TabIndex = 1;
            // 
            // B_OverwriteData
            // 
            this.B_OverwriteData.BackColor = System.Drawing.Color.SandyBrown;
            this.B_OverwriteData.Enabled = false;
            this.B_OverwriteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_OverwriteData.Location = new System.Drawing.Point(245, 126);
            this.B_OverwriteData.Name = "B_OverwriteData";
            this.B_OverwriteData.Size = new System.Drawing.Size(200, 26);
            this.B_OverwriteData.TabIndex = 38;
            this.B_OverwriteData.Text = "Перезаписать данные";
            this.B_OverwriteData.UseVisualStyleBackColor = false;
            this.B_OverwriteData.Click += new System.EventHandler(this.B_OverwriteData_Click);
            // 
            // B_ResetChanges
            // 
            this.B_ResetChanges.BackColor = System.Drawing.Color.SandyBrown;
            this.B_ResetChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ResetChanges.Location = new System.Drawing.Point(245, 89);
            this.B_ResetChanges.Name = "B_ResetChanges";
            this.B_ResetChanges.Size = new System.Drawing.Size(200, 26);
            this.B_ResetChanges.TabIndex = 37;
            this.B_ResetChanges.Text = "Сбростиь изменения";
            this.B_ResetChanges.UseVisualStyleBackColor = false;
            this.B_ResetChanges.Click += new System.EventHandler(this.B_ResetChanges_Click);
            // 
            // B_ApplyChanges
            // 
            this.B_ApplyChanges.BackColor = System.Drawing.Color.SandyBrown;
            this.B_ApplyChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_ApplyChanges.Location = new System.Drawing.Point(245, 52);
            this.B_ApplyChanges.Name = "B_ApplyChanges";
            this.B_ApplyChanges.Size = new System.Drawing.Size(200, 26);
            this.B_ApplyChanges.TabIndex = 36;
            this.B_ApplyChanges.Text = "Принять изменения";
            this.B_ApplyChanges.UseVisualStyleBackColor = false;
            this.B_ApplyChanges.Click += new System.EventHandler(this.B_ApplyChanges_Click);
            // 
            // CHB_ChangePrice
            // 
            this.CHB_ChangePrice.AutoSize = true;
            this.CHB_ChangePrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ChangePrice.Location = new System.Drawing.Point(373, 4);
            this.CHB_ChangePrice.Name = "CHB_ChangePrice";
            this.CHB_ChangePrice.Size = new System.Drawing.Size(72, 21);
            this.CHB_ChangePrice.TabIndex = 35;
            this.CHB_ChangePrice.Tag = "1";
            this.CHB_ChangePrice.Text = "Изменить";
            this.CHB_ChangePrice.UseVisualStyleBackColor = true;
            this.CHB_ChangePrice.CheckedChanged += new System.EventHandler(this.CHB_ChangePrice_CheckedChanged);
            // 
            // CHB_ChangeCount
            // 
            this.CHB_ChangeCount.AutoSize = true;
            this.CHB_ChangeCount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ChangeCount.Location = new System.Drawing.Point(138, 108);
            this.CHB_ChangeCount.Name = "CHB_ChangeCount";
            this.CHB_ChangeCount.Size = new System.Drawing.Size(72, 21);
            this.CHB_ChangeCount.TabIndex = 34;
            this.CHB_ChangeCount.Tag = "1";
            this.CHB_ChangeCount.Text = "Изменить";
            this.CHB_ChangeCount.UseVisualStyleBackColor = true;
            this.CHB_ChangeCount.CheckedChanged += new System.EventHandler(this.CHB_ChangeCount_CheckedChanged);
            // 
            // CHB_ChangeCategory
            // 
            this.CHB_ChangeCategory.AutoSize = true;
            this.CHB_ChangeCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ChangeCategory.Location = new System.Drawing.Point(138, 54);
            this.CHB_ChangeCategory.Name = "CHB_ChangeCategory";
            this.CHB_ChangeCategory.Size = new System.Drawing.Size(72, 21);
            this.CHB_ChangeCategory.TabIndex = 33;
            this.CHB_ChangeCategory.Tag = "1";
            this.CHB_ChangeCategory.Text = "Изменить";
            this.CHB_ChangeCategory.UseVisualStyleBackColor = true;
            this.CHB_ChangeCategory.CheckedChanged += new System.EventHandler(this.CHB_ChangeCategory_CheckedChanged);
            // 
            // CHB_ChangeName
            // 
            this.CHB_ChangeName.AutoSize = true;
            this.CHB_ChangeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CHB_ChangeName.Location = new System.Drawing.Point(136, 5);
            this.CHB_ChangeName.Name = "CHB_ChangeName";
            this.CHB_ChangeName.Size = new System.Drawing.Size(72, 21);
            this.CHB_ChangeName.TabIndex = 32;
            this.CHB_ChangeName.Tag = "1";
            this.CHB_ChangeName.Text = "Изменить";
            this.CHB_ChangeName.UseVisualStyleBackColor = true;
            this.CHB_ChangeName.CheckedChanged += new System.EventHandler(this.CHB_ChangeName_CheckedChanged);
            // 
            // NUD_New_ProductPrice
            // 
            this.NUD_New_ProductPrice.BackColor = System.Drawing.Color.PeachPuff;
            this.NUD_New_ProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_New_ProductPrice.Location = new System.Drawing.Point(245, 26);
            this.NUD_New_ProductPrice.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_New_ProductPrice.Name = "NUD_New_ProductPrice";
            this.NUD_New_ProductPrice.Size = new System.Drawing.Size(200, 22);
            this.NUD_New_ProductPrice.TabIndex = 28;
            this.NUD_New_ProductPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NUD_New_ProductCount
            // 
            this.NUD_New_ProductCount.BackColor = System.Drawing.Color.PeachPuff;
            this.NUD_New_ProductCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NUD_New_ProductCount.Location = new System.Drawing.Point(8, 130);
            this.NUD_New_ProductCount.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.NUD_New_ProductCount.Name = "NUD_New_ProductCount";
            this.NUD_New_ProductCount.Size = new System.Drawing.Size(202, 22);
            this.NUD_New_ProductCount.TabIndex = 27;
            this.NUD_New_ProductCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CB_New_ProductCategory
            // 
            this.CB_New_ProductCategory.BackColor = System.Drawing.Color.PeachPuff;
            this.CB_New_ProductCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CB_New_ProductCategory.FormattingEnabled = true;
            this.CB_New_ProductCategory.Location = new System.Drawing.Point(8, 78);
            this.CB_New_ProductCategory.Name = "CB_New_ProductCategory";
            this.CB_New_ProductCategory.Size = new System.Drawing.Size(200, 25);
            this.CB_New_ProductCategory.TabIndex = 26;
            // 
            // TB_New_ProductName
            // 
            this.TB_New_ProductName.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_New_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_New_ProductName.Cursor = System.Windows.Forms.Cursors.No;
            this.TB_New_ProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_New_ProductName.Location = new System.Drawing.Point(8, 27);
            this.TB_New_ProductName.Name = "TB_New_ProductName";
            this.TB_New_ProductName.Size = new System.Drawing.Size(200, 22);
            this.TB_New_ProductName.TabIndex = 19;
            // 
            // L_New_ProductName
            // 
            this.L_New_ProductName.AutoSize = true;
            this.L_New_ProductName.Location = new System.Drawing.Point(5, 7);
            this.L_New_ProductName.Name = "L_New_ProductName";
            this.L_New_ProductName.Size = new System.Drawing.Size(124, 17);
            this.L_New_ProductName.TabIndex = 20;
            this.L_New_ProductName.Text = "Новое название товара";
            this.L_New_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_New_ProductCategory
            // 
            this.L_New_ProductCategory.AutoSize = true;
            this.L_New_ProductCategory.Location = new System.Drawing.Point(5, 58);
            this.L_New_ProductCategory.Name = "L_New_ProductCategory";
            this.L_New_ProductCategory.Size = new System.Drawing.Size(127, 17);
            this.L_New_ProductCategory.TabIndex = 21;
            this.L_New_ProductCategory.Text = "Новая категория товара";
            this.L_New_ProductCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_New_ProductCount
            // 
            this.L_New_ProductCount.AutoSize = true;
            this.L_New_ProductCount.Location = new System.Drawing.Point(5, 110);
            this.L_New_ProductCount.Name = "L_New_ProductCount";
            this.L_New_ProductCount.Size = new System.Drawing.Size(133, 17);
            this.L_New_ProductCount.TabIndex = 23;
            this.L_New_ProductCount.Text = "Новое количество товара";
            this.L_New_ProductCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_New_ProductPrice
            // 
            this.L_New_ProductPrice.AutoSize = true;
            this.L_New_ProductPrice.Location = new System.Drawing.Point(242, 6);
            this.L_New_ProductPrice.Name = "L_New_ProductPrice";
            this.L_New_ProductPrice.Size = new System.Drawing.Size(101, 17);
            this.L_New_ProductPrice.TabIndex = 25;
            this.L_New_ProductPrice.Text = "Новая цена товара";
            this.L_New_ProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PNL_OldData
            // 
            this.PNL_OldData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.PNL_OldData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_OldData.Controls.Add(this.L_Old_ProductDate);
            this.PNL_OldData.Controls.Add(this.TB_Old_ProductDate);
            this.PNL_OldData.Controls.Add(this.L_Old_ProductCode);
            this.PNL_OldData.Controls.Add(this.TB_Old_ProductCode);
            this.PNL_OldData.Controls.Add(this.TB_Old_ProductCategory);
            this.PNL_OldData.Controls.Add(this.L_Old_ProductPrice);
            this.PNL_OldData.Controls.Add(this.TB_Old_ProductPrice);
            this.PNL_OldData.Controls.Add(this.L_Old_ProductCount);
            this.PNL_OldData.Controls.Add(this.TB_Old_ProductCount);
            this.PNL_OldData.Controls.Add(this.L_Old_ProductCategory);
            this.PNL_OldData.Controls.Add(this.L_Old_ProductName);
            this.PNL_OldData.Controls.Add(this.TB_Old_ProductName);
            this.PNL_OldData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_OldData.Location = new System.Drawing.Point(3, 3);
            this.PNL_OldData.Name = "PNL_OldData";
            this.PNL_OldData.Size = new System.Drawing.Size(458, 169);
            this.PNL_OldData.TabIndex = 0;
            // 
            // L_Old_ProductDate
            // 
            this.L_Old_ProductDate.AutoSize = true;
            this.L_Old_ProductDate.Location = new System.Drawing.Point(242, 113);
            this.L_Old_ProductDate.Name = "L_Old_ProductDate";
            this.L_Old_ProductDate.Size = new System.Drawing.Size(154, 17);
            this.L_Old_ProductDate.TabIndex = 18;
            this.L_Old_ProductDate.Text = "Последнее изменение товара";
            this.L_Old_ProductDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Old_ProductDate
            // 
            this.TB_Old_ProductDate.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_Old_ProductDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Old_ProductDate.Cursor = System.Windows.Forms.Cursors.No;
            this.TB_Old_ProductDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Old_ProductDate.Location = new System.Drawing.Point(245, 133);
            this.TB_Old_ProductDate.Name = "TB_Old_ProductDate";
            this.TB_Old_ProductDate.ReadOnly = true;
            this.TB_Old_ProductDate.Size = new System.Drawing.Size(200, 22);
            this.TB_Old_ProductDate.TabIndex = 17;
            this.TB_Old_ProductDate.Text = "Н / Д";
            // 
            // L_Old_ProductCode
            // 
            this.L_Old_ProductCode.AutoSize = true;
            this.L_Old_ProductCode.Location = new System.Drawing.Point(242, 61);
            this.L_Old_ProductCode.Name = "L_Old_ProductCode";
            this.L_Old_ProductCode.Size = new System.Drawing.Size(63, 17);
            this.L_Old_ProductCode.TabIndex = 16;
            this.L_Old_ProductCode.Text = "Код товара";
            this.L_Old_ProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Old_ProductCode
            // 
            this.TB_Old_ProductCode.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_Old_ProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Old_ProductCode.Cursor = System.Windows.Forms.Cursors.No;
            this.TB_Old_ProductCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Old_ProductCode.Location = new System.Drawing.Point(245, 81);
            this.TB_Old_ProductCode.Name = "TB_Old_ProductCode";
            this.TB_Old_ProductCode.ReadOnly = true;
            this.TB_Old_ProductCode.Size = new System.Drawing.Size(200, 22);
            this.TB_Old_ProductCode.TabIndex = 15;
            this.TB_Old_ProductCode.Text = "Н / Д";
            // 
            // TB_Old_ProductCategory
            // 
            this.TB_Old_ProductCategory.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_Old_ProductCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Old_ProductCategory.Cursor = System.Windows.Forms.Cursors.No;
            this.TB_Old_ProductCategory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Old_ProductCategory.Location = new System.Drawing.Point(8, 81);
            this.TB_Old_ProductCategory.Name = "TB_Old_ProductCategory";
            this.TB_Old_ProductCategory.ReadOnly = true;
            this.TB_Old_ProductCategory.Size = new System.Drawing.Size(200, 22);
            this.TB_Old_ProductCategory.TabIndex = 14;
            this.TB_Old_ProductCategory.Text = "Н / Д";
            // 
            // L_Old_ProductPrice
            // 
            this.L_Old_ProductPrice.AutoSize = true;
            this.L_Old_ProductPrice.Location = new System.Drawing.Point(242, 10);
            this.L_Old_ProductPrice.Name = "L_Old_ProductPrice";
            this.L_Old_ProductPrice.Size = new System.Drawing.Size(69, 17);
            this.L_Old_ProductPrice.TabIndex = 13;
            this.L_Old_ProductPrice.Text = "Цена товара";
            this.L_Old_ProductPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Old_ProductPrice
            // 
            this.TB_Old_ProductPrice.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_Old_ProductPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Old_ProductPrice.Cursor = System.Windows.Forms.Cursors.No;
            this.TB_Old_ProductPrice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Old_ProductPrice.Location = new System.Drawing.Point(245, 30);
            this.TB_Old_ProductPrice.Name = "TB_Old_ProductPrice";
            this.TB_Old_ProductPrice.ReadOnly = true;
            this.TB_Old_ProductPrice.Size = new System.Drawing.Size(200, 22);
            this.TB_Old_ProductPrice.TabIndex = 12;
            this.TB_Old_ProductPrice.Text = "Н / Д";
            // 
            // L_Old_ProductCount
            // 
            this.L_Old_ProductCount.AutoSize = true;
            this.L_Old_ProductCount.Location = new System.Drawing.Point(5, 113);
            this.L_Old_ProductCount.Name = "L_Old_ProductCount";
            this.L_Old_ProductCount.Size = new System.Drawing.Size(101, 17);
            this.L_Old_ProductCount.TabIndex = 11;
            this.L_Old_ProductCount.Text = "Количество товара";
            this.L_Old_ProductCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Old_ProductCount
            // 
            this.TB_Old_ProductCount.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_Old_ProductCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Old_ProductCount.Cursor = System.Windows.Forms.Cursors.No;
            this.TB_Old_ProductCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Old_ProductCount.Location = new System.Drawing.Point(8, 133);
            this.TB_Old_ProductCount.Name = "TB_Old_ProductCount";
            this.TB_Old_ProductCount.ReadOnly = true;
            this.TB_Old_ProductCount.Size = new System.Drawing.Size(200, 22);
            this.TB_Old_ProductCount.TabIndex = 10;
            this.TB_Old_ProductCount.Text = "Н / Д";
            // 
            // L_Old_ProductCategory
            // 
            this.L_Old_ProductCategory.AutoSize = true;
            this.L_Old_ProductCategory.Location = new System.Drawing.Point(5, 61);
            this.L_Old_ProductCategory.Name = "L_Old_ProductCategory";
            this.L_Old_ProductCategory.Size = new System.Drawing.Size(95, 17);
            this.L_Old_ProductCategory.TabIndex = 8;
            this.L_Old_ProductCategory.Text = "Категория товара";
            this.L_Old_ProductCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_Old_ProductName
            // 
            this.L_Old_ProductName.AutoSize = true;
            this.L_Old_ProductName.Location = new System.Drawing.Point(5, 10);
            this.L_Old_ProductName.Name = "L_Old_ProductName";
            this.L_Old_ProductName.Size = new System.Drawing.Size(92, 17);
            this.L_Old_ProductName.TabIndex = 6;
            this.L_Old_ProductName.Text = "Название товара";
            this.L_Old_ProductName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_Old_ProductName
            // 
            this.TB_Old_ProductName.BackColor = System.Drawing.Color.PeachPuff;
            this.TB_Old_ProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Old_ProductName.Cursor = System.Windows.Forms.Cursors.No;
            this.TB_Old_ProductName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TB_Old_ProductName.Location = new System.Drawing.Point(8, 30);
            this.TB_Old_ProductName.Name = "TB_Old_ProductName";
            this.TB_Old_ProductName.ReadOnly = true;
            this.TB_Old_ProductName.Size = new System.Drawing.Size(200, 22);
            this.TB_Old_ProductName.TabIndex = 5;
            this.TB_Old_ProductName.Text = "Н / Д";
            // 
            // PNL_Operations
            // 
            this.PNL_Operations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(145)))));
            this.PNL_Operations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_Operations.Controls.Add(this.SC_TimeDelete);
            this.PNL_Operations.Cursor = System.Windows.Forms.Cursors.Default;
            this.PNL_Operations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Operations.Location = new System.Drawing.Point(0, 0);
            this.PNL_Operations.Name = "PNL_Operations";
            this.PNL_Operations.Size = new System.Drawing.Size(247, 351);
            this.PNL_Operations.TabIndex = 2;
            // 
            // SC_TimeDelete
            // 
            this.SC_TimeDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SC_TimeDelete.Location = new System.Drawing.Point(0, 0);
            this.SC_TimeDelete.Name = "SC_TimeDelete";
            this.SC_TimeDelete.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // SC_TimeDelete.Panel1
            // 
            this.SC_TimeDelete.Panel1.Controls.Add(this.PNL_Time);
            // 
            // SC_TimeDelete.Panel2
            // 
            this.SC_TimeDelete.Panel2.Controls.Add(this.PNL_Delete);
            this.SC_TimeDelete.Size = new System.Drawing.Size(245, 349);
            this.SC_TimeDelete.TabIndex = 0;
            // 
            // PNL_Delete
            // 
            this.PNL_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Delete.Location = new System.Drawing.Point(0, 0);
            this.PNL_Delete.Name = "PNL_Delete";
            this.PNL_Delete.Size = new System.Drawing.Size(245, 295);
            this.PNL_Delete.TabIndex = 0;
            // 
            // PNL_Time
            // 
            this.PNL_Time.Controls.Add(this.L_Timer);
            this.PNL_Time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_Time.Location = new System.Drawing.Point(0, 0);
            this.PNL_Time.Name = "PNL_Time";
            this.PNL_Time.Size = new System.Drawing.Size(245, 50);
            this.PNL_Time.TabIndex = 1;
            // 
            // L_Timer
            // 
            this.L_Timer.AutoSize = true;
            this.L_Timer.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Timer.Location = new System.Drawing.Point(81, 7);
            this.L_Timer.Name = "L_Timer";
            this.L_Timer.Size = new System.Drawing.Size(78, 34);
            this.L_Timer.TabIndex = 0;
            this.L_Timer.Text = "label1";
            // 
            // Timer_ForLable
            // 
            this.Timer_ForLable.Tick += new System.EventHandler(this.Timer_ForLable_Tick);
            // 
            // ProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(715, 376);
            this.Controls.Add(this.SC_ProductUpdate);
            this.Controls.Add(this.MS_Main);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductUpdate";
            this.Text = "Редактировать товар";
            this.Load += new System.EventHandler(this.ProductUpdate_Load);
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.SC_ProductUpdate.Panel1.ResumeLayout(false);
            this.SC_ProductUpdate.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SC_ProductUpdate)).EndInit();
            this.SC_ProductUpdate.ResumeLayout(false);
            this.TLP_NewOldData.ResumeLayout(false);
            this.PNL_NewData.ResumeLayout(false);
            this.PNL_NewData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_New_ProductPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_New_ProductCount)).EndInit();
            this.PNL_OldData.ResumeLayout(false);
            this.PNL_OldData.PerformLayout();
            this.PNL_Operations.ResumeLayout(false);
            this.SC_TimeDelete.Panel1.ResumeLayout(false);
            this.SC_TimeDelete.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SC_TimeDelete)).EndInit();
            this.SC_TimeDelete.ResumeLayout(false);
            this.PNL_Time.ResumeLayout(false);
            this.PNL_Time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PU_File;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PU_TopMost;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PU_ConnectionData;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PU_Connection;
        public System.Windows.Forms.ToolStripMenuItem TSMI_PU_Connection_OpenClose;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PU_ConnectionStatus;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PU_DataTools;
        private System.Windows.Forms.ToolStripMenuItem TSMI_PU_Synchronize;
        private System.Windows.Forms.SplitContainer SC_ProductUpdate;
        private System.Windows.Forms.TableLayoutPanel TLP_NewOldData;
        private System.Windows.Forms.Panel PNL_NewData;
        private System.Windows.Forms.Panel PNL_OldData;
        private System.Windows.Forms.Panel PNL_Operations;
        private System.Windows.Forms.Label L_Old_ProductCategory;
        private System.Windows.Forms.Label L_Old_ProductDate;
        private System.Windows.Forms.TextBox TB_Old_ProductDate;
        private System.Windows.Forms.Label L_Old_ProductCode;
        private System.Windows.Forms.TextBox TB_Old_ProductCode;
        private System.Windows.Forms.TextBox TB_Old_ProductCategory;
        private System.Windows.Forms.Label L_Old_ProductPrice;
        private System.Windows.Forms.TextBox TB_Old_ProductPrice;
        private System.Windows.Forms.Label L_Old_ProductCount;
        private System.Windows.Forms.TextBox TB_Old_ProductCount;
        private System.Windows.Forms.Label L_Old_ProductName;
        private System.Windows.Forms.TextBox TB_Old_ProductName;
        private System.Windows.Forms.TextBox TB_New_ProductName;
        private System.Windows.Forms.Label L_New_ProductName;
        private System.Windows.Forms.Label L_New_ProductCategory;
        private System.Windows.Forms.Label L_New_ProductCount;
        private System.Windows.Forms.Label L_New_ProductPrice;
        private System.Windows.Forms.ComboBox CB_New_ProductCategory;
        private System.Windows.Forms.NumericUpDown NUD_New_ProductPrice;
        private System.Windows.Forms.NumericUpDown NUD_New_ProductCount;
        public System.Windows.Forms.CheckBox CHB_ChangePrice;
        public System.Windows.Forms.CheckBox CHB_ChangeCount;
        public System.Windows.Forms.CheckBox CHB_ChangeCategory;
        public System.Windows.Forms.CheckBox CHB_ChangeName;
        private System.Windows.Forms.Button B_ApplyChanges;
        private System.Windows.Forms.Button B_ResetChanges;
        private System.Windows.Forms.Button B_OverwriteData;
        private System.Windows.Forms.SplitContainer SC_TimeDelete;
        private System.Windows.Forms.Panel PNL_Delete;
        private System.Windows.Forms.Panel PNL_Time;
        private System.Windows.Forms.Timer Timer_ForLable;
        public System.Windows.Forms.Label L_Timer;
    }
}