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

namespace test_DataBase2
{
    public partial class EditRowForm : Form
    {
        ConnectionDB sqlConnection = new ConnectionDB();

        DataGridView dgw;                     

        string nameTable;                     // Название изменяемой таблицы

        int index;                            // Индекс изменяемой строки

        List<(string, string)> NamesAndTypes; // Список полей и их типов изменяемой строки

        List<string> textTypes;               // Список текстовых типов табличных полей

        Action refreshTable;                  // Переданный метод для обновления таблиц в списке

        public EditRowForm( // Конструктор в который передаём всё кроме экземпляра подключения к БД
            DataGridView dgw, 
            string nameTable, 
            int index, 
            List<(string, string)> NamesAndTypes,
            List<string> textTypes,
            Action refreshTable
            )
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            this.dgw = dgw;
            this.nameTable = nameTable;
            this.index = index;            
            this.NamesAndTypes = NamesAndTypes;
            this.textTypes = textTypes;
            this.refreshTable = refreshTable;
        }
        private void EditRowForm_Load(object sender, EventArgs e) // Открытие формы
        {
            textBox_editRow.Text = oldRow();
        }
        private void btn_cancel_Click(object sender, EventArgs e) // Кнопка Отмена
        {
            Close();
        }
        private void btn_ok_Click(object sender, EventArgs e)     // Кнопка Ок
        {
            string newRow = textBox_editRow.Text;

            safeExecute(newRow, oldRow());

            refreshTable();           
        }
        /*******************************************************************************************************
        * ОСНОВНЫЕ МЕТОДЫ                                                                                      *
        * EditRowQuery() - возвращает текстовый запрос для изменения строки                                    *
        * safeExecute() - проводит защищённое от исключений выполнение запроса                                 *      
        * oldRow() - возвращает старое текстовое значение изменяемой строки                                    * 
        * listWithoutWhiteSpace() - конвертирует строку с введенными элементами в список элементов без пробелов*
        * checkRow() - проверяет строку на наличие недопустимых символов                                       *
        *******************************************************************************************************/
        private string EditRowQuery(List<string> LISTnewRow, List<string> LISToldRow)
        {
            var query = String.Empty;

            // Цикл создания строки запроса. Каждая итерация - изменение одного столбца(одной ячейки этого столбца)
            for (int i = 0; i < dgw.ColumnCount - 1; i++)
            {
                query += $"update {nameTable} set ";

                query +=
                    (textTypes.Contains(NamesAndTypes[i + 1].Item2)) ?      //Добавляем "название_поля="новое_значение""
                    $"{NamesAndTypes[i + 1].Item1} = '{LISTnewRow[i]}' " :  //Если значение текстовое то с кавычками
                    $"{NamesAndTypes[i + 1].Item1} = {LISTnewRow[i]} ";

                query += $"where {NamesAndTypes[0].Item1} = {dgw.Rows[index].Cells[0].Value}; "; //Идентифицируем ячейку по id
            }
            return query;
        }
        private void safeExecute(string newRow, string oldRow)
        {
            if (checkRow(newRow))
            {
                List<string> LISTnewRow = listWithoutWhiteSpace(newRow); // Получение списка новых  полей таблицы
                List<string> LISToldRow = listWithoutWhiteSpace(oldRow); // Получение списка старых полей таблицы

                if (/*LISTnewRow.Count == LISToldRow.Count && */newRow != oldRow && newRow != string.Empty)
                {
                    try 
                    {
                        string editRowQuery = EditRowQuery(LISTnewRow, LISToldRow);

                        sqlConnection.openConnection();

                        var command = new SqlCommand(editRowQuery, sqlConnection.getConnection());
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
        private string oldRow()
        {
            string Row = string.Empty;

            for (int i = 1; i < dgw.ColumnCount; i++) // i!=0 так как пропускаем значение первичного ключа
            {
                Row += dgw.Rows[index].Cells[i].Value;    // В строку добавляются значения полей 
                if (i != dgw.ColumnCount - 1) Row += " "; // Добавлять пробел в конце только если не конец строки
            }

            return Row;
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
        private bool checkRow(string Row)
        {
            List<char> list = new List<char> { };   // Список с допустимыми символами

            int i = 32;
            while (i < 123)
            {   // Заполнение списка пробелом, точкой, цифрами, большими англ буквами, "_" и маленькими англ. буквами
                if ((i == 32) || (i == 46) || (i > 47 && i < 58) || (i > 64 && i < 91) || (i == 95) || (i > 96))
                    list.Add(Convert.ToChar(i));
                i++;
            }

            foreach (char value in Row)
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
