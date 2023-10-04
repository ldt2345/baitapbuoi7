namespace Bai2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btnPhai = new System.Windows.Forms.Button();
            this.btnphaiAll = new System.Windows.Forms.Button();
            this.btnTrai = new System.Windows.Forms.Button();
            this.btnTraiAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(30, 58);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(313, 58);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 95);
            this.listBox2.TabIndex = 2;
            // 
            // btnPhai
            // 
            this.btnPhai.Location = new System.Drawing.Point(196, 58);
            this.btnPhai.Name = "btnPhai";
            this.btnPhai.Size = new System.Drawing.Size(29, 23);
            this.btnPhai.TabIndex = 3;
            this.btnPhai.Text = ">";
            this.btnPhai.UseVisualStyleBackColor = true;
            this.btnPhai.Click += new System.EventHandler(this.btnPhai_Click);
            // 
            // btnphaiAll
            // 
            this.btnphaiAll.Location = new System.Drawing.Point(196, 87);
            this.btnphaiAll.Name = "btnphaiAll";
            this.btnphaiAll.Size = new System.Drawing.Size(29, 23);
            this.btnphaiAll.TabIndex = 4;
            this.btnphaiAll.Text = ">>";
            this.btnphaiAll.UseVisualStyleBackColor = true;
            this.btnphaiAll.Click += new System.EventHandler(this.btnphaiAll_Click);
            // 
            // btnTrai
            // 
            this.btnTrai.Location = new System.Drawing.Point(196, 116);
            this.btnTrai.Name = "btnTrai";
            this.btnTrai.Size = new System.Drawing.Size(29, 23);
            this.btnTrai.TabIndex = 5;
            this.btnTrai.Text = "<";
            this.btnTrai.UseVisualStyleBackColor = true;
            this.btnTrai.Click += new System.EventHandler(this.btnTrai_Click);
            // 
            // btnTraiAll
            // 
            this.btnTraiAll.Location = new System.Drawing.Point(196, 145);
            this.btnTraiAll.Name = "btnTraiAll";
            this.btnTraiAll.Size = new System.Drawing.Size(29, 23);
            this.btnTraiAll.TabIndex = 6;
            this.btnTraiAll.Text = "<<";
            this.btnTraiAll.UseVisualStyleBackColor = true;
            this.btnTraiAll.Click += new System.EventHandler(this.btnTraiAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 355);
            this.Controls.Add(this.btnTraiAll);
            this.Controls.Add(this.btnTrai);
            this.Controls.Add(this.btnphaiAll);
            this.Controls.Add(this.btnPhai);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button btnPhai;
        private System.Windows.Forms.Button btnphaiAll;
        private System.Windows.Forms.Button btnTrai;
        private System.Windows.Forms.Button btnTraiAll;
    }
}

