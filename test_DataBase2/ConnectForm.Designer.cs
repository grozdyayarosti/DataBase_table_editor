namespace test_DataBase2
{
    partial class ConnectForm
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
            this.btn_save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Server = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_User_id = new System.Windows.Forms.TextBox();
            this.textBox_Database = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_create = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel_create.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_save.Location = new System.Drawing.Point(341, 259);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(126, 64);
            this.btn_save.TabIndex = 64;
            this.btn_save.Text = "Подключиться";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Название базы данных:";
            // 
            // textBox_Server
            // 
            this.textBox_Server.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_Server.Location = new System.Drawing.Point(255, 121);
            this.textBox_Server.Name = "textBox_Server";
            this.textBox_Server.Size = new System.Drawing.Size(311, 20);
            this.textBox_Server.TabIndex = 62;
            // 
            // textBox_Password
            // 
            this.textBox_Password.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_Password.Location = new System.Drawing.Point(255, 227);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(311, 20);
            this.textBox_Password.TabIndex = 61;
            // 
            // textBox_User_id
            // 
            this.textBox_User_id.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_User_id.Location = new System.Drawing.Point(255, 192);
            this.textBox_User_id.Name = "textBox_User_id";
            this.textBox_User_id.Size = new System.Drawing.Size(311, 20);
            this.textBox_User_id.TabIndex = 60;
            // 
            // textBox_Database
            // 
            this.textBox_Database.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_Database.Location = new System.Drawing.Point(255, 156);
            this.textBox_Database.Name = "textBox_Database";
            this.textBox_Database.Size = new System.Drawing.Size(311, 20);
            this.textBox_Database.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(201, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Название сервера:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Логин:";
            // 
            // panel_create
            // 
            this.panel_create.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_create.Controls.Add(this.label1);
            this.panel_create.Location = new System.Drawing.Point(12, 12);
            this.panel_create.Name = "panel_create";
            this.panel_create.Size = new System.Drawing.Size(741, 79);
            this.panel_create.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Подключение к базе данных";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(631, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 64);
            this.button1.TabIndex = 65;
            this.button1.Text = "Подключиться к локальной БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(767, 346);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Server);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_User_id);
            this.Controls.Add(this.textBox_Database);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel_create);
            this.Name = "ConnectForm";
            this.Text = "Подключение";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.panel_create.ResumeLayout(false);
            this.panel_create.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Server;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_User_id;
        private System.Windows.Forms.TextBox textBox_Database;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel_create;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}