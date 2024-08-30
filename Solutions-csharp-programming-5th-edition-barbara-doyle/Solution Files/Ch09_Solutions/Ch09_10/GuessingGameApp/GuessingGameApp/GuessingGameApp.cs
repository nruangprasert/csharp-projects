/*GuessingGame.cs   
 * This program generates a random number
 * 0 - 100, asks the user to play along
 * (providing clues to the target), and
 * displays a message when the target 
 * value is correctly guessed.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameApp
{
    public partial class GuessingGameAppForm : Form
    {
        private int guess;
        private int target;
        private int countOfGuesses;
        private Random ranValue;

        public GuessingGameAppForm()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            while (int.TryParse(txtBxGuess.Text, out guess) == false)
            {
                lblMsg.Text = "Value must be numeric";
            }
            lblMsg.Text = "";
            lblAnswer.Text = (++countOfGuesses).ToString();
            if (guess == target)
            {
                BackColor = Color.Purple;
                lblMsg.Text = "You got it... You Won!";
            }
            else
            {
                txtBxGuess.Clear();
                txtBxGuess.Focus();
                if (guess > target)
                {
                    lblMsg.Text = guess + " is too high";
                    BackColor = Color.Red;
                }
                else
                {
                    lblMsg.Text = guess + " is too low";
                    BackColor = Color.Green;
                }
            }
        }

        private void GuessingGameAppForm_Load(object sender, EventArgs e)
        {
            ranValue = new Random();
            target = ranValue.Next(0, 101);
            countOfGuesses = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            target = ranValue.Next(0, 101);
            countOfGuesses = 0;
            BackColor = Color.Purple;
            txtBxGuess.Clear();
            lblAnswer.Text = "";
            lblMsg.Text = "";
            txtBxGuess.Focus();
        }
    }
}
