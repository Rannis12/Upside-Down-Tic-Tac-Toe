using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B23_Ex05_AmitSwisa_315507723_RanNissan_207523531
{
    public partial class GameSettingsForm : Form
    {
        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void onSecondPlayerCheckboxCheckChange(object sender, EventArgs e)
        {
            bool isSecondPlayerCheckboxChecked = this.checkBoxSecondPlayer.Checked;

            if(isSecondPlayerCheckboxChecked)
            {
                textBoxSecondPlayer.Text = "";
            }
            else
            {
                textBoxSecondPlayer.Text = "[Computer]";
            }
            
            this.textBoxSecondPlayer.Enabled = isSecondPlayerCheckboxChecked;
            
        }

        private void onRowsOrColsInputValueChange(object sender, EventArgs e)
        {
            NumericUpDown changedInput = (sender as NumericUpDown);

            this.rowsNumBox.Value = changedInput.Value;
            this.colsNumBox.Value = changedInput.Value;
        }

        private void onStartGameButtonClick(object sender, EventArgs e)
        {
            if(textBoxFirstPlayer.TextLength == 0 || textBoxSecondPlayer.TextLength == 0)
            {
                MessageBox.Show("Please fill form's input before starting the game.", "Error",  MessageBoxButtons.OK);
            }
            else
            {
                GameWindow gameWindow = new GameWindow(textBoxFirstPlayer.Text, textBoxSecondPlayer.Text,
                                                                (int)rowsNumBox.Value, checkBoxSecondPlayer.Checked);

                this.Hide(); // Hide this form
                gameWindow.Show();  // Show the game window

                gameWindow.FormClosed += (s, args) => this.Close(); // Close this form when the game window is closed
            }
        }
    }
}
