namespace MusicLoversGuide
{
    partial class LyricsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LyricsForm));
            this.LyricsLabel = new System.Windows.Forms.Label();
            this.TextBoxLyrics = new System.Windows.Forms.TextBox();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.LabelSongName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LyricsLabel
            // 
            this.LyricsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LyricsLabel.AutoSize = true;
            this.LyricsLabel.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LyricsLabel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.LyricsLabel.Location = new System.Drawing.Point(102, 9);
            this.LyricsLabel.Name = "LyricsLabel";
            this.LyricsLabel.Size = new System.Drawing.Size(180, 36);
            this.LyricsLabel.TabIndex = 1;
            this.LyricsLabel.Text = "Слова пісні";
            // 
            // TextBoxLyrics
            // 
            this.TextBoxLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxLyrics.Location = new System.Drawing.Point(28, 127);
            this.TextBoxLyrics.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxLyrics.Multiline = true;
            this.TextBoxLyrics.Name = "TextBoxLyrics";
            this.TextBoxLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxLyrics.Size = new System.Drawing.Size(327, 423);
            this.TextBoxLyrics.TabIndex = 2;
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ButtonOK.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonOK.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ButtonOK.Location = new System.Drawing.Point(126, 555);
            this.ButtonOK.MaximumSize = new System.Drawing.Size(133, 56);
            this.ButtonOK.MinimumSize = new System.Drawing.Size(133, 56);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(133, 56);
            this.ButtonOK.TabIndex = 6;
            this.ButtonOK.Text = "ОК";
            this.ButtonOK.UseVisualStyleBackColor = false;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // LabelSongName
            // 
            this.LabelSongName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LabelSongName.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSongName.ForeColor = System.Drawing.Color.Black;
            this.LabelSongName.Location = new System.Drawing.Point(12, 58);
            this.LabelSongName.Name = "LabelSongName";
            this.LabelSongName.Size = new System.Drawing.Size(294, 36);
            this.LabelSongName.TabIndex = 7;
            this.LabelSongName.Text = "Тут буде назва пісні";
            // 
            // LyricsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(381, 635);
            this.Controls.Add(this.LabelSongName);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.TextBoxLyrics);
            this.Controls.Add(this.LyricsLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(518, 1080);
            this.MinimumSize = new System.Drawing.Size(397, 674);
            this.Name = "LyricsForm";
            this.Text = "LyricsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LyricsLabel;
        private System.Windows.Forms.TextBox TextBoxLyrics;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label LabelSongName;
    }
}