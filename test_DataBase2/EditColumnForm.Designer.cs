namespace test_DataBase2
{
    partial class EditColumnForm
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
            this.tabName = new System.Windows.Forms.TabPage();
            this.btn_cancel3 = new System.Windows.Forms.Button();
            this.btn_okName = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.tabType = new System.Windows.Forms.TabPage();
            this.btn_cancel2 = new System.Windows.Forms.Button();
            this.btn_okType = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.label_type = new System.Windows.Forms.Label();
            this.tabValue = new System.Windows.Forms.TabPage();
            this.btn_cancel1 = new System.Windows.Forms.Button();
            this.btn_okValue = new System.Windows.Forms.Button();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.label_value = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabName.SuspendLayout();
            this.tabType.SuspendLayout();
            this.tabValue.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabName
            // 
            this.tabName.Controls.Add(this.btn_cancel3);
            this.tabName.Controls.Add(this.btn_okName);
            this.tabName.Controls.Add(this.textBoxName);
            this.tabName.Controls.Add(this.label_name);
            this.tabName.Location = new System.Drawing.Point(4, 22);
            this.tabName.Name = "tabName";
            this.tabName.Padding = new System.Windows.Forms.Padding(3);
            this.tabName.Size = new System.Drawing.Size(284, 77);
            this.tabName.TabIndex = 2;
            this.tabName.Text = "Название";
            this.tabName.UseVisualStyleBackColor = true;
            // 
            // btn_cancel3
            // 
            this.btn_cancel3.Location = new System.Drawing.Point(200, 45);
            this.btn_cancel3.Name = "btn_cancel3";
            this.btn_cancel3.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel3.TabIndex = 39;
            this.btn_cancel3.Text = "Отмена";
            this.btn_cancel3.UseVisualStyleBackColor = true;
            this.btn_cancel3.Click += new System.EventHandler(this.btn_cancelName_Click);
            // 
            // btn_okName
            // 
            this.btn_okName.Location = new System.Drawing.Point(105, 45);
            this.btn_okName.Name = "btn_okName";
            this.btn_okName.Size = new System.Drawing.Size(75, 23);
            this.btn_okName.TabIndex = 38;
            this.btn_okName.Text = "Ок";
            this.btn_okName.UseVisualStyleBackColor = true;
            this.btn_okName.Click += new System.EventHandler(this.btn_okName_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(13, 19);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(262, 20);
            this.textBoxName.TabIndex = 37;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(10, 3);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(156, 13);
            this.label_name.TabIndex = 36;
            this.label_name.Text = "Измените название столбца:";
            // 
            // tabType
            // 
            this.tabType.Controls.Add(this.btn_cancel2);
            this.tabType.Controls.Add(this.btn_okType);
            this.tabType.Controls.Add(this.textBoxType);
            this.tabType.Controls.Add(this.label_type);
            this.tabType.Location = new System.Drawing.Point(4, 22);
            this.tabType.Name = "tabType";
            this.tabType.Padding = new System.Windows.Forms.Padding(3);
            this.tabType.Size = new System.Drawing.Size(284, 77);
            this.tabType.TabIndex = 1;
            this.tabType.Text = "Тип";
            this.tabType.UseVisualStyleBackColor = true;
            // 
            // btn_cancel2
            // 
            this.btn_cancel2.Location = new System.Drawing.Point(200, 45);
            this.btn_cancel2.Name = "btn_cancel2";
            this.btn_cancel2.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel2.TabIndex = 39;
            this.btn_cancel2.Text = "Отмена";
            this.btn_cancel2.UseVisualStyleBackColor = true;
            this.btn_cancel2.Click += new System.EventHandler(this.btn_cancelType_Click);
            // 
            // btn_okType
            // 
            this.btn_okType.Location = new System.Drawing.Point(105, 45);
            this.btn_okType.Name = "btn_okType";
            this.btn_okType.Size = new System.Drawing.Size(75, 23);
            this.btn_okType.TabIndex = 38;
            this.btn_okType.Text = "Ок";
            this.btn_okType.UseVisualStyleBackColor = true;
            this.btn_okType.Click += new System.EventHandler(this.btn_okType_Click);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(13, 19);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(262, 20);
            this.textBoxType.TabIndex = 37;
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(10, 3);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(125, 13);
            this.label_type.TabIndex = 36;
            this.label_type.Text = "Измените тип столбца:";
            // 
            // tabValue
            // 
            this.tabValue.Controls.Add(this.btn_cancel1);
            this.tabValue.Controls.Add(this.btn_okValue);
            this.tabValue.Controls.Add(this.textBoxValue);
            this.tabValue.Controls.Add(this.label_value);
            this.tabValue.Location = new System.Drawing.Point(4, 22);
            this.tabValue.Name = "tabValue";
            this.tabValue.Padding = new System.Windows.Forms.Padding(3);
            this.tabValue.Size = new System.Drawing.Size(284, 77);
            this.tabValue.TabIndex = 0;
            this.tabValue.Text = "Значения";
            this.tabValue.UseVisualStyleBackColor = true;
            // 
            // btn_cancel1
            // 
            this.btn_cancel1.Location = new System.Drawing.Point(200, 45);
            this.btn_cancel1.Name = "btn_cancel1";
            this.btn_cancel1.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel1.TabIndex = 43;
            this.btn_cancel1.Text = "Отмена";
            this.btn_cancel1.UseVisualStyleBackColor = true;
            this.btn_cancel1.Click += new System.EventHandler(this.btn_cancelValue_Click);
            // 
            // btn_okValue
            // 
            this.btn_okValue.Location = new System.Drawing.Point(105, 45);
            this.btn_okValue.Name = "btn_okValue";
            this.btn_okValue.Size = new System.Drawing.Size(75, 23);
            this.btn_okValue.TabIndex = 42;
            this.btn_okValue.Text = "Ок";
            this.btn_okValue.UseVisualStyleBackColor = true;
            this.btn_okValue.Click += new System.EventHandler(this.btn_okValue_Click);
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(13, 19);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(262, 20);
            this.textBoxValue.TabIndex = 41;
            // 
            // label_value
            // 
            this.label_value.AutoSize = true;
            this.label_value.Location = new System.Drawing.Point(10, 3);
            this.label_value.Name = "label_value";
            this.label_value.Size = new System.Drawing.Size(229, 13);
            this.label_value.TabIndex = 40;
            this.label_value.Text = "Измените значения столбца(через пробел):";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabValue);
            this.tabControl.Controls.Add(this.tabType);
            this.tabControl.Controls.Add(this.tabName);
            this.tabControl.Location = new System.Drawing.Point(0, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(292, 103);
            this.tabControl.TabIndex = 26;
            // 
            // EditColumnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 98);
            this.Controls.Add(this.tabControl);
            this.Name = "EditColumnForm";
            this.Text = "Редактирование столбца";
            this.Load += new System.EventHandler(this.EditColumnForm_Load_1);
            this.tabName.ResumeLayout(false);
            this.tabName.PerformLayout();
            this.tabType.ResumeLayout(false);
            this.tabType.PerformLayout();
            this.tabValue.ResumeLayout(false);
            this.tabValue.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabName;
        private System.Windows.Forms.Button btn_cancel3;
        private System.Windows.Forms.Button btn_okName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TabPage tabType;
        private System.Windows.Forms.Button btn_cancel2;
        private System.Windows.Forms.Button btn_okType;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.TabPage tabValue;
        private System.Windows.Forms.Button btn_cancel1;
        private System.Windows.Forms.Button btn_okValue;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Label label_value;
        private System.Windows.Forms.TabControl tabControl;
    }
}