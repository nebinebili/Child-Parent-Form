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

namespace Taskk
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string Buttonname { get; set; }
        public Product Product1 { get; set; }
        public string NameProduct { get; set; }
        public string CountryProduct { get; set; }
        public double CostProduct { get; set; }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (Buttonname == "Add")
            {
                if (!string.IsNullOrEmpty(textBox_cost.Text) && !string.IsNullOrEmpty(textBox_country.Text) &&
                !string.IsNullOrEmpty(textBox_name.Text))
                {
                    Product1 = new Product(textBox_name.Text, textBox_country.Text, Convert.ToDouble(textBox_cost.Text));

                    DialogResult = DialogResult.OK;
                }
                else MessageBox.Show("Fill all Information");
            }
            else if (Buttonname == "Edit")
            {
                if (!string.IsNullOrEmpty(textBox_cost.Text) && !string.IsNullOrEmpty(textBox_country.Text) &&
                !string.IsNullOrEmpty(textBox_name.Text))
                {
                    Product1 = new Product(textBox_name.Text, textBox_country.Text, Convert.ToDouble(textBox_cost.Text));

                    DialogResult = DialogResult.OK;

                }
                else MessageBox.Show("Information is Empty");
            }

        }

        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_name.Text, @"^[A-Za-z]+$")) textBox_name.Text = string.Empty;
            
        }

        private void textBox_country_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_country.Text, @"^[A-Za-z]+$")) textBox_country.Text = string.Empty;
        }

        private void textBox_cost_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(textBox_cost.Text, @"^*[0-9\.]+$")) textBox_cost.Text = string.Empty;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(NameProduct)) textBox_name.Text = NameProduct;
            if (!string.IsNullOrEmpty(CountryProduct)) textBox_country.Text = CountryProduct;
            if (CostProduct != 0) textBox_cost.Text = CostProduct.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
