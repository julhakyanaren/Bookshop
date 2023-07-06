using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using DAO = Microsoft.Office.Interop.Access.Dao;

namespace Bookshop
{
    public partial class CategoryManager : Form
    {
        OleDbConnection ConnectionCM = Connections.Direct.Connection;
        public CategoryManager()
        {
            InitializeComponent();
        }
        public void SetFormDesignConfiguration()
        {
            L_Info_AddCategory.Location = new Point((PNL_CM_ControlElements.Width - L_Info_AddCategory.Width) / 2, 0);
            L_Info_RedactCategory.Location = new Point((PNL_CM_ControlElements.Width - L_Info_RedactCategory.Width) / 2, 0);
        }
        public void ChangeConnectionState()
        {
            Connections.Direct.DB_Connect(ConnectionCM);
            if (ConnectionCM.State == ConnectionState.Open)
            {
                TSMI_CM_Status.Text = "Подключено";
                TSMI_CM_Status.ForeColor = Color.Green;
                TSMI_CM_Connect.Text = "Отключить";
            }
            else
            {
                TSMI_CM_Status.Text = "Не Подключено";
                TSMI_CM_Status.ForeColor = Color.Firebrick;
                TSMI_CM_Connect.Text = "Подключить";
            }
        }
        private void CategoryManager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bSDBDataSet.Category". При необходимости она может быть перемещена или удалена.
            this.categoryTableAdapter.Fill(this.bSDBDataSet.Category);
            ChangeConnectionState();
            BindingSource BindingSource = new BindingSource();
            var columnHeaderStyle = DGV_CM_Category.ColumnHeadersDefaultCellStyle;
            columnHeaderStyle.BackColor = Color.SandyBrown;
            columnHeaderStyle.ForeColor = Color.Black;
            DGV_CM_Category.Refresh();
            Options.FormOpened[1] = true;
            Methods.FormsStateRegister();
        }
        private void TSMI_CM_CheckConnection_Click(object sender, EventArgs e)
        {
            bool connected = false;
            switch (ConnectionCM.State)
            {
                case ConnectionState.Open:
                    {
                        connected = true;
                        break;
                    }
                case ConnectionState.Closed:
                    {
                        connected = false;
                        break;
                    }
            }
            Connections.Direct.StatusToMB(connected);
        }

        private void TSMI_CM_Connect_Click(object sender, EventArgs e)
        {
            switch (ConnectionCM.State)
            {
                case ConnectionState.Open:
                    {
                        Connections.Direct.DB_Dissconnect(ConnectionCM);
                        break;
                    }
                case ConnectionState.Closed:
                    {
                        Connections.Direct.DB_Connect(ConnectionCM);
                        break;
                    }
            }
            if (ConnectionCM.State == ConnectionState.Open)
            {
                TSMI_CM_Status.Text = "Подключено";
                TSMI_CM_Status.ForeColor = Color.Green;
                TSMI_CM_Connect.Text = "Отключить";
            }
            else
            {
                TSMI_CM_Status.Text = "Не Подключено";
                TSMI_CM_Status.ForeColor = Color.Firebrick;
                TSMI_CM_Connect.Text = "Подключить";
            }
        }

        private void TSMI_TopMost_Click(object sender, EventArgs e)
        {
            switch (TSMI_CM_TopMost.Checked)
            {
                case true:
                    {
                        TopMost = true;
                        break;
                    }
                case false:
                    {
                        TopMost = false;
                        break;
                    }
            }
        }

