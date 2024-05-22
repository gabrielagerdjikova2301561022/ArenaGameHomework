namespace ArenaGameWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            bNewGame = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ListBoxKnight = new ListBox();
            ListBoxRogue = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // bNewGame
            // 
            bNewGame.Location = new Point(258, 9);
            bNewGame.Margin = new Padding(3, 2, 3, 2);
            bNewGame.Name = "bNewGame";
            bNewGame.Size = new Size(150, 22);
            bNewGame.TabIndex = 0;
            bNewGame.Text = "New Game";
            bNewGame.UseVisualStyleBackColor = true;
            bNewGame.Click += bNewGame_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 69);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(464, 69);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ListBoxKnight
            // 
            ListBoxKnight.FormattingEnabled = true;
            ListBoxKnight.ItemHeight = 15;
            ListBoxKnight.Location = new Point(25, 184);
            ListBoxKnight.Margin = new Padding(3, 2, 3, 2);
            ListBoxKnight.Name = "ListBoxKnight";
            ListBoxKnight.Size = new Size(274, 244);
            ListBoxKnight.TabIndex = 3;
            // 
            // ListBoxRogue
            // 
            ListBoxRogue.FormattingEnabled = true;
            ListBoxRogue.ItemHeight = 15;
            ListBoxRogue.Location = new Point(402, 184);
            ListBoxRogue.Margin = new Padding(3, 2, 3, 2);
            ListBoxRogue.Name = "ListBoxRogue";
            ListBoxRogue.Size = new Size(274, 244);
            ListBoxRogue.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 451);
            Controls.Add(ListBoxRogue);
            Controls.Add(ListBoxKnight);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bNewGame);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "Arena Game";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button bNewGame;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private ListBox ListBoxKnight;
        private ListBox ListBoxRogue;
    }
}
