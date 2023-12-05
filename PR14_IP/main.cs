using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR14_IP
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        string path = "note1.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            REG reg = new REG();

            //
            if (reg.ShowDialog() == DialogResult.OK) return;

            NAME.Text = reg.FirstName;
            LOGIN.Text = reg.Login;
            PAROL.Text = reg.Password;
            EMAIL.Text = reg.Email;

            try
            {
                string fileName = @"E:\TextFile.txt";
                FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate);

                StreamWriter writer = new StreamWriter(fs);
                writer.Write($"name: {NAME.Text} login: {LOGIN.Text}" +
                    $" passwrd: {PAROL.Text} e-mail: {EMAIL.Text}");
                MessageBox.Show("Текст сохранен в файл: TextFile.txt", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения в файл: TextFile.txt", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}
