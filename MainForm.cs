using System;
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

namespace Bookshop
{
    public partial class MainForm : Form
    {
        public OleDbConnection MSConnection = Connections.Direct.Connection;
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
                        if (MSConnection.State != ConnectionState.Open)
                        {
                            try
                            {
                                MSConnection.Open();
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
                                            MSConnection.Close();
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
                        if (MSConnection.State != ConnectionState.Closed)
                        {
                            try
                            {
                                MSConnection.Close();
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
                                            MSConnection.Open();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            Methods.LoadComponents();
            Options.FormOpened[0] = true;
            Methods.FormsStateRegister();
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
    }
}
