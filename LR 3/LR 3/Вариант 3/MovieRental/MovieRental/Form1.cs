using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRental
{
    public partial class MainForm : Form
    {
        List<CharacteristicsFilms> allMovies = new List<CharacteristicsFilms>();
        int totalShowsXorror = 0;
        int totalShowsFantasy = 0;


        public MainForm()
        {
            InitializeComponent();
            ListBoxGenre.Items.Add("Хоррор");
            ListBoxGenre.Items.Add("Фэнтези");

            NumericUpDownValue.Minimum = 1;

            IFilm movieLoader = new StorageFilm();
            allMovies = movieLoader.Film();

        }

        private void ListBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxMovie.Items.Clear();


            string selectedGenre = ListBoxGenre.SelectedItem.ToString();

            foreach (CharacteristicsFilms movie in allMovies)
            {
                if (movie.Genre == selectedGenre)
                {
                    comboBoxMovie.Items.Add(movie.Name);
                }
            }

            if (comboBoxMovie.Items.Count != 0)
            {
                comboBoxMovie.SelectedIndex = 0;
            }
        }

        

        private void ButtonReport_Click(object sender, EventArgs e)
        {

            if (comboBoxMovie.SelectedItem != null && ListBoxGenre.SelectedItem != null)
            {
                string selectedMovieName = comboBoxMovie.SelectedItem.ToString();
                string selectedGenre = ListBoxGenre.SelectedItem.ToString();

                CharacteristicsFilms selectedMovie = null;

                foreach (CharacteristicsFilms movie in allMovies)
                {
                    if (movie.Name == selectedMovieName && movie.Genre == selectedGenre)
                    {
                        selectedMovie = movie;
                        break;
                    }
                }
                if (selectedMovie != null)
                {
                    int shows = (int)NumericUpDownValue.Value;


                    RichTextBoxInfo.Text = selectedMovie.GetFullInfo();
                    RichTextBoxInfo.Text += $"\nЗаказано показов: {shows}";

                }
            }
        }
     

        private void comboBoxMovie_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string movieName = comboBoxMovie.SelectedItem.ToString();

            foreach (CharacteristicsFilms movie in allMovies)
            {
                if (movie.Name == movieName)
                {
                    pictureBoxFilm.Load(movie.Photo);
                }
            }

        }
    }
    
}
