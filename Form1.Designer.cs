namespace worldChamps
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
            this.exitButton = new System.Windows.Forms.Button();
            this.Headline = new System.Windows.Forms.Label();
            this.teamOptions = new System.Windows.Forms.ListBox();
            this.teamLabel = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.results = new System.Windows.Forms.TextBox();
            this.winningsLabel = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(359, 372);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Headline
            // 
            this.Headline.Location = new System.Drawing.Point(341, 28);
            this.Headline.Name = "Headline";
            this.Headline.Size = new System.Drawing.Size(106, 45);
            this.Headline.TabIndex = 1;
            this.Headline.Text = "World Champs";
            this.Headline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teamOptions
            // 
            this.teamOptions.FormattingEnabled = true;
            this.teamOptions.Items.AddRange(new object[] {
            "Anaheim Angels",
            "Arizona Diamondbacks",
            "Atlanta Braves",
            "Baltimore Orioles",
            "Boston Americans",
            "Boston Braves",
            "Boston Red Sox",
            "Brooklyn Dodgers",
            "Chicago Cubs",
            "Chicago White Sox",
            "Cincinnati Reds",
            "Cleveland Indians",
            "Detroit Tigers",
            "Florida Marlins",
            "Kansas City Royals",
            "Los Angeles Dodgers",
            "Milwaukee Braves",
            "Minnesota Twins",
            "New York Giants",
            "New York Mets",
            "New York Yankees",
            "Oakland Athletics",
            "Philadelphia Athletics",
            "Philadelphia Phillies",
            "Pittsburgh Pirates",
            "St. Louis Cardinals",
            "Toronto Blue Jays",
            "Washington Senators"});
            this.teamOptions.Location = new System.Drawing.Point(344, 106);
            this.teamOptions.Name = "teamOptions";
            this.teamOptions.Size = new System.Drawing.Size(103, 69);
            this.teamOptions.TabIndex = 2;
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Location = new System.Drawing.Point(266, 106);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(73, 13);
            this.teamLabel.TabIndex = 3;
            this.teamLabel.Text = "Select Team :";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(359, 194);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 4;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // results
            // 
            this.results.Location = new System.Drawing.Point(347, 284);
            this.results.Name = "results";
            this.results.ReadOnly = true;
            this.results.Size = new System.Drawing.Size(100, 20);
            this.results.TabIndex = 5;
            // 
            // winningsLabel
            // 
            this.winningsLabel.AutoSize = true;
            this.winningsLabel.Location = new System.Drawing.Point(204, 284);
            this.winningsLabel.Name = "winningsLabel";
            this.winningsLabel.Size = new System.Drawing.Size(138, 13);
            this.winningsLabel.TabIndex = 6;
            this.winningsLabel.Text = "World Championships won :";
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(461, 372);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 23);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.winningsLabel);
            this.Controls.Add(this.results);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.teamLabel);
            this.Controls.Add(this.teamOptions);
            this.Controls.Add(this.Headline);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "World Champs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label Headline;
        private System.Windows.Forms.ListBox teamOptions;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox results;
        private System.Windows.Forms.Label winningsLabel;
        private System.Windows.Forms.Button Clear;
    }
}

