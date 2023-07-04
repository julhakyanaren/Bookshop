using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System.Linq.Expressions;

namespace Bookshop
{ 
    public static class Connections
    {
        public static class Direct
        {
            public static class Queries
            {
                public static string CreateCategoryTable(string TableName)
                {
                    string Query = $"CREATE TABLE {TableName} (ID COUNTER PRIMARY KEY, Наименование VARCHAR(255), Количество INT, ЦЕНА INT, Код VARCHAR(255))";
                    return Query;
                }
                public static string DeleteCategoryTable(string TableName)
                {
                    string Query = $"DROP TABLE {TableName}";
                    return Query;
                }
                public static string RenameCategoryTableStage1(string OldTableName, string NewTableName)
                {
                    string Query = $"SELECT * INTO {NewTableName} FROM {OldTableName}";
                    return Query;
                }
                public static string RenameCategoryTableStage2(string OldTableName)
                {
                    string Query = $"DROP TABLE {OldTableName}";
                    return Query;
                }
                public static bool TableOperationsCore(string Query, OleDbConnection InstanceConnection)
                {
                    using (OleDbCommand Command = new OleDbCommand(Query, InstanceConnection))
                    {
                        try
                        {
                            Command.ExecuteNonQuery();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            Handlers.ErrorProvider.ExcaptionShowMessages(ex, 5);
                            return false;
                        }
                        
                    }
                }
                public static int GetRowsCount(string Table, OleDbConnection InstanceConnection)
                {
                    if (InstanceConnection.State != ConnectionState.Open)
                    {
                        InstanceConnection.Open();
                    }
                    int rowsCount;
                    string rowscountquery = "SELECT COUNT(*) FROM " + Table + "";
                    OleDbCommand rowcountcmd = new OleDbCommand(rowscountquery, InstanceConnection);
                    try
                    {
                        rowsCount = (int)rowcountcmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        Handlers.ErrorProvider.ExcaptionShowMessages(ex, 1);
                        rowsCount = -1;
                    }
                    return rowsCount;
                }
                public static int GetFirstID(string Table, OleDbConnection InstanceConnection)
                {
                    int firstID = 0;
                    string GetValue = "SELECT * FROM " + Table + " WHERE ID > 0";
                    using (OleDbCommand getIDCommand = new OleDbCommand(GetValue, InstanceConnection))
                    {
                        using (OleDbDataReader getIDReeader = getIDCommand.ExecuteReader())
                        {
                            while (getIDReeader.Read())
                            {
                                firstID = Convert.ToInt32(getIDReeader[0]);
                                break;
                            }
                        }
                    }
                    return firstID;
                }
            }
            public static string ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BSDB.mdb";
            public static string DBAbsolutePath = Convert.ToString(System.IO.Path.GetFullPath("BSDB.mdb"));
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
            public static void DB_Connect(OleDbConnection FormConnection)
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
            public static void DB_Dissconnect(OleDbConnection FormConnection)
            {
                bool Connected = false;
                if (FormConnection.State != ConnectionState.Closed)
                {
                    try
                    {
                        FormConnection.Close();
                        Connected = false;

                    }
                    catch (Exception ex)
                    {
                        Handlers.ErrorProvider.ExcaptionShowMessages(ex, 0);
                        Connected = true;
                    }
                    finally
                    {
                        Connections.Direct.StatusToMB(Connected);
                    }
                }
            }
            public static bool ConnectionReset(OleDbConnection InstanceConnection)
            {
                Exception extern_ex = null;
                bool refreshed = false;
                switch (InstanceConnection.State)
                {
                    case ConnectionState.Open:
                        {
                            try
                            {
                                InstanceConnection.Close();
                                InstanceConnection.Open();
                                refreshed = true;
                            }
                            catch (Exception ex)
                            {
                                Handlers.ErrorProvider.ExcaptionShowMessages(ex, 0);
                                refreshed = false;
                                extern_ex = ex;
                            }
                            break;
                        }
                    case ConnectionState.Closed:
                        {
                            try
                            {
                                InstanceConnection.Open();
                                InstanceConnection.Close();
                                refreshed = true;
                            }
                            catch (Exception ex)
                            {
                                Handlers.ErrorProvider.ExcaptionShowMessages(ex, 0);
                                refreshed = false;
                                extern_ex = ex;
                            }
                            break;
                        }
                }
                if (refreshed)
                {
                    MessageBox.Show("Соеденение обновлено", "" + Config.Managers[0] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    DialogResult DR = new DialogResult();
                    switch (DR = MessageBox.Show("Обновление соединения провалено\r\n\r\nПокозать подробности ошибки?", "" + Config.Managers[0] + "", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                    {
                        case DialogResult.Yes:
                            {
                                MessageBox.Show("Сообщение исключении:\r\n" + extern_ex.Message.ToString() + "\r\n\r\nПодробности исключении:\r\n" + extern_ex.ToString() + "", "" + Config.Managers[0] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            }
                        case DialogResult.No:
                            {
                                break;
                            }
                    }
                    return false;
                }
            }
        }
    }
}
