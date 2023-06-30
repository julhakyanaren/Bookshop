using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public static class Config
    {
        public static string[] Managers = new string[5];
    }
    public static class Methods
    {
        public static void InitializeManagers()
        {
            Config.Managers[0] = "Диспечер соединения";
            Config.Managers[1] = "Диспечер данных";
        }
        public static void LoadComponents()
        {
            InitializeManagers();
        }
    }
    public static class Handlers
    {
        public static class ErrorProvider
        {
            public static void ExcaptionShowMessages(Exception InputException, int ManagerID)
            {
                DialogResult result = new DialogResult();
                switch (ManagerID)
                {
                    case 0:
                        {
                            result = MessageBox.Show("Возникла ошибка при подключении данных\r\n\r\nПоказать подробности?", "" + Config.Managers[ManagerID] + "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes)
                            {
                                MessageBox.Show("Сообщение исключении:\r\n" + InputException.Message.ToString() + "\r\n\r\nПодробности исключении:\r\n" + InputException.ToString() + "", "" + Config.Managers[ManagerID] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        }
                    case 1:
                        {
                            result = MessageBox.Show("Возникла ошибка при чтении данных\r\n\r\nПоказать подробности?", "" + Config.Managers[ManagerID] + "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes)
                            {
                                MessageBox.Show("Сообщение исключении:\r\n" + InputException.Message.ToString() + "\r\n\r\nПодробности исключении:\r\n" + InputException.ToString() + "", "" + Config.Managers[ManagerID] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        }
                }
            }
        }
    }
}
