using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class SelectionForm : Form
    {
        //PUBLIC INSTANCE VARIABLE
        public List<Movie> movies = new List<Movie>();

        public string[] selectedMovieArray = new string[3];

        //Private Instance Variable
        int _movieIndex;
        int _movieImgageIndex = 0;
        
        

        
        private Bitmap[] _movieImageArray = {Properties.Resources.cedarrapids,
                                       Properties.Resources.companymen,
                                       Properties.Resources.deathrace2,
                                       Properties.Resources.footloose,
                                       Properties.Resources.gnomeoandjuliet,
                                       Properties.Resources.iamnumberfour,
                                       Properties.Resources.justgowithit,
                                       Properties.Resources.nostringsattached,
                                       Properties.Resources.realsteel,
                                       Properties.Resources.sanctum,
                                       Properties.Resources.seasonofthewitch,
                                       Properties.Resources.thedilemma,
                                       Properties.Resources.theeagle,
                                       Properties.Resources.thegreenhornet,
                                       Properties.Resources.themechanic,
                                       Properties.Resources.theotherwoman,
                                       Properties.Resources.therite,
                                       Properties.Resources.theroommate,
                                       Properties.Resources.thewayback,
                                       Properties.Resources.waitingforever
                                       };



        public SelectionForm()
        {
            InitializeComponent();
            InitializeMovieList();
            InitializeComboBox();



        }
        //METHOD - Initailize Movie list 
        private void InitializeMovieList()
        {
            movies.Add(new Movie("Season of the Witch", "Sci‐Fi", 2.99));
            movies.Add(new Movie("The Green Hornet", "Action", 2.99));
            movies.Add(new Movie("The Dilemma", "Comedy", 1.99));
            movies.Add(new Movie("Death Race 2", "Action", 2.99));
            movies.Add(new Movie("Company Men", "Drama", 1.99));
            movies.Add(new Movie("No Strings Attached", "Comedy", 1.99));
            movies.Add(new Movie("The Way Back", "Drama", 1.99));
            movies.Add(new Movie("The Mechanic", "Action", 2.99));
            movies.Add(new Movie("The Rite", "Horror", 2.99));
            movies.Add(new Movie("Sanctum", "Action", 2.99));
            movies.Add(new Movie("The Other Woman", "Action", 2.99));
            movies.Add(new Movie("The Roommate", "Thriller", 1.99));
            movies.Add(new Movie("Waiting for Forever", "Drama", 1.99));
            movies.Add(new Movie("Cedar Rapids", "Comedy", 1.99));
            movies.Add(new Movie("Gnomeo and Juliet", "Family", 0.99));
            movies.Add(new Movie("Just Go With It", "Comedy", 1.99));
            movies.Add(new Movie("The Eagle", "Sci-Fi", 2.99));
            movies.Add(new Movie("I am Number Four", "Sci-Fi", 2.99));
            movies.Add(new Movie("Footloose", "New Release", 4.99));
            movies.Add(new Movie("Real Steel", "New Release", 4.99));

        }
        //MEHTOD - INITIALIZE MOVIE COMBOBOX
        private void InitializeComboBox()
        {
            foreach (var movie in movies)
            {
                MovieListComboBox.Items.Add(movie.Title);
            }
        }
        //METHOD - SORT MOVIE LIST AND SAVE VALUE OF MOVIE TITLE, CATEGORY, COST TO ARRAY 
        private void MovieListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            NextButton.Enabled = true;

            this._movieIndex = MovieListComboBox.SelectedIndex;
            this._movieImgageIndex = MovieListComboBox.SelectedIndex;

            movies.Sort();

            YourSelectionPictureBox.Image = this._movieImageArray[_movieImgageIndex];
            TitleTextBox.Text = movies[this._movieIndex].Title;
            CategoryTextBox.Text = movies[this._movieIndex].Category;
            CostTextBox.Text = movies[this._movieIndex].Cost.ToString("C2");

            selectedMovieArray[0] = movies[this._movieIndex].Title;
            selectedMovieArray[1] = movies[this._movieIndex].Category;
            selectedMovieArray[2] = movies[this._movieIndex].Cost.ToString("C2");


        }
        //EVENT HANDLER - NEXT BUTTON CLICK - SHOW ORDER FORM
        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm(movies[this._movieIndex], this._movieImageArray[_movieImgageIndex]);
            
            this.Hide();

            orderForm.Owner = this;
            orderForm.Show();

        }

        //EVENT HANDLER - SELECTION FORM LOAD - NEXT BUTTON IS UNUSABLE WHEN SELECTION FORM FIRST LOADED
        private void SelectionForm_Load(object sender, EventArgs e)
        {
            NextButton.Enabled = false;

            
        }

        private void CategoryTextBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
