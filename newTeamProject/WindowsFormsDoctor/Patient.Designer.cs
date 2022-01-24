namespace WindowsFormsDoctor
{
    partial class Patient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.label_docname = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_docicon = new System.Windows.Forms.PictureBox();
            this.buttonSelect_docworking = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.selectColumn_docdone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.photoColumn_docdone = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameColumn_docdone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn_docdone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectColumn_docworking = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.photoColumn_docworking = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameColumn_docworking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn_docworking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_docicon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_docname
            // 
            this.label_docname.AutoSize = true;
            this.label_docname.BackColor = System.Drawing.Color.Transparent;
            this.label_docname.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_docname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(86)))));
            this.label_docname.Location = new System.Drawing.Point(86, 17);
            this.label_docname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_docname.Name = "label_docname";
            this.label_docname.Size = new System.Drawing.Size(165, 29);
            this.label_docname.TabIndex = 12;
            this.label_docname.Text = "Name Surname";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(554, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox_docicon
            // 
            this.pictureBox_docicon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_docicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_docicon.Image = global::WindowsFormsDoctor.Properties.Resources.d3f913b8dd27fac04b26c2c9a903610d;
            this.pictureBox_docicon.Location = new System.Drawing.Point(9, 16);
            this.pictureBox_docicon.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox_docicon.Name = "pictureBox_docicon";
            this.pictureBox_docicon.Size = new System.Drawing.Size(72, 64);
            this.pictureBox_docicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_docicon.TabIndex = 10;
            this.pictureBox_docicon.TabStop = false;
            this.pictureBox_docicon.Click += new System.EventHandler(this.pictureBox_docicon_Click);
            // 
            // buttonSelect_docworking
            // 
            this.buttonSelect_docworking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSelect_docworking.Font = new System.Drawing.Font("Poor Richard", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect_docworking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(86)))));
            this.buttonSelect_docworking.Location = new System.Drawing.Point(25, 316);
            this.buttonSelect_docworking.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSelect_docworking.Name = "buttonSelect_docworking";
            this.buttonSelect_docworking.Size = new System.Drawing.Size(70, 34);
            this.buttonSelect_docworking.TabIndex = 9;
            this.buttonSelect_docworking.Text = "Select";
            this.buttonSelect_docworking.UseVisualStyleBackColor = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn_docdone,
            this.photoColumn_docdone,
            this.nameColumn_docdone,
            this.titleColumn_docdone});
            this.dataGridView3.Location = new System.Drawing.Point(314, 106);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(259, 184);
            this.dataGridView3.TabIndex = 8;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // selectColumn_docdone
            // 
            this.selectColumn_docdone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectColumn_docdone.HeaderText = "Select";
            this.selectColumn_docdone.MinimumWidth = 6;
            this.selectColumn_docdone.Name = "selectColumn_docdone";
            this.selectColumn_docdone.Width = 43;
            // 
            // photoColumn_docdone
            // 
            this.photoColumn_docdone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.photoColumn_docdone.HeaderText = "Image";
            this.photoColumn_docdone.MinimumWidth = 6;
            this.photoColumn_docdone.Name = "photoColumn_docdone";
            this.photoColumn_docdone.Width = 42;
            // 
            // nameColumn_docdone
            // 
            this.nameColumn_docdone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn_docdone.HeaderText = "Name";
            this.nameColumn_docdone.MinimumWidth = 6;
            this.nameColumn_docdone.Name = "nameColumn_docdone";
            this.nameColumn_docdone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameColumn_docdone.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // titleColumn_docdone
            // 
            this.titleColumn_docdone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleColumn_docdone.HeaderText = "Title";
            this.titleColumn_docdone.MinimumWidth = 6;
            this.titleColumn_docdone.Name = "titleColumn_docdone";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn_docworking,
            this.photoColumn_docworking,
            this.nameColumn_docworking,
            this.titleColumn_docworking});
            this.dataGridView1.Location = new System.Drawing.Point(26, 106);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(243, 184);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // selectColumn_docworking
            // 
            this.selectColumn_docworking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectColumn_docworking.HeaderText = "Select";
            this.selectColumn_docworking.MinimumWidth = 6;
            this.selectColumn_docworking.Name = "selectColumn_docworking";
            this.selectColumn_docworking.Width = 43;
            // 
            // photoColumn_docworking
            // 
            this.photoColumn_docworking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.photoColumn_docworking.HeaderText = "Image";
            this.photoColumn_docworking.MinimumWidth = 6;
            this.photoColumn_docworking.Name = "photoColumn_docworking";
            this.photoColumn_docworking.Width = 42;
            // 
            // nameColumn_docworking
            // 
            this.nameColumn_docworking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameColumn_docworking.HeaderText = "Name";
            this.nameColumn_docworking.MinimumWidth = 6;
            this.nameColumn_docworking.Name = "nameColumn_docworking";
            this.nameColumn_docworking.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.nameColumn_docworking.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // titleColumn_docworking
            // 
            this.titleColumn_docworking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.titleColumn_docworking.HeaderText = "Title";
            this.titleColumn_docworking.MinimumWidth = 6;
            this.titleColumn_docworking.Name = "titleColumn_docworking";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 41);
            this.button2.TabIndex = 14;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_docname);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox_docicon);
            this.Controls.Add(this.buttonSelect_docworking);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Patient";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_docicon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_docname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox_docicon;
        private System.Windows.Forms.Button buttonSelect_docworking;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn_docdone;
        private System.Windows.Forms.DataGridViewImageColumn photoColumn_docdone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn_docdone;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn_docdone;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn_docworking;
        private System.Windows.Forms.DataGridViewImageColumn photoColumn_docworking;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn_docworking;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn_docworking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button2;
    }
}