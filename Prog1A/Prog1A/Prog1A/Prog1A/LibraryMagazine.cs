//Name:      Jeremy Brown
//Date:      2/14/2012
//Class:     CIS 200-01
//File Name: LibraryMagazine
//Purpose:   The purose of this program is to create a Has-A/IS-A hiearchy that will find the data for the various items
//           reanging from books to journals and movies.  The program will if the item is checkedout and calculate the overdue fee.
//           Afterwards it will display all of the information that has been collected throughout the program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1A
{
    class LibraryMagazine : LibraryPeriodical
    {
        private decimal MINFEE = .25m; //Constant containg the min daily fee for periodicals
        private decimal MAXFEE = 20m;  //Constant containg the max daily fee for periodicals

        // Precondition:  None
        // Postcondition: The library magazine has been initialized with the specified
        //                values for generic library items, and the values for library periodicals
        public LibraryMagazine(String theTitle, String thePublisher, int theCopyrightYear,
        int theLoanPeriod, String theCallNumber, int theVolume, int theNumber)
            : base(theTitle, thePublisher, theCopyrightYear,
                theLoanPeriod, theCallNumber, theVolume, theNumber)
        {
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
        // Postcondition: A string is returned presenting the libary magazine's data on
        //                separate lines
     
        public override string ToString()
        {
            String result; // Holds for formatted results as being built
            result = base.ToString();
            return result;
        }

    }
}
