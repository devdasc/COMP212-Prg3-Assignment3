using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisplayBooksDatabase
{
    public partial class DisplayBooksDatabase_Form : Form
    {
        private BookDataEntities.BooksEntities dbcontext = new BookDataEntities.BooksEntities();
        public DisplayBooksDatabase_Form()
        {
            InitializeComponent();
        }

        private void DisplayBooksDatabase_Form_Load(object sender, EventArgs e)
        {
            //initial output box
            outputTextBox.Text = "";

            //initial comboBox
            queriesComboBox.SelectedIndex = 0;

        }
        private void queriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (queriesComboBox.SelectedIndex)
            {
                case 0:
                    outputTextBox.Text = "";
                    outputTextBox.AppendText("1. Titles and Authors:");

                    // Get a list of all the titles and the authors who wrote them. Sort the results by title. 
                    var titlesAndAuthors =
                        from book in dbcontext.Titles
                        from author in book.Authors
                        orderby book.Title1
                        select new
                        {
                            book.Title1,
                            author.FirstName,
                            author.LastName,
                            book.ISBN,
                            book.Copyright,
                            book.EditionNumber
                        };

                    //display authors and ISBNs in tabular format
                    foreach (var element in titlesAndAuthors)
                    {
                        outputTextBox.AppendText(String.Format("\r\n{0,-50} -- {1,10} -- {2,10} -- {3,6} -- {4,15}",
                            element.Title1, element.FirstName, element.LastName, element.Copyright, element.ISBN));
                    } // end foreach
                    break;
                case 1:
                    outputTextBox.Text = "";
                    outputTextBox.AppendText("2. Titles and Authors:");
                    /*
                     Get a list of all the titles and the authors who wrote them. Sort the results by title.
                     sort the authors alphabetically by last name, then first name
                    */
                    var titlesAndAuthorsSorted =
                        from book in dbcontext.Titles
                        from author in book.Authors
                        orderby book.Title1, author.LastName, author.FirstName
                        select new
                        {
                            book.Title1,
                            author.FirstName,
                            author.LastName,
                            book.ISBN,
                            book.Copyright,
                            book.EditionNumber
                        };

                    //display authors and ISBNs in tabular format
                    foreach (var element in titlesAndAuthorsSorted)
                    {
                        outputTextBox.AppendText(String.Format("\r\n{0,-50} -- {1,10} -- {2,10} -- {3,6} -- {4,15}",
                            element.Title1, element.FirstName, element.LastName, element.Copyright, element.ISBN));
                    } // end foreach
                    break;
                case 2:

                    outputTextBox.Text = "";
                    outputTextBox.AppendText("3. Titles and Authors:");
                    var titlesByAuthor =
                        from author in dbcontext.Authors
                        orderby author.LastName, author.FirstName
                        select new
                        {
                            Name = author.FirstName + " " + author.LastName,
                            Titles =
                        from book in author.Titles
                        orderby book.Title1
                        select book.Title1
                        };
                    foreach (var author in titlesByAuthor)
                    {
                        outputTextBox.AppendText("\r\n" + author.Name + ":");

                        //display titles written by that author
                        foreach (var title in author.Titles)
                        {
                            outputTextBox.AppendText("\r\n\t\t" + title);
                        }
                    } 
                    break;
            }
        }

        private void outputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
