﻿using System.ComponentModel;

namespace WindowsFormsApp8
{
    partial class stock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_stock = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.deleteone = new System.Windows.Forms.Button();
            this.updateone = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(801, 335);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(82, 21);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(214, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 21);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(345, 25);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(79, 21);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // checkbutton1
            // 
            this.checkbutton1.Location = new System.Drawing.Point(445, 24);
            this.checkbutton1.Name = "checkbutton1";
            this.checkbutton1.Size = new System.Drawing.Size(55, 21);
            this.checkbutton1.TabIndex = 4;
            this.checkbutton1.Text = "查询";
            this.checkbutton1.UseVisualStyleBackColor = true;
            this.checkbutton1.Click += new System.EventHandler(this.checkbutton1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "商品名:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(165, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "价格:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(300, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "数量:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // add_stock
            // 
            this.add_stock.Location = new System.Drawing.Point(72, 429);
            this.add_stock.Name = "add_stock";
            this.add_stock.Size = new System.Drawing.Size(61, 21);
            this.add_stock.TabIndex = 8;
            this.add_stock.Text = "添加库存";
            this.add_stock.UseVisualStyleBackColor = true;
            this.add_stock.Click += new System.EventHandler(this.add_stock_Click);
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(172, 429);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(66, 20);
            this.delete1.TabIndex = 9;
            this.delete1.Text = "删除信息";
            this.delete1.UseVisualStyleBackColor = true;
            this.delete1.Click += new System.EventHandler(this.delete1_Click);
            // 
            // deleteone
            // 
            this.deleteone.Location = new System.Drawing.Point(821, 151);
            this.deleteone.Name = "deleteone";
            this.deleteone.Size = new System.Drawing.Size(90, 34);
            this.deleteone.TabIndex = 10;
            this.deleteone.Text = "删除选中一行";
            this.deleteone.UseVisualStyleBackColor = true;
            this.deleteone.Click += new System.EventHandler(this.deleteone_Click);
            // 
            // updateone
            // 
            this.updateone.Location = new System.Drawing.Point(822, 204);
            this.updateone.Name = "updateone";
            this.updateone.Size = new System.Drawing.Size(88, 34);
            this.updateone.TabIndex = 11;
            this.updateone.Text = "修改指定一行";
            this.updateone.UseVisualStyleBackColor = true;
            this.updateone.Click += new System.EventHandler(this.updateone_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(821, 262);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(88, 37);
            this.add2.TabIndex = 12;
            this.add2.Text = "添加写入一行";
            this.add2.UseVisualStyleBackColor = true;
            this.add2.Click += new System.EventHandler(this.add2_Click);
            // 
            // stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 664);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.updateone);
            this.Controls.Add(this.deleteone);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.add_stock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkbutton1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "stock";
            this.Text = "库存";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button add2;

        private System.Windows.Forms.Button updateone;

        private System.Windows.Forms.Button deleteone;

        private System.Windows.Forms.Button delete1;

        private System.Windows.Forms.Button add_stock;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button checkbutton1;

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.TextBox textBox2;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}