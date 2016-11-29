//Name:      Jeremy Brown
//Date:      2/14/2012
//Class:     CIS 200-01
//File Name: LibraryBook
//Purpose:   The purose of this program is to create a Has-A/IS-A hiearchy that will find the data for the various items
//           reanging from books to journals and movies.  The program will if the item is checkedout and calculate the overdue fee.
//           Afterwards it will display all of the information that has been collected throughout the program.




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1A
{
    public class LibraryBook : LibraryItem
    {


        private String bookAuthor;            // The book's author
        private const decimal BOOKFEE = .25m;  // The book's min late fee per day

        // Precondition:  None
        // Postcondition: The library magazine has been initialized with the specified
        //                values for generic library items, and the values for the books author
        public LibraryBook (String theTitle, String thePublisher, int theCopyrightYear,
         int theLoanPeriod, String theCallNumber, String theAuthor) : base( theTitle, thePublisher, theCopyrightYear,
         theLoanPeriod, theCallNumber)
    {
        Author = theAuthor;

        ReturnToShelf(); // Make sure book is not checked out
    }
        
         public String Author
        {
            // Precondition:  None
            // Postcondition: The author has been returned
            get
            {
                return bookAuthor;
            }

            // HELPER - not public
            // Precondition:  None
            // Postcondition: The author has been set to the specified value
            private set
            {
                bookAuthor = value;

            }
             
        }
         // Precondition:  daysLate int must be declared and passed as a parameter.
         // Postcondition: A decimal is returned representing the items late fee after calculations.
        public override decimal  CalcLateFee(int daysLate)
{
                 
 	             lateFee = daysLate * BOOKFEE;
                 return lateFee;
}
        // Precondition:  None
        // Postcondition: A string is returned presenting the libary book's data on
        //                separate lines
        public override string ToString()
        {
            String result; // Holds for formatted results as being built
            result = base.ToString();
            result += String.Format("{1}Author:\t\t{0}{1}",
               Author, System.Environment.NewLine);
            return result;
        }
    }
}
