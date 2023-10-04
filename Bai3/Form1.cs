using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] db = { "Giám đốc", "Tổ chức hành chính", "Kế hoạch", "Kế toán" };
            foreach (var item in db)
            {
                treeView1.Nodes.Add(item);
                cboPhongBan.Items.Add(item);
            }
            cboPhongBan.SelectedIndex = 0;
        }
        public void clear()
        {
            txtMaSo.Clear();
            txtHoTen.Clear();
            txtDiaChi.Clear();
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            this.clear();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if(treeView1.SelectedNode != null)
                {
                    cboPhongBan.Items.Remove(treeView1.SelectedNode.Text);
                    treeView1.Nodes.Remove(treeView1.SelectedNode);
                }
            }
        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            int index = -1;
            foreach (TreeNode node in treeView1.Nodes)
            {
                if(node.Text == cboPhongBan.Text)
                {
                    index = node.Index;
                    break;
                }
                
            }
            treeView1.Nodes[index].Nodes.Add(txtHoTen.Text);
            treeView1.ExpandAll();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add(txtPhongBan.Text);
            cboPhongBan.Items.Add(txtPhongBan.Text);
        }

    }
}
