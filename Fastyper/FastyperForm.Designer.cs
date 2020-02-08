namespace Fastyper
{
    partial class FastyperForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameControl1 = new Fastyper.GameControl();
            this.homeControl1 = new Fastyper.HomeControl();
            this.difficultyControl1 = new Fastyper.DifficultyControl();
            this.SuspendLayout();
            // 
            // gameControl1
            // 
            this.gameControl1.Location = new System.Drawing.Point(42, 12);
            this.gameControl1.Name = "gameControl1";
            this.gameControl1.Size = new System.Drawing.Size(816, 474);
            this.gameControl1.TabIndex = 2;
            // 
            // homeControl1
            // 
            this.homeControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeControl1.Location = new System.Drawing.Point(0, -7);
            this.homeControl1.Margin = new System.Windows.Forms.Padding(5);
            this.homeControl1.Name = "homeControl1";
            this.homeControl1.Size = new System.Drawing.Size(816, 474);
            this.homeControl1.TabIndex = 0;
            // 
            // difficultyControl1
            // 
            this.difficultyControl1.Location = new System.Drawing.Point(42, 12);
            this.difficultyControl1.Name = "difficultyControl1";
            this.difficultyControl1.Size = new System.Drawing.Size(826, 474);
            this.difficultyControl1.TabIndex = 1;
            // 
            // FastyperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 530);
            this.Controls.Add(this.difficultyControl1);
            this.Controls.Add(this.gameControl1);
            this.Controls.Add(this.homeControl1);
            this.Name = "FastyperForm";
            this.Text = "Fastyper v0.1";
            this.ResumeLayout(false);

        }

        #endregion

        private HomeControl homeControl1;
        private DifficultyControl difficultyControl1;
        private GameControl gameControl1;
    }
}

