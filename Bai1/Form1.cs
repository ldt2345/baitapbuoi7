using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                lb_ketqua.Text = ("Dân tộc được chọn: " + comboBox1.SelectedItem.ToString());
            }
            else lb_ketqua.Text = ("Bạn chưa chọn dân tộc");
        }

     

    }

        

        


 
}
