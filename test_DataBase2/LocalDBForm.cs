using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_DataBase2
{
    public partial class LocalDBForm : Form
    {
        public LocalDBForm()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            ConnectionDB connectionDB = new ConnectionDB();

            connectionDB.StrokeConnection = textBox_StrokeConnection.Text;

            Form1 form1 = new Form1();

            form1.ShowDialog();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
