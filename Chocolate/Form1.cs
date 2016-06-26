using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chocolate
{
    public partial class form1 : Form
    {
        private int cnt;
        public form1()
        {
            InitializeComponent();
            cnt = 0;
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

            string name = TextBox.Text.Trim();
            if (String.IsNullOrEmpty(name))
            {

                MessageBox.Show("The Name field can not be empty ");

            }

            Chocolate ch = new Chocolate();
            ch.Sno = ++cnt;
            ch.Name = name;
            AddToList(ch);
            clear();
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            if (cnt < 5)
            {
                MessageBox.Show("First enter the name of five Chocolate Manufacturers");
            }
            else
            {
                int count = listView.SelectedIndices[0];
                string name = TextBox.Text.Trim();
                Chocolate ch = new Chocolate();
                ch.Sno = ++cnt;
                ch.Name = name;
                ListViewItem lvi = new ListViewItem(ch.Sno.ToString());
                lvi.SubItems.Add(ch.Name);
                listView.Items.Insert(count+1, lvi);
                clear();
            }        
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            int count = listView.SelectedIndices.Count;
            if(count>0)
            {
                int curr = listView.SelectedIndices[0];
                ListViewItem lvi = listView.Items[curr];
                Chocolate ch = new Chocolate();
                ch.Sno = int.Parse(lvi.SubItems[0].Text);
                ch.Name = lvi.SubItems[1].Text;
                listView.Items.RemoveAt(curr);
                cnt--;
                   
            }
            else
            {
                MessageBox.Show("There is no data to delete");
            }
        }

        private void Sortbutton_Click(object sender, EventArgs e)
        {
            if (cnt > 0)
            {
                int count = listView.SelectedIndices[0];

                ListViewItem lvi = listView.Items[count];
                Chocolate ch = new Chocolate();
                ch.Sno = int.Parse(lvi.SubItems[0].Text);
                ch.Name = lvi.SubItems[1].Text;

               

            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            listView.Clear();
        }

        public void AddToList(Chocolate c)
        {


            ListViewItem lvi = new ListViewItem(c.Sno.ToString());
            lvi.SubItems.Add(c.Name);
            listView.Items.Add(lvi);
            
        }

        public void clear()
        {
            TextBox.Clear();
        }
    }
}
