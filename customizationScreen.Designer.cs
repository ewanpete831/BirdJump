
namespace BirdJump
{
    partial class customizationScreen
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
            this.pidgeonButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cardinalButton = new System.Windows.Forms.Button();
            this.jayButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pidgeonButton
            // 
            this.pidgeonButton.Location = new System.Drawing.Point(92, 95);
            this.pidgeonButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pidgeonButton.Name = "pidgeonButton";
            this.pidgeonButton.Size = new System.Drawing.Size(213, 88);
            this.pidgeonButton.TabIndex = 0;
            this.pidgeonButton.Text = "Select Pigeon";
            this.pidgeonButton.UseVisualStyleBackColor = true;
            this.pidgeonButton.Click += new System.EventHandler(this.pidgeonButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BirdJump.Properties.Resources.goodbird4;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(396, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 102);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::BirdJump.Properties.Resources.goodbird5;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(396, 234);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(106, 102);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::BirdJump.Properties.Resources.goodbird6;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(396, 391);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(106, 102);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // cardinalButton
            // 
            this.cardinalButton.Location = new System.Drawing.Point(92, 248);
            this.cardinalButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cardinalButton.Name = "cardinalButton";
            this.cardinalButton.Size = new System.Drawing.Size(213, 88);
            this.cardinalButton.TabIndex = 4;
            this.cardinalButton.Text = "Select Cardinal";
            this.cardinalButton.UseVisualStyleBackColor = true;
            this.cardinalButton.Click += new System.EventHandler(this.cardinalButton_Click);
            // 
            // jayButton
            // 
            this.jayButton.Location = new System.Drawing.Point(92, 405);
            this.jayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.jayButton.Name = "jayButton";
            this.jayButton.Size = new System.Drawing.Size(213, 88);
            this.jayButton.TabIndex = 5;
            this.jayButton.Text = "Select Bluejay";
            this.jayButton.UseVisualStyleBackColor = true;
            this.jayButton.Click += new System.EventHandler(this.jayButton_Click);
            // 
            // customizationScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jayButton);
            this.Controls.Add(this.cardinalButton);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pidgeonButton);
            this.Name = "customizationScreen";
            this.Size = new System.Drawing.Size(600, 615);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pidgeonButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button cardinalButton;
        private System.Windows.Forms.Button jayButton;
    }
}
