using Microsoft.Office.Interop.Access.Dao;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Access = Microsoft.Office.Interop.Access;

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
            SetLableInCenterOfPanel(L_Info_RedactRename, CHB_ProdRename_Code);
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
                TB_InpudDataForSearch_Update.Enabled = true;
                L_InfoCatregorySearch_Update.Visible = false;
                CB_CategorySearch_Update.Visible = false;
            }
            else
            {
                if (!CHB_ProdUpdate_ByName.Checked)
                {
                    TB_InpudDataForSearch_Update.Enabled = false;
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
                TB_InpudDataForSearch_Update.Enabled = false;
                L_InfoCatregorySearch_Update.Visible = true;
                CB_CategorySearch_Update.Visible = true;
            }
            else
            {
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
                TB_InpudDataForSearch_Update.Enabled = true;
                L_InfoCatregorySearch_Update.Visible = false;
                CB_CategorySearch_Update.Visible = false;
            }
            else
            {
                if (!CHB_ProdUpdate_ByCode.Checked)
                {
                    TB_InpudDataForSearch_Update.Enabled = false;
                }
            }
        }
        private void CHB_ProdRename_ByCode_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_ProdRename_ByCode.Checked)
            {
                CHB_ProdRename_ByCategory.Checked = false;
                CHB_ProdRename_ByName.Checked = false;
                Handlers.SetConfiguration.SetSearchTypeThrowCheckBox(CHB_ProdRename_ByCode, GB_SearchType_Rename);
                L_NameCode_Rename.Text = "Код";
                TB_InpudDataForSearch_Rename.Enabled = true;
                L_InfoCatregorySearch_Rename.Visible = false;
                CB_CategorySearch_Rename.Visible = false;
            }
            else
            {
                if (!CHB_ProdRename_ByName.Checked)
                {
                    TB_InpudDataForSearch_Rename.Enabled = false;
                }
            }
        }
        private void CHB_ProdRename_ByCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_ProdRename_ByCategory.Checked)
            {
                CHB_ProdRename_ByCode.Checked = false;
                CHB_ProdRename_ByName.Checked = false;
                Handlers.SetConfiguration.SetSearchTypeThrowCheckBox(CHB_ProdRename_ByCategory, GB_SearchType_Rename);
                L_NameCode_Rename.Text = "Код";
                TB_InpudDataForSearch_Rename.Enabled = false;
                L_InfoCatregorySearch_Rename.Visible = true;
                CB_CategorySearch_Rename.Visible = true;
            }
            else
            {
                L_InfoCatregorySearch_Rename.Visible = false;
                CB_CategorySearch_Rename.Visible = false;
            }
        }
        private void CHB_ProdRename_ByName_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_ProdRename_ByName.Checked)
            {
                CHB_ProdRename_ByCode.Checked = false;
                CHB_ProdRename_ByCategory.Checked = false;
                Handlers.SetConfiguration.SetSearchTypeThrowCheckBox(CHB_ProdRename_ByName, GB_SearchType_Rename);
                L_NameCode_Rename.Text = "Название";
                TB_InpudDataForSearch_Rename.Enabled = true;
                L_InfoCatregorySearch_Rename.Visible = false;
                CB_CategorySearch_Rename.Visible = false;
            }
            else
            {
                if (!CHB_ProdRename_ByCode.Checked)
                {
                    TB_InpudDataForSearch_Rename.Enabled = false;
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
                TB_InpudDataForSearch_Delete.Enabled = true;
                L_InfoCatregorySearch_Delete.Visible = false;
                CB_CategorySearch_Delete.Visible = false;
            }
            else
            {
                if (!CHB_ProdDelete_ByCode.Checked)
                {
                    TB_InpudDataForSearch_Delete.Enabled = false;
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
                TB_InpudDataForSearch_Delete.Enabled = false;
                L_InfoCatregorySearch_Delete.Visible = true;
                CB_CategorySearch_Delete.Visible = true;
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
                TB_InpudDataForSearch_Delete.Enabled = true;
                L_InfoCatregorySearch_Delete.Visible = false;
                CB_CategorySearch_Delete.Visible = false;
            }
            else
            {
                if (!CHB_ProdDelete_ByName.Checked)
                {
                    TB_InpudDataForSearch_Delete.Enabled = false;
                }
            }
        }

        private void CHB_SelectAll_Delete_CheckedChanged(object sender, EventArgs e)
        {
            if (CHB_SelectAll_Delete.Checked)
            {
                CB_Products_Delete.Enabled = false;
                CB_Products_Delete.Items.Clear();
                CB_Products_Delete.Text = "Удатиь все данные в категории";
                B_ProductDelete.Text = "Удалить товары";
            }
            else
            {
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
        }

        private void NUD_Count_ValueChanged(object sender, EventArgs e)
        {
            if (NUD_Count.Value >= NUD_Count.Maximum)
            {
                NUD_Count.Value = NUD_Count.Maximum;
            }

        }

        private void TSMI_Synchronize_Click(object sender, EventArgs e)
        {
            if (Connections.Direct.ConnectionReset(ConnectionMF))
            {
                string Table = "Categories";
                int categoriescount = Connections.Direct.Queries.GetRowsCount(Table, ConnectionMF);
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
                            while(getcategoriesreader.Read());
                        }
                    }
                }
            }
            else
            {
            }
        }
    }
}
