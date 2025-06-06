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
            Panel = new Panel();
            ButtonInventory = new Button();
            ButtonMove = new Button();
            ButtonSave = new Button();
            LabelSave = new Label();
            ButtonLoot = new Button();
            ButtonFight = new Button();
            LabelInventory = new Label();
            LabelMove = new Label();
            LavelFight = new Label();
            LabelLoot = new Label();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.Controls.Add(LabelLoot);
            Panel.Controls.Add(LavelFight);
            Panel.Controls.Add(LabelMove);
            Panel.Controls.Add(LabelInventory);
            Panel.Controls.Add(LabelSave);
            Panel.Controls.Add(ButtonLoot);
            Panel.Controls.Add(ButtonFight);
            Panel.Controls.Add(ButtonSave);
            Panel.Controls.Add(ButtonMove);
            Panel.Controls.Add(ButtonInventory);
            Panel.Dock = DockStyle.Fill;
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(304, 181);
            Panel.TabIndex = 0;
            // 
            // ButtonInventory
            // 
            ButtonInventory.Location = new Point(12, 41);
            ButtonInventory.Name = "ButtonInventory";
            ButtonInventory.Size = new Size(75, 23);
            ButtonInventory.TabIndex = 2;
            ButtonInventory.Text = "Inventory";
            ButtonInventory.UseVisualStyleBackColor = true;
            ButtonInventory.Click += ButtonInventory_Click;
            ButtonInventory.MouseEnter += ButtonInventory_MouseEnter;
            ButtonInventory.MouseLeave += ButtonInventory_MouseLeave;
            // 
            // ButtonMove
            // 
            ButtonMove.Location = new Point(12, 70);
            ButtonMove.Name = "ButtonMove";
            ButtonMove.Size = new Size(75, 23);
            ButtonMove.TabIndex = 3;
            ButtonMove.Text = "Move";
            ButtonMove.UseVisualStyleBackColor = true;
            ButtonMove.Click += ButtonMove_Click;
            ButtonMove.MouseEnter += ButtonMove_MouseEnter;
            ButtonMove.MouseLeave += ButtonMove_MouseLeave;
            // 
            // ButtonSave
            // 
            ButtonSave.Location = new Point(12, 12);
            ButtonSave.Name = "ButtonSave";
            ButtonSave.Size = new Size(75, 23);
            ButtonSave.TabIndex = 1;
            ButtonSave.Text = "Save";
            ButtonSave.UseVisualStyleBackColor = true;
            ButtonSave.Click += ButtonSave_Click;
            ButtonSave.MouseEnter += ButtonSave_MouseEnter;
            ButtonSave.MouseLeave += ButtonSave_MouseLeave;
            // 
            // LabelSave
            // 
            LabelSave.AutoSize = true;
            LabelSave.Location = new Point(93, 16);
            LabelSave.Name = "LabelSave";
            LabelSave.Size = new Size(38, 15);
            LabelSave.TabIndex = 6;
            LabelSave.Text = "label1";
            // 
            // ButtonLoot
            // 
            ButtonLoot.Location = new Point(12, 128);
            ButtonLoot.Name = "ButtonLoot";
            ButtonLoot.Size = new Size(75, 23);
            ButtonLoot.TabIndex = 5;
            ButtonLoot.Text = "Loot";
            ButtonLoot.UseVisualStyleBackColor = true;
            ButtonLoot.Click += ButtonLoot_Click;
            ButtonLoot.MouseEnter += ButtonLoot_MouseEnter;
            ButtonLoot.MouseLeave += ButtonLoot_MouseLeave;
            // 
            // ButtonFight
            // 
            ButtonFight.Location = new Point(12, 99);
            ButtonFight.Name = "ButtonFight";
            ButtonFight.Size = new Size(75, 23);
            ButtonFight.TabIndex = 4;
            ButtonFight.Text = "Fight";
            ButtonFight.UseVisualStyleBackColor = true;
            ButtonFight.Click += ButtonFight_Click;
            ButtonFight.MouseEnter += ButtonFight_MouseEnter;
            ButtonFight.MouseLeave += ButtonFight_MouseLeave;
            // 
            // LabelInventory
            // 
            LabelInventory.AutoSize = true;
            LabelInventory.Location = new Point(93, 45);
            LabelInventory.Name = "LabelInventory";
            LabelInventory.Size = new Size(38, 15);
            LabelInventory.TabIndex = 7;
            LabelInventory.Text = "label2";
            // 
            // LabelMove
            // 
            LabelMove.AutoSize = true;
            LabelMove.Location = new Point(93, 74);
            LabelMove.Name = "LabelMove";
            LabelMove.Size = new Size(38, 15);
            LabelMove.TabIndex = 8;
            LabelMove.Text = "label3";
            // 
            // LavelFight
            // 
            LavelFight.AutoSize = true;
            LavelFight.Location = new Point(93, 103);
            LavelFight.Name = "LavelFight";
            LavelFight.Size = new Size(38, 15);
            LavelFight.TabIndex = 9;
            LavelFight.Text = "label4";
            // 
            // LabelLoot
            // 
            LabelLoot.AutoSize = true;
            LabelLoot.Location = new Point(93, 132);
            LabelLoot.Name = "LabelLoot";
            LabelLoot.Size = new Size(38, 15);
            LabelLoot.TabIndex = 10;
            LabelLoot.Text = "label5";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 181);
            Controls.Add(Panel);
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dungeon Crawler";
            Panel.ResumeLayout(false);
            Panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Button ButtonInventory;
        private Button ButtonMove;
        private Button ButtonSave;
        private Button ButtonFight;
        private Button ButtonLoot;
        private Label LabelSave;
        private Label LabelLoot;
        private Label LavelFight;
        private Label LabelMove;
        private Label LabelInventory;
    }
}