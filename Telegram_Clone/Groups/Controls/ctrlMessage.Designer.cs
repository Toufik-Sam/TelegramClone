namespace Telegram_Clone.Groups.Controls
{
    partial class ctrlMessage
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
            this.rtxMessage = new System.Windows.Forms.RichTextBox();
            this.btnReplyToMessage = new System.Windows.Forms.PictureBox();
            this.pbMemberImage = new System.Windows.Forms.PictureBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplyToMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxMessage
            // 
            this.rtxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.rtxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.rtxMessage.Location = new System.Drawing.Point(42, 8);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.Size = new System.Drawing.Size(309, 48);
            this.rtxMessage.TabIndex = 1;
            this.rtxMessage.Text = "First Message";
            // 
            // btnReplyToMessage
            // 
            this.btnReplyToMessage.Image = global::Telegram_Clone.Properties.Resources.icons8_reply_arrow_20;
            this.btnReplyToMessage.Location = new System.Drawing.Point(355, 25);
            this.btnReplyToMessage.Name = "btnReplyToMessage";
            this.btnReplyToMessage.Size = new System.Drawing.Size(23, 20);
            this.btnReplyToMessage.TabIndex = 2;
            this.btnReplyToMessage.TabStop = false;
            this.btnReplyToMessage.Click += new System.EventHandler(this.btnReplyToMessage_Click);
            // 
            // pbMemberImage
            // 
            this.pbMemberImage.Image = global::Telegram_Clone.Properties.Resources.man_512;
            this.pbMemberImage.Location = new System.Drawing.Point(7, 58);
            this.pbMemberImage.Name = "pbMemberImage";
            this.pbMemberImage.Size = new System.Drawing.Size(29, 28);
            this.pbMemberImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMemberImage.TabIndex = 0;
            this.pbMemberImage.TabStop = false;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMemberName.Location = new System.Drawing.Point(43, 65);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(97, 16);
            this.lblMemberName.TabIndex = 3;
            this.lblMemberName.Text = "Member Name";
            // 
            // ctrlMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.btnReplyToMessage);
            this.Controls.Add(this.rtxMessage);
            this.Controls.Add(this.pbMemberImage);
            this.Name = "ctrlMessage";
            this.Size = new System.Drawing.Size(383, 99);
            ((System.ComponentModel.ISupportInitialize)(this.btnReplyToMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMemberImage;
        private System.Windows.Forms.RichTextBox rtxMessage;
        private System.Windows.Forms.PictureBox btnReplyToMessage;
        private System.Windows.Forms.Label lblMemberName;
    }
}
