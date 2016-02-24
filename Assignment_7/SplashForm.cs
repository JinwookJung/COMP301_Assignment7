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
    public partial class SplashForm : Form
    {
        //PRIVATE INSTANCE VARIABLE
        private Movie _selectedMovie;
        private Bitmap _selectedImage;
        public SplashForm()
        {
            InitializeComponent();
        }
        //EVENT HANDLER - TIMER - SELECTION FOR APPEAR AFTER 3 SECONDS
        public void timer1_Tick(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();

            this.Hide();
            selectionForm.Show();
            timer1.Enabled = false;
        }
    }
}
