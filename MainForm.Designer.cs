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
            this.table_Layout_Panel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Player3_Score_Label = new System.Windows.Forms.Label();
            this.Player2_Score_Label = new System.Windows.Forms.Label();
            this.Player3_Name_Label = new System.Windows.Forms.Label();
            this.Player2_Name_Label = new System.Windows.Forms.Label();
            this.Player1_Name_Label = new System.Windows.Forms.Label();
            this.Player1_Score_Label = new System.Windows.Forms.Label();
            this.MainForm_Label = new System.Windows.Forms.FlowLayoutPanel();
            this.table_Layout_Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_Layout_Panel1
            // 
            this.table_Layout_Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.table_Layout_Panel1.ColumnCount = 3;
            this.table_Layout_Panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_Layout_Panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_Layout_Panel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.table_Layout_Panel1.Controls.Add(this.Player3_Score_Label, 2, 1);
            this.table_Layout_Panel1.Controls.Add(this.Player2_Score_Label, 1, 1);
            this.table_Layout_Panel1.Controls.Add(this.Player3_Name_Label, 2, 0);
            this.table_Layout_Panel1.Controls.Add(this.Player2_Name_Label, 1, 0);
            this.table_Layout_Panel1.Controls.Add(this.Player1_Name_Label, 0, 0);
            this.table_Layout_Panel1.Controls.Add(this.Player1_Score_Label, 0, 1);
            this.table_Layout_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_Layout_Panel1.Location = new System.Drawing.Point(0, 0);
            this.table_Layout_Panel1.Name = "table_Layout_Panel1";
            this.table_Layout_Panel1.RowCount = 2;
            this.table_Layout_Panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_Layout_Panel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.table_Layout_Panel1.Size = new System.Drawing.Size(584, 100);
            this.table_Layout_Panel1.TabIndex = 0;
            // 
            // Player3_Score_Label
            // 
            this.Player3_Score_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player3_Score_Label.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.Player3_Score_Label.Location = new System.Drawing.Point(391, 50);
            this.Player3_Score_Label.Name = "Player3_Score_Label";
            this.Player3_Score_Label.Size = new System.Drawing.Size(190, 50);
            this.Player3_Score_Label.TabIndex = 5;
            this.Player3_Score_Label.Text = "0";
            this.Player3_Score_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Player2_Score_Label
            // 
            this.Player2_Score_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player2_Score_Label.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.Player2_Score_Label.Location = new System.Drawing.Point(197, 50);
            this.Player2_Score_Label.Name = "Player2_Score_Label";
            this.Player2_Score_Label.Size = new System.Drawing.Size(188, 50);
            this.Player2_Score_Label.TabIndex = 4;
            this.Player2_Score_Label.Text = "0";
            this.Player2_Score_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Player3_Name_Label
            // 
            this.Player3_Name_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player3_Name_Label.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.Player3_Name_Label.Location = new System.Drawing.Point(391, 0);
            this.Player3_Name_Label.Name = "Player3_Name_Label";
            this.Player3_Name_Label.Size = new System.Drawing.Size(190, 50);
            this.Player3_Name_Label.TabIndex = 3;
            this.Player3_Name_Label.Text = "Player 3";
            this.Player3_Name_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Player2_Name_Label
            // 
            this.Player2_Name_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player2_Name_Label.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.Player2_Name_Label.Location = new System.Drawing.Point(197, 0);
            this.Player2_Name_Label.Name = "Player2_Name_Label";
            this.Player2_Name_Label.Size = new System.Drawing.Size(188, 50);
            this.Player2_Name_Label.TabIndex = 2;
            this.Player2_Name_Label.Text = "Player 2";
            this.Player2_Name_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Player1_Name_Label
            // 
            this.Player1_Name_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player1_Name_Label.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.Player1_Name_Label.Location = new System.Drawing.Point(3, 0);
            this.Player1_Name_Label.Name = "Player1_Name_Label";
            this.Player1_Name_Label.Size = new System.Drawing.Size(188, 50);
            this.Player1_Name_Label.TabIndex = 0;
            this.Player1_Name_Label.Text = "Player 1";
            this.Player1_Name_Label.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Player1_Score_Label
            // 
            this.Player1_Score_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Player1_Score_Label.Font = new System.Drawing.Font("Segoe UI Black", 16F);
            this.Player1_Score_Label.Location = new System.Drawing.Point(3, 50);
            this.Player1_Score_Label.Name = "Player1_Score_Label";
            this.Player1_Score_Label.Size = new System.Drawing.Size(188, 50);
            this.Player1_Score_Label.TabIndex = 1;
            this.Player1_Score_Label.Text = "0";
            this.Player1_Score_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm_Label
            // 
            this.MainForm_Label.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MainForm_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm_Label.Location = new System.Drawing.Point(0, 100);
            this.MainForm_Label.Name = "MainForm_Label";
            this.MainForm_Label.Size = new System.Drawing.Size(584, 261);
            this.MainForm_Label.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.MainForm_Label);
            this.Controls.Add(this.table_Layout_Panel1);
            this.Name = "MainForm";
            this.Text = "Snake";
            this.table_Layout_Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel table_Layout_Panel1;
        private System.Windows.Forms.FlowLayoutPanel MainForm_Label;
        private System.Windows.Forms.Label Player1_Name_Label;
        private System.Windows.Forms.Label Player1_Score_Label;
        private System.Windows.Forms.Label Player3_Score_Label;
        private System.Windows.Forms.Label Player2_Score_Label;
        private System.Windows.Forms.Label Player3_Name_Label;
        private System.Windows.Forms.Label Player2_Name_Label;
    }
}

