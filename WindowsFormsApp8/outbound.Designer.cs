using System.ComponentModel;

namespace WindowsFormsApp8
{
    partial class outbound
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
            this.create1 = new System.Windows.Forms.Button();
            this.transh = new System.Windows.Forms.Button();
            this.update11 = new System.Windows.Forms.Button();
            this.deletebutton1 = new System.Windows.Forms.Button();
            this.submit1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(987, 181);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // create1
            // 
            this.create1.Location = new System.Drawing.Point(28, 418);
            this.create1.Name = "create1";
            this.create1.Size = new System.Drawing.Size(71, 36);
            this.create1.TabIndex = 1;
            this.create1.Text = "创建订单";
            this.create1.UseVisualStyleBackColor = true;
            this.create1.Click += new System.EventHandler(this.create1_Click);
            // 
            // transh
            // 
            this.transh.Location = new System.Drawing.Point(118, 418);
            this.transh.Name = "transh";
            this.transh.Size = new System.Drawing.Size(74, 36);
            this.transh.TabIndex = 2;
            this.transh.Text = "刷新页面";
            this.transh.UseVisualStyleBackColor = true;
            this.transh.Click += new System.EventHandler(this.transh_Click);
            // 
            // update11
            // 
            this.update11.Location = new System.Drawing.Point(28, 476);
            this.update11.Name = "update11";
            this.update11.Size = new System.Drawing.Size(122, 41);
            this.update11.TabIndex = 3;
            this.update11.Text = "更改订单某一行";
            this.update11.UseVisualStyleBackColor = true;
            this.update11.Click += new System.EventHandler(this.update11_Click);
            // 
            // deletebutton1
            // 
            this.deletebutton1.Location = new System.Drawing.Point(175, 474);
            this.deletebutton1.Name = "deletebutton1";
            this.deletebutton1.Size = new System.Drawing.Size(120, 44);
            this.deletebutton1.TabIndex = 4;
            this.deletebutton1.Text = "删除订单选中一行";
            this.deletebutton1.UseVisualStyleBackColor = true;
            this.deletebutton1.Click += new System.EventHandler(this.deletebutton1_Click);
            // 
            // submit1
            // 
            this.submit1.Location = new System.Drawing.Point(209, 418);
            this.submit1.Name = "submit1";
            this.submit1.Size = new System.Drawing.Size(86, 34);
            this.submit1.TabIndex = 5;
            this.submit1.Text = "订单提交";
            this.submit1.UseVisualStyleBackColor = true;
            this.submit1.Click += new System.EventHandler(this.submit1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 29);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(983, 172);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "库存信息如下";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 27);
            this.label2.TabIndex = 8;
            this.label2.Text = "订单如下";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(581, 42);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(198, 172);
            this.dataGridView3.TabIndex = 9;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(584, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "订单人信息";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // outbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 664);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.submit1);
            this.Controls.Add(this.deletebutton1);
            this.Controls.Add(this.update11);
            this.Controls.Add(this.transh);
            this.Controls.Add(this.create1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "outbound";
            this.Text = "出库单";
            this.Load += new System.EventHandler(this.outbound_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.DataGridView dataGridView3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView dataGridView2;

        private System.Windows.Forms.Button submit1;

        private System.Windows.Forms.Button deletebutton1;

        private System.Windows.Forms.Button update11;

        private System.Windows.Forms.Button transh;

        private System.Windows.Forms.Button create1;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}