namespace Telegram_Clone.Groups
{
    partial class frmDropDowMenu
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
            this.btnShowGroupInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(9, 117);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 37);
            this.btnDelete.TabIndex = 5;
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
            this.btnLeave.Location = new System.Drawing.Point(9, 63);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(137, 37);
            this.btnLeave.TabIndex = 4;
            this.btnLeave.Text = "Leave";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnShowGroupInfo
            // 
            this.btnShowGroupInfo.FlatAppearance.BorderSize = 0;
            this.btnShowGroupInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnShowGroupInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowGroupInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowGroupInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowGroupInfo.Location = new System.Drawing.Point(10, 10);
            this.btnShowGroupInfo.Name = "btnShowGroupInfo";
            this.btnShowGroupInfo.Size = new System.Drawing.Size(137, 37);
            this.btnShowGroupInfo.TabIndex = 3;
            this.btnShowGroupInfo.Text = "Group Info";
            this.btnShowGroupInfo.UseVisualStyleBackColor = true;
            this.btnShowGroupInfo.Click += new System.EventHandler(this.btnShowGroupInfo_Click);
            // 
            // frmDropDowMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(154, 168);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLeave);
            this.Controls.Add(this.btnShowGroupInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDropDowMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDropDowMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnShowGroupInfo;
    }
}