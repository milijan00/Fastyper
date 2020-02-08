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
    public partial class GameControl : UserControl
    {
        uint ocurredTime = 0;
        string givenText = "Given text";
        bool readyToDisplayResult = false;
        public GameControl()
        {
            InitializeComponent();
            this.timeLabel.Text = this.ocurredTime.ToString();
        }
        private string setText()
        {
            string difficulty = GameManager.choosenDifficulty;
            string text = String.Empty;
            if (difficulty == "Easy")
            {
                text = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            }
            else if (difficulty == "Medium")
            {
                text = "There are many variations of passages of Lorem Ipsum available, but the majority have suffered alteration in some form, by injected humour, or randomised words which don't look even slightly believable. If you are going to use a passage of Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the middle of text. All the Lorem Ipsum generators on the Internet tend to repeat predefined chunks as necessary, making this the first true generator on the Internet. It uses a dictionary of over 200 Latin words, combined with a handful of model sentence structures, to generate Lorem Ipsum which looks reasonable. The generated Lorem Ipsum is therefore always free from repetition, injected humour, or non-characteristic words etc.";
            }
            else if (difficulty == "Hard")
            { 
                // hard
                text =  "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, Lorem ipsum dolor sit amet.., comes from a line in section 1.10.32.";
            }
            return text;
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (this.enteredTextRichTextBox.Text == this.givenText)
            {
                this.readyToDisplayResult = true;
                GameManager.gameHasStarted = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GameManager.gameHasStarted)
            {
                ocurredTime++;
                if (this.ocurredTime > 0 && this.ocurredTime <2)
                {
                    this.givenText = this.givenTextLabel.Text = this.setText();
                }
                this.timeLabel.Text = this.ocurredTime.ToString();
            }
            if (this.readyToDisplayResult)
            {
                this.readyToDisplayResult = !this.readyToDisplayResult;
                MessageBox.Show("Well done you have finished within " + this.ocurredTime.ToString() + " seconds!", "Game Won");
            }
        }
    }
}
