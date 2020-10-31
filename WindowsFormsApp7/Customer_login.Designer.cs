using System.ComponentModel;

namespace WindowsFormsApp7
{
    partial class Customer_login
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
            this.customer_login1 = new System.Windows.Forms.TextBox();
            this.customer_login2 = new System.Windows.Forms.TextBox();
            this.customer_login3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customer_login1
            // 
            this.customer_login1.Location = new System.Drawing.Point(255, 84);
            this.customer_login1.Margin = new System.Windows.Forms.Padding(2);
            this.customer_login1.Name = "customer_login1";
            this.customer_login1.Size = new System.Drawing.Size(109, 21);
            this.customer_login1.TabIndex = 0;
            this.customer_login1.TextChanged += new System.EventHandler(this.customer_login1_TextChanged);
            // 
            // customer_login2
            // 
            this.customer_login2.Location = new System.Drawing.Point(255, 122);
            this.customer_login2.Margin = new System.Windows.Forms.Padding(2);
            this.customer_login2.Name = "customer_login2";
            this.customer_login2.Size = new System.Drawing.Size(109, 21);
            this.customer_login2.TabIndex = 1;
            this.customer_login2.TextChanged += new System.EventHandler(this.customer_login2_TextChanged);
            // 
            // customer_login3
            // 
            this.customer_login3.Location = new System.Drawing.Point(289, 162);
            this.customer_login3.Margin = new System.Windows.Forms.Padding(2);
            this.customer_login3.Name = "customer_login3";
            this.customer_login3.Size = new System.Drawing.Size(55, 25);
            this.customer_login3.TabIndex = 2;
            this.customer_login3.Text = "登录";
            this.customer_login3.UseVisualStyleBackColor = true;
            this.customer_login3.Click += new System.EventHandler(this.customer_login3_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(264, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "客户 登录";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(209, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "账号:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(209, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Customer_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customer_login3);
            this.Controls.Add(this.customer_login2);
            this.Controls.Add(this.customer_login1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Customer_login";
            this.Text = "客户登录";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button customer_login3;

        private System.Windows.Forms.TextBox customer_login2;

        private System.Windows.Forms.TextBox customer_login1;

        #endregion
    }
}