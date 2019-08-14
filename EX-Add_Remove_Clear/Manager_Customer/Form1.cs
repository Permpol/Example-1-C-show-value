using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Manager_Customer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("ELEC01");
            listBox1.Items.Add("ELEC02");
            listBox1.Items.Add("ELEC03");
        }
        private void inAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(inBox.Text.Trim())) ;
            {
                listBox1.Items.Add(inBox.Text.Trim());
                inBox.Text = "";
                inBox.Focus();
               
            }
            
            

        }

        private void inRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            
        }

        private void inClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

        }

        
    }
}
