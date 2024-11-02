namespace Telegram_Clone.Groups.Controls
{
    partial class ctrlImageMessage
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
            this.pbMessageImage = new System.Windows.Forms.PictureBox();
            this.rtxMessage = new System.Windows.Forms.RichTextBox();
            this.pbMemberImage = new System.Windows.Forms.PictureBox();
            this.lblMembeName = new System.Windows.Forms.Label();
            this.btnReplyToMessage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbMessageImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplyToMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMessageImage
            // 
            this.pbMessageImage.Location = new System.Drawing.Point(125, 16);
            this.pbMessageImage.Name = "pbMessageImage";
            this.pbMessageImage.Size = new System.Drawing.Size(159, 118);
            this.pbMessageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMessageImage.TabIndex = 0;
            this.pbMessageImage.TabStop = false;
            // 
            // rtxMessage
            // 
            this.rtxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.rtxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxMessage.ForeColor = System.Drawing.Color.White;
            this.rtxMessage.Location = new System.Drawing.Point(55, 140);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.Size = new System.Drawing.Size(284, 56);
            this.rtxMessage.TabIndex = 1;
            this.rtxMessage.Text = "Text Message";
            // 
            // pbMemberImage
            // 
            this.pbMemberImage.Image = global::Telegram_Clone.Properties.Resources.man_512;
            this.pbMemberImage.Location = new System.Drawing.Point(14, 58);
            this.pbMemberImage.Name = "pbMemberImage";
            this.pbMemberImage.Size = new System.Drawing.Size(29, 28);
            this.pbMemberImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMemberImage.TabIndex = 2;
            this.pbMemberImage.TabStop = false;
            // 
            // lblMembeName
            // 
            this.lblMembeName.AutoSize = true;
            this.lblMembeName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMembeName.Location = new System.Drawing.Point(10, 94);
            this.lblMembeName.Name = "lblMembeName";
            this.lblMembeName.Size = new System.Drawing.Size(76, 13);
            this.lblMembeName.TabIndex = 3;
            this.lblMembeName.Text = "Member Name";
            // 
            // btnReplyToMessage
            // 
            this.btnReplyToMessage.Image = global::Telegram_Clone.Properties.Resources.icons8_reply_arrow_20;
            this.btnReplyToMessage.Location = new System.Drawing.Point(316, 66);
            this.btnReplyToMessage.Name = "btnReplyToMessage";
            this.btnReplyToMessage.Size = new System.Drawing.Size(23, 20);
            this.btnReplyToMessage.TabIndex = 4;
            this.btnReplyToMessage.TabStop = false;
            this.btnReplyToMessage.Click += new System.EventHandler(this.btnReplyToMessage_Click);
            // 
            // ctrlImageMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnReplyToMessage);
            this.Controls.Add(this.lblMembeName);
            this.Controls.Add(this.pbMemberImage);
            this.Controls.Add(this.rtxMessage);
            this.Controls.Add(this.pbMessageImage);
            this.Name = "ctrlImageMessage";
            this.Size = new System.Drawing.Size(381, 209);
            ((System.ComponentModel.ISupportInitialize)(this.pbMessageImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplyToMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMessageImage;
        private System.Windows.Forms.RichTextBox rtxMessage;
        private System.Windows.Forms.PictureBox pbMemberImage;
        private System.Windows.Forms.Label lblMembeName;
        private System.Windows.Forms.PictureBox btnReplyToMessage;
    }
}
