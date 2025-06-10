namespace UI.WinForms.Forms.Exploration.InspectItem
{
    partial class InspectArmorForm
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
            TextBoxValue = new TextBox();
            LabelValue = new Label();
            ButtonBack = new Button();
            LabelDescription = new Label();
            RichTextBoxDescription = new RichTextBox();
            TextBoxName = new TextBox();
            LabelAC = new Label();
            TextBoxAC = new TextBox();
            SuspendLayout();
            // 
            // TextBoxValue
            // 
            TextBoxValue.Location = new Point(60, 41);
            TextBoxValue.Name = "TextBoxValue";
            TextBoxValue.ReadOnly = true;
            TextBoxValue.Size = new Size(120, 23);
            TextBoxValue.TabIndex = 27;
            // 
            // LabelValue
            // 
            LabelValue.AutoSize = true;
            LabelValue.Location = new Point(12, 44);
            LabelValue.Name = "LabelValue";
            LabelValue.Size = new Size(35, 15);
            LabelValue.TabIndex = 26;
            LabelValue.Text = "Value";
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 231);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(75, 23);
            ButtonBack.TabIndex = 23;
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
            LabelDescription.TabIndex = 22;
            LabelDescription.Text = "Description";
            // 
            // RichTextBoxDescription
            // 
            RichTextBoxDescription.Location = new Point(12, 85);
            RichTextBoxDescription.Name = "RichTextBoxDescription";
            RichTextBoxDescription.ReadOnly = true;
            RichTextBoxDescription.Size = new Size(168, 140);
            RichTextBoxDescription.TabIndex = 21;
            RichTextBoxDescription.Text = "";
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(12, 12);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.ReadOnly = true;
            TextBoxName.Size = new Size(168, 23);
            TextBoxName.TabIndex = 20;
            // 
            // LabelAC
            // 
            LabelAC.AutoSize = true;
            LabelAC.Location = new Point(186, 88);
            LabelAC.Name = "LabelAC";
            LabelAC.Size = new Size(23, 15);
            LabelAC.TabIndex = 28;
            LabelAC.Text = "AC";
            // 
            // TextBoxAC
            // 
            TextBoxAC.Location = new Point(215, 85);
            TextBoxAC.Name = "TextBoxAC";
            TextBoxAC.ReadOnly = true;
            TextBoxAC.Size = new Size(100, 23);
            TextBoxAC.TabIndex = 31;
            // 
            // InspectArmorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 266);
            Controls.Add(TextBoxAC);
            Controls.Add(LabelAC);
            Controls.Add(TextBoxValue);
            Controls.Add(LabelValue);
            Controls.Add(ButtonBack);
            Controls.Add(LabelDescription);
            Controls.Add(RichTextBoxDescription);
            Controls.Add(TextBoxName);
            Name = "InspectArmorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Armor";
            Load += InspectArmorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxValue;
        private Label LabelValue;
        private Button ButtonBack;
        private Label LabelDescription;
        private RichTextBox RichTextBoxDescription;
        private TextBox TextBoxName;
        private Label LabelAC;
        private TextBox TextBoxAC;
    }
}