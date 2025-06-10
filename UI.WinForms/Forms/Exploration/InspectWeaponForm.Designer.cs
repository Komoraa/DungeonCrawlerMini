namespace UI.WinForms.Forms.Exploration
{
    partial class InspectWeaponForm
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
            ButtonBack = new Button();
            LabelDescription = new Label();
            RichTextBoxDescription = new RichTextBox();
            TextBoxName = new TextBox();
            ListBoxAttacks = new ListBox();
            LabelAttacks = new Label();
            TextBoxValue = new TextBox();
            LabelValue = new Label();
            SuspendLayout();
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 231);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(75, 23);
            ButtonBack.TabIndex = 13;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Location = new Point(12, 67);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(67, 15);
            LabelDescription.TabIndex = 11;
            LabelDescription.Text = "Description";
            // 
            // RichTextBoxDescription
            // 
            RichTextBoxDescription.Location = new Point(12, 85);
            RichTextBoxDescription.Name = "RichTextBoxDescription";
            RichTextBoxDescription.ReadOnly = true;
            RichTextBoxDescription.Size = new Size(168, 140);
            RichTextBoxDescription.TabIndex = 9;
            RichTextBoxDescription.Text = "";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(12, 12);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.ReadOnly = true;
            TextBoxName.Size = new Size(168, 23);
            TextBoxName.TabIndex = 8;
            // 
            // ListBoxAttacks
            // 
            ListBoxAttacks.FormattingEnabled = true;
            ListBoxAttacks.Location = new Point(186, 85);
            ListBoxAttacks.Name = "ListBoxAttacks";
            ListBoxAttacks.Size = new Size(186, 139);
            ListBoxAttacks.TabIndex = 16;
            // 
            // LabelAttacks
            // 
            LabelAttacks.AutoSize = true;
            LabelAttacks.Location = new Point(186, 67);
            LabelAttacks.Name = "LabelAttacks";
            LabelAttacks.Size = new Size(46, 15);
            LabelAttacks.TabIndex = 17;
            LabelAttacks.Text = "Attacks";
            // 
            // TextBoxValue
            // 
            TextBoxValue.Location = new Point(60, 41);
            TextBoxValue.Name = "TextBoxValue";
            TextBoxValue.ReadOnly = true;
            TextBoxValue.Size = new Size(120, 23);
            TextBoxValue.TabIndex = 19;
            // 
            // LabelValue
            // 
            LabelValue.AutoSize = true;
            LabelValue.Location = new Point(12, 44);
            LabelValue.Name = "LabelValue";
            LabelValue.Size = new Size(35, 15);
            LabelValue.TabIndex = 18;
            LabelValue.Text = "Value";
            // 
            // InspectWeaponForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 265);
            Controls.Add(TextBoxValue);
            Controls.Add(LabelValue);
            Controls.Add(LabelAttacks);
            Controls.Add(ListBoxAttacks);
            Controls.Add(ButtonBack);
            Controls.Add(LabelDescription);
            Controls.Add(RichTextBoxDescription);
            Controls.Add(TextBoxName);
            Name = "InspectWeaponForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Weapon";
            Load += InspectWeaponForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button ButtonBack;
        private Label LabelDescription;
        private RichTextBox RichTextBoxDescription;
        private TextBox TextBoxName;
        private ListBox ListBoxAttacks;
        private Label LabelAttacks;
        private TextBox TextBoxValue;
        private Label LabelValue;
    }
}