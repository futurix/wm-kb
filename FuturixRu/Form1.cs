using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FuturixRu
{
    public partial class Form1 : Form
    {
        private bool ShiftPressed = false; 
        
        public Form1()
        {
            InitializeComponent();
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox1.Text);
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            IDataObject temp = Clipboard.GetDataObject();
            string txt = temp.GetData("Text") as string;

            if (txt != null)
                textBox1.Text += txt;

            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string txt = (sender as Button).Text;

            if (ShiftPressed)
                txt = txt.ToUpper();
            else
                txt = txt.ToLower();

            int sel = textBox1.SelectionStart;
            textBox1.Text = textBox1.Text.Insert(sel, txt);
            textBox1.SelectionStart = sel + 1;

            textBox1.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.SelectionLength > 0)
                textBox1.SelectedText = "";
            else if (textBox1.Text.Length > 0)
            {
                int sel = textBox1.SelectionStart;

                if (sel > 0)
                {
                    textBox1.Text = textBox1.Text.Remove(sel - 1, 1);
                    textBox1.SelectionStart = sel - 1;
                }
                else
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }

            textBox1.Focus();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            ShiftPressed = !ShiftPressed;

            button26.Text = ShiftPressed ? "ЗГЛ" : "згл";

            textBox1.Focus();
        }
    }
}