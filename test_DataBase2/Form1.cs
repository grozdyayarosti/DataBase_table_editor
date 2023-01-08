using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Collections;
using System.Globalization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using System.Data.Common;

namespace test_DataBase2
{
    public partial class Form1 : Form
    {
        ConnectionDB sqlConnection = new ConnectionDB();

        List<(string, string)> NamesAndTypes = new List<(string, string)>(); // Список с названиями и типами полей выбр.таблицы
             
        List<string> textTypes  = new List<string> {
            "nchar", "nvarchar", "char", "varchar","ntext", "text" 
        };
        List<string> dateTypes = new List<string> {
            "smalldatetime", "datetime", "datetime2", "date"
        };

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)              // Открытие формы
        {
            if (!CheckConnection())
            return;

            try
            {
                CreateColumns("listTables");
                RefreshDataGridView(dataGridViewTables, "listTables");

                CreateColumns("oneMainTable");
                RefreshDataGridView(dataGridViewMain, "oneMainTable");
            }
            catch 
            {
                MessageBox.Show("Создайте таблицу!",
                    "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }       
        private void TableClick(object sender, DataGridViewCellMouseEventArgs e)
        {                                                                // Открытие таблицы        
            panelEdit.Visible = true;
            CreateColumns("oneMainTable");
            RefreshDataGridView(dataGridViewMain, "oneMainTable");
        }       
        private void btn_createTable_Click(object sender, EventArgs e)   // Создание таблицы
        {
            CreateForm createForm = new CreateForm(
                () => RefreshDataGridView(dataGridViewTables, "listTables") // Передаём метод для обновления названий таблиц в списке
                );
            createForm.ShowDialog();
        }
        private void btn_deleteTable_Click(object sender, EventArgs e)   // Удаление таблицы
        {
            if (dataGridViewTables.CurrentCell != null)
            {
                DeleteRow(dataGridViewTables);
                panelEdit.Visible = false;
                dataGridViewMain.Columns.Clear();
            }
            else MessageBox.Show("Не выбрана таблица для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_renameTable_Click(object sender, EventArgs e)   // Переименование таблицы
        {
            if (dataGridViewTables.CurrentCell != null)
            {
                RenameForm renameForm = new RenameForm(
                    NameTableSelect(),
                    () => RefreshDataGridView(dataGridViewTables, "listTables") // Передаём метод для обновления названий таблиц в списке                 
                    );
                renameForm.ShowDialog();
            }
            else MessageBox.Show("Не выбрана таблица для переименования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_editRow_Click(object sender, EventArgs e)       // Изменение строки таблицы
        {
            if (dataGridViewMain.CurrentCell != null)
            {
                int index = dataGridViewMain.CurrentCell.RowIndex;

                EditRowForm editRowForm = new EditRowForm(
                    dataGridViewMain,
                    NameTableSelect(),
                    index,
                    NamesAndTypes,
                    textTypes,
                    () => RefreshDataGridView(dataGridViewMain, "oneMainTable") // Передаём метод для обновления названий таблиц в списке
                    );

                editRowForm.ShowDialog();
            }
            else MessageBox.Show("Нет строк для изменения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_addRow_Click(object sender, EventArgs e)        // Добавление строки таблицы
        {
            AddRowForm addrowForm = new AddRowForm(
                NameTableSelect(),
                NamesAndTypes,
                textTypes,
                dateTypes,
                () => RefreshDataGridView(dataGridViewMain, "oneMainTable") // Передаём метод для обновления названий таблиц в списке
                );

            addrowForm.ShowDialog();
        }
        private void btn_deleteRow_Click(object sender, EventArgs e)     // Удаление строки таблицы
        {
            if (dataGridViewMain.CurrentCell != null)
            {
                DeleteRow(dataGridViewMain);
                RefreshDataGridView(dataGridViewMain, "oneMainTable");
            }
            else MessageBox.Show("Нет строк для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btn_editColumn_Click(object sender, EventArgs e)    // Редактирование столбца
        {
            if (dataGridViewMain.CurrentCell != null)
            {
                int index = dataGridViewMain.CurrentCell.ColumnIndex;

                EditColumnForm editColumnForm = new EditColumnForm(
                    dataGridViewMain,
                    NameTableSelect(),
                    index,
                    NamesAndTypes,
                    textTypes,
                    () =>    // Передаём метод для обновления таблицы
                    {
                        CreateColumns("oneMainTable");
                        RefreshDataGridView(dataGridViewMain, "oneMainTable");
                    }
                    );
                editColumnForm.ShowDialog();
            }
            else MessageBox.Show("Нет столбцов для изменения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }
        private void btn_addColumn_Click(object sender, EventArgs e)     // Добавление столбца
        {
            AddColumnForm addColumnForm = new AddColumnForm(
                NameTableSelect(),
                () =>       // Передаём метод для обновления таблицы
                { 
                    CreateColumns("oneMainTable"); 
                    RefreshDataGridView(dataGridViewMain, "oneMainTable"); 
                }
                );
            addColumnForm.ShowDialog();                            
        }
        private void btn_deleteColumn_Click(object sender, EventArgs e)  // Удаление столбца
        {
            if (dataGridViewMain.CurrentCell != null)
            {
                if (dataGridViewMain.CurrentCell.ColumnIndex != 0)
                {
                    DeleteColumn();

                    CreateColumns("oneMainTable");
                    RefreshDataGridView(dataGridViewMain, "oneMainTable");
                }
                else MessageBox.Show("Нельзя удалить первичный ключ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Нет столбцов для удаления!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        /*******************************************************************************************************
        * ОБЩИЕ МЕТОДЫ ДЛЯ ВЫВОДА ТАБЛИЦЫ                                                                      *
        * CreateColumns() - создает столбцы конкретной таблицы в DataGridView                                  *
        * ReadSingleRow() - задаёт типы данных для всех полей таблицы                                          *
        * RefreshDataGridView() - выводит данные в таблицу                                                     *
        *******************************************************************************************************/
        private void CreateColumns(string str)
        {
            dataGridViewMain.Columns.Clear();
            if (str == "listTables")
                dataGridViewTables.Columns.Add("TABLE_NAME", "Название");
            else
            {
                RefreshNameAndTypes();
                NamesAndTypes.ForEach(value =>
                {
                    dataGridViewMain.Columns.Add(value.Item1, value.Item1);
                });                
            }
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record, string str, int numberRow)
        {            
            // IDataRecord предоставляет доступ к значениям столобцов для каждой строки (исп. для DataReader)            
            if (str == "listTables")
            {
                dgw.Rows.Add(
                    record.GetString(0)
                );
            }
            else
            {              
                dgw.Rows.Add();                
                int numberColumn = 0;
                NamesAndTypes.ForEach(value =>
                {
                    if (record.IsDBNull(numberColumn))
                    {
                        dgw.Rows[numberRow].Cells[numberColumn].Value = "null";
                    }
                    else if (value.Item2 == "bigint")
                    {
                        dgw.Rows[numberRow].Cells[numberColumn].Value = record.GetInt64(numberColumn);
                    }
                    else if (value.Item2 == "int" || value.Item2 == "int identity")
                    {
                        dgw.Rows[numberRow].Cells[numberColumn].Value = record.GetInt32(numberColumn);
                    }
                    else if (value.Item2 == "smallint")
                    {
                        dgw.Rows[numberRow].Cells[numberColumn].Value = record.GetInt16(numberColumn);
                    }
                    else if (value.Item2 == "tinyint")
                    {
                        dgw.Rows[numberRow].Cells[numberColumn].Value = record.GetByte(numberColumn);
                    }
                    else if (value.Item2 == "bit")
                    {
                        dgw.Rows[numberRow].Cells[numberColumn].Value = record.GetBoolean(numberColumn);
                    }
                    else if (textTypes.Contains(value.Item2) || value.Item2 == "sysname")
                    {
                        dgw.Rows[numberRow].Cells[numberColumn].Value = record.GetString(numberColumn);
                    }
                    else if (value.Item2 == "float")
                    {
                        dgw.Rows[numberRow].Cells[numberColumn].Value = record.GetDouble(numberColumn);
                    }
                    else if (dateTypes.Contains(value.Item2))
                    {
                        dgw.Rows[numberRow].Cells[numberColumn].Value = record.GetDateTime(numberColumn);
                    }
                    else 
                    {
                        dgw.Rows[numberRow].Cells[numberColumn].Value = record.GetFieldType(numberColumn);
                    }
                    numberColumn++;
                });
            }
        }        
        private void RefreshDataGridView(DataGridView dgw, string str)
        {
            dgw.Rows.Clear();   

            string queryString = 
                (str == "listTables") ?
                "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES;" : 
                $"SELECT * FROM [{NameTableSelect()}];";

            SqlCommand command = new SqlCommand(queryString, sqlConnection.getConnection()); // Создание запроса

            sqlConnection.openConnection();

            SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса       

            int numberRow = 0;
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader, str, numberRow);
                numberRow++;
            }
            reader.Close();

            sqlConnection.closeConnection();
        }
        /*******************************************************************************************************
        * ВТОРОСТЕПЕННЫЕ МЕТОДЫ                                                                                *
        * NameTableSelect() - возвращает название выбранной таблицы в панели слева                             *
        * RefreshNameAndTypes() - его вызов обновляет данные о выбранной таблице в списке NamesAndTypes        *      
        * DeleteTable() - создаёт запрос на удаление выбр. строки из списка таблиц(с удал-ем таблицы)/таблицы  *      
        * DeleteColumn() - удаляет выбранный столбец в таблице                                                 *
        * CheckConnection() - проверка подключения к БД                                                        *
        *******************************************************************************************************/
        private string NameTableSelect()
        {
            int index;
            if (dataGridViewTables.CurrentCell != null)
            {
                index = dataGridViewTables.CurrentCell.RowIndex;
                return dataGridViewTables.Rows[index].Cells[0].Value.ToString();
            }
            return String.Empty;
        }
        private void RefreshNameAndTypes()
        {
            NamesAndTypes.Clear();

            try
            {
                sqlConnection.openConnection();

                SqlCommand command = new SqlCommand($"EXEC sp_columns {NameTableSelect()}", sqlConnection.getConnection());

                using (SqlDataReader dr = command.ExecuteReader(CommandBehavior.CloseConnection))
                {                    
                    while (dr.Read()) // Чтение данных из таблицы с информацией о всех полях таблицы
                    {
                        NamesAndTypes.Add(
                            (dr.GetValue(3).ToString().Trim(), 
                            dr.GetValue(5).ToString().Trim())
                            );
                    }
                    dr.Close();
                }
            }
            catch (SqlException se)
            {
                Console.WriteLine(se.Message);
            }
            finally
            {
                sqlConnection.closeConnection();
                //sqlConnection.Dispose();
            }
        }
        private void DeleteRow(DataGridView dgw)
        {
            RefreshNameAndTypes();

            int index = dgw.CurrentCell.RowIndex; // индекс строки, на к-й находимся

            var deleteQuery =
                (dgw == dataGridViewTables) ?
                $"drop table {NameTableSelect()};" 
                :
                $"delete from {NameTableSelect()} " +
                $"where {NamesAndTypes[0].Item1} = {dgw.Rows[index].Cells[0].Value};";

            Console.WriteLine(deleteQuery);
            sqlConnection.openConnection();

            var command = new SqlCommand(deleteQuery, sqlConnection.getConnection());
            command.ExecuteNonQuery();
            dgw.Rows[index].Visible = false;

            sqlConnection.closeConnection();

            MessageBox.Show("Успешно удалено!",
                    "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DeleteColumn()
        {
            int index = dataGridViewMain.CurrentCell.ColumnIndex;

            string query = 
                $"alter table {NameTableSelect()} drop column {NamesAndTypes[index].Item1};";

            sqlConnection.openConnection();

            var command = new SqlCommand(query, sqlConnection.getConnection());
            command.ExecuteNonQuery();

            sqlConnection.closeConnection();

            MessageBox.Show("Успешно удалено!",
                    "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool CheckConnection()
        {
            try
            {
                string queryString =
                    "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES;";

                SqlCommand command = new SqlCommand(queryString, sqlConnection.getConnection()); // Создание запроса

                sqlConnection.openConnection();

                SqlDataReader reader = command.ExecuteReader(); // Выполнение запроса       

                sqlConnection.closeConnection();

                return true;
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться!",
                    "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Close();
                return false;
            }
        }
    }
}