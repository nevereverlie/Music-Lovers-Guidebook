namespace MusicLoversGuide
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SongName = new System.Windows.Forms.Label();
            this.ButtonAddPlaylist = new System.Windows.Forms.Button();
            this.ButtonAddSong = new System.Windows.Forms.Button();
            this.ButtonSavePlaylist = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonClearSearchFilters = new System.Windows.Forms.Button();
            this.ButtonFormat = new System.Windows.Forms.Button();
            this.ButtonLyrics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Size = new System.Drawing.Size(806, 324);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // SongName
            // 
            this.SongName.AutoSize = true;
            this.SongName.Location = new System.Drawing.Point(198, 308);
            this.SongName.Name = "SongName";
            this.SongName.Size = new System.Drawing.Size(0, 13);
            this.SongName.TabIndex = 1;
            // 
            // ButtonAddPlaylist
            // 
            this.ButtonAddPlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonAddPlaylist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddPlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddPlaylist.ForeColor = System.Drawing.Color.Green;
            this.ButtonAddPlaylist.Location = new System.Drawing.Point(12, 516);
            this.ButtonAddPlaylist.MaximumSize = new System.Drawing.Size(144, 56);
            this.ButtonAddPlaylist.MinimumSize = new System.Drawing.Size(144, 56);
            this.ButtonAddPlaylist.Name = "ButtonAddPlaylist";
            this.ButtonAddPlaylist.Size = new System.Drawing.Size(144, 56);
            this.ButtonAddPlaylist.TabIndex = 2;
            this.ButtonAddPlaylist.Text = "Завантажити плейліст";
            this.ButtonAddPlaylist.UseVisualStyleBackColor = false;
            this.ButtonAddPlaylist.Click += new System.EventHandler(this.ButtonAddPlaylist_Click);
            // 
            // ButtonAddSong
            // 
            this.ButtonAddSong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddSong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonAddSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAddSong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ButtonAddSong.Location = new System.Drawing.Point(685, 516);
            this.ButtonAddSong.MaximumSize = new System.Drawing.Size(133, 56);
            this.ButtonAddSong.MinimumSize = new System.Drawing.Size(133, 56);
            this.ButtonAddSong.Name = "ButtonAddSong";
            this.ButtonAddSong.Size = new System.Drawing.Size(133, 56);
            this.ButtonAddSong.TabIndex = 3;
            this.ButtonAddSong.Text = "Додати пісню";
            this.ButtonAddSong.UseVisualStyleBackColor = false;
            this.ButtonAddSong.Click += new System.EventHandler(this.ButtonAddSong_Click);
            // 
            // ButtonSavePlaylist
            // 
            this.ButtonSavePlaylist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonSavePlaylist.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonSavePlaylist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSavePlaylist.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ButtonSavePlaylist.Location = new System.Drawing.Point(162, 516);
            this.ButtonSavePlaylist.MaximumSize = new System.Drawing.Size(144, 56);
            this.ButtonSavePlaylist.MinimumSize = new System.Drawing.Size(144, 56);
            this.ButtonSavePlaylist.Name = "ButtonSavePlaylist";
            this.ButtonSavePlaylist.Size = new System.Drawing.Size(144, 56);
            this.ButtonSavePlaylist.TabIndex = 4;
            this.ButtonSavePlaylist.Text = "Зберегти плейліст";
            this.ButtonSavePlaylist.UseVisualStyleBackColor = false;
            this.ButtonSavePlaylist.Click += new System.EventHandler(this.ButtonSavePlaylist_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.Red;
            this.ButtonDelete.Location = new System.Drawing.Point(546, 516);
            this.ButtonDelete.MaximumSize = new System.Drawing.Size(133, 56);
            this.ButtonDelete.MinimumSize = new System.Drawing.Size(133, 56);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(133, 56);
            this.ButtonDelete.TabIndex = 5;
            this.ButtonDelete.Text = "Видалити";
            this.ButtonDelete.UseVisualStyleBackColor = false;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // SearchLabel
            // 
            this.SearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchLabel.Location = new System.Drawing.Point(20, 29);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(286, 24);
            this.SearchLabel.TabIndex = 6;
            this.SearchLabel.Text = "Пошук за ключовим словом:";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSearch.Location = new System.Drawing.Point(323, 26);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(495, 29);
            this.TextBoxSearch.TabIndex = 7;
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ButtonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonSearch.Location = new System.Drawing.Point(323, 61);
            this.ButtonSearch.MaximumSize = new System.Drawing.Size(1920, 37);
            this.ButtonSearch.MinimumSize = new System.Drawing.Size(0, 37);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(495, 37);
            this.ButtonSearch.TabIndex = 8;
            this.ButtonSearch.Text = "Шукати!";
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonClearSearchFilters
            // 
            this.ButtonClearSearchFilters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClearSearchFilters.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonClearSearchFilters.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClearSearchFilters.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonClearSearchFilters.Location = new System.Drawing.Point(323, 104);
            this.ButtonClearSearchFilters.MaximumSize = new System.Drawing.Size(1920, 37);
            this.ButtonClearSearchFilters.MinimumSize = new System.Drawing.Size(0, 37);
            this.ButtonClearSearchFilters.Name = "ButtonClearSearchFilters";
            this.ButtonClearSearchFilters.Size = new System.Drawing.Size(495, 37);
            this.ButtonClearSearchFilters.TabIndex = 9;
            this.ButtonClearSearchFilters.Text = "Очистити фільтри пошуку";
            this.ButtonClearSearchFilters.UseVisualStyleBackColor = false;
            this.ButtonClearSearchFilters.Click += new System.EventHandler(this.ButtonClearSearchFilters_Click);
            // 
            // ButtonFormat
            // 
            this.ButtonFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonFormat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonFormat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ButtonFormat.Location = new System.Drawing.Point(407, 516);
            this.ButtonFormat.MaximumSize = new System.Drawing.Size(133, 56);
            this.ButtonFormat.MinimumSize = new System.Drawing.Size(133, 56);
            this.ButtonFormat.Name = "ButtonFormat";
            this.ButtonFormat.Size = new System.Drawing.Size(133, 56);
            this.ButtonFormat.TabIndex = 10;
            this.ButtonFormat.Text = "Редагувати";
            this.ButtonFormat.UseVisualStyleBackColor = false;
            this.ButtonFormat.Click += new System.EventHandler(this.ButtonFormat_Click);
            // 
            // ButtonLyrics
            // 
            this.ButtonLyrics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLyrics.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ButtonLyrics.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonLyrics.Font = new System.Drawing.Font("Georgia", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLyrics.ForeColor = System.Drawing.Color.Red;
            this.ButtonLyrics.Image = global::MusicLoversGuide.Properties.Resources.lyrics1;
            this.ButtonLyrics.Location = new System.Drawing.Point(12, 69);
            this.ButtonLyrics.MaximumSize = new System.Drawing.Size(294, 72);
            this.ButtonLyrics.MinimumSize = new System.Drawing.Size(294, 72);
            this.ButtonLyrics.Name = "ButtonLyrics";
            this.ButtonLyrics.Size = new System.Drawing.Size(294, 72);
            this.ButtonLyrics.TabIndex = 11;
            this.ButtonLyrics.UseVisualStyleBackColor = false;
            this.ButtonLyrics.Click += new System.EventHandler(this.ButtonLyrics_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(836, 592);
            this.Controls.Add(this.ButtonLyrics);
            this.Controls.Add(this.ButtonFormat);
            this.Controls.Add(this.ButtonClearSearchFilters);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.SearchLabel);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonSavePlaylist);
            this.Controls.Add(this.ButtonAddSong);
            this.Controls.Add(this.ButtonAddPlaylist);
            this.Controls.Add(this.SongName);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(758, 630);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label SongName;
        private System.Windows.Forms.Button ButtonAddPlaylist;
        private System.Windows.Forms.Button ButtonAddSong;
        private System.Windows.Forms.Button ButtonSavePlaylist;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonClearSearchFilters;
        private System.Windows.Forms.Button ButtonFormat;
        private System.Windows.Forms.Button ButtonLyrics;
    }
}

