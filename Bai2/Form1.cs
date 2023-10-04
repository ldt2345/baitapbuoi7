using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
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


        private void btnPhai_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.Remove(listBox1.SelectedItem);
        }
      

        private void Form1_Activated(object sender, EventArgs e)
        {
            string[] ds = { "Cốc", "Ổi", "Xoài", "Me", "Bưởi", "Cam" };
            foreach (var item in ds)
            {
                listBox1.Items.Add(item);
            }
        }

        private void btnphaiAll_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void btnTrai_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void btnTraiAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

    }
}
