
namespace TicTacToe
{
    public partial class Form3 : Form
    {



        bool turn = true;
        List<Button> buttons;
        int player1Count = 0;
        int player2Count = 0;


        public Form3()
        {
            InitializeComponent();
            RestartGame();
        }



        private void RestartGame()
        {
            buttons = new List<Button> { button_1, button_2, button_3, button_4, button_5, button_6, button_7, button_8, button_9 };
            foreach (Button x in buttons)
            {

                x.Enabled = true;
                x.Text = " ";
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (turn)

                button.Text = "X";
            else
                button.Text = "O";
            turn = !turn;


            button.Enabled = false;
            buttons.Remove(button);
            CheckGame();

        }
        private void CheckGame()
        {

            if (button_1.Text == "X" && button_2.Text == "X" && button_3.Text == "X" ||
               button_4.Text == "X" && button_5.Text == "X" && button_6.Text == "X" ||
               button_7.Text == "X" && button_8.Text == "X" && button_9.Text == "X" ||
               button_1.Text == "X" && button_4.Text == "X" && button_7.Text == "X" ||
               button_2.Text == "X" && button_5.Text == "X" && button_8.Text == "X" ||
               button_3.Text == "X" && button_6.Text == "X" && button_9.Text == "X" ||
               button_1.Text == "X" && button_5.Text == "X" && button_9.Text == "X" ||
               button_3.Text == "X" && button_5.Text == "X" && button_7.Text == "X")
            {

                MessageBox.Show("Player1 Wins");
                player1Count++;
                label1.Text = "Player1 Wins: " + player1Count;
                RestartGame();

            }

            else if (button_1.Text == "O" && button_2.Text == "O" && button_3.Text == "O" ||
       button_4.Text == "O" && button_5.Text == "O" && button_6.Text == "O" ||
       button_7.Text == "O" && button_8.Text == "O" && button_9.Text == "O" ||
       button_1.Text == "O" && button_4.Text == "O" && button_7.Text == "O" ||
       button_2.Text == "O" && button_5.Text == "O" && button_8.Text == "O" ||
       button_3.Text == "O" && button_6.Text == "O" && button_9.Text == "O" ||
       button_1.Text == "O" && button_5.Text == "O" && button_9.Text == "O" ||
       button_3.Text == "O" && button_5.Text == "O" && button_7.Text == "O")
            {

                MessageBox.Show("Player2 Wins");
                player2Count++;
                label2.Text = "Player2 Wins: " + player2Count;
                RestartGame();
            }
            else if (buttons.Count == 0)
            {
                MessageBox.Show("Draw");
                RestartGame();
            }

        }

        private void Restart2_Click(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
