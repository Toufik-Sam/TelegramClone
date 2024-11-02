namespace Telegram_Clone.Channels.Controls
{
    partial class ctrlChannelImageCaptionMessage
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnShare = new System.Windows.Forms.PictureBox();
            this.pbMessageImage = new System.Windows.Forms.PictureBox();
            this.pbChannel = new System.Windows.Forms.PictureBox();
            this.rtxText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMessageImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannel)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnShare
            // 
            this.btnShare.Image = global::Telegram_Clone.Properties.Resources.icons8_share_20;
            this.btnShare.Location = new System.Drawing.Point(336, 120);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(25, 25);
            this.btnShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShare.TabIndex = 7;
            this.btnShare.TabStop = false;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // pbMessageImage
            // 
            this.pbMessageImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbMessageImage.Location = new System.Drawing.Point(75, 22);
            this.pbMessageImage.Name = "pbMessageImage";
            this.pbMessageImage.Size = new System.Drawing.Size(215, 178);
            this.pbMessageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMessageImage.TabIndex = 0;
            this.pbMessageImage.TabStop = false;
            // 
            // pbChannel
            // 
            this.pbChannel.Image = global::Telegram_Clone.Properties.Resources.icons8_chat_group_35;
            this.pbChannel.Location = new System.Drawing.Point(17, 101);
            this.pbChannel.Name = "pbChannel";
            this.pbChannel.Size = new System.Drawing.Size(36, 33);
            this.pbChannel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChannel.TabIndex = 8;
            this.pbChannel.TabStop = false;
            // 
            // rtxText
            // 
            this.rtxText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.rtxText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtxText.Location = new System.Drawing.Point(28, 207);
            this.rtxText.Name = "rtxText";
            this.rtxText.Size = new System.Drawing.Size(311, 48);
            this.rtxText.TabIndex = 9;
            this.rtxText.Text = "";
            // 
            // ctrlChannelImageCaptionMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.rtxText);
            this.Controls.Add(this.pbChannel);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.pbMessageImage);
            this.Name = "ctrlChannelImageCaptionMessage";
            this.Size = new System.Drawing.Size(379, 278);
            ((System.ComponentModel.ISupportInitialize)(this.btnShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMessageImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMessageImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox btnShare;
        private System.Windows.Forms.PictureBox pbChannel;
        private System.Windows.Forms.RichTextBox rtxText;
    }
}
