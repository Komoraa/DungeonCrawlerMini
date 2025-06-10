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
            ButtonLoad = new Button();
            ButtonPlay = new Button();
            ButtonExit = new Button();
            SuspendLayout();
            // 
            // ButtonLoad
            // 
            ButtonLoad.Location = new Point(12, 41);
            ButtonLoad.Name = "ButtonLoad";
            ButtonLoad.Size = new Size(75, 23);
            ButtonLoad.TabIndex = 2;
            ButtonLoad.Text = "Load Save";
            ButtonLoad.UseVisualStyleBackColor = true;
            ButtonLoad.Click += ButtonLoadSave_Click;
            // 
            // ButtonPlay
            // 
            ButtonPlay.Location = new Point(12, 12);
            ButtonPlay.Name = "ButtonPlay";
            ButtonPlay.Size = new Size(75, 23);
            ButtonPlay.TabIndex = 1;
            ButtonPlay.Text = "New Game";
            ButtonPlay.UseVisualStyleBackColor = true;
            ButtonPlay.Click += ButtonPlay_Click;
            // 
            // ButtonExit
            // 
            ButtonExit.Location = new Point(12, 138);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(75, 23);
            ButtonExit.TabIndex = 3;
            ButtonExit.Text = "Exit";
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(275, 173);
            Controls.Add(ButtonExit);
            Controls.Add(ButtonPlay);
            Controls.Add(ButtonLoad);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dungeon Crawler";
            ResumeLayout(false);
        }

        #endregion
        private Button ButtonPlay;
        private Button ButtonLoad;
        private Button ButtonExit;
    }
}