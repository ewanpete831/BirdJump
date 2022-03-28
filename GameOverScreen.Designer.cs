
namespace BirdJump
{
    partial class GameOverScreen
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
            this.finalScoreLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.birdBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.birdBox)).BeginInit();
            this.SuspendLayout();
            // 
            // finalScoreLabel
            // 
            this.finalScoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalScoreLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.finalScoreLabel.Location = new System.Drawing.Point(-4, 0);
            this.finalScoreLabel.Name = "finalScoreLabel";
            this.finalScoreLabel.Size = new System.Drawing.Size(604, 182);
            this.finalScoreLabel.TabIndex = 0;
            this.finalScoreLabel.Text = "finalScoreLabel";
            this.finalScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(74, 186);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(458, 149);
            this.playButton.TabIndex = 2;
            this.playButton.Text = "Play Again";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.Location = new System.Drawing.Point(164, 345);
            this.menuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(276, 78);
            this.menuButton.TabIndex = 3;
            this.menuButton.Text = "Return to Menu";
            this.menuButton.UseVisualStyleBackColor = true;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // birdBox
            // 
            this.birdBox.BackgroundImage = global::BirdJump.Properties.Resources.goodbird7;
            this.birdBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.birdBox.Location = new System.Drawing.Point(164, 432);
            this.birdBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.birdBox.Name = "birdBox";
            this.birdBox.Size = new System.Drawing.Size(276, 178);
            this.birdBox.TabIndex = 4;
            this.birdBox.TabStop = false;
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.birdBox);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.finalScoreLabel);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(600, 615);
            this.Load += new System.EventHandler(this.GameOverScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.birdBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label finalScoreLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.PictureBox birdBox;
    }
}
