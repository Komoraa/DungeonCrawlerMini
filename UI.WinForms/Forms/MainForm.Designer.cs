namespace UI.WinForms.Forms
{
    partial class MainForm
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
            panel1 = new Panel();
            ButtonNewGame = new Button();
            ButtonContinue = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ButtonNewGame);
            panel1.Controls.Add(ButtonContinue);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 141);
            panel1.TabIndex = 0;
            // 
            // ButtonNewGame
            // 
            ButtonNewGame.Location = new Point(12, 41);
            ButtonNewGame.Name = "ButtonNewGame";
            ButtonNewGame.Size = new Size(75, 23);
            ButtonNewGame.TabIndex = 2;
            ButtonNewGame.Text = "New Game";
            ButtonNewGame.UseVisualStyleBackColor = true;
            ButtonNewGame.Click += ButtonNewGame_Click;
            // 
            // ButtonContinue
            // 
            ButtonContinue.Location = new Point(12, 12);
            ButtonContinue.Name = "ButtonContinue";
            ButtonContinue.Size = new Size(75, 23);
            ButtonContinue.TabIndex = 1;
            ButtonContinue.Text = "Continue";
            ButtonContinue.UseVisualStyleBackColor = true;
            ButtonContinue.Click += ButtonContinue_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(304, 141);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dungeon Crawler";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button ButtonContinue;
        private Button ButtonNewGame;
    }
}