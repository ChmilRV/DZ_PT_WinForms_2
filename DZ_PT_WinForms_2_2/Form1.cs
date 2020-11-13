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
            timer1.Start();
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
            if (this.listBox_UserInfo.Items.Count != 0)
            {
                if (this.listBox_UserInfo.SelectedItem != null)
                {
                    String userFullInfo= (String)listBox_UserInfo.SelectedItem;
                    textBox_Surname.Text = userFullInfo.Remove(userFullInfo.IndexOf(' '));
                    textBox_Name.Text = userFullInfo.Substring(userFullInfo.IndexOf(' ') + 1, userFullInfo.IndexOf(',') - userFullInfo.IndexOf(' ') - 1);
                    textBox_Email.Text = userFullInfo.Substring(userFullInfo.IndexOf(',') + 2, userFullInfo.LastIndexOf(',') - userFullInfo.IndexOf(',') - 2);
                    textBox_PhoneNumber.Text =userFullInfo.Substring(userFullInfo.LastIndexOf(',') + 2);
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
                "Кнопка «Add» добавляет пользователя в окно хранения информации. " +
                "В окне хранения через контекстное меню реализовано удаление пользователя и редактирование. " +
                "экспорт / импорт всей информации о пользователях в текстовый файл. " +
                "экспорт / импорт всей информации о пользователях в *.xml файл.\n\n" +
                "chmilrv@gmail.com",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_DayOfWeek.Text = DateTime.Now.DayOfWeek.ToString();
            toolStripStatusLabel_Date.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabelTime.Text = DateTime.Now.ToLongTimeString();
        }
        private string TranslateDayOfWeek(string day)
        {
            Dictionary<string, string> DayOfWeek = new Dictionary<string, string>
            {
                ["Monday"] = "Понедельник",
                ["Tuesday"] = "Вторник",
                ["Wednesday"] = "Среда",
                ["Thursday"] = "Четверг",
                ["Friday"] = "Пятница",
                ["Saturday"] = "Суббота",
                ["Sunday"] = "Воскресенье"
            };
            foreach (KeyValuePair<string, string> days in DayOfWeek)
            {
                if (days.Key == DateTime.Now.DayOfWeek.ToString())
                    day = days.Value;
            }
            return day;
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            toolTip1.ToolTipTitle=TranslateDayOfWeek(DateTime.Now.DayOfWeek.ToString());
        }




        /*
         static void WriteFile(string path)
        {
            using (StreamWriter sw = File.CreateText(path))
            {
                Console.WriteLine("Enter the data to write to the file:");
                string writeText = Console.ReadLine();
                sw.WriteLine(writeText);
                foreach (var item in writeText)
                {
                    sw.Write($"{item} ");
                }
                Console.WriteLine("\nData recorded!");
            }
        }
        static string ReadFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                return sr.ReadToEnd();
            }
        }
         
         
         */





    }
}