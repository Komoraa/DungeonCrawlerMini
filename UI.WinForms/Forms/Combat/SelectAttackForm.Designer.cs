namespace UI.WinForms.Forms.Combat
{
    partial class SelectAttackForm
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
            ListBoxAttacks = new ListBox();
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
            // ListBoxAttacks
            // 
            ListBoxAttacks.FormattingEnabled = true;
            ListBoxAttacks.Location = new Point(93, 12);
            ListBoxAttacks.Name = "ListBoxAttacks";
            ListBoxAttacks.Size = new Size(270, 259);
            ListBoxAttacks.TabIndex = 2;
            // 
            // SelectAttackForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 286);
            Controls.Add(ListBoxAttacks);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonConfirm);
            Name = "SelectAttackForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose an Attack";
            Load += SelectAttackForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button ButtonConfirm;
        private Button ButtonCancel;
        private ListBox ListBoxAttacks;
    }
}