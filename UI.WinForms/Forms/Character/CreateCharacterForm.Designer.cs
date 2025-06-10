namespace UI.WinForms.Forms.Character
{
    partial class CreateCharacterForm
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
            NumericStrength = new NumericUpDown();
            NumericDexterity = new NumericUpDown();
            NumericIntelligence = new NumericUpDown();
            NumericPerception = new NumericUpDown();
            LabelName = new Label();
            LabelStr = new Label();
            LabelDex = new Label();
            LabelInt = new Label();
            LabelPer = new Label();
            RichTextBoxDescription = new RichTextBox();
            LabelDescription = new Label();
            GroupBoxGeneral = new GroupBox();
            GroupBoxStartingInventory = new GroupBox();
            GroupBoxAbilityScores = new GroupBox();
            ListBoxInventory = new ListBox();
            ButtonConfirm = new Button();
            NumericPP = new NumericUpDown();
            LabelPP = new Label();
            LabelGP = new Label();
            LabelSP = new Label();
            LabelCP = new Label();
            NumericGP = new NumericUpDown();
            NumericSP = new NumericUpDown();
            NumericCP = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NumericStrength).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericDexterity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericIntelligence).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericPerception).BeginInit();
            GroupBoxGeneral.SuspendLayout();
            GroupBoxStartingInventory.SuspendLayout();
            GroupBoxAbilityScores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericPP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericGP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericSP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericCP).BeginInit();
            SuspendLayout();
            // 
            // TextBoxName
            // 
            TextBoxName.Location = new Point(51, 22);
            TextBoxName.Name = "TextBoxName";
            TextBoxName.Size = new Size(120, 23);
            TextBoxName.TabIndex = 0;
            // 
            // NumericStrength
            // 
            NumericStrength.Location = new Point(38, 22);
            NumericStrength.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            NumericStrength.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            NumericStrength.Name = "NumericStrength";
            NumericStrength.ReadOnly = true;
            NumericStrength.Size = new Size(40, 23);
            NumericStrength.TabIndex = 1;
            NumericStrength.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // NumericDexterity
            // 
            NumericDexterity.Location = new Point(38, 51);
            NumericDexterity.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            NumericDexterity.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            NumericDexterity.Name = "NumericDexterity";
            NumericDexterity.ReadOnly = true;
            NumericDexterity.Size = new Size(40, 23);
            NumericDexterity.TabIndex = 2;
            NumericDexterity.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // NumericIntelligence
            // 
            NumericIntelligence.Location = new Point(38, 80);
            NumericIntelligence.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            NumericIntelligence.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            NumericIntelligence.Name = "NumericIntelligence";
            NumericIntelligence.ReadOnly = true;
            NumericIntelligence.Size = new Size(40, 23);
            NumericIntelligence.TabIndex = 3;
            NumericIntelligence.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // NumericPerception
            // 
            NumericPerception.Location = new Point(38, 109);
            NumericPerception.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            NumericPerception.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            NumericPerception.Name = "NumericPerception";
            NumericPerception.ReadOnly = true;
            NumericPerception.Size = new Size(40, 23);
            NumericPerception.TabIndex = 4;
            NumericPerception.Value = new decimal(new int[] { 8, 0, 0, 0 });
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Location = new Point(6, 25);
            LabelName.Name = "LabelName";
            LabelName.Size = new Size(39, 15);
            LabelName.TabIndex = 5;
            LabelName.Text = "Name";
            // 
            // LabelStr
            // 
            LabelStr.AutoSize = true;
            LabelStr.Location = new Point(6, 25);
            LabelStr.Name = "LabelStr";
            LabelStr.Size = new Size(21, 15);
            LabelStr.TabIndex = 6;
            LabelStr.Text = "Str";
            // 
            // LabelDex
            // 
            LabelDex.AutoSize = true;
            LabelDex.Location = new Point(6, 53);
            LabelDex.Name = "LabelDex";
            LabelDex.Size = new Size(26, 15);
            LabelDex.TabIndex = 7;
            LabelDex.Text = "Dex";
            // 
            // LabelInt
            // 
            LabelInt.AutoSize = true;
            LabelInt.Location = new Point(6, 82);
            LabelInt.Name = "LabelInt";
            LabelInt.Size = new Size(21, 15);
            LabelInt.TabIndex = 8;
            LabelInt.Text = "Int";
            // 
            // LabelPer
            // 
            LabelPer.AutoSize = true;
            LabelPer.Location = new Point(6, 111);
            LabelPer.Name = "LabelPer";
            LabelPer.Size = new Size(24, 15);
            LabelPer.TabIndex = 9;
            LabelPer.Text = "Per";
            // 
            // RichTextBoxDescription
            // 
            RichTextBoxDescription.Location = new Point(6, 66);
            RichTextBoxDescription.Name = "RichTextBoxDescription";
            RichTextBoxDescription.Size = new Size(165, 118);
            RichTextBoxDescription.TabIndex = 10;
            RichTextBoxDescription.Text = "";
            // 
            // LabelDescription
            // 
            LabelDescription.AutoSize = true;
            LabelDescription.Location = new Point(6, 48);
            LabelDescription.Name = "LabelDescription";
            LabelDescription.Size = new Size(67, 15);
            LabelDescription.TabIndex = 11;
            LabelDescription.Text = "Description";
            // 
            // GroupBoxGeneral
            // 
            GroupBoxGeneral.Controls.Add(TextBoxName);
            GroupBoxGeneral.Controls.Add(LabelName);
            GroupBoxGeneral.Controls.Add(RichTextBoxDescription);
            GroupBoxGeneral.Controls.Add(LabelDescription);
            GroupBoxGeneral.Location = new Point(12, 12);
            GroupBoxGeneral.Name = "GroupBoxGeneral";
            GroupBoxGeneral.Size = new Size(180, 190);
            GroupBoxGeneral.TabIndex = 12;
            GroupBoxGeneral.TabStop = false;
            GroupBoxGeneral.Text = "General Information";
            // 
            // GroupBoxStartingInventory
            // 
            GroupBoxStartingInventory.Controls.Add(NumericGP);
            GroupBoxStartingInventory.Controls.Add(NumericSP);
            GroupBoxStartingInventory.Controls.Add(NumericCP);
            GroupBoxStartingInventory.Controls.Add(NumericPP);
            GroupBoxStartingInventory.Controls.Add(LabelGP);
            GroupBoxStartingInventory.Controls.Add(LabelPP);
            GroupBoxStartingInventory.Controls.Add(LabelCP);
            GroupBoxStartingInventory.Controls.Add(LabelSP);
            GroupBoxStartingInventory.Controls.Add(ListBoxInventory);
            GroupBoxStartingInventory.Location = new Point(299, 12);
            GroupBoxStartingInventory.Name = "GroupBoxStartingInventory";
            GroupBoxStartingInventory.Size = new Size(257, 187);
            GroupBoxStartingInventory.TabIndex = 13;
            GroupBoxStartingInventory.TabStop = false;
            GroupBoxStartingInventory.Text = "Starting Inventory";
            // 
            // GroupBoxAbilityScores
            // 
            GroupBoxAbilityScores.Controls.Add(LabelStr);
            GroupBoxAbilityScores.Controls.Add(NumericStrength);
            GroupBoxAbilityScores.Controls.Add(NumericDexterity);
            GroupBoxAbilityScores.Controls.Add(LabelPer);
            GroupBoxAbilityScores.Controls.Add(NumericIntelligence);
            GroupBoxAbilityScores.Controls.Add(LabelInt);
            GroupBoxAbilityScores.Controls.Add(NumericPerception);
            GroupBoxAbilityScores.Controls.Add(LabelDex);
            GroupBoxAbilityScores.Location = new Point(198, 12);
            GroupBoxAbilityScores.Name = "GroupBoxAbilityScores";
            GroupBoxAbilityScores.Size = new Size(95, 144);
            GroupBoxAbilityScores.TabIndex = 14;
            GroupBoxAbilityScores.TabStop = false;
            GroupBoxAbilityScores.Text = "Ability Scores";
            // 
            // ListBoxInventory
            // 
            ListBoxInventory.FormattingEnabled = true;
            ListBoxInventory.Location = new Point(6, 22);
            ListBoxInventory.Name = "ListBoxInventory";
            ListBoxInventory.Size = new Size(166, 154);
            ListBoxInventory.TabIndex = 0;
            // 
            // ButtonConfirm
            // 
            ButtonConfirm.Location = new Point(12, 212);
            ButtonConfirm.Name = "ButtonConfirm";
            ButtonConfirm.Size = new Size(75, 23);
            ButtonConfirm.TabIndex = 15;
            ButtonConfirm.Text = "Confirm";
            ButtonConfirm.UseVisualStyleBackColor = true;
            // 
            // NumericPP
            // 
            NumericPP.Location = new Point(205, 22);
            NumericPP.Name = "NumericPP";
            NumericPP.ReadOnly = true;
            NumericPP.Size = new Size(40, 23);
            NumericPP.TabIndex = 1;
            // 
            // LabelPP
            // 
            LabelPP.AutoSize = true;
            LabelPP.Location = new Point(178, 25);
            LabelPP.Name = "LabelPP";
            LabelPP.Size = new Size(21, 15);
            LabelPP.TabIndex = 1;
            LabelPP.Text = "PP";
            // 
            // LabelGP
            // 
            LabelGP.AutoSize = true;
            LabelGP.Location = new Point(178, 53);
            LabelGP.Name = "LabelGP";
            LabelGP.Size = new Size(22, 15);
            LabelGP.TabIndex = 2;
            LabelGP.Text = "GP";
            // 
            // LabelSP
            // 
            LabelSP.AutoSize = true;
            LabelSP.Location = new Point(178, 82);
            LabelSP.Name = "LabelSP";
            LabelSP.Size = new Size(20, 15);
            LabelSP.TabIndex = 3;
            LabelSP.Text = "SP";
            // 
            // LabelCP
            // 
            LabelCP.AutoSize = true;
            LabelCP.Location = new Point(178, 111);
            LabelCP.Name = "LabelCP";
            LabelCP.Size = new Size(22, 15);
            LabelCP.TabIndex = 4;
            LabelCP.Text = "CP";
            // 
            // NumericGP
            // 
            NumericGP.Location = new Point(205, 51);
            NumericGP.Name = "NumericGP";
            NumericGP.ReadOnly = true;
            NumericGP.Size = new Size(40, 23);
            NumericGP.TabIndex = 16;
            NumericGP.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // NumericSP
            // 
            NumericSP.Location = new Point(205, 80);
            NumericSP.Name = "NumericSP";
            NumericSP.ReadOnly = true;
            NumericSP.Size = new Size(40, 23);
            NumericSP.TabIndex = 17;
            NumericSP.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // NumericCP
            // 
            NumericCP.Location = new Point(205, 109);
            NumericCP.Name = "NumericCP";
            NumericCP.ReadOnly = true;
            NumericCP.Size = new Size(40, 23);
            NumericCP.TabIndex = 18;
            // 
            // CreateCharacterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 247);
            Controls.Add(ButtonConfirm);
            Controls.Add(GroupBoxAbilityScores);
            Controls.Add(GroupBoxStartingInventory);
            Controls.Add(GroupBoxGeneral);
            Name = "CreateCharacterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create a Character";
            ((System.ComponentModel.ISupportInitialize)NumericStrength).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericDexterity).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericIntelligence).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericPerception).EndInit();
            GroupBoxGeneral.ResumeLayout(false);
            GroupBoxGeneral.PerformLayout();
            GroupBoxStartingInventory.ResumeLayout(false);
            GroupBoxStartingInventory.PerformLayout();
            GroupBoxAbilityScores.ResumeLayout(false);
            GroupBoxAbilityScores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericPP).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericGP).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericSP).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericCP).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox TextBoxName;
        private NumericUpDown NumericStrength;
        private NumericUpDown NumericDexterity;
        private NumericUpDown NumericIntelligence;
        private NumericUpDown NumericPerception;
        private Label LabelName;
        private Label LabelStr;
        private Label LabelDex;
        private Label LabelInt;
        private Label LabelPer;
        private RichTextBox RichTextBoxDescription;
        private Label LabelDescription;
        private GroupBox GroupBoxGeneral;
        private GroupBox GroupBoxStartingInventory;
        private GroupBox GroupBoxAbilityScores;
        private ListBox ListBoxInventory;
        private Button ButtonConfirm;
        private NumericUpDown NumericGP;
        private NumericUpDown NumericSP;
        private NumericUpDown NumericCP;
        private NumericUpDown NumericPP;
        private Label LabelGP;
        private Label LabelPP;
        private Label LabelCP;
        private Label LabelSP;
    }
}