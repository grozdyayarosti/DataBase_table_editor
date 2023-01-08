using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace test_DataBase2
{
    public partial class AddRowForm : Form
    {
        ConnectionDB sqlConnection = new ConnectionDB();

        string nameTable;                     // Название изменяемой таблицы

        List<(string, string)> NamesAndTypes; // Список полей и их типов изменяемой строки

        List<string> textTypes;               // Список текстовых типов табличных полей

        List<string> dateTypes;               // Список типов даты табличных полей

        Action refreshTable;                  // Переданный метод для обновления таблиц в списке

        public AddRowForm(
            string nameTable, 
            List<(string, string)> NamesAndTypes, 
            List<string> textTypes,
            List<string> dateTypes,
            Action refreshTable
            )
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

            this.nameTable = nameTable;
            this.NamesAndTypes= NamesAndTypes;
            this.textTypes = textTypes;            
            this.dateTypes = dateTypes;
            this.refreshTable = refreshTable;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string newRow = textBox_addRow.Text;

            safeExecute(newRow);

            refreshTable();
        }

        private string AddRowQuery(List<string> LISTnewRow)
        {
            var query = $"insert into {nameTable} values (";

            // Цикл создания строки запроса. Каждая итерация - добавление 1 нового значения в запрос
            for (int i = 0; i < LISTnewRow.Count; i++)
            {
                query +=
                    (textTypes.Contains(NamesAndTypes[i + 1].Item2) || dateTypes.Contains(NamesAndTypes[i + 1].Item2)) ?
                    $"'{LISTnewRow[i]}'" : $"{LISTnewRow[i]}";

                query += (i != LISTnewRow.Count - 1)  ? ", " : ")";
            }
            return query;
        }

        private void safeExecute(string newRow)
        {
            if (checkRow(newRow))
            {
                List<string> LISTnewRow = listWithoutWhiteSpace(newRow); // Получение нового списка строки таблицы без пробелов

                if (newRow != String.Empty && LISTnewRow.Count == NamesAndTypes.Count - 1)
                {
                    string addRowQuery = AddRowQuery(LISTnewRow);

                    try
                    {
                        sqlConnection.openConnection();

                        var command = new SqlCommand(addRowQuery, sqlConnection.getConnection());
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
                else MessageBox.Show("Неверные данные!","Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        private bool checkRow(string name)
        {
            List<char> list = new List<char> { };   // Список с допустимыми символами

            int i = 32;
            while (i < 123)
            {   // Заполнение списка пробелом, тире, точкой, цифрами, двоеточием, большими англ буквами, "_" и маленькими англ. буквами
                if ((i == 32) || (i == 45) || (i == 46) || (i > 47 && i < 59) || (i > 64 && i < 91) || (i == 95) || (i > 96))
                    list.Add(Convert.ToChar(i));
                i++;
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
        private List<string> listWithoutWhiteSpace(string stroke)
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
    }
}
