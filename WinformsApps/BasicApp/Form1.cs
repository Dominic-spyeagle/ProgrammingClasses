using System;
using System.Windows.Forms;

namespace BasicApp
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        private int _numberToGuess;
        private int _numberofguesses;
        public Form1()
        {
            InitializeComponent();
            messageLabel.Text = "Press the button to start a new game";
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            messageLabel.Text = "Guess a number from 1 to 100";
            startButton.Enabled = false;
            _numberToGuess = _random.Next(1, 101);

            guessInput.Enabled = true;
            _numberofguesses = 0;
            label1.Text = _numberofguesses.ToString();

            guessHistroy.Items.Clear();
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            _numberofguesses++;
            label1.Text = _numberofguesses.ToString();

            string input = guessInput.Text;
            guessInput.Text = "";
            
            int result = int.Parse(input);
            
            if (result > _numberToGuess)
            {
                messageLabel.Text = "Too big. Guess again";
                guessHistroy.Items.Add(result.ToString() + " - too big");
            }
            else if(result < _numberToGuess)
            {
                messageLabel.Text = "Too small. Guess again";
                guessHistroy.Items.Add(result.ToString() + " - too small");
            }
            else
            {
                messageLabel.Text = "You did it !!! Press the start button for another game";
                startButton.Enabled = true;
                guessButton.Enabled = false;
                guessInput.Enabled = false;
            }
           

        }

        private void guessInput_TextChanged(object sender, EventArgs e)
        {
            string input = guessInput.Text;
            int result;
            bool validNumber = int.TryParse(input, out result);
            if (!validNumber || result < 1 || result > 100)
            {
                guessButton.Enabled = false;
            }
            else
            {
                guessButton.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
