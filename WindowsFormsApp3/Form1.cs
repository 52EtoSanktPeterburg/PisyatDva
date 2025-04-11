using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_MouseHover(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip TTip = new ToolTip();
            TTip.SetToolTip(textBox1, "Здесь могла быть ваша реклама");
            button1.MouseHover += new EventHandler(button1_MouseHover);
            button1.MouseLeave += new EventHandler(button1_MouseLeave);
            button1.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackgroundImage = Image.FromFile(@"C:\Users\Студент\Desktop\cat.png");

        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = null;

        }
    }
}
