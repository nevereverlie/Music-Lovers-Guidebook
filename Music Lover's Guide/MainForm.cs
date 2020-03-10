using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace MusicLoversGuide
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Довідник меломана";
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ArtistName", "Виконавець");
            dataGridView1.Columns.Add("AlbumName", "Альбом");
            dataGridView1.Columns.Add("SongName", "Назва пісні");
            dataGridView1.Columns.Add("Year", "Рік випуску");
            dataGridView1.Columns.Add("Genre", "Жанр");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ButtonSavePlaylist.Enabled = false;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            ButtonDelete.Enabled = false;
            ButtonFormat.Enabled = false;
            ButtonLyrics.Enabled = false;
        }

        public static List<Song> Songs = new List<Song> { };

        public static bool IsNum(string Str)
        {
            int Num;
            bool isNum = int.TryParse(Str, out Num);
            return isNum;
        }

        public static bool HasNumber(string Str)
        {
            bool result = false;
            foreach (char c in Str)
            {
                if (Char.IsNumber(c))
                    result = true;
            }
            if (!Char.IsLetter(Str[0]))
            {
                result = true;
            }
            return result;
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void ButtonAddPlaylist_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            openFileDialog.Title = "Відкрити плейліст";
            openFileDialog.Filter = "XML File (.xml)|*.xml|TXT File (.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Clear();
                XmlReaderSettings ws = new XmlReaderSettings();
                //ws.IgnoreWhitespace = false;
                XmlSerializer serializer = new XmlSerializer(typeof(List<Song>));
                string path = "";
                try
                {
                    using (XmlReader xmlWriter = XmlReader.Create(openFileDialog.FileName, ws))
                    {
                        path = openFileDialog.FileName;
                        if (Path.GetExtension(openFileDialog.FileName) == ".xml")
                        {
                            Songs = serializer.Deserialize(xmlWriter) as List<Song>;
                            foreach (Song song in Songs)
                            {
                                dataGridView1.Rows.Add(song.Artist, song.Album, song.Name, song.Year, song.Genre);
                            }
                            ButtonSavePlaylist.Enabled = true;
                            ButtonLyrics.Enabled = true;
                            TextBoxSearch.Clear();
                        }
                        else MessageBox.Show("Wrong format, .xml required", "Wrong format error", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error reading file", MessageBoxButtons.OK);
                }
            }
        }//Deserialization

        SaveFileDialog saveFileDialog = new SaveFileDialog();
        private void ButtonSavePlaylist_Click(object sender, EventArgs e)
        {
            if (Songs.Count != 0)
            {
                saveFileDialog.FileName = "";
                saveFileDialog.Title = "Зберегти наявний плейліст";
                saveFileDialog.Filter = "XML File (.xml)|*.xml|TXT File (.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (Path.GetExtension(saveFileDialog.FileName) == ".xml")
                    {
                        XmlWriterSettings settings = new XmlWriterSettings();
                        settings.NewLineHandling = NewLineHandling.Entitize;
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Song>));
                        using (XmlWriter wr = XmlWriter.Create(saveFileDialog.FileName, settings))
                        {
                            serializer.Serialize(wr, Songs);
                        }
                        ButtonSavePlaylist.Enabled = true;
                    }
                    else if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                    {
                        using (StreamWriter file = new StreamWriter(Path.GetFullPath(saveFileDialog.FileName)))
                        {
                            file.WriteLine("Исполнитель" + " :: " + "Альбом" + " :: " + "Название песни" + " :: " + "Год выпуска" + " :: " + "Жанр");
                            file.WriteLine();
                            foreach (Song song in Songs)
                            {
                                file.WriteLine(song.Artist + " :: " + song.Album + " :: " + song.Name + " :: " + song.Year + " :: " + song.Genre + "\n");
                            }
                        }
                    }
                }
                else return;
            }
            else
            {
                MessageBox.Show("Плейліст пустий, Вам нічого зберігати", "Empty", MessageBoxButtons.OK);
            }
        }//Serialisation

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            ButtonDelete.Enabled = true;
            ButtonFormat.Enabled = true;
            ButtonLyrics.Enabled = true;
        }

        private void ButtonAddSong_Click(object sender, EventArgs e)
        {
            using (AddSongForm f2 = new AddSongForm())
            {
                f2.ShowDialog(this);
                if (AddSongForm.isAddedSong)
                {
                    dataGridView1.Rows.Add(Songs[Songs.Count - 1].Artist,
                    Songs[Songs.Count - 1].Album, Songs[Songs.Count - 1].Name,
                    Songs[Songs.Count - 1].Year, Songs[Songs.Count - 1].Genre);
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.CurrentCell.RowIndex;
            int NumberOfRow = CurrentRow + 1;
            string SongName = GetSongName();

            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити пісню №" + NumberOfRow + ": " + SongName + "?",
                "Видалення пісні", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(CurrentRow);
                Songs.RemoveAt(CurrentRow);
            }
            dataGridView1.ClearSelection();
            ButtonDelete.Enabled = false;
            ButtonFormat.Enabled = false;
            ButtonLyrics.Enabled = false;
        }

        public string GetSongName()
        {
            return Convert.ToString(dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value) + " - " + Convert.ToString(dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value);
        }

        List<Song> foundSongs = new List<Song> { };
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            string SearchKey = TextBoxSearch.Text;
            bool isFound = false;
            int index = 0;
            dataGridView1.Rows.Clear();

            for (int i = 0; i < Songs.Count; i++)
            {
                if (Songs[i].Artist.Contains(SearchKey) == true || Songs[i].Album.Contains(SearchKey) == true || 
                    Songs[i].Name.Contains(SearchKey) == true || Songs[i].Genre.Contains(SearchKey) == true ||
                    Songs[i].Year.Contains(SearchKey) == true)
                {
                    isFound = true;
                    ButtonSavePlaylist.Enabled = false;
                    foundSongs.Add(Songs[i]);
                    dataGridView1.Rows.Insert(index, Songs[i].Artist, Songs[i].Album, Songs[i].Name, Songs[i].Year, Songs[i].Genre);
                    index++;
                    ButtonDelete.Enabled = false;
                    ButtonFormat.Enabled = false;
                }
            }
            if (!isFound)
            {
                MessageBox.Show("З вашого запиту не знайдено збіжностей.\nСпробуйте інші варіанти",
                    "Не знайдено", MessageBoxButtons.OK);
                ButtonSavePlaylist.Enabled = false;
                ButtonLyrics.Enabled = false;
            }
            else if (SearchKey == "")
            {
                ButtonSavePlaylist.Enabled = true;
                dataGridView1.CurrentRow.Selected = false;
            }
        }

        private void ButtonClearSearchFilters_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            TextBoxSearch.Clear();
            ButtonSearch.Enabled = true;
            ButtonSavePlaylist.Enabled = true;
            foundSongs.Clear();

            try
            {
                for (int i = 0; i < Songs.Count; i++)
                {
                    dataGridView1.Rows.Insert(i, Songs[i].Artist, Songs[i].Album, Songs[i].Name, Songs[i].Year, Songs[i].Genre);
                }
                dataGridView1.ClearSelection();
                ButtonDelete.Enabled = false;
                ButtonFormat.Enabled = false;
                ButtonLyrics.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string SelectedArtist { get; set; }
        public string SelectedAlbum { get; set; }
        public string SelectedSongName { get; set; }
        public string SelectedSongYear { get; set; }
        public string SelectedSongGenre { get; set; }
        public string SelectedSongLyrics { get; set; }

        private void ButtonFormat_Click(object sender, EventArgs e)
        {
            int CurrentRow = dataGridView1.CurrentCell.RowIndex;
            SelectedArtist = Convert.ToString(dataGridView1.Rows[CurrentRow].Cells[0].Value);
            SelectedAlbum = Convert.ToString(dataGridView1.Rows[CurrentRow].Cells[1].Value);
            SelectedSongName = Convert.ToString(dataGridView1.Rows[CurrentRow].Cells[2].Value);
            SelectedSongYear = Convert.ToString(dataGridView1.Rows[CurrentRow].Cells[3].Value);
            SelectedSongGenre = Convert.ToString(dataGridView1.Rows[CurrentRow].Cells[4].Value);
            SelectedSongLyrics = Songs[CurrentRow].Lyrics;

            using (FormatForm formatForm = new FormatForm(SelectedArtist, SelectedAlbum, SelectedSongName, SelectedSongYear, SelectedSongGenre, SelectedSongLyrics))
            {
                if (formatForm.ShowDialog(this) == DialogResult.OK)
                {
                    dataGridView1.Rows[CurrentRow].Cells[0].Value = formatForm.FormattedArtist;
                    dataGridView1.Rows[CurrentRow].Cells[1].Value = formatForm.FormattedAlbum;
                    dataGridView1.Rows[CurrentRow].Cells[2].Value = formatForm.FormattedSongName;
                    dataGridView1.Rows[CurrentRow].Cells[3].Value = formatForm.FormattedSongYear;
                    dataGridView1.Rows[CurrentRow].Cells[4].Value = formatForm.FormattedSongGenre;
                    Songs[CurrentRow].Artist = formatForm.FormattedArtist;
                    Songs[CurrentRow].Album = formatForm.FormattedAlbum;
                    Songs[CurrentRow].Name = formatForm.FormattedSongName;
                    Songs[CurrentRow].Year = formatForm.FormattedSongYear;
                    Songs[CurrentRow].Genre = formatForm.FormattedSongGenre;
                    Songs[CurrentRow].Lyrics = formatForm.FormattedSongLyrics;
                }
            }
            dataGridView1.CurrentRow.Selected = true;
        }

        private void ButtonLyrics_Click(object sender, EventArgs e)
        {
            string Lyrics = Songs[dataGridView1.CurrentCell.RowIndex].Lyrics;
            string SongsName = GetSongName();
            using (LyricsForm lyricsForm = new LyricsForm(Lyrics, SongsName))
            {
                lyricsForm.ShowDialog(this);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви впевнені, що зберегли зміни та хочете вийти з програми?", "Warning", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Dispose();
            else
                e.Cancel = true;
        }
    }
}
