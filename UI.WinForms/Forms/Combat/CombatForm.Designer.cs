namespace UI.WinForms.Forms;

partial class CombatForm
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
        progressBar1 = new ProgressBar();
        progressBar2 = new ProgressBar();
        LabelPlayerHealth = new Label();
        LabelEnemyHealth = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        ListBoxRecap = new ListBox();
        GroupBoxEnemy = new GroupBox();
        TextBoxEnemyAC = new TextBox();
        LabelEnemyAC = new Label();
        GroupBoxPlayer = new GroupBox();
        TextBoxPlayerAC = new TextBox();
        LabelPlayerAC = new Label();
        ButtonEndTurn = new Button();
        ButtonItem = new Button();
        ButtonAttack = new Button();
        GroupBoxRecap = new GroupBox();
        GroupBoxEnemy.SuspendLayout();
        GroupBoxPlayer.SuspendLayout();
        GroupBoxRecap.SuspendLayout();
        SuspendLayout();
        // 
        // progressBar1
        // 
        progressBar1.Location = new Point(54, 51);
        progressBar1.Name = "progressBar1";
        progressBar1.Size = new Size(100, 23);
        progressBar1.TabIndex = 0;
        // 
        // progressBar2
        // 
        progressBar2.Location = new Point(54, 51);
        progressBar2.Name = "progressBar2";
        progressBar2.Size = new Size(100, 23);
        progressBar2.TabIndex = 1;
        // 
        // LabelPlayerHealth
        // 
        LabelPlayerHealth.AutoSize = true;
        LabelPlayerHealth.Location = new Point(6, 54);
        LabelPlayerHealth.Name = "LabelPlayerHealth";
        LabelPlayerHealth.Size = new Size(42, 15);
        LabelPlayerHealth.TabIndex = 2;
        LabelPlayerHealth.Text = "Health";
        // 
        // LabelEnemyHealth
        // 
        LabelEnemyHealth.AutoSize = true;
        LabelEnemyHealth.Location = new Point(6, 54);
        LabelEnemyHealth.Name = "LabelEnemyHealth";
        LabelEnemyHealth.Size = new Size(42, 15);
        LabelEnemyHealth.TabIndex = 3;
        LabelEnemyHealth.Text = "Health";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(6, 22);
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(148, 23);
        textBox1.TabIndex = 4;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(6, 22);
        textBox2.Name = "textBox2";
        textBox2.ReadOnly = true;
        textBox2.Size = new Size(148, 23);
        textBox2.TabIndex = 5;
        // 
        // ListBoxRecap
        // 
        ListBoxRecap.FormattingEnabled = true;
        ListBoxRecap.Location = new Point(6, 22);
        ListBoxRecap.Name = "ListBoxRecap";
        ListBoxRecap.Size = new Size(219, 304);
        ListBoxRecap.TabIndex = 6;
        // 
        // GroupBoxEnemy
        // 
        GroupBoxEnemy.Controls.Add(TextBoxEnemyAC);
        GroupBoxEnemy.Controls.Add(LabelEnemyAC);
        GroupBoxEnemy.Controls.Add(textBox1);
        GroupBoxEnemy.Controls.Add(progressBar1);
        GroupBoxEnemy.Controls.Add(LabelEnemyHealth);
        GroupBoxEnemy.Location = new Point(12, 12);
        GroupBoxEnemy.Name = "GroupBoxEnemy";
        GroupBoxEnemy.Size = new Size(168, 121);
        GroupBoxEnemy.TabIndex = 7;
        GroupBoxEnemy.TabStop = false;
        GroupBoxEnemy.Text = "Enemy";
        // 
        // TextBoxEnemyAC
        // 
        TextBoxEnemyAC.Location = new Point(54, 80);
        TextBoxEnemyAC.Name = "TextBoxEnemyAC";
        TextBoxEnemyAC.ReadOnly = true;
        TextBoxEnemyAC.Size = new Size(100, 23);
        TextBoxEnemyAC.TabIndex = 6;
        // 
        // LabelEnemyAC
        // 
        LabelEnemyAC.AutoSize = true;
        LabelEnemyAC.Location = new Point(8, 83);
        LabelEnemyAC.Name = "LabelEnemyAC";
        LabelEnemyAC.Size = new Size(23, 15);
        LabelEnemyAC.TabIndex = 5;
        LabelEnemyAC.Text = "AC";
        // 
        // GroupBoxPlayer
        // 
        GroupBoxPlayer.Controls.Add(TextBoxPlayerAC);
        GroupBoxPlayer.Controls.Add(LabelPlayerAC);
        GroupBoxPlayer.Controls.Add(ButtonEndTurn);
        GroupBoxPlayer.Controls.Add(ButtonItem);
        GroupBoxPlayer.Controls.Add(ButtonAttack);
        GroupBoxPlayer.Controls.Add(textBox2);
        GroupBoxPlayer.Controls.Add(progressBar2);
        GroupBoxPlayer.Controls.Add(LabelPlayerHealth);
        GroupBoxPlayer.Location = new Point(12, 139);
        GroupBoxPlayer.Name = "GroupBoxPlayer";
        GroupBoxPlayer.Size = new Size(168, 212);
        GroupBoxPlayer.TabIndex = 8;
        GroupBoxPlayer.TabStop = false;
        GroupBoxPlayer.Text = "You";
        // 
        // TextBoxPlayerAC
        // 
        TextBoxPlayerAC.Location = new Point(54, 80);
        TextBoxPlayerAC.Name = "TextBoxPlayerAC";
        TextBoxPlayerAC.ReadOnly = true;
        TextBoxPlayerAC.Size = new Size(100, 23);
        TextBoxPlayerAC.TabIndex = 10;
        // 
        // LabelPlayerAC
        // 
        LabelPlayerAC.AutoSize = true;
        LabelPlayerAC.Location = new Point(6, 83);
        LabelPlayerAC.Name = "LabelPlayerAC";
        LabelPlayerAC.Size = new Size(23, 15);
        LabelPlayerAC.TabIndex = 9;
        LabelPlayerAC.Text = "AC";
        // 
        // ButtonEndTurn
        // 
        ButtonEndTurn.Location = new Point(6, 183);
        ButtonEndTurn.Name = "ButtonEndTurn";
        ButtonEndTurn.Size = new Size(75, 23);
        ButtonEndTurn.TabIndex = 8;
        ButtonEndTurn.Text = "End Turn";
        ButtonEndTurn.UseVisualStyleBackColor = true;
        // 
        // ButtonItem
        // 
        ButtonItem.Location = new Point(6, 154);
        ButtonItem.Name = "ButtonItem";
        ButtonItem.Size = new Size(75, 23);
        ButtonItem.TabIndex = 7;
        ButtonItem.Text = "Item";
        ButtonItem.UseVisualStyleBackColor = true;
        // 
        // ButtonAttack
        // 
        ButtonAttack.Location = new Point(6, 125);
        ButtonAttack.Name = "ButtonAttack";
        ButtonAttack.Size = new Size(75, 23);
        ButtonAttack.TabIndex = 6;
        ButtonAttack.Text = "Attack";
        ButtonAttack.UseVisualStyleBackColor = true;
        // 
        // GroupBoxRecap
        // 
        GroupBoxRecap.Controls.Add(ListBoxRecap);
        GroupBoxRecap.Location = new Point(186, 12);
        GroupBoxRecap.Name = "GroupBoxRecap";
        GroupBoxRecap.Size = new Size(231, 339);
        GroupBoxRecap.TabIndex = 9;
        GroupBoxRecap.TabStop = false;
        GroupBoxRecap.Text = "Recap";
        // 
        // CombatForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(429, 363);
        Controls.Add(GroupBoxRecap);
        Controls.Add(GroupBoxPlayer);
        Controls.Add(GroupBoxEnemy);
        Name = "CombatForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Combat";
        GroupBoxEnemy.ResumeLayout(false);
        GroupBoxEnemy.PerformLayout();
        GroupBoxPlayer.ResumeLayout(false);
        GroupBoxPlayer.PerformLayout();
        GroupBoxRecap.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private ProgressBar progressBar1;
    private ProgressBar progressBar2;
    private Label LabelPlayerHealth;
    private Label LabelEnemyHealth;
    private TextBox textBox1;
    private TextBox textBox2;
    private ListBox ListBoxRecap;
    private GroupBox GroupBoxEnemy;
    private GroupBox GroupBoxPlayer;
    private GroupBox GroupBoxRecap;
    private Button ButtonEndTurn;
    private Button ButtonItem;
    private Button ButtonAttack;
    private TextBox TextBoxEnemyAC;
    private Label LabelEnemyAC;
    private TextBox TextBoxPlayerAC;
    private Label LabelPlayerAC;
}