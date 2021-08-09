using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 form2;

        private void btn_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2 = new Form2();
            form2.Buttonname = "Add";
            var result=form2.ShowDialog();
            if (result == DialogResult.OK)
            {
                listBox1.Items.Add(form2.Product1);
            }
            else if (result == DialogResult.Cancel) { };
            btn_edit.Enabled = false;
            btn_remove.Enabled = false;
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>
            {
                new Product("Book","Turkey",12.5),
                new Product("Mouse","America",30)
            };
            listBox1.Items.AddRange(products.ToArray());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_edit.Enabled = true;
            btn_remove.Enabled = true;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
             listBox1.Items.Clear();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            this.Hide();
            form2 = new Form2();
            form2.Buttonname = "Edit";
            form2.NameProduct = (listBox1.SelectedItem as Product)?.Name;
            form2.CountryProduct = (listBox1.SelectedItem as Product)?.Country;
            form2.CostProduct = (listBox1.SelectedItem as Product).Cost;
            var result = form2.ShowDialog();
            if (result == DialogResult.OK)
            {
                var index = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Insert(index, form2.Product1);
            }
            else if (result == DialogResult.Cancel) { };
            btn_edit.Enabled = false;
            btn_remove.Enabled = false;

            this.Show();
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            btn_edit.Enabled = false;
            btn_remove.Enabled = false;
        }
    }
}
