using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Program Name: Mastermind_WindowsForms
 * Description: Implementation of a Mastermind game using Windows Forms in C#.
 * Author: Santiago Escobar Toro
 * Date: 10/01/24
 * Version: 2.0
 * Platform: Windows
 * Programming Language: C#
 * IDE: Visual Studio
 * Comment : No sound is mine, Credits to: Club penguin and Zelda game
 */

namespace Mastermind_WindowsForms
{
    public partial class mainGame : Form
    {
        Menu mainMenu;

        // Number of grid rows and columns
        private const int NBR_ROWS = 10;
        private const int NBR_COLS = 4;

        // Const for change position of panel Choice
        private const int PNL_WIDTH = 120;
        private const int PNL_HEIGHT = 371;

        int _nbrOfAttemps = 0; // NumBer of Attemps

        private int _nbrLabels = 0;  // Counter of Number of Labels

        const int COLOR_MAX = 4; // Number max of colors

        const int COLOR_TO_GUESS = 7; // Number of Colors to guess

        const int LIMIT_OF_GAME = 10; // Times of user can play

        // Tables for label panel creation
        private Label[,] _pnlMain = new Label[NBR_ROWS, NBR_COLS]; // Table of panel to game
        private Label[,] _pnlCheck = new Label[NBR_ROWS, NBR_COLS]; // Table of panel who shows check
        private Label[] _pnlCode = new Label[COLOR_TO_GUESS]; // Table of secret panel colors
        private Label[] _colorGuess = new Label[COLOR_MAX]; // Table of attemps

        // To change the line
        private int _rowChange = 0;


        // Values for pnlMain positioning
        const int POS_HEIGHT = 40;
        const int POS_WIDTH = 12;

        // Values for pnlCheck
        const int POS_HEIGHT_CHECK = 40;
        const int POS_WIDTH_CHECK = 12;

        // Color combination 
        Color[] secretColors =
        {
            Color.Red,
            Color.Lime,
            Color.Blue,
            Color.Yellow,
            Color.LightSkyBlue,
            Color.Purple,
            Color.Orange,
        };

        Color[] tableOfColor = new Color[COLOR_MAX]; // Table of colors

        Random random = new Random(); // Random for the combination of colors

