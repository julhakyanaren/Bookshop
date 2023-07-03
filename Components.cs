using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
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
        public static void FormsStateRegister()
        {
            for (int f = 0; f < Options.FormOpened.Length; f++)
            {
                Options.FormClosed[f] = !Options.FormOpened[f];
            }
        }
    }
    public static class Handlers
    {
        public static class InformationProvider
        {
            public static void DataOperationState(int state, int MessageIndex, int ManagerIndex)
            {
                switch (state)
                {
                    case 0: //Выполнено
                        {
                            switch (MessageIndex)
                            {
                                case 0:
                                    {
                                        MessageBox.Show("Данные успешно Записаны", "" + Config.Managers[ManagerIndex] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                case 1:
                                    {
                                        MessageBox.Show("Данные успешно Обновлены", "" + Config.Managers[ManagerIndex] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                case 2:
                                    {
                                        MessageBox.Show("Данные успешно Удалены", "" + Config.Managers[ManagerIndex] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                                case 3:
                                    {
                                        MessageBox.Show("Данные успешно Получены", "" + Config.Managers[ManagerIndex] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        break;
                                    }
                            }
                            break;
                        }
                    case 1: //Не ывыполнено
                        {
                            switch (MessageIndex)
                            {
                                case 0:
                                    {
                                        MessageBox.Show("Данные Не записаны", "" + Config.Managers[ManagerIndex] + "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                                case 1:
                                    {
                                        MessageBox.Show("Данные Не обновлены", "" + Config.Managers[ManagerIndex] + "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                                case 2:
                                    {
                                        MessageBox.Show("Данные Не Удалены", "" + Config.Managers[ManagerIndex] + "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                                case 3:
                                    {
                                        MessageBox.Show("Данные Не Получены", "" + Config.Managers[ManagerIndex] + "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        break;
                                    }
                            }
                            break;
                        }
                }
            }
        }

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
                    case 2:
                        {
                            result = MessageBox.Show("Возникла ошибка при записи данных\r\n\r\nПоказать подробности?", "" + Config.Managers[ManagerID - 1] + "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes)
                            {
                                MessageBox.Show("Сообщение исключении:\r\n" + InputException.Message.ToString() + "\r\n\r\nПодробности исключении:\r\n" + InputException.ToString() + "", "" + Config.Managers[ManagerID - 1] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        }
                    case 3:
                        {
                            result = MessageBox.Show("Возникла ошибка при обновлении данных\r\n\r\nПоказать подробности?", "" + Config.Managers[ManagerID - 2] + "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes)
                            {
                                MessageBox.Show("Сообщение исключении:\r\n" + InputException.Message.ToString() + "\r\n\r\nПодробности исключении:\r\n" + InputException.ToString() + "", "" + Config.Managers[ManagerID - 2] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        }
                    case 4:
                        {
                            result = MessageBox.Show("Возникла ошибка при удалении данных\r\n\r\nПоказать подробности?", "" + Config.Managers[ManagerID - 3] + "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes)
                            {
                                MessageBox.Show("Сообщение исключении:\r\n" + InputException.Message.ToString() + "\r\n\r\nПодробности исключении:\r\n" + InputException.ToString() + "", "" + Config.Managers[ManagerID - 3] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        }
                    case 5:
                        {
                            result = MessageBox.Show("Возникла ошибка при работе с таблицами в БД\r\n\r\nПоказать подробности?", "" + Config.Managers[ManagerID - 4] + "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            if (result == DialogResult.Yes)
                            {
                                MessageBox.Show("Сообщение исключении:\r\n" + InputException.Message.ToString() + "\r\n\r\nПодробности исключении:\r\n" + InputException.ToString() + "", "" + Config.Managers[ManagerID - 4] + "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            break;
                        }
                }
            }
        }
        public static class SetConfiguration
        {
            public static int StringToInt(string String)
            {
                return Convert.ToInt32(Char.GetNumericValue(Convert.ToChar(String)));
            }
            public static void SetSearchTypeThrowCheckBox(CheckBox CHB, GroupBox GB)
            {
                int CHBTagInt = StringToInt(Convert.ToString(CHB.Tag));
                int GBTagInt = StringToInt(Convert.ToString(GB.Tag));
                Data.Products.SearchWithUniqueCode[GBTagInt] = CHBTagInt;
            }
        }
    }
}
