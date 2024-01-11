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
    public partial class Menu : Form
    {
        mainGame game;
        public Menu()
        {
            InitializeComponent();
            game = new mainGame(this);
            // User cant maximizebox 
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            // Start game in center
            StartPosition = FormStartPosition.CenterScreen;
        }
        // Hide the menu window
        private void gameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            game.Show();
        }
        // For exit of program
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Background music
        /// </summary>
        private void PlayBackgroundMusic()
        {
            try
            {
                SoundPlayer soundPlayer = new SoundPlayer("..\\..\\Songs\\Bits _Bolts _ClubPenguinOST.wav");
                soundPlayer.PlayLooping();// Boucle sound
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error with sound: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Game loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Load(object sender, EventArgs e)
        {
            PlayBackgroundMusic();
        }
    }
}
