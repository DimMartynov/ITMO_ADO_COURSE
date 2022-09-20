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
using System.Configuration;

namespace Lab1_task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.connection.StateChange += new
                System.Data.StateChangeEventHandler(this.connection_StateChange);

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

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            button1.Enabled = (e.CurrentState == ConnectionState.Closed);
            button2.Enabled = (e.CurrentState == ConnectionState.Open);
        }


        //Правильная строка подключения
        //string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MyDB;Data Source=DESKTOP-V4EPFJ1";

        //Неверное значение "Provider"
        //string testConnect = @"Provider=SQLOLEqweDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MyDB;Data Source=DESKTOP-V4EPFJ1";

        //Недопустимое значение "Integrated Security"
        //string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI23311ы;Persist Security Info=False;Initial Catalog=MyDB;Data Source=DESKTOP-V4EPFJ1";

        //Ошибка 17 (Неверное имя Cервера)
        //string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MyDB;Data Source=DESKTOP-V4EPFJsd1";

        //Ошибка 4060 (Неверное имя Базы Данных)
        //string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=MyD22B;Data Source=DESKTOP-V4EPFJ1";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }

            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message,
                    "SQL Error code " + se.NativeError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            //Универасльный обработчик "catch" был заменён на обработчик "catch" с параметром
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");

        }

        private void ConnectionListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;


            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                }
            }


        }
    }
}
