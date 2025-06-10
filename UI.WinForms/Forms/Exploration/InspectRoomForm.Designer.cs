namespace UI.WinForms.Forms
{
    partial class InspectRoomForm
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
            ListBoxEnemies = new ListBox();
            ListBoxItems = new ListBox();
            GroupBoxEnemies = new GroupBox();
            GroupBoxItems = new GroupBox();
            GroupBoxRooms = new GroupBox();
            ListBoxRooms = new ListBox();
            ButtonBack = new Button();
            TextBoxName = new TextBox();
            GroupBoxEnemies.SuspendLayout();
            GroupBoxItems.SuspendLayout();
            GroupBoxRooms.SuspendLayout();
            SuspendLayout();
            // 
            // ListBoxEnemies
            // 
            ListBoxEnemies.FormattingEnabled = true;
            ListBoxEnemies.Location = new Point(6, 22);
            ListBoxEnemies.Name = "ListBoxEnemies";
            ListBoxEnemies.Size = new Size(188, 124);
            ListBoxEnemies.TabIndex = 0;
            // 
            // ListBoxItems
            // 
            ListBoxItems.FormattingEnabled = true;
            ListBoxItems.Location = new Point(6, 22);
            ListBoxItems.Name = "ListBoxItems";
            ListBoxItems.Size = new Size(188, 124);
            ListBoxItems.TabIndex = 1;
            // 
            // GroupBoxEnemies
            // 
            GroupBoxEnemies.Controls.Add(ListBoxEnemies);
            GroupBoxEnemies.Location = new Point(12, 41);
            GroupBoxEnemies.Name = "GroupBoxEnemies";
            GroupBoxEnemies.Size = new Size(200, 158);
            GroupBoxEnemies.TabIndex = 2;
            GroupBoxEnemies.TabStop = false;
            GroupBoxEnemies.Text = "Enemies";
            // 
            // GroupBoxItems
            // 
            GroupBoxItems.Controls.Add(ListBoxItems);
            GroupBoxItems.Location = new Point(218, 41);
            GroupBoxItems.Name = "GroupBoxItems";
            GroupBoxItems.Size = new Size(200, 158);
            GroupBoxItems.TabIndex = 3;
            GroupBoxItems.TabStop = false;
            GroupBoxItems.Text = "Items";
            // 
            // GroupBoxRooms
            // 
            GroupBoxRooms.Controls.Add(ListBoxRooms);
            GroupBoxRooms.Location = new Point(424, 41);
            GroupBoxRooms.Name = "GroupBoxRooms";
            GroupBoxRooms.Size = new Size(200, 158);
            GroupBoxRooms.TabIndex = 4;
            GroupBoxRooms.TabStop = false;
            GroupBoxRooms.Text = "Adjacent Rooms";
            // 
            // ListBoxRooms
            // 
            ListBoxRooms.FormattingEnabled = true;
            ListBoxRooms.Location = new Point(6, 22);
            ListBoxRooms.Name = "ListBoxRooms";
            ListBoxRooms.Size = new Size(188, 124);
            ListBoxRooms.TabIndex = 0;
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 205);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(75, 23);
            ButtonBack.TabIndex = 5;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(12, 12);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(120, 23);
            TextBoxName.TabIndex = 6;
            // 
            // InspectRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 240);
            Controls.Add(TextBoxName);
            Controls.Add(ButtonBack);
            Controls.Add(GroupBoxRooms);
            Controls.Add(GroupBoxItems);
            Controls.Add(GroupBoxEnemies);
            Name = "InspectRoomForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room Inspection";
            Load += InspectRoomForm_Load;
            GroupBoxEnemies.ResumeLayout(false);
            GroupBoxItems.ResumeLayout(false);
            GroupBoxRooms.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListBoxEnemies;
        private ListBox ListBoxItems;
        private GroupBox GroupBoxEnemies;
        private GroupBox GroupBoxItems;
        private GroupBox GroupBoxRooms;
        private ListBox ListBoxRooms;
        private Button ButtonBack;
        private TextBox TextBoxName;
    }
}