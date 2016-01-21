using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieList
{
    public partial class Form1 : Form
    {

        List<Movie> newMovieList = new List<Movie>();
        OptionDetails startUpOptions;

        public Form1()
        {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Options newOptions = new Options();

            newOptions.FormClosing += NewOptions_FormClosing;

            newOptions.Show();

            this.WindowState = FormWindowState.Minimized;

        }

        private void NewOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Look for start up options txt
            string startUpFile = "StartUpOptions.txt";

            if(File.Exists(startUpFile))
            {
                string json = System.IO.File.ReadAllText(startUpFile);

                startUpOptions = JsonConvert.DeserializeObject<OptionDetails>(json);

                if (startUpOptions.startUp == "Movies Wanted")
                {
                    loadMoviesWanted();
                }
                else
                {
                    loadMoviesObtained();
                }

            }
            else
            {

            }

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            movieDataGridView1.Rows.Add();

            int rowCount = movieDataGridView1.Rows.Count;

            DataGridViewCell cell = movieDataGridView1.Rows[rowCount - 1].Cells["MovieTitle"];

            movieDataGridView1.CurrentCell = cell;

            movieDataGridView1.BeginEdit(true);

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in movieDataGridView1.Rows)
            {
                string movieTitle = row.Cells["MovieTitle"].Value.ToString();


                if (movieTitle == "")
                {
                    return;
                }
                else
                {
                    var movie = new Movie();
                    movie.title = movieTitle;

                    newMovieList.Add(movie);
                }
            }

            string json = JsonConvert.SerializeObject(newMovieList);
            if (startUpOptions.startUp == "Movies Wanted")
            {
                System.IO.File.WriteAllText("MoviesWanted.txt", json);

            }
            else
            {
                System.IO.File.WriteAllText("MoviesObtained.txt", json);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in movieDataGridView1.SelectedRows)
            {
                movieDataGridView1.Rows.RemoveAt(item.Index);
            }
        }

        private void loadMoviesObtained()
        {
            this.Text = startUpOptions.startUp.ToString();
            toolStrpView.Text = "View: " + startUpOptions.startUp.ToString();

            string moviesObtainedJson = System.IO.File.ReadAllText("MoviesObtained.txt");

            newMovieList.Clear();

            newMovieList = JsonConvert.DeserializeObject<List<Movie>>(moviesObtainedJson);

            foreach (Movie movie in newMovieList)
            {
                movieDataGridView1.Rows.Add(movie.title, movie.rating, movie.format);
            }
        }

        private void loadMoviesWanted()
        {
            this.Text = "Movies Wanted";
            toolStrpView.Text = "View: Movies Wanted";

            string moviesWantedJson = System.IO.File.ReadAllText("MoviesWanted.txt");

            newMovieList.Clear();

            newMovieList = JsonConvert.DeserializeObject<List<Movie>>(moviesWantedJson);

            foreach (Movie movie in newMovieList)
            {
                movieDataGridView1.Rows.Add(movie.title, movie.rating, movie.format);
            }
        }

        private void moviesWantedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (movieDataGridView1.Rows.Count > 0)
            {
                movieDataGridView1.Rows.Clear();
            }

            loadMoviesWanted();

        }

        private void moviesHadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (movieDataGridView1.Rows.Count > 0)
            {
                movieDataGridView1.Rows.Clear();
            }

            loadMoviesObtained();

        }
    }
}
