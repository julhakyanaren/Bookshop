using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Bookshop
{
    public partial class MainForm : Form
    {
        public OleDbConnection ConnectionMF = Connections.Direct.Connection;
        public MainForm()
        {
            InitializeComponent();
        }
        public void TSMI_Connection_OpenClose_Click(object sender, EventArgs e)
        {
            bool exception = false;
            switch (TSMI_Connection_OpenClose.Checked)
            {
                case true:
                    {
                        if (ConnectionMF.State != ConnectionState.Open)
                        {
                            try
                            {
                                ConnectionMF.Open();
                                Connections.Direct.Connected = true;
                                TSMI_Connection_OpenClose.Text = "Отключить соединение";
                                TSMI_ConnectionStatus.Enabled = true;
                                TSMI_ConnectionStatus.Text = "Статус: Установлено";
                                TSMI_ConnectionStatus.ForeColor = Color.Green;
                                TSMI_Synchronize.Enabled = true;
                            }
                            catch (Exception ex)
                            {
                                exception = true;
                                Handlers.ErrorProvider.ExcaptionShowMessages(ex, 0);
                            }
                            break;
                        }
                        else
                        {
                            switch (DialogResult = MessageBox.Show("Поключение не закрыто\r\nОтсоеденить?", "Диспечер подключении", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                            {
                                case DialogResult.Yes:
                                    {
                                        try
                                        {
                                            ConnectionMF.Close();
                                            Connections.Direct.Connected = false;
                                        }
                                        catch (Exception ex)
                                        {
                                            exception = true;
                                            Handlers.ErrorProvider.ExcaptionShowMessages(ex, 0);
                                        }
                                        break;
                                    }
                                case DialogResult.No:
                                    {
                                        break;
                                    }
                            }
                            break;

                        }
                    }
                case false:
                    {
                        if (ConnectionMF.State != ConnectionState.Closed)
                        {
                            try
                            {
                                ConnectionMF.Close();
                                Connections.Direct.Connected = false;
                                TSMI_Connection_OpenClose.Text = "Установить соединение";
                                TSMI_ConnectionStatus.Enabled = false;
                                TSMI_ConnectionStatus.Text = "Статус: Отключено";
                                TSMI_ConnectionStatus.ForeColor = Color.Firebrick;
                            }
                            catch (Exception ex)
                            {
                                exception = true;
                                Handlers.ErrorProvider.ExcaptionShowMessages(ex, 0);
                            }
                            break;
                        }
                        else
                        {
                            switch (DialogResult = MessageBox.Show("Поключение закрыто\r\nСоеденить?", "Диспечер подключении", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                            {
                                case DialogResult.Yes:
                                    {
                                        try
                                        {
                                            ConnectionMF.Open();
                                            Connections.Direct.Connected = true;
                                        }
                                        catch (Exception ex)
                                        {
                                            exception = true;
                                            Handlers.ErrorProvider.ExcaptionShowMessages(ex, 0);
                                        }
                                        break;
                                    }
                                case DialogResult.No:
                                    {
                                        break;
                                    }
                            }

                        }
                        break;
                    }
            }
            if (!exception)
            {
                Connections.Direct.StatusToMB(Connections.Direct.Connected);
            }
            else
            {
                MessageBox.Show("Соеденение не установлено", "Диспечер Соеденения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetDesignParameters()
        {
            SetLableInCenterOfPanel(L_Info_AddProduct, PNL_DataOperation);
            SetLableInCenterOfPanel(L_Info_RedactUpdate, PNL_Redact_Update);
            SetLableInCenterOfPanel(L_Info_RedactDelete, PNL_Redact_Delete);
        }
        public void SetLableInCenterOfPanel(Label inputlable, Panel inputpanel)
        {
            inputlable.Location = new Point((inputpanel.Width - inputlable.Width) / 2, 0);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bSDBDataSet.Product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.bSDBDataSet.Product);
            Methods.LoadComponents();
            Options.FormOpened[0] = true;
            Methods.FormsStateRegister();
            var columnHeaderStyle = DGV_MS_Product.ColumnHeadersDefaultCellStyle;
            columnHeaderStyle.BackColor = Color.SandyBrown;
            columnHeaderStyle.ForeColor = Color.Black;
            SetDesignParameters();
        }

        private void TSMI_Category_Add_Click(object sender, EventArgs e)
        {
            CategoryManager CMF = new CategoryManager();
            CMF.Show();
        }

        private void TSMI_TopMost_Click(object sender, EventArgs e)
        {
            switch (TSMI_TopMost.Checked)
            {
                case true:
                    {
                        this.TopMost = true;
                        break;
                    }
                case false:
                    {
                        this.TopMost = false;
                        break;
                    }
            }
        }
        public void GetCategoriesforRedact(ComboBox CB_Categories)
        {
            int categoriescount = Connections.Direct.Queries.GetRowsCount(Options.Table[0], ConnectionMF);
            if (categoriescount > 0)
            {
                bool readen = false;
                try
                {
                    Array.Resize(ref Data.Categories.AllCategories, categoriescount);
                    for (int r = 0; r < categoriescount; r++)
                    {
                        Data.Categories.AllCategories[r] = String.Empty;
                    }
                    string getcategoriesquery = $"SELECT * FROM {Options.Table[0]} WHERE ID > 0";
                    string readenrow;
                    int index = 0;
                    using (OleDbCommand getcategoriescmd = new OleDbCommand(getcategoriesquery, ConnectionMF))
                    {
                        using (OleDbDataReader getcategoriesreader = getcategoriescmd.ExecuteReader())
                        {
                            if (getcategoriesreader.Read())
                            {
                                do
                                {
                                    readenrow = Convert.ToString(getcategoriesreader[1]);
                                    Data.Categories.AllCategories[index] = readenrow;
                                    index++;
                                }
                                while (getcategoriesreader.Read());
                            }
                        }
                    }
                    readen = true;
                }
                catch (Exception ex)
                {
                    Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                    readen = false;
                }
                finally
                {
                    CB_Categories.Items.Clear();
                    if (readen)
                    {
                        for (int i = 0; i < categoriescount; i++)
                        {
                            CB_Categories.Items.Add(Convert.ToString(Data.Categories.AllCategories[i]));
                        }
                        B_AcceptChoice_Update.Enabled = true;
                    }
                    else
                    {
                        B_AcceptChoice_Update.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Нет доступных категории", $"{Config.Managers[0]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // PNL_DataOperation.Enabled = false;
            }

        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (ConnectionMF.State)
            {
                case ConnectionState.Open:
                    {
                        ConnectionMF.Close();
                        break;
                    }
                case ConnectionState.Closed:
                    {
                        ConnectionMF.Open();
                        ConnectionMF.Close();
                        break;
                    }
            }
        }
        private void CHB_ProdUpdate_ByCode_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_ProdUpdate_ByCode.Checked)
            {
                CHB_ProdUpdate_ByCategory.Checked = false;
                CHB_ProdUpdate_ByName.Checked = false;
                Handlers.SetConfiguration.SetSearchTypeThrowCheckBox(CHB_ProdUpdate_ByCode, GB_SearchType_Update);
                L_NameCode_Update.Text = "Код";
                TB_InputDataForSearch_Update.Enabled = true;
                L_InfoCatregorySearch_Update.Visible = false;
                CB_CategorySearch_Update.Visible = false;
                CB_Products_Update.Enabled = true;
                TB_InputDataForSearch_Update.Clear();
            }
            else
            {
                if (!CHB_ProdUpdate_ByName.Checked)
                {
                    TB_InputDataForSearch_Update.Enabled = false;
                }
            }
        }
        private void CHB_ProdUpdate_ByCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_ProdUpdate_ByCategory.Checked)
            {
                CHB_ProdUpdate_ByCode.Checked = false;
                CHB_ProdUpdate_ByName.Checked = false;
                Handlers.SetConfiguration.SetSearchTypeThrowCheckBox(CHB_ProdUpdate_ByCategory, GB_SearchType_Update);
                L_NameCode_Update.Text = "Код";
                TB_InputDataForSearch_Update.Enabled = false;
                L_InfoCatregorySearch_Update.Visible = true;
                CB_CategorySearch_Update.Visible = true;
                CB_Products_Update.Enabled = true;
                GetCategoriesforRedact(CB_CategorySearch_Update);
                TB_InputDataForSearch_Update.Clear();
            }
            else
            {
                CB_CategorySearch_Update.Items.Clear();
                L_InfoCatregorySearch_Update.Visible = false;
                CB_CategorySearch_Update.Visible = false;
            }
        }
        private void CHB_ProdUpdate_ByName_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_ProdUpdate_ByName.Checked)
            {
                CHB_ProdUpdate_ByCode.Checked = false;
                CHB_ProdUpdate_ByCategory.Checked = false;
                Handlers.SetConfiguration.SetSearchTypeThrowCheckBox(CHB_ProdUpdate_ByName, GB_SearchType_Update);
                L_NameCode_Update.Text = "Название";
                TB_InputDataForSearch_Update.Enabled = true;
                L_InfoCatregorySearch_Update.Visible = false;
                CB_CategorySearch_Update.Visible = false;
                CB_Products_Update.Enabled = true;
                TB_InputDataForSearch_Update.Clear();
            }
            else
            {
                if (!CHB_ProdUpdate_ByCode.Checked)
                {
                    TB_InputDataForSearch_Update.Enabled = false;
                }
            }
        }
        private void CHB_ProdDelete_ByName_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_ProdDelete_ByName.Checked)
            {
                CHB_ProdDelete_ByCode.Checked = false;
                CHB_ProdDelete_ByCategory.Checked = false;
                Handlers.SetConfiguration.SetSearchTypeThrowCheckBox(CHB_ProdDelete_ByName, GB_SearchType_Delete);
                L_NameCode_Delete.Text = "Название";
                TB_InputDataForSearch_Delete.Enabled = true;
                L_InfoCatregorySearch_Delete.Visible = false;
                CB_CategorySearch_Delete.Visible = false;
            }
            else
            {
                if (!CHB_ProdDelete_ByCode.Checked)
                {
                    TB_InputDataForSearch_Delete.Enabled = false;
                }
            }
        }
        private void CHB_ProdDelete_ByCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_ProdDelete_ByCategory.Checked)
            {
                CHB_ProdDelete_ByCode.Checked = false;
                CHB_ProdDelete_ByName.Checked = false;
                Handlers.SetConfiguration.SetSearchTypeThrowCheckBox(CHB_ProdDelete_ByCategory, GB_SearchType_Delete);
                L_NameCode_Delete.Text = "Код";
                TB_InputDataForSearch_Delete.Enabled = false;
                L_InfoCatregorySearch_Delete.Visible = true;
                CB_CategorySearch_Delete.Visible = true;
                GetCategoriesforRedact(CB_CategorySearch_Delete);
            }
            else
            {
                L_InfoCatregorySearch_Delete.Visible = false;
                CB_CategorySearch_Delete.Visible = false;
            }

        }
        private void CHB_ProdDelete_ByCode_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_ProdDelete_ByCode.Checked)
            {
                CHB_ProdDelete_ByCategory.Checked = false;
                CHB_ProdDelete_ByName.Checked = false;
                Handlers.SetConfiguration.SetSearchTypeThrowCheckBox(CHB_ProdDelete_ByCode, GB_SearchType_Delete);
                L_NameCode_Delete.Text = "Код";
                TB_InputDataForSearch_Delete.Enabled = true;
                L_InfoCatregorySearch_Delete.Visible = false;
                CB_CategorySearch_Delete.Visible = false;
            }
            else
            {
                if (!CHB_ProdDelete_ByName.Checked)
                {
                    TB_InputDataForSearch_Delete.Enabled = false;
                }
            }
        }

        private void CHB_SelectAll_Delete_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_SelectAll_Delete.Checked)
            {
                Data.Products.Delete.DeleteAll = true;
                CB_Products_Delete.Enabled = false;
                CB_Products_Delete.Items.Clear();
                CB_Products_Delete.Text = "Удатиь все данные в категории";
                B_ProductDelete.Text = "Удалить товары";
            }
            else
            {
                Data.Products.Delete.DeleteAll = false;
                CB_Products_Delete.Enabled = true;
                CB_Products_Delete.Items.Clear();
                B_ProductDelete.Text = "Удалить товар";
            }
        }
        private void CHB_PriceOver100_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_PriceOver100.Checked)
            {
                CHB_PriceOver1000.Enabled = true;
                NUD_Price.Maximum = 999;
                if (NUD_Price.Value > 99)
                {
                    NUD_Price.Value = 99;
                }
            }
            else
            {
                CHB_PriceOver1000.Enabled = false;
                CHB_PriceOver1000.Checked = false;
                NUD_Price.Maximum = 99;
            }
        }

        private void CHB_CountOver100_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_CountOver100.Checked)
            {
                CHB_CountOver1000.Enabled = true;
                NUD_Count.Maximum = 999;
            }
            else
            {
                CHB_CountOver1000.Enabled = false;
                CHB_CountOver1000.Checked = false;
                if (NUD_Count.Value > 99)
                {
                    NUD_Count.Value = 99;
                }
                NUD_Count.Maximum = 99;
            }
        }

        private void CHB_PriceOver1000_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_PriceOver1000.Checked)
            {
                NUD_Price.Maximum = 9999;
            }
            else
            {
                if (NUD_Price.Value > 999)
                {
                    NUD_Price.Value = 999;
                    NUD_Price.Maximum = 999;
                }
            }
        }

        private void CHB_CountOver1000_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_CountOver1000.Checked)
            {
                NUD_Count.Maximum = 9999;
            }
            else
            {
                if (NUD_Count.Value > 999)
                {
                    NUD_Count.Value = 999;
                    NUD_Count.Maximum = 999;
                }
            }

        }

        private void NUD_Price_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_Price.Value >= NUD_Price.Maximum)
            {
                NUD_Price.Value = NUD_Price.Maximum;
            }
            if (NUD_Price.Value == 0)
            {
                B_ApplyPrice.Enabled = false;
                Data.Products.CodeGenerator.EnableGenerator[2] = false;
            }
            else
            {
                B_ApplyPrice.Enabled = true;
            }
        }

        private void NUD_Count_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_Count.Value >= NUD_Count.Maximum)
            {
                NUD_Count.Value = NUD_Count.Maximum;
            }
            if (NUD_Count.Value == 0)
            {
                B_ApplyCount.Enabled = false;
                Data.Products.CodeGenerator.EnableGenerator[3] = true;
            }
            else
            {
                B_ApplyCount.Enabled = true;
            }

        }
        public void SynchronizeData()
        {
            Connections.Direct.ConnectionStateReload(ConnectionMF);
            if (Connections.Direct.ConnectionReset(ConnectionMF))
            {
                string Table = "Category";
                int categoriescount = Connections.Direct.Queries.GetRowsCount(Table, ConnectionMF);
                if (categoriescount > 0)
                {
                    bool readen = false;
                    try
                    {
                        Array.Resize(ref Data.Categories.AllCategories, categoriescount);
                        for (int r = 0; r < categoriescount; r++)
                        {
                            Data.Categories.AllCategories[r] = String.Empty;
                        }
                        string getcategoriesquery = $"SELECT * FROM {Table} WHERE ID > 0";
                        string readenrow;
                        int index = 0;
                        using (OleDbCommand getcategoriescmd = new OleDbCommand(getcategoriesquery, ConnectionMF))
                        {
                            using (OleDbDataReader getcategoriesreader = getcategoriescmd.ExecuteReader())
                            {
                                if (getcategoriesreader.Read())
                                {
                                    do
                                    {
                                        readenrow = Convert.ToString(getcategoriesreader[1]);
                                        Data.Categories.AllCategories[index] = readenrow;
                                        index++;
                                    }
                                    while (getcategoriesreader.Read());
                                }
                            }
                        }
                        readen = true;
                    }
                    catch (Exception ex)
                    {
                        Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                        readen = false;
                    }
                    finally
                    {
                        if (readen)
                        {
                            PNL_DataOperation.Enabled = true;
                            B_AcceptChoice_Update.Enabled = true;
                            B_AcceptChoice_Delete.Enabled = true;
                        }
                        else
                        {
                            PNL_DataOperation.Enabled = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Нет доступных категории", $"{Config.Managers[0]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PNL_DataOperation.Enabled = false;
                }
            }
            else
            {
                switch (DialogResult = MessageBox.Show("Синхронизация Провалено", $"{Config.Managers[0]}", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
                {
                    case DialogResult.Retry:
                        {
                            PNL_DataOperation.Enabled = false;
                            SynchronizeData();
                            break;
                        }
                    case DialogResult.Cancel:
                        {
                            break;
                        }
                }
            }
        }
        private void TSMI_Synchronize_Click(object sender, EventArgs e)
        {
            SynchronizeData();
        }
        private void B_ProductName_Check_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionMF);
            Data.Products.EnteredName[0] = Convert.ToString(TB_ProductName.Text);
            Data.Products.ProductsCount = Connections.Direct.Queries.GetRowsCount(Options.Table[1], ConnectionMF);
            if (Data.Products.EnteredName[0] == String.Empty)
            {
                DialogResult = MessageBox.Show("Пустое поле ввода", "Диспечер данных", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (DialogResult == DialogResult.OK)
                {
                    TB_ProductName.Focus();
                }
            }
            else
            {
                bool excaption;
                int rowscount = Data.Products.ProductsCount;
                switch (rowscount)
                {
                    case < 0:
                        {
                            excaption = true;
                            break;
                        }
                    case 0:
                        {
                            excaption = false;
                            Data.Products.NameExist[0] = false;
                            break;
                        }
                    case > 0:
                        {
                            excaption = false;
                            string getproductnamequery = $"SELECT Название FROM {Options.Table[1]} WHERE Название = @Name";
                            try
                            {
                                using (OleDbCommand getproductnamecmd = new OleDbCommand(getproductnamequery, ConnectionMF))
                                {
                                    getproductnamecmd.Parameters.Add("@Name", OleDbType.VarChar).Value = Convert.ToString(Data.Products.EnteredName[0]);
                                    OleDbDataReader getproductnamereader = getproductnamecmd.ExecuteReader();
                                    if (!getproductnamereader.Read())
                                    {
                                        Data.Products.NameExist[0] = false;
                                    }
                                    else
                                    {
                                        Data.Products.NameExist[0] = true;
                                        Data.Products.ProductNameOverOne[0] = true;
                                        Data.Products.SameNameProductsCount = 0;
                                        while (getproductnamereader.Read())
                                        {
                                            Data.Products.SameNameProductsCount++;
                                        }
                                    }
                                    getproductnamereader.Close();
                                }
                            }
                            catch (Exception ex)
                            {
                                Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                                excaption = true;
                            }
                            break;
                        }
                }
                if (excaption)
                {
                    //Ошибка
                }
                else
                {
                    switch (Data.Products.NameExist[0])
                    {
                        case true:
                            {
                                B_GetCategoryData.Enabled = false;
                                Data.Products.CodeGenerator.EnableGenerator[0] = false;
                                Data.Products.ProductNameOverOne[1] = false;
                                break;
                            }
                        case false:
                            {
                                DialogResult = MessageBox.Show($"Обноружено {Data.Products.SameNameProductsCount} продуктов под именем {Data.Products.EnteredName[0]}", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (DialogResult == DialogResult.OK)
                                {
                                    Data.Products.ProductNameOverOne[1] = true;
                                    B_GetCategoryData.Enabled = true;
                                    Data.Products.CodeGenerator.EnableGenerator[0] = true;
                                    B_GenerateUniqueID.Enabled = EnableCodeGenerator(0);
                                }
                                break;
                            }
                    }
                }
            }
        }

        private void B_GetCategoryData_Click(object sender, EventArgs e)
        {
            CB_GetCategories.Items.Clear();
            for (int p = 0; p < Data.Categories.AllCategories.Length; p++)
            {
                CB_GetCategories.Items.Add(Data.Categories.AllCategories[p]);
            }
            CB_GetCategories.Enabled = true;
        }

        private void B_SelectCategory_Click(object sender, EventArgs e)
        {
            Data.Products.SelectedCategory = Convert.ToString(CB_GetCategories.SelectedItem);
            if (Data.Products.SelectedCategory != String.Empty)
            {
                NUD_Price.Enabled = true;
                NUD_Count.Enabled = true;
                CHB_CountOver100.Enabled = true;
                CHB_PriceOver100.Enabled = true;
                NUD_Price.Value = 1;
                NUD_Count.Value = 1;
                Data.Products.CodeGenerator.EnableGenerator[1] = true;
                B_GenerateUniqueID.Enabled = EnableCodeGenerator(0);
            }
            else
            {
                NUD_Price.Enabled = false;
                NUD_Count.Enabled = false;
                NUD_Price.Value = 0;
                NUD_Count.Value = 0;
                CHB_CountOver100.Enabled = false;
                CHB_PriceOver100.Enabled = false;
                Data.Products.CodeGenerator.EnableGenerator[1] = false;
            }
        }
        public bool EnableCodeGenerator(int Index)
        {
            switch (Index)
            {
                case 0:
                    {
                        for (int b = 0; b < Data.Products.CodeGenerator.EnableGenerator.Length; b++)
                        {
                            if (Data.Products.CodeGenerator.EnableGenerator[b])
                            {
                                continue;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                case 1:
                    {
                        for (int b = 0; b < Data.Products.CodeGenerator.EnableGenerator.Length; b++)
                        {
                            Data.Products.CodeGenerator.EnableGenerator[b] = false;
                        }
                        return false;
                    }
                case 2:
                    {
                        for (int b = 0; b < Data.Products.CodeGenerator.EnableGenerator.Length; b++)
                        {
                            Data.Products.CodeGenerator.EnableGenerator[b] = true; ;
                        }
                        return true;
                    }
                default:
                    {
                        return false;
                    }
            }
        }
        private void B_ApplyPrice_Click(object sender, EventArgs e)
        {
            Data.Products.Price = Convert.ToInt32(NUD_Price.Value);
            Data.Products.CodeGenerator.EnableGenerator[2] = true;
            B_GenerateUniqueID.Enabled = EnableCodeGenerator(0);
        }

        private void B_ApplyCount_Click(object sender, EventArgs e)
        {
            Data.Products.Count = Convert.ToInt32(NUD_Count.Value);
            Data.Products.CodeGenerator.EnableGenerator[3] = true;
            B_GenerateUniqueID.Enabled = EnableCodeGenerator(0);
        }

        private void B_GenerateUniqueID_Click(object sender, EventArgs e)
        {
            TB_UniqueCode.Text = Data.Products.CodeGenerator.GenerateCode();
            if (TB_UniqueCode.Text != String.Empty)
            {
                B_ApplyData.Enabled = true;
            }
            else
            {
                B_ApplyData.Enabled = false;
                Data.Products.CodeGenerator.UniqueCode = null;
            }
        }

        private void B_ApplyData_Click(object sender, EventArgs e)
        {
            Data.Products.CodeGenerator.UniqueCode = Convert.ToString(TB_UniqueCode.Text);
            switch (DialogResult = MessageBox.Show("Записать данные ?", $"{Config.Managers[1]}", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    {
                        if (InsertProductsData())
                        {
                            Handlers.InformationProvider.DataOperationState(0, 0, 1);
                            UpdateProductAdd_Values();
                        }
                        else
                        {
                            Handlers.InformationProvider.DataOperationState(1, 0, 1);
                        }
                        break;
                    }
            }
        }
        public bool InsertProductsData()
        {
            Connections.Direct.ConnectionStateReload(ConnectionMF);
            bool inserted = false;
            string insertquery = $"INSERT INTO {Options.Table[1]} (Название, Категория, Количество, Цена, Код, Изменение) VALUES (@Name, @Category, @Count, @Price, @Code, @Date)";
            using (OleDbCommand insertcmd = new OleDbCommand(insertquery, ConnectionMF))
            {
                insertcmd.Parameters.Add("@Name", OleDbType.VarChar).Value = Convert.ToString(Data.Products.EnteredName[0]);
                insertcmd.Parameters.Add("@Category", OleDbType.VarChar).Value = Convert.ToString(Data.Products.SelectedCategory);
                insertcmd.Parameters.Add("@Count", OleDbType.Integer).Value = Convert.ToInt32(Data.Products.Count);
                insertcmd.Parameters.Add("@Price", OleDbType.Integer).Value = Convert.ToInt32(Data.Products.Price);
                insertcmd.Parameters.Add("@Code", OleDbType.VarChar).Value = Convert.ToString(Data.Products.CodeGenerator.UniqueCode);
                insertcmd.Parameters.Add("@Date", OleDbType.DBDate).Value = Convert.ToDateTime(DateTime.Now);
                try
                {
                    insertcmd.ExecuteNonQuery();
                    inserted = true;
                }
                catch (Exception ex)
                {
                    Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                    inserted = false;
                }
            }
            if (inserted)
            {
                int count = 0;
                string[] query = new string[2];
                query[0] = $"SELECT * FROM {Options.Table[0]} WHERE Название = @Name";
                query[1] = $"UPDATE {Options.Table[0]} SET Количество = @NewCount WHERE Название = @Name";
                using (OleDbCommand selectcmd = new OleDbCommand(query[0], ConnectionMF))
                {
                    selectcmd.Parameters.Add("@Name", OleDbType.VarChar).Value = Convert.ToString(Data.Products.SelectedCategory);
                    OleDbDataReader selectreader = selectcmd.ExecuteReader();
                    if (selectreader.Read())
                    {
                        count = selectreader.GetInt32(2);
                    }
                    else
                    {
                        count = -1;
                    }
                    selectreader.Close();
                }
                if (count < 0)
                {
                    MessageBox.Show("Не удалось обновить данные категории", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (OleDbCommand updatecmd = new OleDbCommand(query[1], ConnectionMF))
                    {
                        updatecmd.Parameters.Add("@Name", OleDbType.VarChar).Value = Convert.ToString(Data.Products.SelectedCategory);
                        updatecmd.Parameters.Add("@NewCount", OleDbType.Integer).Value = Convert.ToInt32(count + 1);
                        updatecmd.ExecuteNonQuery();
                    }
                }
            }
            return inserted;

        }

        private void CB_GetCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_GetCategories.Items.Count != 0)
            {
                B_SelectCategory.Enabled = true;
            }
            else
            {
                B_SelectCategory.Enabled = false;
            }
        }

        private void TSMI_Update_DGV_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionMF);
            string script = $"SELECT * FROM {Options.Table[1]}";
            OleDbDataAdapter adapter = new OleDbDataAdapter(script, ConnectionMF);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DGV_MS_Product.DataSource = table;
        }

        private void B_DEBUG_ADDCATEGORY_Click(object sender, EventArgs e)
        {
            
        }
        private void B_AcceptChoice_Update_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionMF);
            CB_Products_Update.Items.Clear();
            switch (Data.Products.SearchWithUniqueCode[0])
            {
                case 0:
                    {
                        bool readen = false;
                        Data.Products.Update.EnteredCode = Convert.ToString(TB_InputDataForSearch_Update.Text);
                        string compareenteredcodequery = $"SELECT * FROM {Options.Table[1]} WHERE Код = @EnteredCode";
                        using (OleDbCommand compareenteredcodecmd = new OleDbCommand(compareenteredcodequery, ConnectionMF))
                        {
                            compareenteredcodecmd.Parameters.Add("@EnteredCode", OleDbType.VarChar).Value = Convert.ToString(Data.Products.Update.EnteredCode);
                            OleDbDataReader compareenteredcodereader = compareenteredcodecmd.ExecuteReader();
                            if (!compareenteredcodereader.Read())
                            {
                                MessageBox.Show($"Товар под кодом {Data.Products.Update.EnteredCode} не найден!", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                try
                                {
                                    Data.Products.Update.SelectedName = Convert.ToString(compareenteredcodereader[1]);
                                    readen = true;
                                }
                                catch (Exception ex)
                                {
                                    Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                                    readen = false;
                                }
                                finally
                                {
                                    if (readen)
                                    {
                                        MessageBox.Show($"Товар {Data.Products.Update.SelectedName} обноружен под кодом {Data.Products.Update.EnteredCode} ", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    CB_Products_Update.Items.Clear();
                                    CB_Products_Update.Items.Add(Convert.ToString(Data.Products.Update.SelectedName));
                                    CB_Products_Update.SelectedIndex = 0;
                                    CB_Products_Update.Enabled = false;
                                }
                            }
                            compareenteredcodereader.Close();
                        }
                        break;
                    }
                case 1:
                    {
                        Data.Products.Update.SelectedCategory = Convert.ToString(CB_CategorySearch_Update.SelectedItem);
                        GB_SelectProduct_Update.Visible = true;
                        Array.Resize(ref Data.Products.Update.ProductsByCategory, 0);
                        string getproductsbycategoryquery = $"SELECT * FROM {Options.Table[1]} WHERE Категория = @Category";
                        using (OleDbCommand getproductsbycategorycmd = new OleDbCommand(getproductsbycategoryquery, ConnectionMF))
                        {
                            getproductsbycategorycmd.Parameters.Add("@Category", OleDbType.VarChar).Value = Convert.ToString(Data.Products.Update.SelectedCategory);
                            using (OleDbDataReader getproductsbycategoryreader = getproductsbycategorycmd.ExecuteReader())
                            {
                                if (getproductsbycategoryreader.Read())
                                {
                                    int index = 0;
                                    do
                                    {
                                        Array.Resize(ref Data.Products.Update.ProductsByCategory, Data.Products.Update.ProductsByCategory.Length + 1);
                                        Data.Products.Update.ProductsByCategory[index] = Convert.ToString(getproductsbycategoryreader.GetValue(1));
                                        index++;
                                    }
                                    while (getproductsbycategoryreader.Read());
                                }
                            }
                            for (int u = 0; u < Data.Products.Update.ProductsByCategory.Length; u++)
                            {
                                CB_Products_Update.Items.Add(Convert.ToString(Data.Products.Update.ProductsByCategory[u]));
                            }
                        }
                        break;
                    }
                case 2:
                    {
                        int counternames = 0;
                        bool readen = false;
                        Data.Products.Update.EnteredName = Convert.ToString(TB_InputDataForSearch_Update.Text);
                        string compareenteredcodequery = $"SELECT * FROM {Options.Table[1]} WHERE Название = @EnteredName";
                        using (OleDbCommand compareenteredcodecmd = new OleDbCommand(compareenteredcodequery, ConnectionMF))
                        {
                            compareenteredcodecmd.Parameters.Add("@EnteredName", OleDbType.VarChar).Value = Convert.ToString(Data.Products.Update.EnteredName);
                            OleDbDataReader compareenteredcodereader = compareenteredcodecmd.ExecuteReader();
                            if (!compareenteredcodereader.Read())
                            {
                                MessageBox.Show($"Товар под названием {Data.Products.Update.EnteredName} не найден!", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                readen = false;
                            }
                            else
                            {
                                readen = true;
                                counternames = 1;
                                do
                                {
                                    Array.Resize(ref Data.Products.Update.SelectedNames, counternames);
                                    Data.Products.Update.SelectedNames[counternames - 1] = Convert.ToString(compareenteredcodereader[5]);
                                    counternames++;
                                }
                                while (compareenteredcodereader.Read());
                                string codes = null;
                                for (int f = 0; f < Data.Products.Update.SelectedNames.Length; f++)
                                {
                                    codes = Data.Products.Update.SelectedNames[f] + "\r\n";
                                }
                                if (readen)
                                {
                                    if (counternames == 1)
                                    {
                                        MessageBox.Show($"Обноружен {Convert.ToString(counternames - 1)} товар под именем {Data.Products.Update.EnteredName}\r\nКод товара\r\n{codes}", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Обноружено {Convert.ToString(counternames - 1)} товаров под именем {Data.Products.Update.EnteredName}\r\nКоды товаров\r\n{codes}", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    CB_Products_Update.Items.Clear();
                                    CB_Products_Update.Items.Add(Convert.ToString(Data.Products.Update.EnteredName));
                                    CB_Products_Update.SelectedIndex = 0;
                                }
                            }
                            compareenteredcodereader.Close();
                        }
                        break;
                    }
            }
        }
        public void UpdateProductAdd_Values()
        {
            TB_ProductName.Clear();
            B_GetCategoryData.Enabled = false;
            CB_GetCategories.Items.Clear();
            CB_GetCategories.Text = String.Empty;
            CB_GetCategories.Enabled = false;
            B_SelectCategory.Enabled = false;
            CHB_CountOver100.Enabled = false;
            CHB_CountOver100.Checked = false;
            CHB_PriceOver100.Enabled = false;
            CHB_PriceOver100.Checked = false;
            NUD_Price.Enabled = false;
            NUD_Price.Value = 1;
            NUD_Count.Enabled = false;
            NUD_Count.Value = 1;
            B_GenerateUniqueID.Enabled = EnableCodeGenerator(1);
            TB_UniqueCode.Clear();
            B_ApplyData.Enabled = false;
        }
        private void B_UpdatePanel_Click(object sender, EventArgs e)
        {
            switch (DialogResult = MessageBox.Show("Вернуть данные в исходное состояние?", $"{Config.Managers[2]}", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    {
                        UpdateProductAdd_Values();
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
            }
        }
        private void B_AcceptChoice_Delete_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionMF);
            CB_Products_Delete.Items.Clear();
            switch (Data.Products.SearchWithUniqueCode[2])
            {
                case 0:
                    {
                        bool readen = false;
                        Data.Products.Delete.EnteredCode = Convert.ToString(TB_InputDataForSearch_Delete.Text);
                        string compareenteredcodequery = $"SELECT * FROM {Options.Table[1]} WHERE Код = @EnteredCode";
                        using (OleDbCommand compareenteredcodecmd = new OleDbCommand(compareenteredcodequery, ConnectionMF))
                        {
                            compareenteredcodecmd.Parameters.Add("@EnteredCode", OleDbType.VarChar).Value = Convert.ToString(Data.Products.Delete.EnteredCode);
                            OleDbDataReader compareenteredcodereader = compareenteredcodecmd.ExecuteReader();
                            if (!compareenteredcodereader.Read())
                            {
                                MessageBox.Show($"Товар под кодом {Data.Products.Delete.EnteredCode} не найден!", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            }
                            else
                            {
                                try
                                {
                                    Data.Products.Delete.SelectedName = Convert.ToString(compareenteredcodereader[1]);
                                    readen = true;
                                }
                                catch (Exception ex)
                                {
                                    Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                                    readen = false;
                                }
                                finally
                                {
                                    if (readen)
                                    {
                                        DialogResult = MessageBox.Show($"Товар {Data.Products.Delete.SelectedName} обноружен под кодом {Data.Products.Delete.EnteredCode} ", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        if (DialogResult == DialogResult.OK)
                                        {
                                            CB_Products_Delete.Items.Clear();
                                            CB_Products_Delete.Items.Add(Data.Products.Delete.SelectedName);
                                        }
                                    }
                                }
                            }
                            compareenteredcodereader.Close();
                        }
                        CHB_SelectAll_Delete.Checked = false;
                        CHB_SelectAll_Delete.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        Data.Products.Delete.SelectedCategory = Convert.ToString(CB_CategorySearch_Delete.SelectedItem);
                        GB_SelectProduct_Delete.Visible = true;
                        Array.Resize(ref Data.Products.Delete.ProductsByCategory, 0);
                        string getproductsbycategoryquery = $"SELECT * FROM {Options.Table[1]} WHERE Категория = @Category";
                        using (OleDbCommand getproductsbycategorycmd = new OleDbCommand(getproductsbycategoryquery, ConnectionMF))
                        {
                            getproductsbycategorycmd.Parameters.Add("@Category", OleDbType.VarChar).Value = Convert.ToString(Data.Products.Delete.SelectedCategory);
                            using (OleDbDataReader getproductsbycategoryreader = getproductsbycategorycmd.ExecuteReader())
                            {
                                if (getproductsbycategoryreader.Read())
                                {
                                    int index = 0;
                                    do
                                    {
                                        Array.Resize(ref Data.Products.Delete.ProductsByCategory, Data.Products.Delete.ProductsByCategory.Length + 1);
                                        Data.Products.Delete.ProductsByCategory[index] = Convert.ToString(getproductsbycategoryreader.GetValue(1));
                                        index++;
                                    }
                                    while (getproductsbycategoryreader.Read());
                                }
                            }
                            for (int u = 0; u < Data.Products.Delete.ProductsByCategory.Length; u++)
                            {
                                CB_Products_Delete.Items.Add(Convert.ToString(Data.Products.Delete.ProductsByCategory[u]));
                            }
                        }
                        CHB_SelectAll_Delete.Checked = true;
                        CHB_SelectAll_Delete.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        int counternames = 0;
                        bool readen = false;
                        Data.Products.Delete.EnteredName = Convert.ToString(TB_InputDataForSearch_Delete.Text);
                        string compareenteredcodequery = $"SELECT * FROM {Options.Table[1]} WHERE Название = @EnteredName";
                        using (OleDbCommand compareenteredcodecmd = new OleDbCommand(compareenteredcodequery, ConnectionMF))
                        {
                            compareenteredcodecmd.Parameters.Add("@EnteredName", OleDbType.VarChar).Value = Convert.ToString(Data.Products.Delete.EnteredName);
                            OleDbDataReader compareenteredcodereader = compareenteredcodecmd.ExecuteReader();
                            if (!compareenteredcodereader.Read())
                            {
                                MessageBox.Show($"Товар под названием {Data.Products.Delete.EnteredName} не найден!", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                readen = false;
                            }
                            else
                            {
                                readen = true;
                                counternames = 1;
                                do
                                {
                                    Array.Resize(ref Data.Products.Delete.SelectedNames, counternames);
                                    Data.Products.Delete.SelectedNames[counternames - 1] = Convert.ToString(compareenteredcodereader[5]);
                                    counternames++;
                                }
                                while (compareenteredcodereader.Read());
                                string codes = null;
                                for (int f = 0; f < Data.Products.Delete.SelectedNames.Length; f++)
                                {
                                    codes = Data.Products.Delete.SelectedNames[f] + "\r\n";
                                }
                                if (readen)
                                {
                                    if (counternames == 1)
                                    {
                                        MessageBox.Show($"Обноружен {Convert.ToString(counternames - 1)} товар под именем {Data.Products.Delete.EnteredName}\r\nКод товара\r\n{codes}", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show($"Обноружено {Convert.ToString(counternames - 1)} товаров под именем {Data.Products.Delete.EnteredName}\r\nКоды товаров\r\n{codes}", $"{Config.Managers[1]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                            CHB_SelectAll_Delete.Checked = false;
                            CHB_SelectAll_Delete.Enabled = false;
                            compareenteredcodereader.Close();
                        }
                        break;
                    }
            }

        }

        private void B_RedactChoosenProduct_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionMF);
            bool IDreaden = false;
            Data.Products.Update.ChoosenName = Convert.ToString(CB_Products_Update.SelectedItem);
            string getIDbynamequery = $"SELECT * FROM {Options.Table[1]} WHERE Название = @Name";
            try
            {
                using (OleDbCommand getIDbynamecmd = new OleDbCommand(getIDbynamequery, ConnectionMF))
                {
                    getIDbynamecmd.Parameters.Add("@Name", OleDbType.VarChar).Value = Convert.ToString(Data.Products.Update.ChoosenName);
                    OleDbDataReader getIdbynamereader = getIDbynamecmd.ExecuteReader();
                    if (getIdbynamereader.Read())
                    {
                        Data.Products.Update.SelectedID = Convert.ToInt32(getIdbynamereader[0]);
                    }
                    getIdbynamereader.Close();
                    IDreaden = true;
                }
            }
            catch (Exception ex)
            {
                Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                IDreaden = false;
            }
            finally
            {
                if (IDreaden)
                {
                    ProductUpdate IPU = new ProductUpdate();
                    IPU.Show();
                }
            }
        }
        private void B_ProductDelete_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionMF);
            switch (DialogResult = MessageBox.Show($"Удалить {Data.Products.Delete.EnteredName} из базы данных?\r\rПосле удаления данные нельзя востоновить!", $"{Config.Managers[1]}", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    {
                        int deleted = -1;
                        try
                        {
                            switch (Data.Products.Delete.DeleteAll)
                            {
                                case false:
                                    {
                                        switch (Data.Products.SearchWithUniqueCode[2])
                                        {
                                            case 0:
                                                {
                                                    string deleteordinarquery = $"DELETE FROM {Options.Table[1]} WHERE Код = @Code";
                                                    using (OleDbCommand deleteordinarcmd = new OleDbCommand(deleteordinarquery, ConnectionMF))
                                                    {
                                                        deleteordinarcmd.Parameters.Add("@Code", OleDbType.VarChar).Value = Convert.ToString(Data.Products.Delete.EnteredCode);
                                                        deleteordinarcmd.ExecuteNonQuery();
                                                    }
                                                    break;
                                                }
                                            case 2:
                                                {
                                                    string deleteordinarquery = $"DELETE FROM {Options.Table[1]} WHERE Название = @Name";
                                                    using (OleDbCommand deleteordinarcmd = new OleDbCommand(deleteordinarquery, ConnectionMF))
                                                    {
                                                        deleteordinarcmd.Parameters.Add("@Name", OleDbType.VarChar).Value = Convert.ToString(Data.Products.Delete.SelectedName = Convert.ToString(CB_Products_Delete.SelectedItem));
                                                        deleteordinarcmd.ExecuteNonQuery();
                                                    }
                                                    break;
                                                }
                                        }
                                        break;
                                    }
                                case true:
                                    {
                                        string selectidquery = $"SELECT * FROM {Options.Table[1]} WHERE Название = @Name";
                                        using (OleDbCommand selectcmd = new OleDbCommand(selectidquery, ConnectionMF))
                                        {
                                            selectcmd.Parameters.Add("@Name", OleDbType.VarChar).Value = Convert.ToString(Data.Products.Delete.SelectedName);
                                            using (OleDbDataReader selectreader = selectcmd.ExecuteReader())
                                            {
                                                if (selectreader.Read())
                                                {
                                                    Array.Resize(ref Data.Products.Delete.SelectedNamesIDs, 0);
                                                    int count = 1;
                                                    do
                                                    {
                                                        Array.Resize(ref Data.Products.Delete.SelectedNamesIDs, count);
                                                        Data.Products.Delete.SelectedNamesIDs[count - 1] = Convert.ToInt32(selectreader[0]);
                                                        count++;
                                                    }
                                                    while (selectreader.Read());
                                                    for (int i = 0; i < Data.Products.Delete.SelectedNames.Length; i++)
                                                    {
                                                        string deletequery = $"DELETE FROM {Options.Table[1]} WHERE ID = @ID";
                                                        using (OleDbCommand deletecmd = new OleDbCommand(deletequery, ConnectionMF))
                                                        {
                                                            deletecmd.Parameters.Add("@ID", OleDbType.Integer).Value = Convert.ToInt32(Data.Products.Delete.SelectedNamesIDs[i]);
                                                            deletecmd.ExecuteNonQuery();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                            }
                            deleted = 0;
                        }
                        catch (Exception ex)
                        {
                            Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                            deleted = 1;
                        }
                        finally
                        {
                            Handlers.InformationProvider.DataOperationState(deleted, 2, 1);
                        }
                        break;
                    }
            }
        }

        private void B_SelectName_Delete_Click(object sender, EventArgs e)
        {
            Data.Products.Delete.SelectedName = Convert.ToString(CB_Products_Delete.SelectedItem);
        }

        private void TSMI_ConnectionStatus_Click(object sender, EventArgs e)
        {
            if (!Config.Debug.DebugModON)
            {
                if (Config.Debug.DebugUnloackCount != 0)
                {
                    Config.Debug.DebugUnloackCount--;
                }
                else
                {
                    Config.Debug.DebugModON = true;
                }
            }
            else
            {
                TSMI_DebugMode.Visible = true;
            }
        }

        private void TSMI_DEBUG_ADDCATEGORY_Click(object sender, EventArgs e)
        {
            if (ConnectionMF.State != ConnectionState.Open)
            {
                ConnectionMF.Open();
                ADD_DEBUGDATA(0);
                ConnectionMF.Close();
            }
            else
            {
                ADD_DEBUGDATA(0);
            }
        }
        public void ADD_DEBUGDATA(int index)
        {
            switch (index)
            {
                case 0:
                    {
                        string insert = $"INSERT INTO {Options.Table[0]} (Название, Количество) VALUES (@V1, @V2)";
                        using (OleDbCommand cmd = new OleDbCommand(insert, ConnectionMF))
                        {
                            cmd.Parameters.Add("@V1", OleDbType.VarChar).Value = Convert.ToString($"TestCategory{Convert.ToString(Config.Debug.DataCounter[0])}");
                            cmd.Parameters.Add("@V2", OleDbType.VarChar).Value = Convert.ToString(1);
                            cmd.ExecuteNonQuery();
                            Config.Debug.DataCounter[0]++;
                        }
                        break;
                    }
                case 1:
                    {
                        string insertquery = $"INSERT INTO {Options.Table[1]} (Название, Категория, Количество, Цена, Код, Изменение) VALUES (@Name, @Category, @Count, @Price, @Code, @Date)";
                        using (OleDbCommand insertcmd = new OleDbCommand(insertquery, ConnectionMF))
                        {
                            insertcmd.Parameters.Add("@Name", OleDbType.VarChar).Value = Convert.ToString($"TestProduct{Convert.ToString(Config.Debug.DataCounter[1])}");
                            insertcmd.Parameters.Add("@Category", OleDbType.VarChar).Value = Convert.ToString($"TestCategory{Convert.ToString(Config.Debug.DataCounter[0] - 1)}");
                            insertcmd.Parameters.Add("@Count", OleDbType.Integer).Value = Convert.ToInt32("-1");
                            insertcmd.Parameters.Add("@Price", OleDbType.Integer).Value = Convert.ToInt32("-1");
                            insertcmd.Parameters.Add("@Code", OleDbType.VarChar).Value = Convert.ToString($"TEST-0000{Convert.ToString(Config.Debug.DataCounter[2])}");
                            insertcmd.Parameters.Add("@Date", OleDbType.DBDate).Value = Convert.ToDateTime(DateTime.MaxValue);
                            insertcmd.ExecuteNonQuery();
                            Config.Debug.DataCounter[1]++;
                            Config.Debug.DataCounter[2]++;
                        }
                        break;
                    }
            }
        }
        private void TSMI_DEBUG_ADDPRODUCT_Click(object sender, EventArgs e)
        {
            if (ConnectionMF.State != ConnectionState.Open)
            {
                ConnectionMF.Open();
                ADD_DEBUGDATA(1);
                ConnectionMF.Close();
            }
            else
            {
                ADD_DEBUGDATA(1);
            }
        }

        private void TSMI_Info_Click(object sender, EventArgs e)
        {
            InfoBox IB = new InfoBox();
            IB.Show();
        }
    }
}
