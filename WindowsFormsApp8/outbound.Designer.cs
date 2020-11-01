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
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-7, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(987, 267);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // create1
            // 
            this.create1.Location = new System.Drawing.Point(28, 359);
            this.create1.Name = "create1";
            this.create1.Size = new System.Drawing.Size(71, 36);
            this.create1.TabIndex = 1;
            this.create1.Text = "创建订单";
            this.create1.UseVisualStyleBackColor = true;
            this.create1.Click += new System.EventHandler(this.create1_Click);
            // 
            // transh
            // 
            this.transh.Location = new System.Drawing.Point(142, 359);
            this.transh.Name = "transh";
            this.transh.Size = new System.Drawing.Size(74, 36);
            this.transh.TabIndex = 2;
            this.transh.Text = "刷新页面";
            this.transh.UseVisualStyleBackColor = true;
            this.transh.Click += new System.EventHandler(this.transh_Click);
            // 
            // update11
            // 
            this.update11.Location = new System.Drawing.Point(28, 440);
            this.update11.Name = "update11";
            this.update11.Size = new System.Drawing.Size(101, 41);
            this.update11.TabIndex = 3;
            this.update11.Text = "更改某一行";
            this.update11.UseVisualStyleBackColor = true;
            this.update11.Click += new System.EventHandler(this.update11_Click);
            // 
            // deletebutton1
            // 
            this.deletebutton1.Location = new System.Drawing.Point(142, 437);
            this.deletebutton1.Name = "deletebutton1";
            this.deletebutton1.Size = new System.Drawing.Size(105, 44);
            this.deletebutton1.TabIndex = 4;
            this.deletebutton1.Text = "删除选中一行";
            this.deletebutton1.UseVisualStyleBackColor = true;
            this.deletebutton1.Click += new System.EventHandler(this.deletebutton1_Click);
            // 
            // outbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 564);
            this.Controls.Add(this.deletebutton1);
            this.Controls.Add(this.update11);
            this.Controls.Add(this.transh);
            this.Controls.Add(this.create1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "outbound";
            this.Text = "出库单";
            this.Load += new System.EventHandler(this.outbound_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button deletebutton1;

        private System.Windows.Forms.Button update11;

        private System.Windows.Forms.Button transh;

        private System.Windows.Forms.Button create1;

        private System.Windows.Forms.DataGridView dataGridView1;

        #endregion
    }
}