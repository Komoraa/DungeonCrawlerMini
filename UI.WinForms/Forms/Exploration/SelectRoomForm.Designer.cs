namespace UI.WinForms.Forms;

partial class SelectRoomForm
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
        ListBoxRooms = new ListBox();
        ButtonCancel = new Button();
        ButtonConfirm = new Button();
        SuspendLayout();
        // 
        // ListBoxRooms
        // 
        ListBoxRooms.FormattingEnabled = true;
        ListBoxRooms.Location = new Point(93, 12);
        ListBoxRooms.Name = "ListBoxRooms";
        ListBoxRooms.Size = new Size(204, 259);
        ListBoxRooms.TabIndex = 5;
        // 
        // ButtonCancel
        // 
        ButtonCancel.Location = new Point(12, 41);
        ButtonCancel.Name = "ButtonCancel";
        ButtonCancel.Size = new Size(75, 23);
        ButtonCancel.TabIndex = 4;
        ButtonCancel.Text = "Cancel";
        ButtonCancel.UseVisualStyleBackColor = true;
        // 
        // ButtonConfirm
        // 
        ButtonConfirm.Location = new Point(12, 12);
        ButtonConfirm.Name = "ButtonConfirm";
        ButtonConfirm.Size = new Size(75, 23);
        ButtonConfirm.TabIndex = 3;
        ButtonConfirm.Text = "Confirm";
        ButtonConfirm.UseVisualStyleBackColor = true;
        // 
        // SelectRoomForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(310, 285);
        Controls.Add(ListBoxRooms);
        Controls.Add(ButtonCancel);
        Controls.Add(ButtonConfirm);
        Name = "SelectRoomForm";
        Text = "Go Where?";
        ResumeLayout(false);
    }

    #endregion

    private ListBox ListBoxRooms;
    private Button ButtonCancel;
    private Button ButtonConfirm;
}