using System.ComponentModel;

namespace WindowsFormsApp8
{
    partial class create2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ord_person_box = new System.Windows.Forms.TextBox();
            this.shop_name_box = new System.Windows.Forms.TextBox();
            this.shop_price_box = new System.Windows.Forms.TextBox();
            this.shop_number_box = new System.Windows.Forms.TextBox();
            this.re_person_box = new System.Windows.Forms.TextBox();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.address_box = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(100, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单人:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(100, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品名:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(100, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "价格:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(100, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "数量:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(100, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "收货人:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(100, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "电话:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(100, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "地址:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // ord_person_box
            // 
            this.ord_person_box.Location = new System.Drawing.Point(154, 88);
            this.ord_person_box.Name = "ord_person_box";
            this.ord_person_box.Size = new System.Drawing.Size(76, 21);
            this.ord_person_box.TabIndex = 7;
            this.ord_person_box.TextChanged += new System.EventHandler(this.ord_person_box_TextChanged);
            // 
            // shop_name_box
            // 
            this.shop_name_box.Location = new System.Drawing.Point(152, 123);
            this.shop_name_box.Name = "shop_name_box";
            this.shop_name_box.Size = new System.Drawing.Size(77, 21);
            this.shop_name_box.TabIndex = 8;
            this.shop_name_box.TextChanged += new System.EventHandler(this.shop_name_box_TextChanged);
            // 
            // shop_price_box
            // 
            this.shop_price_box.Location = new System.Drawing.Point(152, 152);
            this.shop_price_box.Name = "shop_price_box";
            this.shop_price_box.Size = new System.Drawing.Size(76, 21);
            this.shop_price_box.TabIndex = 9;
            this.shop_price_box.TextChanged += new System.EventHandler(this.shop_price_box_TextChanged);
            // 
            // shop_number_box
            // 
            this.shop_number_box.Location = new System.Drawing.Point(151, 187);
            this.shop_number_box.Name = "shop_number_box";
            this.shop_number_box.Size = new System.Drawing.Size(78, 21);
            this.shop_number_box.TabIndex = 10;
            this.shop_number_box.TextChanged += new System.EventHandler(this.shop_number_box_TextChanged);
            // 
            // re_person_box
            // 
            this.re_person_box.Location = new System.Drawing.Point(151, 215);
            this.re_person_box.Name = "re_person_box";
            this.re_person_box.Size = new System.Drawing.Size(78, 21);
            this.re_person_box.TabIndex = 11;
            this.re_person_box.TextChanged += new System.EventHandler(this.re_person_box_TextChanged);
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(150, 244);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(78, 21);
            this.phone_box.TabIndex = 12;
            this.phone_box.TextChanged += new System.EventHandler(this.phone_box_TextChanged);
            // 
            // address_box
            // 
            this.address_box.Location = new System.Drawing.Point(150, 271);
            this.address_box.Name = "address_box";
            this.address_box.Size = new System.Drawing.Size(79, 21);
            this.address_box.TabIndex = 13;
            this.address_box.TextChanged += new System.EventHandler(this.address_box_TextChanged);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(87, 319);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(71, 41);
            this.add_button.TabIndex = 14;
            this.add_button.Text = "添加";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(203, 321);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(65, 37);
            this.close.TabIndex = 15;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // create2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 454);
            this.Controls.Add(this.close);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.address_box);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.re_person_box);
            this.Controls.Add(this.shop_number_box);
            this.Controls.Add(this.shop_price_box);
            this.Controls.Add(this.shop_name_box);
            this.Controls.Add(this.ord_person_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "create2";
            this.Text = "添加订单";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button close;

        private System.Windows.Forms.Button add_button;

        private System.Windows.Forms.TextBox address_box;

        private System.Windows.Forms.TextBox phone_box;

        private System.Windows.Forms.TextBox re_person_box;

        private System.Windows.Forms.TextBox shop_number_box;

        private System.Windows.Forms.TextBox shop_price_box;

        private System.Windows.Forms.TextBox shop_name_box;

        private System.Windows.Forms.TextBox ord_person_box;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}