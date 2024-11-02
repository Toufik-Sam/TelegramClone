namespace Telegram_Clone.Groups.Controls
{
    partial class ctrlReplyMessage
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
            this.rtxReplyToMessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbReplyToMember = new System.Windows.Forms.PictureBox();
            this.pbMainMember = new System.Windows.Forms.PictureBox();
            this.rtxMainMessage = new System.Windows.Forms.RichTextBox();
            this.btnReplyToMessage = new System.Windows.Forms.PictureBox();
            this.lblMainMemberName = new System.Windows.Forms.Label();
            this.lblReplyToMemberName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbReplyToMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplyToMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // rtxReplyToMessage
            // 
            this.rtxReplyToMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.rtxReplyToMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxReplyToMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxReplyToMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.rtxReplyToMessage.Location = new System.Drawing.Point(136, 7);
            this.rtxReplyToMessage.Name = "rtxReplyToMessage";
            this.rtxReplyToMessage.ReadOnly = true;
            this.rtxReplyToMessage.Size = new System.Drawing.Size(204, 41);
            this.rtxReplyToMessage.TabIndex = 2;
            this.rtxReplyToMessage.Text = "First Message";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reply To:";
            // 
            // pbReplyToMember
            // 
            this.pbReplyToMember.Image = global::Telegram_Clone.Properties.Resources.man_512;
            this.pbReplyToMember.Location = new System.Drawing.Point(100, 49);
            this.pbReplyToMember.Name = "pbReplyToMember";
            this.pbReplyToMember.Size = new System.Drawing.Size(29, 28);
            this.pbReplyToMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReplyToMember.TabIndex = 4;
            this.pbReplyToMember.TabStop = false;
            // 
            // pbMainMember
            // 
            this.pbMainMember.Image = global::Telegram_Clone.Properties.Resources.man_512;
            this.pbMainMember.Location = new System.Drawing.Point(17, 154);
            this.pbMainMember.Name = "pbMainMember";
            this.pbMainMember.Size = new System.Drawing.Size(29, 28);
            this.pbMainMember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMainMember.TabIndex = 5;
            this.pbMainMember.TabStop = false;
            // 
            // rtxMainMessage
            // 
            this.rtxMainMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.rtxMainMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxMainMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxMainMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.rtxMainMessage.Location = new System.Drawing.Point(52, 97);
            this.rtxMainMessage.Name = "rtxMainMessage";
            this.rtxMainMessage.Size = new System.Drawing.Size(288, 55);
            this.rtxMainMessage.TabIndex = 6;
            this.rtxMainMessage.Text = "First Message";
            // 
            // btnReplyToMessage
            // 
            this.btnReplyToMessage.Image = global::Telegram_Clone.Properties.Resources.icons8_reply_arrow_20;
            this.btnReplyToMessage.Location = new System.Drawing.Point(346, 117);
            this.btnReplyToMessage.Name = "btnReplyToMessage";
            this.btnReplyToMessage.Size = new System.Drawing.Size(23, 20);
            this.btnReplyToMessage.TabIndex = 7;
            this.btnReplyToMessage.TabStop = false;
            this.btnReplyToMessage.Click += new System.EventHandler(this.btnReplyToMessage_Click);
            // 
            // lblMainMemberName
            // 
            this.lblMainMemberName.AutoSize = true;
            this.lblMainMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMemberName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMainMemberName.Location = new System.Drawing.Point(53, 161);
            this.lblMainMemberName.Name = "lblMainMemberName";
            this.lblMainMemberName.Size = new System.Drawing.Size(97, 16);
            this.lblMainMemberName.TabIndex = 8;
            this.lblMainMemberName.Text = "Member Name";
            // 
            // lblReplyToMemberName
            // 
            this.lblReplyToMemberName.AutoSize = true;
            this.lblReplyToMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplyToMemberName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblReplyToMemberName.Location = new System.Drawing.Point(135, 56);
            this.lblReplyToMemberName.Name = "lblReplyToMemberName";
            this.lblReplyToMemberName.Size = new System.Drawing.Size(97, 16);
            this.lblReplyToMemberName.TabIndex = 9;
            this.lblReplyToMemberName.Text = "Member Name";
            // 
            // ctrlReplyMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblReplyToMemberName);
            this.Controls.Add(this.lblMainMemberName);
            this.Controls.Add(this.btnReplyToMessage);
            this.Controls.Add(this.rtxMainMessage);
            this.Controls.Add(this.pbMainMember);
            this.Controls.Add(this.pbReplyToMember);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxReplyToMessage);
            this.Name = "ctrlReplyMessage";
            this.Size = new System.Drawing.Size(381, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pbReplyToMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMainMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReplyToMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxReplyToMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbReplyToMember;
        private System.Windows.Forms.PictureBox pbMainMember;
        private System.Windows.Forms.RichTextBox rtxMainMessage;
        private System.Windows.Forms.PictureBox btnReplyToMessage;
        private System.Windows.Forms.Label lblMainMemberName;
        private System.Windows.Forms.Label lblReplyToMemberName;
    }
}
