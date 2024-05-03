using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace CityAndCountryPicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ArrayList messages = new ArrayList();
        public string message = "";

        // Create message and add the message to the list
        private void button1_Click(object sender, EventArgs e)
        {
            message = $"{textBox1.Text} lives in {listBox1.SelectedItem}, {comboBox1.SelectedItem}";
            messages.Add(message);
            MessageBox.Show(message, "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Display all messages in the list
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "New Zealand")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Auckland");
                comboBox1.Items.Add("Wellington");
                comboBox1.Items.Add("Christchurch");
            }
            else if (listBox1.SelectedItem.ToString() == "Australia")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Sydney");
                comboBox1.Items.Add("Melbourne");
                comboBox1.Items.Add("Brisbane");
            }
            else if (listBox1.SelectedItem.ToString() == "America")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("New York");
                comboBox1.Items.Add("Los Angeles");
                comboBox1.Items.Add("Chicago");
            }
            else if (listBox1.SelectedItem.ToString() == "Vietnam")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Ha Noi");
                comboBox1.Items.Add("Sai Gon");
                comboBox1.Items.Add("Hue");
            }
            else if (listBox1.SelectedItem.ToString() == "China")
            {
                comboBox1.Items.Clear();
                comboBox1.Items.Add("Beijing");
                comboBox1.Items.Add("Guangzhou");
                comboBox1.Items.Add("Fujian");
            }
        }


    }
}