        public void B_CM_Check_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionCM);
            Data.Categories.EnteredName[0] = Convert.ToString(TB_CategoryName.Text);
            if (Data.Categories.EnteredName[0] == String.Empty)
            {
                DialogResult = MessageBox.Show("Пустое поле ввода", "Диспечер данных", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (DialogResult == DialogResult.OK)
                {
                    TB_CategoryName.Focus();
                }
            }
            bool excaption;
            string tablename = "Category";
            int rowscount = Connections.Direct.Queries.GetRowsCount(tablename, ConnectionCM);
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
                        Config.NameExist[0] = false;
                        break;
                    }
                case > 0:
                    {
                        excaption = false;
                        for (int i = 1; i <= rowscount; i++)
                        {
                            string Table = "Category";
                            string query = "SELECT @Column FROM " + Table + " WHERE ID = @Value";
                            OleDbCommand cmd = new OleDbCommand(query, ConnectionCM);
                            cmd.Parameters.Add("@Column", OleDbType.VarChar).Value = "Название";
                            cmd.Parameters.Add("@Value", OleDbType.Variant).Value = Convert.ToInt32(i);
                            try
                            {
                                OleDbDataReader reader = cmd.ExecuteReader();
                                if (!reader.Read())
                                {
                                    reader.Close();
                                    Config.NameExist[0] = false;
                                    continue;
                                }
                                else
                                {
                                    reader.Close();
                                    string readendata = Convert.ToString(cmd.ExecuteScalar());
                                    if (readendata == Data.Categories.EnteredName[0])
                                    {
                                        Config.NameExist[0] = true;
                                        reader.Close();
                                    }
                                    else
                                    {
                                        Config.NameExist[0] = false;
                                        reader.Close();
                                        continue;
                                    }
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {
                                Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                            }
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
                switch (Config.NameExist[0])
                {
                    case true:
                        {
                            break;
                        }
                    case false:
                        {
                            B_CM_Add.Enabled = true;
                            break;
                        }
                }
            }
        }

        private void B_CM_Add_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionCM);
            Data.Categories.EnteredName[1] = Convert.ToString(TB_CategoryName.Text);
            if (Data.Categories.EnteredName[0] != Data.Categories.EnteredName[1])
            {
                DialogResult = MessageBox.Show("Введённое имя категории не было проверено\r\nПроверьте имя до записи в БД", "Диспечер данных", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (DialogResult == DialogResult.OK)
                {
                    TB_CategoryName.Focus();
                    B_CM_Add.Enabled = false;
                }
            }
            else
            {
                string Table = "Category";
                Data.Categories.IDCount = Connections.Direct.Queries.GetRowsCount(Table, ConnectionCM);
                Data.Categories.LastID = Data.Categories.FirstID + Data.Categories.IDCount - 1;
                bool successfullinsert = false;
                string newcategoryinsertquery = "INSERT INTO " + Table + " (Название, Количество) VALUES (@Value2, @Value3)"; //@Value1
                using (OleDbCommand newcategoryinsertcmd = new OleDbCommand(newcategoryinsertquery, ConnectionCM))
                {
                    newcategoryinsertcmd.Parameters.Add("@Value2", OleDbType.VarChar).Value = Convert.ToString(Data.Categories.EnteredName[0]);
                    newcategoryinsertcmd.Parameters.Add("@Value3", OleDbType.VarChar).Value = Convert.ToString(0);
                    try
                    {
                        newcategoryinsertcmd.ExecuteNonQuery();
                        successfullinsert = true;
                    }
                    catch (Exception ex)
                    {
                        Handlers.ErrorProvider.ExcaptionShowMessages(ex, 2);
                        successfullinsert = false;
                    }
                    finally
                    {
                        if (successfullinsert)
                        {
                            Handlers.InformationProvider.DataOperationState(0, 0, 1);
                            TB_CategoryName.Clear();
                            B_CM_Add.Enabled = false;
                        }
                        else
                        {
                            Handlers.InformationProvider.DataOperationState(1, 0, 1);
                            TB_CategoryName.Clear();
                            B_CM_Add.Enabled = false;
                        }
                    }
                }
                
            }
        }

        private void B_CM_GetCategory_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionCM);
            CB_CM_Categories.Items.Clear();
            string Table = "Category";
            bool readen = false;
            int rowscount = Connections.Direct.Queries.GetRowsCount(Table, ConnectionCM);
            Array.Resize(ref Data.Categories.ExistingNames, 0);
            string selectallnamesquery = "SELECT * FROM " + Table + " WHERE ID > 0";
            try
            {
                using (OleDbCommand selectallnamescmd = new OleDbCommand(selectallnamesquery, ConnectionCM))
                {
                    using (OleDbDataReader selectallnamesreader = selectallnamescmd.ExecuteReader())
                    {
                        while (selectallnamesreader.Read())
                        {
                            CB_CM_Categories.Items.Add(Convert.ToString(selectallnamesreader[1]));
                        }
                    }
                }
                int lenght = CB_CM_Categories.Items.Count;
                Array.Resize(ref Data.Categories.ExistingNames, lenght);
                for (int l = 0; l < lenght; l++)
                {
                    Data.Categories.ExistingNames[l] = Convert.ToString(CB_CM_Categories.Items[l]);
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
                    CB_CM_Categories.Items.Clear();
                    for (int i = 0; i < Data.Categories.ExistingNames.Length; i++)
                    {
                        CB_CM_Categories.Items.Add(Convert.ToString(Data.Categories.ExistingNames[i]));
                    }
                    Handlers.InformationProvider.DataOperationState(0, 3, 1);
                }
                else
                {
                    CB_CM_Categories.Items.Clear();
                    Handlers.InformationProvider.DataOperationState(1, 3, 1);
                }
            }
        }

        private void B_CM_UpdateDable_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionCM);
            string Table = "Category";
            string script = "SELECT * FROM " + Table + "";
            OleDbDataAdapter adapter = new OleDbDataAdapter(script, ConnectionCM);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DGV_CM_Category.DataSource = table;          
        }

        private void B_CM_CheckNewName_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionCM);
            Data.Categories.NewName[0] = Convert.ToString(TB_CM_NewCategoryName.Text);
            if (Data.Categories.NewName[0] == String.Empty)
            {
                DialogResult = MessageBox.Show("Пустое поле ввода", "Диспечер данных", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (DialogResult == DialogResult.OK)
                {
                    TB_CM_NewCategoryName.Focus();
                }
            }
            else
            {
                bool excaption;
                string tablename = "Category";
                int rowscount = Connections.Direct.Queries.GetRowsCount(tablename, ConnectionCM);
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
                            Config.NameExist[1] = false;
                            break;
                        }
                    case > 0:
                        {
                            excaption = true;
                            try
                            {
                                string Table = "Category";
                                string comparenamesquery = $"SELECT ID FROM {Table} WHERE @Name = @EnteredName";
                                using (OleDbCommand comparenamescmd = new OleDbCommand(comparenamesquery, ConnectionCM))
                                {
                                    comparenamescmd.Parameters.Add("@Name", OleDbType.VarChar).Value = "Название";
                                    comparenamescmd.Parameters.Add("@EnteredName", OleDbType.VarChar).Value = Convert.ToString(Data.Categories.NewName[0]);
                                    using (OleDbDataReader comparenamesreader = comparenamescmd.ExecuteReader())
                                    {
                                        if (comparenamesreader.Read())
                                        {
                                            Config.NameExist[1] = true;
                                        }
                                        else
                                        {
                                            Config.NameExist[1] = false;
                                        }
                                    }
                                }
                                excaption = false;
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
                    switch (Config.NameExist[1])
                    {
                        case true:
                            {
                                break;
                            }
                        case false:
                            {
                                Data.Categories.OldName = CB_CM_Categories.SelectedItem.ToString();
                                B_CM_CategoryRename.Enabled = true;
                                break;
                            }
                    }
                }
            }
        }

        private void B_CM_CategoryRename_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionCM);
            Data.Categories.NewName[1] = Convert.ToString(TB_CM_NewCategoryName.Text);
            if (Data.Categories.NewName[0] != Data.Categories.NewName[1])
            {
                DialogResult = MessageBox.Show("Введённое имя категории не было проверено\r\nПроверьте имя до записи в БД", "Диспечер данных", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (DialogResult == DialogResult.OK)
                {
                    CB_CM_Categories.Focus();
                    B_CM_CategoryRename.Enabled = false;
                }
            }
            else
            {
                bool renamed = false;
                try
                {
                    string Table = "Category";
                    int ID = 0;
                    if (ID == 0)
                    {
                        string renamequery = $"UPDATE {Table} SET Название = @NewName WHERE Название = @OldName";
                        using (OleDbCommand renamecmd = new OleDbCommand(renamequery, ConnectionCM))
                        {
                            renamecmd.Parameters.Add("@NewName", OleDbType.VarChar).Value = Convert.ToString(Data.Categories.NewName[0]);
                            renamecmd.Parameters.Add("@OldName", OleDbType.VarChar).Value = Convert.ToString(Data.Categories.OldName);
                            renamecmd.ExecuteNonQuery();
                        }
                        renamed = true;
                    }
                    else
                    {
                        renamed = false;
                    }
                }
                catch (Exception ex)
                {
                    renamed = false;
                    Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                }
                finally
                {
                    if (renamed)
                    {
                        Handlers.InformationProvider.DataOperationState(0, 1, 1);
                    }
                    else
                    {
                        Handlers.InformationProvider.DataOperationState(1, 1, 1);
                    }
                }
            }
        }

        private void CategoryManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Закрыть Менеджер Категории?", "BookShop Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    {
                        if (ConnectionCM.State == ConnectionState.Open)
                        {
                            ConnectionCM.Close();
                        }
                        break;
                    }
                case DialogResult.No:
                    {
                        e.Cancel = true;
                        break;
                    }
            }
        }

        private void B_CM_Delete_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionCM);
            bool deleted = false;
            Data.Categories.OldName = Convert.ToString(CB_CM_Categories.SelectedItem);
            if (Data.Categories.OldName == String.Empty)
            {
                DialogResult = MessageBox.Show("Пустое поле ввода", "Диспечер данных", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (DialogResult == DialogResult.OK)
                {
                    CB_CM_Categories.Focus();
                }
            }
            else
            {
                switch (DialogResult = MessageBox.Show("Данная функция удалит категорию " + Data.Categories.OldName + "\r\nДанное действие нельзя отменить\r\n\r\nПродолжить?", "Диспечер данных", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        {
                            string Table = "Category";
                            string deletequery = "DELETE FROM " + Table + " WHERE Название = @Value";
                            using (OleDbCommand deletecmd = new OleDbCommand(deletequery, ConnectionCM))
                            {
                                deletecmd.Parameters.Add("@Value", OleDbType.VarChar).Value = Convert.ToString(Data.Categories.OldName);
                                try
                                {
                                    deletecmd.ExecuteNonQuery();
                                    deleted = true;
                                }
                                catch (Exception ex)
                                {
                                    Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                                    deleted = false;
                                }
                            }
                            
                            break;
                        }
                    case DialogResult.No:
                        {
                            deleted = false;
                            break;
                        }
                }
                switch (deleted)
                {
                    case true:
                        {
                            CB_CM_Categories.Items.Clear();
                            Array.Resize(ref Data.Categories.ExistingNames, 0);
                            Handlers.InformationProvider.DataOperationState(0, 2, 1);
                            break;
                        }
                    case false:
                        {
                            Handlers.InformationProvider.DataOperationState(1, 2, 1);
                            break;
                        }
                }
            }
        }
        private void B_CM_Turnicate_Click(object sender, EventArgs e)
        {
            Data.Categories.OldName = Convert.ToString(CB_CM_Categories.SelectedItem);
            if (Data.Categories.OldName == String.Empty)
            {
                DialogResult = MessageBox.Show("Пустое поле ввода", "Диспечер данных", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (DialogResult == DialogResult.OK)
                {
                    CB_CM_Categories.Focus();
                }
            }
            else
            {
                switch (DialogResult = MessageBox.Show("Данная функция полностью очистит БД категории\r\nДанное действие нельзя отменить\r\n\r\nПродолжить?", "Диспечер данных", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        {
                            bool turnicated = false;
                            string Table = "Category";
                            string[] TurnicateQuery = new string[2];
                            OleDbCommand[] TurnicateCommand = new OleDbCommand[2];
                            TurnicateQuery[0] = "DELETE FROM " + Table;
                            TurnicateQuery[1] = "DBCC CHECKIDENT ('" + Table + "', RESEED, 0)";
                            for (int c = 0; c < TurnicateQuery.Length; c++)
                            {
                                try
                                {
                                    TurnicateCommand[c] = new OleDbCommand(TurnicateQuery[c], ConnectionCM);
                                    TurnicateCommand[c].ExecuteNonQuery();
                                    turnicated = true;
                                }
                                catch (Exception ex)
                                {
                                    Handlers.ErrorProvider.ExcaptionShowMessages(ex, 4);
                                    turnicated = false;
                                    break;
                                }
                            }
                            if (turnicated)
                            {
                                Handlers.InformationProvider.DataOperationState(0, 2, 1);
                            }
                            else
                            {
                                Handlers.InformationProvider.DataOperationState(1, 2, 1);
                            }
                            break;
                        }
                    case DialogResult.No:
                        {
                            break;
                        }
                }
            }
        }

        private void B_CM_Delete_MouseEnter(object sender, EventArgs e)
        {
            switch (sender)
            {
                case Button B1 when B1 == B_CM_Delete:
                    {
                        B1.BackColor = Color.Salmon;
                        break;
                    }
                case Button B2 when B2 == B_CM_Turnicate:
                    {
                        B2.BackColor = Color.Salmon;
                        break;
                    }
            }
        }

        private void B_CM_Delete_MouseLeave(object sender, EventArgs e)
        {
            switch (sender)
            {
                case Button B1 when B1 == B_CM_Delete:
                    {
                        B1.BackColor = Color.SandyBrown;
                        break;
                    }
                case Button B2 when B2 == B_CM_Turnicate:
                    {
                        B2.BackColor = Color.SandyBrown;
                        break;
                    }
            }
        }
        private void TSMI_CM_SynchronizeData_Click(object sender, EventArgs e)
        {
            Connections.Direct.ConnectionStateReload(ConnectionCM);
            int updatedindex = 1;
            try
            {
                string[] categorynames = new string[0];
                int selector = 0;
                string getcategoriesquery = $"SELECT * FROM {Options.Table[0]} WHERE ID > 0";
                using (OleDbCommand getcategoriescmd = new OleDbCommand(getcategoriesquery, ConnectionCM))
                {
                    using (OleDbDataReader getcategoriesreader = getcategoriescmd.ExecuteReader())
                    {
                        if (getcategoriesreader.Read())
                        {
                            selector = 1;
                            do
                            {
                                Array.Resize(ref categorynames, selector);
                                categorynames[selector - 1] = getcategoriesreader.GetString(1);
                                selector++;
                            }
                            while (getcategoriesreader.Read());
                        }
                    }
                }
                int categoriescount = categorynames.Length;
                if (categoriescount > 0)
                {
                    int[] counts = new int[categoriescount];
                    string getdataquery = $"SELECT * FROM {Options.Table[1]} WHERE Категория = @Category";
                    using (OleDbCommand getdatacmd = new OleDbCommand(getdataquery, ConnectionCM))
                    {
                        for (int i = 0; i < categoriescount; i++)
                        {
                            getdatacmd.Parameters.Add("@Category", OleDbType.VarChar).Value = Convert.ToString(categorynames[i]);
                            using (OleDbDataReader getdatareader = getdatacmd.ExecuteReader())
                            {
                                if (getdatareader.Read())
                                {
                                    while (getdatareader.Read())
                                    {
                                        counts[i]++;
                                    }
                                }
                            }
                        }
                    }
                    int[] newcounts = new int[counts.Length];
                    for (int nc = 0; nc < counts.Length; nc++)
                    {
                        newcounts[nc] = counts[nc] + 1;
                    }
                    string updatecountquery = $"UPDATE {Options.Table[0]} SET Количество = @NewCount WHERE Название = @Category";
                    using (OleDbCommand updatecountcmd = new OleDbCommand(updatecountquery, ConnectionCM))
                    {
                        for (int u = 0; u < newcounts.Length; u++)
                        {
                            updatecountcmd.Parameters.Add("@Category", OleDbType.VarChar).Value = Convert.ToString(categorynames[u]);
                            updatecountcmd.Parameters.Add("@NewCount", OleDbType.VarChar).Value = Convert.ToString(newcounts[u]);
                            updatecountcmd.ExecuteNonQuery();
                        }
                    }
                }
                updatedindex = 0;
            }
            catch (Exception ex)
            {
                Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                updatedindex = 1;
            }
            finally
            {
                Handlers.InformationProvider.DataOperationState(updatedindex, 1, 1);
            }
        }
    }
}
