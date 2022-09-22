using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EXAM
{
    public partial class DataTables : Form
    {
        Form old;
        public DataTables(Form form)
        {
            old = form;
            InitializeComponent();
        }

        private MyDBEntities1 context;

        private void Output()
        {
            if (this.UsersRad.Checked == true)
            {
                dataGridView1.DataSource = context.Users.ToList();
                usersAddBox.Visible = true;
                tsAddBox.Visible = false;
                otAddBox.Visible = false;
            }
                
            else if (this.ourTableRad.Checked == true)
            {
                dataGridView1.DataSource = context.OurTables.ToList();
                otAddBox.Visible = true;
                usersAddBox.Visible = false;
                tsAddBox.Visible = false;
            }
                
            else if (this.tableSourceRad.Checked == true)
            {
                dataGridView1.DataSource = context.TableSources.ToList();
                tsAddBox.Visible = true;
                otAddBox.Visible = false;
                usersAddBox.Visible = false;

            }
                

           
        }

        private void DataTables_Load(object sender, EventArgs e)
        {
            context = new MyDBEntities1();
  
        }

        private void DataTables_FormClosed(object sender, FormClosedEventArgs e)
        {
            old.Show();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                context.SaveChanges();
                MessageBox.Show("Changes saved to the database.");
                this.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tableSourceRad_CheckedChanged(object sender, EventArgs e)
        {
            Output();
        }

        private void ourTableRad_CheckedChanged(object sender, EventArgs e)
        {
            Output();
        }

        private void UsersRad_CheckedChanged(object sender, EventArgs e)
        {
            Output();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.UsersRad.Checked == true)
            {
                try
                {
                    User user = new User
                    {
                        User_login = uTB1.Text,
                        User_password = uTB2.Text,
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Output();
            }

            else if (this.ourTableRad.Checked == true)
            {
                try
                {
                    OurTable ourTable = new OurTable
                    {
                        nCanonId = Convert.ToInt32(oTB1.Text),
                        dtReportDate = Convert.ToDateTime(oTB2.Text),
                        nTerOtdelenie = Convert.ToInt32(oTB3.Text),
                        nTerPodrazdel = Convert.ToInt32(oTB4.Text),
                        vProcent = Convert.ToDecimal(oTB5.Text),

                    };
                    context.OurTables.Add(ourTable);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Output();

            }

            else if (this.tableSourceRad.Checked == true)
            {
                try { 
                    TableSource tableS = new TableSource
                    {
                        nPokazatelId = Convert.ToInt64(tsTB1.Text),
                        vPeriodType = tsTB2.Text,
                        dtStartDate = Convert.ToDateTime(tsTB3.Text),
                        dtEndDate = Convert.ToDateTime(tsTB4.Text),
                        vTerritoryId = tsTB5.Text,
                        nValue = Convert.ToDecimal(tsTB6.Text),
                    };
                    context.TableSources.Add(tableS);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Output();
                

            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (delTB.Text == String.Empty) return;

            
            if (this.UsersRad.Checked == true)
            {
                var id = delTB.Text;
                var item = context.Users.Find(id);
                context.Entry(item).State = EntityState.Deleted;
            }

            else if (this.ourTableRad.Checked == true)
            {
                var id = Convert.ToInt64(delTB.Text);
                var item = context.OurTables.Find(id);
                context.Entry(item).State = EntityState.Deleted;
            }

            else if (this.tableSourceRad.Checked == true)
            {
                var id = Convert.ToInt64(delTB.Text);
                var item = context.TableSources.Find(id);
                context.Entry(item).State = EntityState.Deleted;
            }
            

            
            context.SaveChanges();
            Output();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
