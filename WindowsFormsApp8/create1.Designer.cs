using System.ComponentModel;

namespace WindowsFormsApp8
{
    partial class create1
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
            this.ord_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.shop_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pricebox = new System.Windows.Forms.TextBox();
            this.numberbox = new System.Windows.Forms.TextBox();
            this.person = new System.Windows.Forms.TextBox();
            this.phonebox = new System.Windows.Forms.TextBox();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.createbox1 = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ord_name
            // 
            this.ord_name.Location = new System.Drawing.Point(202, 81);
            this.ord_name.Name = "ord_name";
            this.ord_name.Size = new System.Drawing.Size(93, 21);
            this.ord_name.TabIndex = 0;
            this.ord_name.TextChanged += new System.EventHandler(this.ord_name_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(134, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "订单人:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(138, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品名:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // shop_name
            // 
            this.shop_name.Location = new System.Drawing.Point(202, 108);
            this.shop_name.Name = "shop_name";
            this.shop_name.Size = new System.Drawing.Size(93, 21);
            this.shop_name.TabIndex = 3;
            this.shop_name.TextChanged += new System.EventHandler(this.shop_name_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(134, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "价格:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(134, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "数量:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(134, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "收货人:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(134, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 7;
            this.label6.Text = "电话:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(134, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "地址:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // pricebox
            // 
            this.pricebox.Location = new System.Drawing.Point(202, 135);
            this.pricebox.Name = "pricebox";
            this.pricebox.Size = new System.Drawing.Size(93, 21);
            this.pricebox.TabIndex = 10;
            this.pricebox.TextChanged += new System.EventHandler(this.pricebox_TextChanged);
            // 
            // numberbox
            // 
            this.numberbox.Location = new System.Drawing.Point(202, 162);
            this.numberbox.Name = "numberbox";
            this.numberbox.Size = new System.Drawing.Size(93, 21);
            this.numberbox.TabIndex = 11;
            this.numberbox.TextChanged += new System.EventHandler(this.numberbox_TextChanged);
            // 
            // person
            // 
            this.person.Location = new System.Drawing.Point(202, 192);
            this.person.Name = "person";
            this.person.Size = new System.Drawing.Size(93, 21);
            this.person.TabIndex = 12;
            this.person.TextChanged += new System.EventHandler(this.person_TextChanged);
            // 
            // phonebox
            // 
            this.phonebox.Location = new System.Drawing.Point(202, 219);
            this.phonebox.Name = "phonebox";
            this.phonebox.Size = new System.Drawing.Size(93, 21);
            this.phonebox.TabIndex = 13;
            this.phonebox.TextChanged += new System.EventHandler(this.phonebox_TextChanged);
            // 
            // addressbox
            // 
            this.addressbox.Location = new System.Drawing.Point(203, 246);
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(92, 21);
            this.addressbox.TabIndex = 14;
            this.addressbox.TextChanged += new System.EventHandler(this.addressbox_TextChanged);
            // 
            // createbox1
            // 
            this.createbox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.createbox1.Location = new System.Drawing.Point(125, 314);
            this.createbox1.Name = "createbox1";
            this.createbox1.Size = new System.Drawing.Size(62, 40);
            this.createbox1.TabIndex = 16;
            this.createbox1.Text = "创建";
            this.createbox1.UseVisualStyleBackColor = true;
            this.createbox1.Click += new System.EventHandler(this.createbox1_Click);
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(238, 314);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(73, 40);
            this.closebutton.TabIndex = 17;
            this.closebutton.Text = "关闭";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // create1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 444);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.createbox1);
            this.Controls.Add(this.addressbox);
            this.Controls.Add(this.phonebox);
            this.Controls.Add(this.person);
            this.Controls.Add(this.numberbox);
            this.Controls.Add(this.pricebox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shop_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ord_name);
            this.Name = "create1";
            this.Text = "创建订单";
            this.Load += new System.EventHandler(this.create1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button closebutton;

        private System.Windows.Forms.Button createbox1;

        private System.Windows.Forms.TextBox addressbox;

        private System.Windows.Forms.TextBox phonebox;

        private System.Windows.Forms.TextBox person;

        private System.Windows.Forms.TextBox numberbox;

        private System.Windows.Forms.TextBox pricebox;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox shop_name;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox ord_name;

        #endregion
    }
}