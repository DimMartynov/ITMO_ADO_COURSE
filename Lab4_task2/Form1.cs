using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab4_task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable CustomersTable = new DataTable("Customers");
        private void AddRowButton_Click(object sender, EventArgs e)
        {
            // При работе с данными могут возникать исключения
            try
            {
                DataRow CustRow = CustomersTable.NewRow();
                // Данные из методички были отредактированны для корректного добавления
                Object[] CustRecord =  {"ALFKI", "Alfreds Futterkiste", "Maria Anders",
                                    "Sales Representative", "Obere Str. 57", "Berlin",
                                    "Germany","030-0076545"};
                CustRow.ItemArray = CustRecord;

                CustomersTable.Rows.Add(CustRow);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                TableGrid.DataSource = CustomersTable;

                CustomersTable.Columns.Add("CustomerID", Type.GetType("System.String"));
                CustomersTable.Columns.Add("CompanyName", Type.GetType("System.String"));
                CustomersTable.Columns.Add("ContactName", Type.GetType("System.String"));
                CustomersTable.Columns.Add("ContactTitle", Type.GetType("System.String"));
                CustomersTable.Columns.Add("Address", Type.GetType("System.String"));
                CustomersTable.Columns.Add("City", Type.GetType("System.String"));
                CustomersTable.Columns.Add("Country", Type.GetType("System.String"));
                CustomersTable.Columns.Add("Phone", Type.GetType("System.String"));

                // Для добавления одинаковых записей нужно закомментировать блок с установкой первичного ключа
                DataColumn[] KeyColumns = new DataColumn[1];
                KeyColumns[0] = CustomersTable.Columns["CustomerID"];
                CustomersTable.PrimaryKey = KeyColumns;

                CustomersTable.Columns["CustomerID"].AllowDBNull = false;
                CustomersTable.Columns["CompanyName"].AllowDBNull = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
    }
}
