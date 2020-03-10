using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicLoversGuide
{
    public partial class LyricsForm : Form
    {
        public LyricsForm()
        {
            InitializeComponent();
        }

        public LyricsForm(string lyrics, string songsName)
        {
            InitializeComponent();
            this.Text = "LYRICS";
            TextBoxLyrics.ReadOnly = true;
            TextBoxLyrics.Text = lyrics;
            LabelSongName.Size = new Size(350, 50);
            LabelSongName.MaximumSize = new Size(350, 50);
            LabelSongName.Text = songsName;
            Size InnerTextSize = TextRenderer.MeasureText(songsName, LabelSongName.Font);
            if (InnerTextSize.Width - LabelSongName.Width <= 20 || InnerTextSize.Width > LabelSongName.Width)
            {
                do
                {
                    InnerTextSize = TextRenderer.MeasureText(songsName, LabelSongName.Font);
                    LabelSongName.Font = new Font(LabelSongName.Font.Name, Convert.ToSingle(LabelSongName.Font.Size - 1), LabelSongName.Font.Style);
                    TextBoxLyrics.Text = lyrics;
                } while (Math.Abs(InnerTextSize.Width - LabelSongName.Width) <= 20 || InnerTextSize.Width > LabelSongName.Width);
            }
            LabelSongName.TextAlign = ContentAlignment.MiddleCenter;
            TextBoxLyrics.Select(0, 0);
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
