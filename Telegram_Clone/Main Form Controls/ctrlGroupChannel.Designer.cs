namespace Telegram_Clone.Main_Form_Controls
{
    partial class ctrlGroupChannel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbEntityImage = new System.Windows.Forms.PictureBox();
            this.lblEntityName = new System.Windows.Forms.Label();
            this.lblMessagesCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEntityImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbEntityImage
            // 
            this.pbEntityImage.Image = global::Telegram_Clone.Properties.Resources.icons8_chat_group_35;
            this.pbEntityImage.Location = new System.Drawing.Point(11, 7);
            this.pbEntityImage.Name = "pbEntityImage";
            this.pbEntityImage.Size = new System.Drawing.Size(38, 39);
            this.pbEntityImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEntityImage.TabIndex = 0;
            this.pbEntityImage.TabStop = false;
            this.pbEntityImage.Click += new System.EventHandler(this.ctrlGroupChannel_Click);
            this.pbEntityImage.MouseEnter += new System.EventHandler(this.pbEntityImage_MouseEnter);
            this.pbEntityImage.MouseLeave += new System.EventHandler(this.pbEntityImage_MouseLeave);
            // 
            // lblEntityName
            // 
            this.lblEntityName.AutoSize = true;
            this.lblEntityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntityName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEntityName.Location = new System.Drawing.Point(52, 17);
            this.lblEntityName.Name = "lblEntityName";
            this.lblEntityName.Size = new System.Drawing.Size(172, 20);
            this.lblEntityName.TabIndex = 1;
            this.lblEntityName.Text = "ChannelOrGroupName";
            this.lblEntityName.Click += new System.EventHandler(this.ctrlGroupChannel_Click);
            this.lblEntityName.MouseEnter += new System.EventHandler(this.lblEntityName_MouseEnter);
            this.lblEntityName.MouseLeave += new System.EventHandler(this.lblEntityName_MouseLeave);
            // 
            // lblMessagesCount
            // 
            this.lblMessagesCount.AutoSize = true;
            this.lblMessagesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessagesCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lblMessagesCount.Location = new System.Drawing.Point(227, 15);
            this.lblMessagesCount.Name = "lblMessagesCount";
            this.lblMessagesCount.Size = new System.Drawing.Size(30, 24);
            this.lblMessagesCount.TabIndex = 2;
            this.lblMessagesCount.Text = "12";
            this.lblMessagesCount.Click += new System.EventHandler(this.ctrlGroupChannel_Click);
            this.lblMessagesCount.MouseEnter += new System.EventHandler(this.lblMessagesCount_MouseEnter);
            this.lblMessagesCount.MouseLeave += new System.EventHandler(this.lblMessagesCount_MouseLeave);
            // 
            // ctrlGroupChannel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMessagesCount);
            this.Controls.Add(this.lblEntityName);
            this.Controls.Add(this.pbEntityImage);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Name = "ctrlGroupChannel";
            this.Size = new System.Drawing.Size(262, 54);
            this.Click += new System.EventHandler(this.ctrlGroupChannel_Click);
            this.MouseEnter += new System.EventHandler(this.ctrlGroupChannel_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ctrlGroupChannel_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbEntityImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEntityImage;
        private System.Windows.Forms.Label lblEntityName;
        private System.Windows.Forms.Label lblMessagesCount;
    }
}
