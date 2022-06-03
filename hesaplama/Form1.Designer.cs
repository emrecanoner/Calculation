namespace hesaplama
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
            this.btntopla = new System.Windows.Forms.Button();
            this.tboxsayi = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btntopla
            // 
            this.btntopla.Location = new System.Drawing.Point(52, 73);
            this.btntopla.Name = "btntopla";
            this.btntopla.Size = new System.Drawing.Size(161, 54);
            this.btntopla.TabIndex = 0;
            this.btntopla.Text = "Hesapla";
            this.btntopla.UseVisualStyleBackColor = true;
            this.btntopla.Click += new System.EventHandler(this.btntopla_Click);
            // 
            // tboxsayi
            // 
            this.tboxsayi.Location = new System.Drawing.Point(71, 38);
            this.tboxsayi.Name = "tboxsayi";
            this.tboxsayi.Size = new System.Drawing.Size(116, 20);
            this.tboxsayi.TabIndex = 1;
            this.tboxsayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxsayi_KeyPress);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(120, 150);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(0, 13);
            this.lbl1.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 178);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(283, 82);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 261);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.tboxsayi);
            this.Controls.Add(this.btntopla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntopla;
        private System.Windows.Forms.TextBox tboxsayi;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

