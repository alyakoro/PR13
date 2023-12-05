using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR14
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            //
            EditPersonForm editForm = new EditPersonForm();

            //
            if (editForm.ShowDialog() == DialogResult.OK) return;

            ListViewItem newItem = personsListView.Items.Add(editForm.FirstName);
            newItem.SubItems.Add(editForm.LastName);
            newItem.SubItems.Add(editForm.Age.ToString());
            newItem.SubItems.Add(editForm.Telefone.ToString());
        }

        private void edit_Click(object sender, EventArgs e)
        {
            if (personsListView.SelectedItems.Count == 0) return;

            //
            ListViewItem item = personsListView.SelectedItems[0];
            //
            EditPersonForm editForm = new EditPersonForm();

            //
            editForm.FirstName = item.Text;
            editForm.LastName = item.SubItems[1].Text;
            editForm.Age = Convert.ToInt32(item.SubItems[2].Text);
            editForm.Telefone = item.SubItems[3].Text;
            if (editForm.ShowDialog() != DialogResult.OK) return;

            item.Text = editForm.FirstName;
            item.SubItems[1].Text = editForm.LastName;
            item.SubItems[2].Text = editForm.Age.ToString();
            item.SubItems[3].Text = editForm.Telefone;
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var sb = new StringBuilder();  
                foreach (ListViewItem str in personsListView.Items)
                {
                    foreach (ListViewItem.ListViewSubItem subItem in str.SubItems)
                    {
                        sb.Append(subItem.Text);
                        sb.Append(';'); 
                    }
                    sb.AppendLine();
                }
                System.IO.File.WriteAllText(saveFileDialog1.FileName, sb.ToString());
            }
        }
    }
}
