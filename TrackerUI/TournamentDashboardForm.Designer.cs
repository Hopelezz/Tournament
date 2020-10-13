namespace TournamentDashboardForm
{
    partial class tournamentDashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tournamentDashboardForm));
            this.createTournamentButton = new System.Windows.Forms.Button();
            this.viewTournamentButton = new System.Windows.Forms.Button();
            this.loadTournamentDropdown = new System.Windows.Forms.ComboBox();
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadTournamentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createTournamentButton
            // 
            this.createTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.createTournamentButton.Location = new System.Drawing.Point(46, 367);
            this.createTournamentButton.Name = "createTournamentButton";
            this.createTournamentButton.Size = new System.Drawing.Size(421, 56);
            this.createTournamentButton.TabIndex = 6;
            this.createTournamentButton.Text = "Create Tournament";
            this.createTournamentButton.UseVisualStyleBackColor = true;
            // 
            // viewTournamentButton
            // 
            this.viewTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.viewTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.viewTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.viewTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.viewTournamentButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.viewTournamentButton.Location = new System.Drawing.Point(46, 294);
            this.viewTournamentButton.Name = "viewTournamentButton";
            this.viewTournamentButton.Size = new System.Drawing.Size(421, 56);
            this.viewTournamentButton.TabIndex = 6;
            this.viewTournamentButton.Text = "View Tournament";
            this.viewTournamentButton.UseVisualStyleBackColor = true;
            // 
            // loadTournamentDropdown
            // 
            this.loadTournamentDropdown.FormattingEnabled = true;
            this.loadTournamentDropdown.Location = new System.Drawing.Point(46, 232);
            this.loadTournamentDropdown.Name = "loadTournamentDropdown";
            this.loadTournamentDropdown.Size = new System.Drawing.Size(421, 45);
            this.loadTournamentDropdown.TabIndex = 2;
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentDashboardLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(12, 34);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(488, 62);
            this.tournamentDashboardLabel.TabIndex = 0;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadTournamentLabel
            // 
            this.loadTournamentLabel.AutoSize = true;
            this.loadTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loadTournamentLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.loadTournamentLabel.Location = new System.Drawing.Point(119, 170);
            this.loadTournamentLabel.Name = "loadTournamentLabel";
            this.loadTournamentLabel.Size = new System.Drawing.Size(274, 45);
            this.loadTournamentLabel.TabIndex = 1;
            this.loadTournamentLabel.Text = "Load Tournament";
            // 
            // tournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(527, 470);
            this.Controls.Add(this.loadTournamentLabel);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Controls.Add(this.loadTournamentDropdown);
            this.Controls.Add(this.viewTournamentButton);
            this.Controls.Add(this.createTournamentButton);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "tournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createTournamentButton;
        private System.Windows.Forms.Button viewTournamentButton;
        private System.Windows.Forms.ComboBox loadTournamentDropdown;
        private System.Windows.Forms.Label tournamentDashboardLabel;
        private System.Windows.Forms.Label loadTournamentLabel;
    }
}

