//Name:      Jeremy Brown
//Date:      2/14/2012
//Class:     CIS 200-01
//File Name: LibraryMovie
//Purpose:   The purose of this program is to create a Has-A/IS-A hiearchy that will find the data for the various items
//           reanging from books to journals and movies.  The program will if the item is checkedout and calculate the overdue fee.
//           Afterwards it will display all of the information that has been collected throughout the program.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1A
{
   public class LibraryMovie : LibraryMediaItem
    {
        public enum MPAARatings { G, PG, PG13, R, NC17, U };  // Enum that contains the set of rating given to movies by the MPAA

        private string movieDirector;   //Holds the movie's Director
        private MediaType movieMedium;   //Holds the movie's storage medium
        private MPAARatings movieRatings;  //Holds the movies rating
        public const decimal STND_FRMT_MINFEE = 1.00m;    //Constant the holds the standard min late fee for standards digital media
        public const decimal HGHDEFT_FRMT_MINFEE = 1.50m; //Constant the holds the standards min late fee for high deft digital media 
        public const decimal STD_MAX_FEE = 25m; //Constant the holds the standards min late fee for high deft digital media 


        // Precondition:  None
        // Postcondition: The library movie has been initialized with the specified
        //                values for generic library items, and the director, medium, and ratings
        public LibraryMovie(String theTitle, String thePublisher, int theCopyrightYear,
         int theLoanPeriod, String theCallNumber, double theDuration, String theDirector, MediaType theMedium, MPAARatings theRatings)
            : base(theTitle, thePublisher, theCopyrightYear,
                theLoanPeriod, theCallNumber, theDuration)
        {
            Director = theDirector;
            Medium = theMedium;
            Ratings = theRatings;
        }
        public string Director
        {
            // Precondition:  None
            // Postcondition: The movie's director is returned
            get
            {
                return movieDirector;
            }
            // Precondition:  None
            // Postcondition: The movie's director is set to the specified value
            private set
            {
                movieDirector = value;
            }
        }
        public override MediaType Medium
        {
            // Precondition:  None
            // Postcondition: The movie's storage medium is returned 
            get 
            { 
                return movieMedium; 
            }
            // Precondition:  MediaType must be less that VHS in the Enum order else exception thrown
            // Postcondition: The movie's storage medium is set to the specified value
            set
            {
                
                if ( value <= MediaType.VHS)
                    movieMedium = value;
                else
                    throw new ArgumentOutOfRangeException("movieMedium", value,
                    "The movie medium must be either in a DVD, VHS, or BLU-RAY format");
            }
        }
        public MPAARatings Ratings
        {
            // Precondition:  None
            // Postcondition: The movie's ratings is returned 
            get
            {
                return movieRatings;
            }
            // Precondition:  None
            // Postcondition: The movie's rating is set to the specified value
            private set
            {
                movieRatings = value;
            }
        }
        // Precondition:  daysLate int must be declared and passed as a parameter.
        // Postcondition: A decimal is returned representing the items late fee after calculations.     
        public override decimal CalcLateFee(int daysLate)
        {
            
            if (movieMedium > MediaType.DVD && movieMedium < MediaType.VHS)
             lateFee = daysLate * HGHDEFT_FRMT_MINFEE;
            else lateFee = daysLate * STND_FRMT_MINFEE;


               return lateFee;
        }
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary movie's data on
        //                separate lines
     
        public override string ToString()
        {
            String result; // Holds for formatted results as being built
            result = base.ToString();
            result += String.Format("Director:\t{0}{3}Movie Type:\t{1}{3}Movie Rating:\t{2}{3}",
                Director, Medium, Ratings, System.Environment.NewLine);
            

            return result;
        }

    }
}

