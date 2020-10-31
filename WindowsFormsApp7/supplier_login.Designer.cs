using System.ComponentModel;

namespace WindowsFormsApp7
{
    partial class supplier_login
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
            this.supplier_login_box1 = new System.Windows.Forms.TextBox();
            this.supplier_login_box2 = new System.Windows.Forms.TextBox();
            this.supplier_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // supplier_login_box1
            // 
            this.supplier_login_box1.Location = new System.Drawing.Point(314, 128);
            this.supplier_login_box1.Name = "supplier_login_box1";
            this.supplier_login_box1.Size = new System.Drawing.Size(105, 21);
            this.supplier_login_box1.TabIndex = 0;
            this.supplier_login_box1.TextChanged += new System.EventHandler(this.supplier_login_box1_TextChanged);
            // 
            // supplier_login_box2
            // 
            this.supplier_login_box2.Location = new System.Drawing.Point(313, 175);
            this.supplier_login_box2.Name = "supplier_login_box2";
            this.supplier_login_box2.Size = new System.Drawing.Size(105, 21);
            this.supplier_login_box2.TabIndex = 1;
            this.supplier_login_box2.TextChanged += new System.EventHandler(this.supplier_login_box2_TextChanged);
            // 
            // supplier_button
            // 
            this.supplier_button.Location = new System.Drawing.Point(333, 224);
            this.supplier_button.Name = "supplier_button";
            this.supplier_button.Size = new System.Drawing.Size(65, 33);
            this.supplier_button.TabIndex = 2;
            this.supplier_button.Text = "登录";
            this.supplier_button.UseVisualStyleBackColor = true;
            this.supplier_button.Click += new System.EventHandler(this.supplier_button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(314, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "供应商登录";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(274, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "账号:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(272, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // supplier_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplier_button);
            this.Controls.Add(this.supplier_login_box2);
            this.Controls.Add(this.supplier_login_box1);
            this.Name = "supplier_login";
            this.Text = "供应商登录";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button supplier_button;

        private System.Windows.Forms.TextBox supplier_login_box2;

        private System.Windows.Forms.TextBox supplier_login_box1;

        #endregion
    }
}