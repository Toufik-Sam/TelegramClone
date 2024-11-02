namespace Telegram_Clone.Channels.Controls
{
    partial class ctrlSubscriber
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
            this.lblSubscriberName = new System.Windows.Forms.Label();
            this.btnDeleteSubscriber = new System.Windows.Forms.PictureBox();
            this.pbSubscriberImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSubscriber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubscriberImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubscriberName
            // 
            this.lblSubscriberName.AutoSize = true;
            this.lblSubscriberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubscriberName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSubscriberName.Location = new System.Drawing.Point(47, 12);
            this.lblSubscriberName.Name = "lblSubscriberName";
            this.lblSubscriberName.Size = new System.Drawing.Size(123, 18);
            this.lblSubscriberName.TabIndex = 4;
            this.lblSubscriberName.Text = "Subscriber Name";
            // 
            // btnDeleteSubscriber
            // 
            this.btnDeleteSubscriber.Image = global::Telegram_Clone.Properties.Resources.icons8_delete_20;
            this.btnDeleteSubscriber.Location = new System.Drawing.Point(172, 9);
            this.btnDeleteSubscriber.Name = "btnDeleteSubscriber";
            this.btnDeleteSubscriber.Size = new System.Drawing.Size(22, 23);
            this.btnDeleteSubscriber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteSubscriber.TabIndex = 5;
            this.btnDeleteSubscriber.TabStop = false;
            this.btnDeleteSubscriber.Click += new System.EventHandler(this.btnDeleteSubscriber_Click);
            // 
            // pbSubscriberImage
            // 
            this.pbSubscriberImage.Image = global::Telegram_Clone.Properties.Resources.man_512;
            this.pbSubscriberImage.Location = new System.Drawing.Point(13, 9);
            this.pbSubscriberImage.Name = "pbSubscriberImage";
            this.pbSubscriberImage.Size = new System.Drawing.Size(29, 26);
            this.pbSubscriberImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSubscriberImage.TabIndex = 3;
            this.pbSubscriberImage.TabStop = false;
            // 
            // ctrlSubscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.Controls.Add(this.btnDeleteSubscriber);
            this.Controls.Add(this.lblSubscriberName);
            this.Controls.Add(this.pbSubscriberImage);
            this.Name = "ctrlSubscriber";
            this.Size = new System.Drawing.Size(207, 44);
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteSubscriber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSubscriberImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnDeleteSubscriber;
        private System.Windows.Forms.Label lblSubscriberName;
        private System.Windows.Forms.PictureBox pbSubscriberImage;
    }
}
