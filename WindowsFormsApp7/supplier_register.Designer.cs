using System.ComponentModel;

namespace WindowsFormsApp7
{
    partial class supplier_register
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
            this.supplier_register_box1 = new System.Windows.Forms.TextBox();
            this.supplier_register_box2 = new System.Windows.Forms.TextBox();
            this.supplier_button_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // supplier_register_box1
            // 
            this.supplier_register_box1.Location = new System.Drawing.Point(304, 108);
            this.supplier_register_box1.Name = "supplier_register_box1";
            this.supplier_register_box1.Size = new System.Drawing.Size(127, 21);
            this.supplier_register_box1.TabIndex = 0;
            this.supplier_register_box1.TextChanged += new System.EventHandler(this.supplier_register_box1_TextChanged);
            // 
            // supplier_register_box2
            // 
            this.supplier_register_box2.Location = new System.Drawing.Point(301, 156);
            this.supplier_register_box2.Name = "supplier_register_box2";
            this.supplier_register_box2.Size = new System.Drawing.Size(129, 21);
            this.supplier_register_box2.TabIndex = 1;
            this.supplier_register_box2.TextChanged += new System.EventHandler(this.supplier_register_box2_TextChanged);
            // 
            // supplier_button_register
            // 
            this.supplier_button_register.Location = new System.Drawing.Point(328, 209);
            this.supplier_button_register.Name = "supplier_button_register";
            this.supplier_button_register.Size = new System.Drawing.Size(80, 34);
            this.supplier_button_register.TabIndex = 2;
            this.supplier_button_register.Text = "注册";
            this.supplier_button_register.UseVisualStyleBackColor = true;
            this.supplier_button_register.Click += new System.EventHandler(this.supplier_button_register_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.label1.Location = new System.Drawing.Point(310, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "供应商注册";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(260, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "账号:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(256, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "密码:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // supplier_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.supplier_button_register);
            this.Controls.Add(this.supplier_register_box2);
            this.Controls.Add(this.supplier_register_box1);
            this.Name = "supplier_register";
            this.Text = "供应商注册";
            this.Load += new System.EventHandler(this.supplier_register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button supplier_button_register;

        private System.Windows.Forms.TextBox supplier_register_box2;

        private System.Windows.Forms.TextBox supplier_register_box1;

        #endregion
    }
}