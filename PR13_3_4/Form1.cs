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

namespace PR13_3_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || town.Text == "" || info.Text == "")
            {
                MessageBox.Show("Введите все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string fn = saveFileDialog1.FileName;
                    this.Text = "Файл сохранен " + fn;
                    using (StreamWriter sw = File.AppendText(fn))
                    {
                        string clas = radioclass();
                        sw.Write($"Имя: {name.Text} Город: {town.Text} Класс: {clas} Предмет: {info.Text}\n");
                    }
                }
            }
        }
        string radioclass()
        {
            string clas = "";
            if (radioButton1.Checked) clas = radioButton1.Text;
            else if (radioButton2.Checked) clas = radioButton2.Text;
            else if (radioButton3.Checked) clas = radioButton3.Text;
            else clas = "Класс не выбран";
            return clas;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Завершить работу?", "Предупреждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes) Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                string text = File.ReadAllText(fn);
                textBox1.Text = text;
            }
        }
    }
}
