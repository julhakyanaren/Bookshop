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
        }
    }
}
