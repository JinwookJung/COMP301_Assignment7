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
    public partial class StreamForm_ : Form
    {
        //Private Instace Variable
        private Movie _selectedMovie;
        public StreamForm_(Movie selectedMovie)
        {
            InitializeComponent();
            this._selectedMovie = selectedMovie;

            ChargedLabel.Text = this._selectedMovie.Cost.ToString("C2");
            TitleLabel.Text = this._selectedMovie.Title;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StreamForm__Load(object sender, EventArgs e)
        {

        }
    }
}
