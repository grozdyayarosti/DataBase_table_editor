namespace test_DataBase2
{
    partial class CreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_nameTable = new System.Windows.Forms.TextBox();
            this.textBox_typesFields = new System.Windows.Forms.TextBox();
            this.textBox_namesFields = new System.Windows.Forms.TextBox();
            this.textBox_primaryKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_create = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(273, 304);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Пример: \"varchar(50) varchar(50) int float\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(273, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Пример: \"name type amount price\"";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(273, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Пример: \"id\"";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(273, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Пример: \"table1\"";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_save.Location = new System.Drawing.Point(339, 338);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(110, 49);
            this.btn_save.TabIndex = 50;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Первичный ключ:";
            // 
            // textBox_nameTable
            // 
            this.textBox_nameTable.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_nameTable.Location = new System.Drawing.Point(273, 118);
            this.textBox_nameTable.Name = "textBox_nameTable";
            this.textBox_nameTable.Size = new System.Drawing.Size(311, 20);
            this.textBox_nameTable.TabIndex = 48;
            // 
            // textBox_typesFields
            // 
            this.textBox_typesFields.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_typesFields.Location = new System.Drawing.Point(273, 281);
            this.textBox_typesFields.Name = "textBox_typesFields";
            this.textBox_typesFields.Size = new System.Drawing.Size(311, 20);
            this.textBox_typesFields.TabIndex = 47;
            // 
            // textBox_namesFields
            // 
            this.textBox_namesFields.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_namesFields.Location = new System.Drawing.Point(273, 224);
            this.textBox_namesFields.Name = "textBox_namesFields";
            this.textBox_namesFields.Size = new System.Drawing.Size(311, 20);
            this.textBox_namesFields.TabIndex = 46;
            // 
            // textBox_primaryKey
            // 
            this.textBox_primaryKey.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_primaryKey.Location = new System.Drawing.Point(273, 171);
            this.textBox_primaryKey.Name = "textBox_primaryKey";
            this.textBox_primaryKey.Size = new System.Drawing.Size(311, 20);
            this.textBox_primaryKey.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Типы полей(через пробел):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Имя таблицы:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Названия полей(через пробел):";
            // 
            // panel_create
            // 
            this.panel_create.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_create.Controls.Add(this.label1);
            this.panel_create.Location = new System.Drawing.Point(30, 12);
            this.panel_create.Name = "panel_create";
            this.panel_create.Size = new System.Drawing.Size(741, 79);
            this.panel_create.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создание таблицы";
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 398);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_nameTable);
            this.Controls.Add(this.textBox_typesFields);
            this.Controls.Add(this.textBox_namesFields);
            this.Controls.Add(this.textBox_primaryKey);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_create);
            this.Name = "CreateForm";
            this.Text = "Создание таблицы";
            this.panel_create.ResumeLayout(false);
            this.panel_create.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_nameTable;
        private System.Windows.Forms.TextBox textBox_typesFields;
        private System.Windows.Forms.TextBox textBox_namesFields;
        private System.Windows.Forms.TextBox textBox_primaryKey;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_create;
        private System.Windows.Forms.Label label1;
    }
}