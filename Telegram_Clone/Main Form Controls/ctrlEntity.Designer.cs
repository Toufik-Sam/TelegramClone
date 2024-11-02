namespace Telegram_Clone.Main_Form_Controls
{
    partial class ctrlEntity
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
            this.lblEntityName = new System.Windows.Forms.Label();
            this.btnJoinGroup = new System.Windows.Forms.PictureBox();
            this.pbEntityImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnJoinGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEntityImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEntityName
            // 
            this.lblEntityName.AutoSize = true;
            this.lblEntityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntityName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEntityName.Location = new System.Drawing.Point(45, 12);
            this.lblEntityName.Name = "lblEntityName";
            this.lblEntityName.Size = new System.Drawing.Size(88, 18);
            this.lblEntityName.TabIndex = 1;
            this.lblEntityName.Text = "Entity Name";
            this.lblEntityName.MouseEnter += new System.EventHandler(this.ctrlEntity_MouseEnter);
            this.lblEntityName.MouseLeave += new System.EventHandler(this.ctrlEntity_MouseLeave);
            // 
            // btnJoinGroup
            // 
            this.btnJoinGroup.Image = global::Telegram_Clone.Properties.Resources.icons8_add_male_user_group_20;
            this.btnJoinGroup.Location = new System.Drawing.Point(200, 7);
            this.btnJoinGroup.Name = "btnJoinGroup";
            this.btnJoinGroup.Size = new System.Drawing.Size(27, 24);
            this.btnJoinGroup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnJoinGroup.TabIndex = 2;
            this.btnJoinGroup.TabStop = false;
            this.btnJoinGroup.Click += new System.EventHandler(this.btnJoinGroup_Click);
            this.btnJoinGroup.MouseEnter += new System.EventHandler(this.ctrlEntity_MouseEnter);
            this.btnJoinGroup.MouseLeave += new System.EventHandler(this.ctrlEntity_MouseLeave);
            // 
            // pbEntityImage
            // 
            this.pbEntityImage.Image = global::Telegram_Clone.Properties.Resources.icons8_chat_group_351;
            this.pbEntityImage.Location = new System.Drawing.Point(8, 5);
            this.pbEntityImage.Name = "pbEntityImage";
            this.pbEntityImage.Size = new System.Drawing.Size(31, 30);
            this.pbEntityImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbEntityImage.TabIndex = 0;
            this.pbEntityImage.TabStop = false;
            this.pbEntityImage.MouseEnter += new System.EventHandler(this.ctrlEntity_MouseEnter);
            this.pbEntityImage.MouseLeave += new System.EventHandler(this.ctrlEntity_MouseLeave);
            // 
            // ctrlEntity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.btnJoinGroup);
            this.Controls.Add(this.lblEntityName);
            this.Controls.Add(this.pbEntityImage);
            this.Name = "ctrlEntity";
            this.Size = new System.Drawing.Size(249, 44);
            this.MouseEnter += new System.EventHandler(this.ctrlEntity_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ctrlEntity_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.btnJoinGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEntityImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbEntityImage;
        private System.Windows.Forms.Label lblEntityName;
        private System.Windows.Forms.PictureBox btnJoinGroup;
    }
}
