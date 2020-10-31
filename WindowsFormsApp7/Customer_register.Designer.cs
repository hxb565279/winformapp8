using System.ComponentModel;

namespace WindowsFormsApp7
{
    partial class Customer_register
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
            this.register_customer1 = new System.Windows.Forms.TextBox();
            this.register_customer2 = new System.Windows.Forms.TextBox();
            this.register_customer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // register_customer1
            // 
            this.register_customer1.Location = new System.Drawing.Point(266, 66);
            this.register_customer1.Margin = new System.Windows.Forms.Padding(2);
            this.register_customer1.Name = "register_customer1";
            this.register_customer1.Size = new System.Drawing.Size(103, 21);
            this.register_customer1.TabIndex = 0;
            this.register_customer1.TextChanged += new System.EventHandler(this.register_customer1_TextChanged);
            // 
            // register_customer2
            // 
            this.register_customer2.Location = new System.Drawing.Point(266, 112);
            this.register_customer2.Margin = new System.Windows.Forms.Padding(2);
            this.register_customer2.Name = "register_customer2";
            this.register_customer2.Size = new System.Drawing.Size(103, 21);
            this.register_customer2.TabIndex = 1;
            this.register_customer2.TextChanged += new System.EventHandler(this.register_customer2_TextChanged);
            // 
            // register_customer
            // 
            this.register_customer.Location = new System.Drawing.Point(283, 158);
            this.register_customer.Margin = new System.Windows.Forms.Padding(2);
            this.register_customer.Name = "register_customer";
            this.register_customer.Size = new System.Drawing.Size(61, 24);
            this.register_customer.TabIndex = 2;
            this.register_customer.Text = "注册";
            this.register_customer.UseVisualStyleBackColor = true;
            this.register_customer.Click += new System.EventHandler(this.register_customer_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(266, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "客户注册";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(221, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "账号:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(220, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Customer_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register_customer);
            this.Controls.Add(this.register_customer2);
            this.Controls.Add(this.register_customer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customer_register";
            this.Text = "Customer_register";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button register_customer;

        private System.Windows.Forms.TextBox register_customer2;

        private System.Windows.Forms.TextBox register_customer1;

        #endregion
    }
}