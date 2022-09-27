/* Pabitra Bhandari and Ally Moore
 * Program 4
 * September 27, 2022
 * This program runs a simple game on windows forms in which a
 * user enters guesses until they find the hidden island. The user
 * can also change the size of the map.
 */

namespace IslandGame
{
    public partial class IslandGame : Form
    {
    //Holds map dimensions value, easier to change
    const string MAX = "10";
    const int MAXINT = 10;

    int row = MAXINT;
    int col = MAXINT;
    int grow = 0;
    int gcol = 0;
    int guessCount = 0;


    NavigationSystem navSys = new NavigationSystem(10, 10);

    public IslandGame()
    {
        InitializeComponent();

        //disable except for menu so user has to choose to start a new game,
        //edit the map size, or close
        GamePlayBox.Enabled = false;
        SetMapBox.Enabled = false;
        GuessButton.Enabled = false;
        SetRowLabel.Visible = false;
        SetColumnLabel.Visible = false;
        SetRowTxtBox.Visible = false;
        SetColumnTxtBox.Visible = false;
        RowLabel.Enabled = false;
        ColumnLabel.Enabled = false;
        RowTxtBox.Enabled = false;
        ColumnTxtBox.Enabled = false;
        SetButton.Visible = false;


    }



    //Button Handlers
    //Guess button communicates with NavigationSystem Class
    private void GuessButton_Click(object sender, EventArgs e)
    {



        guessCount++;
        grow = (byte)Convert.ToInt32(RowTxtBox.Text);
        gcol = (byte)Convert.ToInt32(ColumnTxtBox.Text);
        if (grow < row && gcol < col)
        {

            GameMap.Text = "";
            GameMap.Text = navSys.EvalGuess(grow, gcol, guessCount);


        }
        else
        {
            MessageBox.Show("Out of Bounds Guess");
        }

    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        RowLabel.Enabled = true;
        ColumnLabel.Enabled = true;
        RowTxtBox.Enabled = true;
        ColumnTxtBox.Enabled = true;
        GuessButton.Enabled = true;
        GamePlayBox.Enabled = true;
        GameMap.Enabled = true;
        GameMap.Text = "";
        navSys = new NavigationSystem(row, col);
        GameMap.Text = navSys.DspMap();
        guessCount = 0;

    }

    private void SettingsButton_Click(object sender, EventArgs e)
    {
        //enables and sets visible
        SetMapBox.Enabled = true;
        SetRowLabel.Visible = true;
        SetColumnLabel.Visible = true;
        SetRowTxtBox.Visible = true;
        SetColumnTxtBox.Visible = true;
        SetButton.Enabled = true;
        SetButton.Visible = true;

    }

    private void SetButton_Click(object sender, EventArgs e)
    {
        row = (byte)Convert.ToInt32(SetRowTxtBox.Text);
        col = (byte)Convert.ToInt32(SetColumnTxtBox.Text);
        GameMap.Text = "";
        navSys = new NavigationSystem(row, col);
        GameMap.Text = navSys.DspMap();
    }
    //closes application window
    private void CloseButton_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    //Text box handlers

    /// <summary>
    /// text changed limits user input to the max specified with const int MAX
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void RowTxtBox_TextChanged(object sender, EventArgs e)
    {
        string test = RowTxtBox.Text;
        if (RowTxtBox.Text != "")
        {
            if (int.Parse(test) > MAXINT || int.Parse(test) < 0)
            {
                RowTxtBox.Text = MAX;
            }
        }
    }

    private void ColumnTxtBox_TextChanged(object sender, EventArgs e)
    {
        string test = ColumnTxtBox.Text;
        if (ColumnTxtBox.Text != "")
        {
            if (int.Parse(test) > MAXINT || int.Parse(test) < 0)
            {
                ColumnTxtBox.Text = MAX;
            }
        }
    }

    private void SetRowTxtBox_TextChanged(object sender, EventArgs e)
    {
        string test = SetRowTxtBox.Text;
        if (SetRowTxtBox.Text != "")
        {
            if (int.Parse(test) > MAXINT || int.Parse(test) < 0)
            {
                SetRowTxtBox.Text = MAX;
            }
        }
    }

    private void SetColumnTxtBox_TextChanged(object sender, EventArgs e)
    {
        string test = SetColumnTxtBox.Text;
        if (SetColumnTxtBox.Text != "")
        {
            if (int.Parse(test) > MAXINT || int.Parse(test) < 0)
            {
                SetColumnTxtBox.Text = MAX;
            }
        }
    }
    //only allows numerical characters and backspace to avoid improper input
    //same code for each text box-keypress handler
    private void RowTxtBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
        {
            e.Handled = true;
        }

    }
    private void ColummTxtBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
        {
            e.Handled = true;
        }
    }
    private void SetRowTxtBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
        {
            e.Handled = true;
        }
    }
    private void SetColummTxtBox_KeyPress(object sender, KeyPressEventArgs e)
    {
        if ((char.IsNumber(e.KeyChar) == false) && (e.KeyChar != (char)Keys.Back))
        {
            e.Handled = true;
        }
    }


}
}