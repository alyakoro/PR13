using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PR13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вызов диалога задания шрифта
            fontDialog1.ShowDialog();
            textBox1.Font = fontDialog1.Font;
        }

        private void цветToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Вызов диалога задания цвета
            colorDialog1.ShowDialog();
            textBox1.ForeColor = colorDialog1.Color;
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            справка spr = new справка();
            spr.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Завершить работу?", "Предупреждение", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes) Application.Exit();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = String.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                this.Text = "Файл открыт " + fn;
                try
                {
                    StreamReader sr = new StreamReader(fn);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка чтения \n" + ex.ToString());
                }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                this.Text = "Файл сохранен " + fn;
                if (fn != string.Empty)
                {
                    FileInfo fi = new FileInfo(fn);
                    try
                    {
                        StreamWriter sw = fi.CreateText();
                        sw.Write(textBox1.Text);
                        sw.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка записи \n" + ex.ToString());
                    }
                }
            }
        }
    }
}
