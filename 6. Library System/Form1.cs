using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.Library_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ebook myEbook = new Ebook("C# Programming", "5MB");

            string bookTitle = myEbook.GetTitleInfo();

            MessageBox.Show($"{bookTitle}", "Ebook Info");
        }
    }
}
