using System.ComponentModel;

namespace WindowsFormsApp7
{
    partial class store_login
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
            this.store_login1 = new System.Windows.Forms.TextBox();
            this.store_login2 = new System.Windows.Forms.TextBox();
            this.store_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // store_login1
            // 
            this.store_login1.Location = new System.Drawing.Point(327, 132);
            this.store_login1.Name = "store_login1";
            this.store_login1.Size = new System.Drawing.Size(100, 21);
            this.store_login1.TabIndex = 0;
            this.store_login1.TextChanged += new System.EventHandler(this.store_login1_TextChanged);
            // 
            // store_login2
            // 
            this.store_login2.Location = new System.Drawing.Point(325, 179);
            this.store_login2.Name = "store_login2";
            this.store_login2.Size = new System.Drawing.Size(101, 21);
            this.store_login2.TabIndex = 1;
            this.store_login2.TextChanged += new System.EventHandler(this.store_login2_TextChanged);
            // 
            // store_button
            // 
            this.store_button.Location = new System.Drawing.Point(343, 224);
            this.store_button.Name = "store_button";
            this.store_button.Size = new System.Drawing.Size(66, 33);
            this.store_button.TabIndex = 2;
            this.store_button.Text = "登录";
            this.store_button.UseVisualStyleBackColor = true;
            this.store_button.Click += new System.EventHandler(this.store_button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(327, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "店铺登录";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(282, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "账号:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(279, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // store_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.store_button);
            this.Controls.Add(this.store_login2);
            this.Controls.Add(this.store_login1);
            this.Name = "store_login";
            this.Text = "store_login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button store_button;

        private System.Windows.Forms.TextBox store_login2;

        private System.Windows.Forms.TextBox store_login1;

        #endregion
    }
}