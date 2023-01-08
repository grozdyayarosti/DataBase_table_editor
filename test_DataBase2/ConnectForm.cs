using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_DataBase2
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }
        private void ConnectForm_Load(object sender, EventArgs e)
        {
            textBox_Server.Text = "WIN-4S4CK5N38C2\\MSSQLSERVER2";
            textBox_Database.Text = "MyDBase";
            textBox_User_id.Text = "sa";
            textBox_Password.Text = "mssql";
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            string server = textBox_Server.Text;
            string database = textBox_Database.Text;
            string userId = textBox_User_id.Text;
            string password = textBox_Password.Text;


            ConnectionDB connectionDB = new ConnectionDB();

            connectionDB.StrokeConnection = $"Server = {server}; Database={database};User Id = {userId};Password={password}";

            Form1 form1= new Form1();

            form1.ShowDialog();            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LocalDBForm localDBForm= new LocalDBForm();
            localDBForm.ShowDialog();
        }
    }
}
