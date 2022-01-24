namespace WindowsFormsDoctor
{
    partial class Doctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doctor));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectColumn_docworking = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.photoColumn_docworking = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameColumn_docworking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn_docworking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.selectColumn_docdone = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.photoColumn_docdone = new System.Windows.Forms.DataGridViewImageColumn();
            this.nameColumn_docdone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleColumn_docdone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelect_docworking = new System.Windows.Forms.Button();
            this.pictureBox_docIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox_docMessages = new System.Windows.Forms.PictureBox();
            this.label_docname = new System.Windows.Forms.Label();
            this.label_docprogressing = new System.Windows.Forms.Label();
            this.label_docsolved = new System.Windows.Forms.Label();
            this.textBox_docEntry = new System.Windows.Forms.TextBox();
            this.button_docEntryClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_docIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_docMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn_docworking,
            this.photoColumn_docworking,
            this.nameColumn_docworking,
            this.titleColumn_docworking});
            this.dataGridView1.Location = new System.Drawing.Point(34, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(324, 192);
            this.dataGridView1.TabIndex = 0;
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
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn_docdone,
            this.photoColumn_docdone,
            this.nameColumn_docdone,
            this.titleColumn_docdone});
            this.dataGridView3.Location = new System.Drawing.Point(418, 156);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(345, 192);
            this.dataGridView3.TabIndex = 2;
            // 
            // selectColumn_docdone
            // 
            this.selectColumn_docdone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.selectColumn_docdone.HeaderText = "Select";
            this.selectColumn_docdone.MinimumWidth = 6;
            this.selectColumn_docdone.Name = "selectColumn_docdone";
            this.selectColumn_docdone.Width = 51;
            // 
            // photoColumn_docdone
            // 
            this.photoColumn_docdone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.photoColumn_docdone.HeaderText = "Image";
            this.photoColumn_docdone.MinimumWidth = 6;
            this.photoColumn_docdone.Name = "photoColumn_docdone";
            this.photoColumn_docdone.Width = 51;
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
            // buttonSelect_docworking
            // 
            this.buttonSelect_docworking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonSelect_docworking.Font = new System.Drawing.Font("Poor Richard", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect_docworking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(86)))));
            this.buttonSelect_docworking.Location = new System.Drawing.Point(33, 381);
            this.buttonSelect_docworking.Name = "buttonSelect_docworking";
            this.buttonSelect_docworking.Size = new System.Drawing.Size(94, 42);
            this.buttonSelect_docworking.TabIndex = 3;
            this.buttonSelect_docworking.Text = "Select";
            this.buttonSelect_docworking.UseVisualStyleBackColor = false;
            this.buttonSelect_docworking.Click += new System.EventHandler(this.buttonSelect_docworking_Click);
            // 
            // pictureBox_docIcon
            // 
            this.pictureBox_docIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_docIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_docIcon.Image = global::WindowsFormsDoctor.Properties.Resources.d3f913b8dd27fac04b26c2c9a903610d;
            this.pictureBox_docIcon.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_docIcon.Name = "pictureBox_docIcon";
            this.pictureBox_docIcon.Size = new System.Drawing.Size(96, 79);
            this.pictureBox_docIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_docIcon.TabIndex = 4;
            this.pictureBox_docIcon.TabStop = false;
            this.pictureBox_docIcon.Click += new System.EventHandler(this.pictureBox_docIcon_Click);
            // 
            // pictureBox_docMessages
            // 
            this.pictureBox_docMessages.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_docMessages.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_docMessages.Image")));
            this.pictureBox_docMessages.Location = new System.Drawing.Point(738, 12);
            this.pictureBox_docMessages.Name = "pictureBox_docMessages";
            this.pictureBox_docMessages.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_docMessages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_docMessages.TabIndex = 5;
            this.pictureBox_docMessages.TabStop = false;
            this.pictureBox_docMessages.Click += new System.EventHandler(this.pictureBox_docMessages_Click);
            // 
            // label_docname
            // 
            this.label_docname.AutoSize = true;
            this.label_docname.BackColor = System.Drawing.Color.Transparent;
            this.label_docname.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_docname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(86)))));
            this.label_docname.Location = new System.Drawing.Point(115, 13);
            this.label_docname.Name = "label_docname";
            this.label_docname.Size = new System.Drawing.Size(208, 37);
            this.label_docname.TabIndex = 6;
            this.label_docname.Text = "Name Surname";
            // 
            // label_docprogressing
            // 
            this.label_docprogressing.AutoSize = true;
            this.label_docprogressing.BackColor = System.Drawing.Color.Transparent;
            this.label_docprogressing.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_docprogressing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(101)))));
            this.label_docprogressing.Location = new System.Drawing.Point(28, 119);
            this.label_docprogressing.Name = "label_docprogressing";
            this.label_docprogressing.Size = new System.Drawing.Size(148, 34);
            this.label_docprogressing.TabIndex = 7;
            this.label_docprogressing.Text = "In Progress";
            // 
            // label_docsolved
            // 
            this.label_docsolved.AutoSize = true;
            this.label_docsolved.BackColor = System.Drawing.Color.Transparent;
            this.label_docsolved.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_docsolved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label_docsolved.Location = new System.Drawing.Point(418, 119);
            this.label_docsolved.Name = "label_docsolved";
            this.label_docsolved.Size = new System.Drawing.Size(193, 34);
            this.label_docsolved.TabIndex = 8;
            this.label_docsolved.Text = "Recently Solved";
            // 
            // textBox_docEntry
            // 
            this.textBox_docEntry.Location = new System.Drawing.Point(144, 68);
            this.textBox_docEntry.Multiline = true;
            this.textBox_docEntry.Name = "textBox_docEntry";
            this.textBox_docEntry.Size = new System.Drawing.Size(504, 331);
            this.textBox_docEntry.TabIndex = 9;
            // 
            // button_docEntryClose
            // 
            this.button_docEntryClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_docEntryClose.Font = new System.Drawing.Font("Poor Richard", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_docEntryClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(86)))));
            this.button_docEntryClose.Location = new System.Drawing.Point(669, 381);
            this.button_docEntryClose.Name = "button_docEntryClose";
            this.button_docEntryClose.Size = new System.Drawing.Size(94, 42);
            this.button_docEntryClose.TabIndex = 11;
            this.button_docEntryClose.Text = "Close";
            this.button_docEntryClose.UseVisualStyleBackColor = false;
            this.button_docEntryClose.Click += new System.EventHandler(this.button_docEntryClose_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_docEntryClose);
            this.Controls.Add(this.textBox_docEntry);
            this.Controls.Add(this.label_docsolved);
            this.Controls.Add(this.label_docprogressing);
            this.Controls.Add(this.label_docname);
            this.Controls.Add(this.pictureBox_docMessages);
            this.Controls.Add(this.pictureBox_docIcon);
            this.Controls.Add(this.buttonSelect_docworking);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_docIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_docMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn_docworking;
        private System.Windows.Forms.DataGridViewImageColumn photoColumn_docworking;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn_docworking;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn_docworking;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn_docdone;
        private System.Windows.Forms.DataGridViewImageColumn photoColumn_docdone;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn_docdone;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleColumn_docdone;
        private System.Windows.Forms.Button buttonSelect_docworking;
        private System.Windows.Forms.PictureBox pictureBox_docIcon;
        private System.Windows.Forms.PictureBox pictureBox_docMessages;
        private System.Windows.Forms.Label label_docname;
        private System.Windows.Forms.Label label_docprogressing;
        private System.Windows.Forms.Label label_docsolved;
        private System.Windows.Forms.TextBox textBox_docEntry;
        private System.Windows.Forms.Button button_docEntryClose;
    }
}