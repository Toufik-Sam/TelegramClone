namespace Telegram_Clone.Channels
{
    partial class frmShowChannelMessaging
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flyChannelMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnJoin = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.lblSubscribers = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.rtxMessage = new System.Windows.Forms.RichTextBox();
            this.btnOpenFile = new System.Windows.Forms.PictureBox();
            this.btnSendMessage = new System.Windows.Forms.PictureBox();
            this.pbChannelImageMessage = new System.Windows.Forms.PictureBox();
            this.pnldown = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannelImageMessage)).BeginInit();
            this.pnldown.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // flyChannelMessages
            // 
            this.flyChannelMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flyChannelMessages.AutoScroll = true;
            this.flyChannelMessages.Location = new System.Drawing.Point(0, 44);
            this.flyChannelMessages.Name = "flyChannelMessages";
            this.flyChannelMessages.Size = new System.Drawing.Size(690, 451);
            this.flyChannelMessages.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnJoin);
            this.panel2.Controls.Add(this.btnMenu);
            this.panel2.Controls.Add(this.lblSubscribers);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 46);
            this.panel2.TabIndex = 9;
            // 
            // btnJoin
            // 
            this.btnJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJoin.Location = new System.Drawing.Point(300, 6);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 30);
            this.btnJoin.TabIndex = 5;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Visible = false;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
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
            // 
            // lblSubscribers
            // 
            this.lblSubscribers.AutoSize = true;
            this.lblSubscribers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscribers.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSubscribers.Location = new System.Drawing.Point(43, 24);
            this.lblSubscribers.Name = "lblSubscribers";
            this.lblSubscribers.Size = new System.Drawing.Size(96, 16);
            this.lblSubscribers.TabIndex = 2;
            this.lblSubscribers.Text = "12 Subscribers";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(22, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(118, 18);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Channel Name";
            // 
            // rtxMessage
            // 
            this.rtxMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.rtxMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.rtxMessage.Location = new System.Drawing.Point(101, 16);
            this.rtxMessage.Name = "rtxMessage";
            this.rtxMessage.Size = new System.Drawing.Size(494, 35);
            this.rtxMessage.TabIndex = 8;
            this.rtxMessage.Text = "Write a Message....";
            this.rtxMessage.Enter += new System.EventHandler(this.rtxMessage_Enter);
            this.rtxMessage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rtxMessage_KeyDown);
            this.rtxMessage.Leave += new System.EventHandler(this.rtxMessage_Leave);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Image = global::Telegram_Clone.Properties.Resources.icons8_opened_folder_30;
            this.btnOpenFile.Location = new System.Drawing.Point(23, 18);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(29, 28);
            this.btnOpenFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOpenFile.TabIndex = 9;
            this.btnOpenFile.TabStop = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Image = global::Telegram_Clone.Properties.Resources.icons8_send_message_30;
            this.btnSendMessage.Location = new System.Drawing.Point(62, 19);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(29, 28);
            this.btnSendMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSendMessage.TabIndex = 10;
            this.btnSendMessage.TabStop = false;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // pbChannelImageMessage
            // 
            this.pbChannelImageMessage.ContextMenuStrip = this.contextMenuStrip1;
            this.pbChannelImageMessage.Location = new System.Drawing.Point(620, 19);
            this.pbChannelImageMessage.Name = "pbChannelImageMessage";
            this.pbChannelImageMessage.Size = new System.Drawing.Size(29, 28);
            this.pbChannelImageMessage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChannelImageMessage.TabIndex = 11;
            this.pbChannelImageMessage.TabStop = false;
            // 
            // pnldown
            // 
            this.pnldown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.pnldown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnldown.Controls.Add(this.pbChannelImageMessage);
            this.pnldown.Controls.Add(this.btnSendMessage);
            this.pnldown.Controls.Add(this.btnOpenFile);
            this.pnldown.Controls.Add(this.rtxMessage);
            this.pnldown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnldown.Location = new System.Drawing.Point(0, 498);
            this.pnldown.Name = "pnldown";
            this.pnldown.Size = new System.Drawing.Size(690, 72);
            this.pnldown.TabIndex = 8;
            // 
            // frmShowChannelMessaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(690, 570);
            this.Controls.Add(this.pnldown);
            this.Controls.Add(this.flyChannelMessages);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShowChannelMessaging";
            this.Text = "frmShowChannelMessaging";
            this.Load += new System.EventHandler(this.frmShowChannelMessaging_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSendMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannelImageMessage)).EndInit();
            this.pnldown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flyChannelMessages;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Label lblSubscribers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox rtxMessage;
        private System.Windows.Forms.PictureBox btnOpenFile;
        private System.Windows.Forms.PictureBox btnSendMessage;
        private System.Windows.Forms.PictureBox pbChannelImageMessage;
        private System.Windows.Forms.Panel pnldown;
    }
}