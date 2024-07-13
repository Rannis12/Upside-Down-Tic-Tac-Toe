
namespace B23_Ex05_AmitSwisa_315507723_RanNissan_207523531
{
    partial class GameWindow
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
            this.playerDataTable = new System.Windows.Forms.TableLayoutPanel();
            this.firstPlayerNameLabel = new System.Windows.Forms.Label();
            this.firstPlayerScoreLabel = new System.Windows.Forms.Label();
            this.secondPlayerNameLabel = new System.Windows.Forms.Label();
            this.secondPlayerScoreLabel = new System.Windows.Forms.Label();
            this.playerDataTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // playerDataTable
            // 
            this.playerDataTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerDataTable.ColumnCount = 2;
            this.playerDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerDataTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerDataTable.Controls.Add(this.firstPlayerNameLabel, 0, 0);
            this.playerDataTable.Controls.Add(this.firstPlayerScoreLabel, 0, 1);
            this.playerDataTable.Controls.Add(this.secondPlayerNameLabel, 1, 0);
            this.playerDataTable.Controls.Add(this.secondPlayerScoreLabel, 1, 1);
            this.playerDataTable.Location = new System.Drawing.Point(10, 433);
            this.playerDataTable.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.playerDataTable.Name = "playerDataTable";
            this.playerDataTable.RowCount = 2;
            this.playerDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerDataTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.playerDataTable.Size = new System.Drawing.Size(603, 54);
            this.playerDataTable.TabIndex = 0;
            // 
            // firstPlayerNameLabel
            // 
            this.firstPlayerNameLabel.AutoSize = true;
            this.firstPlayerNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPlayerNameLabel.Location = new System.Drawing.Point(2, 0);
            this.firstPlayerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstPlayerNameLabel.Name = "firstPlayerNameLabel";
            this.firstPlayerNameLabel.Size = new System.Drawing.Size(297, 27);
            this.firstPlayerNameLabel.TabIndex = 0;
            this.firstPlayerNameLabel.Text = "firstPlayerName";
            this.firstPlayerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstPlayerScoreLabel
            // 
            this.firstPlayerScoreLabel.AutoSize = true;
            this.firstPlayerScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstPlayerScoreLabel.Location = new System.Drawing.Point(2, 27);
            this.firstPlayerScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstPlayerScoreLabel.Name = "firstPlayerScoreLabel";
            this.firstPlayerScoreLabel.Size = new System.Drawing.Size(297, 27);
            this.firstPlayerScoreLabel.TabIndex = 1;
            this.firstPlayerScoreLabel.Text = "0";
            this.firstPlayerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondPlayerNameLabel
            // 
            this.secondPlayerNameLabel.AutoSize = true;
            this.secondPlayerNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondPlayerNameLabel.Location = new System.Drawing.Point(303, 0);
            this.secondPlayerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secondPlayerNameLabel.Name = "secondPlayerNameLabel";
            this.secondPlayerNameLabel.Size = new System.Drawing.Size(298, 27);
            this.secondPlayerNameLabel.TabIndex = 2;
            this.secondPlayerNameLabel.Text = "secondPlayerNameLabel";
            this.secondPlayerNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondPlayerScoreLabel
            // 
            this.secondPlayerScoreLabel.AutoSize = true;
            this.secondPlayerScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondPlayerScoreLabel.Location = new System.Drawing.Point(303, 27);
            this.secondPlayerScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.secondPlayerScoreLabel.Name = "secondPlayerScoreLabel";
            this.secondPlayerScoreLabel.Size = new System.Drawing.Size(298, 27);
            this.secondPlayerScoreLabel.TabIndex = 3;
            this.secondPlayerScoreLabel.Text = "0";
            this.secondPlayerScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 504);
            this.Controls.Add(this.playerDataTable);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(644, 551);
            this.MinimumSize = new System.Drawing.Size(644, 551);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.GameWindow_Load);
            this.playerDataTable.ResumeLayout(false);
            this.playerDataTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel playerDataTable;
        private System.Windows.Forms.Label firstPlayerNameLabel;
        private System.Windows.Forms.Label firstPlayerScoreLabel;
        private System.Windows.Forms.Label secondPlayerNameLabel;
        private System.Windows.Forms.Label secondPlayerScoreLabel;
    }
}