namespace PROJECT
{
    partial class USERS
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
            this.T_ADMIN = new System.Windows.Forms.Button();
            this.C_ADMIN = new System.Windows.Forms.Button();
            this.SUPPORTER = new System.Windows.Forms.Button();
            this.COACH = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // T_ADMIN
            // 
            this.T_ADMIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.T_ADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_ADMIN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.T_ADMIN.Image = global::PROJECT.Properties.Resources.easport__1_;
            this.T_ADMIN.Location = new System.Drawing.Point(377, 204);
            this.T_ADMIN.Name = "T_ADMIN";
            this.T_ADMIN.Size = new System.Drawing.Size(529, 57);
            this.T_ADMIN.TabIndex = 4;
            this.T_ADMIN.Text = "TOURNAMENT ADMIN";
            this.T_ADMIN.UseVisualStyleBackColor = true;
            this.T_ADMIN.Click += new System.EventHandler(this.T_ADMIN_Click);
            // 
            // C_ADMIN
            // 
            this.C_ADMIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.C_ADMIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_ADMIN.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.C_ADMIN.Image = global::PROJECT.Properties.Resources.easport__1_;
            this.C_ADMIN.Location = new System.Drawing.Point(377, 33);
            this.C_ADMIN.Name = "C_ADMIN";
            this.C_ADMIN.Size = new System.Drawing.Size(529, 57);
            this.C_ADMIN.TabIndex = 3;
            this.C_ADMIN.Text = "CLUB ADMIN";
            this.C_ADMIN.UseVisualStyleBackColor = true;
            this.C_ADMIN.Click += new System.EventHandler(this.C_ADMIN_Click);
            // 
            // SUPPORTER
            // 
            this.SUPPORTER.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SUPPORTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUPPORTER.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.SUPPORTER.Image = global::PROJECT.Properties.Resources.easport__1_;
            this.SUPPORTER.Location = new System.Drawing.Point(1207, 204);
            this.SUPPORTER.Name = "SUPPORTER";
            this.SUPPORTER.Size = new System.Drawing.Size(529, 57);
            this.SUPPORTER.TabIndex = 2;
            this.SUPPORTER.Text = "SUPPORTER";
            this.SUPPORTER.UseVisualStyleBackColor = true;
            this.SUPPORTER.Click += new System.EventHandler(this.SUPPORTER_Click);
            // 
            // COACH
            // 
            this.COACH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.COACH.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COACH.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.COACH.Image = global::PROJECT.Properties.Resources.easport__1_;
            this.COACH.Location = new System.Drawing.Point(1207, 33);
            this.COACH.Name = "COACH";
            this.COACH.Size = new System.Drawing.Size(529, 57);
            this.COACH.TabIndex = 1;
            this.COACH.Text = "COACH";
            this.COACH.UseVisualStyleBackColor = true;
            this.COACH.Click += new System.EventHandler(this.COACH_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROJECT.Properties.Resources.easport__1_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2050, 1080);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // USERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 772);
            this.Controls.Add(this.T_ADMIN);
            this.Controls.Add(this.C_ADMIN);
            this.Controls.Add(this.SUPPORTER);
            this.Controls.Add(this.COACH);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(50, 50);
            this.Name = "USERS";
            this.Text = "USERS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button COACH;
        private System.Windows.Forms.Button SUPPORTER;
        private System.Windows.Forms.Button C_ADMIN;
        private System.Windows.Forms.Button T_ADMIN;
    }
}

