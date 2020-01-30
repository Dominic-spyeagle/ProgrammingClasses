using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceManager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string path = pathTextBox.Text;
            if (!File.Exists(path))
            {
                MessageBox.Show("file does exists");
                return;
            }
            string[] content = File.ReadAllLines(path);
            int totalsum = 0;
            List<string> dates = new List<string>();
            for (int i = 1; i < content.Length; i++)
            {
                string line = content[i];
                string[] elements = line.Split('\t');
                totalsum = totalsum + int.Parse(elements[1]);
                if (!dates.Contains(elements[0]))
                {
                    dates.Add(elements[0]);
                }
            }
            resultLabel.Text = $"Total dates {dates.Count}, total sum {totalsum}";
        }
    }
}
