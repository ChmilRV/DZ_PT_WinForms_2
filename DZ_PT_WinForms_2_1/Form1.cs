using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_PT_WinForms_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "0 %";




        }

        public void LoadMyFile()
        {
            OpenFileDialog openFile1 = new OpenFileDialog();
            //openFile1.DefaultExt = "*.rtf";
            //openFile1.Filter = "RTF Files|*.rtf";

            if (openFile1.ShowDialog() == DialogResult.OK && openFile1.FileName.Length > 0)
            {
                richTextBox1.LoadFile(openFile1.FileName);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            LoadMyFile();


            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Step = 5;

            for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
            {
                progressBar1.PerformStep();
                label1.Text = progressBar1.Value.ToString() + " %";
                this.Update();
                Thread.Sleep(100);
            }
        }

        private void richTextBox1_VScroll(object sender, EventArgs e)
        {


            //MessageBox.Show(richTextBox1.ScrollBars.ToString());


        }
    }
}
