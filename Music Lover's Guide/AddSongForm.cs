using System;
using System.Windows.Forms;

namespace MusicLoversGuide
{
    public partial class AddSongForm : Form
    {
        public AddSongForm()
        {
            InitializeComponent();
            this.Text = "Додання";
        }

        public static bool isAddedSong = false;

        private void ButtonSaveSong_Click(object sender, EventArgs e)
        {
            string NewArtist, NewAlbum, NewSongName, NewSongYear, NewSongGenre, NewLyrics;
            NewArtist = TextBoxArtist.Text;
            NewAlbum = TextBoxAlbum.Text;
            NewSongName = TextBoxSong.Text;
            NewSongYear = TextBoxYear.Text;
            NewSongGenre = TextBoxGenre.Text;
            NewLyrics = TextBoxLyrics.Text;

            if (NewArtist == "" || NewAlbum == "" || NewSongName == "" || NewSongYear == "" || NewSongGenre == "" || NewLyrics == "")
            {
                DialogResult result = MessageBox.Show("Заповніть всі поля", "Error: empty fields", MessageBoxButtons.OK);
            }
            else if (!MainForm.IsNum(NewSongYear) || NewSongYear.Length != 4 || Convert.ToInt32(NewSongYear) < 1000 || Convert.ToInt32(NewSongYear) > DateTime.Today.Year)
            {
                DialogResult result = MessageBox.Show("Помилка при зчитуванні року випуску: перевірте, будь ласка, дані", "Error: incorrect year", MessageBoxButtons.OK);
            }
            else if (MainForm.HasNumber(NewSongGenre))
            {
                DialogResult result = MessageBox.Show("Помилка при зчитуванні жанру: ймовірно, такого жанру не існує", "Error: incorrect genre", MessageBoxButtons.OK);
            }
            else
            {
                MainForm.Songs.Add(new Song(NewArtist, NewAlbum, NewSongName, NewSongYear, NewSongGenre, NewLyrics));
                isAddedSong = true;
                this.Close();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            isAddedSong = false;
            this.Close();
        }
    }
}
