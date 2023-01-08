using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace test_DataBase2
{
    public partial class AddColumnForm : Form
    {
        ConnectionDB sqlConnection = new ConnectionDB();

        string nameTable;                     // Название изменяемой таблицы

        Action refreshTable;                  // Переданный метод для обновления таблиц в списке

        public AddColumnForm(
            string nameTable, 
            Action refreshTable
            )
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            this.nameTable = nameTable;
            this.refreshTable = refreshTable;
        }
        private void AddColumnForm_Load(object sender, EventArgs e)
        {
            textBox_name.Text = "new_column";
            textBox_type.Text = "varchar(20)";
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            string newName = textBox_name.Text;
            string newType = textBox_type.Text;

            string addColumnQuery = 
                $"alter table {nameTable} add {newName} {newType};";

            try
            {
                safeExecute(newName, newType);

                refreshTable();
            }
            catch
            {
                MessageBox.Show($"На данное поле нельзя установить тип {newType}!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void safeExecute(string newName, string newType)
        {
            if (checkRow(newName, "Name") && checkRow(newType, "Type"))
            {
                if (newName != string.Empty && newType != string.Empty)
                {
                    string addCollumnQuery = $"alter table {nameTable} add {newName} {newType};";

                    try
                    {
                        sqlConnection.openConnection();

                        var command = new SqlCommand(addCollumnQuery, sqlConnection.getConnection());
                        command.ExecuteNonQuery();

                        sqlConnection.closeConnection();

                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Несоответствие типов!", "Ошибка!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }
                else MessageBox.Show("Введите новые значения!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }
        private bool checkRow(string name, string choose)
        {
            List<char> list = new List<char> { };   // Список с допустимыми символами

            int i = 32;
            while (i < 123)
            {   // Заполнение списка пробелом, цифрами, большими англ буквами, "_" и маленькими англ. буквами
                if ((i == 32) || (i > 47 && i < 58) || (i > 64 && i < 91) || (i == 95) || (i > 96))
                    list.Add(Convert.ToChar(i));
                i++;
            }

            if (choose == "Type") 
            {
                list.Add(Convert.ToChar(40));
                list.Add(Convert.ToChar(41));
            }

            foreach (char value in name)
            {
                if (!list.Contains(value))          // Если хотя бы один символ недопустимый, то выводится исключение
                {
                    MessageBox.Show($"Недопустимый символ '{value}' !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }
    }
}
