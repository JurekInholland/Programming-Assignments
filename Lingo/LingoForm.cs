using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lingo
{
  public partial class LingoForm : Form
  {
    const int NR_OF_LETTERS = 5;
    const int MAX_ATTEMPTS = 5;

    bool gameRunning;     // flag indicating game is running or not
    int currentAttempt;   // the current (running) attempt, 1..MAX_ATTEMPTS
    string lingoWord;     // the lingo word (the user must guess)
    string playerWord;    // the word entered by user (updated with each entered character)
    string guessedWord;   // word containing all (correctly) guessed letters

    /// <summary>
    /// Constructor of LingoForm.
    /// </summary>
    public LingoForm()
    {
      InitializeComponent();

      // initialize
      EraseAllLetters();
      gameRunning = false;
    }

    /// <summary>
    /// Evenhandler for clicking Start button.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnStart_Click(object sender, EventArgs e)
    {
      // read the lingo word
      lingoWord = txtLingoWord.Text.ToUpper();
      txtLingoWord.Text = lingoWord;

      if (lingoWord.Length != NR_OF_LETTERS)
      {
        MessageBox.Show("Lingo word should have " + NR_OF_LETTERS + " letters!", "Invalid lingo word");
        return;
      }

      // reset
      EraseAllLetters();
      playerWord = "";
      guessedWord = lingoWord[0] + "....";  // first letter is free
      currentAttempt = 1;
      DisplayGuessedLetters(guessedWord);
      gameRunning = true;

      chkWordVisible.Checked = false;  // eventhandler is being called now
    }

    /// <summary>
    /// Erases all letters (and colors) on the form.
    /// </summary>
    private void EraseAllLetters()
    {
      // process each row
      for (int r = 1; r <= MAX_ATTEMPTS; r++)
      {
        // process each column
        for (int k = 1; k <= NR_OF_LETTERS; k++)
        {
          // give the panel a standard color
          Panel pnl = Controls.Find("pnlLetter" + r + k, true).FirstOrDefault() as Panel;
          pnl.BackColor = Color.LightBlue;

          // erase the letter
          Label lbl = Controls.Find("lblLetter" + r + k, true).FirstOrDefault() as Label;
          lbl.Text = "";
        }
      }
    }

    /// <summary>
    /// Eventhandler for processing entered keys.
    /// </summary>
    private void Form1_KeyDown(object sender, KeyEventArgs e)
    {
      // if the game's not running, then ignore entered key
      if (!gameRunning)
        return;

      // user entered backspace?
      if (e.KeyCode == Keys.Back)
      {
        DeleteLastLetter();
      }
      else
      {
        AddNewLetter((char)e.KeyCode);

        // user entered a complete word?
        if (playerWord.Length == NR_OF_LETTERS)
        {
          ProcessNewAttempt();
        }
      }
    }

    /// <summary>
    /// Deletes the last entered letter from userinterface and from player word.
    /// </summary>
    private void DeleteLastLetter()
    {
      if (playerWord.Length > 0)
      {
        // erase last letter
        Label lblWis = Controls.Find("lblLetter" + currentAttempt + playerWord.Length, true).FirstOrDefault() as Label;
        lblWis.Text = ".";

        playerWord = playerWord.Substring(0, playerWord.Length - 1);
      }
    }

    /// <summary>
    /// Adds a new letter to userinface and to player word.
    /// </summary>
    /// <param name="c"></param>
    private void AddNewLetter(char c)
    {
      // add letter to player word
      playerWord += c;

      // display letter
      Label lbl = Controls.Find("lblLetter" + currentAttempt + playerWord.Length, true).FirstOrDefault() as Label;
      lbl.Text = playerWord[playerWord.Length - 1].ToString();
    }

    /// <summary>
    /// Processes the latest attempt of user to guess the lingo word.
    /// </summary>
    private void ProcessNewAttempt()
    {
      // for each letter a status (1=correct, 2=wrong position, 3=wrong letter)
      int[] letterStatus = new int[NR_OF_LETTERS];

      // check entered word
      bool wordCorrect = CheckWord(lingoWord, playerWord, letterStatus);

      // display the (status) colors for the entered letters
      DisplayLetterColors(letterStatus);

      // lingo word found by user?
      if (wordCorrect)
      {
        gameRunning = false;
        DisplayFoundAnimation();
      }
      else
      {
        // game is running while maximum number of attempts has not been reached
        gameRunning = (currentAttempt < MAX_ATTEMPTS);
        if (gameRunning)
        {
          currentAttempt++;
          playerWord = "";

          DisplayGuessedLetters(guessedWord);
        }
      }

      if (!gameRunning)
        chkWordVisible.Checked = true; // eventhandler is being called now
    }

    /// <summary>
    /// Check all letters of the player word with letters of lingo word.
    /// Result is returned in an (output) array with int-values
    /// 1=letter is correct, 2=letter is at wrong position, 3=letter is incorrect.
    /// </summary>
    /// <param name="lingoWord">word that must be guessed by player/user</param>
    /// <param name="playerWord">word entered by player/user</param>
    /// <param name="status">array with int-values (letter status) determined in this method</param>
    /// <returns>True if lingo word equals player word, false otherwise</returns>
    private bool CheckWord(string lingoWord, string playerWord, int[] status)
    {
            // keep track of not yet matched letters
            string remaining = lingoWord;

            // loop inner loop 2 times
            for (int j = 0; j < 2; j++)
            { 
            // iterate through the word
            for (int i = 0; i < lingoWord.Length; i++)
            {
                char character = playerWord[i];
                
                // first loop iteration
                if (j == 0)
                {
                    // set status to 1 if letters match
                    if (playerWord[i] == lingoWord[i])
                    {
                        status[i] = 1;
                        int index = remaining.IndexOf(playerWord[i]);
                        remaining = remaining.Remove(index, 1);
                    }
                }
                // second loop iteration
                else if (j == 1)
                    {
                        // set status to two
                        if (remaining.Contains(character) && status[i] != 1)
                        {
                            status[i] = 2;
                            int index = remaining.IndexOf(playerWord[i]);
                            remaining = remaining.Remove(index, 1);
                        }
                        // if status is still 0, set it to 3
                        else if (status[i] == 0)
                        {
                            status[i] = 3;
                        }
                    }
                }
            }
            // Check win condtion
            if (lingoWord == playerWord)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    /// <summary>
    /// Displays the letters in the correct color according to given status-array.
    /// </summary>
    /// <param name="status">array with int-values with values:
    /// 1=correct letter, 2=correct letter but wrong position, 3=wrong letter</param>
    private void DisplayLetterColors(int[] status)
    {
      Color letterColor;

      for (int i = 0; i < NR_OF_LETTERS; i++)
      {
        switch (status[i])
        {
          case 1:
            letterColor = Color.Red;
            break;
          case 2:
            letterColor = Color.Yellow;
            break;
          default:
            letterColor = Color.LightGray;
            break;
        }

        Panel pnl = Controls.Find("pnlLetter" + currentAttempt + (i + 1), true).FirstOrDefault() as Panel;
        pnl.BackColor = letterColor;

        this.Refresh();
        System.Threading.Thread.Sleep(100);
      }
    }

    /// <summary>
    /// Displays the guessed letters in the new row (for the new attempt).
    /// </summary>
    /// <param name="guessedWord">string with the guessed letters (so far)</param>
    private void DisplayGuessedLetters(string guessedWord)
    {
      for (int i = 1; i <= NR_OF_LETTERS; i++)
      {
        Label lbl = Controls.Find("lblLetter" + currentAttempt + i, true).FirstOrDefault() as Label;
        lbl.Text = guessedWord[i - 1].ToString();
      }
    }

    /// <summary>
    /// Displays a simple animation to indicate the lingo word has been found.
    /// </summary>
    private void DisplayFoundAnimation()
    {
      for (int i = 0; i < 5; i++)
      {
        for (int j = 1; j <= NR_OF_LETTERS; j++)
        {
          Panel pnl = Controls.Find("pnlLetter" + currentAttempt + j, true).FirstOrDefault() as Panel;
          pnl.BackColor = Color.Yellow;
          this.Refresh();

          System.Threading.Thread.Sleep(50);

          pnl.BackColor = Color.Red;
        }
      }
    }

    /// <summary>
    /// Eventhandler for checkbox 'word visible'.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void chkWordVisible_CheckedChanged(object sender, EventArgs e)
    {
      // the lingo word is only visible when 'word visible' is checked
      txtLingoWord.Visible = chkWordVisible.Checked;
    }
  }
}