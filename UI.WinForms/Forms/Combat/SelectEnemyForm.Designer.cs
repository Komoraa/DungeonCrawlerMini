namespace UI.WinForms.Forms.Combat
{
    partial class SelectEnemyForm
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
            ButtonConfirm = new Button();
            ButtonCancel = new Button();
            ListBoxEnemies = new ListBox();
            SuspendLayout();
            // 
            // ButtonConfirm
            // 
            ButtonConfirm.Location = new Point(12, 12);
            ButtonConfirm.Name = "ButtonConfirm";
            ButtonConfirm.Size = new Size(75, 23);
            ButtonConfirm.TabIndex = 0;
            ButtonConfirm.Text = "Confirm";
            ButtonConfirm.UseVisualStyleBackColor = true;
            ButtonConfirm.Click += ButtonConfirm_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(12, 41);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(75, 23);
            ButtonCancel.TabIndex = 1;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // ListBoxEnemies
            // 
            ListBoxEnemies.FormattingEnabled = true;
            ListBoxEnemies.Location = new Point(93, 12);
            ListBoxEnemies.Name = "ListBoxEnemies";
            ListBoxEnemies.Size = new Size(242, 259);
            ListBoxEnemies.TabIndex = 2;
            // 
            // SelectEnemyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 286);
            Controls.Add(ListBoxEnemies);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonConfirm);
            Name = "SelectEnemyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose an Opponent";
            Load += SelectEnemyForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonConfirm;
        private Button ButtonCancel;
        private ListBox ListBoxEnemies;
    }
}