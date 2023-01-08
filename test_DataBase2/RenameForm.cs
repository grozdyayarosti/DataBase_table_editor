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
    public partial class RenameForm : Form
    {
        ConnectionDB sqlConnection = new ConnectionDB();

        string nameTable;

        Action refreshList;     // Переданный метод для обновления таблиц в списке
        
        public RenameForm(string nameTable, Action refreshList)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.nameTable = nameTable;           
            this.refreshList = refreshList;
        }
        private void RenameForm_Load(object sender, EventArgs e)
        {
            textBox_newName.Text = nameTable;
        }
        private void btn_ok_Click(object sender, EventArgs e)
        {
            string newName = textBox_newName.Text; // На этом этапе производится избавление от пробелов
            
            safeExecute(newName);

            refreshList();  // Обновление названия таблицы в списке
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private bool checkName(string name)
        {
            List<char> list = new List<char> { };   // Список с допустимыми символами

            int i = 48;
            while (i < 123)
            {   // Заполнение списка цифрами, большими англ буквами, "_" и маленькими англ. буквами
                if ((i < 58) || (i > 64 && i < 91) || (i == 95) || (i > 96))
                    list.Add(Convert.ToChar(i));
                i++;
            }

            foreach (char value in name)
            {
                if (!list.Contains(value))          // Если хотя бы один символ недопустимый, то выводится исключение
                {
                    MessageBox.Show($"Недопустимый символ '{value}' !", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error) ;
                    return false;
                }
            }
            return true;
        }       
        private void safeExecute(string newName) 
        {
            if (checkName(newName))
            {
                if (newName != String.Empty && newName != nameTable)
                {
                    var renameQuery = $"EXEC sp_rename '{nameTable}', '{newName}';";   // Запрос на переименование                

                    sqlConnection.openConnection();

                    var command = new SqlCommand(renameQuery, sqlConnection.getConnection());
                    command.ExecuteNonQuery();

                    sqlConnection.closeConnection();                    

                    Close();
                }
                else MessageBox.Show("Введите новое название!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
