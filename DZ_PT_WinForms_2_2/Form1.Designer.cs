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
            this.contextMenuStrip_EditDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Edit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Delete_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox_ = new System.Windows.Forms.GroupBox();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.contextMenuStrip_About = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_DayOfWeek = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_Space = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_mail = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox_Export = new System.Windows.Forms.GroupBox();
            this.button_Import = new System.Windows.Forms.Button();
            this.radioButton_ExportXML = new System.Windows.Forms.RadioButton();
            this.button_Export = new System.Windows.Forms.Button();
            this.radioButton_ExportTXT = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip_EditDelete.SuspendLayout();
            this.groupBox_.SuspendLayout();
            this.contextMenuStrip_About.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox_Export.SuspendLayout();
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
            this.textBox_Name.TabIndex = 1;
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
            this.textBox_Email.TabIndex = 2;
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
            this.textBox_PhoneNumber.TabIndex = 3;
            // 
            // listBox_UserInfo
            // 
            this.listBox_UserInfo.ContextMenuStrip = this.contextMenuStrip_EditDelete;
            this.listBox_UserInfo.FormattingEnabled = true;
            this.listBox_UserInfo.Location = new System.Drawing.Point(249, 12);
            this.listBox_UserInfo.Name = "listBox_UserInfo";
            this.listBox_UserInfo.Size = new System.Drawing.Size(323, 173);
            this.listBox_UserInfo.TabIndex = 2;
            // 
            // contextMenuStrip_EditDelete
            // 
            this.contextMenuStrip_EditDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Edit_ToolStripMenuItem,
            this.Delete_ToolStripMenuItem});
            this.contextMenuStrip_EditDelete.Name = "contextMenuStrip_EditDelete";
            this.contextMenuStrip_EditDelete.Size = new System.Drawing.Size(155, 48);
            // 
            // Edit_ToolStripMenuItem
            // 
            this.Edit_ToolStripMenuItem.Name = "Edit_ToolStripMenuItem";
            this.Edit_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.Edit_ToolStripMenuItem.Text = "Редактировать";
            this.Edit_ToolStripMenuItem.Click += new System.EventHandler(this.Edit_ToolStripMenuItem_Click);
            // 
            // Delete_ToolStripMenuItem
            // 
            this.Delete_ToolStripMenuItem.Name = "Delete_ToolStripMenuItem";
            this.Delete_ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.Delete_ToolStripMenuItem.Text = "Удалить";
            this.Delete_ToolStripMenuItem.Click += new System.EventHandler(this.Delete_ToolStripMenuItem_Click);
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
            this.groupBox_.Size = new System.Drawing.Size(219, 173);
            this.groupBox_.TabIndex = 3;
            this.groupBox_.TabStop = false;
            this.groupBox_.Text = "Анкета";
            // 
            // button_AddUser
            // 
            this.button_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddUser.Location = new System.Drawing.Point(13, 198);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(218, 60);
            this.button_AddUser.TabIndex = 4;
            this.button_AddUser.Text = "ДОБАВИТЬ";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.button_AddUser_Click);
            // 
            // contextMenuStrip_About
            // 
            this.contextMenuStrip_About.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.contextMenuStrip_About.Name = "contextMenuStrip_About";
            this.contextMenuStrip_About.Size = new System.Drawing.Size(108, 26);
            this.contextMenuStrip_About.Click += new System.EventHandler(this.contextMenuStrip_About_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_DayOfWeek,
            this.toolStripStatusLabel_Date,
            this.toolStripStatusLabel_Time,
            this.toolStripStatusLabel_Space,
            this.toolStripStatusLabel_mail});
            this.statusStrip1.Location = new System.Drawing.Point(0, 269);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(584, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            this.toolTip1.SetToolTip(this.statusStrip1, " ");
            // 
            // toolStripStatusLabel_DayOfWeek
            // 
            this.toolStripStatusLabel_DayOfWeek.Name = "toolStripStatusLabel_DayOfWeek";
            this.toolStripStatusLabel_DayOfWeek.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel_Date
            // 
            this.toolStripStatusLabel_Date.Name = "toolStripStatusLabel_Date";
            this.toolStripStatusLabel_Date.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel_Time
            // 
            this.toolStripStatusLabel_Time.Name = "toolStripStatusLabel_Time";
            this.toolStripStatusLabel_Time.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel_Space
            // 
            this.toolStripStatusLabel_Space.Name = "toolStripStatusLabel_Space";
            this.toolStripStatusLabel_Space.Size = new System.Drawing.Size(253, 17);
            this.toolStripStatusLabel_Space.Text = "                                                                                 " +
    " ";
            // 
            // toolStripStatusLabel_mail
            // 
            this.toolStripStatusLabel_mail.IsLink = true;
            this.toolStripStatusLabel_mail.Name = "toolStripStatusLabel_mail";
            this.toolStripStatusLabel_mail.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel_mail.Text = "chmilrv@gmail.com";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // groupBox_Export
            // 
            this.groupBox_Export.Controls.Add(this.button_Import);
            this.groupBox_Export.Controls.Add(this.radioButton_ExportXML);
            this.groupBox_Export.Controls.Add(this.button_Export);
            this.groupBox_Export.Controls.Add(this.radioButton_ExportTXT);
            this.groupBox_Export.Location = new System.Drawing.Point(249, 191);
            this.groupBox_Export.Name = "groupBox_Export";
            this.groupBox_Export.Size = new System.Drawing.Size(323, 67);
            this.groupBox_Export.TabIndex = 6;
            this.groupBox_Export.TabStop = false;
            // 
            // button_Import
            // 
            this.button_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Import.Location = new System.Drawing.Point(198, 15);
            this.button_Import.Name = "button_Import";
            this.button_Import.Size = new System.Drawing.Size(125, 40);
            this.button_Import.TabIndex = 7;
            this.button_Import.Text = "IMPORT";
            this.button_Import.UseVisualStyleBackColor = true;
            this.button_Import.Click += new System.EventHandler(this.button_Import_Click);
            // 
            // radioButton_ExportXML
            // 
            this.radioButton_ExportXML.AutoSize = true;
            this.radioButton_ExportXML.Location = new System.Drawing.Point(17, 38);
            this.radioButton_ExportXML.Name = "radioButton_ExportXML";
            this.radioButton_ExportXML.Size = new System.Drawing.Size(40, 17);
            this.radioButton_ExportXML.TabIndex = 1;
            this.radioButton_ExportXML.TabStop = true;
            this.radioButton_ExportXML.Text = "xml";
            this.radioButton_ExportXML.UseVisualStyleBackColor = true;
            // 
            // button_Export
            // 
            this.button_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Export.Location = new System.Drawing.Point(63, 15);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(125, 40);
            this.button_Export.TabIndex = 7;
            this.button_Export.Text = "EXPORT";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.button_Export_Click);
            // 
            // radioButton_ExportTXT
            // 
            this.radioButton_ExportTXT.AutoSize = true;
            this.radioButton_ExportTXT.Checked = true;
            this.radioButton_ExportTXT.Location = new System.Drawing.Point(17, 13);
            this.radioButton_ExportTXT.Name = "radioButton_ExportTXT";
            this.radioButton_ExportTXT.Size = new System.Drawing.Size(36, 17);
            this.radioButton_ExportTXT.TabIndex = 0;
            this.radioButton_ExportTXT.TabStop = true;
            this.radioButton_ExportTXT.Text = "txt";
            this.radioButton_ExportTXT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.ContextMenuStrip = this.contextMenuStrip_About;
            this.Controls.Add(this.groupBox_Export);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_AddUser);
            this.Controls.Add(this.groupBox_);
            this.Controls.Add(this.listBox_UserInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DZ_PT_WinForms_2_2";
            this.contextMenuStrip_EditDelete.ResumeLayout(false);
            this.groupBox_.ResumeLayout(false);
            this.groupBox_.PerformLayout();
            this.contextMenuStrip_About.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox_Export.ResumeLayout(false);
            this.groupBox_Export.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_About;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Time;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_DayOfWeek;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_mail;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_Space;
        private System.Windows.Forms.GroupBox groupBox_Export;
        private System.Windows.Forms.RadioButton radioButton_ExportXML;
        private System.Windows.Forms.RadioButton radioButton_ExportTXT;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Button button_Import;
    }
}

