namespace WindowsFormsDoctor
{
    partial class Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrator));
            this.label_docname = new System.Windows.Forms.Label();
            this.pictureBox_adminMessages = new System.Windows.Forms.PictureBox();
            this.pictureBox_docIcon = new System.Windows.Forms.PictureBox();
            this.button_adminDownload = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectColumn_docworking = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.photoColumn_docworking = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameColumn_docworking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn_docworking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button_adminAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_adminMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_docIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_docname
            // 
            this.label_docname.AutoSize = true;
            this.label_docname.BackColor = System.Drawing.Color.Transparent;
            this.label_docname.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_docname.ForeColor = System.Drawing.Color.Maroon;
            this.label_docname.Location = new System.Drawing.Point(114, 20);
            this.label_docname.Name = "label_docname";
            this.label_docname.Size = new System.Drawing.Size(208, 37);
            this.label_docname.TabIndex = 12;
            this.label_docname.Text = "Name Surname";
            // 
            // pictureBox_adminMessages
            // 
            this.pictureBox_adminMessages.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_adminMessages.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_adminMessages.Image")));
            this.pictureBox_adminMessages.Location = new System.Drawing.Point(738, 20);
            this.pictureBox_adminMessages.Name = "pictureBox_adminMessages";
            this.pictureBox_adminMessages.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_adminMessages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_adminMessages.TabIndex = 11;
            this.pictureBox_adminMessages.TabStop = false;
            this.pictureBox_adminMessages.Click += new System.EventHandler(this.pictureBox_adminMessages_Click);
            // 
            // pictureBox_docIcon
            // 
            this.pictureBox_docIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_docIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_docIcon.Image = global::WindowsFormsDoctor.Properties.Resources.system_administrator_female;
            this.pictureBox_docIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_docIcon.Name = "pictureBox_docIcon";
            this.pictureBox_docIcon.Size = new System.Drawing.Size(96, 79);
            this.pictureBox_docIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_docIcon.TabIndex = 10;
            this.pictureBox_docIcon.TabStop = false;
            this.pictureBox_docIcon.Click += new System.EventHandler(this.pictureBox_docIcon_Click);
            // 
            // button_adminDownload
            // 
            this.button_adminDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_adminDownload.Font = new System.Drawing.Font("Poor Richard", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adminDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_adminDownload.Location = new System.Drawing.Point(121, 396);
            this.button_adminDownload.Name = "button_adminDownload";
            this.button_adminDownload.Size = new System.Drawing.Size(162, 42);
            this.button_adminDownload.TabIndex = 9;
            this.button_adminDownload.Text = "Download CV";
            this.button_adminDownload.UseVisualStyleBackColor = false;
            this.button_adminDownload.Click += new System.EventHandler(this.button_adminDownload_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn_docworking,
            this.photoColumn_docworking,
            this.nameColumn_docworking,
            this.titleColumn_docworking});
            this.dataGridView1.Location = new System.Drawing.Point(122, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(577, 226);
            this.dataGridView1.TabIndex = 7;
            // 
            // selectColumn_docworking
            // 
            this.selectColumn_docworking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectColumn_docworking.HeaderText = "Select";
            this.selectColumn_docworking.MinimumWidth = 6;
            this.selectColumn_docworking.Name = "selectColumn_docworking";
            this.selectColumn_docworking.Width = 51;
            // 
            // photoColumn_docworking
            // 
            this.photoColumn_docworking.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.photoColumn_docworking.HeaderText = "Image";
            this.photoColumn_docworking.MinimumWidth = 6;
            this.photoColumn_docworking.Name = "photoColumn_docworking";
            this.photoColumn_docworking.Width = 51;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(122, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 34);
            this.label1.TabIndex = 13;
            this.label1.Text = "Requests";
            // 
            // button_adminAdd
            // 
            this.button_adminAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_adminAdd.Font = new System.Drawing.Font("Poor Richard", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_adminAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_adminAdd.Location = new System.Drawing.Point(537, 396);
            this.button_adminAdd.Name = "button_adminAdd";
            this.button_adminAdd.Size = new System.Drawing.Size(162, 42);
            this.button_adminAdd.TabIndex = 15;
            this.button_adminAdd.Text = "Add to base";
            this.button_adminAdd.UseVisualStyleBackColor = false;
            this.button_adminAdd.Click += new System.EventHandler(this.button_adminAdd_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_adminAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_docname);
            this.Controls.Add(this.pictureBox_adminMessages);
            this.Controls.Add(this.pictureBox_docIcon);
            this.Controls.Add(this.button_adminDownload);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_adminMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_docIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_docname;
        private System.Windows.Forms.PictureBox pictureBox_adminMessages;
        private System.Windows.Forms.PictureBox pictureBox_docIcon;
        private System.Windows.Forms.Button button_adminDownload;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn_docworking;
        private System.Windows.Forms.DataGridViewImageColumn photoColumn_docworking;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn_docworking;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn_docworking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_adminAdd;
    }
}