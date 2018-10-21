using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bank.Test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string result = "";


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void sb_Click(object sender, EventArgs e)
        {
            sbyte sb = 0;
            result = "ค่า MIN : " + sbyte.MinValue.ToString() + Environment.NewLine;
            result += "ค่า MAX : " + sbyte.MaxValue.ToString() + Environment.NewLine;
            result += "TYPE : " + sb.GetType().ToString();
            MessageBox.Show(result.ToString(), "SByte");
        }

        private void Short_Click(object sender, EventArgs e)
        {
            short sh = 0;
            result = "ค่า MIN : " + short.MinValue.ToString() + Environment.NewLine;
            result += "ค่า MAX : " + short.MaxValue.ToString() + Environment.NewLine;
            result += "TYPE : " + sh.GetType().ToString();
            MessageBox.Show(result.ToString(), "Short");
        }

        private void Integer_Click(object sender, EventArgs e)
        {
            int i = 0;
            result = "ค่า MIN : " + int.MinValue.ToString() + Environment.NewLine;
            result += "ค่า MAX : " + int.MaxValue.ToString() + Environment.NewLine;
            result += "TYPE : " + i.GetType().ToString();
            MessageBox.Show(result.ToString(), "Integer");
        }

        private void lo_Click(object sender, EventArgs e)
        {
            long l = 0;
            result = "ค่า MIN : " + long.MinValue.ToString() + Environment.NewLine;
            result += "ค่า MAX : " + long.MaxValue.ToString() + Environment.NewLine;
            result += "TYPE : " + l.GetType().ToString();
            MessageBox.Show(result.ToString(), "long");
        }

        private void by_Click(object sender, EventArgs e)
        {
            byte by = 0;
            result = "ค่า MIN : " + byte.MinValue.ToString() + Environment.NewLine;
            result += "ค่า MAX : " + byte.MaxValue.ToString() + Environment.NewLine;
            result += "TYPE : " + by.GetType().ToString();
            MessageBox.Show(result.ToString(), "byte");
        }

        private void us_Click(object sender, EventArgs e)
        {
            ushort ush = 0;
            result = "ค่า MIN : " + ushort.MinValue.ToString() + Environment.NewLine;
            result += "ค่า MAX : " + ushort.MaxValue.ToString() + Environment.NewLine;
            result += "TYPE : " + ush.GetType().ToString();
            MessageBox.Show(result.ToString(), "UShort");
        }

        private void ui_Click(object sender, EventArgs e)
        {
            uint ui = 0;
            result = "ค่า MIN : " + uint.MinValue.ToString() + Environment.NewLine;
            result += "ค่า MAX : " + uint.MaxValue.ToString() + Environment.NewLine;
            result += "TYPE : " + ui.GetType().ToString();
            MessageBox.Show(result.ToString(), "UInteger");
        }

        private void ul_Click(object sender, EventArgs e)
        {
            ulong ul = 0;
            result = "ค่า MIN : " + ulong.MinValue.ToString() + Environment.NewLine;
            result += "ค่า MAX : " + ulong.MaxValue.ToString() + Environment.NewLine;
            result += "TYPE : " + ul.GetType().ToString();
            MessageBox.Show(result.ToString(), "ULong");
        }

        private void fl_Click(object sender, EventArgs e)
        {
            float fl = 0;
            result = "ค่า MIN : " + float.MinValue.ToString() + Environment.NewLine;
            result += "ค่า MAX : " + float.MaxValue.ToString() + Environment.NewLine;
            result += "TYPE : " + fl.GetType().ToString();
            MessageBox.Show(result.ToString(), "Single");
        }

        private void dou_Click(object sender, EventArgs e)
        {
            double dou = 0;
            result = "ค่า MIN : " + double.MinValue.ToString() + Environment.NewLine;
            result += "ค่า MAX : " + double.MaxValue.ToString() + Environment.NewLine;
            result += "TYPE : " + dou.GetType().ToString();
            MessageBox.Show(result.ToString(), "Double");
        }

        private void de_Click(object sender, EventArgs e)
        {
            decimal de = default(decimal);
            result = "ค่า MIN : " + decimal.MinValue.ToString() + Environment.NewLine;
            result += "ค่า MAX : " + decimal.MaxValue.ToString() + Environment.NewLine;
            result += "TYPE : " + de.GetType().ToString();
            MessageBox.Show(result.ToString(), "Decimal");
        }

        private void ch_Click(object sender, EventArgs e)
        {
            char ch = '\0';
            result += "TYPE : " + ch.GetType().ToString();
            MessageBox.Show(result.ToString(), "Char");
        }

        private void bo_Click(object sender, EventArgs e)
        {
            bool bo = false;
            result += "TYPE : " + bo.GetType().ToString();
            MessageBox.Show(result.ToString(), "Boolean");
        }
    }
}
