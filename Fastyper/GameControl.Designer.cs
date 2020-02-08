namespace Fastyper
{
    partial class GameControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.enteredTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.givenTextLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.timeLabel);
            this.panel1.Controls.Add(this.submitButton);
            this.panel1.Controls.Add(this.enteredTextRichTextBox);
            this.panel1.Controls.Add(this.givenTextLabel);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 474);
            this.panel1.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(716, 416);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(69, 29);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "Time";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(22, 401);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(158, 58);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // enteredTextRichTextBox
            // 
            this.enteredTextRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.enteredTextRichTextBox.Location = new System.Drawing.Point(0, 190);
            this.enteredTextRichTextBox.Name = "enteredTextRichTextBox";
            this.enteredTextRichTextBox.Size = new System.Drawing.Size(810, 205);
            this.enteredTextRichTextBox.TabIndex = 1;
            this.enteredTextRichTextBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // givenTextLabel
            // 
            this.givenTextLabel.AutoSize = true;
            this.givenTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.givenTextLabel.Location = new System.Drawing.Point(17, 14);
            this.givenTextLabel.MaximumSize = new System.Drawing.Size(800, 0);
            this.givenTextLabel.Name = "givenTextLabel";
            this.givenTextLabel.Size = new System.Drawing.Size(0, 24);
            this.givenTextLabel.TabIndex = 0;
            // 
            // GameControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "GameControl";
            this.Size = new System.Drawing.Size(816, 474);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox enteredTextRichTextBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label givenTextLabel;
    }
}
