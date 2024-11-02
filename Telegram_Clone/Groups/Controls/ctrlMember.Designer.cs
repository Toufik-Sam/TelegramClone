namespace Telegram_Clone.Groups.Controls
{
    partial class ctrlMember
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
            this.lblMemberName = new System.Windows.Forms.Label();
            this.btnDeleteMember = new System.Windows.Forms.PictureBox();
            this.pbMemberImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMemberName.Location = new System.Drawing.Point(47, 12);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(107, 18);
            this.lblMemberName.TabIndex = 1;
            this.lblMemberName.Text = "Member Name";
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Image = global::Telegram_Clone.Properties.Resources.icons8_delete_20;
            this.btnDeleteMember.Location = new System.Drawing.Point(172, 9);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(22, 23);
            this.btnDeleteMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteMember.TabIndex = 2;
            this.btnDeleteMember.TabStop = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // pbMemberImage
            // 
            this.pbMemberImage.Image = global::Telegram_Clone.Properties.Resources.man_512;
            this.pbMemberImage.Location = new System.Drawing.Point(13, 9);
            this.pbMemberImage.Name = "pbMemberImage";
            this.pbMemberImage.Size = new System.Drawing.Size(29, 26);
            this.pbMemberImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMemberImage.TabIndex = 0;
            this.pbMemberImage.TabStop = false;
            // 
            // ctrlMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.pbMemberImage);
            this.Name = "ctrlMember";
            this.Size = new System.Drawing.Size(207, 44);
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMemberImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMemberImage;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.PictureBox btnDeleteMember;
    }
}
