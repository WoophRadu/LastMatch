namespace LastMatch
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonLoadMatch = new System.Windows.Forms.Button();
            this.timerButtonLoadMatch = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelLoadMatch = new System.Windows.Forms.Label();
            this.textBoxLoadMatch = new System.Windows.Forms.TextBox();
            this.Played = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kills = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Assists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Deaths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MVPs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 382);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(24, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Idle";
            // 
            // buttonLoadMatch
            // 
            this.buttonLoadMatch.Location = new System.Drawing.Point(272, 5);
            this.buttonLoadMatch.Name = "buttonLoadMatch";
            this.buttonLoadMatch.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadMatch.TabIndex = 1;
            this.buttonLoadMatch.Text = "Load Match";
            this.buttonLoadMatch.UseVisualStyleBackColor = true;
            this.buttonLoadMatch.Click += new System.EventHandler(this.buttonLoadMatch_Click);
            // 
            // timerButtonLoadMatch
            // 
            this.timerButtonLoadMatch.Interval = 2000;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Played,
            this.Player,
            this.Kills,
            this.Assists,
            this.Deaths,
            this.MVPs,
            this.Score});
            this.dataGridView1.Location = new System.Drawing.Point(36, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(794, 225);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelLoadMatch
            // 
            this.labelLoadMatch.AutoSize = true;
            this.labelLoadMatch.Location = new System.Drawing.Point(12, 9);
            this.labelLoadMatch.Name = "labelLoadMatch";
            this.labelLoadMatch.Size = new System.Drawing.Size(54, 13);
            this.labelLoadMatch.TabIndex = 3;
            this.labelLoadMatch.Text = "Steam ID:";
            // 
            // textBoxLoadMatch
            // 
            this.textBoxLoadMatch.Enabled = false;
            this.textBoxLoadMatch.Location = new System.Drawing.Point(72, 6);
            this.textBoxLoadMatch.Name = "textBoxLoadMatch";
            this.textBoxLoadMatch.Size = new System.Drawing.Size(194, 20);
            this.textBoxLoadMatch.TabIndex = 4;
            this.textBoxLoadMatch.Text = "Hardcoded for Alive eSports RO";
            // 
            // Played
            // 
            this.Played.FillWeight = 50F;
            this.Played.HeaderText = "Played?";
            this.Played.Name = "Played";
            this.Played.Width = 50;
            // 
            // Player
            // 
            this.Player.FillWeight = 150F;
            this.Player.HeaderText = "Player";
            this.Player.Name = "Player";
            this.Player.ReadOnly = true;
            this.Player.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Player.Width = 150;
            // 
            // Kills
            // 
            this.Kills.HeaderText = "Kills";
            this.Kills.Name = "Kills";
            this.Kills.ReadOnly = true;
            this.Kills.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Assists
            // 
            this.Assists.HeaderText = "Assists";
            this.Assists.Name = "Assists";
            this.Assists.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Deaths
            // 
            this.Deaths.HeaderText = "Deaths";
            this.Deaths.Name = "Deaths";
            this.Deaths.ReadOnly = true;
            this.Deaths.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // MVPs
            // 
            this.MVPs.HeaderText = "MVPs";
            this.MVPs.Name = "MVPs";
            this.MVPs.ReadOnly = true;
            // 
            // Score
            // 
            this.Score.HeaderText = "Score";
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 404);
            this.Controls.Add(this.textBoxLoadMatch);
            this.Controls.Add(this.labelLoadMatch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonLoadMatch);
            this.Controls.Add(this.labelStatus);
            this.Name = "Form1";
            this.Text = "LastMatch";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonLoadMatch;
        private System.Windows.Forms.Timer timerButtonLoadMatch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelLoadMatch;
        private System.Windows.Forms.TextBox textBoxLoadMatch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Played;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kills;
        private System.Windows.Forms.DataGridViewTextBoxColumn Assists;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deaths;
        private System.Windows.Forms.DataGridViewTextBoxColumn MVPs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}

