namespace UI.WinForms.Forms.Exploration
{
    partial class InspectPotionForm
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
            TextBoxName = new TextBox();
            RichTextBoxDescription = new RichTextBox();
            LabelDescription = new Label();
            ButtonBack = new Button();
            LabelHealth = new Label();
            ProgressBarHealth = new ProgressBar();
            LabelValue = new Label();
            TextBoxValue = new TextBox();
            SuspendLayout();
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(12, 12);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.ReadOnly = true;
            TextBoxName.Size = new Size(168, 23);
            TextBoxName.TabIndex = 0;
            // 
            // RichTextBoxDescription
            // 
            RichTextBoxDescription.Location = new Point(12, 85);
            RichTextBoxDescription.Name = "RichTextBoxDescription";
            RichTextBoxDescription.ReadOnly = true;
            RichTextBoxDescription.Size = new Size(168, 140);
            RichTextBoxDescription.TabIndex = 1;
            RichTextBoxDescription.Text = "";
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Location = new Point(12, 67);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(67, 15);
            LabelDescription.TabIndex = 3;
            LabelDescription.Text = "Description";
            // 
            // ButtonBack
            // 
            ButtonBack.Location = new Point(12, 231);
            ButtonBack.Name = "ButtonBack";
            ButtonBack.Size = new Size(75, 23);
            ButtonBack.TabIndex = 5;
            ButtonBack.Text = "Back";
            ButtonBack.UseVisualStyleBackColor = true;
            ButtonBack.Click += ButtonBack_Click;
            // 
            // LabelHealth
            // 
            LabelHealth.AutoSize = true;
            LabelHealth.Location = new Point(186, 88);
            LabelHealth.Name = "LabelHealth";
            LabelHealth.Size = new Size(42, 15);
            LabelHealth.TabIndex = 7;
            LabelHealth.Text = "Health";
            // 
            // ProgressBarHealth
            // 
            ProgressBarHealth.Location = new Point(234, 85);
            ProgressBarHealth.Name = "ProgressBarHealth";
            ProgressBarHealth.Size = new Size(120, 23);
            ProgressBarHealth.TabIndex = 9;
            // 
            // LabelValue
            // 
            LabelValue.AutoSize = true;
            LabelValue.Location = new Point(12, 44);
            LabelValue.Name = "LabelValue";
            LabelValue.Size = new Size(35, 15);
            LabelValue.TabIndex = 10;
            LabelValue.Text = "Value";
            // 
            // TextBoxValue
            // 
            TextBoxValue.Location = new Point(60, 41);
            TextBoxValue.Name = "TextBoxValue";
            TextBoxValue.ReadOnly = true;
            TextBoxValue.Size = new Size(120, 23);
            TextBoxValue.TabIndex = 11;
            // 
            // InspectPotionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 264);
            Controls.Add(TextBoxValue);
            Controls.Add(LabelValue);
            Controls.Add(ProgressBarHealth);
            Controls.Add(LabelHealth);
            Controls.Add(ButtonBack);
            Controls.Add(LabelDescription);
            Controls.Add(RichTextBoxDescription);
            Controls.Add(TextBoxName);
            Name = "InspectPotionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Potion";
            Load += InspectPotionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxName;
        private RichTextBox RichTextBoxDescription;
        private Label LabelDescription;
        private Button ButtonBack;
        private Label LabelHealth;
        private ProgressBar ProgressBarHealth;
        private Label LabelValue;
        private TextBox TextBoxValue;
    }
}