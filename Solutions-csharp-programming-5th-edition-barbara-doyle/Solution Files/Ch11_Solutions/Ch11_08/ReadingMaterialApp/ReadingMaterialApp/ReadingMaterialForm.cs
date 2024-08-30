/* ReadingMaterialForm.cs
 * This class instantiates objects
 * of the Book and Magazine classes.
 * A GUI is provided that enables users
 * to test members of the classes.
 */

using System;
using System.Windows.Forms;

namespace ReadingMaterialApp
{
    public partial class ReadingMaterialForm : Form
    {
        private Book aBook;
        private Magazine aMagazine;
        private OnLine onLineVersion;

        public ReadingMaterialForm()
        {
            InitializeComponent();
        }

        private void ReadingMaterialForm_Load(object sender, EventArgs e)
        {
            aBook = new Book("Barbara", "Doyle", "C# Programming", "Computer Science",
                                                "Course Technology", "2012", "12387-2349", false, true);
            aMagazine = new Magazine("Julia", "Little", "Data Grids", "Reference", "Oriorn", "2013", "Technology Today", "Fredrick");

            onLineVersion = new OnLine("http://www.gutenberg.org/ebooks/20727", "The Cosmic Computer");
        }

        private void cmboDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblResult.Visible = true;
            if (cmboDisplay.SelectedIndex == 0)
               lblResult.Text =   aBook.ToString();
            else
                if (cmboDisplay.SelectedIndex == 1)
                    lblResult.Text = aMagazine.ToString();
                else
                lblResult.Text = onLineVersion.ToString();


        }

    }
}