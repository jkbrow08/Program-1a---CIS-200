//Name:      Jeremy Brown
//Date:      2/14/2012
//Class:     CIS 200-01
//File Name: LibraryMusic
//Purpose:   The purose of this program is to create a Has-A/IS-A hiearchy that will find the data for the various items
//           reanging from books to journals and movies.  The program will if the item is checkedout and calculate the overdue fee.
//           Afterwards it will display all of the information that has been collected throughout the program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1A
{
    class LibraryMusic : LibraryMediaItem
    {

        private string musicArtist;  // Stores the musical artist
        private int musicNumTracks;  // Stores the amount of tracks for the medium
        private const decimal MINFEE = .50m;  //Constant containg the min daily fee for music
        private const decimal MAXFEE = 20m;   //Constant containg the max daily fee for music
        public MediaType musicMedium;        //Stores the medium that the music is stored upon

        // Precondition:  None
        // Postcondition: The library music has been initialized with the specified
        //                values for generic library items, and the artisit, medium, and number of tracks.
        public LibraryMusic(String theTitle, String thePublisher, int theCopyrightYear,
         int theLoanPeriod, String theCallNumber, double theDuration, String theArtist, MediaType theMedium, int theNumOfTracks)
            : base(theTitle, thePublisher, theCopyrightYear,
                theLoanPeriod, theCallNumber, theDuration)
        {
            Artist = theArtist;
            NumTracks = theNumOfTracks;
            Medium = theMedium;
        }

        public string Artist
        {
            // Precondition:  None
            // Postcondition: The music's artist is returned
            get
            {
                return musicArtist;
            }
            // Precondition:  None
            // Postcondition: The music's artist is set
            private set
            {
                musicArtist = value;
            }
        }

        public int NumTracks
        {
            // Precondition:  None
            // Postcondition: The music's num of trackes is returned
            get 
            { 
                return musicNumTracks;
            }
            // Precondition:  Num of tracks is greater than 0 else exception thrown
            // Postcondition: The music's artist is set
            set
            {

                if (value >= 0)
                    musicNumTracks = value;
                else
                    throw new ArgumentOutOfRangeException("Number of Tracks", value,
                    "Number of tracks must be more than 0");
            }
        }
        public override MediaType Medium
        {
            // Precondition:  None
            // Postcondition: The music's medium is returned
            get
            { 
                return musicMedium; 
            }
            // Precondition:  MusicType is between CD and Vinyl inclusive else exception thrown
            // Postcondition: The music's medium is set
            set
            {

                if (value >= MediaType.CD && value <= MediaType.VINYL)
                    musicMedium = value;
                else
                    throw new ArgumentOutOfRangeException("musicMedium", value,
                    "Music must be stored on either CD, SACD, or VINYL");
            }
        }
        // Precondition:  daysLate int must be declared and passed as a parameter.
        // Postcondition: A decimal is returned representing the items late fee after calculations.
        public override decimal CalcLateFee(int daysLate)
        {
            
            lateFee = daysLate * MINFEE; 
            if (lateFee > MAXFEE)
                return MAXFEE;
            else return lateFee;
        }
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary music's data on
        //                separate lines
        public override string ToString()
        {
            String result; // Holds for formatted results as being built
            result = base.ToString();
            result += String.Format("Artist:\t\t{0}{3}Medium:\t\t{1}{3}NumTracks:\t{2}{3}",
                Artist, Medium, NumTracks, System.Environment.NewLine);

            return result;
        }
    }
}
