namespace WindowsFormsDoctor
{
    partial class Messages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.dataGridView_messagesGeneral = new System.Windows.Forms.DataGridView();
            this.Column_messagesGeneralSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_messagesGeneralImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_messagesGeneralName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_messagesSelect = new System.Windows.Forms.Button();
            this.button_messagesBack = new System.Windows.Forms.Button();
            this.pictureBox_messages = new System.Windows.Forms.PictureBox();
            this.label_messagesName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_messagesGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_messages)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_messagesGeneral
            // 
            this.dataGridView_messagesGeneral.BackgroundColor = System.Drawing.Color.IndianRed;
            this.dataGridView_messagesGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_messagesGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_messagesGeneralSelect,
            this.Column_messagesGeneralImage,
            this.Column_messagesGeneralName});
            this.dataGridView_messagesGeneral.GridColor = System.Drawing.Color.MidnightBlue;
            this.dataGridView_messagesGeneral.Location = new System.Drawing.Point(152, 31);
            this.dataGridView_messagesGeneral.Name = "dataGridView_messagesGeneral";
            this.dataGridView_messagesGeneral.RowHeadersVisible = false;
            this.dataGridView_messagesGeneral.RowHeadersWidth = 51;
            this.dataGridView_messagesGeneral.RowTemplate.Height = 24;
            this.dataGridView_messagesGeneral.Size = new System.Drawing.Size(533, 356);
            this.dataGridView_messagesGeneral.TabIndex = 0;
            // 
            // Column_messagesGeneralSelect
            // 
            this.Column_messagesGeneralSelect.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column_messagesGeneralSelect.HeaderText = "Select";
            this.Column_messagesGeneralSelect.MinimumWidth = 6;
            this.Column_messagesGeneralSelect.Name = "Column_messagesGeneralSelect";
            this.Column_messagesGeneralSelect.Width = 51;
            // 
            // Column_messagesGeneralImage
            // 
            this.Column_messagesGeneralImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_messagesGeneralImage.HeaderText = "Image";
            this.Column_messagesGeneralImage.MinimumWidth = 6;
            this.Column_messagesGeneralImage.Name = "Column_messagesGeneralImage";
            // 
            // Column_messagesGeneralName
            // 
            this.Column_messagesGeneralName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_messagesGeneralName.HeaderText = "Name";
            this.Column_messagesGeneralName.MinimumWidth = 6;
            this.Column_messagesGeneralName.Name = "Column_messagesGeneralName";
            this.Column_messagesGeneralName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_messagesGeneralName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // button_messagesSelect
            // 
            this.button_messagesSelect.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_messagesSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.button_messagesSelect.Location = new System.Drawing.Point(152, 393);
            this.button_messagesSelect.Name = "button_messagesSelect";
            this.button_messagesSelect.Size = new System.Drawing.Size(105, 45);
            this.button_messagesSelect.TabIndex = 1;
            this.button_messagesSelect.Text = "Select";
            this.button_messagesSelect.UseVisualStyleBackColor = true;
            this.button_messagesSelect.Click += new System.EventHandler(this.button_messagesSelect_Click);
            // 
            // button_messagesBack
            // 
            this.button_messagesBack.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_messagesBack.ForeColor = System.Drawing.Color.IndianRed;
            this.button_messagesBack.Location = new System.Drawing.Point(13, 13);
            this.button_messagesBack.Name = "button_messagesBack";
            this.button_messagesBack.Size = new System.Drawing.Size(90, 40);
            this.button_messagesBack.TabIndex = 2;
            this.button_messagesBack.Text = "Back";
            this.button_messagesBack.UseVisualStyleBackColor = true;
            this.button_messagesBack.Click += new System.EventHandler(this.button_messagesBack_Click);
            // 
            // pictureBox_messages
            // 
            this.pictureBox_messages.Location = new System.Drawing.Point(752, 13);
            this.pictureBox_messages.Name = "pictureBox_messages";
            this.pictureBox_messages.Size = new System.Drawing.Size(58, 53);
            this.pictureBox_messages.TabIndex = 3;
            this.pictureBox_messages.TabStop = false;
            this.pictureBox_messages.Click += new System.EventHandler(this.pictureBox_messages_Click);
            // 
            // label_messagesName
            // 
            this.label_messagesName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_messagesName.AutoSize = true;
            this.label_messagesName.BackColor = System.Drawing.Color.Transparent;
            this.label_messagesName.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_messagesName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(22)))), ((int)(((byte)(60)))));
            this.label_messagesName.Location = new System.Drawing.Point(555, 19);
            this.label_messagesName.Name = "label_messagesName";
            this.label_messagesName.Size = new System.Drawing.Size(191, 34);
            this.label_messagesName.TabIndex = 4;
            this.label_messagesName.Text = "Name Surname";
            // 
            // Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 450);
            this.Controls.Add(this.label_messagesName);
            this.Controls.Add(this.pictureBox_messages);
            this.Controls.Add(this.button_messagesBack);
            this.Controls.Add(this.button_messagesSelect);
            this.Controls.Add(this.dataGridView_messagesGeneral);
            this.Name = "Messages";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.Messages_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_messagesGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_messages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_messagesGeneral;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_messagesGeneralSelect;
        private System.Windows.Forms.DataGridViewImageColumn Column_messagesGeneralImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_messagesGeneralName;
        private System.Windows.Forms.Button button_messagesSelect;
        private System.Windows.Forms.Button button_messagesBack;
        private System.Windows.Forms.PictureBox pictureBox_messages;
        private System.Windows.Forms.Label label_messagesName;
    }
}