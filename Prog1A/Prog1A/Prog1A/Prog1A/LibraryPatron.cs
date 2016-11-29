//Name:      Jeremy Brown
//Date:      2/14/2012
//Class:     CIS 200-01
//File Name: LibraryPatron
//Purpose:   The purose of this program is to create a Has-A/IS-A hiearchy that will find the data for the various items
//           reanging from books to journals and movies.  The program will if the item is checkedout and calculate the overdue fee.
//           Afterwards it will display all of the information that has been collected throughout the program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1A
{
    public class LibraryPatron
    {
        private String patronName; // Name of the patron
        private String patronID;   // ID of the patron

        // Precondition:  None
        // Postcondition: The patron has been initialized with the specified name
        //                and ID
        public LibraryPatron(String name, String id)
        {
            PatronName = name;
            PatronID = id;
        }

        public String PatronName
        {
            // Precondition:  None
            // Postcondition: The patron's name has been returned
            get
            {
                return patronName;
            }

            // Precondition:  None
            // Postcondition: The patron's name has been set to the specified value
            set
            {
                patronName = value;
            }
        }

        public String PatronID
        {
            // Precondition:  None
            // Postcondition: The patron's ID has been returned
            get
            {
                return patronID;
            }

            // Precondition:  None
            // Postcondition: The patron's ID has been set to the specified value
            set
            {
                patronID = value;
            }
        }

        // Precondition:  None
        // Postcondition: A string is returned presenting the libary patron's data on
        //                separate lines
        public override string ToString()
        {
            return String.Format("Name:\t\t{0}{2}ID:\t\t{1}{2}",
                PatronName, PatronID, System.Environment.NewLine);
        }
    }
    
}
