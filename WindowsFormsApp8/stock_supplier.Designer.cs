using System.ComponentModel;

namespace WindowsFormsApp8
{
    partial class stock_supplier
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
            this.add1 = new System.Windows.Forms.Button();
            this.deleteone = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shop_name_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shop_price_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shop_number_box = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(488, 304);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(72, 455);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(79, 42);
            this.add1.TabIndex = 1;
            this.add1.Text = "添加库存";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.add1_Click);
            // 
            // deleteone
            // 
            this.deleteone.Location = new System.Drawing.Point(243, 460);
            this.deleteone.Name = "deleteone";
            this.deleteone.Size = new System.Drawing.Size(93, 36);
            this.deleteone.TabIndex = 2;
            this.deleteone.Text = "删除选中一行";
            this.deleteone.UseVisualStyleBackColor = true;
            this.deleteone.Click += new System.EventHandler(this.deleteone_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "商品名:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // shop_name_box
            // 
            this.shop_name_box.Location = new System.Drawing.Point(72, 35);
            this.shop_name_box.Name = "shop_name_box";
            this.shop_name_box.Size = new System.Drawing.Size(87, 21);
            this.shop_name_box.TabIndex = 4;
            this.shop_name_box.TextChanged += new System.EventHandler(this.shop_name_box_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(202, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "价格:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // shop_price_box
            // 
            this.shop_price_box.Location = new System.Drawing.Point(246, 33);
            this.shop_price_box.Name = "shop_price_box";
            this.shop_price_box.Size = new System.Drawing.Size(89, 21);
            this.shop_price_box.TabIndex = 6;
            this.shop_price_box.TextChanged += new System.EventHandler(this.shop_price_box_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(360, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "数量:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // shop_number_box
            // 
            this.shop_number_box.Location = new System.Drawing.Point(401, 33);
            this.shop_number_box.Name = "shop_number_box";
            this.shop_number_box.Size = new System.Drawing.Size(103, 21);
            this.shop_number_box.TabIndex = 8;
            this.shop_number_box.TextChanged += new System.EventHandler(this.shop_number_box_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 39);
            this.button1.TabIndex = 9;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(393, 461);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(94, 35);
            this.update.TabIndex = 10;
            this.update.Text = "修改选中一行";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // stock_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 664);
            this.Controls.Add(this.update);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shop_number_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shop_price_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.shop_name_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteone);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "stock_supplier";
            this.Text = "供应商库存";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button update;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.TextBox shop_number_box;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox shop_price_box;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox shop_name_box;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button deleteone;

        private System.Windows.Forms.Button add1;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}