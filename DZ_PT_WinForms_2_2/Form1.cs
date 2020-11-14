using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace DZ_PT_WinForms_2_2
{
    public partial class Form1 : Form
    {
        string path_txt = "info.txt";
        string path_xml = "info.xml";
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
                {
                    MessageBox.Show("Запись существует.");
                }
            }
            else
            {
                MessageBox.Show("Пустая строка.");
            }
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
            toolStripStatusLabel_Time.Text = DateTime.Now.ToLongTimeString();
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
        private void button_Export_Click(object sender, EventArgs e)
        {
            List<object> listTemp = new List<object>();
            if (listBox_UserInfo.Items.Count != 0)
            {
                foreach (string item in listBox_UserInfo.Items)
                    listTemp.Add(item);
            }
            else
            {
                MessageBox.Show("Нет данных для записи.");
            }
            if (radioButton_TXT.Checked)
            {
                WriteFileTXT(path_txt, listTemp);
            }
            else if (radioButton_XML.Checked)
            {
                WriteFileXML(path_xml, listTemp);
            }
        }
        private void button_Import_Click(object sender, EventArgs e)
        {
            if (radioButton_TXT.Checked)
            {
                if (File.Exists(path_txt))
                {
                    List<object> listTemp = ReadFileTXT(path_txt);
                    foreach (object item in listTemp)
                    {
                        listBox_UserInfo.Items.Add(item);
                    }
                    MessageBox.Show("Файл \"" + path_txt + "\" прочитан."); 
                }
                else
                {
                    MessageBox.Show("Файл не найден.");
                }
            }
            else if (radioButton_XML.Checked)
            {
                if (File.Exists(path_xml))
                {
                    List<object> listTemp = ReadFileXML(path_xml);
                    foreach (object item in listTemp)
                    {
                        listBox_UserInfo.Items.Add(item);
                    }
                    MessageBox.Show("Файл \"" + path_xml + "\" прочитан.");
                }
                else
                {
                    MessageBox.Show("Файл не найден.");
                }
            }
        }
         static void WriteFileTXT(string pathTxt, List<object> listTemp)
         {
            bool addToFile = false;
            if (File.Exists(pathTxt))
                addToFile = true;
            using (StreamWriter sw = new StreamWriter(pathTxt, addToFile))
            {
                foreach (object item in listTemp)
                {
                    sw.WriteLine(item);
                }
            }
            MessageBox.Show("Файл \"" + pathTxt + "\" записан.");
         }
        static List<object> ReadFileTXT(string path_txt)
        {
            List<object> listTemp = new List<object>();
            using (StreamReader sr = new StreamReader(path_txt))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listTemp.Add(line);
                }
            }
            return listTemp;
        }
        static void WriteFileXML(string path_xml, List<object> listTemp)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(List<object>));
            using (FileStream fs = new FileStream(path_xml, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, listTemp);
            }
            MessageBox.Show("Файл \"" + path_xml + "\" записан.");
        }
        static List<object> ReadFileXML(string path_xml)
        {
            List<object> listTemp = new List<object>();
            XmlSerializer formatter = new XmlSerializer(typeof(List<object>));
            using (FileStream fs = new FileStream(path_xml, FileMode.Open))
            {
                listTemp = (List<object>)formatter.Deserialize(fs);
            }
            return listTemp;
        }
    }
}