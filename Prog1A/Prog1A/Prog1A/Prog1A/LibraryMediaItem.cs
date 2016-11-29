//Name:      Jeremy Brown
//Date:      2/14/2012
//Class:     CIS 200-01
//File Name: LibraryMediaItem
//Purpose:   The purose of this program is to create a Has-A/IS-A hiearchy that will find the data for the various items
//           reanging from books to journals and movies.  The program will if the item is checkedout and calculate the overdue fee.
//           Afterwards it will display all of the information that has been collected throughout the program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1A
{
   public abstract class LibraryMediaItem : LibraryItem
    {
        public enum MediaType { DVD, BLURAY, VHS, CD, SACD, VINYL }; // Enum that contains the mediums that music and movies are stored upon

       public double mediaDuration;  //Stores the length of the media duration

       // Precondition:  None
       // Postcondition: The library media has been initialized with the specified
       //                values for generic library items, and the duration of the item.
       public LibraryMediaItem(String theTitle, String thePublisher, int theCopyrightYear,
         int theLoanPeriod, String theCallNumber, double theDuration) : base( theTitle, thePublisher, theCopyrightYear,
         theLoanPeriod, theCallNumber)
    {
        Duration = theDuration;       

    }
       public double Duration
       {
           // Precondition:  None
           // Postcondition: The media's duration is returned 
           get
           {
               return mediaDuration;
           }
           // Precondition:  Duration must be greater than 0
           // Postcondition: The The media's duration is set 
           private set
           {
               if (value >= 0)
                   mediaDuration = value;
               else
                   throw new ArgumentOutOfRangeException("mediaDuration", value,
                   "The media's duration must be greater than 0 hours");
           }

       }
       // Precondition:  None
       // Postcondition: The abstrat property is intitialized
       public abstract MediaType Medium
       {
       get;
       set;
       }
       // Precondition:  None
       // Postcondition: A string is returned presenting the libary media item's data on
       //                separate lines
     
       public override string ToString()
       {
           String result; // Holds for formatted results as being built
           result = base.ToString();
           result += String.Format("{1}Duration:\t{0}{1}", Duration, System.Environment.NewLine);

           
           return result;
       }

    }
    
     }




