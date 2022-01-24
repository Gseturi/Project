namespace WindowsFormsDoctor
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.pictureBox_profile = new System.Windows.Forms.PictureBox();
            this.textBox_profile = new System.Windows.Forms.TextBox();
            this.label_profileName = new System.Windows.Forms.Label();
            this.label_profileDialogNumb = new System.Windows.Forms.Label();
            this.label_profileDescription = new System.Windows.Forms.Label();
            this.label_profileMode = new System.Windows.Forms.Label();
            this.button_profileSwitch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_profile
            // 
            this.pictureBox_profile.Location = new System.Drawing.Point(247, 49);
            this.pictureBox_profile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox_profile.Name = "pictureBox_profile";
            this.pictureBox_profile.Size = new System.Drawing.Size(113, 110);
            this.pictureBox_profile.TabIndex = 0;
            this.pictureBox_profile.TabStop = false;
            // 
            // textBox_profile
            // 
            this.textBox_profile.Location = new System.Drawing.Point(130, 271);
            this.textBox_profile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_profile.Multiline = true;
            this.textBox_profile.Name = "textBox_profile";
            this.textBox_profile.Size = new System.Drawing.Size(336, 85);
            this.textBox_profile.TabIndex = 1;
            this.textBox_profile.TextChanged += new System.EventHandler(this.textBox_profile_TextChanged);
            // 
            // label_profileName
            // 
            this.label_profileName.AutoSize = true;
            this.label_profileName.BackColor = System.Drawing.Color.Transparent;
            this.label_profileName.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profileName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_profileName.Location = new System.Drawing.Point(273, 168);
            this.label_profileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_profileName.Name = "label_profileName";
            this.label_profileName.Size = new System.Drawing.Size(68, 25);
            this.label_profileName.TabIndex = 2;
            this.label_profileName.Text = "label1";
            this.label_profileName.Click += new System.EventHandler(this.label_profileName_Click);
            // 
            // label_profileDialogNumb
            // 
            this.label_profileDialogNumb.AutoSize = true;
            this.label_profileDialogNumb.BackColor = System.Drawing.Color.Transparent;
            this.label_profileDialogNumb.Font = new System.Drawing.Font("Poor Richard", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profileDialogNumb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_profileDialogNumb.Location = new System.Drawing.Point(273, 205);
            this.label_profileDialogNumb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_profileDialogNumb.Name = "label_profileDialogNumb";
            this.label_profileDialogNumb.Size = new System.Drawing.Size(68, 25);
            this.label_profileDialogNumb.TabIndex = 3;
            this.label_profileDialogNumb.Text = "label1";
            // 
            // label_profileDescription
            // 
            this.label_profileDescription.AutoSize = true;
            this.label_profileDescription.BackColor = System.Drawing.Color.Transparent;
            this.label_profileDescription.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profileDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_profileDescription.Location = new System.Drawing.Point(128, 253);
            this.label_profileDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_profileDescription.Name = "label_profileDescription";
            this.label_profileDescription.Size = new System.Drawing.Size(79, 19);
            this.label_profileDescription.TabIndex = 4;
            this.label_profileDescription.Text = "Description";
            // 
            // label_profileMode
            // 
            this.label_profileMode.AutoSize = true;
            this.label_profileMode.BackColor = System.Drawing.Color.Transparent;
            this.label_profileMode.Font = new System.Drawing.Font("Poor Richard", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_profileMode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_profileMode.Location = new System.Drawing.Point(500, 49);
            this.label_profileMode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_profileMode.Name = "label_profileMode";
            this.label_profileMode.Size = new System.Drawing.Size(102, 17);
            this.label_profileMode.TabIndex = 5;
            this.label_profileMode.Text = "Light/Dark mode";
            // 
            // button_profileSwitch
            // 
            this.button_profileSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_profileSwitch.Font = new System.Drawing.Font("Script MT Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_profileSwitch.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.button_profileSwitch.Location = new System.Drawing.Point(502, 10);
            this.button_profileSwitch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_profileSwitch.Name = "button_profileSwitch";
            this.button_profileSwitch.Size = new System.Drawing.Size(88, 37);
            this.button_profileSwitch.TabIndex = 6;
            this.button_profileSwitch.Text = "Switch";
            this.button_profileSwitch.UseVisualStyleBackColor = false;
            this.button_profileSwitch.Click += new System.EventHandler(this.button_profileSwitch_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button_profileSwitch);
            this.Controls.Add(this.label_profileMode);
            this.Controls.Add(this.label_profileDescription);
            this.Controls.Add(this.label_profileDialogNumb);
            this.Controls.Add(this.label_profileName);
            this.Controls.Add(this.textBox_profile);
            this.Controls.Add(this.pictureBox_profile);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_profile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_profile;
        private System.Windows.Forms.TextBox textBox_profile;
        private System.Windows.Forms.Label label_profileName;
        private System.Windows.Forms.Label label_profileDialogNumb;
        private System.Windows.Forms.Label label_profileDescription;
        private System.Windows.Forms.Label label_profileMode;
        private System.Windows.Forms.Button button_profileSwitch;
    }
}