//Name:      Jeremy Brown
//Date:      2/14/2012
//Class:     CIS 200-01
//File Name: LibraryPeriodical
//Purpose:   The purose of this program is to create a Has-A/IS-A hiearchy that will find the data for the various items
//           reanging from books to journals and movies.  The program will if the item is checkedout and calculate the overdue fee.
//           Afterwards it will display all of the information that has been collected throughout the program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1A
{
    public abstract class LibraryPeriodical : LibraryItem
    {
        private int periodicalVolume;  //The periodcial's Volume
        private int periodicalNumber;  //The periodical's Number 

        // Precondition:  None
        // Postcondition: The library periodical has been initialized with the specified
        //                values for generic library items, and the volume and number for the periodical
        public LibraryPeriodical(String theTitle, String thePublisher, int theCopyrightYear,
        int theLoanPeriod, String theCallNumber, int theVolume, int theNumber)
            : base(theTitle, thePublisher, theCopyrightYear,
                theLoanPeriod, theCallNumber)
        {
            Volume = theVolume;
            Number = theNumber;
        }
        public int Volume
        {
            // Precondition:  None
            // Postcondition: The periodical's volume is returned
            get
            {
                return periodicalVolume;
            }
            // Precondition:  If volume is greater than 0 else exception thrown
            // Postcondition: The periodical's volume is set
            set
            {


                if (value >= 0)
                    periodicalVolume = value;
                else
                    throw new ArgumentOutOfRangeException("periodicalVolume", value,
                    "periodicalVolume must be more than 0");

            }
        }
        public int Number
        {
            // Precondition:  None
            // Postcondition: The periodical's number is returned
            get
            {
                return periodicalNumber;
            }
            // Precondition:  If number is greater than 0 else exception thrown
            // Postcondition: The periodical's number is set
            set
            {
                if (value >= 0)
                    periodicalNumber = value;
                else
                    throw new ArgumentOutOfRangeException("periodicalNumber", value,
                    "periodicalNumber must be more than 0");


            }
        }
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary periodical's data on
        //                separate lines
        public override string ToString()
        {
            String result; // Holds for formatted results as being built
            result = base.ToString();
            result += String.Format("{2}Volume:\t\t{0}{2}Number:\t\t{1}{2}",
                Volume,Number, System.Environment.NewLine);

            return result;
        }



    }
}
