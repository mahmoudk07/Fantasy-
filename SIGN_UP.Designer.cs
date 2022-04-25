namespace PROJECT
{
    partial class SIGN_UP
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LOGIIN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PASS = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "USERNAME";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 22);
            this.textBox1.TabIndex = 13;
            // 
            // LOGIIN
            // 
            this.LOGIIN.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LOGIIN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LOGIIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIIN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LOGIIN.Location = new System.Drawing.Point(51, 88);
            this.LOGIIN.Name = "LOGIIN";
            this.LOGIIN.Size = new System.Drawing.Size(147, 35);
            this.LOGIIN.TabIndex = 12;
            this.LOGIIN.Text = "SIGN UP";
            this.LOGIIN.UseVisualStyleBackColor = false;
            this.LOGIIN.Click += new System.EventHandler(this.LOGIIN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "PASSWORD";
            // 
            // PASS
            // 
            this.PASS.Location = new System.Drawing.Point(131, 51);
            this.PASS.Name = "PASS";
            this.PASS.Size = new System.Drawing.Size(145, 22);
            this.PASS.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PROJECT.Properties.Resources.SLEG;
            this.pictureBox2.Location = new System.Drawing.Point(1, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(799, 448);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // SIGN_UP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LOGIIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PASS);
            this.Controls.Add(this.pictureBox2);
            this.Name = "SIGN_UP";
            this.Text = "SIGN_UP";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LOGIIN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PASS;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}