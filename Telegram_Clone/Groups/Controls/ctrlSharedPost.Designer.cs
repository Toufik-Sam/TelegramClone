namespace Telegram_Clone.Groups.Controls
{
    partial class ctrlSharedPost
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
            this.linkPageName = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPagePostImage = new System.Windows.Forms.PictureBox();
            this.rtxMessage = new System.Windows.Forms.RichTextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.pbMemberImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagePostImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberImage)).BeginInit();
            this.SuspendLayout();
            // 
            // linkPageName
            // 
            this.linkPageName.AutoSize = true;
            this.linkPageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPageName.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.linkPageName.Location = new System.Drawing.Point(195, 13);
            this.linkPageName.Name = "linkPageName";
            this.linkPageName.Size = new System.Drawing.Size(92, 20);
            this.linkPageName.TabIndex = 0;
            this.linkPageName.TabStop = true;
            this.linkPageName.Text = "Page Name";
            this.linkPageName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPageName_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(22, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Post Shared From Page: ";
            // 
            // pbPagePostImage
            // 
            this.pbPagePostImage.Location = new System.Drawing.Point(229, 59);
            this.pbPagePostImage.Name = "pbPagePostImage";
            this.pbPagePostImage.Size = new System.Drawing.Size(95, 97);
            this.pbPagePostImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPagePostImage.TabIndex = 2;
            this.pbPagePostImage.TabStop = false;
            // 
            // rtxMessage
            // 
            this.rtxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.rtxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rtxMessage.Location = new System.Drawing.Point(20, 82);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.Size = new System.Drawing.Size(198, 46);
            this.rtxMessage.TabIndex = 3;
            this.rtxMessage.Text = "";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMemberName.Location = new System.Drawing.Point(47, 155);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(97, 16);
            this.lblMemberName.TabIndex = 5;
            this.lblMemberName.Text = "Member Name";
            // 
            // pbMemberImage
            // 
            this.pbMemberImage.Image = global::Telegram_Clone.Properties.Resources.man_512;
            this.pbMemberImage.Location = new System.Drawing.Point(11, 148);
            this.pbMemberImage.Name = "pbMemberImage";
            this.pbMemberImage.Size = new System.Drawing.Size(29, 28);
            this.pbMemberImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMemberImage.TabIndex = 4;
            this.pbMemberImage.TabStop = false;
            // 
            // ctrlSharedPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.pbMemberImage);
            this.Controls.Add(this.rtxMessage);
            this.Controls.Add(this.pbPagePostImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkPageName);
            this.Name = "ctrlSharedPost";
            this.Size = new System.Drawing.Size(381, 194);
            ((System.ComponentModel.ISupportInitialize)(this.pbPagePostImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkPageName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPagePostImage;
        private System.Windows.Forms.RichTextBox rtxMessage;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.PictureBox pbMemberImage;
    }
}
