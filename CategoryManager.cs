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
    public partial class CategoryManager : Form
    {
        OleDbConnection ConnectionCM = Connections.Direct.Connection;
        public CategoryManager()
        {
            InitializeComponent();
        }

        private void CategoryManager_Load(object sender, EventArgs e)
        {
            Methods.LoadComponents();
            Connections.Direct.ConnectToDB(ConnectionCM);
            if (ConnectionCM.State == ConnectionState.Open)
            {
                TSMI_CM_Status.Text = "Подключено";
                TSMI_CM_Status.ForeColor = Color.Green;
                TSMI_CM_Connect.Text = "Подключить";
            }
            else
            {
                TSMI_CM_Status.Text = "Не Подключено";
                TSMI_CM_Status.ForeColor = Color.Firebrick;
                TSMI_CM_Connect.Text = "Отключить";
            }
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
                        Connections.Direct.ConnectToDB(ConnectionCM);
                        break;
                    }
                case ConnectionState.Closed:
                    {
                        Connections.Direct.DissconnectDB(ConnectionCM);
                        break;
                    }
            }
        }
    }
}
