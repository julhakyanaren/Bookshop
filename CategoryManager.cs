using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            this.TA_CategoryBS.Fill(this.BSDataSetBM.Category);
            //Methods.LoadComponents();
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
            int rowscount = Connections.Direct.Query.GetRowsCount(tablename, ConnectionCM);
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
                Data.Categories.IDCount = Connections.Direct.Query.GetRowsCount(Table, ConnectionCM);
                Data.Categories.LastID = Data.Categories.FirstID + Data.Categories.IDCount - 1;
                bool successfullinsert = false;
                string newcategoryinsertquery = "INSERT INTO " + Table + " (ID, Название, Количество) VALUES (@Value1, @Value2, @Value3)";
                OleDbCommand newcategoryinsertcmd = new OleDbCommand (newcategoryinsertquery, ConnectionCM);
                newcategoryinsertcmd.Parameters.Add("@Values", OleDbType.VarChar).Value = Convert.ToString(Data.Categories.LastID + 1);
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

        private void B_CM_GetCategory_Click(object sender, EventArgs e)
        {
            string selectquery;
            string tablename = "Category";
            bool readen = false;
            int rowscount = Connections.Direct.Query.GetRowsCount(tablename, ConnectionCM);
            Array.Resize(ref Data.Categories.ExistingNames, 0);
            for (int r = 0; r < rowscount; r++)
            {
                selectquery = "SELECT * FROM " + tablename + " WHERE ID = " + Convert.ToString(r + 1) + "";
                OleDbCommand selectcmd = new OleDbCommand(selectquery, ConnectionCM);
                try
                {
                    OleDbDataReader selectreader = selectcmd.ExecuteReader();
                    while (selectreader.Read())
                    {
                        Array.Resize(ref Data.Categories.ExistingNames, Data.Categories.ExistingNames.Length + 1);
                        Data.Categories.ExistingNames[r] = Convert.ToString(selectreader[1]);
                    }
                    selectreader.Close();
                    readen = true;
                }
                catch (Exception ex)
                {
                    Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                    readen = false;
                }
            }
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

        private void B_CM_UpdateDable_Click(object sender, EventArgs e)
        {
            string Table = "Category";
            string script = "SELECT * FROM " + Table + "";
            OleDbDataAdapter adapter = new OleDbDataAdapter(script, ConnectionCM);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DGV_CM_Category.DataSource = table;          
        }

        private void B_CM_CheckNewName_Click(object sender, EventArgs e)
        {
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
                int rowscount = Connections.Direct.Query.GetRowsCount(tablename, ConnectionCM);
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
                            excaption = false;
                            string Table = "Category";
                            for (int i = 0; i < rowscount; i++)
                            {
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
                                        Config.NameExist[1] = false;
                                        continue;
                                    }
                                    else
                                    {
                                        Config.NameExist[1] = true;
                                        reader.Close();
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
                    switch (Config.NameExist[1])
                    {
                        case true:
                            {
                                break;
                            }
                        case false:
                            {
                                B_CM_CategoryRename.Enabled = true;
                                break;
                            }
                    }
                }
            }
        }

        private void B_CM_CategoryRename_Click(object sender, EventArgs e)
        {
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
                Data.Categories.OldName = CB_CM_Categories.SelectedItem.ToString();
                bool IDreaden = false;
                bool renamed = false;
                string Table = "Category";
                string ID = null;
                string findrowIDquery = "SELECT * FROM " + Table + " WHERE Название = @Value1";
                OleDbCommand findrowIDcmd = new OleDbCommand(findrowIDquery, ConnectionCM);
                findrowIDcmd.Parameters.Add("@Value", OleDbType.VarChar).Value = Data.Categories.OldName;
                try
                {
                    OleDbDataReader findrowIDreader = findrowIDcmd.ExecuteReader();
                    while (findrowIDreader.Read())
                    {
                        ID = Convert.ToString(findrowIDreader[0]);
                        IDreaden = true;
                    }
                    findrowIDreader.Close();
                    if (IDreaden)
                    {
                        string renamequery = "UPDATE " + Table + "SET Название = @P1 WHERE ID = @Value2";
                        OleDbCommand renamecmd = new OleDbCommand(renamequery, ConnectionCM);
                        renamecmd.Parameters.Add("@Value2", OleDbType.VarChar).Value = Convert.ToString(ID);
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
                            OleDbCommand deletecmd = new OleDbCommand(deletequery, ConnectionCM);
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
                            bool IDupdated = false;
                            try
                            {
                                string Table = "Category";
                                int rowscount = Connections.Direct.Query.GetRowsCount(Table, ConnectionCM);
                                Array.Resize(ref Data.Categories.NameByID, rowscount);
                                for (int d = 1; d <= rowscount; d++)
                                {
                                    string namesbyIDquery = "SELECT * FROM " + Table + " WHERE ID = @ID1";
                                    OleDbCommand namesbyIDcmd = new OleDbCommand(namesbyIDquery, ConnectionCM);
                                    namesbyIDcmd.Parameters.Add("@ID1", OleDbType.VarChar).Value = Convert.ToString(d);
                                    OleDbDataReader namesbyIDreader = namesbyIDcmd.ExecuteReader();
                                    if (namesbyIDreader.Read())
                                    {
                                        Data.Categories.NameByID[d - 1] = Convert.ToString(namesbyIDreader[1]);
                                    }
                                    else
                                    {
                                        rowscount++;
                                        d++;
                                        continue;
                                    }
                                    namesbyIDreader.Close();
                                }
                                IDupdated = true;

                            }
                            catch (Exception ex)
                            {
                                Handlers.ErrorProvider.ExcaptionShowMessages(ex, 3);
                                IDupdated = false;
                            }
                            finally
                            {
                                if (IDupdated)
                                {
                                    CB_CM_Categories.Items.Clear();
                                    //Array.Resize(ref Data.Categories.ExistingNames, 1);
                                    Array.Resize(ref Data.Categories.ExistingNames, 0);
                                    Handlers.InformationProvider.DataOperationState(0, 2, 1);
                                }
                                else
                                {
                                    Handlers.InformationProvider.DataOperationState(1, 2, 1);
                                }
                            }
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
    }
}
