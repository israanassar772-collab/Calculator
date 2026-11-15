namespace WindowsFormsApp15
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.num1 = new System.Windows.Forms.Label();
            this.txt_b1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.Label();
            this.txt_b2 = new System.Windows.Forms.TextBox();
            this.btn_sum = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.lb_res = new System.Windows.Forms.Label();
            this.lab_res = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.num1.Font = new System.Drawing.Font("29LT Bukra Bold Italic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num1.Location = new System.Drawing.Point(115, 45);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(66, 17);
            this.num1.TabIndex = 0;
            this.num1.Text = "number1";
            this.num1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_b1
            // 
            this.txt_b1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b1.Location = new System.Drawing.Point(193, 42);
            this.txt_b1.Name = "txt_b1";
            this.txt_b1.Size = new System.Drawing.Size(107, 23);
            this.txt_b1.TabIndex = 1;
            this.txt_b1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.num2.Font = new System.Drawing.Font("29LT Bukra Bold Italic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.num2.Location = new System.Drawing.Point(115, 75);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(69, 17);
            this.num2.TabIndex = 0;
            this.num2.Text = "number2";
            this.num2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_b2
            // 
            this.txt_b2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b2.Location = new System.Drawing.Point(193, 72);
            this.txt_b2.Name = "txt_b2";
            this.txt_b2.Size = new System.Drawing.Size(107, 23);
            this.txt_b2.TabIndex = 1;
            this.txt_b2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_sum
            // 
            this.btn_sum.BackColor = System.Drawing.Color.IndianRed;
            this.btn_sum.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sum.Location = new System.Drawing.Point(106, 160);
            this.btn_sum.Name = "btn_sum";
            this.btn_sum.Size = new System.Drawing.Size(61, 51);
            this.btn_sum.TabIndex = 2;
            this.btn_sum.Text = "+";
            this.btn_sum.UseVisualStyleBackColor = false;
            this.btn_sum.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.IndianRed;
            this.btn_sub.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sub.Location = new System.Drawing.Point(193, 160);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(61, 51);
            this.btn_sub.TabIndex = 2;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.BackColor = System.Drawing.Color.IndianRed;
            this.btn_multi.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multi.Location = new System.Drawing.Point(193, 228);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(61, 51);
            this.btn_multi.TabIndex = 2;
            this.btn_multi.Text = "*";
            this.btn_multi.UseVisualStyleBackColor = false;
            this.btn_multi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.IndianRed;
            this.btn_div.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_div.Location = new System.Drawing.Point(106, 228);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(61, 51);
            this.btn_div.TabIndex = 2;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.BackColor = System.Drawing.Color.IndianRed;
            this.btn_mod.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod.Location = new System.Drawing.Point(278, 190);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(61, 51);
            this.btn_mod.TabIndex = 2;
            this.btn_mod.Text = "%";
            this.btn_mod.UseVisualStyleBackColor = false;
            this.btn_mod.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_res
            // 
            this.lb_res.AutoSize = true;
            this.lb_res.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_res.Font = new System.Drawing.Font("29LT Bukra Bold Italic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_res.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_res.Location = new System.Drawing.Point(103, 318);
            this.lb_res.Name = "lb_res";
            this.lb_res.Size = new System.Drawing.Size(82, 17);
            this.lb_res.TabIndex = 0;
            this.lb_res.Text = "The Result";
            this.lb_res.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_res
            // 
            this.lab_res.AutoSize = true;
            this.lab_res.Location = new System.Drawing.Point(233, 320);
            this.lab_res.Name = "lab_res";
            this.lab_res.Size = new System.Drawing.Size(0, 13);
            this.lab_res.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 394);
            this.Controls.Add(this.lab_res);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_sum);
            this.Controls.Add(this.txt_b2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.txt_b1);
            this.Controls.Add(this.lb_res);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.TextBox txt_b1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.TextBox txt_b2;
        private System.Windows.Forms.Button btn_sum;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Label lb_res;
        private System.Windows.Forms.Label lab_res;
    }
}

