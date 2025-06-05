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
            ButtonInventory = new Button();
            ButtonMove = new Button();
            ButtonSave = new Button();
            panel1 = new Panel();
            ButtonLoot = new Button();
            ButtonFight = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ButtonInventory
            // 
            ButtonInventory.Location = new Point(12, 41);
            ButtonInventory.Name = "ButtonInventory";
            ButtonInventory.Size = new Size(75, 23);
            ButtonInventory.TabIndex = 2;
            ButtonInventory.Text = "Inventory";
            ButtonInventory.UseVisualStyleBackColor = true;
            // 
            // ButtonMove
            // 
            ButtonMove.Location = new Point(12, 70);
            ButtonMove.Name = "ButtonMove";
            ButtonMove.Size = new Size(75, 23);
            ButtonMove.TabIndex = 3;
            ButtonMove.Text = "Move";
            ButtonMove.UseVisualStyleBackColor = true;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(12, 12);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 23);
            ButtonSave.TabIndex = 1;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(ButtonLoot);
            panel1.Controls.Add(ButtonFight);
            panel1.Controls.Add(ButtonSave);
            panel1.Controls.Add(ButtonMove);
            panel1.Controls.Add(ButtonInventory);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 181);
            panel1.TabIndex = 0;
            // 
            // ButtonLoot
            // 
            ButtonLoot.Location = new Point(12, 128);
            ButtonLoot.Name = "ButtonLoot";
            ButtonLoot.Size = new Size(75, 23);
            ButtonLoot.TabIndex = 5;
            ButtonLoot.Text = "Loot";
            ButtonLoot.UseVisualStyleBackColor = true;
            // 
            // ButtonFight
            // 
            ButtonFight.Location = new Point(12, 99);
            ButtonFight.Name = "ButtonFight";
            ButtonFight.Size = new Size(75, 23);
            ButtonFight.TabIndex = 4;
            ButtonFight.Text = "Fight";
            ButtonFight.UseVisualStyleBackColor = true;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 181);
            Controls.Add(panel1);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dungeon Crawler";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonInventory;
        private Button ButtonMove;
        private Button ButtonSave;
        private Panel panel1;
        private Button ButtonFight;
        private Button ButtonLoot;
    }
}