namespace Telegram_Clone.Groups
{
    partial class frmShowGroupDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.flyMembers = new System.Windows.Forms.FlowLayoutPanel();
            this.rdbPublic = new System.Windows.Forms.RadioButton();
            this.rdbPrivate = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblChangePicture = new System.Windows.Forms.LinkLabel();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pbAdminPicture = new System.Windows.Forms.PictureBox();
            this.pbGroupImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroupImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(256, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Admin:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.Color.White;
            this.lblMemberName.Location = new System.Drawing.Point(124, 203);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(119, 20);
            this.lblMemberName.TabIndex = 7;
            this.lblMemberName.Text = "MemberName";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(271, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 24);
            this.label7.TabIndex = 8;
            this.label7.Text = "Link:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(324, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "t.me/Groupname";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(24, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 24);
            this.label9.TabIndex = 10;
            this.label9.Text = "Members:";
            // 
            // flyMembers
            // 
            this.flyMembers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flyMembers.Location = new System.Drawing.Point(29, 277);
            this.flyMembers.Name = "flyMembers";
            this.flyMembers.Size = new System.Drawing.Size(427, 155);
            this.flyMembers.TabIndex = 11;
            // 
            // rdbPublic
            // 
            this.rdbPublic.AutoSize = true;
            this.rdbPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPublic.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbPublic.Location = new System.Drawing.Point(325, 131);
            this.rdbPublic.Name = "rdbPublic";
            this.rdbPublic.Size = new System.Drawing.Size(69, 24);
            this.rdbPublic.TabIndex = 12;
            this.rdbPublic.TabStop = true;
            this.rdbPublic.Text = "Public";
            this.rdbPublic.UseVisualStyleBackColor = true;
            // 
            // rdbPrivate
            // 
            this.rdbPrivate.AutoSize = true;
            this.rdbPrivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPrivate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rdbPrivate.Location = new System.Drawing.Point(400, 131);
            this.rdbPrivate.Name = "rdbPrivate";
            this.rdbPrivate.Size = new System.Drawing.Size(75, 24);
            this.rdbPrivate.TabIndex = 13;
            this.rdbPrivate.TabStop = true;
            this.rdbPrivate.Text = "Private";
            this.rdbPrivate.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(325, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 34);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblChangePicture
            // 
            this.lblChangePicture.AutoSize = true;
            this.lblChangePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChangePicture.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.lblChangePicture.Location = new System.Drawing.Point(84, 49);
            this.lblChangePicture.Name = "lblChangePicture";
            this.lblChangePicture.Size = new System.Drawing.Size(100, 16);
            this.lblChangePicture.TabIndex = 16;
            this.lblChangePicture.TabStop = true;
            this.lblChangePicture.Text = "Change picture ";
            this.lblChangePicture.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblChangePicture_LinkClicked);
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.txtGroupName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGroupName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtGroupName.Location = new System.Drawing.Point(98, 133);
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(151, 19);
            this.txtGroupName.TabIndex = 17;
            this.txtGroupName.Text = "Group Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pbAdminPicture
            // 
            this.pbAdminPicture.Image = global::Telegram_Clone.Properties.Resources.man_512;
            this.pbAdminPicture.Location = new System.Drawing.Point(95, 199);
            this.pbAdminPicture.Name = "pbAdminPicture";
            this.pbAdminPicture.Size = new System.Drawing.Size(26, 24);
            this.pbAdminPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAdminPicture.TabIndex = 6;
            this.pbAdminPicture.TabStop = false;
            // 
            // pbGroupImage
            // 
            this.pbGroupImage.Image = global::Telegram_Clone.Properties.Resources.icons8_chat_group_35;
            this.pbGroupImage.Location = new System.Drawing.Point(197, 12);
            this.pbGroupImage.Name = "pbGroupImage";
            this.pbGroupImage.Size = new System.Drawing.Size(88, 88);
            this.pbGroupImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGroupImage.TabIndex = 0;
            this.pbGroupImage.TabStop = false;
            // 
            // frmShowGroupDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(488, 444);
            this.Controls.Add(this.txtGroupName);
            this.Controls.Add(this.lblChangePicture);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.rdbPrivate);
            this.Controls.Add(this.rdbPublic);
            this.Controls.Add(this.flyMembers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.pbAdminPicture);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGroupImage);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmShowGroupDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmShowGroupDetails";
            this.Load += new System.EventHandler(this.frmShowGroupDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAdminPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroupImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGroupImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbAdminPicture;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flyMembers;
        private System.Windows.Forms.RadioButton rdbPublic;
        private System.Windows.Forms.RadioButton rdbPrivate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.LinkLabel lblChangePicture;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}