namespace Snake_Projekt
{
    partial class MainForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Player3_Score_Label = new System.Windows.Forms.Label();
            this.Player2_Score_Label = new System.Windows.Forms.Label();
            this.Player3_Name_Label = new System.Windows.Forms.Label();
            this.Player2_Name_Label = new System.Windows.Forms.Label();
            this.Player1_Name_Label = new System.Windows.Forms.Label();
            this.Player1_ScoreLabel = new System.Windows.Forms.Label();
            this.MainForm_Label = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.Player3_Score_Label, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Player2_Score_Label, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Player3_Name_Label, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Player2_Name_Label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Player1_Name_Label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Player1_ScoreLabel, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Player3_Score_Label
            // 
            this.Player3_Score_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player3_Score_Label.Location = new System.Drawing.Point(525, 50);
            this.Player3_Score_Label.Name = "Player3_Score_Label";
            this.Player3_Score_Label.Size = new System.Drawing.Size(256, 50);
            this.Player3_Score_Label.TabIndex = 5;
            this.Player3_Score_Label.Text = "0";
            this.Player3_Score_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Player2_Score_Label
            // 
            this.Player2_Score_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player2_Score_Label.Location = new System.Drawing.Point(264, 50);
            this.Player2_Score_Label.Name = "Player2_Score_Label";
            this.Player2_Score_Label.Size = new System.Drawing.Size(255, 50);
            this.Player2_Score_Label.TabIndex = 4;
            this.Player2_Score_Label.Text = "0";
            this.Player2_Score_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Player3_Name_Label
            // 
            this.Player3_Name_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player3_Name_Label.Location = new System.Drawing.Point(525, 0);
            this.Player3_Name_Label.Name = "Player3_Name_Label";
            this.Player3_Name_Label.Size = new System.Drawing.Size(256, 50);
            this.Player3_Name_Label.TabIndex = 3;
            this.Player3_Name_Label.Text = "Player 3";
            this.Player3_Name_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Player2_Name_Label
            // 
            this.Player2_Name_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player2_Name_Label.Location = new System.Drawing.Point(264, 0);
            this.Player2_Name_Label.Name = "Player2_Name_Label";
            this.Player2_Name_Label.Size = new System.Drawing.Size(255, 50);
            this.Player2_Name_Label.TabIndex = 2;
            this.Player2_Name_Label.Text = "Player 2";
            this.Player2_Name_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Player1_Name_Label
            // 
            this.Player1_Name_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player1_Name_Label.Location = new System.Drawing.Point(3, 0);
            this.Player1_Name_Label.Name = "Player1_Name_Label";
            this.Player1_Name_Label.Size = new System.Drawing.Size(255, 50);
            this.Player1_Name_Label.TabIndex = 0;
            this.Player1_Name_Label.Text = "Player 1";
            this.Player1_Name_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Player1_ScoreLabel
            // 
            this.Player1_ScoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player1_ScoreLabel.Location = new System.Drawing.Point(3, 50);
            this.Player1_ScoreLabel.Name = "Player1_ScoreLabel";
            this.Player1_ScoreLabel.Size = new System.Drawing.Size(255, 50);
            this.Player1_ScoreLabel.TabIndex = 1;
            this.Player1_ScoreLabel.Text = "0";
            this.Player1_ScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm_Label
            // 
            this.MainForm_Label.BackColor = System.Drawing.SystemColors.Highlight;
            this.MainForm_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm_Label.Location = new System.Drawing.Point(0, 100);
            this.MainForm_Label.Name = "MainForm_Label";
            this.MainForm_Label.Size = new System.Drawing.Size(784, 461);
            this.MainForm_Label.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.MainForm_Label);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Snake";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel MainForm_Label;
        private System.Windows.Forms.Label Player1_Name_Label;
        private System.Windows.Forms.Label Player1_ScoreLabel;
        private System.Windows.Forms.Label Player3_Score_Label;
        private System.Windows.Forms.Label Player2_Score_Label;
        private System.Windows.Forms.Label Player3_Name_Label;
        private System.Windows.Forms.Label Player2_Name_Label;
    }
}

