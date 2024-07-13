
namespace B23_Ex05_AmitSwisa_315507723_RanNissan_207523531
{
    partial class GameSettingsForm
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
            this.playersLabel = new System.Windows.Forms.Label();
            this.FirstPlayerLabel = new System.Windows.Forms.Label();
            this.textBoxFirstPlayer = new System.Windows.Forms.TextBox();
            this.checkBoxSecondPlayer = new System.Windows.Forms.CheckBox();
            this.textBoxSecondPlayer = new System.Windows.Forms.TextBox();
            this.boardLabel = new System.Windows.Forms.Label();
            this.m_RowsLabel = new System.Windows.Forms.Label();
            this.rowsNumBox = new System.Windows.Forms.NumericUpDown();
            this.colsNumBox = new System.Windows.Forms.NumericUpDown();
            this.m_ColsLabel = new System.Windows.Forms.Label();
            this.startGameButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsNumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Location = new System.Drawing.Point(13, 12);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(76, 24);
            this.playersLabel.TabIndex = 0;
            this.playersLabel.Text = "Players:";
            // 
            // FirstPlayerLabel
            // 
            this.FirstPlayerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstPlayerLabel.AutoSize = true;
            this.FirstPlayerLabel.Location = new System.Drawing.Point(47, 56);
            this.FirstPlayerLabel.Name = "FirstPlayerLabel";
            this.FirstPlayerLabel.Size = new System.Drawing.Size(82, 24);
            this.FirstPlayerLabel.TabIndex = 1;
            this.FirstPlayerLabel.Text = "Player 1:";
            // 
            // textBoxFirstPlayer
            // 
            this.textBoxFirstPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstPlayer.Location = new System.Drawing.Point(165, 53);
            this.textBoxFirstPlayer.Name = "textBoxFirstPlayer";
            this.textBoxFirstPlayer.Size = new System.Drawing.Size(150, 32);
            this.textBoxFirstPlayer.TabIndex = 2;
            // 
            // checkBoxSecondPlayer
            // 
            this.checkBoxSecondPlayer.AutoSize = true;
            this.checkBoxSecondPlayer.Location = new System.Drawing.Point(51, 98);
            this.checkBoxSecondPlayer.Name = "checkBoxSecondPlayer";
            this.checkBoxSecondPlayer.Size = new System.Drawing.Size(108, 28);
            this.checkBoxSecondPlayer.TabIndex = 3;
            this.checkBoxSecondPlayer.Text = "Player 2:";
            this.checkBoxSecondPlayer.UseVisualStyleBackColor = true;
            this.checkBoxSecondPlayer.CheckedChanged += new System.EventHandler(this.onSecondPlayerCheckboxCheckChange);
            // 
            // textBoxSecondPlayer
            // 
            this.textBoxSecondPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSecondPlayer.Enabled = false;
            this.textBoxSecondPlayer.Location = new System.Drawing.Point(165, 96);
            this.textBoxSecondPlayer.Name = "textBoxSecondPlayer";
            this.textBoxSecondPlayer.Size = new System.Drawing.Size(150, 32);
            this.textBoxSecondPlayer.TabIndex = 4;
            this.textBoxSecondPlayer.Text = "[Computer]";
            // 
            // boardLabel
            // 
            this.boardLabel.AutoSize = true;
            this.boardLabel.Location = new System.Drawing.Point(13, 145);
            this.boardLabel.Name = "boardLabel";
            this.boardLabel.Size = new System.Drawing.Size(66, 24);
            this.boardLabel.TabIndex = 5;
            this.boardLabel.Text = "Board:";
            // 
            // m_RowsLabel
            // 
            this.m_RowsLabel.AutoSize = true;
            this.m_RowsLabel.Location = new System.Drawing.Point(47, 186);
            this.m_RowsLabel.Name = "m_RowsLabel";
            this.m_RowsLabel.Size = new System.Drawing.Size(60, 24);
            this.m_RowsLabel.TabIndex = 6;
            this.m_RowsLabel.Text = "Rows:";
            // 
            // rowsNumBox
            // 
            this.rowsNumBox.Location = new System.Drawing.Point(112, 186);
            this.rowsNumBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rowsNumBox.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.rowsNumBox.Name = "rowsNumBox";
            this.rowsNumBox.Size = new System.Drawing.Size(53, 32);
            this.rowsNumBox.TabIndex = 7;
            this.rowsNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.rowsNumBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.rowsNumBox.ValueChanged += new System.EventHandler(this.onRowsOrColsInputValueChange);
            // 
            // colsNumBox
            // 
            this.colsNumBox.Location = new System.Drawing.Point(258, 186);
            this.colsNumBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.colsNumBox.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.colsNumBox.Name = "colsNumBox";
            this.colsNumBox.Size = new System.Drawing.Size(53, 32);
            this.colsNumBox.TabIndex = 9;
            this.colsNumBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colsNumBox.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.colsNumBox.ValueChanged += new System.EventHandler(this.onRowsOrColsInputValueChange);
            // 
            // m_ColsLabel
            // 
            this.m_ColsLabel.AutoSize = true;
            this.m_ColsLabel.Location = new System.Drawing.Point(193, 186);
            this.m_ColsLabel.Name = "m_ColsLabel";
            this.m_ColsLabel.Size = new System.Drawing.Size(51, 24);
            this.m_ColsLabel.TabIndex = 8;
            this.m_ColsLabel.Text = "Cols:";
            // 
            // startGameButton
            // 
            this.startGameButton.BackColor = System.Drawing.Color.White;
            this.startGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startGameButton.Location = new System.Drawing.Point(12, 241);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(345, 35);
            this.startGameButton.TabIndex = 10;
            this.startGameButton.Text = "Start!";
            this.startGameButton.UseVisualStyleBackColor = false;
            this.startGameButton.Click += new System.EventHandler(this.onStartGameButtonClick);
            // 
            // GameSettingsForm
            // 
            this.AcceptButton = this.startGameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 287);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.colsNumBox);
            this.Controls.Add(this.m_ColsLabel);
            this.Controls.Add(this.rowsNumBox);
            this.Controls.Add(this.m_RowsLabel);
            this.Controls.Add(this.boardLabel);
            this.Controls.Add(this.textBoxSecondPlayer);
            this.Controls.Add(this.checkBoxSecondPlayer);
            this.Controls.Add(this.textBoxFirstPlayer);
            this.Controls.Add(this.FirstPlayerLabel);
            this.Controls.Add(this.playersLabel);
            this.Font = new System.Drawing.Font("Open Sans Hebrew", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colsNumBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.Label FirstPlayerLabel;
        private System.Windows.Forms.TextBox textBoxFirstPlayer;
        private System.Windows.Forms.CheckBox checkBoxSecondPlayer;
        private System.Windows.Forms.TextBox textBoxSecondPlayer;
        private System.Windows.Forms.Label boardLabel;
        private System.Windows.Forms.Label m_RowsLabel;
        private System.Windows.Forms.NumericUpDown rowsNumBox;
        private System.Windows.Forms.NumericUpDown colsNumBox;
        private System.Windows.Forms.Label m_ColsLabel;
        private System.Windows.Forms.Button startGameButton;
    }
}