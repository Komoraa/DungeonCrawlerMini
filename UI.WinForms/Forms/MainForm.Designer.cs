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
            Panel = new Panel();
            ButtonNewGame = new Button();
            ButtonContinue = new Button();
            LabelContinue = new Label();
            LabelNewGame = new Label();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Controls.Add(LabelNewGame);
            Panel.Controls.Add(LabelContinue);
            Panel.Controls.Add(ButtonNewGame);
            Panel.Controls.Add(ButtonContinue);
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(304, 141);
            Panel.TabIndex = 0;
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
            // LabelContinue
            // 
            LabelContinue.AutoSize = true;
            LabelContinue.Location = new Point(93, 16);
            LabelContinue.Name = "LabelContinue";
            LabelContinue.Size = new Size(38, 15);
            LabelContinue.TabIndex = 3;
            LabelContinue.Text = "label1";
            // 
            // LabelNewGame
            // 
            LabelNewGame.AutoSize = true;
            LabelNewGame.Location = new Point(93, 45);
            LabelNewGame.Name = "LabelNewGame";
            LabelNewGame.Size = new Size(38, 15);
            LabelNewGame.TabIndex = 4;
            LabelNewGame.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(304, 141);
            Controls.Add(Panel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dungeon Crawler";
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Button ButtonContinue;
        private Button ButtonNewGame;
        private Label LabelContinue;
        private Label LabelNewGame;
    }
}