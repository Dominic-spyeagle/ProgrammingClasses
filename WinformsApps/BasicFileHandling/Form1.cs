using System;
using System.IO;
using System.Windows.Forms;

namespace BasicFileHandling
{
    public partial class Form1 : Form
    {
        private string _path = @"C:\Users\W61504\Desktop\Sample.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            File.WriteAllText(_path,contenttextbox.Text);
        }

        private void Load_Click(object sender, EventArgs e)
        {
            contenttextbox.Text=File.ReadAllText(_path);

        }
    }
}
