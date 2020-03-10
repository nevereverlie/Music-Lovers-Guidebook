using System;
using System.Windows.Forms;

namespace MusicLoversGuide
{
    public partial class FormatForm : Form
    {
        public FormatForm()
        {
            InitializeComponent();
        }

        public FormatForm(string OldArtist, string OldAlbum, string OldSongName, string OldYear, string OldGenre, string OldLyrics)
        {
            InitializeComponent();
            this.Text = "Редагування пісні";
            TextBoxFormatArtist.Text = OldArtist;
            TextBoxFormatAlbum.Text = OldAlbum;
            TextBoxFormatSongName.Text = OldSongName;
            TextBoxFormatYear.Text = OldYear;
            TextBoxFormatGenre.Text = OldGenre;
            TextBoxFormatLyrics.Text = OldLyrics;
        }

        public string FormattedArtist { get; set; }
        public string FormattedAlbum { get; set; }
        public string FormattedSongName { get; set; }
        public string FormattedSongYear { get; set; }
        public string FormattedSongGenre { get; set; }
        public string FormattedSongLyrics { get; set; }

        private void ButtonSaveFormattedSong_Click(object sender, EventArgs e)
        {
            FormattedArtist = TextBoxFormatArtist.Text;
            FormattedAlbum = TextBoxFormatAlbum.Text;
            FormattedSongName = TextBoxFormatSongName.Text;
            FormattedSongYear = TextBoxFormatYear.Text;
            FormattedSongGenre = TextBoxFormatGenre.Text;
            FormattedSongLyrics = TextBoxFormatLyrics.Text;
            if (FormattedArtist == "" || FormattedAlbum == "" || FormattedSongName == "" ||
                FormattedSongYear == "" || FormattedSongGenre == "" || FormattedSongLyrics == "")
            {
                DialogResult result = MessageBox.Show("Заповніть всі поля", "Error", MessageBoxButtons.OK);
            }
            else if (!MainForm.IsNum(FormattedSongYear) || FormattedSongYear.Length != 4 || Convert.ToInt32(FormattedSongYear) < 1000 || Convert.ToInt32(FormattedSongYear) > DateTime.Today.Year)
            {
                DialogResult result = MessageBox.Show("Помилка при зчитуванні року випуску: перевірте, будь ласка, дані", "Error: incorrect year", MessageBoxButtons.OK);
            }
            else if (MainForm.HasNumber(FormattedSongGenre))
            {
                DialogResult result = MessageBox.Show("Помилка при зчитуванні жанру: ймовірно, такого жанру не існує", "Error: incorrect genre", MessageBoxButtons.OK);
            }

            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
