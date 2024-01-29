using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Financial
{
    public partial class frmGuessingGame : Form
    {
        int userID;
        string AccNum;
        private int randomNumber;
        private int guessCount;
        private int remainingGuesses = 5;
        private decimal accountBalance;
        private decimal earn;

        SqlConnection con;
        SqlCommand cmd;

        public frmGuessingGame(int id)
        {
            InitializeComponent();
            userID = id;
            getAccBal();

            guessCount = 0;
            lblGuessCount.Text = "Guesses left : " + remainingGuesses;

            Random random = new Random();
            randomNumber = random.Next(1, 101);

            int rangeStart = Math.Max(randomNumber - 15, 1);
            int rangeEnd = Math.Min(randomNumber + 15, 100);


            lblHint.Text = "The answer is between " + rangeStart + " and " + rangeEnd + ".";

            con = new SqlConnection("Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True");
        }
        private void getAccBal()
        {
            try
            {
                string connectionString = "Data Source=.;Initial Catalog=BankDataBase;Integrated Security=True";
                string q = "select top 1 AccNum, Balance from MyAccounts where CustomerID = '" + userID.ToString() + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(q, connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        AccNum = (string)reader["AccNum"];
                        accountBalance = (decimal)reader["Balance"];
                    }
                    else
                    {
                        frmNotification notification = new frmNotification();
                        notification.ShowNotification("Error", "Please Try Again.", "warning");
                    }
                }

            }
            catch(Exception)
            {
                frmNotification notification = new frmNotification();
                notification.ShowNotification("Error", "Please Try Again.", "warning");
            }
         }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            int guess;
            if (int.TryParse(txtGuessNum.Text, out guess))
            {
                if (guess < 1 || guess > 100)
                {
                    GameNotify gameNotify = new GameNotify("Please enter a number between 1 and 100.");
                    gameNotify.ShowDialog();
                }
                else
                {
                    guessCount++;
                    remainingGuesses--;
                    lblGuessCount.Text = "Guess Count : " + guessCount;

                    
                    if (guess == randomNumber)
                    {
                        if (guessCount == 1)
                        {
                            GameNotify gameNotify = new GameNotify("Congratulations!\nYou guessed the number in " + guessCount + " guesses.");
                            gameNotify.ShowDialog();
                            earn = 200;
                            accountBalance += earn;
                            txtGuessNum.Enabled = false;
                            btnGuess.Enabled = false;
                            updateMyAccounts();
                        }
                        else if (guessCount == 2)
                        {
                            GameNotify gameNotify = new GameNotify("Congratulations!\nYou guessed the number in " + guessCount + " guesses.");
                            gameNotify.ShowDialog();
                            earn = 150;
                            accountBalance += earn;
                            txtGuessNum.Enabled = false;
                            btnGuess.Enabled = false;
                            updateMyAccounts();
                        }
                        else if (guessCount == 3)
                        {
                            GameNotify gameNotify = new GameNotify("Congratulations!\nYou guessed the number in " + guessCount + " guesses.");
                            gameNotify.ShowDialog();
                            earn = 100;
                            accountBalance += earn;
                            txtGuessNum.Enabled = false;
                            btnGuess.Enabled = false;
                            updateMyAccounts();
                        }
                        else if (guessCount == 4)
                        {
                            GameNotify gameNotify = new GameNotify("Congratulations!\nYou guessed the number in " + guessCount + " guesses.");
                            gameNotify.ShowDialog();
                            earn = 75;
                            accountBalance += earn;
                            txtGuessNum.Enabled = false;
                            btnGuess.Enabled = false;
                            updateMyAccounts();
                        }
                        else if (guessCount == 5)
                        {
                            GameNotify gameNotify = new GameNotify("Congratulations!\nYou guessed the number in " + guessCount + " guesses.");
                            gameNotify.ShowDialog();
                            earn = 50;
                            accountBalance += earn;
                            txtGuessNum.Enabled = false;
                            btnGuess.Enabled = false;
                            updateMyAccounts();
                        }
                    }
                    else if (guessCount > 4)
                    {
                        GameNotify gameNotify = new GameNotify("Sorry, you have run out of guesses.");
                        gameNotify.ShowDialog();
                        earn = 100;
                        accountBalance -= earn;
                        txtGuessNum.Enabled = false;
                        btnGuess.Enabled = false;
                        InsertPaymentHistory();
                    }
                    else if (guess < randomNumber)
                    {
                        int min = Math.Max(randomNumber - 12, 1);
                        int max = Math.Min(randomNumber + 12, 100);
                        lblHint.Text = "The answer is between " + Convert.ToString(min) + " and " + Convert.ToString(max);
                        lblGuessCount.Text = "Guesses left: " + remainingGuesses;
                        //GameNotify gameNotify = new GameNotify("Your guess is too low. Try again.");
                        //gameNotify.ShowDialog();
                    }
                    else
                    {
                        int min = Math.Max(randomNumber - 9, 1);
                        int max = Math.Min(randomNumber + 9, 100);
                        lblHint.Text = "The answer is between " + Convert.ToString(min) + " and " + Convert.ToString(max);
                        lblGuessCount.Text = "Guesses left: " + remainingGuesses;
                        //GameNotify gameNotify = new GameNotify("Your guess is too high. Try again");
                        //gameNotify.ShowDialog();
                    }
                }
            }
            else
            {
                GameNotify gameNotify = new GameNotify("Please enter a valid number.");
            }
        }
        private void InsertPaymentHistory()
        {
            try
            {
                string payTo = "Game";
                con.Open();
                //LOST
                cmd = new SqlCommand("insert into PaymentHistory values ('" + userID.ToString() + "', '" + AccNum.ToString() + "', '" + earn.ToString() + "', '" + payTo.ToString() + "', '" + DateTime.Now.ToString() + "')", con);
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {
                    cmd = new SqlCommand("update MyAccounts set Balance = '" + accountBalance + "' where AccNum = '" + AccNum.ToString() + "'", con);
                    int l = cmd.ExecuteNonQuery();
                    if (l == 1)
                    {
                        frmNotification notify = new frmNotification();
                        notify.ShowNotification("Info", "Game Finished.", "info");
                    }
                    else
                    {
                        frmNotification notify = new frmNotification();
                        notify.ShowNotification("Error", "Payment unsuccessful. Please try again.", "error");
                    }
                }
                else
                {
                    frmNotification notify = new frmNotification();
                    notify.ShowNotification("Error", "Please check and try again.", "error");
                }
            }
            catch(Exception)
            {
                frmNotification notify = new frmNotification();
                notify.ShowNotification("Error", "Please check and try again.", "error");
            }
        }
        private void updateMyAccounts()
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("update MyAccounts set Balance = '" + accountBalance + "' where AccNum = '" + AccNum.ToString() + "'", con);
                int l = cmd.ExecuteNonQuery();
                if (l == 1)
                {
                    frmNotification notify = new frmNotification();
                    notify.ShowNotification("Info", "Game Finished.", "info");
                }
                else
                {
                    frmNotification notify = new frmNotification();
                    notify.ShowNotification("Error", "Please check and try again.", "error");
                }

            }
            catch(Exception)
            {
                frmNotification notify = new frmNotification();
                notify.ShowNotification("Error", "Please check and try again.", "error");
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
