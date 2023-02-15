namespace EmojiCord
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.ThotLabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.DownloadBtn = new System.Windows.Forms.Button();
            this.PNGSelect = new System.Windows.Forms.RadioButton();
            this.GIFSelect = new System.Windows.Forms.RadioButton();
            this.WEBPSelect = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // ThotLabel
            // 
            this.ThotLabel.AutoSize = true;
            this.ThotLabel.Font = new System.Drawing.Font("Zombie Holocaust", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThotLabel.ForeColor = System.Drawing.Color.White;
            this.ThotLabel.Location = new System.Drawing.Point(151, 19);
            this.ThotLabel.Name = "ThotLabel";
            this.ThotLabel.Size = new System.Drawing.Size(108, 53);
            this.ThotLabel.TabIndex = 0;
            this.ThotLabel.Text = "THOTCF";
            this.ThotLabel.Click += new System.EventHandler(this.ThotLabel_Click);
            // 
            // IDBox
            // 
            this.IDBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.IDBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IDBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.ForeColor = System.Drawing.Color.White;
            this.IDBox.Location = new System.Drawing.Point(63, 97);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(284, 33);
            this.IDBox.TabIndex = 1;
            // 
            // DownloadBtn
            // 
            this.DownloadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DownloadBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DownloadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadBtn.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DownloadBtn.ForeColor = System.Drawing.Color.White;
            this.DownloadBtn.Location = new System.Drawing.Point(63, 136);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.Size = new System.Drawing.Size(284, 48);
            this.DownloadBtn.TabIndex = 2;
            this.DownloadBtn.Text = "Download Emoji";
            this.DownloadBtn.UseVisualStyleBackColor = false;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // PNGSelect
            // 
            this.PNGSelect.AutoSize = true;
            this.PNGSelect.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PNGSelect.ForeColor = System.Drawing.Color.White;
            this.PNGSelect.Location = new System.Drawing.Point(109, 201);
            this.PNGSelect.Name = "PNGSelect";
            this.PNGSelect.Size = new System.Drawing.Size(60, 25);
            this.PNGSelect.TabIndex = 3;
            this.PNGSelect.TabStop = true;
            this.PNGSelect.Text = "PNG";
            this.PNGSelect.UseVisualStyleBackColor = true;
            // 
            // GIFSelect
            // 
            this.GIFSelect.AutoSize = true;
            this.GIFSelect.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIFSelect.ForeColor = System.Drawing.Color.White;
            this.GIFSelect.Location = new System.Drawing.Point(175, 201);
            this.GIFSelect.Name = "GIFSelect";
            this.GIFSelect.Size = new System.Drawing.Size(51, 25);
            this.GIFSelect.TabIndex = 4;
            this.GIFSelect.TabStop = true;
            this.GIFSelect.Text = "GIF";
            this.GIFSelect.UseVisualStyleBackColor = true;
            // 
            // WEBPSelect
            // 
            this.WEBPSelect.AutoSize = true;
            this.WEBPSelect.Font = new System.Drawing.Font("Nirmala UI Semilight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WEBPSelect.ForeColor = System.Drawing.Color.White;
            this.WEBPSelect.Location = new System.Drawing.Point(232, 201);
            this.WEBPSelect.Name = "WEBPSelect";
            this.WEBPSelect.Size = new System.Drawing.Size(69, 25);
            this.WEBPSelect.TabIndex = 5;
            this.WEBPSelect.TabStop = true;
            this.WEBPSelect.Text = "WEBP";
            this.WEBPSelect.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(411, 251);
            this.Controls.Add(this.WEBPSelect);
            this.Controls.Add(this.GIFSelect);
            this.Controls.Add(this.PNGSelect);
            this.Controls.Add(this.DownloadBtn);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.ThotLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "EmojiCord - Coded by: ⛧Samuel#9999";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ThotLabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.Button DownloadBtn;
        private System.Windows.Forms.RadioButton PNGSelect;
        private System.Windows.Forms.RadioButton GIFSelect;
        private System.Windows.Forms.RadioButton WEBPSelect;
    }
}

