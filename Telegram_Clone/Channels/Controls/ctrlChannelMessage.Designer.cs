namespace Telegram_Clone.Channels.Controls
{
    partial class ctrlChannelMessage
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
            this.pbChannelImage = new System.Windows.Forms.PictureBox();
            this.btnShare = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannelImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShare)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxMessage
            // 
            this.rtxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.rtxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.rtxMessage.Location = new System.Drawing.Point(60, 10);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.Size = new System.Drawing.Size(280, 54);
            this.rtxMessage.TabIndex = 2;
            this.rtxMessage.Text = "First Message";
            // 
            // pbChannelImage
            // 
            this.pbChannelImage.Image = global::Telegram_Clone.Properties.Resources.icons8_chat_group_35;
            this.pbChannelImage.Location = new System.Drawing.Point(12, 22);
            this.pbChannelImage.Name = "pbChannelImage";
            this.pbChannelImage.Size = new System.Drawing.Size(36, 33);
            this.pbChannelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChannelImage.TabIndex = 3;
            this.pbChannelImage.TabStop = false;
            // 
            // btnShare
            // 
            this.btnShare.Image = global::Telegram_Clone.Properties.Resources.icons8_share_20;
            this.btnShare.Location = new System.Drawing.Point(348, 22);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(25, 25);
            this.btnShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShare.TabIndex = 8;
            this.btnShare.TabStop = false;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // ctrlChannelMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.pbChannelImage);
            this.Controls.Add(this.rtxMessage);
            this.Name = "ctrlChannelMessage";
            this.Size = new System.Drawing.Size(381, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pbChannelImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxMessage;
        private System.Windows.Forms.PictureBox pbChannelImage;
        private System.Windows.Forms.PictureBox btnShare;
    }
}
