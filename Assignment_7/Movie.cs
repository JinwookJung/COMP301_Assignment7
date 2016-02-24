using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    //Movie Class
    public class Movie : IComparable<Movie>
    {
       //Private Instance Variable ++++++++++++++++++++++++++++++++++++++++++++++++
        private string _title;
        private string _category;
        private double _cost;
        
        
        //Public Properties ++++++++++++++++++++++++++++++++++++++++++++++++
        public string Title 
        {
            get 
            {
                return this._title; //Read Only
            }

        }
        public string Category 
        {
            get
            {
                return this._category; //Read Only
            }

        }
        public double Cost 
        {
            get
            {
                return this._cost; //Read Only
            }

        }

        public Movie(string title, string category, double cost) 
        { 
            //Assign Value to Instance Variables
            this._title = title;
            this._category = category;
            this._cost = cost;
        }

        //Default comparer for Movie type - compare the title property

        public int CompareTo(Movie compareMovie)
        {
            //A null value means that this object is greater.
            
            if (compareMovie == null)
                return 1;
            else
                return this._title.CompareTo(compareMovie._title);

        }
        

    }
}
