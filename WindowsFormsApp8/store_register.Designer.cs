using System.ComponentModel;

namespace WindowsFormsApp7
{
    partial class store_register
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
            this.store_register_box1 = new System.Windows.Forms.TextBox();
            this.store_register_box2 = new System.Windows.Forms.TextBox();
            this.店铺注册_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // store_register_box1
            // 
            this.store_register_box1.Location = new System.Drawing.Point(417, 151);
            this.store_register_box1.Name = "store_register_box1";
            this.store_register_box1.Size = new System.Drawing.Size(122, 21);
            this.store_register_box1.TabIndex = 0;
            this.store_register_box1.TextChanged += new System.EventHandler(this.store_register_box1_TextChanged);
            // 
            // store_register_box2
            // 
            this.store_register_box2.Location = new System.Drawing.Point(418, 195);
            this.store_register_box2.Name = "store_register_box2";
            this.store_register_box2.Size = new System.Drawing.Size(121, 21);
            this.store_register_box2.TabIndex = 1;
            this.store_register_box2.TextChanged += new System.EventHandler(this.store_register_box2_TextChanged);
            // 
            // 店铺注册_button
            // 
            this.店铺注册_button.Location = new System.Drawing.Point(457, 238);
            this.店铺注册_button.Name = "店铺注册_button";
            this.店铺注册_button.Size = new System.Drawing.Size(65, 38);
            this.店铺注册_button.TabIndex = 2;
            this.店铺注册_button.Text = "店铺注册";
            this.店铺注册_button.UseVisualStyleBackColor = true;
            this.店铺注册_button.Click += new System.EventHandler(this.店铺注册_button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(428, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "店家注册";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(374, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "账号:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(372, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // store_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.店铺注册_button);
            this.Controls.Add(this.store_register_box2);
            this.Controls.Add(this.store_register_box1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "store_register";
            this.Text = "店铺注册";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button 店铺注册_button;

        private System.Windows.Forms.TextBox store_register_box2;

        private System.Windows.Forms.TextBox store_register_box1;

        #endregion
    }
}