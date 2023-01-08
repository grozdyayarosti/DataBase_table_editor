namespace test_DataBase2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_renameTable = new System.Windows.Forms.Button();
            this.panelEdit = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_editColumn = new System.Windows.Forms.Button();
            this.btn_editRow = new System.Windows.Forms.Button();
            this.btn_deleteColumn = new System.Windows.Forms.Button();
            this.btn_deleteRow = new System.Windows.Forms.Button();
            this.btn_addRow = new System.Windows.Forms.Button();
            this.btn_addColumn = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTables = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(763, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Действия с таблицей";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_renameTable);
            this.panel1.Controls.Add(this.panelEdit);
            this.panel1.Controls.Add(this.btn_create);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Location = new System.Drawing.Point(766, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 444);
            this.panel1.TabIndex = 22;
            // 
            // btn_renameTable
            // 
            this.btn_renameTable.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_renameTable.Location = new System.Drawing.Point(4, 90);
            this.btn_renameTable.Name = "btn_renameTable";
            this.btn_renameTable.Size = new System.Drawing.Size(142, 36);
            this.btn_renameTable.TabIndex = 8;
            this.btn_renameTable.Text = "Переименовать таблицу";
            this.btn_renameTable.UseVisualStyleBackColor = false;
            this.btn_renameTable.Click += new System.EventHandler(this.btn_renameTable_Click);
            // 
            // panelEdit
            // 
            this.panelEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelEdit.Controls.Add(this.label6);
            this.panelEdit.Controls.Add(this.label5);
            this.panelEdit.Controls.Add(this.btn_editColumn);
            this.panelEdit.Controls.Add(this.btn_editRow);
            this.panelEdit.Controls.Add(this.btn_deleteColumn);
            this.panelEdit.Controls.Add(this.btn_deleteRow);
            this.panelEdit.Controls.Add(this.btn_addRow);
            this.panelEdit.Controls.Add(this.btn_addColumn);
            this.panelEdit.Location = new System.Drawing.Point(3, 132);
            this.panelEdit.Name = "panelEdit";
            this.panelEdit.Size = new System.Drawing.Size(144, 305);
            this.panelEdit.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Location = new System.Drawing.Point(3, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Столбцы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Строки";
            // 
            // btn_editColumn
            // 
            this.btn_editColumn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_editColumn.Location = new System.Drawing.Point(2, 175);
            this.btn_editColumn.Name = "btn_editColumn";
            this.btn_editColumn.Size = new System.Drawing.Size(136, 36);
            this.btn_editColumn.TabIndex = 14;
            this.btn_editColumn.Text = "Изменить столбец";
            this.btn_editColumn.UseVisualStyleBackColor = false;
            this.btn_editColumn.Click += new System.EventHandler(this.btn_editColumn_Click);
            // 
            // btn_editRow
            // 
            this.btn_editRow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_editRow.Location = new System.Drawing.Point(3, 25);
            this.btn_editRow.Name = "btn_editRow";
            this.btn_editRow.Size = new System.Drawing.Size(136, 36);
            this.btn_editRow.TabIndex = 12;
            this.btn_editRow.Text = "Изменить строку";
            this.btn_editRow.UseVisualStyleBackColor = false;
            this.btn_editRow.Click += new System.EventHandler(this.btn_editRow_Click);
            // 
            // btn_deleteColumn
            // 
            this.btn_deleteColumn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_deleteColumn.Location = new System.Drawing.Point(3, 261);
            this.btn_deleteColumn.Name = "btn_deleteColumn";
            this.btn_deleteColumn.Size = new System.Drawing.Size(136, 36);
            this.btn_deleteColumn.TabIndex = 11;
            this.btn_deleteColumn.Text = "Удалить столбец";
            this.btn_deleteColumn.UseVisualStyleBackColor = false;
            this.btn_deleteColumn.Click += new System.EventHandler(this.btn_deleteColumn_Click);
            // 
            // btn_deleteRow
            // 
            this.btn_deleteRow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_deleteRow.Location = new System.Drawing.Point(3, 109);
            this.btn_deleteRow.Name = "btn_deleteRow";
            this.btn_deleteRow.Size = new System.Drawing.Size(136, 36);
            this.btn_deleteRow.TabIndex = 10;
            this.btn_deleteRow.Text = "Удалить строку";
            this.btn_deleteRow.UseVisualStyleBackColor = false;
            this.btn_deleteRow.Click += new System.EventHandler(this.btn_deleteRow_Click);
            // 
            // btn_addRow
            // 
            this.btn_addRow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_addRow.Location = new System.Drawing.Point(3, 67);
            this.btn_addRow.Name = "btn_addRow";
            this.btn_addRow.Size = new System.Drawing.Size(136, 36);
            this.btn_addRow.TabIndex = 9;
            this.btn_addRow.Text = "Добавить строку";
            this.btn_addRow.UseVisualStyleBackColor = false;
            this.btn_addRow.Click += new System.EventHandler(this.btn_addRow_Click);
            // 
            // btn_addColumn
            // 
            this.btn_addColumn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_addColumn.Location = new System.Drawing.Point(2, 219);
            this.btn_addColumn.Name = "btn_addColumn";
            this.btn_addColumn.Size = new System.Drawing.Size(136, 36);
            this.btn_addColumn.TabIndex = 8;
            this.btn_addColumn.Text = "Добавить столбец";
            this.btn_addColumn.UseVisualStyleBackColor = false;
            this.btn_addColumn.Click += new System.EventHandler(this.btn_addColumn_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_create.Location = new System.Drawing.Point(5, 3);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(142, 39);
            this.btn_create.TabIndex = 2;
            this.btn_create.Text = "Создать таблицу";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_createTable_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_delete.Location = new System.Drawing.Point(5, 48);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(142, 36);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "Удалить таблицу";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_deleteTable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(155, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Текущая таблица";
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMain.Location = new System.Drawing.Point(158, 25);
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.ReadOnly = true;
            this.dataGridViewMain.Size = new System.Drawing.Size(602, 445);
            this.dataGridViewMain.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Список таблиц";
            // 
            // dataGridViewTables
            // 
            this.dataGridViewTables.AllowUserToAddRows = false;
            this.dataGridViewTables.AllowUserToDeleteRows = false;
            this.dataGridViewTables.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTables.Location = new System.Drawing.Point(8, 25);
            this.dataGridViewTables.Name = "dataGridViewTables";
            this.dataGridViewTables.ReadOnly = true;
            this.dataGridViewTables.Size = new System.Drawing.Size(144, 445);
            this.dataGridViewTables.TabIndex = 16;
            this.dataGridViewTables.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TableClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(925, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewTables);
            this.Name = "Form1";
            this.Text = "Редактор таблиц";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelEdit.ResumeLayout(false);
            this.panelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_renameTable;
        private System.Windows.Forms.Panel panelEdit;
        private System.Windows.Forms.Button btn_deleteColumn;
        private System.Windows.Forms.Button btn_deleteRow;
        private System.Windows.Forms.Button btn_addRow;
        private System.Windows.Forms.Button btn_addColumn;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewTables;
        private System.Windows.Forms.Button btn_editRow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_editColumn;
    }
}