        /// <summary>
        /// Secret color code
        /// </summary>
        void RandomColor()
        {
            /***************************************************************************
            * Make the secret colors code                                              *
            ***************************************************************************/
            for (int i = 0; i < COLOR_MAX; i++)
            {
                int x = random.Next(COLOR_TO_GUESS);

                tableOfColor[i] = secretColors[x];
            }
        }
        /// <summary>
        /// Code launch
        /// </summary>
        /// <param name="menu"></param>
        public mainGame(Menu menu)
        {
            InitializeComponent();
            mainMenu = menu;
            // User cant maximizebox 
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            // Start game in center
            StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Game loads
        /// </summary>
        private void mainGame_Load(object sender, EventArgs e)
        {

            // When game load make secret code
            RandomColor();

            // Position Variables for Panels
            int pnlMainX = 20;
            int pnlMainY = 5;

            int pnlCheckX = 140;
            int pnlCheckY = 12;

            int pnlCodeX = 328;
            int pnlCodeY = 352;

            /***************************************************************************
            * Start of panels creation                                                 *
            ***************************************************************************/
            // Panel creation pnlMain
            Panel pnlMain = new Panel();
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(PNL_WIDTH, PNL_HEIGHT);
            pnlMain.Location = new System.Drawing.Point(pnlMainX, pnlMainY);
            this.Controls.Add(pnlMain);

            // Panel creation pnlCheck
            Panel pnlCheck = new Panel();
            pnlCheck.Name = "pnlCheck";
            pnlCheck.Size = new System.Drawing.Size(PNL_WIDTH, PNL_HEIGHT);
            pnlCheck.Location = new System.Drawing.Point(pnlCheckX, pnlCheckY);
            this.Controls.Add(pnlCheck);

            // Panel creation pnlCode
            Panel pnlCode = new Panel();
            pnlCode.Name = "pnlCheck";
            pnlCode.Size = new System.Drawing.Size(101, 21);
            pnlCode.Location = new System.Drawing.Point(pnlCodeX, pnlCodeY);
            this.Controls.Add(pnlCode);


            // Position variables to separate labels
            int posX = 0;
            int posY = 0;

            /**************************************************************************
            * Creation of labels in pnlMain                                           *
            **************************************************************************/
            for (int i = 0; i < NBR_ROWS; i++)
            {
                for (int j = 0; j < NBR_COLS; j++)
                {

                    // Labels Creation + Labels Properties
                    Label lbl = new Label();
                    _nbrLabels++;
                    lbl.Name = "lblChoice" + _nbrLabels;
                    lbl.Location = new Point(posX + POS_WIDTH, posY + POS_HEIGHT); 
                    lbl.Height = 21;
                    lbl.Width = 21;
                    lbl.BackColor = Color.Gainsboro;
                    //lbl.Text = _nbrLabels + "";

                    // Add to panel
                    pnlMain.Controls.Add(lbl);

                    // Put Labels in table
                    _pnlMain[i, j] = lbl;
                    posX += 27;

                }
                posX = 0;
                posY += 27;
            }

            // Reset Position Variables for Correct Positioning
            posX = 0;
            posY = 0;
            _nbrLabels = 0; // Reset counter

            /**************************************************************************
            * Creation of labels in pnlCheck                                          *
            **************************************************************************/
            for (int i = 0; i < NBR_ROWS; i++)
            {
                for (int j = 0; j < NBR_COLS; j++)
                {

                    // Labels Creation + Labels Properties
                    Label lbl = new Label();
                    _nbrLabels++;
                    lbl.Name = "lblCheck" + _nbrLabels;
                    lbl.Location = new Point(posX + POS_WIDTH, posY + POS_HEIGHT); 
                    lbl.Height = 12;
                    lbl.Width = 12;
                    lbl.BackColor = Color.Gainsboro;
                    //lbl.Text = _nbrLabels + "";

                    // Add to panel
                    pnlCheck.Controls.Add(lbl);

                    // Put Labels in table
                    _pnlCheck[i, j] = lbl;
                    posX += 27;

                    // Related events
                    //lbl.Click += new System.EventHandler(this.setColors);

                }
                posX = 0;
                posY += 27;
            }

            // Reset Position Variables for Correct Positioning
            posX = 0;
            posY = 0;
            _nbrLabels = 0; // Reset counter

            /**************************************************************************
            * Creation of labels in pnlCode                                           *
            **************************************************************************/

            int posLblCode = 0; // Position of labels

            for (int i = 0; i < COLOR_TO_GUESS; i++)
            {

                // Labels Creation + Labels Properties
                Label lbl = new Label();
                _nbrLabels++;
                lbl.Name = "lblCode" + _nbrLabels;
                lbl.Location = new Point(0 + posLblCode, 0);
                lbl.Height = 21;
                lbl.Width = 21;
                lbl.BackColor = Color.Gainsboro;
                //lbl.Text = _nbrLabels + "";

                // Add to panel
                pnlCode.Controls.Add(lbl);

                // Put Labels in table
                _pnlCode[i] = lbl;
                posLblCode += 26;

                // Related events
                //lbl.Click += new System.EventHandler(this.setColors);
            }

            // Make color combination in labels
            for (int i = 0; i < COLOR_MAX; i++)
            {
                _pnlCode[i].BackColor = tableOfColor[i];
            }

            HideColors();

            // Disable check button
            checkButton.Enabled = false;

            // Good music to play
            PlayBackgroundMusic();

        }

        /// <summary>
        /// Music if you won
        /// </summary>
        private void PlayVictoryMusic()
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer("..\\..\\Songs\\Victory_Sound_Effect.wav");
                soundPlayer.PlayLooping();// Boucle sound
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error with sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Music if you lose
        /// </summary>
        private void PlayLoseMusic()
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer("..\\..\\Songs\\random_slowed_goofy_laugh.wav");
                soundPlayer.PlayLooping();// Boucle sound
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error with sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Nice music to play :) (No sound is of my authorship, all rights reserved for Club penguin.)
        /// </summary>
        private void PlayBackgroundMusic()
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer("..\\..\\Songs\\Thin_Ice _ClubPenguinOST.wav");
                soundPlayer.PlayLooping();// Boucle sound
            } 
            catch (Exception ex)
            {
                MessageBox.Show($"Error with sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void DeactivateLlb()
        {
            boxRedSelect.Enabled = false;
            boxGreenSelect.Enabled = false;
            boxBlueSelect.Enabled = false;
            boxYellowSelect.Enabled = false;
            boxOrangeSelect.Enabled = false;
            boxPurpleSelect.Enabled = false;
            boxLightSkyBlueSelect.Enabled = false;
            checkButton.Enabled = true;  // Check button
        }

        /// <summary>
        /// Hide the colors
        /// </summary>
        void HideColors()
        {
            // Hide secret code
            for (int i = 0; i < COLOR_MAX; i++)
            {
                _pnlCode[i].Visible = false;
            }
        }

        /// <summary>
        /// Activate label of color selection
        /// </summary>
        public void ActivateLlb()
        {
            boxRedSelect.Enabled = true;
            boxGreenSelect.Enabled = true;
            boxBlueSelect.Enabled = true;
            boxYellowSelect.Enabled = true;
            boxOrangeSelect.Enabled = true;
            boxPurpleSelect.Enabled = true;
            boxLightSkyBlueSelect.Enabled = true;
        }

        /// <summary>
        /// Method of setting colors in each trial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SetColors(Color selectColor)
        {

            // Get the first label created
            Label firstLabel = _pnlMain[_rowChange, _nbrOfAttemps];

            // Set the color of the first label
            firstLabel.BackColor = Color.Gainsboro;

            // Check the initial color
            for (int j = 0; j < COLOR_MAX; j++)
            {
                Label currentLabel = _pnlMain[_rowChange, _nbrOfAttemps];

                if (currentLabel.BackColor == firstLabel.BackColor)
                {
                    // Changes the background color of the current label
                    currentLabel.BackColor = selectColor;
                }
            }

            // Check if color max are reached
            if (_nbrOfAttemps >= COLOR_MAX)
            {
                DeactivateLlb();
            }

            _nbrOfAttemps++; // Change label

            // Condition to disable labels if MAX
            if (_nbrOfAttemps == COLOR_MAX)
            {
                DeactivateLlb();
            }

        }

        /// <summary>
        /// Red color selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxRedSelect_Click(object sender, EventArgs e)
        {
            SetColors(Color.Red);
        }

        /// <summary>
        /// Green color selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxGreenSelect_Click(object sender, EventArgs e)
        {
            SetColors(Color.Lime);

        }
        /// <summary>
        /// Blue color selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxBlueSelect_Click(object sender, EventArgs e)
        {
            SetColors(Color.Blue);
        }
        /// <summary>
        /// Yellow color selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxYellowSelect_Click(object sender, EventArgs e)
        {
            SetColors(Color.Yellow);
        }
        /// <summary>
        /// Orange color selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxOrangeSelect_Click(object sender, EventArgs e)
        {
            SetColors(Color.Orange);
        }
        /// <summary>
        /// Purple color selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void boxPurpleSelect_Click(object sender, EventArgs e)
        {
            SetColors(Color.Purple);
        }
        private void boxSkyBlueSelect_Click(object sender, EventArgs e)
        {
            SetColors(Color.LightSkyBlue);
        }
        /// <summary>
        /// Color reset button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Make all colors in gainsboro
            for (int i = 0; i < COLOR_MAX; i++)
            {
                _pnlMain[_rowChange,i].BackColor = Color.Gainsboro;
            }
            _nbrOfAttemps = 0; // Change label

            ActivateLlb();

        }
        /// <summary>
        /// Checkbox for show the secret code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkCode_CheckedChanged(object sender, EventArgs e)
        {
            // Bool that allows you to show or not the secret code
            bool showCode = false;

            // Boolean Condition to Display Colors
            if (checkCode.Checked)
            {
                showCode = true;
            }

            // Change the color of the color code
            if (showCode == true)
            {
                // Show secret code
                for (int i = 0; i < COLOR_MAX; i++)
                {
                    _pnlCode[i].Visible = true;
                }
            }
            else
            {
                HideColors();
            }
        }

        /// <summary>
        /// Mixing colors in check
        /// </summary>
        /// <param name="colors"></param>
        private void ShuffleColors(Label[,] colors)
        {
            Random random = new Random();

            int rows = colors.GetLength(0);
            int cols = colors.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = cols - 1; j > 0; j--)
                {
                    int k = random.Next(0, j + 1);

                    // Swap colors[i, j] and colors[i, k] in the second dimension
                    Label temp = colors[i, j];
                    colors[i, j] = colors[i, k];
                    colors[i, k] = temp;
                }
            }
        }

        /// <summary>
        /// Check if it's finded the secret code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void checkButton_Click(object sender, EventArgs e)
        {
            _nbrOfAttemps = 0; // Reset number of attemps
            ActivateLlb(); // Activate the labels to be able to continue playing
            int winnerNbr = 0; // Number of green colors for winner

            // Check good or bad colors
            for (int i = 0; i < COLOR_MAX; i++)
            {
                if (_pnlMain[_rowChange, i].BackColor == _pnlCode[i].BackColor)
                {
                    _pnlCheck[_rowChange, i].BackColor = Color.Green;
                }
                else
                {
                    _pnlCheck[_rowChange, i].BackColor = Color.Red;
                }
            }
            

            // Check colors if exists
            for (int i = 0; i < COLOR_MAX; i++)
            {
                for (int j = 0; j < COLOR_MAX; j++)
                {
                    if (_pnlCheck[_rowChange, i].BackColor != Color.Green)
                    {
                        if (_pnlMain[_rowChange, i].BackColor == _pnlCode[j].BackColor)
                        {
                            _pnlCheck[_rowChange, i].BackColor = Color.Gold;
                        }
                    }

                }
            }

            // Unsort the colors of the current row
            ShuffleColors(_pnlCheck);

            // Check when the game is done
            if (_rowChange >= 9)
            {
                //check if you lose
                for (int i = 0; i < COLOR_MAX; i++)
                {

                    if (_pnlCheck[_rowChange, i].BackColor != Color.Green)
                    {
                        PlayLoseMusic();
                        MessageBox.Show("HAHA, You Lose!", "𝗠𝗮𝘀𝘁𝗲𝗿𝗠𝗶𝗻𝗱", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                        break;

                    }

                }
            }

            // Check if you win 
            for (int i = 0; i < COLOR_MAX; i++)
            {
                if (_pnlCheck[_rowChange, i].BackColor == Color.Green)
                {
                    winnerNbr++;
                    if (winnerNbr == COLOR_MAX)
                    {
                        PlayVictoryMusic();
                        MessageBox.Show("You win, you are a pro!", "𝗠𝗮𝘀𝘁𝗲𝗿𝗠𝗶𝗻𝗱", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                        break;
                    }
                }
            }

            _rowChange++; // Change the line

        }
        /// <summary>
        /// Close the program for good
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
