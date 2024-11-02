namespace Telegram_Clone.Groups
{
    partial class frmShowGroupMessaging
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbMessageImage = new System.Windows.Forms.PictureBox();
            this.btnOpenFile = new System.Windows.Forms.PictureBox();
            this.btnVoiceMessage = new System.Windows.Forms.PictureBox();
            this.btnSendMessage = new System.Windows.Forms.PictureBox();
            this.rtxMessage = new System.Windows.Forms.RichTextBox();
            this.flyGroupMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlReplyToMessage = new System.Windows.Forms.Panel();
            this.pbCloseReplyMessage = new System.Windows.Forms.PictureBox();
            this.pbReplyToImageMessage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxReplyToMessage = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMessageImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoiceMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendMessage)).BeginInit();
            this.pnlReplyToMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseReplyMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReplyToImageMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.lblMembers);
            this.panel1.Controls.Add(this.lblGroupName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 46);
            this.panel1.TabIndex = 1;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Image = global::Telegram_Clone.Properties.Resources.icons8_menu_vertical_30;
            this.btnMenu.Location = new System.Drawing.Point(624, 11);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(25, 22);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 4;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseEnter += new System.EventHandler(this.btnMenu_MouseEnter);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMembers.Location = new System.Drawing.Point(43, 24);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(81, 16);
            this.lblMembers.TabIndex = 2;
            this.lblMembers.Text = "12 members";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblGroupName.Location = new System.Drawing.Point(22, 3);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(104, 18);
            this.lblGroupName.TabIndex = 1;
            this.lblGroupName.Text = "Group Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pbMessageImage);
            this.panel2.Controls.Add(this.btnOpenFile);
            this.panel2.Controls.Add(this.btnVoiceMessage);
            this.panel2.Controls.Add(this.btnSendMessage);
            this.panel2.Controls.Add(this.rtxMessage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 64);
            this.panel2.TabIndex = 2;
            // 
            // pbMessageImage
            // 
            this.pbMessageImage.Location = new System.Drawing.Point(591, 26);
            this.pbMessageImage.Name = "pbMessageImage";
            this.pbMessageImage.Size = new System.Drawing.Size(29, 28);
            this.pbMessageImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMessageImage.TabIndex = 9;
            this.pbMessageImage.TabStop = false;
            this.pbMessageImage.Visible = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Image = global::Telegram_Clone.Properties.Resources.icons8_opened_folder_30;
            this.btnOpenFile.Location = new System.Drawing.Point(26, 23);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(29, 28);
            this.btnOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOpenFile.TabIndex = 8;
            this.btnOpenFile.TabStop = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnVoiceMessage
            // 
            this.btnVoiceMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVoiceMessage.Image = global::Telegram_Clone.Properties.Resources.icons8_mic_30;
            this.btnVoiceMessage.Location = new System.Drawing.Point(653, 24);
            this.btnVoiceMessage.Name = "btnVoiceMessage";
            this.btnVoiceMessage.Size = new System.Drawing.Size(29, 28);
            this.btnVoiceMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnVoiceMessage.TabIndex = 7;
            this.btnVoiceMessage.TabStop = false;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Image = global::Telegram_Clone.Properties.Resources.icons8_send_message_30;
            this.btnSendMessage.Location = new System.Drawing.Point(64, 23);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(29, 28);
            this.btnSendMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSendMessage.TabIndex = 5;
            this.btnSendMessage.TabStop = false;
            this.btnSendMessage.MouseEnter += new System.EventHandler(this.btnDownloadFile_MouseEnter);
            this.btnSendMessage.MouseLeave += new System.EventHandler(this.btnDownloadFile_MouseLeave);
            // 
            // rtxMessage
            // 
            this.rtxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.rtxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.rtxMessage.Location = new System.Drawing.Point(115, 24);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.Size = new System.Drawing.Size(456, 30);
            this.rtxMessage.TabIndex = 2;
            this.rtxMessage.Text = "Write a Message....";
            this.rtxMessage.Enter += new System.EventHandler(this.rtxMessage_Enter);
            this.rtxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxMessage_KeyDown);
            this.rtxMessage.Leave += new System.EventHandler(this.rtxMessage_Leave);
            // 
            // flyGroupMessages
            // 
            this.flyGroupMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flyGroupMessages.AutoScroll = true;
            this.flyGroupMessages.Location = new System.Drawing.Point(0, 46);
            this.flyGroupMessages.Name = "flyGroupMessages";
            this.flyGroupMessages.Size = new System.Drawing.Size(690, 408);
            this.flyGroupMessages.TabIndex = 3;
            this.flyGroupMessages.Paint += new System.Windows.Forms.PaintEventHandler(this.flyGroupMessages_Paint);
            // 
            // pnlReplyToMessage
            // 
            this.pnlReplyToMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.pnlReplyToMessage.Controls.Add(this.pbCloseReplyMessage);
            this.pnlReplyToMessage.Controls.Add(this.pbReplyToImageMessage);
            this.pnlReplyToMessage.Controls.Add(this.label1);
            this.pnlReplyToMessage.Controls.Add(this.rtxReplyToMessage);
            this.pnlReplyToMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlReplyToMessage.Location = new System.Drawing.Point(0, 458);
            this.pnlReplyToMessage.Name = "pnlReplyToMessage";
            this.pnlReplyToMessage.Size = new System.Drawing.Size(690, 48);
            this.pnlReplyToMessage.TabIndex = 4;
            this.pnlReplyToMessage.Visible = false;
            // 
            // pbCloseReplyMessage
            // 
            this.pbCloseReplyMessage.Image = global::Telegram_Clone.Properties.Resources.icons8_Whitecross_20;
            this.pbCloseReplyMessage.Location = new System.Drawing.Point(638, 10);
            this.pbCloseReplyMessage.Name = "pbCloseReplyMessage";
            this.pbCloseReplyMessage.Size = new System.Drawing.Size(29, 28);
            this.pbCloseReplyMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCloseReplyMessage.TabIndex = 1;
            this.pbCloseReplyMessage.TabStop = false;
            this.pbCloseReplyMessage.Click += new System.EventHandler(this.pbCloseReplyMessage_Click);
            // 
            // pbReplyToImageMessage
            // 
            this.pbReplyToImageMessage.Location = new System.Drawing.Point(590, 10);
            this.pbReplyToImageMessage.Name = "pbReplyToImageMessage";
            this.pbReplyToImageMessage.Size = new System.Drawing.Size(29, 28);
            this.pbReplyToImageMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReplyToImageMessage.TabIndex = 10;
            this.pbReplyToImageMessage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Reply To:";
            // 
            // rtxReplyToMessage
            // 
            this.rtxReplyToMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.rtxReplyToMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxReplyToMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxReplyToMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.rtxReplyToMessage.Location = new System.Drawing.Point(89, 10);
            this.rtxReplyToMessage.Name = "rtxReplyToMessage";
            this.rtxReplyToMessage.Size = new System.Drawing.Size(456, 30);
            this.rtxReplyToMessage.TabIndex = 10;
            this.rtxReplyToMessage.Text = "Write a Message....";
            this.rtxReplyToMessage.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmShowGroupMessaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(690, 570);
            this.Controls.Add(this.pnlReplyToMessage);
            this.Controls.Add(this.flyGroupMessages);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowGroupMessaging";
            this.Text = "frmShowGroupMessaging";
            this.Load += new System.EventHandler(this.frmShowGroupMessaging_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMessageImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoiceMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendMessage)).EndInit();
            this.pnlReplyToMessage.ResumeLayout(false);
            this.pnlReplyToMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseReplyMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReplyToImageMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnVoiceMessage;
        private System.Windows.Forms.RichTextBox rtxMessage;
        private System.Windows.Forms.FlowLayoutPanel flyGroupMessages;
        private System.Windows.Forms.PictureBox btnSendMessage;
        private System.Windows.Forms.PictureBox btnOpenFile;
        private System.Windows.Forms.Panel pnlReplyToMessage;
        private System.Windows.Forms.RichTextBox rtxReplyToMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbCloseReplyMessage;
        private System.Windows.Forms.PictureBox pbMessageImage;
        private System.Windows.Forms.PictureBox pbReplyToImageMessage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}