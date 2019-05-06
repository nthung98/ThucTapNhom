namespace ThucTapNhom_XH
{
    partial class Record
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Level = new System.Windows.Forms.TextBox();
            this.txt_ThoiGian = new System.Windows.Forms.TextBox();
            this.txt_MaNC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaDiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaNC = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDiem,
            this.ThoiGian,
            this.Level,
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(102, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(419, 121);
            this.dataGridView1.TabIndex = 17;
            // 
            // MaDiem
            // 
            this.MaDiem.DataPropertyName = "MaDiem";
            this.MaDiem.HeaderText = "Số thứ tự";
            this.MaDiem.Name = "MaDiem";
            // 
            // ThoiGian
            // 
            this.ThoiGian.DataPropertyName = "ThoiGian";
            this.ThoiGian.HeaderText = "Thoi Gian";
            this.ThoiGian.Name = "ThoiGian";
            // 
            // Level
            // 
            this.Level.DataPropertyName = "Level";
            this.Level.HeaderText = "Level";
            this.Level.Name = "Level";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNC";
            this.Column1.HeaderText = "MaNC";
            this.Column1.Name = "Column1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(465, 221);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 14;
            this.button3.Text = "Xoa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 221);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 19);
            this.button2.TabIndex = 15;
            this.button2.Text = "Sua";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 221);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 16;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Level
            // 
            this.txt_Level.Location = new System.Drawing.Point(142, 229);
            this.txt_Level.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Level.Name = "txt_Level";
            this.txt_Level.Size = new System.Drawing.Size(96, 20);
            this.txt_Level.TabIndex = 10;
            // 
            // txt_ThoiGian
            // 
            this.txt_ThoiGian.Location = new System.Drawing.Point(142, 206);
            this.txt_ThoiGian.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ThoiGian.Name = "txt_ThoiGian";
            this.txt_ThoiGian.Size = new System.Drawing.Size(96, 20);
            this.txt_ThoiGian.TabIndex = 11;
            // 
            // txt_MaNC
            // 
            this.txt_MaNC.Location = new System.Drawing.Point(142, 250);
            this.txt_MaNC.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaNC.Name = "txt_MaNC";
            this.txt_MaNC.Size = new System.Drawing.Size(96, 20);
            this.txt_MaNC.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 229);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Level";
            // 
            // txt_MaDiem
            // 
            this.txt_MaDiem.Location = new System.Drawing.Point(142, 176);
            this.txt_MaDiem.Margin = new System.Windows.Forms.Padding(2);
            this.txt_MaDiem.Name = "txt_MaDiem";
            this.txt_MaDiem.Size = new System.Drawing.Size(96, 20);
            this.txt_MaDiem.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 206);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thoi gian";
            // 
            // MaNC
            // 
            this.MaNC.AutoSize = true;
            this.MaNC.Location = new System.Drawing.Point(82, 252);
            this.MaNC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaNC.Name = "MaNC";
            this.MaNC.Size = new System.Drawing.Size(55, 13);
            this.MaNC.TabIndex = 8;
            this.MaNC.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 178);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "STT";
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 317);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_Level);
            this.Controls.Add(this.txt_ThoiGian);
            this.Controls.Add(this.txt_MaNC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_MaDiem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaNC);
            this.Controls.Add(this.label1);
            this.Name = "Record";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Level;
        private System.Windows.Forms.TextBox txt_ThoiGian;
        private System.Windows.Forms.TextBox txt_MaNC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_MaDiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MaNC;
        private System.Windows.Forms.Label label1;
    }
}