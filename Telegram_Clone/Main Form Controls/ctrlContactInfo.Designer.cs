namespace Telegram_Clone.Main_Form_Controls
{
    partial class ctrlContactInfo
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
            this.lblContactName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.PictureBox();
            this.pbContactImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContactImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblContactName
            // 
            this.lblContactName.AutoSize = true;
            this.lblContactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblContactName.Location = new System.Drawing.Point(56, 16);
            this.lblContactName.Name = "lblContactName";
            this.lblContactName.Size = new System.Drawing.Size(111, 20);
            this.lblContactName.TabIndex = 1;
            this.lblContactName.Text = "Contact Name";
            this.lblContactName.MouseEnter += new System.EventHandler(this.ctrlContactInfo_MouseEnter);
            this.lblContactName.MouseLeave += new System.EventHandler(this.ctrlContactInfo_MouseLeave);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::Telegram_Clone.Properties.Resources.icons8_delete_20;
            this.btnRemove.Location = new System.Drawing.Point(215, 11);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(29, 31);
            this.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRemove.TabIndex = 2;
            this.btnRemove.TabStop = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseEnter += new System.EventHandler(this.ctrlContactInfo_MouseEnter);
            this.btnRemove.MouseLeave += new System.EventHandler(this.ctrlContactInfo_MouseLeave);
            // 
            // pbContactImage
            // 
            this.pbContactImage.Location = new System.Drawing.Point(13, 11);
            this.pbContactImage.Name = "pbContactImage";
            this.pbContactImage.Size = new System.Drawing.Size(33, 31);
            this.pbContactImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbContactImage.TabIndex = 0;
            this.pbContactImage.TabStop = false;
            this.pbContactImage.MouseEnter += new System.EventHandler(this.ctrlContactInfo_MouseEnter);
            this.pbContactImage.MouseLeave += new System.EventHandler(this.ctrlContactInfo_MouseLeave);
            // 
            // ctrlContactInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(66)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblContactName);
            this.Controls.Add(this.pbContactImage);
            this.Name = "ctrlContactInfo";
            this.Size = new System.Drawing.Size(264, 55);
            this.MouseEnter += new System.EventHandler(this.ctrlContactInfo_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ctrlContactInfo_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContactImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbContactImage;
        private System.Windows.Forms.Label lblContactName;
        private System.Windows.Forms.PictureBox btnRemove;
    }
}
