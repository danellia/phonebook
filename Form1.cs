using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        Serializer serializer = new Serializer();
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonViewAll_Click(object sender, EventArgs e)
        {
            serializer.createPhoneBook();
            foreach (PhoneBookEntry entry in serializer.getObject())
            {
                addSubItem(entry.lastName, entry.phoneNumber.ToString(), entry.year.ToString());
            }
        }
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            foreach (PhoneBookEntry entry in serializer.getObject())
            {
                if (entry.phoneNumber / 100 == entry.year / 100)
                {
                    addSubItem(entry.lastName, entry.phoneNumber.ToString(), entry.year.ToString());
                }
            }
        }
        private void addSubItem(string name, string phone, string year)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, name));
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, phone));
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, year));
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, ""));
            listView.Items.Add(item);
        }
    }

}
