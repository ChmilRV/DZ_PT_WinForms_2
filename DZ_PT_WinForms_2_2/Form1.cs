using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_PT_WinForms_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_AddUser_Click(object sender, EventArgs e)
        {
            String userFullInfo = String.Empty;
            userFullInfo = textBox_Surname.Text + " " + textBox_Name.Text + ", " + textBox_Email.Text + ", " + textBox_PhoneNumber.Text;
            if (!String.IsNullOrEmpty(userFullInfo))
            {
                if (!listBox_UserInfo.Items.Contains(userFullInfo))
                {
                    listBox_UserInfo.Items.Add(userFullInfo);
                }
                else
                    MessageBox.Show("Strings must be unique");
            }
            else
                MessageBox.Show("Empty string");
            textBox_Surname.Text = string.Empty;
            textBox_Name.Text = string.Empty;
            textBox_Email.Text = string.Empty;
            textBox_PhoneNumber.Text = string.Empty;
        }

        

        private void Edit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //textBox_Surname.Text = string.Empty;
            //textBox_Name.Text = string.Empty;
            //textBox_Email.Text = string.Empty;
            //textBox_PhoneNumber.Text = string.Empty;

            if (this.listBox_UserInfo.Items.Count != 0)
            {
                if (this.listBox_UserInfo.SelectedItem != null)
                {
                    String userFullInfo= (String)listBox_UserInfo.SelectedItem;

                    textBox_Surname.Text = userFullInfo.Remove(userFullInfo.IndexOf(' '));

                    textBox_Name.Text = userFullInfo.Substring(userFullInfo.IndexOf(' ') + 1, userFullInfo.IndexOf(',') - userFullInfo.IndexOf(' ') - 1);

                    //textBox_Email.Text =;

                    //textBox_PhoneNumber =;
                    listBox_UserInfo.Items.Remove(userFullInfo);


                }
            }


            







        }




        private void Delete_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.listBox_UserInfo.Items.Count != 0)
            {
                if (this.listBox_UserInfo.SelectedItems != null)
                {
                    for (int i = 0; i < this.listBox_UserInfo.SelectedItems.Count; i++)
                    {
                        this.listBox_UserInfo.Items.Remove(this.listBox_UserInfo.SelectedItems[i]);
                        i--;
                    }
                }
            }



        }


        private void contextMenuStrip_About_Click(object sender, EventArgs e)
        {
            contextMenuStrip_About.Visible = false;

            MessageBox.Show("Приложение – анкета.\n" +
                "Кнопка «Add» добавляет пользователя в окно хранения информации.\n" +
                "В окне хранения через контекстное меню реализовано удаление пользователя и редактирование.\n" +
                "экспорт / импорт всей информации о пользователях в текстовый файл.\n" +
                "экспорт / импорт всей информации о пользователях в *.xml файл.",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);


        }






    }
}
