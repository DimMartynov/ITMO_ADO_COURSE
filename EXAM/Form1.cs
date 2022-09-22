using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace EXAM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        string testConnect = GetConnectionStringByName("DBConnect.MyDBConnectionString");
        OleDbConnection connection = new OleDbConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.ConnectionString = testConnect;
                connection.Open();
                string queue = "SELECT COUNT(*) FROM Users where User_login = '" + loginText.Text +"'  AND User_password= '" + passwordText.Text +"'";
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = queue;
                int number = (int)command.ExecuteScalar();       
                connection.Close();

                if(number == 1)
                {
                    DataTables form = new DataTables(this);
                    this.Hide();
                    form.Show();
                }
            }
        }
    }
}
