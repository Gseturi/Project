namespace WindowsFormsDoctor
{
    partial class Extra
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.Lable2 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(293, 185);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(347, 42);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(318, 185);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // Lable2
            // 
            this.Lable2.AutoSize = true;
            this.Lable2.Location = new System.Drawing.Point(457, 26);
            this.Lable2.Name = "Lable2";
            this.Lable2.Size = new System.Drawing.Size(22, 13);
            this.Lable2.TabIndex = 4;
            this.Lable2.Text = "Bio";
            this.Lable2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(100, 26);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(60, 13);
            this.Label.TabIndex = 5;
            this.Label.Text = "Description";
            this.Label.Click += new System.EventHandler(this.Description_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 254);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(105, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "speciality";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Extra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.Lable2);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Extra";
            this.Text = "Extra";
            this.Load += new System.EventHandler(this.Extra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label Lable2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}