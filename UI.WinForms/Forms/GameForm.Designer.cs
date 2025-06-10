namespace UI.WinForms.Forms
{
    partial class GameForm
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
            ButtonSearch = new Button();
            ButtonFight = new Button();
            ButtonSave = new Button();
            ButtonMove = new Button();
            ButtonInventory = new Button();
            ButtonQuit = new Button();
            SuspendLayout();
            // 
            // ButtonSearch
            // 
            ButtonSearch.Location = new Point(12, 41);
            ButtonSearch.Name = "ButtonSearch";
            ButtonSearch.Size = new Size(75, 23);
            ButtonSearch.TabIndex = 5;
            ButtonSearch.Text = "Search";
            ButtonSearch.UseVisualStyleBackColor = true;
            ButtonSearch.Click += ButtonSearch_Click;
            // 
            // ButtonFight
            // 
            ButtonFight.Location = new Point(12, 70);
            ButtonFight.Name = "ButtonFight";
            ButtonFight.Size = new Size(75, 23);
            ButtonFight.TabIndex = 4;
            ButtonFight.Text = "Fight";
            ButtonFight.UseVisualStyleBackColor = true;
            ButtonFight.Click += ButtonFight_Click;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(12, 163);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 23);
            ButtonSave.TabIndex = 1;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            // 
            // ButtonMove
            // 
            ButtonMove.Location = new Point(12, 99);
            ButtonMove.Name = "ButtonMove";
            ButtonMove.Size = new Size(75, 23);
            ButtonMove.TabIndex = 3;
            ButtonMove.Text = "Move";
            ButtonMove.UseVisualStyleBackColor = true;
            ButtonMove.Click += ButtonMove_Click;
            // 
            // ButtonInventory
            // 
            ButtonInventory.Location = new Point(12, 12);
            ButtonInventory.Name = "ButtonInventory";
            ButtonInventory.Size = new Size(75, 23);
            ButtonInventory.TabIndex = 2;
            ButtonInventory.Text = "Inventory";
            ButtonInventory.UseVisualStyleBackColor = true;
            ButtonInventory.Click += ButtonInventory_Click;
            // 
            // ButtonQuit
            // 
            ButtonQuit.Location = new Point(12, 192);
            ButtonQuit.Name = "ButtonQuit";
            ButtonQuit.Size = new Size(75, 23);
            ButtonQuit.TabIndex = 6;
            ButtonQuit.Text = "Quit";
            ButtonQuit.UseVisualStyleBackColor = true;
            ButtonQuit.Click += ButtonQuit_Click;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 227);
            Controls.Add(ButtonQuit);
            Controls.Add(ButtonSave);
            Controls.Add(ButtonInventory);
            Controls.Add(ButtonMove);
            Controls.Add(ButtonFight);
            Controls.Add(ButtonSearch);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dungeon Crawler";
            ResumeLayout(false);
        }

        #endregion
        private Button ButtonInventory;
        private Button ButtonMove;
        private Button ButtonSave;
        private Button ButtonFight;
        private Button ButtonSearch;
        private Button ButtonQuit;
    }
}