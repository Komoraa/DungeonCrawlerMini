namespace UI.WinForms.Forms.Combat
{
    partial class SelectItemForm
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
            ListBoxInventory = new ListBox();
            ButtonConfirm = new Button();
            ButtonCancel = new Button();
            SuspendLayout();
            // 
            // ListBoxInventory
            // 
            ListBoxInventory.FormattingEnabled = true;
            ListBoxInventory.Location = new Point(93, 12);
            ListBoxInventory.Name = "ListBoxInventory";
            ListBoxInventory.Size = new Size(259, 259);
            ListBoxInventory.TabIndex = 0;
            // 
            // ButtonConfirm
            // 
            ButtonConfirm.Location = new Point(12, 12);
            ButtonConfirm.Name = "ButtonConfirm";
            ButtonConfirm.Size = new Size(75, 23);
            ButtonConfirm.TabIndex = 1;
            ButtonConfirm.Text = "Confirm";
            ButtonConfirm.UseVisualStyleBackColor = true;
            ButtonConfirm.Click += ButtonConfirm_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Location = new Point(12, 41);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(75, 23);
            ButtonCancel.TabIndex = 2;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // SelectItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(364, 286);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonConfirm);
            Controls.Add(ListBoxInventory);
            Name = "SelectItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Choose an Item";
            Load += SelectItemForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListBoxInventory;
        private Button ButtonConfirm;
        private Button ButtonCancel;
    }
}