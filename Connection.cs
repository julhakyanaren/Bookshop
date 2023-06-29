﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Bookshop
{
    public static class Connections
    {
        public static class Direct
        {
            public static string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BSDB.mdb";
            public static OleDbConnection Connection = new OleDbConnection(ConnectionString);
            public static bool Connected = false;
            public static void StatusToMB(bool Status)
            {
                switch (Status)
                {
                    case true:
                        {
                            MessageBox.Show("Соеденение Установлено", "Диспечер соеденения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    case false:
                        {
                            MessageBox.Show("Соеденение Откючено", "Диспечер соеденения", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                }
            }
            public static void ConnectToDB(OleDbConnection FormConnection)
            {
                bool Connected = false;
                if (FormConnection.State == ConnectionState.Closed)
                {
                    try
                    {
                        FormConnection.Open();
                        Connected = true;

                    }
                    catch (Exception ex)
                    {
                        Handlers.ErrorProvider.ExcaptionShowMessages(ex, 0);
                        Connected = false;
                    }
                    finally
                    {
                        Connections.Direct.StatusToMB(Connected);
                    }
                }
            }
            public static void DissconnectDB(OleDbConnection FormConnection)
            {
                bool Connected = false;
                if (FormConnection.State != ConnectionState.Closed)
                {
                    try
                    {
                        FormConnection.Close();
                        Connected = true;

                    }
                    catch (Exception ex)
                    {
                        Handlers.ErrorProvider.ExcaptionShowMessages(ex, 0);
                        Connected = false;
                    }
                    finally
                    {
                        Connections.Direct.StatusToMB(Connected);
                    }
                }
            }
        }
    }
}
