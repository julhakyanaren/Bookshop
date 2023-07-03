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

    }
    public static class Config
    {
        public static string[] Managers = new string[5];
        public static bool[] NameExist = new bool[2];
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
        }
    }
}
