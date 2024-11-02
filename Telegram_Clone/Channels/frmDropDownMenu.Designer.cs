namespace Telegram_Clone.Channels
{
    partial class frmDropDownMenu
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnShowChannelInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(8, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.FlatAppearance.BorderSize = 0;
            this.btnLeave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnLeave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLeave.Location = new System.Drawing.Point(8, 65);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(137, 37);
            this.btnLeave.TabIndex = 7;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnShowChannelInfo
            // 
            this.btnShowChannelInfo.FlatAppearance.BorderSize = 0;
            this.btnShowChannelInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnShowChannelInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowChannelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowChannelInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowChannelInfo.Location = new System.Drawing.Point(9, 12);
            this.btnShowChannelInfo.Name = "btnShowChannelInfo";
            this.btnShowChannelInfo.Size = new System.Drawing.Size(137, 37);
            this.btnShowChannelInfo.TabIndex = 6;
            this.btnShowChannelInfo.Text = "Channel Info";
            this.btnShowChannelInfo.UseVisualStyleBackColor = true;
            this.btnShowChannelInfo.Click += new System.EventHandler(this.btnShowChannelInfo_Click);
            // 
            // frmDropDownMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(154, 168);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnShowChannelInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDropDownMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDropDownMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnShowChannelInfo;
    }
}