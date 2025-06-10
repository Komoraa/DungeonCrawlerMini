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
        ProgressBarEnemyHealth = new ProgressBar();
        ProgressBarPlayerHealth = new ProgressBar();
        LabelPlayerHealth = new Label();
        LabelEnemyHealth = new Label();
        TextBoxEnemyName = new TextBox();
        TextBoxPlayerName = new TextBox();
        GroupBoxEnemy = new GroupBox();
        TextBoxEnemyAC = new TextBox();
        LabelEnemyAC = new Label();
        GroupBoxPlayer = new GroupBox();
        TextBoxPlayerAC = new TextBox();
        LabelPlayerAC = new Label();
        ButtonEndTurn = new Button();
        ButtonItem = new Button();
        ButtonAttack = new Button();
        GroupBoxEnemy.SuspendLayout();
        GroupBoxPlayer.SuspendLayout();
        SuspendLayout();
        // 
        // ProgressBarEnemyHealth
        // 
        ProgressBarEnemyHealth.Location = new Point(54, 51);
        ProgressBarEnemyHealth.Name = "ProgressBarEnemyHealth";
        ProgressBarEnemyHealth.Size = new Size(100, 23);
        ProgressBarEnemyHealth.TabIndex = 0;
        // 
        // ProgressBarPlayerHealth
        // 
        ProgressBarPlayerHealth.Location = new Point(54, 51);
        ProgressBarPlayerHealth.Name = "ProgressBarPlayerHealth";
        ProgressBarPlayerHealth.Size = new Size(100, 23);
        ProgressBarPlayerHealth.TabIndex = 1;
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
        // TextBoxEnemyName
        // 
        TextBoxEnemyName.Location = new Point(6, 22);
        TextBoxEnemyName.Name = "TextBoxEnemyName";
        TextBoxEnemyName.ReadOnly = true;
        TextBoxEnemyName.Size = new Size(148, 23);
        TextBoxEnemyName.TabIndex = 4;
        // 
        // TextBoxPlayerName
        // 
        TextBoxPlayerName.Location = new Point(6, 22);
        TextBoxPlayerName.Name = "TextBoxPlayerName";
        TextBoxPlayerName.ReadOnly = true;
        TextBoxPlayerName.Size = new Size(148, 23);
        TextBoxPlayerName.TabIndex = 5;
        // 
        // GroupBoxEnemy
        // 
        GroupBoxEnemy.Controls.Add(TextBoxEnemyAC);
        GroupBoxEnemy.Controls.Add(LabelEnemyAC);
        GroupBoxEnemy.Controls.Add(TextBoxEnemyName);
        GroupBoxEnemy.Controls.Add(ProgressBarEnemyHealth);
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
        GroupBoxPlayer.Controls.Add(TextBoxPlayerName);
        GroupBoxPlayer.Controls.Add(ProgressBarPlayerHealth);
        GroupBoxPlayer.Controls.Add(LabelPlayerHealth);
        GroupBoxPlayer.Location = new Point(243, 12);
        GroupBoxPlayer.Name = "GroupBoxPlayer";
        GroupBoxPlayer.Size = new Size(185, 212);
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
        ButtonEndTurn.AutoSize = true;
        ButtonEndTurn.Location = new Point(87, 181);
        ButtonEndTurn.Name = "ButtonEndTurn";
        ButtonEndTurn.Size = new Size(75, 25);
        ButtonEndTurn.TabIndex = 8;
        ButtonEndTurn.Text = "End Turn";
        ButtonEndTurn.UseVisualStyleBackColor = true;
        ButtonEndTurn.Click += ButtonEndTurn_Click;
        // 
        // ButtonItem
        // 
        ButtonItem.Location = new Point(6, 183);
        ButtonItem.Name = "ButtonItem";
        ButtonItem.Size = new Size(75, 23);
        ButtonItem.TabIndex = 7;
        ButtonItem.Text = "Item";
        ButtonItem.UseVisualStyleBackColor = true;
        ButtonItem.Click += ButtonItem_Click;
        // 
        // ButtonAttack
        // 
        ButtonAttack.Location = new Point(6, 154);
        ButtonAttack.Name = "ButtonAttack";
        ButtonAttack.Size = new Size(75, 23);
        ButtonAttack.TabIndex = 6;
        ButtonAttack.Text = "Attack";
        ButtonAttack.UseVisualStyleBackColor = true;
        ButtonAttack.Click += ButtonAttack_Click;
        // 
        // CombatForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(440, 235);
        Controls.Add(GroupBoxPlayer);
        Controls.Add(GroupBoxEnemy);
        Name = "CombatForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Combat";
        Load += CombatForm_Load;
        GroupBoxEnemy.ResumeLayout(false);
        GroupBoxEnemy.PerformLayout();
        GroupBoxPlayer.ResumeLayout(false);
        GroupBoxPlayer.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private ProgressBar ProgressBarEnemyHealth;
    private ProgressBar ProgressBarPlayerHealth;
    private Label LabelPlayerHealth;
    private Label LabelEnemyHealth;
    private TextBox TextBoxEnemyName;
    private TextBox TextBoxPlayerName;
    private GroupBox GroupBoxEnemy;
    private GroupBox GroupBoxPlayer;
    private Button ButtonEndTurn;
    private Button ButtonItem;
    private Button ButtonAttack;
    private TextBox TextBoxEnemyAC;
    private Label LabelEnemyAC;
    private TextBox TextBoxPlayerAC;
    private Label LabelPlayerAC;
}