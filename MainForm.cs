using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
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
                            }
                            catch (Exception ex)
                            {
                                // Форма обработки иисключении
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
                                            // Форма обработки иисключении
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
                            }
                            catch (Exception ex)
                            {
                                // Форма обработки иисключении
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
                                            // Форма обработки иисключении
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
            Connections.Direct.StatusToMB(Connections.Direct.Connected);
        }
    }
}
