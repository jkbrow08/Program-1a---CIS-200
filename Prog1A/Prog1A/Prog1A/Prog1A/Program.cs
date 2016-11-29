//Name:      Jeremy Brown
//Date:      2/14/2012
//Class:     CIS 200-01
//File Name: TestProgram
//Purpose:   The purose of this program is to create a Has-A/IS-A hiearchy that will find the data for the various items
//           reanging from books to journals and movies.  The program will if the item is checkedout and calculate the overdue fee.
//           Afterwards it will display all of the information that has been collected throughout the program.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prog1A
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryMovie testLibraryMovie = new LibraryMovie("Avatar", "UK",1987,10, "6789",20, "JVDA", LibraryMediaItem.MediaType.BLURAY, LibraryMovie.MPAARatings.PG);
            LibraryJournal testLibraryJournal = new LibraryJournal("Wolf's Rain", "Louisville", 1987, 2010, "20BA", 1021, 21, "Tech", "Knight");
            LibraryBook testLibraryBook = new LibraryBook("Prog C#", "Prof. wright", 1987, 10, "2056", "Mifune");
            LibraryMagazine testLibraryMagazine = new LibraryMagazine("Game design", "EA", 2005, 10, "3533", 2, 5);
            LibraryMusic testLibraryMusic = new LibraryMusic("B.B. King", "Eric Clapton", 1993, 14, "0090", 1, "B.B. King", LibraryMediaItem.MediaType.VINYL, 16);

            LibraryPatron testLibraryPatron = new LibraryPatron("Jeremy Brown", "507610");


            Console.WriteLine(testLibraryMovie);
            Console.WriteLine(testLibraryJournal);
            Console.WriteLine(testLibraryBook);
            Console.WriteLine(testLibraryMagazine);
            Console.WriteLine(testLibraryMusic);

            Console.WriteLine("After books have been checked out");
            Console.WriteLine();

            testLibraryBook.CheckOut(testLibraryPatron);
            testLibraryBook.CalcLateFee(1);
            testLibraryMovie.CheckOut(testLibraryPatron);
            testLibraryMovie.CalcLateFee(7);
            testLibraryJournal.CheckOut(testLibraryPatron);
            testLibraryJournal.CalcLateFee(10);
            testLibraryMagazine.CheckOut(testLibraryPatron);
            testLibraryMagazine.CalcLateFee(4);
            testLibraryMusic.CheckOut(testLibraryPatron);
            testLibraryMusic.CalcLateFee(5);

            Console.WriteLine(testLibraryMovie);
            Console.WriteLine(testLibraryJournal);
            Console.WriteLine(testLibraryBook);
            Console.WriteLine(testLibraryMagazine);
            Console.WriteLine(testLibraryMusic);

        }
    }
}



 