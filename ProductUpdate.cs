using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public partial class ProductUpdate : Form
    {
        public OleDbConnection ConnectionPU = Connections.Direct.Connection;
        public ProductUpdate()
        {
            InitializeComponent();
        }
        private void TSMI_PU_TopMost_Click(object sender, EventArgs e)
        {
            switch (TSMI_PU_TopMost.Checked)
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
        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            L_Timer.Text = DateTime.Now.ToString("HH:mm:ss");
            L_Timer.AutoSize = true;
            Timer_ForLable.Start();
            bool connected = false;
            Connections.Direct.ConnectionReset(ConnectionPU);
            if (ConnectionPU.State != ConnectionState.Open)
            {
                try
                {
                    Connections.Direct.DB_Connect(ConnectionPU);
                    connected = true;
                }
                catch (Exception ex)
                {
                    Handlers.ErrorProvider.ExcaptionShowMessages(ex, 0);
                    connected = false;
                }
                finally
                {
                    if (connected)
                    {
                        MessageBox.Show("Соеденение установлено", $"{Config.Managers[0]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TSMI_PU_Connection_OpenClose.Checked = true;
                        TSMI_PU_ConnectionStatus.Text = "Установлено";
                        TSMI_PU_ConnectionStatus.ForeColor = Color.Green;
                    }
                    else
                    {
                        MessageBox.Show("Соеденение не установлено", $"{Config.Managers[0]}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TSMI_PU_Connection_OpenClose.Checked = false;
                        TSMI_PU_ConnectionStatus.Text = "Не установлено";
                        TSMI_PU_ConnectionStatus.ForeColor = Color.Firebrick;
                    }

                }
            }
        }

        private void TSMI_PU_Synchronize_Click(object sender, EventArgs e)
        {
            int readendata = 1;
            string getalldatabyIDquery = $"SELECT * FROM {Options.Table[1]} WHERE ID = @ID";
            try
            {
                using (OleDbCommand getalldatabyIDcmd = new OleDbCommand(getalldatabyIDquery, ConnectionPU))
                {
                    getalldatabyIDcmd.Parameters.Add("@ID", OleDbType.Integer).Value = Convert.ToInt32(Data.Products.Update.SelectedID);
                    using (OleDbDataReader getalldatabyIDreader = getalldatabyIDcmd.ExecuteReader())
                    {
                        while (getalldatabyIDreader.Read())
                        {
                            Data.Products.Update.RedactName[0] = Convert.ToString(getalldatabyIDreader[1]);
                            Data.Products.Update.RedactCategory[0] = Convert.ToString(getalldatabyIDreader[2]);
                            Data.Products.Update.RedactCount[0] = Convert.ToInt32(getalldatabyIDreader[3]);
                            Data.Products.Update.RedactPrice[0] = Convert.ToInt32(getalldatabyIDreader[4]);
                            Data.Products.Update.RedactCode[0] = Convert.ToString(getalldatabyIDreader[5]);
                            Data.Products.Update.RedactDate[0] = Convert.ToDateTime(getalldatabyIDreader[6]);
                        }
                    }
                }
                readendata = 0;
            }
            catch (Exception ex)
            {
                Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                readendata = 0;
            }
            finally
            {
                Handlers.InformationProvider.DataOperationState(readendata, 3, 1);
                switch (readendata)
                {
                    case 0:
                        {
                            TB_Old_ProductName.Text = Convert.ToString(Data.Products.Update.RedactName[0]);
                            TB_Old_ProductCategory.Text = Convert.ToString(Data.Products.Update.RedactCategory[0]);
                            TB_Old_ProductCount.Text = Convert.ToString(Data.Products.Update.RedactCount[0]);
                            TB_Old_ProductPrice.Text = Convert.ToString(Data.Products.Update.RedactPrice[0]);
                            TB_Old_ProductCode.Text = Convert.ToString(Data.Products.Update.RedactCode[0]);
                            TB_Old_ProductDate.Text = Convert.ToString(Data.Products.Update.RedactDate[0]);
                            break;
                        }
                    case 1:
                        {
                            TB_Old_ProductName.Text = Convert.ToString("Н / Д");
                            TB_Old_ProductCategory.Text = Convert.ToString("Н / Д");
                            TB_Old_ProductCount.Text = Convert.ToString("Н / Д");
                            TB_Old_ProductPrice.Text = Convert.ToString("Н / Д");
                            TB_Old_ProductCode.Text = Convert.ToString("Н / Д");
                            TB_Old_ProductDate.Text = Convert.ToString("Н / Д");
                            break;
                        }
                }
            }
        }

        private void CHB_ChangeName_CheckedChanged(object sender, EventArgs e)
        {
            switch (CHB_ChangeName.Checked)
            {
                case true:
                    {
                        Data.Products.Update.ChangeMode[0] = true;
                        TB_New_ProductName.Enabled = true;
                        break;
                    }
                case false:
                    {
                        Data.Products.Update.ChangeMode[0] = false;
                        TB_New_ProductName.Enabled = false;
                        break;
                    }
            }
        }

        private void CHB_ChangeCategory_CheckedChanged(object sender, EventArgs e)
        {
            switch (CHB_ChangeCategory.Checked)
            {
                case true:
                    {
                        Data.Products.Update.ChangeMode[1] = true;
                        CB_New_ProductCategory.Enabled = true;
                        break;
                    }
                case false:
                    {
                        Data.Products.Update.ChangeMode[1] = false;
                        CB_New_ProductCategory.Enabled = false;
                        break;
                    }
            }
        }

        private void CHB_ChangeCount_CheckedChanged(object sender, EventArgs e)
        {
            switch (CHB_ChangeCategory.Checked)
            {
                case true:
                    {
                        Data.Products.Update.ChangeMode[2] = true;
                        NUD_New_ProductCount.Enabled = true;
                        break;
                    }
                case false:
                    {
                        Data.Products.Update.ChangeMode[2] = false;
                        NUD_New_ProductCount.Enabled = false;
                        break;
                    }
            }
        }

        private void CHB_ChangePrice_CheckedChanged(object sender, EventArgs e)
        {
            switch (CHB_ChangeCategory.Checked)
            {
                case true:
                    {
                        Data.Products.Update.ChangeMode[3] = true;
                        NUD_New_ProductPrice.Enabled = true;
                        break;
                    }
                case false:
                    {
                        Data.Products.Update.ChangeMode[3] = false;
                        NUD_New_ProductPrice.Enabled = false;
                        break;
                    }
            }
        }

        private void B_ResetChanges_Click(object sender, EventArgs e)
        {
            TB_New_ProductName.Clear();
            CB_New_ProductCategory.Text = string.Empty;
            NUD_New_ProductCount.Value = 1;
            NUD_New_ProductPrice.Value = 1;
        }

        private async void Timer_ForLable_Tick(object sender, EventArgs e)
        {
            await UpdateTimerAsync();
        }
        public  async Task UpdateTimerAsync()
        {
            await Task.Delay(1000);
            L_Timer.Text = "UTC + 4 " + DateTime.Now.ToString("HH:mm:ss");
            L_Timer.Location = new Point((PNL_Time.Width - L_Timer.Width) / 2, 0);

        }

        private void B_ApplyChanges_Click(object sender, EventArgs e)
        {
            if (Data.Products.Update.ChangeMode[0])
            {
                Data.Products.Update.RedactName[1] = Convert.ToString(TB_New_ProductName.Text);
                Data.Products.Update.FinalOverwriteData[0] = Convert.ToString(Data.Products.Update.RedactName[1]);
            }
            if (Data.Products.Update.ChangeMode[1])
            {
                Data.Products.Update.RedactCategory[1] = Convert.ToString(CB_New_ProductCategory.SelectedItem);
                Data.Products.Update.FinalOverwriteData[1] = Convert.ToString(Data.Products.Update.RedactCategory[1]);
            }
            if (Data.Products.Update.ChangeMode[2])
            {
                Data.Products.Update.RedactCount[1] = Convert.ToInt32(NUD_New_ProductCount.Value);
                Data.Products.Update.FinalOverwriteData[2] = Convert.ToString(Data.Products.Update.RedactCount[1]);
            }
            if (Data.Products.Update.ChangeMode[3])
            {
                Data.Products.Update.RedactPrice[1] = Convert.ToInt32(NUD_New_ProductPrice.Value);
                Data.Products.Update.FinalOverwriteData[3] = Convert.ToString(Data.Products.Update.RedactPrice[1]);
            }
            Data.Products.Update.FinalOverwriteData[4] = Data.Products.Update.RedactCode[0];
            DialogResult = MessageBox.Show("Данные сохранены", $"{Config.Managers[0]}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (DialogResult == DialogResult.OK)
            {
                B_OverwriteData.Enabled = true;
            }
        }

        private void B_OverwriteData_Click(object sender, EventArgs e)
        {
            switch (DialogResult = MessageBox.Show("", $"{Config.Managers[1]}");
        }
    }
}
