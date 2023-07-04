using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookshop
{
    public static class Options
    {
        public static bool[] FormOpened = new bool[3];
        public static bool[] FormClosed = new bool[3];
        public static string[] Table = { "Category", "Product" };
    }
    public static class Config
    {
        public static string[] Managers = new string[5];
        public static bool[] NameExist = new bool[2];
        public static class Debug
        {
            public static int DebugUnloackCount = 5;
            public static bool DebugModON = false;
        }
    }
    public static class Data
    {
        public static class Categories
        {
            public static int FirstID = 1;
            public static int LastID;
            public static int IDCount;
            public static string[] NameByID = new string[0];
            public static string[] EnteredName = new string[2];
            public static string[] ExistingNames = new string[0];
            public static string[] NewName = new string[2];
            public static string OldName;
            public static string[] AllCategories = new string[0];
        }
        public static class Products
        {
            public static int[] SearchWithUniqueCode = { 0, 0, 0 };
            public static int ProductsCount;
            public static string[] EnteredName = new string[2];
            public static bool[] NameExist = new bool[2];
            public static string SelectedCategory;
            public static int Price;
            public static int Count;
            public static bool[] ProductNameOverOne = new bool[2];
            public static int SameNameProductsCount = 0;
            public static string[] RedactType = new string[2];
            public static class Update
            {
                public static string SelectedCategory;
                public static string[] ProductsByCategory = new string[0];
                public static string EnteredCode;
                public static string SelectedName;
                public static string EnteredName;
                public static string[] SelectedNames = new string[0];
                public static string ChoosenName;
                public static int SelectedID;
                public static string[] RedactName = new string[2];
                public static string[] RedactCategory = new string[2];
                public static int[] RedactCount = new int[2];
                public static int[] RedactPrice = new int[2];
                public static string[] RedactCode = new string[2];
                public static DateTime[] RedactDate = new DateTime[2];
                public static bool[] ChangeMode = new bool[4];
                public static string[] FinalOverwriteData = new string[6];
            }
            public static class Rename
            {
                public static string SelectedCategory;
                public static string[] ProductsByCategory = new string[0];
                public static string EnteredCode;
                public static string SelectedName;
                public static string EnteredName;
                public static string[] SelectedNames = new string[0];
                public static string[] NewName = new string[2];
                public static bool NameEpty;
                public static bool RanameAll;
                public static int[] SelectedNamesIDs = new int[0];
            }
            public static class Delete
            {
                public static string SelectedCategory;
                public static string[] ProductsByCategory = new string[0];
                public static string EnteredCode;
                public static string SelectedName;
                public static string EnteredName;
                public static string[] SelectedNames = new string[0];
                public static string[] NewName = new string[2];
                public static bool DeleteAll;
                public static int[] SelectedNamesIDs = new int[0];
            }
            public static class CodeGenerator
            {
                public static string UniqueCode;
                public static bool[] EnableGenerator = new bool[4];
                public static string GetRandomChars(int ID)
                {
                    if (ID == 0)
                    {
                        Random random = new Random();
                        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                        char randomsymbol;
                        randomsymbol = chars[random.Next(chars.Length)];
                        string finalrandomsymbol = Convert.ToString(randomsymbol);
                        return finalrandomsymbol;
                    }
                    else
                    {
                        Random random = new Random();
                        const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                        char randomsymbol;
                        randomsymbol = chars[random.Next(chars.Length)];
                        string finalrandomsymbol = Convert.ToString(randomsymbol);
                        return finalrandomsymbol;
                    }
                    
                }
                public static string GenerateCode()
                {
                    string randomChars = GetRandomChars(0);
                    string randomLetter = GetRandomChars(1);
                    DateTime currentTime = DateTime.Now;
                    int hour = currentTime.Hour;
                    int minute = currentTime.Minute;
                    int second = currentTime.Second;
                    string[] generatechararray = new string[3];
                    for (int r = 0; r < 3; r++)
                    {
                        generatechararray[r] = GetRandomChars(0);
                    }
                    string FinalChars = $"{randomLetter}-{hour:D2}{generatechararray[0]}{minute:D2}{generatechararray[0]}{second:D2}{generatechararray[0]}";

                    return FinalChars;
                }
            }
        }
    }
}
