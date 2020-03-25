namespace PacManSimple
{
    partial class Game
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
            this.Hero = new System.Windows.Forms.PictureBox();
            this.Food = new System.Windows.Forms.PictureBox();
            this.Enemy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // Hero
            // 
            this.Hero.BackColor = System.Drawing.Color.Coral;
            this.Hero.Location = new System.Drawing.Point(200, 109);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(150, 150);
            this.Hero.TabIndex = 0;
            this.Hero.TabStop = false;
            // 
            // Food
            // 
            this.Food.Location = new System.Drawing.Point(586, 109);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(50, 50);
            this.Food.TabIndex = 1;
            this.Food.TabStop = false;
            // 
            // Enemy
            // 
            this.Enemy.Location = new System.Drawing.Point(382, 297);
            this.Enemy.Name = "Enemy";
            this.Enemy.Size = new System.Drawing.Size(80, 80);
            this.Enemy.TabIndex = 2;
            this.Enemy.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Enemy);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Hero);
            this.Name = "Game";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Game_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Hero;
        private System.Windows.Forms.PictureBox Food;
        private System.Windows.Forms.PictureBox Enemy;
    }
}

