namespace Telegram_Clone
{
    partial class MainForm
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
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.btnMaxi = new System.Windows.Forms.PictureBox();
            this.btnResize = new System.Windows.Forms.PictureBox();
            this.btnMini = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlUserSilder = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnContacts = new System.Windows.Forms.Button();
            this.btnNewChannel = new System.Windows.Forms.Button();
            this.btnNewGroup = new System.Windows.Forms.Button();
            this.pbUserImage = new System.Windows.Forms.PictureBox();
            this.btnSlidUserMenu = new System.Windows.Forms.Button();
            this.flowlayoutChannelsandGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchForEnttiy = new System.Windows.Forms.TextBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.pnlSideBar.SuspendLayout();
            this.pnlUserSilder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.pnlTopBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTopBar.Controls.Add(this.btnMaxi);
            this.pnlTopBar.Controls.Add(this.btnResize);
            this.pnlTopBar.Controls.Add(this.btnMini);
            this.pnlTopBar.Controls.Add(this.btnClose);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(969, 35);
            this.pnlTopBar.TabIndex = 0;
            this.pnlTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTopBar_MouseDown);
            // 
            // btnMaxi
            // 
            this.btnMaxi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnMaxi.Image = global::Telegram_Clone.Properties.Resources.icons8_Whitemaximize_20;
            this.btnMaxi.Location = new System.Drawing.Point(887, 2);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(21, 22);
            this.btnMaxi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMaxi.TabIndex = 3;
            this.btnMaxi.TabStop = false;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaxi_Click);
            // 
            // btnResize
            // 
            this.btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnResize.Image = global::Telegram_Clone.Properties.Resources.icons8_WhiteResize_20;
            this.btnResize.Location = new System.Drawing.Point(887, 3);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(21, 22);
            this.btnResize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnResize.TabIndex = 5;
            this.btnResize.TabStop = false;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnMini.Image = global::Telegram_Clone.Properties.Resources.icons8_Whiteminus_20;
            this.btnMini.Location = new System.Drawing.Point(846, 3);
            this.btnMini.Name = "btnMini";
            this.btnMini.Size = new System.Drawing.Size(21, 22);
            this.btnMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMini.TabIndex = 4;
            this.btnMini.TabStop = false;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.btnClose.Image = global::Telegram_Clone.Properties.Resources.icons8_Whitecross_20;
            this.btnClose.Location = new System.Drawing.Point(928, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 22);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.pnlSideBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSideBar.Controls.Add(this.pnlUserSilder);
            this.pnlSideBar.Controls.Add(this.btnSlidUserMenu);
            this.pnlSideBar.Controls.Add(this.flowlayoutChannelsandGroups);
            this.pnlSideBar.Controls.Add(this.txtSearchForEnttiy);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 35);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(277, 582);
            this.pnlSideBar.TabIndex = 1;
            // 
            // pnlUserSilder
            // 
            this.pnlUserSilder.Controls.Add(this.btnSearch);
            this.pnlUserSilder.Controls.Add(this.btnLogOut);
            this.pnlUserSilder.Controls.Add(this.btnReturn);
            this.pnlUserSilder.Controls.Add(this.btnSettings);
            this.pnlUserSilder.Controls.Add(this.btnContacts);
            this.pnlUserSilder.Controls.Add(this.btnNewChannel);
            this.pnlUserSilder.Controls.Add(this.btnNewGroup);
            this.pnlUserSilder.Controls.Add(this.pbUserImage);
            this.pnlUserSilder.Location = new System.Drawing.Point(4, 2);
            this.pnlUserSilder.Name = "pnlUserSilder";
            this.pnlUserSilder.Size = new System.Drawing.Size(251, 565);
            this.pnlUserSilder.TabIndex = 2;
            this.pnlUserSilder.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSearch.Image = global::Telegram_Clone.Properties.Resources.icons8_search_30;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(3, 137);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(244, 34);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.Image = global::Telegram_Clone.Properties.Resources.icons8_logout_35;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(3, 392);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(244, 34);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.FlatAppearance.BorderSize = 0;
            this.btnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturn.Image = global::Telegram_Clone.Properties.Resources.icons8_return_30;
            this.btnReturn.Location = new System.Drawing.Point(197, 27);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(35, 32);
            this.btnReturn.TabIndex = 0;
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSettings.Image = global::Telegram_Clone.Properties.Resources.icons8_settings_35;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(3, 341);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(244, 34);
            this.btnSettings.TabIndex = 5;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnContacts
            // 
            this.btnContacts.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.btnContacts.FlatAppearance.BorderSize = 0;
            this.btnContacts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.btnContacts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContacts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnContacts.Image = global::Telegram_Clone.Properties.Resources.icons8_contacts_35;
            this.btnContacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnContacts.Location = new System.Drawing.Point(3, 290);
            this.btnContacts.Name = "btnContacts";
            this.btnContacts.Size = new System.Drawing.Size(244, 34);
            this.btnContacts.TabIndex = 3;
            this.btnContacts.Text = "Contacts";
            this.btnContacts.UseVisualStyleBackColor = true;
            this.btnContacts.Click += new System.EventHandler(this.btnContacts_Click);
            // 
            // btnNewChannel
            // 
            this.btnNewChannel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.btnNewChannel.FlatAppearance.BorderSize = 0;
            this.btnNewChannel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.btnNewChannel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewChannel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewChannel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewChannel.Image = global::Telegram_Clone.Properties.Resources.icons8_announcement_35;
            this.btnNewChannel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewChannel.Location = new System.Drawing.Point(3, 239);
            this.btnNewChannel.Name = "btnNewChannel";
            this.btnNewChannel.Size = new System.Drawing.Size(244, 34);
            this.btnNewChannel.TabIndex = 2;
            this.btnNewChannel.Text = "New Channel";
            this.btnNewChannel.UseVisualStyleBackColor = true;
            this.btnNewChannel.Click += new System.EventHandler(this.btnNewChannel_Click);
            // 
            // btnNewGroup
            // 
            this.btnNewGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.btnNewGroup.FlatAppearance.BorderSize = 0;
            this.btnNewGroup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.btnNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGroup.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNewGroup.Image = global::Telegram_Clone.Properties.Resources.icons8_person_351;
            this.btnNewGroup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewGroup.Location = new System.Drawing.Point(3, 188);
            this.btnNewGroup.Name = "btnNewGroup";
            this.btnNewGroup.Size = new System.Drawing.Size(244, 34);
            this.btnNewGroup.TabIndex = 1;
            this.btnNewGroup.Text = "New Group";
            this.btnNewGroup.UseVisualStyleBackColor = true;
            this.btnNewGroup.Click += new System.EventHandler(this.btnNewGroup_Click);
            // 
            // pbUserImage
            // 
            this.pbUserImage.Image = global::Telegram_Clone.Properties.Resources.man_512;
            this.pbUserImage.Location = new System.Drawing.Point(8, 27);
            this.pbUserImage.Name = "pbUserImage";
            this.pbUserImage.Size = new System.Drawing.Size(82, 75);
            this.pbUserImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserImage.TabIndex = 0;
            this.pbUserImage.TabStop = false;
            // 
            // btnSlidUserMenu
            // 
            this.btnSlidUserMenu.FlatAppearance.BorderSize = 0;
            this.btnSlidUserMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.btnSlidUserMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSlidUserMenu.Image = global::Telegram_Clone.Properties.Resources.icons8_White_menu_35;
            this.btnSlidUserMenu.Location = new System.Drawing.Point(11, 8);
            this.btnSlidUserMenu.Name = "btnSlidUserMenu";
            this.btnSlidUserMenu.Size = new System.Drawing.Size(35, 26);
            this.btnSlidUserMenu.TabIndex = 3;
            this.btnSlidUserMenu.UseVisualStyleBackColor = true;
            this.btnSlidUserMenu.Click += new System.EventHandler(this.btnSlidUserMenu_Click);
            // 
            // flowlayoutChannelsandGroups
            // 
            this.flowlayoutChannelsandGroups.Location = new System.Drawing.Point(3, 42);
            this.flowlayoutChannelsandGroups.Name = "flowlayoutChannelsandGroups";
            this.flowlayoutChannelsandGroups.Size = new System.Drawing.Size(267, 506);
            this.flowlayoutChannelsandGroups.TabIndex = 6;
            // 
            // txtSearchForEnttiy
            // 
            this.txtSearchForEnttiy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.txtSearchForEnttiy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchForEnttiy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchForEnttiy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchForEnttiy.Location = new System.Drawing.Point(58, 11);
            this.txtSearchForEnttiy.Name = "txtSearchForEnttiy";
            this.txtSearchForEnttiy.Size = new System.Drawing.Size(194, 24);
            this.txtSearchForEnttiy.TabIndex = 2;
            this.txtSearchForEnttiy.TextChanged += new System.EventHandler(this.txtSearchForEnttiy_TextChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(277, 35);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(692, 582);
            this.pnlMain.TabIndex = 4;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(969, 617);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaxi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnResize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            this.pnlUserSilder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMaxi;
        private System.Windows.Forms.PictureBox btnMini;
        private System.Windows.Forms.TextBox txtSearchForEnttiy;
        private System.Windows.Forms.FlowLayoutPanel flowlayoutChannelsandGroups;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlUserSilder;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnContacts;
        private System.Windows.Forms.Button btnNewChannel;
        private System.Windows.Forms.Button btnNewGroup;
        private System.Windows.Forms.PictureBox pbUserImage;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnSlidUserMenu;
        private System.Windows.Forms.PictureBox btnResize;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSearch;
    }
}

