using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace test_DataBase2
{
    public partial class CreateForm : Form
    {
        ConnectionDB sqlConnection = new ConnectionDB();

        Action refreshList;     // Переданный метод для обновления таблиц в списке

        public CreateForm(Action refreshList)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.refreshList = refreshList;
        }
        private void btn_save_Click(object sender, EventArgs e)
        {         
            string nameTable  = textBox_nameTable.Text;               // Получение нового названия таблицы
            string primaryKey = textBox_primaryKey.Text;              // Получение нового первичного ключа таблицы

            List <string> namesList = listWithoutWhiteSpace(textBox_namesFields.Text); // Получение нового списка полей таблицы
            List <string> typesList = listWithoutWhiteSpace(textBox_typesFields.Text); // Получение нового списка типов полей таблицы

            if (namesList.Count == typesList.Count)
            {
                string createQuery = CreateQuery(nameTable, primaryKey, namesList, typesList);

                safeExecute(createQuery);
            }
            else MessageBox.Show("Разное количество полей и их типов!", 
                "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
        private string CreateQuery(string nameTable, string primaryKey, List<string> namesList, List<string> typesList)
        {
            string query = $"create table {nameTable} " +
                    $"({primaryKey} int identity(1,1) not null, ";

            for (int i = 0; i < namesList.Count; i++)
            {
                query += namesList[i] + " " + typesList[i] + " null";
                query += (i != namesList.Count - 1) ? ", " : ");";  
            }

            return query;
        }
        private List<string> listWithoutWhiteSpace(string stroke)   // Конвертирует строку с введенными элементами в список элементов без пробелов
        {
            string[] array = stroke.Split(' ');

            List<string> list1 = array.ToList();
            List<string> list2 = new List<string>();

            list1.ForEach(item =>
            {
                if (item != String.Empty)
                    list2.Add(item);
            });
            return list2;
        }
        private void safeExecute(string query)
        {
            try
            {
                sqlConnection.openConnection();

                var command = new SqlCommand(query, sqlConnection.getConnection());
                command.ExecuteNonQuery();

                MessageBox.Show("Таблица успешно создана!",
                    "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                refreshList();  // Обновление названия таблицы в списке

                Close();
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.closeConnection();
            }
        }
    }
}
