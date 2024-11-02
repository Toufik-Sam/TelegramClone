namespace Telegram_Clone.Channels
{
    partial class frmShowChannelInfo
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
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.lblChangePicture = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.rdbPrivate = new System.Windows.Forms.RadioButton();
            this.rdbPublic = new System.Windows.Forms.RadioButton();
            this.flySubscribers = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbAdminPicture = new System.Windows.Forms.PictureBox();
            this.pbChannelImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannelImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtChannelName
            // 
            this.txtChannelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.txtChannelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChannelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChannelName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtChannelName.Location = new System.Drawing.Point(90, 131);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(151, 26);
            this.txtChannelName.TabIndex = 32;
            this.txtChannelName.Text = "Channel Name";
            // 
            // lblChangePicture
            // 
            this.lblChangePicture.AutoSize = true;
            this.lblChangePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePicture.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblChangePicture.Location = new System.Drawing.Point(81, 49);
            this.lblChangePicture.Name = "lblChangePicture";
            this.lblChangePicture.Size = new System.Drawing.Size(100, 16);
            this.lblChangePicture.TabIndex = 31;
            this.lblChangePicture.TabStop = true;
            this.lblChangePicture.Text = "Change picture ";
            this.lblChangePicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChangePicture_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(322, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 34);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rdbPrivate
            // 
            this.rdbPrivate.AutoSize = true;
            this.rdbPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrivate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbPrivate.Location = new System.Drawing.Point(397, 131);
            this.rdbPrivate.Name = "rdbPrivate";
            this.rdbPrivate.Size = new System.Drawing.Size(75, 24);
            this.rdbPrivate.TabIndex = 29;
            this.rdbPrivate.TabStop = true;
            this.rdbPrivate.Text = "Private";
            this.rdbPrivate.UseVisualStyleBackColor = true;
            // 
            // rdbPublic
            // 
            this.rdbPublic.AutoSize = true;
            this.rdbPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPublic.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbPublic.Location = new System.Drawing.Point(322, 131);
            this.rdbPublic.Name = "rdbPublic";
            this.rdbPublic.Size = new System.Drawing.Size(69, 24);
            this.rdbPublic.TabIndex = 28;
            this.rdbPublic.TabStop = true;
            this.rdbPublic.Text = "Public";
            this.rdbPublic.UseVisualStyleBackColor = true;
            // 
            // flySubscribers
            // 
            this.flySubscribers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flySubscribers.Location = new System.Drawing.Point(26, 277);
            this.flySubscribers.Name = "flySubscribers";
            this.flySubscribers.Size = new System.Drawing.Size(427, 155);
            this.flySubscribers.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(21, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Subscribers:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(321, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 20);
            this.label8.TabIndex = 25;
            this.label8.Text = "t.me/ChannelName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(268, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Link:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.Color.White;
            this.lblMemberName.Location = new System.Drawing.Point(121, 203);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(119, 20);
            this.lblMemberName.TabIndex = 23;
            this.lblMemberName.Text = "MemberName";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Admin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(253, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Name:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbAdminPicture
            // 
            this.pbAdminPicture.Image = global::Telegram_Clone.Properties.Resources.man_512;
            this.pbAdminPicture.Location = new System.Drawing.Point(92, 199);
            this.pbAdminPicture.Name = "pbAdminPicture";
            this.pbAdminPicture.Size = new System.Drawing.Size(26, 24);
            this.pbAdminPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdminPicture.TabIndex = 22;
            this.pbAdminPicture.TabStop = false;
            // 
            // pbChannelImage
            // 
            this.pbChannelImage.Image = global::Telegram_Clone.Properties.Resources.icons8_chat_group_35;
            this.pbChannelImage.Location = new System.Drawing.Point(194, 12);
            this.pbChannelImage.Name = "pbChannelImage";
            this.pbChannelImage.Size = new System.Drawing.Size(88, 88);
            this.pbChannelImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbChannelImage.TabIndex = 18;
            this.pbChannelImage.TabStop = false;
            // 
            // frmShowChannelInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(488, 444);
            this.Controls.Add(this.txtChannelName);
            this.Controls.Add(this.lblChangePicture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdbPrivate);
            this.Controls.Add(this.rdbPublic);
            this.Controls.Add(this.flySubscribers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.pbAdminPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbChannelImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowChannelInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmShowChannelInfo";
            this.Load += new System.EventHandler(this.frmShowChannelInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChannelImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChannelName;
        private System.Windows.Forms.LinkLabel lblChangePicture;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdbPrivate;
        private System.Windows.Forms.RadioButton rdbPublic;
        private System.Windows.Forms.FlowLayoutPanel flySubscribers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.PictureBox pbAdminPicture;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbChannelImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}