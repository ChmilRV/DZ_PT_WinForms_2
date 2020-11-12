namespace DZ_PT_WinForms_2_2
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
            this.components = new System.ComponentModel.Container();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.label_Surname = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.label_PhoneNumber = new System.Windows.Forms.Label();
            this.textBox_PhoneNumber = new System.Windows.Forms.TextBox();
            this.listBox_UserInfo = new System.Windows.Forms.ListBox();
            this.groupBox_ = new System.Windows.Forms.GroupBox();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.contextMenuStrip_EditDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_.SuspendLayout();
            this.contextMenuStrip_EditDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(77, 30);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.Size = new System.Drawing.Size(127, 20);
            this.textBox_Surname.TabIndex = 0;
            // 
            // label_Surname
            // 
            this.label_Surname.AutoSize = true;
            this.label_Surname.Location = new System.Drawing.Point(15, 37);
            this.label_Surname.Name = "label_Surname";
            this.label_Surname.Size = new System.Drawing.Size(56, 13);
            this.label_Surname.TabIndex = 1;
            this.label_Surname.Text = "Фамилия";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(15, 72);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(29, 13);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Имя";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(77, 65);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(127, 20);
            this.textBox_Name.TabIndex = 0;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(15, 109);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(35, 13);
            this.label_Email.TabIndex = 1;
            this.label_Email.Text = "E-mail";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(77, 106);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(127, 20);
            this.textBox_Email.TabIndex = 0;
            // 
            // label_PhoneNumber
            // 
            this.label_PhoneNumber.AutoSize = true;
            this.label_PhoneNumber.Location = new System.Drawing.Point(15, 148);
            this.label_PhoneNumber.Name = "label_PhoneNumber";
            this.label_PhoneNumber.Size = new System.Drawing.Size(52, 13);
            this.label_PhoneNumber.TabIndex = 1;
            this.label_PhoneNumber.Text = "Телефон";
            // 
            // textBox_PhoneNumber
            // 
            this.textBox_PhoneNumber.Location = new System.Drawing.Point(77, 145);
            this.textBox_PhoneNumber.Name = "textBox_PhoneNumber";
            this.textBox_PhoneNumber.Size = new System.Drawing.Size(127, 20);
            this.textBox_PhoneNumber.TabIndex = 0;
            // 
            // listBox_UserInfo
            // 
            this.listBox_UserInfo.FormattingEnabled = true;
            this.listBox_UserInfo.Location = new System.Drawing.Point(249, 12);
            this.listBox_UserInfo.Name = "listBox_UserInfo";
            this.listBox_UserInfo.Size = new System.Drawing.Size(323, 225);
            this.listBox_UserInfo.TabIndex = 2;
            // 
            // groupBox_
            // 
            this.groupBox_.Controls.Add(this.textBox_Surname);
            this.groupBox_.Controls.Add(this.label_Surname);
            this.groupBox_.Controls.Add(this.label_PhoneNumber);
            this.groupBox_.Controls.Add(this.textBox_PhoneNumber);
            this.groupBox_.Controls.Add(this.label_Email);
            this.groupBox_.Controls.Add(this.textBox_Name);
            this.groupBox_.Controls.Add(this.label_Name);
            this.groupBox_.Controls.Add(this.textBox_Email);
            this.groupBox_.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_.Location = new System.Drawing.Point(12, 12);
            this.groupBox_.Name = "groupBox_";
            this.groupBox_.Size = new System.Drawing.Size(219, 180);
            this.groupBox_.TabIndex = 3;
            this.groupBox_.TabStop = false;
            this.groupBox_.Text = "Анкета";
            // 
            // button_AddUser
            // 
            this.button_AddUser.Location = new System.Drawing.Point(13, 198);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(218, 39);
            this.button_AddUser.TabIndex = 4;
            this.button_AddUser.Text = "Add";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // contextMenuStrip_EditDelete
            // 
            this.contextMenuStrip_EditDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit_ToolStripMenuItem,
            this.Delete_ToolStripMenuItem});
            this.contextMenuStrip_EditDelete.Name = "contextMenuStrip_EditDelete";
            this.contextMenuStrip_EditDelete.Size = new System.Drawing.Size(155, 48);
            this.contextMenuStrip_EditDelete.Text = "rtrtrrt";
            // 
            // Edit_ToolStripMenuItem
            // 
            this.Edit_ToolStripMenuItem.Name = "Edit_ToolStripMenuItem";
            this.Edit_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.Edit_ToolStripMenuItem.Text = "Редактировать";
            this.Edit_ToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // Delete_ToolStripMenuItem
            // 
            this.Delete_ToolStripMenuItem.Name = "Delete_ToolStripMenuItem";
            this.Delete_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.Delete_ToolStripMenuItem.Text = "Удалить";
            this.Delete_ToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.groupBox_);
            this.Controls.Add(this.listBox_UserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "DZ_PT_WinForms_2_2";
            this.groupBox_.ResumeLayout(false);
            this.groupBox_.PerformLayout();
            this.contextMenuStrip_EditDelete.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.Label label_Surname;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Label label_PhoneNumber;
        private System.Windows.Forms.TextBox textBox_PhoneNumber;
        private System.Windows.Forms.ListBox listBox_UserInfo;
        private System.Windows.Forms.GroupBox groupBox_;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_EditDelete;
        private System.Windows.Forms.ToolStripMenuItem Edit_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Delete_ToolStripMenuItem;
    }
}

