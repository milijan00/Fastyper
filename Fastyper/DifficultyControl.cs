using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fastyper
{
    public partial class DifficultyControl : UserControl
    {
        public DifficultyControl()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            this.setDifficulty("Easy");
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            this.setDifficulty("Medium");
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            this.setDifficulty("Hard");
        }
        private void setDifficulty(string difficulty)
        {
            GameManager.choosenDifficulty = difficulty;
            GameManager.gameHasStarted = true;
            this.SendToBack();
        }
    }
}
