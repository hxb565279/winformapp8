using System.ComponentModel;

namespace WindowsFormsApp8
{
    partial class manu
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addbutton = new System.Windows.Forms.Button();
            this.refrash = new System.Windows.Forms.Button();
            this.sumbit1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Web.UI.WebControls.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(454, 161);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1, 244);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(938, 223);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "供应商库存";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label2.Location = new System.Drawing.Point(6, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "订单";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(54, 491);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(111, 40);
            this.addbutton.TabIndex = 4;
            this.addbutton.Text = "添加订单";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // refrash
            // 
            this.refrash.Location = new System.Drawing.Point(234, 490);
            this.refrash.Name = "refrash";
            this.refrash.Size = new System.Drawing.Size(67, 40);
            this.refrash.TabIndex = 5;
            this.refrash.Text = "刷新";
            this.refrash.UseVisualStyleBackColor = true;
            this.refrash.Click += new System.EventHandler(this.refrash_Click);
            // 
            // sumbit1
            // 
            this.sumbit1.Location = new System.Drawing.Point(331, 491);
            this.sumbit1.Name = "sumbit1";
            this.sumbit1.Size = new System.Drawing.Size(78, 40);
            this.sumbit1.TabIndex = 6;
            this.sumbit1.Text = "提交订单";
            this.sumbit1.UseVisualStyleBackColor = true;
            this.sumbit1.Click += new System.EventHandler(this.sumbit1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "删除选中一行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(530, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(257, 161);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.ID = null;
            this.label3.Text = "订单人信息";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label4.Location = new System.Drawing.Point(533, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = "订单人名单";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // manu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 664);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sumbit1);
            this.Controls.Add(this.refrash);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Name = "manu";
            this.Text = "入库单";
            this.Load += new System.EventHandler(this.manu_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;

        private System.Web.UI.WebControls.Label label3;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button sumbit1;

        private System.Windows.Forms.Button refrash;

        private System.Windows.Forms.Button addbutton;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.DataGridView dataGridView3;

        private System.Windows.Forms.DataGridView dataGridView2;

        #endregion
    }
}