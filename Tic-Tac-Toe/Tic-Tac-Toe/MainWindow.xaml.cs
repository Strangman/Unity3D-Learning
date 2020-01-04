using System.Windows;
using System.Windows.Controls;

namespace Tic_Tac_Toe
{
    public partial class MainWindow : Window
    {
        public int turn;
        Player player1 = new Player();
        Player player2 = new Player();
        public MainWindow()
        {
            InitializeComponent();
            textBlock1.Text = $"Player 1: {player1.Score.ToString()}";
            textBlock2.Text = $"Player 2: {player2.Score.ToString()}";
        }
        public void Click_Button(object sender, RoutedEventArgs e)
        {
            Button a = (Button)e.Source;
            if(a.Content == null)
            {
                turn++;
                if (turn % 2 == 1)
                {
                    a.Content = "X";
                }
                else
                {
                    a.Content = "O";
                }

                Check();
            }
        }
        public void Clean()
        {
            button1.Content = null;
            button2.Content = null;
            button3.Content = null;
            button4.Content = null;
            button5.Content = null;
            button6.Content = null;
            button7.Content = null;
            button8.Content = null;
            button9.Content = null;
        }
        public void Win()
        {
            MessageBox.Show("Draw");
            turn = 0;
            Clean();
        }
        public void Win(Button a)
        {

            if (a.Content == "X")
            {
                MessageBox.Show($"Player 1 Win \n Turns:{turn}");
                player1.Score += 1;
                textBlock1.Text =$"Player 1: {player1.Score.ToString()}";
            }
            else
            {
                MessageBox.Show($"Player 2 Win \n Turns:{turn}");
                player2.Score += 1;
                textBlock2.Text = $"Player 2: {player2.Score.ToString()}";
            }
            turn = 0;
            Clean();
        }
        public void Check()
        {
            if (button1.Content == button2.Content && button2.Content == button3.Content && button2.Content != null)
            {
                Win(button1);
            }
            else if (button1.Content == button5.Content && button5.Content == button9.Content && button5.Content != null)
            {
                Win(button1);
            }
            else if (button3.Content == button5.Content && button5.Content == button7.Content && button5.Content != null)
            {
                Win(button3);
            }
            else if (button4.Content == button5.Content && button5.Content == button6.Content && button5.Content != null)
            {
                Win(button4);
            }
            else if (button7.Content == button8.Content && button8.Content == button9.Content && button8.Content != null)
            {
                Win(button7);
            }
            else if (button1.Content == button4.Content && button4.Content == button7.Content && button4.Content != null)
            {
                Win(button1);
            }
            else if (button2.Content == button5.Content && button5.Content == button8.Content && button5.Content != null)
            {
                Win(button2);
            }
            else if (button3.Content == button6.Content && button6.Content == button9.Content && button6.Content != null)
            {
                Win(button3);
            }
            else if (button1.Content != null &&
            button2.Content != null &&
            button3.Content != null &&
            button4.Content != null &&
            button5.Content != null &&
            button6.Content != null &&
            button7.Content != null &&
            button8.Content != null &&
            button9.Content != null)
            {
                Win();
            }
        }
    }
}
