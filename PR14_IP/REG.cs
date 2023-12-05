using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR14_IP
{
    public partial class REG : Form
    {
        public REG()
        {
            InitializeComponent();
        }

        string hasnum = (@"[0-9]+");
        string hasUpperChar = (@"[A-Z]+");
        string hasMiniMaxChars = (@".{8}");
        string hasLowerChar = (@"[a-z]");
        string hasSym = (@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");
        private void regg_Click(object sender, EventArgs e)
        {
            if ((PAROL.Text == "") ||
                (NAME.Text == "") ||
                (LOGIN.Text == "") ||
                (mm.Text == "") ||
                (EMAIL.Text == ""))
                MessageBox.Show("Ведите данные!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!Regex.IsMatch(PAROL.Text, hasLowerChar))
                MessageBox.Show("Пароль должен содержать по крайней мере одну строчную букву!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!Regex.IsMatch(PAROL.Text, hasUpperChar))
                MessageBox.Show("Пароль должен содержать по крайней мере одну заглавную букву!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!Regex.IsMatch(PAROL.Text, hasMiniMaxChars))
                MessageBox.Show("Длина пароля не должна быть меньше 8 символов!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!Regex.IsMatch(PAROL.Text, hasnum))
                MessageBox.Show("Пароль должен содержать по крайней мере одно числовое значение!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (!Regex.IsMatch(PAROL.Text, hasSym))
                MessageBox.Show("Пароль должен содержать по крайней мере один символ особого регистра!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else this.Close();
        }
        public string FirstName
        {
            get { return NAME.Text; }
            set { NAME.Text = value; }
        }
        public string Login
        {
            get { return LOGIN.Text; }
            set { LOGIN.Text = value ; }
        }
        public string Password
        {
            get { return PAROL.Text; }
            set { PAROL.Text = value; }
        }
        public string Email
        {
            get { return (EMAIL.Text + mm.Text); }
            set { EMAIL.Text = value + mm.Text;
 }
        }
    }
}
