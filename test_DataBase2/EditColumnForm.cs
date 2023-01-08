using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_DataBase2
{
    public partial class EditColumnForm : Form
    {
        ConnectionDB sqlConnection = new ConnectionDB();

        DataGridView dgw;

        string nameTable;                     // Название изменяемой таблицы

        int index;                            // Индекс изменяемого столбца

        List<(string, string)> NamesAndTypes; // Список полей и их типов изменяемого столбца

        List<string> textTypes;               // Список текстовых типов табличных полей

        Action refreshTable;                  // Переданный метод для обновления таблиц в списке

        public EditColumnForm( // Конструктор в который передаём всё кроме экземпляра подключения к БД
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
        private void EditColumnForm_Load_1(object sender, EventArgs e)                  // Открытие формы
        {
            // Сразу же заполняем поля ввода старыми значениями
            textBoxValue.Text = CurrentValueColumn();  // Старая строчка значений
            textBoxType.Text  =  CurrentTypeColumn();  // Старый тип поля
            textBoxName.Text  =  CurrentNameColumn();  // Старое название поля

            if (NamesAndTypes[index].Item2 == "int identity") 
            {
                btn_okValue.Visible = false;
                label_value.Visible = false;
                btn_okType.Visible = false;
                label_type.Visible = false;
            }
        }
        private void btn_cancelValue_Click(object sender, EventArgs e)                  // Закрытие формы на вкладке 1
        {
            Close();
        }
        private void btn_cancelType_Click(object sender, EventArgs e)                   // Закрытие формы на вкладке 2
        {
            Close();
        }
        private void btn_cancelName_Click(object sender, EventArgs e)                   // Закрытие формы на вкладке 3
        {
            Close();
        }        
        private void btn_okValue_Click(object sender, EventArgs e)                      // Кнопка ОК на изм. значений столбца
        {
            string newValue = textBoxValue.Text;

            string editValueQuery = "";

            safeExecute(editValueQuery, newValue, CurrentValueColumn(), "Value");

            refreshTable();
        }
        private void btn_okType_Click(object sender, EventArgs e)                       // Кнопка ОК на изм. типа столбца
        {
            string newType = textBoxType.Text; // На этом этапе производится избавление от пробелов

            string editTypeQuery = 
                $"alter table {nameTable} alter column {CurrentNameColumn()} {newType};";

            try
            {
                safeExecute(editTypeQuery, newType, CurrentTypeColumn(), "Type");

                refreshTable();
            }
            catch 
            { 
                MessageBox.Show($"На данное поле нельзя установить тип {newType}!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_okName_Click(object sender, EventArgs e)                       // Кнопка ОК на изм. названия столбца
        {
            string newName = textBoxName.Text;

            string renameColumnQuery = 
                $"exec sp_rename '{nameTable}.{CurrentNameColumn()}', '{newName}', 'column';";

            safeExecute(renameColumnQuery, newName, CurrentNameColumn(), "Name");

            refreshTable();
        }
        /*******************************************************************************************************
        * МЕТОДЫ ТЕКУЩИХ ЗНАЧЕНИЙ                                                                              *
        * CurrentValueColumn() - возвращает текущее значение всех ячеек столбца в виде строки                  *     
        * CurrentTypeColumn() - возвращает текущее значение типа выбранного столбца                            *
        * CurrentNameColumn() - возвращает текущее название выбранного столбца                                 *      
        *******************************************************************************************************/
        private string CurrentValueColumn()
        {
            string column = string.Empty;

            for (int i = 0; i < dgw.RowCount; i++)
            {
                column += dgw.Rows[i].Cells[index].Value;    // В строку добавляются значения ячеек 
                if (i != dgw.RowCount - 1) column += " ";    // Добавлять пробел в конце только если не конец строки
            }

            return column;
        }
        private string CurrentTypeColumn()
            => NamesAndTypes[index].Item2;

        private string CurrentNameColumn()
            => NamesAndTypes[index].Item1;

        /********************************************************************************************************
         * ДРУГИЕ МЕТОДЫ                                                                                        *
         * EditValueQuery() - возвращает строку запроса на редактирование всех значений столбца                 *     
         * safeExecute() - проводит защищённое от исключений выполнение любого запроса этого класса             * 
         * checkColumn() - проверяет строку на наличие недопустимых символов                                    *
         * listWithoutWhiteSpace() - конвертирует строку с введенными элементами в список элементов без пробелов*         
         *******************************************************************************************************/
        private string EditValueQuery(List<string> LISTnewColumn)
        {            
            var query = String.Empty;

            // Цикл создания строки запроса. Каждая итерация - изменение одного столбца(одной ячейки этого столбца)
            for (int i = 0; i < LISTnewColumn.Count; i++)
            {           
                query += $"update {nameTable} set {CurrentNameColumn()} = ";

                query +=
                    (textTypes.Contains(NamesAndTypes[index].Item2)) ?   //Добавляем новое значение
                    $" '{LISTnewColumn[i]}' " :                          //Если значение текстовое то с кавычками
                    $" {LISTnewColumn[i]} ";

                query += $"where {NamesAndTypes[0].Item1} =";            //Добавляем "id" =

                query += $" {dgw.Rows[i].Cells[0].Value};";              // Добавляем id изменяемой строки
            }
            return query;
        }
        private void safeExecute(string Query, string newStroke, string currentStroke, string choose)
        {
            if (checkColumn(newStroke,choose))
            {
                List<string> LISTnewStroke     = listWithoutWhiteSpace(newStroke);     // Получение нового списка столбца таблицы без пробелов
                List<string> LISTcurrentStroke = listWithoutWhiteSpace(currentStroke); // Получение старого списка столбца таблицы без пробелов

                if (newStroke != currentStroke && newStroke != String.Empty)
                {
                    if (choose == "Value" && LISTnewStroke.Count == LISTcurrentStroke.Count) 
                        Query = EditValueQuery(LISTnewStroke);

                    if (choose == "Type" && (newStroke == "decimal" || newStroke == "real" || newStroke == "numeric"))
                        Query = "";

                    try
                    {
                        sqlConnection.openConnection();

                        var command = new SqlCommand(Query, sqlConnection.getConnection());
                        command.ExecuteNonQuery();

                        sqlConnection.closeConnection();

                        refreshTable();

                        Close();
                    }
                    catch
                    {
                        MessageBox.Show("Несоответствие типов!", "Ошибка!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Неверные данные!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private bool checkColumn(string name, string choose)
        {
            List<char> list = new List<char> { };   // Список с допустимыми символами

            int i = 48;
            while (i < 123)
            {   // Заполнение списка цифрами, большими англ буквами, "_" и маленькими англ. буквами
                if ((i < 58) || (i > 64 && i < 91) || (i == 95) || (i > 96))
                    list.Add(Convert.ToChar(i));
                i++;
            }
            
            if (choose == "Value")
            {
                list.Add(Convert.ToChar(32)); // Заполнение пробелом                

                if (CurrentTypeColumn() == "float")
                {
                    list.Add(Convert.ToChar(46)); // Заполнение точкой   
                }
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
