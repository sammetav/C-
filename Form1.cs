using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleEntry
{
    public partial class Form1 : Form
    {
        List<String> MyPeople = new List<string>();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = MyPeople;
        }

        private void btnAddName_Click(object sender, EventArgs e)
        {
            MyPeople.Add(txtAddName.Text);
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            label1.Text = "There are " + MyPeople.Count + " in the list";
        }

        private void btn_AddFive_Click(object sender, EventArgs e)
        {
            MyPeople.Add(txtAddName.Text);
            MyPeople.Add(txtAddName.Text);
            MyPeople.Add(txtAddName.Text);
            MyPeople.Add(txtAddName.Text);
            MyPeople.Add(txtAddName.Text);
            listBox1.DataSource = bs;
            bs.ResetBindings(false);
            label1.Text = "There are " + MyPeople.Count + " in the list";
        }

        private void btn_AtoZ_Click(object sender, EventArgs e)
        {
            MyPeople.Sort();
            bs.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyPeople.Sort();
            MyPeople.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            MyPeople.Clear();
            bs.ResetBindings(false);
        }
    }
}
