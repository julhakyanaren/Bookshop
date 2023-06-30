using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
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
            Methods.LoadComponents();
            ChangeConnectionState();
            BindingSource BindingSource = new BindingSource();
            var columnHeaderStyle = DGV_CM_Category.ColumnHeadersDefaultCellStyle;
            columnHeaderStyle.BackColor = Color.SandyBrown;
            columnHeaderStyle.ForeColor = Color.Black;
            DGV_CM_Category.Refresh();
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
            bool nameexist;
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
                        nameexist = false;
                        break;
                    }
                case > 0:
                    {
                        excaption = false;
                        for (int i = 0; i < rowscount; i++)
                        {
                            string query = "SELECT @Column FROM @Table WHERE ID = @Value";
                            OleDbCommand cmd = new OleDbCommand(query, ConnectionCM);
                            cmd.Parameters.Add("@Column", OleDbType.VarChar).Value = "Название";
                            cmd.Parameters.Add("@Table", OleDbType.VarChar).Value = "Category";
                            cmd.Parameters.Add("@Value", OleDbType.Variant).Value = Convert.ToInt32(i);
                            try
                            {
                                OleDbDataReader reader = cmd.ExecuteReader();
                                if (!reader.Read())
                                {
                                    reader.Close();
                                    nameexist = false;
                                    continue;
                                }
                                else
                                {
                                    nameexist = true;
                                    reader.Close();
                                    break;
                                }
                            }
                            catch (Exception ex)
                            {
                                Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                            }
                        }
                        if (excaption)
                        {
                            //Ошибка
                        }
                        else
                        {
                            switch (excaption)
                            {
                                case true:
                                    {
                                        break;
                                    }
                                case false:
                                    {
                                        break;
                                    }
                            }

                        }
                        break;
                    }
            }
        }
    }
}
