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
    public partial class OrderForm : Form
    {
        //PRIVATE INSTANCE VARIABLE
        private Movie _selectedMovie;
        private Bitmap _selectedImage;
        private string[] _selectedMovieArray;
        private double salesTax = 0;
        private double grandTotal = 0;
        private const int additionalCharge = 10;

        public OrderForm(Movie selectedMovie, Bitmap selectedImage)
        {
            InitializeComponent();

            this._selectedMovie = selectedMovie;
            this._selectedImage = selectedImage;

            TitleTextBox.Text = this._selectedMovie.Title;
            CategoryTextBox.Text = this._selectedMovie.Category;
            CostTextBox.Text = this._selectedMovie.Cost.ToString("C2");
            YourSelectionPictureBox.Image = this._selectedImage;

            salesTax = this._selectedMovie.Cost * 0.13;
            SalesTaxTextBox.Text = salesTax.ToString("C2");

            grandTotal = salesTax + this._selectedMovie.Cost;
            GrandTotalTextBox.Text = grandTotal.ToString("C2");
        }
        //SHARED EVENT HANDLER - ENABLE APPLICATION EXIT
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //EVENT HANDLER - ENABLE PRINT PREVIEW
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm1.Print();
        }
        //EVENT HANDLER - ABOUTBOX APPEAR WHEN ABOUT TOOL STRIP MENU ITEM CLICKED 
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox = new AboutBox1();

            aboutBox.ShowDialog();
        }
        //EVENT HANDLER - BACK BUTTON - SELECTION FORM APPEAR WHEN BACK BUTTON IS CLICKED
        private void BackButton_Click(object sender, EventArgs e)
        {
            SelectionForm selectionForm = new SelectionForm();

            this.Hide();
            selectionForm.Owner = this;

            this.TitleTextBox.Text = selectionForm.selectedMovieArray[0];
            this.CategoryTextBox.Text = selectionForm.selectedMovieArray[1];
            this.CostTextBox.Text = selectionForm.selectedMovieArray[2];

            selectionForm.Show();

        }

        //EVENT HANDLER - STREAM BUTTON - PROCESS TO STREAM FORM AND HIDE ORDER FORM
        private void StreamButton_Click(object sender, EventArgs e)
        {
            StreamForm_ streamform = new StreamForm_(_selectedMovie);

            this.Hide();
            streamform.Owner = this;
            streamform.Show();
        }

        private void OrderTheDVDCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (OrderTheDVDCheckBox.Checked == true)
            {
                HiddenLabel.Visible = true;
                HiddenTextBox.Visible = true;

                HiddenTextBox.Text = additionalCharge.ToString("C2");
                grandTotal = grandTotal + 10;
                GrandTotalTextBox.Text = grandTotal.ToString("C2");
            }
            else
            {
                HiddenLabel.Visible = false;
                HiddenTextBox.Visible = false;

                
                grandTotal = grandTotal - 10;
                GrandTotalTextBox.Text = grandTotal.ToString("C2");
            }
        }
    }
}
