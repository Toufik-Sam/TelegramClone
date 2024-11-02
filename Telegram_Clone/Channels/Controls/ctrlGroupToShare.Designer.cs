namespace Telegram_Clone.Channels.Controls
{
    partial class ctrlGroupToShare
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
            this.lblGroupName = new System.Windows.Forms.Label();
            this.pbGroupImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGroupImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblGroupName.Location = new System.Drawing.Point(42, 12);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(94, 18);
            this.lblGroupName.TabIndex = 3;
            this.lblGroupName.Text = "Group Name";
            this.lblGroupName.Click += new System.EventHandler(this.ctrlGroupToShare_Click);
            this.lblGroupName.MouseEnter += new System.EventHandler(this.ctrlGroupToShare_MouseEnter);
            this.lblGroupName.MouseLeave += new System.EventHandler(this.ctrlGroupToShare_MouseLeave);
            // 
            // pbGroupImage
            // 
            this.pbGroupImage.Image = global::Telegram_Clone.Properties.Resources.icons8_chat_group_35;
            this.pbGroupImage.Location = new System.Drawing.Point(8, 9);
            this.pbGroupImage.Name = "pbGroupImage";
            this.pbGroupImage.Size = new System.Drawing.Size(29, 26);
            this.pbGroupImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGroupImage.TabIndex = 2;
            this.pbGroupImage.TabStop = false;
            this.pbGroupImage.Click += new System.EventHandler(this.ctrlGroupToShare_Click);
            this.pbGroupImage.MouseEnter += new System.EventHandler(this.ctrlGroupToShare_MouseEnter);
            this.pbGroupImage.MouseLeave += new System.EventHandler(this.ctrlGroupToShare_MouseLeave);
            // 
            // ctrlGroupToShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.lblGroupName);
            this.Controls.Add(this.pbGroupImage);
            this.Name = "ctrlGroupToShare";
            this.Size = new System.Drawing.Size(207, 44);
            this.Click += new System.EventHandler(this.ctrlGroupToShare_Click);
            this.MouseEnter += new System.EventHandler(this.ctrlGroupToShare_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ctrlGroupToShare_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pbGroupImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.PictureBox pbGroupImage;
    }
}
