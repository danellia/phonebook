using System;
using System.Collections.Generic;
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
            listViewAll.Items.Clear();
            serializer.createPhoneBook();
            showList(listViewAll, serializer.deserialize().entries);
            buttonChoose.Enabled = true;
            buttonViewAll.Enabled = false;
        }
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            listViewChoose.Items.Clear();
            PhoneBook bookChoose = new PhoneBook();
            foreach (PhoneBookEntry entry in serializer.deserialize().entries)
            {
                if (entry.phoneNumber % 100 == entry.year % 100)
                {
                    bookChoose.addEntry(entry);
                }
            }
            showList(listViewChoose, bookChoose.entries);
            buttonChoose.Enabled = false;
        }
        private void showList(ListView list, List<PhoneBookEntry> book)
        {
            foreach (PhoneBookEntry entry in book)
            {
                addSubItem(entry.lastName, entry.phoneNumber.ToString(), entry.year.ToString(), list);
            }
        }
        private void addSubItem(string name, string phone, string year, ListView list)
        {
            ListViewItem item = new ListViewItem();
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, name));
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, phone));
            item.SubItems.Add(new ListViewItem.ListViewSubItem(item, year));
            list.Items.Add(item);
        }
        private void listView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listViewAll.Columns[e.ColumnIndex].Width;
        }
    }
}
