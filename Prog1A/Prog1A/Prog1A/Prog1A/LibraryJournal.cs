//Name:      Jeremy Brown
//Date:      2/14/2012
//Class:     CIS 200-01
//File Name: LibraryJournal
//Purpose:   The purose of this program is to create a Has-A/IS-A hiearchy that will find the data for the various items
//           reanging from books to journals and movies.  The program will if the item is checkedout and calculate the overdue fee.
//           Afterwards it will display all of the information that has been collected throughout the program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1A
{
    class LibraryJournal : LibraryPeriodical
    {
        private string discipline;  //The Journals discipline is stored
        private string editor;   //The Journals editor is stored
        private const decimal MINFEE = .75m;  //Constant holding the min daily late fee for journals

        // Precondition:  None
        // Postcondition: The library magazine has been initialized with the specified
        //                values for generic library items, and the values for the journals discipline, and editor.
        public LibraryJournal(String theTitle, String thePublisher, int theCopyrightYear,
        int theLoanPeriod, String theCallNumber,int theVolume, int theNumber, string theDiscipline, string theEditor)
            : base(theTitle, thePublisher, theCopyrightYear,
                theLoanPeriod, theCallNumber, theVolume, theNumber)
        {
          Discipline  = theDiscipline;
           Editor = theEditor;
        }

        public string Discipline
        {
            // Precondition:  None
            // Postcondition: The journal's discipline is returned
            get
            {
                return discipline;
            }
            // Precondition:  None
            // Postcondition: The journal's discipline is set
            set
            {
                discipline = value;
            }
        }
        public string Editor
        {
            // Precondition:  None
            // Postcondition: The journal's editor is returned
            get
            {
                return editor;
            }
            // Precondition:  None
            // Postcondition: The journal's editor is set
            set
            {
                editor = value;
            }
        }
        // Precondition:  daysLate int must be declared and passed as a parameter.
        // Postcondition: A decimal is returned representing the items late fee after calculations.
        public override decimal CalcLateFee(int daysLate)
        {
            
            lateFee = daysLate * MINFEE;
            return lateFee;
        }
        public override string ToString()
        {
            String result; // Holds for formatted results as being built
            result = base.ToString();
            result += String.Format("Discipline:\t{0}{2}Editor:\t\t{1}{2}", Discipline, Editor, System.Environment.NewLine);
            return result;
        }


    }
}
