//Name:      Jeremy Brown
//Date:      2/14/2012
//Class:     CIS 200-01
//File Name: LibraryItem
//Purpose:   The purose of this program is to create a Has-A/IS-A hiearchy that will find the data for the various items
//           reanging from books to journals and movies.  The program will if the item is checkedout and calculate the overdue fee.
//           Afterwards it will display all of the information that has been collected throughout the program.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1A
{
    public abstract class LibraryItem
    {
    public const int DEFAULT_YEAR = 2012; // Default copyright year

    private String libraryItemTitle;      // The item's title
    private String libraryItemPublisher;  // The item's publisher
    private int libraryItemCopyrightYear; // The item's year of copyright
    private int libraryItemLoanPeriod;    // The length of days that the library permits to loan the desired item to you.
    private String libraryItemCallNumber; // The item's call number in the library
    private bool libraryItemCheckedOut;   // The item's checked out status
    private LibraryPatron patron;  // The person that has the item checked out (null otherwise)
    public decimal lateFee;        //The library item's late fee.

    // Precondition:  None
    // Postcondition: The library item has been initialized with the specified
    //                values for title, author, publisher, copyright year, and
    //                call number. The book is not checked out.
    public LibraryItem(String theTitle, String thePublisher, int theCopyrightYear,
         int theLoanPeriod, String theCallNumber)
    {
        // Establish default first in case invalid
        CopyrightYear = DEFAULT_YEAR;

        Title = theTitle;
        Publisher = thePublisher;
        CopyrightYear = theCopyrightYear;
        LoanPeriod = theLoanPeriod;
        CallNumber = theCallNumber;

        ReturnToShelf(); // Make sure book is not checked out
    }

    public String Title
    {
        // Precondition:  None
        // Postcondition: The title has been returned
        get
        {
            return libraryItemTitle;
        }

        // HELPER - not public
        // Precondition:  None
        // Postcondition: The title has been set to the specified value
        private set
        {
            libraryItemTitle = value;
        }
    }
    public String Publisher
    {
        // Precondition:  None
        // Postcondition: The publisher has been returned
        get
        {
            return libraryItemPublisher;
        }

        // Precondition:  None
        // Postcondition: The publisher has been set to the specified value
        set
        {
            libraryItemPublisher = value;
        }
    }

    public int CopyrightYear
    {
        // Precondition:  None
        // Postcondition: The copyright year has been returned
        get
        {
            return libraryItemCopyrightYear;
        }

        // HELPER - not public
        // Precondition:  value >= 0
        // Postcondition: The copyright year has been set to the specified value
        private set
        {
            if (value >= 0)
                libraryItemCopyrightYear = value;
        }
    }
        public int LoanPeriod
        {
            // Precondition:  None
            // Postcondition: The item load period has been returned
            get
        {
            return libraryItemLoanPeriod;
        }
            // Precondition:  value >= 0
            // Postcondition: The item load period has been set to the specified value
           private set
        {
            if (value >= 0)
                libraryItemLoanPeriod = value;
        }

              }

    public String CallNumber
    {
        // Precondition:  None
        // Postcondition: The call number has been returned
        get
        {
            return libraryItemCallNumber;
        }

        // Precondition:  None
        // Postcondition: The call number has been set to the specified value
        set
        {
            libraryItemCallNumber = value;
        }
    }

    // Precondition:  None
    // Postcondition: The item is checked out by thePatron
    public void CheckOut(LibraryPatron thePatron)
    {
        libraryItemCheckedOut = true;
        patron = thePatron;
    }

    // Precondition:  None
    // Postcondition: The item is not checked out (by any patron)
    public void ReturnToShelf()
    {
        libraryItemCheckedOut = false;
        patron = null; // No longer associated with anyone
    }

    // Precondition:  None
    // Postcondition: true is returned if the item is checked out,
    //                otherwise false is returned
    public bool IsCheckedOut()
    {
        return libraryItemCheckedOut;
    }

    // Precondition:  IsCheckedOut() == true
    // Postcondition: The patron that has the item checked out is returned
    //                (otherwise null)
    public LibraryPatron GetPatron()
    {
        return patron;
    }

    // Precondition:  None
    // Postcondition: The method will will calculate the late fee for the library item, and return a decimal
    public abstract decimal CalcLateFee(int daysLate); 



    // Precondition:  None
    // Postcondition: A string is returned presenting the libary item's data on
    //                separate lines
     
    public override string ToString()
    {
        String result; // Holds for formatted results as being built

        result = String.Format("Title:\t\t{0}{5}Publisher:\t{1}{5}" +
            "Copyright:\t{2}{5}Loan Period:\t{3}{5}Call Number:\t{4}{5}",
            Title, Publisher, CopyrightYear, LoanPeriod, CallNumber, System.Environment.NewLine);

        if (IsCheckedOut())
            result += String.Format("Checked Out By:{1}{0}", GetPatron(), System.Environment.NewLine);
        else
            result += "Not Checked Out\n";

        if (lateFee > 0)
            result += String.Format("Late Fee:\t{0}", lateFee.ToString("C2"));
        else result += "Not overdue";
        
        return result;
    }
    }
}
